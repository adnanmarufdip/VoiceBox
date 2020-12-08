namespace WinMailClientApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pushPnl = new System.Windows.Forms.Panel();
            this.pushInfo = new WinMailClientApp.InfoControl();
            this.CurPos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.inboxBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sentBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.draftBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.composeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SentItemsPanel = new System.Windows.Forms.Panel();
            this.MailReader_ = new WinMailClientApp.ReadBoxControl_();
            this.uiSettings = new WinMailClientApp.SettingsControl();
            this.MailReader = new WinMailClientApp.ReadBoxControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComposeTab = new WinMailClientApp.ComposeControl();
            this.inBoxPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeAni = new System.Windows.Forms.Timer(this.components);
            this.homeAnim = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DraftItemsPanel = new System.Windows.Forms.Panel();
            this.menuSlideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InboxRefresh = new System.Windows.Forms.Timer(this.components);
            this.NotifiAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SlideAni1 = new System.Windows.Forms.Timer(this.components);
            this.SlideAni2 = new System.Windows.Forms.Timer(this.components);
            this.AwaitTime = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.pushPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.slidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SentItemsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSlideBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.pushPnl);
            this.topPanel.Controls.Add(this.CurPos);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.NotifiAnimation.SetDecoration(this.topPanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.topPanel, BunifuAnimatorNS.DecorationType.None);
            this.topPanel.Location = new System.Drawing.Point(49, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(675, 33);
            this.topPanel.TabIndex = 3;
            // 
            // pushPnl
            // 
            this.pushPnl.BackColor = System.Drawing.Color.White;
            this.pushPnl.Controls.Add(this.pushInfo);
            this.NotifiAnimation.SetDecoration(this.pushPnl, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.pushPnl, BunifuAnimatorNS.DecorationType.None);
            this.pushPnl.Location = new System.Drawing.Point(307, 8);
            this.pushPnl.Name = "pushPnl";
            this.pushPnl.Size = new System.Drawing.Size(259, 15);
            this.pushPnl.TabIndex = 0;
            this.pushPnl.Visible = false;
            // 
            // pushInfo
            // 
            this.pushInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.homeAnim.SetDecoration(this.pushInfo, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.pushInfo, BunifuAnimatorNS.DecorationType.None);
            this.pushInfo.Location = new System.Drawing.Point(0, 0);
            this.pushInfo.Name = "pushInfo";
            this.pushInfo.Size = new System.Drawing.Size(259, 15);
            this.pushInfo.TabIndex = 0;
            // 
            // CurPos
            // 
            this.CurPos.AutoSize = true;
            this.homeAnim.SetDecoration(this.CurPos, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.CurPos, BunifuAnimatorNS.DecorationType.None);
            this.CurPos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurPos.ForeColor = System.Drawing.Color.Black;
            this.CurPos.Location = new System.Drawing.Point(189, 9);
            this.CurPos.Name = "CurPos";
            this.CurPos.Size = new System.Drawing.Size(11, 17);
            this.CurPos.TabIndex = 9;
            this.CurPos.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.homeAnim.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(39, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gmail -Virtual Assistant";
            // 
            // pictureBox1
            // 
            this.homeAnim.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifiAnimation.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(623, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(17, 17);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 6;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 20;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifiAnimation.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(650, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 17);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 20;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.slidePanel.Controls.Add(this.settingsBtn);
            this.slidePanel.Controls.Add(this.inboxBtn);
            this.slidePanel.Controls.Add(this.sentBtn);
            this.slidePanel.Controls.Add(this.draftBtn);
            this.slidePanel.Controls.Add(this.composeBtn);
            this.NotifiAnimation.SetDecoration(this.slidePanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.slidePanel, BunifuAnimatorNS.DecorationType.None);
            this.slidePanel.Location = new System.Drawing.Point(0, 32);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(49, 468);
            this.slidePanel.TabIndex = 1;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifiAnimation.SetDecoration(this.settingsBtn, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.settingsBtn, BunifuAnimatorNS.DecorationType.None);
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageActive = null;
            this.settingsBtn.Location = new System.Drawing.Point(15, 439);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(18, 18);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Zoom = 20;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // inboxBtn
            // 
            this.inboxBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.inboxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.inboxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inboxBtn.BorderRadius = 0;
            this.inboxBtn.ButtonText = "    INBOX";
            this.inboxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeAnim.SetDecoration(this.inboxBtn, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.inboxBtn, BunifuAnimatorNS.DecorationType.None);
            this.inboxBtn.DisabledColor = System.Drawing.Color.Gray;
            this.inboxBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.inboxBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("inboxBtn.Iconimage")));
            this.inboxBtn.Iconimage_right = null;
            this.inboxBtn.Iconimage_right_Selected = null;
            this.inboxBtn.Iconimage_Selected = null;
            this.inboxBtn.IconMarginLeft = 0;
            this.inboxBtn.IconMarginRight = 0;
            this.inboxBtn.IconRightVisible = true;
            this.inboxBtn.IconRightZoom = 0D;
            this.inboxBtn.IconVisible = true;
            this.inboxBtn.IconZoom = 35D;
            this.inboxBtn.IsTab = false;
            this.inboxBtn.Location = new System.Drawing.Point(0, 99);
            this.inboxBtn.Name = "inboxBtn";
            this.inboxBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.inboxBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.inboxBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.inboxBtn.selected = false;
            this.inboxBtn.Size = new System.Drawing.Size(188, 48);
            this.inboxBtn.TabIndex = 2;
            this.inboxBtn.Text = "    INBOX";
            this.inboxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboxBtn.Textcolor = System.Drawing.Color.White;
            this.inboxBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxBtn.Click += new System.EventHandler(this.inboxBtn_click);
            // 
            // sentBtn
            // 
            this.sentBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.sentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.sentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sentBtn.BorderRadius = 0;
            this.sentBtn.ButtonText = "    SENT";
            this.sentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeAnim.SetDecoration(this.sentBtn, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.sentBtn, BunifuAnimatorNS.DecorationType.None);
            this.sentBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sentBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sentBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sentBtn.Iconimage")));
            this.sentBtn.Iconimage_right = null;
            this.sentBtn.Iconimage_right_Selected = null;
            this.sentBtn.Iconimage_Selected = null;
            this.sentBtn.IconMarginLeft = 0;
            this.sentBtn.IconMarginRight = 0;
            this.sentBtn.IconRightVisible = true;
            this.sentBtn.IconRightZoom = 0D;
            this.sentBtn.IconVisible = true;
            this.sentBtn.IconZoom = 35D;
            this.sentBtn.IsTab = false;
            this.sentBtn.Location = new System.Drawing.Point(0, 149);
            this.sentBtn.Name = "sentBtn";
            this.sentBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.sentBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.sentBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sentBtn.selected = false;
            this.sentBtn.Size = new System.Drawing.Size(188, 48);
            this.sentBtn.TabIndex = 3;
            this.sentBtn.Text = "    SENT";
            this.sentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sentBtn.Textcolor = System.Drawing.Color.White;
            this.sentBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentBtn.Click += new System.EventHandler(this.sentBtn_click);
            // 
            // draftBtn
            // 
            this.draftBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.draftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.draftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.draftBtn.BorderRadius = 0;
            this.draftBtn.ButtonText = "    DRAFT";
            this.draftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeAnim.SetDecoration(this.draftBtn, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.draftBtn, BunifuAnimatorNS.DecorationType.None);
            this.draftBtn.DisabledColor = System.Drawing.Color.Gray;
            this.draftBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.draftBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("draftBtn.Iconimage")));
            this.draftBtn.Iconimage_right = null;
            this.draftBtn.Iconimage_right_Selected = null;
            this.draftBtn.Iconimage_Selected = null;
            this.draftBtn.IconMarginLeft = 0;
            this.draftBtn.IconMarginRight = 0;
            this.draftBtn.IconRightVisible = true;
            this.draftBtn.IconRightZoom = 0D;
            this.draftBtn.IconVisible = true;
            this.draftBtn.IconZoom = 35D;
            this.draftBtn.IsTab = false;
            this.draftBtn.Location = new System.Drawing.Point(0, 199);
            this.draftBtn.Name = "draftBtn";
            this.draftBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.draftBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.draftBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.draftBtn.selected = false;
            this.draftBtn.Size = new System.Drawing.Size(188, 48);
            this.draftBtn.TabIndex = 4;
            this.draftBtn.Text = "    DRAFT";
            this.draftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.draftBtn.Textcolor = System.Drawing.Color.White;
            this.draftBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draftBtn.Click += new System.EventHandler(this.drafBtn_click);
            // 
            // composeBtn
            // 
            this.composeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.composeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.composeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.composeBtn.BorderRadius = 0;
            this.composeBtn.ButtonText = "    COMPOSE";
            this.composeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeAnim.SetDecoration(this.composeBtn, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.composeBtn, BunifuAnimatorNS.DecorationType.None);
            this.composeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.composeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.composeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("composeBtn.Iconimage")));
            this.composeBtn.Iconimage_right = null;
            this.composeBtn.Iconimage_right_Selected = null;
            this.composeBtn.Iconimage_Selected = null;
            this.composeBtn.IconMarginLeft = 0;
            this.composeBtn.IconMarginRight = 0;
            this.composeBtn.IconRightVisible = true;
            this.composeBtn.IconRightZoom = 0D;
            this.composeBtn.IconVisible = true;
            this.composeBtn.IconZoom = 35D;
            this.composeBtn.IsTab = false;
            this.composeBtn.Location = new System.Drawing.Point(0, 49);
            this.composeBtn.Name = "composeBtn";
            this.composeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.composeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.composeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.composeBtn.selected = false;
            this.composeBtn.Size = new System.Drawing.Size(188, 48);
            this.composeBtn.TabIndex = 1;
            this.composeBtn.Text = "    COMPOSE";
            this.composeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.composeBtn.Textcolor = System.Drawing.Color.White;
            this.composeBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.composeBtn.Click += new System.EventHandler(this.composeBtn_click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.SentItemsPanel);
            this.mainPanel.Controls.Add(this.uiSettings);
            this.mainPanel.Controls.Add(this.MailReader);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.ComposeTab);
            this.mainPanel.Controls.Add(this.inBoxPanel);
            this.NotifiAnimation.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainPanel.Location = new System.Drawing.Point(49, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(675, 469);
            this.mainPanel.TabIndex = 2;
            // 
            // SentItemsPanel
            // 
            this.SentItemsPanel.BackColor = System.Drawing.Color.White;
            this.SentItemsPanel.Controls.Add(this.MailReader_);
            this.NotifiAnimation.SetDecoration(this.SentItemsPanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.SentItemsPanel, BunifuAnimatorNS.DecorationType.None);
            this.SentItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.SentItemsPanel.Name = "SentItemsPanel";
            this.SentItemsPanel.Size = new System.Drawing.Size(675, 468);
            this.SentItemsPanel.TabIndex = 10;
            this.SentItemsPanel.Visible = false;
            // 
            // MailReader_
            // 
            this.MailReader_.BackColor = System.Drawing.Color.White;
            this.homeAnim.SetDecoration(this.MailReader_, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.MailReader_, BunifuAnimatorNS.DecorationType.None);
            this.MailReader_.Location = new System.Drawing.Point(0, 1);
            this.MailReader_.Name = "MailReader_";
            this.MailReader_.Size = new System.Drawing.Size(675, 469);
            this.MailReader_.TabIndex = 0;
            this.MailReader_.Visible = false;
            // 
            // uiSettings
            // 
            this.uiSettings.BackColor = System.Drawing.Color.White;
            this.homeAnim.SetDecoration(this.uiSettings, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.uiSettings, BunifuAnimatorNS.DecorationType.None);
            this.uiSettings.Location = new System.Drawing.Point(2, 1);
            this.uiSettings.Name = "uiSettings";
            this.uiSettings.Size = new System.Drawing.Size(675, 469);
            this.uiSettings.TabIndex = 9;
            this.uiSettings.Visible = false;
            // 
            // MailReader
            // 
            this.MailReader.BackColor = System.Drawing.Color.White;
            this.homeAnim.SetDecoration(this.MailReader, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.MailReader, BunifuAnimatorNS.DecorationType.None);
            this.MailReader.Location = new System.Drawing.Point(0, -3);
            this.MailReader.Name = "MailReader";
            this.MailReader.Size = new System.Drawing.Size(675, 470);
            this.MailReader.TabIndex = 7;
            this.MailReader.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.NotifiAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(196, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 39);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.homeAnim.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gmail - Virtual Assistant";
            // 
            // pictureBox2
            // 
            this.homeAnim.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.homeAnim.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "@This is a test product";
            // 
            // ComposeTab
            // 
            this.ComposeTab.BackColor = System.Drawing.Color.White;
            this.homeAnim.SetDecoration(this.ComposeTab, BunifuAnimatorNS.DecorationType.None);
            this.NotifiAnimation.SetDecoration(this.ComposeTab, BunifuAnimatorNS.DecorationType.None);
            this.ComposeTab.Location = new System.Drawing.Point(3, 3);
            this.ComposeTab.Name = "ComposeTab";
            this.ComposeTab.Size = new System.Drawing.Size(675, 469);
            this.ComposeTab.TabIndex = 5;
            this.ComposeTab.Visible = false;
            // 
            // inBoxPanel
            // 
            this.NotifiAnimation.SetDecoration(this.inBoxPanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.inBoxPanel, BunifuAnimatorNS.DecorationType.None);
            this.inBoxPanel.Location = new System.Drawing.Point(0, 1);
            this.inBoxPanel.Name = "inBoxPanel";
            this.inBoxPanel.Size = new System.Drawing.Size(675, 468);
            this.inBoxPanel.TabIndex = 8;
            this.inBoxPanel.Visible = false;
            this.inBoxPanel.VisibleChanged += new System.EventHandler(this.inBoxPanel_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.NotifiAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 33);
            this.panel1.TabIndex = 8;
            // 
            // homeAni
            // 
            this.homeAni.Interval = 3000;
            this.homeAni.Tick += new System.EventHandler(this.homeAni_Tick);
            // 
            // homeAnim
            // 
            this.homeAnim.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.homeAnim.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.homeAnim.DefaultAnimation = animation1;
            this.homeAnim.Interval = 20;
            // 
            // DraftItemsPanel
            // 
            this.DraftItemsPanel.BackColor = System.Drawing.Color.White;
            this.NotifiAnimation.SetDecoration(this.DraftItemsPanel, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.DraftItemsPanel, BunifuAnimatorNS.DecorationType.None);
            this.DraftItemsPanel.Location = new System.Drawing.Point(49, 32);
            this.DraftItemsPanel.Name = "DraftItemsPanel";
            this.DraftItemsPanel.Size = new System.Drawing.Size(675, 468);
            this.DraftItemsPanel.TabIndex = 1;
            this.DraftItemsPanel.Visible = false;
            // 
            // menuSlideBtn
            // 
            this.menuSlideBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuSlideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifiAnimation.SetDecoration(this.menuSlideBtn, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this.menuSlideBtn, BunifuAnimatorNS.DecorationType.None);
            this.menuSlideBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuSlideBtn.Image")));
            this.menuSlideBtn.ImageActive = null;
            this.menuSlideBtn.Location = new System.Drawing.Point(8, 5);
            this.menuSlideBtn.Name = "menuSlideBtn";
            this.menuSlideBtn.Size = new System.Drawing.Size(32, 23);
            this.menuSlideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuSlideBtn.TabIndex = 7;
            this.menuSlideBtn.TabStop = false;
            this.menuSlideBtn.Zoom = 20;
            this.menuSlideBtn.Click += new System.EventHandler(this.menuSlideBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InboxRefresh
            // 
            this.InboxRefresh.Interval = 180000;
            this.InboxRefresh.Tick += new System.EventHandler(this.InboxRefresh_Tick);
            // 
            // NotifiAnimation
            // 
            this.NotifiAnimation.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.NotifiAnimation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.NotifiAnimation.DefaultAnimation = animation2;
            // 
            // SlideAni1
            // 
            this.SlideAni1.Interval = 1;
            this.SlideAni1.Tick += new System.EventHandler(this.SlideAni1_Tick);
            // 
            // SlideAni2
            // 
            this.SlideAni2.Interval = 1;
            this.SlideAni2.Tick += new System.EventHandler(this.SlideAni2_Tick);
            // 
            // AwaitTime
            // 
            this.AwaitTime.Interval = 1000;
            this.AwaitTime.Tick += new System.EventHandler(this.AwaitTime_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 500);
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.DraftItemsPanel);
            this.Controls.Add(this.menuSlideBtn);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.NotifiAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.homeAnim.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.pushPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.slidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.SentItemsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSlideBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton menuSlideBtn;
        private Bunifu.Framework.UI.BunifuImageButton settingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton inboxBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sentBtn;
        private Bunifu.Framework.UI.BunifuFlatButton draftBtn;
        private Bunifu.Framework.UI.BunifuFlatButton composeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer homeAni;
        private BunifuAnimatorNS.BunifuTransition homeAnim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label CurPos;
        public ReadBoxControl MailReader;
        public ComposeControl ComposeTab;
        private System.Windows.Forms.Timer InboxRefresh;
        private System.Windows.Forms.Panel inBoxPanel;
        private SettingsControl uiSettings;
        private System.Windows.Forms.Panel SentItemsPanel;
        private ReadBoxControl_ MailReader_;
        private BunifuAnimatorNS.BunifuTransition NotifiAnimation;
        private System.Windows.Forms.Panel pushPnl;
        private InfoControl pushInfo;
        private System.Windows.Forms.Timer SlideAni1;
        private System.Windows.Forms.Timer SlideAni2;
        private System.Windows.Forms.Panel DraftItemsPanel;
        private System.Windows.Forms.Timer AwaitTime;
    }
}