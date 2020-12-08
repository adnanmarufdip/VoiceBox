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
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Media;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.IO;

namespace WinMailClientApp
{
    public partial class VoiceBox : Form
    {
        NAudio.Wave.WaveIn sourceStrem = null;
        NAudio.CoreAudioApi.MMDevice firstMic = null;

        login lg;
        MainWindow mw;
        VBScratchpad vbs;

        public int mainVis = 0;
        int backtoSleep = 0;
        int backtoSleep_ = 0;
        int VirAssist = 0;
        int MasterIgnore = 0;
        int lgVis = 0;
        public int cmmndOpen = 0;
        int sectn = 0;
        int conf = 0;
        int activeCmd = 0;
        int composeOpt = 0;
        int inboxOpt = 0;
        int sentOpt = 0;
        int draftOpt = 0;
        int settingOpt = 0;
        int closeOpt = 0;
        int mailCmmnd = 0;
        int setCmmnd = 0;
        int inboxCmmnd = 0;
        int sentCmmnd = 0;
        int draftCmmnd = 0;
        int inboRead = 0;
        int sntRead = 0;
        int inboRet = 0;
        int sntRet = 0;
        int drftRet = 0;
        int awitTillRead = 0;
        int awitTillRead_ = 0;
        int awitTillRead__ = 0;
        int ingcmpsaddr = 0;
        int ingcmpsttl_ssmry = 0;
        public int mailCount = 0;
        public int sentCount = 0;
        public int draftCount = 0;
        public int mCount = 0;
        public int navMenu = 0;
        public int inbTotlaMail = 0;
        public int sntTotalMail = 0;
        public int drftTotalMail = 0;
        public int cmmndRead = 0;
        public int cmmndRead_ = 0;
        public int cmmndRead__ = 0;
        public string inboMesName = null;
        public string sntMesName = null;
        public string drftMesName = null;
        public string readMessage = null;
        int navCmd = 0;
        string usrName = null;
        string greetText = null;
        string byeText = null;
        public int vaSection = 0;
        int vaExcOrdr = 0;
        int vAsectn = 0;

        SoundPlayer VB_Master_Sound;

        public static event EventHandler VBLogin;
        public static event EventHandler VBLogin_;
        public static event EventHandler WindowHide;
        public static event EventHandler WindowHide_;
        public static event EventHandler AppExit;

        public static event EventHandler CmdComposeTabOpn;
        public static event EventHandler CmdInboxTabOpn;
        public static event EventHandler CmdSentTabOpn;
        public static event EventHandler CmdDraftTabOpn;
        public static event EventHandler CmdSettingTabOpn;

        public static event EventHandler CmdComposeTabCls;
        public static event EventHandler CmdInboxTabCls;
        public static event EventHandler CmdSentTabCls;
        public static event EventHandler CmdDraftTabCls;
        public static event EventHandler CmdSettingTabCls;

        public static event EventHandler SetMailClear;
        public static event EventHandler SetMailSend;
        public static event EventHandler SetMailDraft;

        public static event EventHandler SetVAOn;
        public static event EventHandler SetVAOff;
        public static event EventHandler SetResetAll;
        public static event EventHandler SetSignOut;

        public static event EventHandler ReadInboxMail;
        public static event EventHandler ReadInboxMailClose;
        public static event EventHandler ReadInboxMailReply;
        public static event EventHandler ReadInboxMailForward;
        public static event EventHandler ReadInboxMailDelete;

        public static event EventHandler ReadSentMail;
        public static event EventHandler ReadSentMailClose;
        public static event EventHandler ReadSentMailForward;
        public static event EventHandler ReadSentMailDelete;

        public static event EventHandler ReadDraftMail;
        public static event EventHandler ReadDraftMailDelete;

        public static event EventHandler InboxScrollDown;
        public static event EventHandler InboxScrollUp;
        public static event EventHandler inboxMesNameRet;

        public static event EventHandler SentScrollDown;
        public static event EventHandler SentScrollUp;
        public static event EventHandler sentMesNameRet;

        public static event EventHandler DraftScrollDown;
        public static event EventHandler DraftScrollUp;
        public static event EventHandler draftMesNameRet;

        ////////////////////////////////////
        Choices VB_Master = new Choices();
        SpeechRecognitionEngine VB_Mas_Eng = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        ////////////////////////////////////
        Choices VB_Commands = new Choices();
        SpeechRecognitionEngine VB_Command_Eng = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechRecognitionEngine typeENG = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechSynthesizer TalkBk = new SpeechSynthesizer();
        ////////////////////////////////////
        Choices VA_Commands = new Choices();
        SpeechRecognitionEngine VA_Eng = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechRecognitionEngine VAtypeENG = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechSynthesizer TalkBk_ = new SpeechSynthesizer();
        ////////////////////////////////////

        public VoiceBox()
        {
            InitializeComponent();
            int Dwidth = Screen.PrimaryScreen.Bounds.Width;
            int loc = Dwidth - 357;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(loc / 2 + 1, -1);
            VB_Master_Sound = new SoundPlayer("VB_Open.wav");
            VB_Master_Sound.Play();
            ///////////////////////////////////////
            string Txt = "[ActiveWindow]\r\nLogin";
            TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt");
            txt.Write(Txt);
            txt.Close();
            //////////////////////////////////////
            PreCheck();
            MicVm();
            VoiceBox_Master();
            VoiceBox_Commands();
            SetTypeEng();
            VA_Commands_();
            VA_type_Eng();
            TalkBk.SpeakCompleted += TalkBk_SpeakCompleted;
            TalkBk_.SpeakCompleted += TalkBk__SpeakCompleted;
            TalkBk_.SpeakStarted += TalkBk__SpeakStarted;
        }

        private void TalkBk__SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            VBDisplay.Text = "VB: Working........!";
            VBDisplay.ForeColor = System.Drawing.Color.SpringGreen;
            backtoSleep_ = 0;
            VAResetAuto.Stop();
            VAResetAuto.Start();
        }

        private void VA_state()
        {
            VBDisplay.Text = "VB: Listening........!";
            VBDisplay.ForeColor = System.Drawing.Color.SpringGreen;
        }


        private void VA_type_Eng()
        {
            try
            {
                VAtypeENG.UnloadAllGrammars();
                VAtypeENG.LoadGrammar(new DictationGrammar());
                VAtypeENG.SpeechRecognized += VAtypeENG_SpeechRecognized;
                VAtypeENG.SetInputToDefaultAudioDevice();
            }
            catch (Exception Ex)
            {
                //Error....................
            }
        }

