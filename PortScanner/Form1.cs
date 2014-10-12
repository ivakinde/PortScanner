using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PortScanner
{
    public partial class MainForm : Form
    {
        //define List to keep hostnames data
        List<string> hostlist = new List<string>();
        
        //define protocol type (tcp/udp)
        private string proto_type;

        public MainForm()
        {
            InitializeComponent();
        }

        //Scan button action
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            //clear text box
            richTxtScreen.Clear();
            //parse port number String -> Int
            int portNumber = Int32.Parse(txtPortNumber.Text);
            //protocol selection
            if (rdnBtnTCP.Checked)
            {
                proto_type = "tcp";
            }
            else if (rdnBtnUDP.Checked)
            {
                proto_type = "udp";
            }
            //List iteration and connect to remote host
            foreach (string item in hostlist)
            {
                Host.host = item;
                Host.port = portNumber;
                richTxtScreen.AppendText(Host.Connect(proto_type) + "\n");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //radio button initial configuration
            if (txtPortNumber.Text=="")
            {
                btnStartScan.Enabled = false;
            }
        }

        private void txtPortNumber_TextChanged(object sender, EventArgs e)
        {
            btnStartScan.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load data from txt file
            richTxtScreen.Text = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT files|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filename = openFile.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            hostlist.Add(line);
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error reading file!");
                }
            }
        }

        private void rdnBtnTCP_CheckedChanged(object sender, EventArgs e)
        {
            rdnBtnUDP.Checked = false;

        }

        private void rdnBtnUDP_CheckedChanged(object sender, EventArgs e)
        {
            rdnBtnTCP.Checked = false;

        }
    }
}
