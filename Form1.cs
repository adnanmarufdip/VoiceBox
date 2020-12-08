using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.IO;


namespace WinMailClientApp
{
    public partial class Form1 : Form
    {
        public static string user;
        public static string upass;

        public Form1()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            string Folder = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData";
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
                File.WriteAllText(Path.Combine(Folder, "User_Info.txt"), null);
                string Txt = "[UserInfo]\r\nus:\r\n\r\nps:\r\n\r\n-.-";
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                txt.Write(Txt);
                txt.Close();
            }
            
        }

        void mail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(userName.Text);
                mail.To.Add(userName.Text);
                mail.Subject = "Verification";
                mail.Body = "App logged in";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(userName.Text, passWord.Text);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                user = userName.Text;
                upass = passWord.Text;
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
                logError.Visible = false;
            
            }

            catch (Exception ex)
            {
                //MessageBox.Show("You have entered an invalid username or password");
                logError.Visible = true;
            }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userName_Enter_1(object sender, EventArgs e)
        {
            userName.Text = String.Empty;
            userName.ForeColor = System.Drawing.Color.Gray;
            logError.Visible = false;
        }

        private void passWord_Enter_1(object sender, EventArgs e)
        {
            passWord.Text = String.Empty;
            passWord.isPassword = true;
            passWord.ForeColor = System.Drawing.Color.Gray;
            logError.Visible = false;
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            bool NetCon = NetworkInterface.GetIsNetworkAvailable();
            if (NetCon == false)
            {
                MessageBox.Show("Check your net connection");
            }
            else if (NetCon == true)
            {
                mail();
                
                if (btnCheck.Checked == true && logError.Visible == false)
                {
                    string us, ps;
                    us = userName.Text.ToString();
                    ps = passWord.Text.ToString();
                    string Txt = "[UserInfo]\r\nus:\r\n" + us + "\r\nps:\r\n" + ps + "\r\n-.-";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                    txt.Write(Txt);
                    txt.Close();
                }
                else if (btnCheck.Checked == false)
                {
                    string Txt = "[UserInfo]\r\nus:\r\n\r\nps:\r\n\r\n-.-";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                    txt.Write(Txt);
                    txt.Close();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checking();
        }

        private void checking()
        {
            string usr, pas;
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt";
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                usr = lines[2].ToString();
                pas = lines[4].ToString();
                if (usr != String.Empty && pas != String.Empty)
                {
                    userName.Text = usr;
                    passWord.isPassword = true;
                    passWord.Text = pas;
                    btnCheck.Checked = true;
                }
                else if (usr == String.Empty && pas == String.Empty)
                {
                    userName.Text = "Username";
                    passWord.Text = "Password";
                    btnCheck.Checked = false;
                }
            }
        }
    }
}
