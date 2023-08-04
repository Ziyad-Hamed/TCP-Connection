using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {

        Socket MainSocket;
        List<Socket> workerSockets = new List<Socket>();
        public Form1()
        {
            InitializeComponent();
            IpTxt.Text = GetLocalIp();
            PortTxt.Text = "8000";
        }
        string GetLocalIp()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry iphost = Dns.GetHostByName(hostname);
            return iphost.AddressList[iphost.AddressList.Length -1].ToString();
        
        }

        void UpdateGUI(bool isRunning)
        {
            StartBtn.Enabled = !isRunning;
            StopBtn.Enabled = isRunning;
            SendBtn.Enabled = isRunning;

            toolStripStatusLabel1.Text = isRunning ? "Start" : "Stop";
            toolStripStatusLabel1.ForeColor = isRunning ? Color.Green : Color.Red;

            IpTxt.Enabled = !isRunning;
            PortTxt.Enabled = !isRunning;
        }

        void StartServer ()
        {
            IPAddress ServerIp;
            if (!IPAddress.TryParse(IpTxt.Text.Trim(), out ServerIp))
            {
                MessageBox.Show("Please , Enter a Valid IpAddress in the Coreect Form");
                IpTxt.Focus();
                return;

            }

            int ServerPortNumber;
            if (!int.TryParse(PortTxt.Text.Trim(), out ServerPortNumber))
            {
                MessageBox.Show("Please , Enter a Valid Port Number in the Coreect Form");
                PortTxt.Focus();
                return;
            }
            MainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ServerAddress = new IPEndPoint(ServerIp,ServerPortNumber);
            MainSocket.Bind(ServerAddress);
            MainSocket.Listen(5);
            MainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

            UpdateGUI(true);

        }
        private void OnClientConnect(IAsyncResult ar)
        {
            try
            {
                if (MainSocket!=null)
                {
                    Socket Worker = MainSocket.EndAccept(ar);
                    workerSockets.Add(Worker);
                    waitingForData(Worker);
                    MainSocket.BeginAccept(new AsyncCallback(OnClientConnect),null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void waitingForData(Socket Worker)
        {
            if (Worker!=null&&Worker.Connected)
            {
                SocketPacket socketPacket = new SocketPacket(Worker);
                IAsyncResult ar = Worker.BeginReceive(socketPacket.buf, 0, socketPacket.buf.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), socketPacket);
                
            }
        }

        private void OnDataReceived (IAsyncResult ar)
        {
            try
            {
                SocketPacket socketPacket = (SocketPacket)ar.AsyncState;
                if (socketPacket.Socket!=null&&socketPacket.Socket.Connected)
                {
                    int byteCount =socketPacket.Socket.EndReceive(ar);
                    if (byteCount==0)
                    {
                        socketPacket.Socket.Close();
                    }
                    else
                    {
                        string msg = Encoding.ASCII.GetString(socketPacket.buf, 0, byteCount);

                        LogTxt.Invoke(new Action(delegate
                        {
                            LogTxt.AppendText(msg);
                        }));

                        socketPacket.Socket.BeginReceive(socketPacket.buf, 0, socketPacket.buf.Length, SocketFlags.None, new AsyncCallback(OnDataReceived), socketPacket);

                    }
                }
            }
            catch{}
        }

        private void StopServer()
        {
            if (MainSocket!=null)
            {
                MainSocket.Close();
                MainSocket = null;
                foreach (Socket Worker in workerSockets)
                {
                    Worker.Close();
                }
                workerSockets.Clear();
                UpdateGUI(false);
            }
        }

        private void SendMessage()
        {
            if (MsgTxt.Text.Trim()=="")
            {
                MessageBox.Show("Please Enter Your Message First");
                MsgTxt.Focus();
                return;
            }
            byte[] buf = Encoding.ASCII.GetBytes("Server : " + MsgTxt.Text.Trim() + " " + Environment.NewLine);
            foreach (Socket Worker in workerSockets)
            {
                if (Worker!=null&&Worker.Connected)
                {
                    Worker.Send(buf);
                    LogTxt.AppendText("Server : " + MsgTxt.Text.Trim() + " " + Environment.NewLine);
                    MsgTxt.Text = "";
                }
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void MsgTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
