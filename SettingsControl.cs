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
    public partial class SettingsControl : UserControl
    {
        int N_M = 0;

        string user;

        public event EventHandler AppRestart_;

        public SettingsControl()
        {
            InitializeComponent();
            user = login.AppUser;
            StateCheck();
            PreCheck();
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

        private void AppRestart()
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void StateCheck()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    string state = lines[1].ToString();
                    string state1 = lines[2].ToString();
                    if (state.Equals("Voice-Recognition = 1") && state1.Equals("Virtual-Assistant = 1"))
                    {
                        vrEnDis.Checked = true;
                        vaEnDis.Enabled = true;
                        vaEnDis.Checked = true;
                    }
                    else if (state.Equals("Voice-Recognition = 1") && state1.Equals("Virtual-Assistant = 0"))
                    {
                        vrEnDis.Checked = true;
                        vaEnDis.Enabled = true;
                        vaEnDis.Checked = false;
                    }
                    else if (state.Equals("Voice-Recognition = 0") && state1.Equals("Virtual-Assistant = 0"))
                    {
                        vrEnDis.Checked = false;
                        vaEnDis.Enabled = false;
                        vaEnDis.Checked = false;
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }
        private void BtnResetAll_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                try
                {
                    string Txt1 = "[UserSettings]\r\nVoice-Recognition = 0\r\nVirtual-Assistant = 0";
                    TextWriter txt1 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                    txt1.Write(Txt1);
                    txt1.Close();
                    BtnResetAllAction();
                    AppRestart();
                }
                catch (Exception ex)
                {
                    //
                }
            }
            
        }

        private void BtnResetAllAction()
        {
            try
            {
                string Txt = "[UserInfo]\r\nus:\r\n\r\nps:\r\n\r\n-.-";
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                txt.Write(Txt);
                txt.Close();

                string Txt2 = "[ActiveWindow]\r\nLogin";
                TextWriter txt2 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt");
                txt2.Write(Txt2);
                txt2.Close();

                using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notify.txt"))
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        writer.WriteLine("Null");
                    }
                }
                using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notifyx.txt"))
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        writer.WriteLine("Null");
                    }
                }

                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Msg_Del.txt", String.Empty);

                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg.txt", String.Empty);

                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg_Del.txt", String.Empty);

                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg.txt", String.Empty);

                File.WriteAllText(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg_Del.txt", String.Empty);
  
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                BtnSignOutAction();
                AppRestart();
            }
        }

        private void BtnSignOutAction()
        {
            try
            {
                SaveLastUpdate();
                string Txt = "[UserInfo]\r\nus:\r\n\r\nps:\r\n\r\n-.-";
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt");
                txt.Write(Txt);
                txt.Close();

                string Txt2 = "[ActiveWindow]\r\nLogin";
                TextWriter txt2 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt");
                txt2.Write(Txt2);
                txt2.Close();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void SaveLastUpdate()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notify.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    int lim = lines.Length;
                    using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Inb_Mes_Notifyx.txt"))
                    {
                        for (int i = 1; i <= lim; i++)
                        {
                            writer.WriteLine(lines[i - 1].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {    
            BtnSaveAction();
            AppRestart();
        }

        private void BtnSaveAction()
        {
            try
            {
                SaveLastUpdate();
                if (vrEnDis.Checked == true && vaEnDis.Checked == true)
                {
                    string Txt = "[UserSettings]\r\nVoice-Recognition = 1\r\nVirtual-Assistant = 1";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                    txt.Write(Txt);
                    txt.Close();
                }
                else if (vrEnDis.Checked == true && vaEnDis.Checked == false)
                {
                    string Txt = "[UserSettings]\r\nVoice-Recognition = 1\r\nVirtual-Assistant = 0";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                    txt.Write(Txt);
                    txt.Close();
                }
                else if (vrEnDis.Checked == false)
                {
                    string Txt = "[UserSettings]\r\nVoice-Recognition = 0\r\nVirtual-Assistant = 0";
                    TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                    txt.Write(Txt);
                    txt.Close();
                }  
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            MainWindow.SetVAOn_ += MainWindow_SetVAOn_;
            MainWindow.SetVAOff_ += MainWindow_SetVAOff_;
            MainWindow.SetResetAll_ += MainWindow_SetResetAll_;
            MainWindow.SetSignOut_ += MainWindow_SetSignOut_;
        }

        private void MainWindow_SetSignOut_(object sender, EventArgs e)
        {
            BtnSignOutAction();
            DelayTime.Start();
        }

        private void MainWindow_SetResetAll_(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    string state = lines[1].ToString();
                    string state_ = lines[2].ToString();
                    if (state.Equals("Voice-Recognition = 1") && state_.Equals("Virtual-Assistant = 0"))
                    {
                        string Txt1 = "[UserSettings]\r\nVoice-Recognition = 1\r\nVirtual-Assistant = 0";
                        TextWriter txt1 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                        txt1.Write(Txt1);
                        txt1.Close();
                    }
                    else if (state.Equals("Voice-Recognition = 1") && state_.Equals("Virtual-Assistant = 1"))
                    {
                        string Txt1 = "[UserSettings]\r\nVoice-Recognition = 1\r\nVirtual-Assistant = 1";
                        TextWriter txt1 = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt");
                        txt1.Write(Txt1);
                        txt1.Close();
                    }
                    BtnResetAllAction();
                    DelayTime.Start();
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void MainWindow_SetVAOff_(object sender, EventArgs e)
        {
            vaEnDis.Checked = false;
            BtnSaveAction();
            DelayTime.Start();
        }

        private void MainWindow_SetVAOn_(object sender, EventArgs e)
        {
            vaEnDis.Checked = true;
            BtnSaveAction();
            DelayTime.Start();
        }

        private void AppRestartActn()
        {
            EventHandler handler = AppRestart_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void DelayTime_Tick(object sender, EventArgs e)
        {
            DelayTime.Stop();
            AppRestartActn();
        }
    }
}
