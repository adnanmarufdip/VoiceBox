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
using System.IO;

namespace WinMailClientApp
{
    public partial class CustomeMailLabel : UserControl
    {
        public string Eaddress;

        public int ID;

        int N_M = 0;

        public string mTime;

        public event EventHandler LoadMailReader;

        public event EventHandler lMailRepli;

        public event EventHandler lMailForwardd;

        public static string str;

        string user;

        public CustomeMailLabel()
        {
            InitializeComponent();
            PreCheck();
            user = login.AppUser;
            InboxControl.ReadInboxMail_v += InboxControl_ReadInboxMail_v;
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

        private void InboxControl_ReadInboxMail_v(object sender, EventArgs e)
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
                        if (ID == vb.mCount)
                        {
                            ClickAction();
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void keepVisible_Tick(object sender, EventArgs e)
        {
            this.mailReplyBtn.SendToBack();
            this.mailFrdBtn.SendToBack();
            keepVisible.Stop();
        }

        private void MouseHover_Backcolor(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.pictureBox1.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.pictureBox2.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.emailName.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailSubject.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailMessage.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailReplyBtn.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailFrdBtn.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailTime.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailReplyBtn.BringToFront();
            this.mailFrdBtn.BringToFront();
            keepVisible.Interval = 2000;
            keepVisible.Start();
        }

        private void MouseLeave_Backcolor(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.pictureBox1.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.pictureBox2.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.emailName.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailSubject.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailMessage.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailReplyBtn.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailFrdBtn.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailTime.BackColor = ColorTranslator.FromHtml("#f2f2f2");
        }

        private void Click_event(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                ClickAction();
            }
        }

        private void ClickAction()
        {
            this.emailName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EventHandler handler = LoadMailReader;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            string name = emailName.Text;
            string address = Eaddress;
            string subject = mailSubject.Text;
            string body = mailMessage.Text;
            string time = mailTime.Text;
            string tM = mTime;
            MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
            frm2.rbc.ChangeText(name, address, subject, body, time, tM);
        }

        private void mailFrdBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                frm2.ComposeTab.mailSubject.Text = mailSubject.Text;
                frm2.ComposeTab.mailBody.Text = mailMessage.Text;
                EventHandler handler = lMailForwardd;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void mailReplyBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                frm2.ComposeTab.mailTo.Text = Eaddress;
                EventHandler handler = lMailRepli;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void CustomeMailLabel_Load(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notify.txt";

            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    int i = ID - 1;
                    if (lines[i].ToString() != mTime)
                    {
                        str = "new";
                    }
                    else
                    {
                        str = "old";
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }
    }
}
