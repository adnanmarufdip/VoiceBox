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
    public partial class ReadBoxControl : UserControl
    {
        SpeechSynthesizer TalkBk = new SpeechSynthesizer();

        public event EventHandler CloseMailReader;

        public event EventHandler rMailRepli;

        public event EventHandler rMailForwardd;

        public event EventHandler rMailDelete;

        public string ttM;

        int N_M = 0;

        public ReadBoxControl()
        {
            InitializeComponent();
            PreCheck();
            MainWindow.ReadInboxMailClose_ += MainWindow_ReadInboxMailClose_;
            MainWindow.ReadInboxMailReply_ += MainWindow_ReadInboxMailReply_;
            MainWindow.ReadInboxMailForward_ += MainWindow_ReadInboxMailForward_;
            MainWindow.ReadInboxMailDelete_ += MainWindow_ReadInboxMailDelete_;
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

        private void MainWindow_ReadInboxMailDelete_(object sender, EventArgs e)
        {
            EventHandler handler = rMailDelete;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            cleanFields();
        }

        private void MainWindow_ReadInboxMailForward_(object sender, EventArgs e)
        {
            EventHandler handler = rMailForwardd;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            cleanFields();
        }

        private void MainWindow_ReadInboxMailReply_(object sender, EventArgs e)
        {
            EventHandler handler = rMailRepli;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            cleanFields();
        }

        private void MainWindow_ReadInboxMailClose_(object sender, EventArgs e)
        {
            cleanFields();
            EventHandler handler = CloseMailReader;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        public void ChangeText(string name,string address,string subject, string body, string time, string tM)
        {
            rMailName.Text = name;
            rMailAddress.Text = address;
            rMailSubject.Text = subject;
            rMailBody.Text = body;
            rMailTime.Text = time;
            ttM = tM;
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
                        if (vb.cmmndRead == 1 && vb.cmmndRead != 0)
                        {
                            vb.readMessage = "sender name, " + rMailName.Text +
                                            "? " + "time and date, " + rMailTime.Text +
                                            "? " + "sender address, " + rMailAddress.Text +
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
                EventHandler handler = CloseMailReader;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void cleanFields()
        {
            rMailName.Text = null;
            rMailAddress.Text = null;
            rMailSubject.Text = null;
            rMailBody.Text = null;
            rMailTime.Text = null;
        }

        private void rMailReply_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                EventHandler handler = rMailRepli;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void rMailForward_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                EventHandler handler = rMailForwardd;
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
                EventHandler handler = rMailDelete;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }
    }
}
