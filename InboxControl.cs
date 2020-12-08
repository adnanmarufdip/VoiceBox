/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WinMailClientApp
{
    public partial class InboxControl : UserControl
    {
        string username;

        string password;

        int Index;

        int lim;

        ListBox name = new ListBox();

        ListBox email = new ListBox();

        ListBox title = new ListBox();

        ListBox summary = new ListBox();

        ListBox time = new ListBox();

        public event EventHandler LoadMailReaderT;

        public event EventHandler mReply;

        public event EventHandler mForword;

        public event EventHandler SendPushNoti;

        string fileOld;

        string fileDel;

        string user;

        public static event EventHandler ReadInboxMail_v;

        public InboxControl()
        {
            InitializeComponent();
            GetUserCred();
            user = login.AppUser;
            fileOld = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notifyx.txt";
            fileDel = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Msg_Del.txt";
            MainWindow.ReadInboxMail_ += MainWindow_ReadInboxMail_;
            MainWindow.InboxScrollDown_ += MainWindow_InboxScrollDown_;
            MainWindow.InboxScrollUp_ += MainWindow_InboxScrollUp_;
            MainWindow.inboxMesNameRet_ += MainWindow_inboxMesNameRet_;
        }

        private void MainWindow_inboxMesNameRet_(object sender, EventArgs e)
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
                        vb.inboMesName = name.Items[vb.mailCount - 1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void MainWindow_InboxScrollUp_(object sender, EventArgs e)
        {
            scrollPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void MainWindow_InboxScrollDown_(object sender, EventArgs e)
        {
            int temp = scrollPanel.VerticalScroll.Value + scrollPanel.VerticalScroll.SmallChange * 76;
            scrollPanel.AutoScrollPosition = new Point(0, temp);
        }

        private void MainWindow_ReadInboxMail_(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMail_v;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
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

        public void GetAllmails()
        {
            System.Net.WebClient objclient = new WebClient();
            string response = null;
            XmlDocument xdoc = new XmlDocument();

            try
            {
                objclient.Credentials = new System.Net.NetworkCredential(username, password);
                response = Encoding.UTF8.GetString(objclient.DownloadData("https://mail.google.com/mail/feed/atom/inbox"));
                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">","<feed>");
                xdoc.LoadXml(response);
                foreach (XmlNode node1 in xdoc.SelectNodes("feed/entry"))
                {
                    title.Items.Add(node1.SelectSingleNode("title").InnerText);
                    summary.Items.Add(node1.SelectSingleNode("summary").InnerText);
                    time.Items.Add(node1.SelectSingleNode("issued").InnerText);
                    Index = title.Items.Count;
                }
                foreach (XmlNode node1 in xdoc.SelectNodes("feed/entry/author"))
                {
                    name.Items.Add(node1.SelectSingleNode("name").InnerText);
                    email.Items.Add(node1.SelectSingleNode("email").InnerText);
                }
            }
            catch(Exception ex)
            {
                timerT.Start();
            }
        }

        private void SortDeletedMailsData()
        {
            if (File.Exists(fileDel))
            {
                try
                {
                    string[] lines = File.ReadAllLines(fileDel);
                    lim = time.Items.Count;
                    int lim1 = lines.Length;
                    if (lim1 != 0)
                    {
                        for (int i = 1; i <= lim1; i++)
                        {
                            for (int j = 1; j <= lim; j++)
                            {
                                if (time.Items[j - 1].ToString() == lines[i - 1].ToString())
                                {
                                    title.Items.Remove(title.Items[j - 1].ToString());
                                    summary.Items.Remove(summary.Items[j - 1].ToString());
                                    time.Items.Remove(time.Items[j - 1].ToString());
                                    name.Items.Remove(name.Items[j - 1].ToString());
                                    email.Items.Remove(email.Items[j - 1].ToString());
                                    lim = time.Items.Count;
                                    Index = title.Items.Count;
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }

        private void InboxControl_Load(object sender, EventArgs e)
        {
            LoadMails();
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
                        vb.inbTotlaMail = Index;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void LoadMails()
        {
            try
            {
                string[] lines = File.ReadAllLines(fileOld);
                int len = lines.Length;
                GetAllmails();
                SortDeletedMailsData();
                for (int i = 1; i <= Index; i++)
                {
                    CustomeMailLabel temp = new CustomeMailLabel();
                    temp.Name = "cml" + i.ToString();
                    if (temp.Name == "cml" + i.ToString())
                    {
                        temp.ID = i;
                        temp.emailName.Text = name.Items[i - 1].ToString();
                        temp.Eaddress = email.Items[i - 1].ToString();
                        temp.mailSubject.Text = title.Items[i - 1].ToString();
                        temp.mailMessage.Text = summary.Items[i - 1].ToString();
                        temp.mailTime.Text = DateTime.Parse(time.Items[i - 1].ToString()).ToString();
                        temp.mTime = time.Items[i - 1].ToString();
                    }
                    temp.Location = new Point(18, scrollPanel.Controls.Count * 76);
                    scrollPanel.Controls.Add(temp);
                    temp.LoadMailReader += Temp_LoadMailReader;
                    temp.lMailRepli += Temp_lMailRepli;
                    temp.lMailForwardd += Temp_lMailForwardd;
                    for (int j = 1; j <= len; j++)
                    {
                        if (lines[j - 1].ToString() == time.Items[i - 1].ToString())
                        {
                            temp.emailName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }
                }
                SaveCurrentStatus();
            }
            catch(Exception ex)
            {
                //
            }
        }

        private void SaveCurrentStatus()
        {
            using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notify.txt"))
            {
                try
                {
                    Index = title.Items.Count;
                    for (int i = 1; i <= Index; i++)
                    {
                        if (time.Items[i - 1] != null)
                        {
                            writer.WriteLine(time.Items[i - 1].ToString());
                        }
                        else if (time.Items[i - 1] == null)
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

        private void Temp_lMailForwardd(object sender, EventArgs e)
        {
            EventHandler handler = mForword;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void Temp_lMailRepli(object sender, EventArgs e)
        {
            EventHandler handler = mReply;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void Temp_LoadMailReader(object sender, EventArgs e)
        {
            EventHandler handler = LoadMailReaderT;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void timerT_Tick(object sender, EventArgs e)
        {
            EventHandler handler = SendPushNoti;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            timerT.Stop();
        }
    }
}
