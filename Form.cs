using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IconChanger
{
    public partial class Form : System.Windows.Forms.Form
    {


        private bool found = false;
        private UInt16 port { get; set; }
        private String token { get; set; }

        private const String _LocalBaseUrl = @"https://127.0.0.1:{0}/{1}";

        private WebClient Client = new WebClient();

        private void SetHeaders()
        {
            Client.Headers.Clear();
            Client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            Client.Headers.Add(HttpRequestHeader.Accept, "application/json");

            String username = "riot";
            String password = token;
            String hash = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            Client.Headers.Add(HttpRequestHeader.Authorization, $"Basic {hash}");
        }

        public Form()
        {
            InitializeComponent();
            lblStatus.Text = @"Waiting/Searching for League Client...";
            txtInput.Enabled = false;

            
            timer.Start();
        }

        private void TxtLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://share.aecx.cc/LxlSRe");
        }

        private void TxtCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://aecx.cc");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("LeagueClientUx");
            if (!found && pname.Length > 0)
            {
                // Client is running
                String CLI = Program.GetCommandLine(pname[0]);

                // Parse the CLI call
                String key = null;
                String val = null;

                foreach (String param in CLI.Split(@""" """.ToCharArray()))
                {
                    try
                    {
                        key = param.Split('=')[0];
                        val = param.Split('=')[1];
                        if (key == @"--remoting-auth-token")
                        {
                            token = val;
                        }
                        else if (key == @"--app-port")
                        {
                            port = UInt16.Parse(val);
                        }

                        if (token != null && port != 0)
                            break;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }


                found = true;

                lblStatus.Text = @"League client attached!";
                txtInput.Enabled = true;

                richTextBox1.Text += "port: " + port + "\r\ntoken: " + token + "\r\n";

                return;
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            try
            {
                int iconID = -1;

                if(!int.TryParse(txtInput.Text, out iconID))
                {
                    throw new Exception("Invalid ID format. Please use whole natural numbers!");
                }

                if(iconID < 0)
                {
                    throw new Exception("Invalid ID. Make sure it's >= 0");
                }

                SetHeaders();
                String iconAPIpath = @"lol-summoner/v1/current-summoner/icon";
                String url = String.Format(_LocalBaseUrl, port, iconAPIpath);

                String Body = "{\r\n" + @"""profileIconId"": " + iconID + "\r\n}";

                richTextBox1.Text += Client.Headers.ToString();
                richTextBox1.Text += "PUT " + url;
                richTextBox1.Text += "\r\n" + Body + "\r\n";

                ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                Client.UploadData(url, "PUT", ASCIIEncoding.ASCII.GetBytes(Body));
                
            }
            catch(Exception ex)
            {
                richTextBox1.Text += $"Exception at {ex.Source} :: {ex.Message}\r\n";                
            }
        }

        private void ToggleLog_CheckedChanged(object sender, EventArgs e)
        {
            if(ToggleLog.Checked)
            {
                this.Height = 550;
            }
            else
            {
                this.Height = 140;
            }
        }

        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
    }
}
