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
using System.Speech.Synthesis;
using System.IO;

namespace WinMailClientApp
{
    public partial class ReadBoxControl_ : UserControl
    {
        SpeechSynthesizer TalkBk = new SpeechSynthesizer();

        public event EventHandler CloseMailReader_;

        public event EventHandler rMailForwardd_;

        public event EventHandler rMailDelete_;

        public string ttM_;

        int N_M = 0;

        public ReadBoxControl_()
        {
            InitializeComponent();
            PreCheck();
            MainWindow.ReadSentMailForward_ += MainWindow_ReadSentMailForward_;
            MainWindow.ReadSentMailDelete_ += MainWindow_ReadSentMailDelete_;
            MainWindow.ReadSentMailClose_ += MainWindow_ReadSentMailClose_;
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

        private void MainWindow_ReadSentMailClose_(object sender, EventArgs e)
        {
            cleanFields();
            EventHandler handler = CloseMailReader_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void MainWindow_ReadSentMailDelete_(object sender, EventArgs e)
        {
            EventHandler handler = rMailDelete_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            cleanFields();
        }

        private void MainWindow_ReadSentMailForward_(object sender, EventArgs e)
        {
            EventHandler handler = rMailForwardd_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            cleanFields();
        }

        public void ChangeText(string address, string subject, string body, string time)
        {
            rMailAddress.Text = address;
            rMailSubject.Text = subject;
            rMailBody.Text = body;
            rMailTime.Text = time;
            ttM_ = time;
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
                        if (vb.cmmndRead_ == 1 && vb.cmmndRead_ != 0)
                        {
                            vb.readMessage = "recipient address, " + rMailAddress.Text +
                                            "? " + "time and date, " + rMailTime.Text +
                                            "? " + "title, " + rMailSubject.Text +
                                            "? " + "summary, " + rMailBody.Text
                                            ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void rGoBack_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                cleanFields();
                EventHandler handler = CloseMailReader_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void cleanFields()
        {
            rMailAddress.Text = String.Empty;
            rMailSubject.Text = String.Empty;
            rMailBody.Text = String.Empty;
            rMailTime.Text = String.Empty;
        }

        private void rMailForward_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                EventHandler handler = rMailForwardd_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void rMialDelete_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                EventHandler handler = rMailDelete_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }
    }
}
