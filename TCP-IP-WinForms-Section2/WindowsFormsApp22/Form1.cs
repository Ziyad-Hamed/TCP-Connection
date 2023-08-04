using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        Socket client;
        byte[] buf; // << Array for Data Sending & Reciving 

        public Form1()
        {
            InitializeComponent();
            buf = new byte[1024];
            IpTxt.Text = GetLocalIp();
            PortTxt.Text = "8000";

        }
        string GetLocalIp()  //<< Method to Get LocalIp From Host
        {
            string hostname = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(hostname);
            return ipHost.AddressList[ipHost.AddressList.Length -1].ToString();

        }
        void UpdateGUI(bool isRunning)
        {
            StartBtn.Enabled = !isRunning;
            StopBtn.Enabled = isRunning;
            SendBtn.Enabled = isRunning;

            statusLb1.Text = isRunning ? "Connected" : "Disconnected";
            statusLb1.ForeColor = isRunning ? Color.Green : Color.Red;

            IpTxt.Enabled = !isRunning;
            PortTxt.Enabled = !isRunning;
            
        }

        void ConnectToServer()
        {
            IPAddress serverIp;
            if (!IPAddress.TryParse(IpTxt.Text.Trim(), out serverIp)) 
            {
                MessageBox.Show("Please, Enter A Valid IP Address In Correct Format");
                IpTxt.Focus();
                return;
            }

            int serverPortNumber;
            
            if (! int.TryParse(PortTxt.Text.Trim(), out serverPortNumber))
            {
                MessageBox.Show("Pleasem Enter A Valid Port Number In Correct Format");
                PortTxt.Focus();
                return;
            }
            //Create Socket
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Create Address
            IPEndPoint serverAddress = new IPEndPoint(serverIp,serverPortNumber);
            try
            {
                client.Connect(serverAddress);

                client.BeginReceive(buf, 0, buf.Length, SocketFlags.None, new AsyncCallback(OnDataRecived), null);
                UpdateGUI(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnDataRecived(IAsyncResult ar)
        {
            try
            {
                if (client!=null&&client.Connected)
                {
                    int byteCount = client.EndReceive(ar);
                    if (byteCount==0)
                    {
                        this.Invoke(new Action(delegate
                        {
                            DisConnectFromServer();
                        }));

                    }
                    else
                    {
                        string msg = Encoding.ASCII.GetString(buf, 0, byteCount);
                        LogTxt.Invoke(new Action(delegate
                        {
                            LogTxt.AppendText(msg);
                        }));
                        client.BeginReceive(buf, 0, buf.Length, SocketFlags.None, new AsyncCallback(OnDataRecived), null);
                    }
                }
            }
            catch (Exception)
            {
                this.Invoke(new Action(delegate
                {
                    DisConnectFromServer();
                }));
            }
        }
        private void DisConnectFromServer()
        {
            if (client!=null&&client.Connected)
            {
                client.Disconnect(false);
                client.Close();
                client = null;

                UpdateGUI(false);
            }
        }


        private void button1_Click(object sender, EventArgs e) //Disconnect
        {
            DisConnectFromServer();
        }

        private void button2_Click(object sender, EventArgs e) //Connect
        {
            ConnectToServer();
        }

        private void button3_Click(object sender, EventArgs e) //send
        {
            if (MsgTxt.Text.Trim()=="")
            {
                MessageBox.Show("Please Insert Message First");
                MsgTxt.Focus();
                return;

            }
            byte[] bufData = Encoding.ASCII.GetBytes("Client : " + MsgTxt.Text.Trim() + " " + Environment.NewLine);

            if (client!=null&&client.Connected)
            {
                client.Send(bufData);
                LogTxt.AppendText("Client : " + MsgTxt.Text.Trim() + " " + Environment.NewLine);
                MsgTxt.Text = "";

            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnectFromServer();
        }

        private void statusLb1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
