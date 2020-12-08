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
    public partial class DraftControls : UserControl
    {

        int lim;

        int lim_;

        int limit;

        int Index;

        ListBox DraftTime = new ListBox();

        ListBox DraftAddress = new ListBox();

        ListBox DraftTitle = new ListBox();

        ListBox DraftSummary = new ListBox();

        ListBox DraftAttachment = new ListBox();

        ListBox TTM_ = new ListBox();

        ListBox TTR_ = new ListBox();

        string user;

        string fileDel;

        public event EventHandler LoadMailReaderT_c;

        public event EventHandler mDrftDlt;

        public event EventHandler SendPushNoti_c;

        public static event EventHandler ReadDraftMail_v;

        public static event EventHandler ReadDraftMailDelete_v;

        public DraftControls()
        {
            InitializeComponent();
            user = login.AppUser;
            fileDel = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg_Del.txt";
            preCheck();
            limit = lim / 8;
            MainWindow.draftMesNameRet_ += MainWindow_draftMesNameRet_;
            MainWindow.DraftScrollDown_ += MainWindow_DraftScrollDown_;
            MainWindow.DraftScrollUp_ += MainWindow_DraftScrollUp_;
            MainWindow.ReadDraftMail_ += MainWindow_ReadDraftMail_;
            MainWindow.ReadDraftMailDelete_ += MainWindow_ReadDraftMailDelete_;
        }

        private void MainWindow_ReadDraftMailDelete_(object sender, EventArgs e)
        {
            EventHandler handler = ReadDraftMailDelete_v;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void MainWindow_ReadDraftMail_(object sender, EventArgs e)
        {
            EventHandler handler = ReadDraftMail_v;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void MainWindow_DraftScrollUp_(object sender, EventArgs e)
        {
            scrollPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void MainWindow_DraftScrollDown_(object sender, EventArgs e)
        {
            int temp = scrollPanel.VerticalScroll.Value + scrollPanel.VerticalScroll.SmallChange * 76;
            scrollPanel.AutoScrollPosition = new Point(0, temp);
        }

        private void MainWindow_draftMesNameRet_(object sender, EventArgs e)
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
                        vb.drftMesName = TTR_.Items[vb.draftCount - 1].ToString();
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
                string draft_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg.txt";
                if (File.Exists(draft_message))
                {
                    string[] linesNew = File.ReadAllLines(draft_message);
                    lim = linesNew.Length;
                    if (lim == 0)
                    {
                        timerT.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void DraftControls_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void loader()
        {
            string draft_message = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + user + "\\Drft_Msg.txt";
            if (lim != 0)
            {
                int k = 0;
                string[] lines = File.ReadAllLines(draft_message);
                for (int i = 1; i <= limit; i++)
                {
                    int Index_ = i - 1;
                    for (int j = k; j <= lim;)
                    {

                        try
                        {
                            TTM_.Items.Insert(Index_, DateTime.Parse(lines[j + 2]).ToBinary().ToString());
                            DraftTime.Items.Insert(Index_, lines[j + 2].ToString());
                            DraftAddress.Items.Insert(Index_, lines[j + 3].ToString());
                            DraftTitle.Items.Insert(Index_, lines[j + 4].ToString());
                            DraftSummary.Items.Insert(Index_, lines[j + 5].ToString());
                            DraftAttachment.Items.Insert(Index_, lines[j + 6].ToString());
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

        private void FeatchMail()
        {
            SortDeletedMailsData();
            Index = DraftTime.Items.Count;
            GetTotalMail();
            if (Index == 0)
            {
                timerT.Start();
            }
            for (int i = Index; i >= 1; i--)
            {
                try
                {
                    DrftMsgLbl ms = new DrftMsgLbl();
                    ms.mailTime.Text = DraftTime.Items[i - 1].ToString();
                    ms.emailName.Text = DraftAddress.Items[i - 1].ToString();
                    ms.mailSubject.Text = DraftTitle.Items[i - 1].ToString();
                    ms.mailMessage.Text = DraftSummary.Items[i - 1].ToString();
                    ms.attachment_ = DraftAttachment.Items[i - 1].ToString();
                    ms.Location = new Point(18, scrollPanel.Controls.Count * 73);
                    scrollPanel.Controls.Add(ms);
                    ms.LoadMailReader_c += Ms_LoadMailReader_c;
                    //ms.lMailForwardd_c += Ms_lMailForwardd_c;
                    ms.lMailDlt += Ms_lMailDlt;
                }
                catch (Exception ex)
                {
                    //
                }
                SortMailOrder();
            }
        }

        private void SortMailOrder()
        {
            for (int i = Index; i >= 1; i--)
            {
                TTR_.Items.Add(DraftTitle.Items[i - 1].ToString());
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
                        vb.drftTotalMail = Index;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void Ms_lMailDlt(object sender, EventArgs e)
        {
            EventHandler handler = mDrftDlt;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void Ms_LoadMailReader_c(object sender, EventArgs e)
        {
            EventHandler handler = LoadMailReaderT_c;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void SortDeletedMailsData()
        {
            if (File.Exists(fileDel))
            {
                try
                {
                    string[] lines = File.ReadAllLines(fileDel);
                    lim_ = TTM_.Items.Count;
                    int lim1 = lines.Length;
                    if (lim1 != 0)
                    {
                        for (int i = 1; i <= lim1; i++)
                        {
                            for (int j = 1; j <= lim_; j++)
                            {
                                if (TTM_.Items[j - 1].ToString() == lines[i - 1].ToString())
                                {
                                    DraftAddress.Items.Remove(DraftAddress.Items[j - 1].ToString());
                                    DraftTitle.Items.Remove(DraftTitle.Items[j - 1].ToString());
                                    DraftTime.Items.Remove(DraftTime.Items[j - 1].ToString());
                                    DraftSummary.Items.Remove(DraftSummary.Items[j - 1].ToString());
                                    DraftAttachment.Items.Remove(DraftAttachment.Items[j - 1].ToString());
                                    TTM_.Items.Remove(TTM_.Items[j - 1].ToString());
                                    lim_ = TTM_.Items.Count;
                                    Index = DraftTime.Items.Count;
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

        private void timerT_Tick(object sender, EventArgs e)
        {
            EventHandler handler = SendPushNoti_c;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            timerT.Stop();
        }
    }
}
