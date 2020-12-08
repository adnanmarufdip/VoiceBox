/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;

namespace WinMailClientApp
{
    public partial class ComposeControl : UserControl
    {
        string username;

        string password;

        string user;

        string oldTime = "";

        int N_M = 0;

        public string status;

        public event EventHandler EnablePush;

        public event EventHandler DraftNoti;

        public event EventHandler DraftNoti_;

        public ComposeControl()
        {
            InitializeComponent();
            GetUserCred();
            PreCheck();
            user = login.AppUser;
            MainWindow.SetMailClear_ += MainWindow_SetMailClear_;
            MainWindow.SetMailDraft_ += MainWindow_SetMailDraft_;
            MainWindow.SetMailSend_ += MainWindow_SetMailSend_;
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

        private void MainWindow_SetMailSend_(object sender, EventArgs e)
        {
            SendThisMail();
        }

        private void MainWindow_SetMailDraft_(object sender, EventArgs e)
        {
            if (mailSubject.Text != "" && mailBody.Text != "")
            {
                AddToDraft();
                EventHandler handler = DraftNoti;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
            else
            {
                EventHandler handler = DraftNoti_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void MainWindow_SetMailClear_(object sender, EventArgs e)
        {
            mailTo.Text = String.Empty;
            mailSubject.Text = String.Empty;
            attactment.Text = String.Empty;
            mailBody.Text = String.Empty;
            oldTime = "";
        }

        private void GetUserCred()
        {
            try
            {
                string usr, pas;
                string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt";
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    usr = lines[2].ToString();
                    pas = lines[4].ToString();
                    username = usr;
                    password = pas;
                }
            }
            catch(Exception ex)
            {
                //
            }
        }

        private void mailClearBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                mailTo.Text = String.Empty;
                mailSubject.Text = String.Empty;
                attactment.Text = String.Empty;
                mailBody.Text = String.Empty;
                oldTime = "";
            }
        }

        private void mailSendBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                SendThisMail();
            }
        }

