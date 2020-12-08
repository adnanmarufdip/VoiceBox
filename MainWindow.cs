/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;


namespace WinMailClientApp
{
    public partial class MainWindow : Form
    {
        int sld = 1;

        int N_M = 0;

        int ignore = 0;

        int ignoreS = 0;

        int ignoreS_ = 0;

        int newMailCount = 0;

        int synTh = 0;

        int AwaitTimerTick = 0;

        int emptyOrder = 0;

        string AppUser;

        public string DrftMailDlt;

        InboxControl InboxMail;

        SentControlcs SentMail;

        DraftControls DraftMail;

        SoundPlayer Notification;


        public static event EventHandler AppRestart;

        public static event EventHandler SetMailClear_;
        public static event EventHandler SetMailDraft_;
        public static event EventHandler SetMailSend_;

        public static event EventHandler SetVAOn_;
        public static event EventHandler SetVAOff_;
        public static event EventHandler SetResetAll_;
        public static event EventHandler SetSignOut_;

        public static event EventHandler ReadInboxMail_;
        public static event EventHandler ReadInboxMailClose_;
        public static event EventHandler ReadInboxMailReply_;
        public static event EventHandler ReadInboxMailForward_;
        public static event EventHandler ReadInboxMailDelete_;

        public static event EventHandler ReadSentMail_;
        public static event EventHandler ReadSentMailClose_;
        public static event EventHandler ReadSentMailForward_;
        public static event EventHandler ReadSentMailDelete_;

        public static event EventHandler ReadDraftMail_;
        public static event EventHandler ReadDraftMailDelete_;

        public static event EventHandler InboxScrollDown_;
        public static event EventHandler InboxScrollUp_;
        public static event EventHandler inboxMesNameRet_;

        public static event EventHandler SentScrollDown_;
        public static event EventHandler SentScrollUp_;
        public static event EventHandler sentMesNameRet_;

        public static event EventHandler DraftScrollDown_;
        public static event EventHandler DraftScrollUp_;
        public static event EventHandler draftMesNameRet_;

        VoiceBox vb;

        public MainWindow()
        {
            InitializeComponent();
            VoiceBox.WindowHide += VoiceBox_WindowHide;
            VoiceBox.WindowHide_ += VoiceBox_WindowHide_;
            VoiceBox.AppExit += VoiceBox_AppExit;
            VoiceBox.CmdComposeTabOpn += VoiceBox_CmdComposeTabOpn;
            VoiceBox.CmdComposeTabCls += VoiceBox_CmdComposeTabCls;
            VoiceBox.CmdInboxTabOpn += VoiceBox_CmdInboxTabOpn;
            VoiceBox.CmdInboxTabCls += VoiceBox_CmdInboxTabCls;
            VoiceBox.CmdSentTabOpn += VoiceBox_CmdSentTabOpn;
            VoiceBox.CmdSentTabCls += VoiceBox_CmdSentTabCls;
            VoiceBox.CmdDraftTabOpn += VoiceBox_CmdDraftTabOpn;
            VoiceBox.CmdDraftTabCls += VoiceBox_CmdDraftTabCls;
            VoiceBox.CmdSettingTabOpn += VoiceBox_CmdSettingTabOpn;
            VoiceBox.CmdSettingTabCls += VoiceBox_CmdSettingTabCls;
            VoiceBox.SetMailClear += VoiceBox_SetMailClear;
            VoiceBox.SetMailDraft += VoiceBox_SetMailDraft;
            VoiceBox.SetMailSend += VoiceBox_SetMailSend;
            VoiceBox.SetVAOn += VoiceBox_SetVAOn;
            VoiceBox.SetVAOff += VoiceBox_SetVAOff;
            VoiceBox.SetResetAll += VoiceBox_SetResetAll;
            VoiceBox.SetSignOut += VoiceBox_SetSignOut;
            VoiceBox.ReadInboxMail += VoiceBox_ReadInboxMail;
            VoiceBox.ReadInboxMailClose += VoiceBox_ReadInboxMailClose;
            VoiceBox.InboxScrollDown += VoiceBox_InboxScrollDown;
            VoiceBox.InboxScrollUp += VoiceBox_InboxScrollUp;
            VoiceBox.ReadInboxMailReply += VoiceBox_ReadInboxMailReply;
            VoiceBox.ReadInboxMailForward += VoiceBox_ReadInboxMailForward;
            VoiceBox.ReadInboxMailDelete += VoiceBox_ReadInboxMailDelete;
            VoiceBox.inboxMesNameRet += VoiceBox_inboxMesNameRet;
            VoiceBox.sentMesNameRet += VoiceBox_sentMesNameRet;
            VoiceBox.SentScrollDown += VoiceBox_SentScrollDown;
            VoiceBox.SentScrollUp += VoiceBox_SentScrollUp;
            VoiceBox.ReadSentMail += VoiceBox_ReadSentMail;
            VoiceBox.ReadSentMailForward += VoiceBox_ReadSentMailForward;
            VoiceBox.ReadSentMailDelete += VoiceBox_ReadSentMailDelete;
            VoiceBox.ReadSentMailClose += VoiceBox_ReadSentMailClose;
            VoiceBox.draftMesNameRet += VoiceBox_draftMesNameRet;
            VoiceBox.DraftScrollDown += VoiceBox_DraftScrollDown;
            VoiceBox.DraftScrollUp += VoiceBox_DraftScrollUp;
            VoiceBox.ReadDraftMail += VoiceBox_ReadDraftMail;
            VoiceBox.ReadDraftMailDelete += VoiceBox_ReadDraftMailDelete;

            this.slidePanel.Width = 49;
            CurPos.Text = String.Empty;

            MailReader.CloseMailReader += MailReader_CloseMailReader;
            MailReader.rMailRepli += MailReader_rMailRepli;
            MailReader.rMailForwardd += MailReader_rMailForwardd;
            MailReader.rMailDelete += MailReader_rMailDelete;

            MailReader_.CloseMailReader_ += MailReader__CloseMailReader_;
            MailReader_.rMailForwardd_ += MailReader__rMailForwardd_;
            MailReader_.rMailDelete_ += MailReader__rMailDelete_;

            ComposeTab.EnablePush += ComposeTab_EnablePush;

            ComposeTab.DraftNoti += ComposeTab_DraftNoti;
            ComposeTab.DraftNoti_ += ComposeTab_DraftNoti_;

            pushInfo.ClosePushNoti += PushInfo_ClosePushNoti;

            uiSettings.AppRestart_ += UiSettings_AppRestart_;

            PreCheck();
        }

