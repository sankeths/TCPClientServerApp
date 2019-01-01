using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient Client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;

            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;
            btnConnect.Enabled = false;
            try
            {
                Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
                txtStatus.Text += DateTime.Now +" : " + "-----Connected-----" + Environment.NewLine;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
                txtStatus.Text += DateTime.Now + " : " + "-----Error in Connection-----" + Environment.NewLine;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;

            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += DateTime.Now + " : "  + "Message Received from Server - " + e.MessageString+Environment.NewLine;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtStatus.Text += DateTime.Now + " : " + "Message Sent to Server- " + txtMessage.Text + Environment.NewLine;
            Client.WriteLineAndGetReply( txtMessage.Text, TimeSpan.FromSeconds(0));


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            txtStatus.Text += DateTime.Now + " : " + "-----Disconnected-----" +Environment.NewLine;
            btnSend.Enabled = false;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            txtStatus.SelectionStart = txtStatus.Text.Length;
            txtStatus.ScrollToCaret();
        }

        private void btnClearlog_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "";
        }
    }
}