        private void VAtypeENG_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string temp = (e.Result.Text.ToLower()).ToString();
            temp = temp.Replace(" ", "");
            string temp1 = e.Result.Text.ToString();
            temp1 = temp1.Replace(" ", "");
            if (temp != "enter")
            {
                vbs.TypeMaster.Text += temp1;
            }
            else if (temp == "enter")
            {
                VAtypeENG.RecognizeAsyncStop();
                vaSection = 9;
                TalkBack_("do you think text entries as:" + vbs.TypeMaster.Text + "is correct?");
            }
        }

        private void VA_Commands_()
        {
            VA_Commands.Add(new string[] {"yes I do", "no I don't"});
            GrammarBuilder grammarBuilder_ = new GrammarBuilder();
            grammarBuilder_.Append(VA_Commands);
            Grammar grammar_ = new Grammar(grammarBuilder_);
            try
            {
                VA_Eng.LoadGrammar(grammar_);
                VA_Eng.SetInputToDefaultAudioDevice();
                VA_Eng.SpeechRecognized += VA_Eng_SpeechRecognized;
            }
            catch (Exception ex)
            {
                //error handle
            }
        }

        private void ByeText_()
        {
            DateTime byeUser = DateTime.Now;

            if (byeUser.Hour >= 5 && byeUser.Hour < 12)
            {
                byeText = "have a great morning";
            }
            else if (byeUser.Hour >= 12 && byeUser.Hour < 17)
            {
                byeText = "have a great afternoon";
            }
            else if (byeUser.Hour >= 17 && byeUser.Hour < 24)
            {
                byeText = "have a great evening";
            }
            else
            {
                byeText = "good night";
            }
        }

        private void VA_Eng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "yes I do":
                    {
                        if (vaExcOrdr == 1)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 3;
                            TalkBack_("okay, please stand by");
                        }
                        else if (vaExcOrdr == 2)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            EventHandler handler = WindowHide_;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaExcOrdr = 0;
                            vaSection = 3;
                            TalkBack_("okay, please stand by");
                        }
                        else if (vaExcOrdr == 3)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            VaInsertText();
                        }
                        else if (vaExcOrdr == 4)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 19;
                            TalkBack_("alright!");
                            selectComposeTab();
                        }
                        else if (vaExcOrdr == 5)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 29;
                            TalkBack_("alright!");
                            selectInboxTab();
                        }
                        else if (vaExcOrdr == 6)
                         {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 37;
                            TalkBack_("alright!");
                            selectSentTab();
                        }
                        else if (vaExcOrdr == 7)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 43;
                            TalkBack_("alright!");
                            selectDraftTab();
                        }
                        else if (vaExcOrdr == 8)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 52;
                            TalkBack_("alright!");
                            selectSettingTab();
                        }
                        else if (vaExcOrdr == 9)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 5;
                            TalkBack_("alright, ");
                        }
                        else if (vaExcOrdr == 10)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = SetMailSend;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        else if (vaExcOrdr == 11)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = SetMailDraft;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        else if (vaExcOrdr == 12)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            mCount = mailCount;
                            cmmndRead = 1;
                            EventHandler handler = ReadInboxMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 33;
                            TalkBack_(readMessage);
                        }
                        else if (vaExcOrdr == 13)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            if (mailCount != inbTotlaMail)
                            {
                                mailCount++;
                                EventHandler handler = inboxMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                MailRetrieveStart_();
                            }
                            else if (mailCount == inbTotlaMail)
                            {
                                mailCount = 1;
                                EventHandler handler = inboxMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                MailRetrieveStart_();
                            }
                        }
                        else if (vaExcOrdr == 14)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;                         
                            EventHandler handler = ReadInboxMailReply;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 21;
                            TalkBack_(", ");
                        }
                        else if (vaExcOrdr == 15)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = ReadInboxMailForward;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 36;
                            TalkBack_("what should be the address?");
                        }
                        else if (vaExcOrdr == 16)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            mailCount = 0;
                            mCount = 0;
                            readMessage = null;
                            EventHandler handler = ReadInboxMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 31;
                            TalkBack_("okay, message has been deleted");
                        }
                        else if (vaExcOrdr == 17)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            cmmndRead_ = 1;
                            EventHandler handler = ReadSentMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 41;
                            TalkBack_(readMessage);
                        }
                        else if (vaExcOrdr == 18)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            if (sentCount!= sntTotalMail)
                            {
                                sentCount++;
                                EventHandler handler = sentMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                SentRetrieveStart_();
                            }
                            else if (sentCount == sntTotalMail)
                            {
                                sentCount = 1;
                                EventHandler handler = sentMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                SentRetrieveStart_();
                            }
                        }
                        else if (vaExcOrdr == 19)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = ReadSentMailForward;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 36;
                            TalkBack_("what should be the address?");
                        }
                        else if (vaExcOrdr == 20)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;   
                            sentCount = 0;
                            readMessage = null;
                            EventHandler handler = ReadSentMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 39;
                            TalkBack_("okay, message has been deleted");
                        }
                        else if (vaExcOrdr == 21)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            cmmndRead__ = 1;
                            EventHandler handler = ReadDraftMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 45;
                            TalkBack_(readMessage);
                        }
                        else if (vaExcOrdr == 22)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            draftCount = 0;
                            EventHandler handler = ReadDraftMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 47;
                            TalkBack_("okay, message has been deleted");

                        }
                        else if (vaExcOrdr == 23)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            if (draftCount != drftTotalMail)
                            {
                                draftCount++;
                                EventHandler handler = draftMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                DraftRetrieveStart_();
                            }
                            else if (draftCount == drftTotalMail)
                            {
                                draftCount = 1;
                                EventHandler handler = draftMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                DraftRetrieveStart_();
                            }
                        }
                        else if (vaExcOrdr == 24)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 19;
                            TalkBack_("alright!");
                        }
                        else if (vaExcOrdr == 25)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 56;
                            TalkBack_("alright! virtual assistant will be turned off after application will restarts, please wait");
                        }
                        else if (vaExcOrdr == 26)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 57;
                            TalkBack_("alright! gmail will be signed out, please wait while the application restarts");
                        }
                        else if (vaExcOrdr == 27)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 58;
                            TalkBack_("alright! application's data will be reset, please wait while the application restarts");
                        }
                        break;
                    }
                case "no I don't":
                    {
                        if (vaExcOrdr == 1)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 2;
                            ByeText_();
                            TalkBack_("okay, i will go back to sleep then, " + byeText);
                        }
                        else if (vaExcOrdr == 2)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            EventHandler handler = WindowHide_;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaExcOrdr = 0;
                            vaSection = 2;
                            ByeText_();
                            TalkBack_("okay, i will go back to sleep then, " + byeText);
                        }
                        else if (vaExcOrdr == 3)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 13;
                            TalkBack_("okay! lets try again");
                        }
                        else if (vaExcOrdr == 4)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 14;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 5)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 15;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 6)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 16;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 7)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 17;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 8)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 18;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 9)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            EventHandler handler = WindowHide_;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaExcOrdr = 0;
                            vaSection = 2;
                            ByeText_();
                            TalkBack_("okay, I will go back to sleep then, " + byeText);
                        }
                        else if (vaExcOrdr == 10)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 26;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 11)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = SetMailClear;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 27;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 12)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 31;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 13)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 32;
                            mailCount = 0;
                            mCount = 0;
                            cmmndRead = 0;
                            readMessage = null;
                            TalkBack_("alright! ");
                        }
                        else if (vaExcOrdr == 14)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 34;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 15)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 35;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 16)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = ReadInboxMailClose;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 31;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 17)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 39;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 18)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 40;
                            sentCount = 0;
                            cmmndRead_ = 0;
                            readMessage = null;
                            TalkBack_("alright! ");
                        }
                        else if (vaExcOrdr == 19)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 42;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 20)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = ReadSentMailClose;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            vaSection = 39;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 21)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 46;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 22)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 47;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 23)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 48;
                            draftCount = 0;
                            TalkBack_("alright! ");
                        }
                        else if (vaExcOrdr == 24)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            EventHandler handler = SetMailClear;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            draftCount = 0;
                            vaSection = 27;
                            TalkBack_("alright! ");
                        }
                        else if (vaExcOrdr == 25)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 53;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 26)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 54;
                            TalkBack_("okay, ");
                        }
                        else if (vaExcOrdr == 27)
                        {
                            VA_Eng.RecognizeAsyncStop();
                            vaExcOrdr = 0;
                            vaSection = 55;
                            TalkBack_("okay, ");
                        }
                        break;
                    }
            }
        }

        private void VaInsertText()
        {
            switch (vAsectn)
            {
                case 1:
                    {
                        lg.userName.Text = String.Empty;
                        lg.userName.LineIdleColor = System.Drawing.Color.Gray;
                        lg.userName.Text = (vbs.TypeMaster.Text + "@gmail.com").ToLower();
                        lg.userName.Text = lg.userName.Text.Replace(" ", "");
                        vaSection = 10;
                        TalkBack_("username inserted as:" + lg.userName.Text + "< ");
                        vAsectn = 0;
                        break;
                    }
                case 2:
                    {
                        lg.passWord.Text = String.Empty;
                        lg.passWord.isPassword = true;
                        lg.passWord.LineIdleColor = System.Drawing.Color.Gray;
                        lg.passWord.Text = (vbs.TypeMaster.Text).ToLower();
                        lg.passWord.Text = lg.passWord.Text.Replace(" ", "");
                        vaSection = 12;
                        TalkBack_("password inserted as:" + lg.passWord.Text + ", ");
                        vAsectn = 0;
                        break;
                    }
                case 3:
                    {
                        string temp = (vbs.TypeMaster.Text + "@gmail.com").ToLower();
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetAddress.SetMailToText(temp);
                        vaSection = 21;
                        TalkBack_("address inserted as:" + temp + ", ");
                        vAsectn = 0;
                        break;
                    }
                case 4:
                    {
                        string temp = vbs.TypeMaster.Text;
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetSubject.SetMailSubjectText(temp);
                        vaSection = 23;
                        TalkBack_("title inserted as:" + temp + ", ");
                        vAsectn = 0;
                        break;
                    }
                case 5:
                    {
                        string temp = vbs.TypeMaster.Text;
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetBody.SetMailBodyText(temp);
                        vaSection = 25;
                        TalkBack_("summary inserted as:" + temp + ", ");
                        vAsectn = 0;
                        break;
                    }
                case 6:
                    {
                        string temp = (vbs.TypeMaster.Text + "@gmail.com").ToLower();
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetAddress.SetMailToText(temp);
                        vaSection = 25;
                        TalkBack_("address inserted as:" + temp + ", ");
                        vAsectn = 0;
                        break;
                    }
            }
            vbs.TypeMaster.Text = String.Empty;
            vbs.Close();
        }

        private void loginDelay_Tick(object sender, EventArgs e)
        {
            CheckloginState();
            loginDelay.Stop();
        }

        private void afterLoginDelay_Tick(object sender, EventArgs e)
        {
            afterLoginDelay.Stop();
            TalkBack_("would you like to write a new mail?");
            vaExcOrdr = 4;
            VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void compDelay_Tick(object sender, EventArgs e)
        {
            compDelay.Stop();
            vaSection = 20;
            TalkBack_("what should be the address?");
        }

        private void inboxDelay_Tick(object sender, EventArgs e)
        {
            inboxDelay.Stop();
            if (inbTotlaMail != 0)
            {
                mailCount = 1;
                EventHandler handler = inboxMesNameRet;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                MailRetrieveStart_();
            }
            else if (inbTotlaMail == 0)
            {
                vaSection = 32;
                TalkBack_("oh, snap! looks like your inbox is empty! ");
            }
        }

        private void afterInbDelDelay_Tick(object sender, EventArgs e)
        {
            afterInbDelDelay.Stop();
            if (inbTotlaMail != 0)
            {
                vaSection = 49;
                TalkBack_("would you like me to get the next message?");
            }
            else if (inbTotlaMail == 0)
            {
                vaSection = 32;
                TalkBack_("oh, snap! looks like your inbox is empty! ");
            }
        }

        private void sentDelay_Tick(object sender, EventArgs e)
        {
            sentDelay.Stop();
            if (sntTotalMail != 0)
            {
                sentCount = 1;
                EventHandler handler = sentMesNameRet;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                SentRetrieveStart_();
            }
            else if (sntTotalMail == 0)
            {
                vaSection = 40;
                TalkBack_("oh, snap! looks like your sent is empty! ");
            }
        }

        private void afterSntDelDelay_Tick(object sender, EventArgs e)
        {
            afterSntDelDelay.Stop();
            if (sntTotalMail != 0)
            {
                vaSection = 50;
                TalkBack_("would you like me to get the next message?");
            }
            else if (sntTotalMail == 0)
            {
                vaSection = 40;
                TalkBack_("oh, snap! looks like your sent is empty! ");
            }
        }

        private void draftDelay_Tick(object sender, EventArgs e)
        {
            draftDelay.Stop();
            if (drftTotalMail != 0)
            {
                draftCount = 1;
                EventHandler handler = draftMesNameRet;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
                DraftRetrieveStart_();
            }
            else if (drftTotalMail == 0)
            {
                vaSection = 48;
                TalkBack_("oh, snap! looks like your draft is empty! ");
            }
        }

        private void afterDrftDelDelay_Tick(object sender, EventArgs e)
        {
            afterDrftDelDelay.Stop();
            if (drftTotalMail != 0)
            {
                vaSection = 51;
                TalkBack_("would you like me to get the next message?");
            }
            else if (drftTotalMail == 0)
            {
                vaSection = 48;
                TalkBack_("oh, snap! looks like your draft is empty! ");
            }
        }

        private void settingsDelay_Tick(object sender, EventArgs e)
        {
            settingsDelay.Stop();
            TalkBack_("would you like to turn off virtual assistant?");
            vaExcOrdr = 25;
            VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void taskFinishtklDelay_Tick(object sender, EventArgs e)
        {
            taskFinishtklDelay.Stop();
            vaSection = 18;
            TalkBack_(", ");
        }

        private void AfterReadDelay_Tick(object sender, EventArgs e)
        {
            AfterReadDelay.Stop();
            TalkBack_("would you like to reply to it?");
            vaExcOrdr = 14;
            VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void AfterReadDelaySent_Tick(object sender, EventArgs e)
        {
            AfterReadDelaySent.Stop();
            TalkBack_("would you like to forward it?");
            vaExcOrdr = 19;
            VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void AfterReadDelayDraft_Tick(object sender, EventArgs e)
        {
            AfterReadDelayDraft.Stop();
            cmmndRead__ = 0;
            readMessage = null;
            TalkBack_("would you like to modify it?");
            vaExcOrdr = 24;
            VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void TalkBk__SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            VA_state();
            if (vaSection == 0)
            {
                vaSection = -1;
                vaTimer.Start();
            }
            else if (vaSection == 1)
            {
                vaSection = -1;
                vaExcOrdr = 1;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 2)
            {
                vaSection = -1;
                vASleepAc();
            }
            else if (vaSection == 3)
            {
                vaSection = -1;
                lg = new login();
                lg.Show();
                loginDelay.Start();
            }
            else if (vaSection == 4)
            {
                vaSection = -1;
                TalkBack_("would you like to retry?");
                vaExcOrdr = 2;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 5)
            {
                vaSection = -1;
                afterLoginDelay.Start();
            }
            else if (vaSection == 6)
            {
                vaSection = -1;
                TalkBack_("would you like to retry?");
                vaExcOrdr = 2;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 7)
            {
                vaSection = 8;
                TalkBack_("what is your username?");
            }
            else if (vaSection == 8)
            {
                vaSection = -1;
                vAsectn = 1;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 9)
            {
                vaSection = -1;
                vaExcOrdr = 3;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 10)
            {
                vaSection = 11;
                TalkBack_("what is your password?");
            }
            else if (vaSection == 11)
            {
                vaSection = -1;
                vAsectn = 2;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 12)
            {
                vaSection = -1;
                lg.btnCheck.Checked = true;
                EventHandler handler = VBLogin_;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
            else if (vaSection == 13)
            {
                vaSection = -1;
                vbs.TypeMaster.Text = String.Empty;
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 14)
            {
                vaSection = -1;
                TalkBack_("would you like to check out inbox?");
                vaExcOrdr = 5;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 15)
            {
                vaSection = -1;
                TalkBack_("would you like to check out sent?");
                vaExcOrdr = 6;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 16)
            {
                vaSection = -1;
                TalkBack_("would you like to check out draft?");
                vaExcOrdr = 7;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 17)
            {
                vaSection = -1;
                TalkBack_("would you like to check out application settings?");
                vaExcOrdr = 8;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 18)
            {
                vaSection = -1;
                TalkBack_("would you like to have further assist?");
                vaExcOrdr = 9;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 19)
            {
                vaSection = -1;
                compDelay.Start();
            }
            else if (vaSection == 20)
            {
                vaSection = -1;
                vAsectn = 3;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 21)
            {
                vaSection = 22;
                TalkBack_("what should be the title?");
            }
            else if (vaSection == 22)
            {
                vaSection = -1;
                vAsectn = 4;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 23)
            {
                vaSection = 24;
                TalkBack_("what should be the summary?");
            }
            else if (vaSection == 24)
            {
                vaSection = -1;
                vAsectn = 5;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 25)
            {
                vaSection = -1;
                TalkBack_("would you like to send it?");
                vaExcOrdr = 10;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 26)
            {
                vaSection = -1;
                TalkBack_("would you like to draft it?");
                vaExcOrdr = 11;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 27)
            {
                closeComposeTab();
                taskFinishtklDelay.Start();
            }
            else if (vaSection == 28)
            {
                vaSection = 19;
                TalkBack_("let's try again! ");
            }
            else if (vaSection == 29)
            {
                vaSection = -1;
                inboxDelay.Start();
            }
            else if (vaSection == 30)
            {
                vaSection = -1;
                vaExcOrdr = 12;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 31)
            {
                vaSection = -1;
                afterInbDelDelay.Start();
            }
            else if (vaSection == 32)
            {
                vaSection = -1;
                closeInboxTab();
                taskFinishtklDelay.Start();
            }
            else if (vaSection == 33)
            {
                vaSection = -1;
                AfterReadDelay.Start();
            }
            else if (vaSection == 34)
            {
                vaSection = -1;
                TalkBack_("would you like to forward it?");
                vaExcOrdr = 15;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 35)
            {
                vaSection = -1;
                TalkBack_("would you like to delete it?");
                vaExcOrdr = 16;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 36)
            {
                vaSection = -1;
                vAsectn = 6;
                ShowScratchpad();
                VAtypeENG.RecognizeAsync(RecognizeMode.Multiple);
                VAResetAuto.Stop();
            }
            else if (vaSection == 37)
            {
                vaSection = -1;
                sentDelay.Start();
            }
            else if (vaSection == 38)
            {
                vaSection = -1;
                vaExcOrdr = 17;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 39)
            {
                vaSection = -1;
                afterSntDelDelay.Start();
            }
            else if (vaSection == 40)
            {
                vaSection = -1;
                closeSentTab();
                taskFinishtklDelay.Start();
            }
            else if (vaSection == 41)
            {
                vaSection = -1;
                AfterReadDelaySent.Start();
            }
            else if (vaSection == 42)
            {
                vaSection = -1;
                TalkBack_("would you like to delete it?");
                vaExcOrdr = 20;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 43)
            {
                vaSection = -1;
                draftDelay.Start();
            }
            else if (vaSection == 44)
            {
                vaSection = -1;
                vaExcOrdr = 21;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 45)
            {
                vaSection = -1;
                AfterReadDelayDraft.Start();
            }
            else if (vaSection == 46)
            {
                vaSection = -1;
                TalkBack_("would you like to delete it?");
                vaExcOrdr = 22;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 47)
            {
                vaSection = -1;
                afterDrftDelDelay.Start();
            }
            else if (vaSection == 48)
            {
                vaSection = -1;
                closeDraftTab();
                taskFinishtklDelay.Start();
            }
            else if (vaSection == 49)
            {
                vaSection = -1;
                vaExcOrdr = 13;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 50)
            {
                vaSection = -1;
                vaExcOrdr = 18;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 51)
            {
                vaSection = -1;
                vaExcOrdr = 23;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 52)
            {
                vaSection = -1;
                settingsDelay.Start();
            }
            else if (vaSection == 53)
            {
                vaSection = -1;
                TalkBack_("would you like to sign out from gmail?");
                vaExcOrdr = 26;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 54)
            {
                vaSection = -1;
                TalkBack_("would you like application data to reset?");
                vaExcOrdr = 27;
                VA_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            else if (vaSection == 55)
            {
                vaSection = -1;
                closeSettingTab();
                taskFinishtklDelay.Start();
            }
            else if (vaSection == 56)
            {
                EventHandler handler = SetVAOff;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
            else if (vaSection == 57)
            {
                EventHandler handler = SetSignOut;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
            else if (vaSection == 58)
            {
                EventHandler handler = SetResetAll;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void MailRetrieveStart_()
        {
            vaSection = 30;
            readMessage = null;
            TalkBack_("message number:" + mailCount + ", sender name:" + inboMesName+", would you like me to read it?");
            switch (mailCount)
            {
                case 1:
                    {
                        EventHandler handler = InboxScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void SentRetrieveStart_()
        {
            vaSection = 38;
            readMessage = null;
            TalkBack_("message number:" + sentCount + ", title:" + sntMesName + ", would you like me to read it?");
            switch (sentCount)
            {
                case 1:
                    {
                        EventHandler handler = SentScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void DraftRetrieveStart_()
        {
            vaSection = 44;
            readMessage = null;
            TalkBack_("message number:" + draftCount + ", title:" + drftMesName + ", would you like me to read it?");
            switch (draftCount)
            {
                case 1:
                    {
                        EventHandler handler = DraftScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void CheckloginState()
        {
            string usr, pas;
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt";
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                usr = lines[2].ToString();
                pas = lines[4].ToString();
                if (usr != String.Empty && pas != String.Empty)
                {
                    EventHandler handler = VBLogin_;
                    if (handler != null)
                    {
                        handler(this, new EventArgs());
                    }
                }
                else if (usr == String.Empty && pas == String.Empty)
                {
                    vaSection = 7;
                    TalkBack_("I can not find your sign in credentials");
                }
            }
        }

        private void vASleepAc()
        {
            VB_Master_Sound = new SoundPlayer("VB_Sleep.wav");
            VB_Master_Sound.Play();
            VBDisplay.Text = "VB: Sleeping........!";
            PowerBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            VBDisplay.ForeColor = System.Drawing.Color.LightSeaGreen;
            MasterIgnore = 0;
            vaSection = 0;
        }

        public void TalkBack(string tts)
        {
            try
            {
                TalkBk.Volume = 100;
                TalkBk.Rate = -1;
                TalkBk.SelectVoice("Microsoft Zira Desktop");
                TalkBk.SetOutputToDefaultAudioDevice();
                TalkBk.SpeakAsync(tts);
            }
            catch (Exception ex)
            {
                //
            }
        }

        public void TalkBack_(string tts)
        {
            try
            {
                TalkBk_.Volume = 100;
                TalkBk_.Rate = -1;
                TalkBk_.SelectVoice("Microsoft Zira Desktop");
                TalkBk_.SetOutputToDefaultAudioDevice();
                TalkBk_.SpeakAsync(tts);
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void Mw_VBbackToIdleActn(object sender, EventArgs e)
        {
            MasterOnOff.Interval = 50;
        }

        private void TalkBk_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            MasterOnOff.Interval = 50;
        }

        private void PreCheck()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    string state = lines[2].ToString();
                    if (state.Equals("Virtual-Assistant = 0"))
                    {
                        VirAssist = 1;
                    }
                    else if (state.Equals("Virtual-Assistant = 1"))
                    {
                        VirAssist = 2;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void VoiceBox_Master()
        {
            VB_Master.Add(new string[] { "Hey Voice Box" });
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(VB_Master);
            Grammar grammar = new Grammar(grammarBuilder);
            try
            {
                VB_Mas_Eng.LoadGrammar(grammar);
                VB_Mas_Eng.SetInputToDefaultAudioDevice();
                VB_Mas_Eng.SpeechRecognized += VB_Mas_Eng_SpeechRecognized;
                VB_Mas_Eng.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                //error handle
            }
        }

        private void VoiceBox_Commands()
        {
            VB_Commands.Add(new string[] { "wake up", "go to sleep", "username", 
            "password", "confirm", "try again", "go next", "sign in", "select",
            "close", "compose", "inbox", "sent", "draft", "settings", "summary",
            "address", "title", "message", "clear", "send", "do","virtual assist on",
            "reset all", "sign out", "retrieve", "read","next", "reply", "forward", 
            "delete", "break", });
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(VB_Commands);
            Grammar grammar = new Grammar(grammarBuilder);
            try
            {
                VB_Command_Eng.LoadGrammar(grammar);
                VB_Command_Eng.SetInputToDefaultAudioDevice();
                VB_Command_Eng.SpeechRecognized += VB_Command_Eng_SpeechRecognized;
            }
            catch(Exception ex)
            {
                //error handle
            }
        }

        private void VB_Command_Eng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "wake up":
                    {
                        if (lgVis == 0)
                        {
                            GetTheActiveForm();
                            lgVis = 1;
                            VBState();
                            MasterOnOff.Interval = 90000;
                        }
                        
                        break;
                    }
                case "go to sleep":
                    {
                        if (lgVis == 1)
                        {
                            SendEvent();
                            VB_MasterSleep();
                        }
                        
                        break;
                    }
                case "sign in":
                    {
                        if (cmmndOpen == 1)
                        {
                            cmmndOpen = 2;
                            lgVis = 0;
                            VBState();
                            Accknldgmnt();
                        }

                        break;
                    }
                case "username":
                    {
                        if (cmmndOpen == 2)
                        {
                            MasterOnOff.Stop();
                            VBState();
                            sectn = 1;
                            cmmndOpen = 0;
                            ShowScratchpad();
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);                            
                            TalkBack("proceed");
                        }
                        break;
                    }
                case "password":
                    {
                        if (cmmndOpen == 2)
                        {
                            MasterOnOff.Stop();
                            VBState();
                            sectn = 2;
                            cmmndOpen = 0;
                            ShowScratchpad();
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);
                            TalkBack("proceed");
                        }
                        break;
                    }
                case "confirm":
                    {
                        if (conf == 1)
                        {
                            conf = 0;
                            InsertTheText();
                        }
                        break;
                    }
                case "try again":
                    {
                        if (conf == 1)
                        {
                            conf = 0;
                            TalkBack("okay");
                            vbs.TypeMaster.Text = String.Empty;
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);
                        }
                        break;
                    }
                case "go next":
                    {
                        if (cmmndOpen == 2)
                        {
                            if (lg.userName.Text != "Username" && lg.passWord.Text != "Password")
                            {
                                VBState();
                                MasterOnOff.Interval = 90000;
                                lg.btnCheck.Checked = true;
                                cmmndOpen = 0;
                                lgVis = 1;
                                TalkBack("Please stand by");
                                RequestLogin();
                            }
                        }
                        break;
                    }
                case "select":
                    {
                        if (navMenu == 1)
                        {
                            VBState();
                            Accknldgmnt();
                            navMenu = 0;
                            activeCmd = 0;
                            composeOpt = 1;
                            inboxOpt = 1;
                            sentOpt = 1;
                            draftOpt = 1;
                            settingOpt = 1;
                            lgVis = 0;
                            navCmd = 1;
                        }
                        break;
                    }
                case "close":
                    {
                        if (closeOpt == 1)
                        {
                            closeOpt = 0;
                            lgVis = 0;
                            VBState();
                            if (activeCmd == 1)
                            {
                                activeCmd = 0;
                                composeOpt = 2;
                                Accknldgmnt();
                            }
                            else if (activeCmd == 2)
                            {
                                activeCmd = 0;
                                inboxOpt = 2;
                                Accknldgmnt();
                            }
                            else if (activeCmd == 3)
                            {
                                activeCmd = 0;
                                sentOpt = 2;
                                Accknldgmnt();
                            }
                            else if (activeCmd == 4)
                            {
                                activeCmd = 0;
                                draftOpt = 2;
                                Accknldgmnt();
                            }
                            else if (activeCmd == 5)
                            {
                                activeCmd = 0;
                                settingOpt = 2;
                                Accknldgmnt();
                            }
                        }
                        else if (inboRet == 3 && inboRead == 1)
                        {
                            inboRet = 0;
                            inboxCmmnd = 1;
                            cmmndRead = 0;
                            inboRead = 0;
                            lgVis = 1;
                            mCount = 0;
                            readMessage = null;
                            closeOpt = 1;
                            TalkBack("reader stopped");
                            EventHandler handler = ReadInboxMailClose;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        else if (sntRet == 3 && sntRead == 1)
                        {
                            closeOpt = 0;
                            sntRet = 0;
                            sentCmmnd = 1;
                            cmmndRead_ = 0;
                            sntRead = 0;
                            lgVis = 1;
                            readMessage = null;
                            closeOpt = 1;
                            TalkBack("reader stopped");
                            EventHandler handler = ReadSentMailClose;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
                case "compose":
                    {
                        if (composeOpt == 1)
                        {
                            selectComposeTab();
                            VBState();
                            MasterOnOff.Interval = 90000;
                            TalkBack("Compose tab selected");
                            composeOpt = 0;
                            inboxOpt = 0;
                            sentOpt = 0;
                            draftOpt = 0;
                            closeOpt = 1;
                            settingOpt = 0;
                            activeCmd = 1;
                            mailCmmnd = 1;
                            ingcmpsaddr = 0;
                            ingcmpsttl_ssmry = 0;
                            lgVis = 1;
                            navCmd = 0;
                        }
                        else if (composeOpt == 2)
                        {
                            closeComposeTab();
                            VBState();
                            MasterOnOff.Interval = 90000;
                            TalkBack("Compose tab closed");
                            closeOpt = 0;
                            composeOpt = 0;
                            navMenu = 1;
                            mailCmmnd = 0;
                            ingcmpsaddr = 0;
                            ingcmpsttl_ssmry = 0;
                            lgVis = 1;
                            cmmndRead__ = 0;
                        }
                        break;
                    }
                case "message":
                    {
                        if (mailCmmnd == 1 && awitTillRead__ != 1)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            mailCmmnd = 2;
                            closeOpt = 0;
                        }
                        else if (inboxCmmnd == 1 && inbTotlaMail != 0)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            inboRet = 1;
                            inboxCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (inboxCmmnd == 2)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            inboRet = 2;
                            inboxCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (inboxCmmnd == 3 && awitTillRead != 1)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            inboRet = 3;
                            inboxCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (sentCmmnd == 1 && sntTotalMail != 0)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            sntRet = 1;
                            sentCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (sentCmmnd == 2)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            sntRet = 2;
                            sentCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (sentCmmnd == 3 && awitTillRead_ != 1)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            sntRet = 3;
                            sentCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (draftCmmnd == 1 && drftTotalMail != 0)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            drftRet = 1;
                            draftCmmnd = 0;
                            closeOpt = 0;
                        }
                        else if (draftCmmnd == 2)
                        {
                            VBState();
                            Accknldgmnt();
                            lgVis = 0;
                            drftRet = 2;
                            draftCmmnd = 0;
                            closeOpt = 0;
                        }
                        break;
                    }
                case "address":
                    {
                        if (mailCmmnd == 2 && ingcmpsaddr != 1)
                        {
                            MasterOnOff.Stop();
                            VBState();
                            sectn = 3;
                            mailCmmnd = 1;
                            ShowScratchpad();
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);
                            TalkBack("proceed");
                        }
                        break;
                    }
                case "title":
                    {
                        if (mailCmmnd == 2 && ingcmpsttl_ssmry != 1)
                        {
                            MasterOnOff.Stop();
                            VBState();
                            sectn = 4;
                            mailCmmnd = 1;
                            ShowScratchpad();
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);
                            TalkBack("proceed");
                        }
                        break;
                    }
                case "summary":
                    {
                        if (mailCmmnd == 2 && ingcmpsttl_ssmry != 1)
                        {
                            MasterOnOff.Stop();
                            VBState();
                            sectn = 5;
                            mailCmmnd = 1;
                            ShowScratchpad();
                            VB_Command_Eng.RecognizeAsyncStop();
                            typeENG.RecognizeAsync(RecognizeMode.Multiple);
                            TalkBack("proceed");
                        }
                        break;
                    }
                case "clear":
                    {
                        if (mailCmmnd == 2)
                        {
                            EventHandler handler = SetMailClear;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeOpt = 1;
                            lgVis = 1;
                            mailCmmnd = 1;
                            TalkBack("all fields are cleared");
                        }
                        break;
                    }
                case "send":
                    {
                        if(mailCmmnd == 2)
                        {
                            EventHandler handler = SetMailSend;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeOpt = 1;
                            mailCmmnd = 1;
                            lgVis = 1;
                        }
                        break;
                    }
                case "inbox":
                    {
                        if (inboxOpt == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            selectInboxTab();
                            TalkBack("Inbox selected");
                            composeOpt = 0;
                            inboxOpt = 0;
                            sentOpt = 0;
                            draftOpt = 0;
                            settingOpt = 0;
                            closeOpt = 1;
                            activeCmd = 2;
                            inboxCmmnd = 1;
                            lgVis = 1;
                            navCmd = 0;
                        }
                        else if (inboxOpt == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeInboxTab();
                            TalkBack("Inbox closed");
                            closeOpt = 0;
                            inboxOpt = 0;
                            inboxCmmnd = 0;
                            navMenu = 1;
                            lgVis = 1;
                        }
                        break;
                    }
                case "sent":
                    {
                        if (sentOpt == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            selectSentTab();
                            TalkBack("Sent selected");
                            composeOpt = 0;
                            inboxOpt = 0;
                            sentOpt = 0;
                            draftOpt = 0;
                            settingOpt = 0;
                            closeOpt = 1;
                            activeCmd = 3;
                            sentCmmnd = 1;
                            lgVis = 1;
                            navCmd = 0;
                        }
                        else if (sentOpt == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeSentTab();
                            TalkBack("Sent closed");
                            closeOpt = 0;
                            sentOpt = 0;
                            sentCmmnd = 0;
                            navMenu = 1;
                            lgVis = 1;
                        }
                        break;
                    }
                case "draft":
                    {
                        if (draftOpt == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            selectDraftTab();
                            TalkBack("Draft selected");
                            composeOpt = 0;
                            inboxOpt = 0;
                            sentOpt = 0;
                            draftOpt = 0;
                            settingOpt = 0;
                            closeOpt = 1;
                            activeCmd = 4;
                            draftCmmnd = 1;
                            lgVis = 1;
                            navCmd = 0;
                        }
                        else if (draftOpt == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeDraftTab();
                            TalkBack("Draft closed");
                            closeOpt = 0;
                            draftOpt = 0;
                            draftCmmnd = 0;
                            navMenu = 1;
                            lgVis = 1;
                        }
                        else if (mailCmmnd == 2 )
                        {
                            EventHandler handler = SetMailDraft;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeOpt = 1;
                            mailCmmnd = 1;
                            lgVis = 1;
                        }
                        break;
                    }
                case "retrieve":
                    {
                        if (inboRet == 1)
                        {
                            inboxCmmnd = 2;
                            inboRet = 0;
                            mailCount = 1;
                            readMessage = null;
                            EventHandler handler = inboxMesNameRet;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            MailRetrieveStart();
                        }
                        else if (sntRet == 1)
                        {
                            sentCmmnd = 2;
                            sntRet = 0;
                            sentCount = 1;
                            readMessage = null;
                            EventHandler handler = sentMesNameRet;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            SentRetrieveStart();
                        }
                        else if (drftRet == 1)
                        {
                            draftCmmnd = 2;
                            drftRet = 0;
                            draftCount = 1;
                            readMessage = null;
                            EventHandler handler = draftMesNameRet;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            VBState();
                            MasterOnOff.Interval = 90000;
                            DraftRetrieveStart();
                        }
                        break;
                    }
                case "read":
                    {
                        if (inboRet == 2 && inboRead == 0)
                        {
                            VBState();
                            MasterOnOff.Interval = 900000;
                            inboxCmmnd = 3;
                            awitTillRead = 1;
                            mCount = mailCount;
                            cmmndRead = 1;
                            inboRead = 1;
                            inboRet = 0;
                            EventHandler handler = ReadInboxMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack(readMessage);
                        }
                        else if (sntRet == 2 && sntRead == 0)
                        {
                            VBState();
                            MasterOnOff.Interval = 900000;
                            sentCmmnd = 3;
                            awitTillRead_ = 1;
                            cmmndRead_ = 1;
                            sntRead = 1;
                            sntRet = 0;
                            EventHandler handler = ReadSentMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack(readMessage);
                        }
                        else if (drftRet == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 900000;
                            awitTillRead__ = 1;
                            activeCmd = 1;
                            mailCmmnd = 1;
                            cmmndRead__ = 1;
                            drftRet = 0;
                            draftCmmnd = 0;
                            EventHandler handler = ReadDraftMail;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack(readMessage);
                        }
                        break;
                    }
                case "reply":
                    {
                        if (inboRet == 3 && inboRead == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            inboRet = 0;
                            inboxCmmnd = 0;
                            activeCmd = 1;
                            mailCmmnd = 1;
                            cmmndRead = 0;
                            inboRead = 0;
                            ingcmpsaddr = 1;
                            mCount = 0;
                            readMessage = null;
                            TalkBack("composetab opened to reply");
                            EventHandler handler = ReadInboxMailReply;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
                case "forward":
                    {
                        if (inboRet == 3 && inboRead == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            inboRet = 0;
                            inboxCmmnd = 0;
                            activeCmd = 1;
                            mailCmmnd = 1;
                            cmmndRead = 0;
                            inboRead = 0;
                            mCount = 0;
                            ingcmpsttl_ssmry = 1;
                            readMessage = null;
                            TalkBack("composetab opened to forward");
                            EventHandler handler = ReadInboxMailForward;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        else if (sntRet == 3 && sntRead == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            sntRet = 0;
                            sentCmmnd = 0;
                            activeCmd = 1;
                            mailCmmnd = 1;
                            cmmndRead_ = 0;
                            sntRead = 0;
                            ingcmpsttl_ssmry = 1;
                            readMessage = null;
                            TalkBack("composetab opened to forward");
                            EventHandler handler = ReadSentMailForward;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
                case "delete":
                    {
                        if (inboRet == 3 && inboRead == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            inboxCmmnd = 1;
                            inboRet = 0;
                            inboRead = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            mCount = 0;
                            readMessage = null;
                            EventHandler handler = ReadInboxMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack("item deleted");
                        }
                        else if (sntRet == 3 && sntRead == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            sentCmmnd = 1;
                            sntRet = 0;
                            sntRead = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            readMessage = null;
                            EventHandler handler = ReadSentMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack("item deleted");
                        }
                        else if (drftRet == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            draftCmmnd = 1;
                            drftRet = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            readMessage = null;
                            EventHandler handler = ReadDraftMailDelete;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                            TalkBack("item deleted");
                        }
                        break;
                    }
                case "next":
                    {
                        if (inboRet == 2 && inboRead == 0)
                        {
                            inboxCmmnd = 2;
                            inboRet = 0;
                            if (mailCount != inbTotlaMail)
                            {
                                mailCount++;
                                EventHandler handler = inboxMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 900000;
                                MailRetrieveStart();
                            }
                            else if (mailCount == inbTotlaMail)
                            {
                                mailCount = 1;
                                EventHandler handler = inboxMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 900000;
                                MailRetrieveStart();
                            }
                        }
                        else if (sntRet == 2 && sntRead == 0)
                        {
                            sentCmmnd = 2;
                            sntRet = 0;
                            if (sentCount != sntTotalMail)
                            {
                                sentCount++;
                                EventHandler handler = sentMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 90000;
                                SentRetrieveStart();
                            }
                            else if (sentCount == sntTotalMail)
                            {
                                sentCount = 1;
                                EventHandler handler = sentMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 90000;
                                SentRetrieveStart();
                            }
                        }
                        else if (drftRet == 2)
                        {
                            draftCmmnd = 2;
                            drftRet = 0;
                            if (draftCount != drftTotalMail)
                            {
                                draftCount++;
                                EventHandler handler = draftMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 90000;
                                DraftRetrieveStart();
                            }
                            else if (draftCount == drftTotalMail)
                            {
                                draftCount = 1;
                                EventHandler handler = draftMesNameRet;
                                if (handler != null)
                                {
                                    handler(this, new EventArgs());
                                }
                                VBState();
                                MasterOnOff.Interval = 90000;
                                DraftRetrieveStart();
                            }
                        }
                        break;
                    }
                case "break":
                    {
                        if (inboRet == 2 && inboRead == 0)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            inboxCmmnd = 1;
                            inboRet = 0;
                            inboRead = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            TalkBack("retrieve canceled");
                        }
                        else if (sntRet == 2 && sntRead == 0)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            sentCmmnd = 1;
                            sntRet = 0;
                            sntRead = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            TalkBack("retrieve canceled");
                        }
                        else if (drftRet == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            draftCmmnd = 1;
                            drftRet = 0;
                            closeOpt = 1;
                            lgVis = 1;
                            TalkBack("retrieve canceled");
                        }
                        break;
                    }
                case "settings":
                    {
                        if (settingOpt == 1)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            selectSettingTab();
                            TalkBack("Settings selected");
                            setCmmnd = 1;
                            composeOpt = 0;
                            inboxOpt = 0;
                            sentOpt = 0;
                            draftOpt = 0;
                            settingOpt = 0;
                            closeOpt = 1;
                            activeCmd = 5;
                            lgVis = 1;
                            navCmd = 0;
                        }
                        else if (settingOpt == 2)
                        {
                            VBState();
                            MasterOnOff.Interval = 90000;
                            closeSettingTab();
                            TalkBack("Settings closed");
                            setCmmnd = 0;
                            closeOpt = 0;
                            settingOpt = 0;
                            navMenu = 1;
                            lgVis = 1;
                        }
                        break;
                    }
                case "do":
                    {
                        if (setCmmnd == 1)
                        {
                            VBState();
                            Accknldgmnt();
                            setCmmnd = 2;
                            closeOpt = 0;
                            lgVis = 0;
                        }
                        break;
                    }
                case "virtual assist on":
                    {
                        if (setCmmnd == 2)
                        {
                            closeOpt = 1;
                            setCmmnd = 1;
                            VB_MasterSleep();
                            TalkBack("Application will restart. Please stand by");
                            VB_Mas_Eng.RecognizeAsyncStop();
                            EventHandler handler = SetVAOn;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
                case "reset all":
                    {
                        if (setCmmnd == 2)
                        {
                            closeOpt = 1;
                            setCmmnd = 1;
                            VB_MasterSleep();
                            TalkBack("Application will restart. Please stand by");
                            VB_Mas_Eng.RecognizeAsyncStop();
                            EventHandler handler = SetResetAll;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
                case "sign out":
                    {
                        if (setCmmnd == 2)
                        {
                            closeOpt = 1;
                            setCmmnd = 1;
                            VB_MasterSleep();
                            TalkBack("Application will restart. Please stand by");
                            VB_Mas_Eng.RecognizeAsyncStop();
                            EventHandler handler = SetSignOut;
                            if (handler != null)
                            {
                                handler(this, new EventArgs());
                            }
                        }
                        break;
                    }
            }
        }

        private void Accknldgmnt()
        {
            VB_Master_Sound = new SoundPlayer("ScratchpadOpen.wav");
            VB_Master_Sound.Play();
        }

        private void MailRetrieveStart()
        {
            TalkBack("sender name" + inboMesName + ", index number" + mailCount);
            switch (mailCount)
            {
                case 1:
                    {
                        EventHandler handler = InboxScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = InboxScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void SentRetrieveStart()
        {
            TalkBack("title, " + sntMesName + ", index number" + sentCount);
            switch (sentCount)
            {
                case 1:
                    {
                        EventHandler handler = SentScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = SentScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void DraftRetrieveStart()
        {
            TalkBack("title, " + drftMesName + ", index number" + draftCount);
            switch (draftCount)
            {
                case 1:
                    {
                        EventHandler handler = DraftScrollUp;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 5:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 10:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
                case 15:
                    {
                        EventHandler handler = DraftScrollDown;
                        if (handler != null)
                        {
                            handler(this, new EventArgs());
                        }
                        break;
                    }
            }
        }

        private void InsertTheText()
        {
            switch (sectn)
            {
                case 1:
                    {
                        lg.userName.Text = String.Empty;
                        lg.userName.LineIdleColor = System.Drawing.Color.Gray;
                        lg.userName.Text = (vbs.TypeMaster.Text + "@gmail.com").ToLower();
                        lg.userName.Text = lg.userName.Text.Replace(" ", "");
                        MasterOnOff.Start();
                        TalkBack("username inserted");
                        cmmndOpen = 1;
                        break;
                    }
                case 2:
                    {
                        lg.passWord.Text = String.Empty;
                        lg.passWord.isPassword = true;
                        lg.passWord.LineIdleColor = System.Drawing.Color.Gray;
                        lg.passWord.Text = (vbs.TypeMaster.Text).ToLower();
                        lg.passWord.Text = lg.passWord.Text.Replace(" ", "");
                        MasterOnOff.Start();
                        TalkBack("password inserted");
                        cmmndOpen = 1;
                        break;
                    }
                case 3:
                    {
                        string temp = (vbs.TypeMaster.Text + "@gmail.com").ToLower();
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetAddress.SetMailToText(temp);
                        MasterOnOff.Start();
                        TalkBack("address inserted");
                        mailCmmnd = 1;
                        break;
                    }
                case 4:
                    {
                        string temp = vbs.TypeMaster.Text;
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetSubject.SetMailSubjectText(temp);
                        MasterOnOff.Start();
                        TalkBack("subject inserted");
                        mailCmmnd = 1;
                        break;
                    }
                case 5:
                    {
                        string temp = vbs.TypeMaster.Text;
                        MainWindow frm2 = (MainWindow)Application.OpenForms["MainWindow"];
                        frm2.SetBody.SetMailBodyText(temp);
                        MasterOnOff.Start();
                        TalkBack("message inserted");
                        mailCmmnd = 1;
                        break;
                    }
            }
            sectn = 0;
            vbs.TypeMaster.Text = String.Empty;
            vbs.Close();
        }

        private void ShowScratchpad()
        {
            vbs = new VBScratchpad();
            vbs.TypeMaster.Text = String.Empty;
            vbs.Show();
        }

        private void SetTypeEng()
        {
            try
            {
                typeENG.UnloadAllGrammars();
                typeENG.LoadGrammar(new DictationGrammar());
                typeENG.SpeechRecognized += TypeENG_SpeechRecognized;
                typeENG.SetInputToDefaultAudioDevice();
            }
            catch (Exception Ex)
            {
                //Error....................
            }
        }

        private void TypeENG_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string temp = (e.Result.Text.ToLower()).ToString();
            temp = temp.Replace(" ", "");
            string temp1 = e.Result.Text.ToString();
            temp1 = temp1.Replace(" ", "");
            if (temp != "enter")
            {
                vbs.TypeMaster.Text += temp1;
                TalkBack("Text inserted");
            }
            else if (temp == "enter")
            {
                conf = 1;
                typeENG.RecognizeAsyncStop();
                VB_Command_Eng.RecognizeAsync(RecognizeMode.Multiple);
                TalkBack("text inserted as " + vbs.TypeMaster.Text);
            }
        }

        private void LoginProcess()
        {
            string usr, pas;
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Info.txt";
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                usr = lines[2].ToString();
                pas = lines[4].ToString();
                if (usr != String.Empty && pas != String.Empty)
                {
                    TalkBack("Signing into gmail. Please stand by");
                    RequestLogin();
                }
                else if (usr == String.Empty && pas == String.Empty)
                {
                    TalkBack("Gmail sign in required. need username and password");
                    cmmndOpen = 1;
                }
            }
        }

        private void VB_MasterSleep()
        {
            VB_Master_Sound = new SoundPlayer("VB_Sleep.wav");
            VB_Master_Sound.Play();
            VBDisplay.Text = "VB: Sleeping........!";
            PowerBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            VBDisplay.ForeColor = System.Drawing.Color.LightSeaGreen;
            MasterOnOff.Stop();
            MasterIgnore = 0;
            VB_Command_Eng.RecognizeAsyncStop();
            resetCmmndVar();
        }

        private void resetCmmndVar()
        {
            lgVis = 0;
            sectn = 0;
            conf = 0;
            cmmndOpen = 0;
            navMenu = 0;
            composeOpt = 0;
            inboxOpt = 0;
            sentOpt = 0;
            draftOpt = 0;
            settingOpt = 0;
            inboRet = 0;
            sntRet = 0;
            inboxCmmnd = 0;
            sentCmmnd = 0;
            closeOpt = 0;
            cmmndRead = 0;
            cmmndRead_ = 0;
            inboRead = 0;
            sntRead = 0;
            mailCmmnd = 0;
            ingcmpsaddr = 0;
            ingcmpsttl_ssmry = 0;
            setCmmnd = 0;
            activeCmd = 0;
            mailCount = 0;
            sentCount = 0;
            mCount = 0;
            inbTotlaMail = 0;
            sntTotalMail = 0;
            inboMesName = null;
            sntMesName = null;
        }

        private void VB_Mas_Eng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("Hey Voice Box") && MasterIgnore == 0)
            {
                VB_Master_Sound = new SoundPlayer("VB_Awake.wav");
                VB_Master_Sound.Play();
                VBDisplay.Text = "VB: Listening........!";
                PowerBtn.BackColor = System.Drawing.Color.SpringGreen;
                VBDisplay.ForeColor = System.Drawing.Color.SpringGreen;
                if (VirAssist == 0 || VirAssist == 1)
                {
                    MasterOnOff.Interval = 10000;
                    PutBacktoSleep.Interval = 1000;
                    MasterOnOff.Start();
                    PutBacktoSleep.Stop();
                    PutBacktoSleep.Start();
                    MasterIgnore = 1;
                    backtoSleep = 0;
                    VB_Command_Eng.RecognizeAsync(RecognizeMode.Multiple);
                }
                else if (VirAssist == 2)
                {
                    MasterIgnore = 1;
                    usrName = System.Environment.MachineName;
                    vaSection = 0;
                    vaStart.Start();
                }
            }
        }

        private void vaStart_Tick(object sender, EventArgs e)
        {
            DateTime greetUser = DateTime.Now;

            if (greetUser.Hour >= 5 && greetUser.Hour < 12)
            {
                greetText = "good morning";
            }
            else if (greetUser.Hour >= 12 && greetUser.Hour < 17)
            {
                greetText = "good afternoon";
            }
            else if (greetUser.Hour >= 17 && greetUser.Hour < 24)
            {
                greetText = "good evening";
            }
            else 
            {
                greetText = "mid night greetings";
            }
            TalkBack_("hello, " + usrName + "? " + greetText);
            vaStart.Stop();
        }

        private void vaTimer_Tick(object sender, EventArgs e)
        {
            GetTheActiveForm_();
            vaTimer.Stop();
        }

        private void GetTheActiveForm_()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt";
            if (File.Exists(filename))
            {
                string temp;
                string[] lines = File.ReadAllLines(filename);
                temp = lines[1].ToString();
                if (temp.Equals("Login"))
                {
                    vaSection = 1;
                    TalkBack_("would you like to sign into your gmail?");
                    
                }
                else if (temp.Equals("MainWindow"))
                {
                    vaSection = 5;
                    MainFormShow();
                    TalkBack_("good to see you again");
                }
            }
        }

        private void MicVm()
        {
            int i;
            sourceStrem = new NAudio.Wave.WaveIn();
            sourceStrem.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(0).Channels);
            sourceStrem.StartRecording();
            sourceStrem.DataAvailable += SourceStrem_DataAvailable;           
            MMDeviceEnumerator mde = new MMDeviceEnumerator();
            var devices = mde.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            if (devices.Count == 1)
            {
                i = 0;
                firstMic = devices.ElementAt(i);
            }
            else if (devices.Count == 2)
            {
                i = 1;
                firstMic = devices.ElementAt(i);
            }
        }

        private void SourceStrem_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.Visible)
            {
                int value, limit = 10;
                value = (int)(Math.Round(firstMic.AudioMeterInformation.MasterPeakValue * 130));
                
                if (value <= limit)
                {
                    switch (value)
                    {
                        case 0:
                            this.MicLvl.Image = Properties.Resources.MIC0;
                            break;
                        case 1:
                            this.MicLvl.Image = Properties.Resources.MIC1;
                            break;
                        case 2:
                            this.MicLvl.Image = Properties.Resources.MIC1;
                            break;
                        case 3:
                            this.MicLvl.Image = Properties.Resources.MIC1;
                            break;
                        case 4:
                            this.MicLvl.Image = Properties.Resources.MIC2;
                            break;
                        case 5:
                            this.MicLvl.Image = Properties.Resources.MIC2;
                            break;
                        case 6:
                            this.MicLvl.Image = Properties.Resources.MIC3;
                            break;
                        case 7:
                            this.MicLvl.Image = Properties.Resources.MIC4;
                            break;
                        case 8:
                            this.MicLvl.Image = Properties.Resources.MIC5;
                            break;
                        case 9:
                            this.MicLvl.Image = Properties.Resources.MIC6;
                            break;
                        case 10:
                            this.MicLvl.Image = Properties.Resources.MIC7;
                            break;
                    }
                }
            }
        }

        private void PowerBtn_MouseHover(object sender, EventArgs e)
        {
            this.PowerBtn.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.PowerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.PowerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
        }

        private void PowerBtn_MouseLeave(object sender, EventArgs e)
        {
            this.PowerBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            this.CloseBtn.ForeColor = System.Drawing.Color.SpringGreen;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (mainVis == 0)
            {
                Application.Exit();
            }
            else if (mainVis == 1)
            {
                EventHandler handler = AppExit;
                if (handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
        }

        private void MasterOnOff_Tick(object sender, EventArgs e)
        {
            MasterOnOffAction();
        }

        private void MasterOnOffAction()
        {
            VB_Master_Sound = new SoundPlayer("idle.wav");
            VB_Master_Sound.Play();
            VBDisplay.Text = "VB: Idling........!";
            VBDisplay.ForeColor = System.Drawing.Color.LightCoral;
            MasterOnOff.Stop();
            MasterIgnore = 0;
            VB_Command_Eng.RecognizeAsyncStop();
            ResetCommands();
        }

        private void ResetCommands()
        {
            if (cmmndOpen == 2)
            {
                cmmndOpen = 1;
            }

            if (navCmd == 1)
            {
                if (navMenu == 0)
                {
                    navMenu = 1;
                    composeOpt = 0;
                    inboxOpt = 0;
                    sentOpt = 0;
                    draftOpt = 0;
                    settingOpt = 0;
                    lgVis = 0;
                }
            }

            if (mailCmmnd == 2)
            {
                mailCmmnd = 1;
            }

            if (inboRet == 1)
            {
                inboRet = 0;
                inboxCmmnd = 1;
            }
            else if (inboRet == 2)
            {
                inboRet = 0;
                inboxCmmnd = 2;
            }
            else if (inboRet == 3)
            {
                inboRet = 0;
                inboxCmmnd = 3;
            }

            if (sntRet == 1)
            {
                sntRet = 0;
                sentCmmnd = 1;
            }
            else if (sntRet == 2)
            {
                sntRet = 0;
                sentCmmnd = 2;
            }
            else if (sntRet == 3)
            {
                sntRet = 0;
                sentCmmnd = 3;
            }

            if (drftRet == 1)
            {
                drftRet = 0;
                draftCmmnd = 1;
            }
            else if (drftRet == 2)
            {
                drftRet = 0;
                draftCmmnd = 2;
            }

            if (setCmmnd == 2)
            {
                setCmmnd = 1;
            }

            awitTillRead = 0;
            awitTillRead_ = 0;
            awitTillRead__ = 0;
        }

        private void VBState()
        {
            VBDisplay.Text = "VB: Processing....!";
            VBDisplay.ForeColor = System.Drawing.Color.Thistle;
        }

        private void LoginFormShow()
        {
            lg = new login();
            LoginProcess();
            lg.Show();
        }

        private void MainFormShow()
        {
            mw = new MainWindow();
            mw.Show();
        }

        private void RequestLogin()
        {
            EventHandler handler = VBLogin;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void SendEvent()
        {
            EventHandler handler = WindowHide;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void selectComposeTab()
        {
            EventHandler handler = CmdComposeTabOpn;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void closeComposeTab()
        {
            EventHandler handler = CmdComposeTabCls;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void selectInboxTab()
        {
            EventHandler handler = CmdInboxTabOpn;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void closeInboxTab()
        {
            EventHandler handler = CmdInboxTabCls;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void selectSentTab()
        {
            EventHandler handler = CmdSentTabOpn;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void closeSentTab()
        {
            EventHandler handler = CmdSentTabCls;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void selectDraftTab()
        {
            EventHandler handler = CmdDraftTabOpn;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void closeDraftTab()
        {
            EventHandler handler = CmdDraftTabCls;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void selectSettingTab()
        {
            EventHandler handler = CmdSettingTabOpn;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void closeSettingTab()
        {
            EventHandler handler = CmdSettingTabCls;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void GetTheActiveForm()
        {
            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\Active_Window.txt";
            if (File.Exists(filename))
            {
                string temp;
                string[] lines = File.ReadAllLines(filename);
                temp = lines[1].ToString();
                if (temp.Equals("Login"))
                {
                    LoginFormShow();
                }
                else if (temp.Equals("MainWindow"))
                {
                    MainFormShow();
                    TalkBack(" hello! welcome back");
                    navMenu = 1;
                }
            }
        }

        private void VoiceBox_Load(object sender, EventArgs e)
        {
            MainWindow.AppRestart += MainWindow_AppRestart;
        }

        private void MainWindow_AppRestart(object sender, EventArgs e)
        {
            AppRestartTime.Start();
        }

        private void AppRestartTime_Tick(object sender, EventArgs e)
        {
            AppRestartTime.Stop();
            Application.Restart();
            Environment.Exit(0);
        }

        private void PutBacktoSleep_Tick(object sender, EventArgs e)
        {
            if(VBDisplay.Text.Equals("VB: Idling........!"))
            {
                if (backtoSleep != 300)
                {
                    backtoSleep++;
                }
                else if (backtoSleep == 300)
                {
                    PutBacktoSleep.Stop();
                    VB_MasterSleep();
                    EventHandler handler = WindowHide;
                    if (handler != null)
                    {
                        handler(this, new EventArgs());
                    }
                }
            }
        }

        private void VAResetAuto_Tick(object sender, EventArgs e)
        {
            if(VBDisplay.Text.Equals("VB: Listening........!"))
            {
                if (backtoSleep_ != 120)
                {
                    backtoSleep_++;
                }
                else if (backtoSleep_ == 120)
                {
                    VAResetAuto.Stop();
                    vASleepAc();
                    VA_Eng.RecognizeAsyncStop();
                    VAtypeENG.RecognizeAsyncStop();
                    EventHandler handler = WindowHide_;
                    if (handler != null)
                    {
                        handler(this, new EventArgs());
                    }
                }
            }
        }
    }
}