        private void VoiceBox_WindowHide_(object sender, EventArgs e)
        {
            SaveLastUpdate();
            this.Close();
        }

        private void VoiceBox_ReadDraftMailDelete(object sender, EventArgs e)
        {
            EventHandler handler = ReadDraftMailDelete_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadDraftMail(object sender, EventArgs e)
        {
            EventHandler handler = ReadDraftMail_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_DraftScrollUp(object sender, EventArgs e)
        {
            EventHandler handler = DraftScrollUp_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_DraftScrollDown(object sender, EventArgs e)
        {
            EventHandler handler = DraftScrollDown_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_draftMesNameRet(object sender, EventArgs e)
        {
            EventHandler handler = draftMesNameRet_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
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
                    string state_ = lines[2].ToString();
                    vb = (VoiceBox)Application.OpenForms["VoiceBox"];
                    if (state.Equals("Voice-Recognition = 1") && state_.Equals("Virtual-Assistant = 0"))
                    {
                         vb.navMenu = 1;
                         vb.mainVis = 1;
                         synTh = 1;
                         N_M = 1;
                    }
                    else if (state.Equals("Voice-Recognition = 1") && state_.Equals("Virtual-Assistant = 1"))
                    {
                        vb.mainVis = 1;
                        synTh = 2;
                        N_M = 1;
                    }
                    else
                    {
                        synTh = 0;
                        N_M = 0;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void VoiceBox_ReadSentMailClose(object sender, EventArgs e)
        {
            EventHandler handler = ReadSentMailClose_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadSentMailDelete(object sender, EventArgs e)
        {
            EventHandler handler = ReadSentMailDelete_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadSentMailForward(object sender, EventArgs e)
        {
            EventHandler handler = ReadSentMailForward_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadSentMail(object sender, EventArgs e)
        {
            EventHandler handler = ReadSentMail_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SentScrollUp(object sender, EventArgs e)
        {
            EventHandler handler = SentScrollUp_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SentScrollDown(object sender, EventArgs e)
        {
            EventHandler handler = SentScrollDown_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_sentMesNameRet(object sender, EventArgs e)
        {
            EventHandler handler = sentMesNameRet_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_inboxMesNameRet(object sender, EventArgs e)
        {
            EventHandler handler = inboxMesNameRet_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadInboxMailDelete(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMailDelete_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadInboxMailForward(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMailForward_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadInboxMailReply(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMailReply_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadInboxMailClose(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMailClose_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_InboxScrollUp(object sender, EventArgs e)
        {
            EventHandler handler = InboxScrollUp_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_AppExit(object sender, EventArgs e)
        {
            InboxRefresh.Stop();
            SaveLastUpdate();
            Application.Exit();
        }

        private void VoiceBox_InboxScrollDown(object sender, EventArgs e)
        {
            EventHandler handler = InboxScrollDown_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_ReadInboxMail(object sender, EventArgs e)
        {
            EventHandler handler = ReadInboxMail_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void UiSettings_AppRestart_(object sender, EventArgs e)
        {
            EventHandler handler = AppRestart;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            this.Hide();
        }

        private void VoiceBox_SetSignOut(object sender, EventArgs e)
        {
            EventHandler handler = SetSignOut_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetResetAll(object sender, EventArgs e)
        {
            EventHandler handler = SetResetAll_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetVAOff(object sender, EventArgs e)
        {
            EventHandler handler = SetVAOff_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetVAOn(object sender, EventArgs e)
        {
            EventHandler handler = SetVAOn_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetMailSend(object sender, EventArgs e)
        {
            EventHandler handler = SetMailSend_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetMailDraft(object sender, EventArgs e)
        {
            EventHandler handler = SetMailDraft_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void VoiceBox_SetMailClear(object sender, EventArgs e)
        {
            EventHandler handler = SetMailClear_;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }


        /////////////////////////////////////////////////////////////////
        private void VoiceBox_CmdComposeTabOpn(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (ComposeTab.Visible == false)
            {
                ComposeTab.Visible = true;
                inBoxPanel.Visible = false;
                MailReader.Visible = false;
                uiSettings.Visible = false;
                SentItemsPanel.Visible = false;
                DraftItemsPanel.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Compose]";
            }
        }
        private void VoiceBox_CmdComposeTabCls(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (ComposeTab.Visible == true)
            {
                ComposeTab.Visible = false;
                Animation_On();
                CurPos.Text = String.Empty;
            }
        }
        //////////////////////////////////////////////////////////////////////
        private void VoiceBox_CmdInboxTabOpn(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (inBoxPanel.Visible == false && ignore == 0)
            {
                InboxMail = new InboxControl();
                InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
                inBoxPanel.Controls.Add(InboxMail);
                inBoxPanel.Visible = true;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                SentItemsPanel.Visible = false;
                DraftItemsPanel.Visible = false;
                label3.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Inbox]";
                ignore++;
                InboxCheck();
                InboxRefresh.Start();
            }
            else if (inBoxPanel.Visible == false && ignore == 1)
            {
                inBoxPanel.Visible = true;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                label3.Visible = false;
                SentItemsPanel.Visible = false;
                DraftItemsPanel.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Inbox]";
            }
        }
        private void VoiceBox_CmdInboxTabCls(object sender, EventArgs e)
        {
            SlideMenuHide();
            inBoxPanel.Visible = false;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            uiSettings.Visible = false;
            label3.Visible = true;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
            Animation_On();
            CurPos.Text = String.Empty;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            ignore = 1;
        }
        ///////////////////////////////////////////////////////////////////////
        private void VoiceBox_CmdSentTabOpn(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (SentItemsPanel.Visible == false && ignoreS == 0)
            {
                SentMail = new SentControlcs();
                SentMail.Location = new Point(0, SentItemsPanel.Controls.Count * 1);
                SentItemsPanel.Controls.Add(SentMail);
                SentMailActions();
                SentItemsPanel.Visible = true;
                DraftItemsPanel.Visible = false;
                inBoxPanel.Visible = false;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                label3.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Sent]";
                ignoreS++;
            }
            else if (SentItemsPanel.Visible == false && ignoreS == 1)
            {
                SentItemsPanel.Controls.Remove(SentMail);
                SentMail.Dispose();
                SentMail = new SentControlcs();
                SentMail.Location = new Point(0, SentItemsPanel.Controls.Count * 1);
                SentItemsPanel.Controls.Add(SentMail);
                SentMailActions();
                SentItemsPanel.Visible = true;
                DraftItemsPanel.Visible = false;
                inBoxPanel.Visible = false;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                label3.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Sent]";
            }
        }
        private void VoiceBox_CmdSentTabCls(object sender, EventArgs e)
        {
            SlideMenuHide();
            inBoxPanel.Visible = false;
            MailReader.Visible = false;
            uiSettings.Visible = false;
            label3.Visible = true;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            Animation_On();
            CurPos.Text = String.Empty;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            ignoreS = 1;
        }
        ///////////////////////////////////////////////////////////////////////
        private void VoiceBox_CmdDraftTabOpn(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (DraftItemsPanel.Visible == false && ignoreS_ == 0)
            {
                DraftMail = new DraftControls();
                DraftMail.Location = new Point(0, DraftItemsPanel.Controls.Count * 1);
                DraftItemsPanel.Controls.Add(DraftMail);
                DraftMailActions();
                DraftItemsPanel.Visible = true;
                SentItemsPanel.Visible = false;
                inBoxPanel.Visible = false;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                label3.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Draft]";
                ignoreS_++;
            }
            else if (DraftItemsPanel.Visible == false && ignoreS_ == 1)
            {
                DraftItemsPanel.Controls.Remove(DraftMail);
                DraftMail.Dispose();
                DraftMail = new DraftControls();
                DraftMail.Location = new Point(0, DraftItemsPanel.Controls.Count * 1);
                DraftItemsPanel.Controls.Add(DraftMail);
                DraftMailActions();
                DraftItemsPanel.Visible = true;
                SentItemsPanel.Visible = false;
                inBoxPanel.Visible = false;
                ComposeTab.Visible = false;
                uiSettings.Visible = false;
                label3.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                Animation_Off();
                CurPos.Text = "[Draft]";
            }
        }
        private void VoiceBox_CmdDraftTabCls(object sender, EventArgs e)
        {
            SlideMenuHide();
            inBoxPanel.Visible = false;
            MailReader.Visible = false;
            uiSettings.Visible = false;
            label3.Visible = true;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            Animation_On();
            CurPos.Text = String.Empty;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            ignoreS_ = 1;
        }
        ///////////////////////////////////////////////////////////////////////
        private void VoiceBox_CmdSettingTabOpn(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (uiSettings.Visible == false)
            {
                uiSettings.Visible = true;
                ComposeTab.Visible = false;
                inBoxPanel.Visible = false;
                MailReader.Visible = false;
                MailReader_.Visible = false;
                SentItemsPanel.Visible = false;
                DraftItemsPanel.Visible = false;
                Animation_Off();
                CurPos.Text = "[Settings]";
            }
        }
        private void VoiceBox_CmdSettingTabCls(object sender, EventArgs e)
        {
            SlideMenuHide();
            if (uiSettings.Visible == true)
            {
                uiSettings.Visible = false;
                Animation_On();
                CurPos.Text = String.Empty;
            }
        }
        ///////////////////////////////////////////////////////////////////////

        private void ComposeTab_DraftNoti(object sender, EventArgs e)
        {
            this.pushInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            pushInfo.CntrlMesLbl.Text = "Message saved as draft !";
            if (synTh == 1)
            {
                vb.TalkBack("saved as draft");
            }
            else if (synTh == 2)
            {
                vb.vaSection = 27;
                vb.TalkBack_("alright! message is saved as a draft");
            }
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void ComposeTab_DraftNoti_(object sender, EventArgs e)
        {
            this.pushInfo.BackColor = System.Drawing.Color.Red;
            pushInfo.CntrlMesLbl.Text = "Draft not possible !";
            if (synTh == 1)
            {
                vb.TalkBack("title and summary fields are empty");
            }
            else if (synTh == 2)
            {
                vb.vaSection = 28;
                vb.TalkBack_("well! it looks like there is a problem with saving draft");
            }
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void PushInfo_ClosePushNoti(object sender, EventArgs e)
        {
            NotifiAnimation.HideSync(pushPnl);
            this.pushInfo.BackColor = System.Drawing.Color.DarkGray;
            pushInfo.CntrlMesLbl.Text = "";
            pushInfo.CloseTimer.Stop();
        }

        private void ComposeTab_EnablePush(object sender, EventArgs e)
        {
            if (ComposeTab.status == "Message sent successfull !")
            {
                this.pushInfo.BackColor = System.Drawing.Color.Green;
                if (synTh == 1)
                {
                    vb.TalkBack("sent successfull");
                }
                else if (synTh == 2)
                {
                    vb.vaSection = 27;
                    vb.TalkBack_("alright! message has been sent successfully");
                }
            }
            else if (ComposeTab.status == "Incorrect email address !")
            {
                this.pushInfo.BackColor = System.Drawing.Color.Red;
                if (synTh == 1)
                {
                    vb.TalkBack("incorrect email address");
                }
                else if (synTh == 2)
                {
                    vb.vaSection = 28;
                    vb.TalkBack_("well! it looks like this email address is incorrect");
                }
            }
            else if (ComposeTab.status == "Fields are empty !")
            {
                this.pushInfo.BackColor = System.Drawing.Color.Red;
                if (synTh == 1)
                {
                    vb.TalkBack("fields are empty");
                }
                else if (synTh == 2)
                {
                    vb.vaSection = 28;
                    vb.TalkBack_("well! it looks like some important fields are empty");
                }
            }
            else if (ComposeTab.status == "No internet connection !")
            {
                this.pushInfo.BackColor = System.Drawing.Color.Red;
                if (synTh == 1)
                {
                    vb.TalkBack("can't send! check internet connection");
                }
                else if (synTh == 2)
                {
                    vb.vaSection = 27;
                    vb.TalkBack_("well! it looks like you are disconnected from the internet");
                }
            }
            pushInfo.CntrlMesLbl.Text = ComposeTab.status;
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void MailReader__rMailDelete_(object sender, EventArgs e)
        {
            try
            {
                string file = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Snt_Msg_Del.txt";
                string SntTime = DateTime.Parse(MailReader_.ttM_).ToBinary().ToString();
                string td = SntTime + Environment.NewLine;
                System.IO.File.AppendAllText(file, td);
                //////////////////////////////////////
                this.pushInfo.BackColor = System.Drawing.Color.CornflowerBlue;
                pushInfo.CntrlMesLbl.Text = "Sent message deleted !";
                if (synTh == 1)
                {
                    vb.TalkBack("item deleted");
                }
                NotifiAnimation.ShowSync(pushPnl);
                pushInfo.CloseTimer.Start();
                //////////////////////////////////////
                LoadSentMails();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void MailReader__rMailForwardd_(object sender, EventArgs e)
        {
            ComposeTab.mailSubject.Text = MailReader_.rMailSubject.Text;
            ComposeTab.mailBody.Text = MailReader_.rMailBody.Text;
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        private void MailReader__CloseMailReader_(object sender, EventArgs e)
        {
            MailReader_.Visible = false;
        }

        private void MailReader_rMailDelete(object sender, EventArgs e)
        {
            try
            {
                string file = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Msg_Del.txt";
                string td = MailReader.ttM + Environment.NewLine;
                System.IO.File.AppendAllText(file, td);
                //////////////////////////////////////
                this.pushInfo.BackColor = System.Drawing.Color.CornflowerBlue;
                pushInfo.CntrlMesLbl.Text = "Inbox Message deleted !";
                if (synTh == 1)
                {
                    vb.TalkBack("item deleted");
                }
                NotifiAnimation.ShowSync(pushPnl);
                pushInfo.CloseTimer.Start();
                //////////////////////////////////////
                LoadInbox();
            }
            catch(Exception ex)
            {
                //
            }
        }

        private void VoiceBox_WindowHide(object sender, EventArgs e)
        {
            SaveLastUpdate();
            this.Close();
        }

        private void InboxCheck()
        {
            try
            {
                string New = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notify.txt";
                string Old = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notifyx.txt";
                if (File.Exists(New) && File.Exists(Old))
                {
                    string[] linesNew = File.ReadAllLines(New);
                    string[] linesOld = File.ReadAllLines(Old);
                    int lim = linesOld.Length;
                    for (int i = 1; i <= lim; i++)
                    {
                        if (linesNew[i - 1].ToString() != linesOld[i - 1].ToString())
                        {
                            newMailCount++;
                        }
                    }
                    if (newMailCount > 0)
                    {
                        Notification = new SoundPlayer("NewMail.wav");
                        Notification.Play();
                        newMailCount = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                //
            }
        }

        private void InboxMail_mForword(object sender, EventArgs e)
        {
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        private void InboxMail_mReply(object sender, EventArgs e)
        {
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        private void MailReader_rMailForwardd(object sender, EventArgs e)
        {
            ComposeTab.mailSubject.Text = MailReader.rMailSubject.Text;
            ComposeTab.mailBody.Text = MailReader.rMailBody.Text;
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }
        private void MailReader_rMailRepli(object sender, EventArgs e)
        {
            ComposeTab.mailTo.Text = MailReader.rMailAddress.Text;
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        public ReadBoxControl rbc
        {
            get { return MailReader; }
        }

        public ReadBoxControl_ rbc_
        {
            get { return MailReader_; }
        }

        public ComposeControl c_c
        {
            get { return ComposeTab; }
        }

        public ComposeControl SetAddress
        {
            get { return ComposeTab; }
        }

        public ComposeControl SetSubject
        {
            get { return ComposeTab; }
        }

        public ComposeControl SetBody
        {
            get { return ComposeTab; }
        }

        private void MailReader_CloseMailReader(object sender, EventArgs e)
        {
            MailReader.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AppUser = login.AppUser;
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
            InboxRefresh.Stop();
            SaveLastUpdate();
            Application.Exit();
        }

        private void SaveLastUpdate()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notify.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    int lim = lines.Length;
                    using (var writer = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Inb_Mes_Notifyx.txt"))
                    {
                        for (int i = 1; i <= lim; i++)
                        {
                            writer.WriteLine(lines[i - 1].ToString());
                        }
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                this.WindowState = FormWindowState.Minimized;
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
        {   if (N_M != 1)
            {
                SlideMenuHide();
                if (ComposeTab.Visible == false)
                {
                    ComposeTab.Visible = true;
                    inBoxPanel.Visible = false;
                    MailReader.Visible = false;
                    uiSettings.Visible = false;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Compose]";
                }
                else if (ComposeTab.Visible == true)
                {
                    ComposeTab.Visible = false;
                    Animation_On();
                    CurPos.Text = String.Empty;
                }
            }
        }

        private void LoadDraftMails()
        {
            DraftItemsPanel.Controls.Remove(DraftMail);
            DraftMail.Dispose();
            MailReader.Visible = false;
            MailReader_.Visible = false;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            DraftMail = new DraftControls();
            DraftMail.Location = new Point(0, DraftItemsPanel.Controls.Count * 1);
            DraftItemsPanel.Controls.Add(DraftMail);
            DraftMailActions();
            DraftItemsPanel.Visible = true;
            SentItemsPanel.Visible = false;
            inBoxPanel.Visible = false;
            ComposeTab.Visible = false;
            uiSettings.Visible = false;
            label3.Visible = false;
            Animation_Off();
            CurPos.Text = "[Draft]";
        }

        private void LoadSentMails()
        {
            SentItemsPanel.Controls.Remove(SentMail);
            SentMail.Dispose();
            MailReader.Visible = false;
            MailReader_.Visible = false;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            SlideMenuHide();
            SentMail = new SentControlcs();
            SentMail.Location = new Point(0, SentItemsPanel.Controls.Count * 1);
            SentItemsPanel.Controls.Add(SentMail);
            SentMailActions();
            SentItemsPanel.Visible = true;
            DraftItemsPanel.Visible = false;
            inBoxPanel.Visible = false;
            ComposeTab.Visible = false;
            uiSettings.Visible = false;
            label3.Visible = false;
            Animation_Off();
            CurPos.Text = "[Sent]";
        }

        private void LoadInbox()
        {
            InboxRefresh.Stop();
            inBoxPanel.Controls.Remove(InboxMail);
            InboxMail.Dispose();
            MailReader.Visible = false;
            MailReader_.Visible = false;
            MailReader.rMailName.Text = String.Empty;
            MailReader.rMailAddress.Text = String.Empty;
            MailReader.rMailSubject.Text = String.Empty;
            MailReader.rMailBody.Text = String.Empty;
            MailReader.rMailTime.Text = String.Empty;
            MailReader_.rMailAddress.Text = String.Empty;
            MailReader_.rMailSubject.Text = String.Empty;
            MailReader_.rMailBody.Text = String.Empty;
            MailReader_.rMailTime.Text = String.Empty;
            SlideMenuHide();
            InboxMail = new InboxControl();
            InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
            inBoxPanel.Controls.Add(InboxMail);
            InboxMailActions();
            inBoxPanel.Visible = true;
            ComposeTab.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
            label3.Visible = false;
            Animation_Off();
            CurPos.Text = "[Inbox]";
            InboxCheck();
            InboxRefresh.Start();
            SaveLastUpdate();
        }

        private void inboxBtn_click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                SlideMenuHide();
                if (inBoxPanel.Visible == false && ignore == 0)
                {
                    InboxMail = new InboxControl();
                    InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
                    inBoxPanel.Controls.Add(InboxMail);
                    inBoxPanel.Visible = true;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    label3.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Inbox]";
                    ignore++;
                    InboxCheck();
                    InboxRefresh.Start();
                }
                else if (inBoxPanel.Visible == false && ignore == 1)
                {
                    inBoxPanel.Visible = true;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = false;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Inbox]";
                }
                else
                {
                    inBoxPanel.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = true;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    Animation_On();
                    CurPos.Text = String.Empty;
                    MailReader.rMailName.Text = String.Empty;
                    MailReader.rMailAddress.Text = String.Empty;
                    MailReader.rMailSubject.Text = String.Empty;
                    MailReader.rMailBody.Text = String.Empty;
                    MailReader.rMailTime.Text = String.Empty;
                    MailReader_.rMailAddress.Text = String.Empty;
                    MailReader_.rMailSubject.Text = String.Empty;
                    MailReader_.rMailBody.Text = String.Empty;
                    MailReader_.rMailTime.Text = String.Empty;
                    ignore = 1;
                }
            }
        }

        private void sentBtn_click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                SlideMenuHide();
                if (SentItemsPanel.Visible == false && ignoreS == 0)
                {
                    SentMail = new SentControlcs();
                    SentMail.Location = new Point(0, SentItemsPanel.Controls.Count * 1);
                    SentItemsPanel.Controls.Add(SentMail);
                    SentMailActions();
                    SentItemsPanel.Visible = true;
                    DraftItemsPanel.Visible = false;
                    inBoxPanel.Visible = false;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Sent]";
                    ignoreS++;
                }
                else if (SentItemsPanel.Visible == false && ignoreS == 1)
                {
                    SentItemsPanel.Controls.Remove(SentMail);
                    SentMail.Dispose();
                    SentMail = new SentControlcs();
                    SentMail.Location = new Point(0, SentItemsPanel.Controls.Count * 1);
                    SentItemsPanel.Controls.Add(SentMail);
                    SentMailActions();
                    SentItemsPanel.Visible = true;
                    DraftItemsPanel.Visible = false;
                    inBoxPanel.Visible = false;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Sent]";
                }
                else
                {
                    inBoxPanel.Visible = false;
                    MailReader.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = true;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_On();
                    CurPos.Text = String.Empty;
                    MailReader.rMailName.Text = String.Empty;
                    MailReader.rMailAddress.Text = String.Empty;
                    MailReader.rMailSubject.Text = String.Empty;
                    MailReader.rMailBody.Text = String.Empty;
                    MailReader.rMailTime.Text = String.Empty;
                    MailReader_.rMailAddress.Text = String.Empty;
                    MailReader_.rMailSubject.Text = String.Empty;
                    MailReader_.rMailBody.Text = String.Empty;
                    MailReader_.rMailTime.Text = String.Empty;
                    ignoreS = 1;
                }
            }
        }

        private void SentMailActions()
        {
            SentMail.LoadMailReaderT_ += SentMail_LoadMailReaderT_;
            SentMail.mForword_ += SentMail_mForword_;
            SentMail.SendPushNoti_ += SentMail_SendPushNoti_;
        }

        private void SentMail_SendPushNoti_(object sender, EventArgs e)
        {
            this.pushInfo.BackColor = System.Drawing.Color.Red;
            pushInfo.CntrlMesLbl.Text = "Sent message is empty !";
            if (synTh == 1)
            {
                emptyOrder = 2;
                AwaitTime.Start();
            }
            else if (synTh == 2)
            {
                vb.sntTotalMail = 0;
            }
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void SentMail_mForword_(object sender, EventArgs e)
        {
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        private void SentMail_LoadMailReaderT_(object sender, EventArgs e)
        {
            SlideMenuHide();
            MailReader_.Visible = true;
        }

        private void drafBtn_click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                SlideMenuHide();
                if (DraftItemsPanel.Visible == false && ignoreS_ == 0)
                {
                    DraftMail = new DraftControls();
                    DraftMail.Location = new Point(0, DraftItemsPanel.Controls.Count * 1);
                    DraftItemsPanel.Controls.Add(DraftMail);
                    DraftMailActions();
                    DraftItemsPanel.Visible = true;
                    SentItemsPanel.Visible = false;
                    inBoxPanel.Visible = false;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Draft]";
                    ignoreS_++;
                }
                else if (DraftItemsPanel.Visible == false && ignoreS_ == 1)
                {
                    DraftItemsPanel.Controls.Remove(DraftMail);
                    DraftMail.Dispose();
                    DraftMail = new DraftControls();
                    DraftMail.Location = new Point(0, DraftItemsPanel.Controls.Count * 1);
                    DraftItemsPanel.Controls.Add(DraftMail);
                    DraftMailActions();
                    DraftItemsPanel.Visible = true;
                    SentItemsPanel.Visible = false;
                    inBoxPanel.Visible = false;
                    ComposeTab.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Draft]";
                }
                else
                {
                    inBoxPanel.Visible = false;
                    MailReader.Visible = false;
                    uiSettings.Visible = false;
                    label3.Visible = true;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    Animation_On();
                    CurPos.Text = String.Empty;
                    MailReader.rMailName.Text = String.Empty;
                    MailReader.rMailAddress.Text = String.Empty;
                    MailReader.rMailSubject.Text = String.Empty;
                    MailReader.rMailBody.Text = String.Empty;
                    MailReader.rMailTime.Text = String.Empty;
                    MailReader_.rMailAddress.Text = String.Empty;
                    MailReader_.rMailSubject.Text = String.Empty;
                    MailReader_.rMailBody.Text = String.Empty;
                    MailReader_.rMailTime.Text = String.Empty;
                    ignoreS_ = 1;
                }
            }
        }

        private void DraftMailActions()
        {
            DraftMail.LoadMailReaderT_c += DraftMail_LoadMailReaderT_c;
            DraftMail.SendPushNoti_c += DraftMail_SendPushNoti_c;
            DraftMail.mDrftDlt += DraftMail_mDrftDlt;
        }

        private void DraftMail_mDrftDlt(object sender, EventArgs e)
        {
            try
            {
                string file = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData" + "\\" + AppUser + "\\Drft_Msg_Del.txt";
                string SntTime = DateTime.Parse(DrftMailDlt).ToBinary().ToString();
                string td = SntTime + Environment.NewLine;
                System.IO.File.AppendAllText(file, td);
                //////////////////////////////////////
                this.pushInfo.BackColor = System.Drawing.Color.CornflowerBlue;
                pushInfo.CntrlMesLbl.Text = "Draft message deleted !";
                if (synTh == 1)
                {
                    vb.TalkBack("item deleted");
                }
                NotifiAnimation.ShowSync(pushPnl);
                pushInfo.CloseTimer.Start();
                //////////////////////////////////////
                LoadDraftMails();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void DraftMail_SendPushNoti_c(object sender, EventArgs e)
        {
            this.pushInfo.BackColor = System.Drawing.Color.Red;
            pushInfo.CntrlMesLbl.Text = "Draft message is empty !";
            if (synTh == 1)
            {
                emptyOrder = 3;
                AwaitTime.Start();
            }
            else if (synTh == 2)
            {
                vb.drftTotalMail = 0;
            }
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void DraftMail_LoadMailReaderT_c(object sender, EventArgs e)
        {
            SlideMenuHide();
            ComposeTab.Visible = true;
            MailReader.Visible = false;
            MailReader_.Visible = false;
            inBoxPanel.Visible = false;
            uiSettings.Visible = false;
            SentItemsPanel.Visible = false;
            DraftItemsPanel.Visible = false;
        }

        private void menuSlideBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                if (sld == 1)
                {
                    sld = 2;
                    SlideAni1.Start();
                    menuSlideBtn.Enabled = false;
                }
                else if (sld == 2)
                {
                    sld = 1;
                    SlideAni2.Start();
                    menuSlideBtn.Enabled = false;
                }
            }
        }

        void SlideMenuHide()
        {
            SlideAni1.Stop();
            if (sld == 2)
            {
                sld = 1;
                SlideAni2.Start();
                menuSlideBtn.Enabled = false;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (N_M != 1)
            {
                SlideMenuHide();
                if (uiSettings.Visible == false)
                {
                    uiSettings.Visible = true;
                    ComposeTab.Visible = false;
                    inBoxPanel.Visible = false;
                    MailReader.Visible = false;
                    MailReader_.Visible = false;
                    SentItemsPanel.Visible = false;
                    DraftItemsPanel.Visible = false;
                    Animation_Off();
                    CurPos.Text = "[Settings]";
                }
                else if (uiSettings.Visible == true)
                {
                    uiSettings.Visible = false;
                    Animation_On();
                    CurPos.Text = String.Empty;
                }
            }
        }

        private void InboxRefresh_Tick(object sender, EventArgs e)
        {
            if (inBoxPanel.Visible == true)
            {
                try
                {
                    SaveLastUpdate();
                    inBoxPanel.Controls.Remove(InboxMail);
                    InboxMail.Dispose();
                    InboxMail = new InboxControl();
                    InboxMail.Location = new Point(0, inBoxPanel.Controls.Count * 1);
                    InboxMailActions();
                    inBoxPanel.Controls.Add(InboxMail);
                    if(CustomeMailLabel.str == "new")
                    {
                        Notification = new SoundPlayer("NewMail.wav");
                        Notification.Play();
                    }
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void InboxMail_LoadMailReaderT(object sender, EventArgs e)
        {
            SlideMenuHide();
            MailReader.Visible = true;
        }

        private void inBoxPanel_VisibleChanged(object sender, EventArgs e)
        {
            SlideMenuHide();
            InboxMailActions(); 
        }

        private void InboxMailActions()
        {
            InboxMail.LoadMailReaderT += InboxMail_LoadMailReaderT;
            InboxMail.mReply += InboxMail_mReply;
            InboxMail.mForword += InboxMail_mForword;
            InboxMail.SendPushNoti += InboxMail_SendPushNoti;
        }

        private void InboxMail_SendPushNoti(object sender, EventArgs e)
        {
            this.pushInfo.BackColor = System.Drawing.Color.Red;
            pushInfo.CntrlMesLbl.Text = "Unable to load inbox message !";
            if (synTh == 1)
            {
                emptyOrder = 1;
                AwaitTime.Start();
            }
            else if (synTh == 2)
            {
                vb.inbTotlaMail = 0;
            }
            NotifiAnimation.ShowSync(pushPnl);
            pushInfo.CloseTimer.Start();
        }

        private void SlideAni1_Tick(object sender, EventArgs e)
        {
            if (this.slidePanel.Width <= 188)
            {
                this.slidePanel.Width = slidePanel.Width + 13;
            }
            if (this.slidePanel.Width >= 188)
            {
                SlideAni1.Stop();
                menuSlideBtn.Enabled = true;
            }
        }

        private void SlideAni2_Tick(object sender, EventArgs e)
        {
            if (this.slidePanel.Width >= 49)
            {
                this.slidePanel.Width = slidePanel.Width - 13;
            }
            if (this.slidePanel.Width <= 49)
            {
                SlideAni2.Stop();
                menuSlideBtn.Enabled = true;
            }
        }

        private void AwaitTime_Tick(object sender, EventArgs e)
        {
            AwaitTimerTick++;
            if (AwaitTimerTick == 2)
            {
                if (emptyOrder == 1)
                {
                    vb.TalkBack("unable to load inbox, check connection");
                }
                else if (emptyOrder == 2)
                {
                    vb.TalkBack("sent is empty");
                }
                else if (emptyOrder == 3)
                {
                    vb.TalkBack("draft is empty");
                }
                AwaitTimerTick = 0;
                AwaitTime.Stop();
            }
        }
    }
}
