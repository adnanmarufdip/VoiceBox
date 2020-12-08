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
    public partial class SntMsgLbl : UserControl
    {
        int N_M = 0;

        public string attachment;

        public event EventHandler LoadMailReader_;

        public event EventHandler lMailForwardd_;

        public SntMsgLbl()
        {
            InitializeComponent();
            PreCheck();
            SentControlcs.ReadSentMail_v += SentControlcs_ReadSentMail_v;
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

        private void SentControlcs_ReadSentMail_v(object sender, EventArgs e)
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
                        if (mailSubject.Text == vb.sntMesName)
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

        private void MouseHover_Backcolor(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.pictureBox1.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.pictureBox2.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.emailName.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailSubject.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailMessage.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailFrdBtn.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailTime.BackColor = ColorTranslator.FromHtml("#e6e6e6");
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
            this.mailFrdBtn.BackColor = ColorTranslator.FromHtml("#f2f2f2");
            this.mailTime.BackColor = ColorTranslator.FromHtml("#f2f2f2");
        }

        private void Click_Event(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                ClickAction();
            }
        }

        private void ClickAction()
        {
            EventHandler handler = LoadMailReader_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            string address = emailName.Text;
            string subject = mailSubject.Text;
            string body = mailMessage.Text;
            string time = mailTime.Text;
            MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
            frm2.rbc_.ChangeText(address, subject, body, time);
        }

        private void keepVisible_Tick(object sender, EventArgs e)
        {
            this.mailFrdBtn.SendToBack();
            keepVisible.Stop();
        }

        private void mailFrdBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                frm2.ComposeTab.mailSubject.Text = mailSubject.Text;
                frm2.ComposeTab.mailBody.Text = mailMessage.Text;
                EventHandler handler = lMailForwardd_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }
    }
}
