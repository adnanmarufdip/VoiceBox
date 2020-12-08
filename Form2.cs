using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinMailClientApp
{
    public partial class Form2 : Form
    {
        int ignore = 0;

        InboxControl InboxMail;


        public Form2()
        {
            InitializeComponent();
            this.slidePanel.Width = 49;
            CurPos.Text = String.Empty;
            InboxMail = new InboxControl();
            //InboxMail.LoadMailReaderT += InboxMail_LoadMailReaderT;
            MailReader.CloseMailReader += MailReader_CloseMailReader;
            MailReader.rMailRepli += MailReader_rMailRepli;
            MailReader.rMailForwardd += MailReader_rMailForwardd;
            //InboxMail.LoadMailReaderT += InboxMail_LoadMailReaderT;
        }

        /*private void InboxMail_LoadMailReaderT(object sender, EventArgs e)
        {
            MessageBox.Show("Ami thik achi");
            //MailReader.Visible = true;
        }*/

        private void InboxMail_mForword(object sender, EventArgs e)
        {
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            //InboxMail.Visible = false;
            inBoxPanel.Visible = false;
        }

        private void InboxMail_mReply(object sender, EventArgs e)
        {
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            //InboxMail.Visible = false;
            inBoxPanel.Visible = false;
        }

        private void MailReader_rMailForwardd(object sender, EventArgs e)
        {
            ComposeTab.mailSubject.Text = MailReader.rMailSubject.Text;
            ComposeTab.mailBody.Text = MailReader.rMailBody.Text;
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            //InboxMail.Visible = false;
            inBoxPanel.Visible = false;
        }
        private void MailReader_rMailRepli(object sender, EventArgs e)
        {
            ComposeTab.mailTo.Text = MailReader.rMailAddress.Text;
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            //InboxMail.Visible = false;
            inBoxPanel.Visible = false;
        }

        public ReadBoxControl rbc
        {
            get { return MailReader; }
        }

        public ComposeControl cc
        {
            get { return ComposeTab; }
        }

        private void MailReader_CloseMailReader(object sender, EventArgs e)
        {
            MailReader.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            homeAni.Start();
            this.pictureBox2.Image = Properties.Resources.animatedPic;
        }

        void Animation_On()
        {
            pictureBox2.Visible = true;
            this.panel2.BringToFront();
            panel2.Visible = false;
            homeAni.Start();
            this.pictureBox2.Image = Properties.Resources.animatedPic;
        }
        void Animation_Off()
        {
            pictureBox2.Visible = false;
            panel2.Visible = false;
            homeAni.Stop();
            this.panel2.SendToBack();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void slidePanel_close(object sender, EventArgs e)
        {
            if (this.slidePanel.Width == 188)
            {
                this.slidePanel.Width = 49;
            }
        }

        private void homeAni_Tick(object sender, EventArgs e)
        {
            if (homeAni.Interval == 3000)
            {
                if (panel2.Visible == false)
                {
                    homeAnim.ShowSync(panel2);
                }
                this.pictureBox2.Image = Properties.Resources.stillPic;
                homeAni.Stop();
            }
        }

        private void composeBtn_click(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (ComposeTab.Visible == false)
            {
                ComposeTab.Visible = true;
                //InboxMail.Visible = false;
                inBoxPanel.Visible = false;
                MailReader.Visible = false;

                Animation_Off();
                CurPos.Text = "[Write a mail]";
            }
            else if (ComposeTab.Visible == true)
            {
                ComposeTab.Visible = false;
                Animation_On();
                CurPos.Text = String.Empty;
            }
        }

        private void inboxBtn_click(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (inBoxPanel.Visible == false && ignore == 0)
            {
                InboxMail = new InboxControl();
                InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
                inBoxPanel.Controls.Add(InboxMail);
                inBoxPanel.Visible = true;
                ComposeTab.Visible = false;
                label3.Visible = false;
                Animation_Off();
                CurPos.Text = "[Inbox]";
                ignore++;
                InboxRefresh.Start();
            }
            else if (inBoxPanel.Visible == false && ignore == 1)
            {
                inBoxPanel.Visible = true;
                ComposeTab.Visible = false;
                label3.Visible = false;
                Animation_Off();
                CurPos.Text = "[Inbox]";
            }
            else
            {
                inBoxPanel.Visible = false;
                MailReader.Visible = false;
                label3.Visible = true;
                Animation_On();
                CurPos.Text = String.Empty;
                MailReader.rMailName.Text = String.Empty;
                MailReader.rMailAddress.Text = String.Empty;
                MailReader.rMailSubject.Text = String.Empty;
                MailReader.rMailBody.Text = String.Empty;
                MailReader.rMailTime.Text = String.Empty;
                InboxRefresh.Stop();
            }
        }

        private void sentBtn_click(object sender, EventArgs e)
        {
            SlideMenuHide();
        }

        private void drafBtn_click(object sender, EventArgs e)
        {
            SlideMenuHide();
        }

        private void menuSlideBtn_Click(object sender, EventArgs e)
        {
            if (this.slidePanel.Width == 49)
            {
                this.slidePanel.Width = 188;
            }
            else if (this.slidePanel.Width == 188)
            {
                this.slidePanel.Width = 49;
            }
        }

        void SlideMenuHide()
        {
            if (this.slidePanel.Width == 188)
            {
                this.slidePanel.Width = 49;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void InboxRefresh_Tick(object sender, EventArgs e)
        {
            if (inBoxPanel.Visible == true)
            {
                inBoxPanel.Visible = false;
                inBoxPanel.Controls.Remove(InboxMail);
                InboxMail.Dispose();
                InboxMail = new InboxControl();
                InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
                try
                {
                    inBoxPanel.Controls.Add(InboxMail);
                    inBoxPanel.Visible = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //inBoxPanel.Visible = true;
            }
        }

        private void InboxMail_LoadMailReaderT(object sender, EventArgs e)
        {
            //MessageBox.Show("Ami thik achi");
            MailReader.Visible = true;
        }

        private void inBoxPanel_VisibleChanged(object sender, EventArgs e)
        {
            InboxMail.LoadMailReaderT += InboxMail_LoadMailReaderT;
            InboxMail.mReply += InboxMail_mReply;
            InboxMail.mForword += InboxMail_mForword;
        }
    }
}
