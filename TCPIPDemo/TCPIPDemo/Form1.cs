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
using MySql.Data.MySqlClient;


namespace TCPIPDemo
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string Server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += string.Format(DateTime.Now +" : "+ "Message Received from Client- " + e.MessageString) + Environment.NewLine;
                //String toSendMsg = "Ok Google !" + e.MessageString;

                String prodNum = e.MessageString.Remove(e.MessageString.Length - 1);
                String prodName;
                //MessageBox.Show(prodNum);
                string query = "SELECT name FROM products where id="+prodNum;
                var cmd = new MySqlCommand(query, connection);
                try
                {
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        prodName = reader.GetString(0);
                    }
                    else
                    {
                        prodName = "Product not found";
                    }


                    reader.Close();



                }
                catch (Exception e1){
                    prodName = "Something went wrong."+e1 ;
                }

                //while (reader.Read())
                //{
                //    MessageBox.Show(reader.GetString(0));
                //}


                e.ReplyLine(string.Format(prodName));
                txtStatus.Text += string.Format(DateTime.Now + " : " + "Message Sent to Client- " + prodName) + Environment.NewLine;
            });
            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (connection.State.ToString() == "Open")
            {
                txtStatus.Text += DateTime.Now + " : " + "Server starting" + Environment.NewLine;
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
                server.Start(ip, Convert.ToInt32(txtPort.Text));
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please connect to Database first.");
            }




        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                server.Stop();
                txtStatus.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            btnStart.Enabled = false;
            btnStop.Enabled = false;

            btnDBDisconnect.Enabled = false;

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            txtStatus.SelectionStart = txtStatus.Text.Length;
            txtStatus.ScrollToCaret();
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            Server = txtDBServer.Text;
            database = txtDBName.Text;
            user = txtDBUid.Text;
            password = txtDBPwd.Text;
            port = txtDBPort.Text;
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", Server, port, user, password, database, sslM);
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                txtStatus.Text += string.Format(DateTime.Now + " : " + "----DB Connection Succesful---") + Environment.NewLine;
                btnDBConnect.Enabled = false;
                btnStart.Enabled = true;
                btnDBDisconnect.Enabled = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }

        }

        private void btnDBDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            btnDBConnect.Enabled = true;
            btnStart.Enabled = false;
            btnDBDisconnect.Enabled = false;

        }

        private void btnClearlog_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "";
        }
    }
}