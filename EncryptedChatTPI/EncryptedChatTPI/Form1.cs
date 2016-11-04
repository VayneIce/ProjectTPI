using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EncryptedChatTPI
{

    public partial class Form1 : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        [DllImport("gdi32.dll")]

        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont,uint cbfont,IntPtr pdv,[In]ref uint pcFonts);

        FontFamily ff;
        Font font;        
        Random rnd = new Random();       
        Socket sck;
        EndPoint epLocal, epRemote;
        ColorDialog ColorDialogBack = new ColorDialog();
        ColorDialog ColorDialogText = new ColorDialog();        

        public Form1()
        {
            InitializeComponent();
            desObj = Rijndael.Create();

            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
           
            //Get Local IP
            txtLocalIP.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();
        }

        byte[] buffer;
        int i = 0;
        int ii = 0;
        public const string LocalHostIP = "127.0.0.1";
        int go;

        string cipherData;
        byte[] cipherbytes;
        byte[] plainbytes;
        byte[] plainbytes2;
        byte[] plainKey;

        SymmetricAlgorithm desObj;

        //Load DIGITAL FONT FOR CLOCK AND DATE
        private void loadFont()
        {
            byte[] fontArray = EncryptedChatTPI.Properties.Resources.digital_7;
            int dataLength = EncryptedChatTPI.Properties.Resources.digital_7.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f,FontStyle.Bold);
        }            

        //ALLOCATES FONT
        private void AllocFont(Font f,Control c,float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }      

        //FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {             
            loadFont();
            AllocFont(font, this.lblTime, 20);
            AllocFont(font, this.lblDate, 20);
           
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }


        //DATE AND TIME 
        private void t_Tick(object sender, EventArgs e)
        {        
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        
        //GET LOCAL IP
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return LocalHostIP;
        }


        //CONNECT BUTTON
        private void btnConnect_Click(object sender, EventArgs e)
        {
            int parsedValue;
            int parsedValue2;

            try
            {
                if ((txtMyName.Text != txtFriendName.Text) && (!int.TryParse(txtMyName.Text, out parsedValue2)) && (!int.TryParse(txtFriendName.Text, out parsedValue2)))
                {
                    if ((txtPort.Text != "") && (int.TryParse(txtPort.Text, out parsedValue)) && (txtLocalIP.Text != "") && (txtRemoteIP.Text != "") && (txtMyName.Text != "") && (txtFriendName.Text != "") && (parsedValue > 1024) && (parsedValue < 65536)||(txtPort.Text=="(Default)"))
                    {
                        if(txtPort.Text ==("(Default)"))
                        {
                            //binding socket
                            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text),1234);
                            sck.Bind(epLocal);

                            //Connecting to remote IP
                            epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text),1234);
                            sck.Connect(epRemote);
                        }
                        else
                        { //binding socket
                            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtPort.Text));
                            sck.Bind(epLocal);

                            //Connecting to remote IP
                            epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), Convert.ToInt32(txtPort.Text));
                            sck.Connect(epRemote);
                        }
                       
                        
                        //Listening the specific port 
                        buffer = new byte[5500];
                        sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                        btnConnect.Visible = false;
                        lblConnected.Visible = true;
                        lblNotConnected.Visible = false;
                        txtLocalIP.ReadOnly = true;
                        txtRemoteIP.ReadOnly = true;
                        txtPort.ReadOnly = true;
                        txtMyName.ReadOnly = true;
                        txtFriendName.ReadOnly = true;
                        txtMessage.Enabled = true;
                        txtMessage.Focus();
                        go = 1;

                        tabControl.SelectedTab = tabPageChat;
                        tabControl.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters");
                    }

                }
                else
                {
                    MessageBox.Show("Enter different names");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //SEND ENTER
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(e.KeyChar) == 13)&&(txtMessage.Text != ""))
                {

                    byte[] sendingMessage = new byte [5500];

                    cipherData = txtMessage.Text;

                    plainbytes = new byte[cipherData.Length];
               
                    plainbytes = Encoding.ASCII.GetBytes(cipherData);               

                    plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
                    desObj.Key = plainKey;

                    //Choose object
                    desObj.Mode = CipherMode.CBC;
                    desObj.Padding = PaddingMode.PKCS7;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, desObj.CreateEncryptor(), CryptoStreamMode.Write);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                    cs.Close();
                    cipherbytes = ms.ToArray();
                    ms.Close();          

                    sendingMessage = cipherbytes;                

                    //Sending the encoded message
                    sck.Send(sendingMessage);

                    //Adding to the Log 
                    if ((i == 0) && (Log.Text == ""))
                    {
                        Log.Text += "[" + txtMyName.Text + "]: " + txtMessage.Text;
                        txtMessage.Clear();
                        txtMessage.Focus();
                        btnSend.Enabled = false;
                        i = 1;
                    }
                    else
                    {
                        Log.Text += "\n" + "[" + txtMyName.Text + "]: " + txtMessage.Text;
                        txtMessage.Clear();
                        txtMessage.Focus();
                        btnSend.Enabled = false;
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // BUTTON SEND
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] sendingMessage = new byte[5500];

                cipherData = txtMessage.Text;

                plainbytes = new byte[cipherData.Length];
        
                plainbytes = Encoding.ASCII.GetBytes(cipherData);              

                plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
                desObj.Key = plainKey;

                //Choose object
                desObj.Mode = CipherMode.CBC;
                desObj.Padding = PaddingMode.PKCS7;
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, desObj.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(plainbytes, 0, plainbytes.Length);
                cs.Close();
                cipherbytes = ms.ToArray();
                ms.Close();
                
                sendingMessage = cipherbytes;            

                //Sending the encoded message
                sck.Send(sendingMessage);

                //Adding to the Log 
                if ((i == 0) && (Log.Text == ""))
                {
                    Log.Text += "[" + txtMyName.Text + "]: " + txtMessage.Text;
                    txtMessage.Clear();
                    txtMessage.Focus();
                    btnSend.Enabled = false;
                    i = 1;
                }
                else
                {
                    Log.Text += "\n" + "[" + txtMyName.Text + "]: " + txtMessage.Text;
                    txtMessage.Clear();
                    txtMessage.Focus();
                    btnSend.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //MESSAGE CALL BACK
        private void MessageCallBack(IAsyncResult aResult)
        {         
            try
            {
                string recivedMessage;
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if(size >0)
                {

                    byte[] receivedData = new byte[5500];

                    //BYTES : aResult.AsyncState;
                    //receivedData = ObjectToByteArray(aResult.AsyncState);
                    receivedData = (byte[])aResult.AsyncState;

                    MemoryStream ms1 = new MemoryStream(receivedData);
                    CryptoStream cs1 = new CryptoStream(ms1, desObj.CreateDecryptor(), CryptoStreamMode.Read);

                    cs1.Read(receivedData, 0, receivedData.Length);
                    plainbytes2 = ms1.ToArray();              

                    cs1.Close();
                    ms1.Close();                  

                    recivedMessage = Encoding.ASCII.GetString(receivedData);



                    //Adding this message into Log                          
                    if ((ii == 0) && (Log.Text == ""))
                    {
                        Log.Text += "[" + txtFriendName.Text + "]: " + recivedMessage;
                        ii = 1;
                    }
                    else
                    {
                        Log.Text += "\n" + "[" + txtFriendName.Text + "]: " + recivedMessage;
                    }

                }                         
         
                byte [] buffer = new byte[5500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        
     
        
        //*****************************************************************************************************************************


        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            btnSend.Image = Image.FromFile("../SendBtn3.png");
        }


        private void btnSend_MouseUp(object sender, MouseEventArgs e)
        {
            btnSend.Image = Image.FromFile("../SendBtn2.png");
        }  
             

        private void chatBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialogBack.ShowDialog() == DialogResult.OK)
                Log.BackColor = ColorDialogBack.Color;
        }


        private void chatTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialogBack.ShowDialog() == DialogResult.OK)
                Log.ForeColor = ColorDialogBack.Color;

        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright ©  2016 Daniele Pavesi, Iulian Zorila, Simone Cavalca, Ramandeep Singh & Davide Cattani");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMessage.Text != "") 
                btnSend.Enabled = true;
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if ((tabControl.SelectedIndex == 1))
            {
                if (go != 1)
                {
                    MessageBox.Show("Enter data first");
                    tabControl.SelectedTab = tabPageConfig;
                    tabControl.SelectedIndex = 0;
                }
                else
                {
                    tabControl.SelectedTab = tabPageChat;
                    tabControl.SelectedIndex = 1;                    
                }
            }

        }


        //BUTTON CLOSE
        private void CloseBox_Click(object sender, EventArgs e)
        {                  
            if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CloseBox_MouseEnter(object sender, EventArgs e)
        {
            CloseBox.Image = Image.FromFile("../btnCloseHover.png");
        }

        private void CloseBox_MouseLeave(object sender, EventArgs e)
        {
            CloseBox.Image = Image.FromFile("../btnClose.png");
        }


        //MOVEMENT MANAGEMENT     
        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
            Cursor.Current = Cursors.Hand;
        }

        private void menuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
            Cursor.Current = Cursors.Default;
        }

        private void menuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
                Cursor.Current = Cursors.Hand;
            }
        }
    

        //TXT MESSAGE MANAGEMENT     
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMessage.Text != "") 
            {
                btnSend.Enabled = true;                
            }
            else
            {
                btnSend.Enabled = false;
            }            
        }

        //ESCAPE PRESS
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }

                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
