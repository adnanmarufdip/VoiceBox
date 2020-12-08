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
    public partial class SentControlcs : UserControl
    {

        int lim;

        int lim_;

        int limit;

        int Index;

        ListBox sentTime = new ListBox();

        ListBox sentAddress = new ListBox();

        ListBox sentTitle = new ListBox();

        ListBox sentSummary = new ListBox();

        ListBox sentAttachment = new ListBox();

        ListBox TTM = new ListBox();

        ListBox TTR = new ListBox();

        string user;

        string fileDel;

        public event EventHandler LoadMailReaderT_;

        public event EventHandler mForword_;

        public event EventHandler SendPushNoti_;

        public static event EventHandler ReadSentMail_v;

        public SentControlcs()
        {
            InitializeComponent();
            user = login.AppUser;
            fileDel = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg_Del.txt";
            preCheck();
            limit = lim / 8;
            MainWindow.sentMesNameRet_ += MainWindow_sentMesNameRet_;
            MainWindow.SentScrollDown_ += MainWindow_SentScrollDown_;
            MainWindow.SentScrollUp_ += MainWindow_SentScrollUp_;
            MainWindow.ReadSentMail_ += MainWindow_ReadSentMail_;
        }

        private void MainWindow_ReadSentMail_(object sender, EventArgs e)
        {
            EventHandler handler = ReadSentMail_v;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void MainWindow_SentScrollUp_(object sender, EventArgs e)
        {
            scrollPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void MainWindow_SentScrollDown_(object sender, EventArgs e)
        {
            int temp = scrollPanel.VerticalScroll.Value + scrollPanel.VerticalScroll.SmallChange * 76;
            scrollPanel.AutoScrollPosition = new Point(0, temp);
        }

        private void MainWindow_sentMesNameRet_(object sender, EventArgs e)
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
                        vb.sntMesName = TTR.Items[vb.sentCount - 1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void preCheck()
        {
            try
            {
                string sent_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg.txt";
                if (File.Exists(sent_message))
                {
                    string[] linesNew = File.ReadAllLines(sent_message);
                    lim = linesNew.Length;
                    if (lim == 0)
                    {
                        timerT.Start();
                    }
                }
            }
            catch(Exception ex)
            {
                //
            }
        }

        private void SentControlcs_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void loader()
        {
            string sent_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Snt_Msg.txt";
            if (lim != 0)
            {
                int k = 0;
                string[] lines = File.ReadAllLines(sent_message);
                for (int i = 1; i <= limit; i++)
                {
                    int Index_ = i - 1;
                    for (int j = k; j <= lim;)
                    {

                        try
                        {
                            TTM.Items.Insert(Index_, DateTime.Parse(lines[j + 2]).ToBinary().ToString());
                            sentTime.Items.Insert(Index_, lines[j + 2].ToString());
                            sentAddress.Items.Insert(Index_, lines[j + 3].ToString());
                            sentTitle.Items.Insert(Index_, lines[j + 4].ToString());
                            sentSummary.Items.Insert(Index_, lines[j + 5].ToString());
                            sentAttachment.Items.Insert(Index_, lines[j + 6].ToString());
                            break;
                        }
                        catch (Exception ex)
                        {
                            //
                        }

                    }
                    k = k + 8;
                }
                FeatchMail();
            }
        }

        private void SortDeletedMailsData()
        {
            if (File.Exists(fileDel))
            {
                try
                {
                    string[] lines = File.ReadAllLines(fileDel);
                    lim_ = TTM.Items.Count;
                    int lim1 = lines.Length;
                    if (lim1 != 0)
                    {
                        for (int i = 1; i <= lim1; i++)
                        {
                            for (int j = 1; j <= lim_; j++)
                            {
                                if (TTM.Items[j - 1].ToString() == lines[i - 1].ToString())
                                {
                                    sentAddress.Items.Remove(sentAddress.Items[j - 1].ToString());
                                    sentTitle.Items.Remove(sentTitle.Items[j - 1].ToString());
                                    sentTime.Items.Remove(sentTime.Items[j - 1].ToString());
                                    sentSummary.Items.Remove(sentSummary.Items[j - 1].ToString());
                                    sentAttachment.Items.Remove(sentAttachment.Items[j - 1].ToString());
                                    TTM.Items.Remove(TTM.Items[j - 1].ToString());
                                    lim_ = TTM.Items.Count;
                                    Index = sentTime.Items.Count;
                                }
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

        private void FeatchMail()
        {
            SortDeletedMailsData();
            Index = sentTime.Items.Count;
            GetTotalMail();
            if (Index == 0)
            {
                timerT.Start();
            }
            for (int i = Index; i >= 1; i--)
            {
                try
                {
                    SntMsgLbl ms = new SntMsgLbl();
                    ms.mailTime.Text = sentTime.Items[i - 1].ToString();
                    ms.emailName.Text = sentAddress.Items[i - 1].ToString();
                    ms.mailSubject.Text = sentTitle.Items[i - 1].ToString();
                    ms.mailMessage.Text = sentSummary.Items[i - 1].ToString();
                    ms.attachment = sentAttachment.Items[i - 1].ToString();
                    ms.Location = new Point(18, scrollPanel.Controls.Count * 73);
                    scrollPanel.Controls.Add(ms);
                    ms.LoadMailReader_ += Ms_LoadMailReader_;
                    ms.lMailForwardd_ += Ms_lMailForwardd_;
                }
                catch (Exception ex)
                {
                    //
                }
            }
            SortMailOrder();
        }

        private void SortMailOrder()
        {
            for (int i = Index; i >= 1; i--)
            {
                TTR.Items.Add(sentTitle.Items[i - 1].ToString());
            }
        }

        private void GetTotalMail()
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
                        vb.sntTotalMail = Index;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void Ms_lMailForwardd_(object sender, EventArgs e)
        {
            EventHandler handler = mForword_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void Ms_LoadMailReader_(object sender, EventArgs e)
        {
            EventHandler handler = LoadMailReaderT_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void timerT_Tick(object sender, EventArgs e)
        {
            EventHandler handler = SendPushNoti_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            timerT.Stop();
        }
    }
}
