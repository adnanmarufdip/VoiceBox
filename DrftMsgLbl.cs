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
    public partial class DrftMsgLbl : UserControl
    {
        int N_M = 0;

        public string attachment_;

        public event EventHandler LoadMailReader_c;

        public event EventHandler lMailDlt;

        public DrftMsgLbl()
        {
            InitializeComponent();
            PreCheck();
            DraftControls.ReadDraftMail_v += DraftControls_ReadDraftMail_v;
            DraftControls.ReadDraftMailDelete_v += DraftControls_ReadDraftMailDelete_v;
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

        private void DraftControls_ReadDraftMailDelete_v(object sender, EventArgs e)
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
                        if (mailSubject.Text == vb.drftMesName)
                        {
                            DeleteAction();
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void DraftControls_ReadDraftMail_v(object sender, EventArgs e)
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
                        if (mailSubject.Text == vb.drftMesName)
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
            this.mailDltBtn.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailTime.BackColor = ColorTranslator.FromHtml("#e6e6e6");
            this.mailDltBtn.BringToFront();
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
            this.mailDltBtn.BackColor = ColorTranslator.FromHtml("#f2f2f2");
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
            EventHandler handler = LoadMailReader_c;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            string address = emailName.Text;
            string subject = mailSubject.Text;
            string body = mailMessage.Text;
            string time = mailTime.Text;
            string attH = attachment_;
            MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
            frm2.c_c.ChangeText(address, subject, body, time, attH);
        }

        private void keepVisible_Tick(object sender, EventArgs e)
        {
            this.mailDltBtn.SendToBack();
            keepVisible.Stop();
        }

        private void mailDltBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                DeleteAction();
            }
        }

        private void DeleteAction()
        {
            MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
            frm2.DrftMailDlt = mailTime.Text;
            frm2.ComposeTab.mailBody.Text = mailMessage.Text;
            EventHandler handler = lMailDlt;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }
}
