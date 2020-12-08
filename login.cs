/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

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
using System.Speech;
using System.Speech.Synthesis;


namespace WinMailClientApp
{
    public partial class login : Form
    {
        VoiceBox vb;

        public static string AppUser;

        int tlkOpn = 0;

        int logSuSS = 0;

        int N_M = 0;

        public login()
        {
            InitializeComponent();
            VoiceBox.VBLogin += VoiceBox_VBLogin;
            VoiceBox.VBLogin_ += VoiceBox_VBLogin_;
            VoiceBox.WindowHide += VoiceBox_WindowHide;
            VoiceBox.WindowHide_ += VoiceBox_WindowHide_;
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            string Folder = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData";
            if (!Directory.Exists(Folder))
            {
                try
                {
                    Directory.CreateDirectory(Folder);

                    File.WriteAllText(Path.Combine(Folder, "User_Info.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "User_Settings.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Active_Window.txt"), null);

                    string Txt = "[UserInfo]\r\nus:\r\n\r\nps:\r\n\r\n-.-";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                    txt.Write(Txt);
                    txt.Close();

                    string Txt1 = "[UserSettings]\r\nVoice-Recognition = 0\r\nVirtual-Assistant = 0";
                    TextWriter txt1 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                    txt1.Write(Txt1);
                    txt1.Close();
                }
                catch(Exception ex)
                {
                    //
                }
            }
            PreCheck();
        }

        private void VoiceBox_WindowHide_(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoiceBox_VBLogin_(object sender, EventArgs e)
        {
            logSuSS = -1;
            MailLogin();
            chooseResT();
        }

        private void chooseResT()
        {
            switch (logSuSS)
            {
                case 0:
                    {
                        logSuSS = -1;
                        vb.vaSection = 4;
                        vb.TalkBack_("i think you have entered wrong username or password");
                        break;
                    }
                case 1:
                    {
                        logSuSS = -1;
                        vb.vaSection = 5;
                        vb.TalkBack_("gmail successfully signed in");
                        break;
                    }
                case 2:
                    {
                        logSuSS = -1;
                        vb.vaSection = 6;
                        vb.TalkBack_("oh, snap! no internet connection");
                        break;
                    }
            }
        }

        private void PreCheck()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    string state = lines[1].ToString();
                    if (state.Equals("Voice-Recognition = 1"))
                    {
                        vb = (VoiceBox)Application.OpenForms["VoiceBox"];
                        N_M = 1;
                    }
                    else
                    {
                        N_M = 0;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void VoiceBox_WindowHide(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoiceBox_VBLogin(object sender, EventArgs e)
        {
            GapTime.Start();
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
                logSuSS = 1;
                AppUser = userName.Text;
                MainWindow frm = new MainWindow();
                frm.Show();
                string Txt = "[ActiveWindow]\r\nMainWindow";
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt");
                txt.Write(Txt);
                txt.Close();
                this.Hide();
                logError.Visible = false;
                createUser();
            }

            catch (Exception ex)
            {
                logError.Visible = true;
                logSuSS = 0;
            }
        }

        private void createUser()
        {
            string Folder = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser;
            if (!Directory.Exists(Folder))
            {
                try
                {
                    Directory.CreateDirectory(Folder);
                    File.WriteAllText(Path.Combine(Folder, "Inb_Mes_Notify.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Inb_Mes_Notifyx.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Inb_Msg_Del.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Snt_Msg.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Snt_Msg_Del.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Drft_Msg.txt"), null);
                    File.WriteAllText(Path.Combine(Folder, "Drft_Msg_Del.txt"), null);

                    using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notify.txt"))
                    {
                        for (int i = 0; i <= 19; i++)
                        {
                            writer.WriteLine("Null");
                        }
                    }
                    using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notifyx.txt"))
                    {
                        for (int i = 0; i <= 19; i++)
                        {
                            writer.WriteLine("Null");
                        }
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userName_Enter_1(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                userName.Text = String.Empty;
                userName.ForeColor = System.Drawing.Color.Gray;
                logError.Visible = false;
            }
        }

        private void passWord_Enter_1(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                passWord.Text = String.Empty;
                passWord.isPassword = true;
                passWord.ForeColor = System.Drawing.Color.Gray;
                logError.Visible = false;
            }
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                MailLogin();
            }
        }
        private void MailLogin()
        {
            bool NetCon = NetworkInterface.GetIsNetworkAvailable();
            if (NetCon == false)
            {
                logSuSS = 2;
                if (tlkOpn == 0 && N_M != 1)
                {
                    MessageBox.Show("Check your internet connection", "Internet error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (tlkOpn == 1)
                {
                    vb.TalkBack("Check your internet connection");
                }
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
                try
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
                        userName.Text = "Email address";
                        passWord.Text = "Password";
                        btnCheck.Checked = false;
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }

        private void GapTime_Tick(object sender, EventArgs e)
        {
            tlkOpn = 1;
            MailLogin();
            if (logError.Visible != true && logSuSS == 1)
            {
                vb.TalkBack("Signing in successfull");
            }
            else if (logError.Visible != false && logSuSS == 0)
            {
                vb.TalkBack(logError.Text);
                vb.cmmndOpen = 1;
            }
            GapTime.Stop();
        }
    }
}