        private void SendThisMail()
        {
            bool NetCon = NetworkInterface.GetIsNetworkAvailable();
            if (NetCon == true)
            {
                try
                {
                    GetUserCred();
                    if (mailTo.Text != "" && mailSubject.Text != "")
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(username);
                        message.To.Add(mailTo.Text);
                        message.Subject = mailSubject.Text;
                        if (attactment.Text != String.Empty)
                        {
                            message.Attachments.Add(new Attachment(attactment.Text));
                        }
                        message.Body = mailBody.Text;
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        client.Credentials = new System.Net.NetworkCredential(username, password);
                        client.Send(message);
                        message = null;
                        AddToSent();
                        mailTo.Text = String.Empty;
                        mailSubject.Text = String.Empty;
                        attactment.Text = String.Empty;
                        mailBody.Text = String.Empty;
                        status = "Message sent successfull !";
                        SendPushNoti();
                    }
                    else
                    {
                        status = "Fields are empty !";
                        SendPushNoti();
                    }
                }
                catch (Exception ex)
                {
                    status = "Incorrect email address !";
                    SendPushNoti();
                }
            }
            else if (NetCon == false)
            {
                status = "No internet connection !";
                SendPushNoti();
            }
        }

        private void SendPushNoti()
        {
            EventHandler handler = EnablePush;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void AddToSent()
        {
            if (mailTo.Text != "")
            {
                string sent_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg.txt";
                string[] linesNew = File.ReadAllLines(sent_message);
                int lim = linesNew.Length;
                if (lim < 800)
                {
                    if (lim != 0)
                    {
                        string sta = Environment.NewLine + "#" + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, sta);
                    }
                    else if (lim == 0)
                    {
                        string sta = "#" + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, sta);
                    }
                    string temp = "//////////////////////////" + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, temp);
                    string ttT = DateTime.Now + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ttT);
                    string ttl = mailTo.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ttl);
                    string ssb = mailSubject.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ssb);
                    string bby = mailBody.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, bby);
                    if (attactment.Text != String.Empty)
                    {
                        string bbA = attactment.Text + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, bbA);
                    }
                    else
                    {
                        string bbA = "NULL" + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, bbA);
                    }
                    string temp1 = "//////////////////////////";
                    System.IO.File.AppendAllText(sent_message, temp1);
                }
                else if (lim >= 800)
                {
                    File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg.txt", String.Empty);
                    string sta = "#" + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, sta);
                    string temp = "//////////////////////////" + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, temp);
                    string ttT = DateTime.Now + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ttT);
                    string ttl = mailTo.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ttl);
                    string ssb = mailSubject.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, ssb);
                    string bby = mailBody.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(sent_message, bby);
                    if (attactment.Text != String.Empty)
                    {
                        string bbA = attactment.Text + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, bbA);
                    }
                    else
                    {
                        string bbA = "NULL" + Environment.NewLine;
                        System.IO.File.AppendAllText(sent_message, bbA);
                    }
                    string temp1 = "//////////////////////////";
                    System.IO.File.AppendAllText(sent_message, temp1);
                }
            }
        }

        private void mailAttachBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                var codecs = ImageCodecInfo.GetImageEncoders();
                var codecFilter = "Image Files|";
                foreach (var codec in codecs)
                {
                    codecFilter += codec.FilenameExtension + ";";
                }
                ImageFile.Filter = codecFilter;
                if (ImageFile.ShowDialog() == DialogResult.OK)
                {
                    attactment.Text = ImageFile.FileName.ToString();
                }
            }
        }

        private void attactment_TextChanged(object sender, EventArgs e)
        {
            if (attactment.Text != String.Empty)
            {
                attachRmvBtn.Visible = true;
            }
            else if (attactment.Text == String.Empty)
            {
                attachRmvBtn.Visible = false;
            }
        }

        private void attachRmvBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                attactment.Text = String.Empty;
            }
        }

        private void mailDraftBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                if (mailBody.Text != "" && mailSubject.Text != "")
                {
                    AddToDraft();
                    EventHandler handler = DraftNoti;
                    if (handler != null)
                    {
                        handler(this, new EventArgs());
                    }
                }
            }
        }

        private void AddToDraft()
        {
            if (oldTime != "")
            {
                DltOldDrftInstnc();
            }
            string drft_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg.txt";
            string[] linesNew = File.ReadAllLines(drft_message);
            int lim = linesNew.Length;
            if (lim < 800)
            {
                if (lim != 0)
                {
                    string sta = Environment.NewLine + "#" + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, sta);
                }
                else if (lim == 0)
                {
                    string sta = "#" + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, sta);
                }
                string temp = "//////////////////////////" + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, temp);
                string ttT = DateTime.Now + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ttT);
                string ttl = mailTo.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ttl);
                string ssb = mailSubject.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ssb);
                string bby = mailBody.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, bby);
                if (attactment.Text != String.Empty)
                {
                    string bbA = attactment.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, bbA);
                }
                else
                {
                    string bbA = "NULL" + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, bbA);
                }
                string temp1 = "//////////////////////////";
                System.IO.File.AppendAllText(drft_message, temp1);
            }
            else if (lim >= 800)
            {
                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg.txt", String.Empty);
                string sta = "#" + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, sta);
                string temp = "//////////////////////////" + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, temp);
                string ttT = DateTime.Now + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ttT);
                string ttl = mailTo.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ttl);
                string ssb = mailSubject.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, ssb);
                string bby = mailBody.Text + Environment.NewLine;
                System.IO.File.AppendAllText(drft_message, bby);
                if (attactment.Text != String.Empty)
                {
                    string bbA = attactment.Text + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, bbA);
                }
                else
                {
                    string bbA = "NULL" + Environment.NewLine;
                    System.IO.File.AppendAllText(drft_message, bbA);
                }
                string temp1 = "//////////////////////////";
                System.IO.File.AppendAllText(drft_message, temp1);
            }
            mailTo.Text = String.Empty;
            mailSubject.Text = String.Empty;
            attactment.Text = String.Empty;
            mailBody.Text = String.Empty;
            oldTime = "";
        }

        public void ChangeText(string address, string subject, string body, string time, string attachmnt)
        {
            mailTo.Text = address;
            mailSubject.Text = subject;
            mailBody.Text = body;
            if (attachmnt != "NULL")
            {
                attactment.Text = attachmnt;
            }
            else
            {
                attactment.Text = String.Empty;
            }
            oldTime = time;
            ReadBack_();
        }

        private void ReadBack_()
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
                        VoiceBox vb = (VoiceBox)Application.OpenForms["VoiceBox"];
                        if (vb.cmmndRead__ == 1 && vb.cmmndRead__ != 0)
                        {
                            if (mailTo.Text == "")
                            {
                                vb.readMessage = "title, " + mailSubject.Text +
                                                "? " + "summary, " + mailBody.Text
                                                ;
                            }
                            else if (mailTo.Text != "")
                            {
                                vb.readMessage = "address, " + mailTo.Text +
                                                "? " + "title, " + mailSubject.Text +
                                                "? " + "summary, " + mailBody.Text
                                                ;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        public void SetMailToText(string MailAddress)
        {
            mailTo.Text = MailAddress;
            mailTo.Text = mailTo.Text.Replace(" ", "");
        }

        public void SetMailSubjectText(string MailSubject)
        {
            mailSubject.Text = MailSubject;
        }

        public void SetMailBodyText(string MailBody)
        {
            mailBody.Text = MailBody;
        }

        private void DltOldDrftInstnc()
        {
            string file = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg_Del.txt";
            string SntTime = DateTime.Parse(oldTime).ToBinary().ToString();
            string td = SntTime + Environment.NewLine;
            System.IO.File.AppendAllText(file, td);
        }
    }
}
