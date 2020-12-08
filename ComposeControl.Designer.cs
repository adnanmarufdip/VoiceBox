namespace WinMailClientApp
{
    partial class ComposeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposeControl));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.mailTo = new System.Windows.Forms.TextBox();
            this.mailSubject = new System.Windows.Forms.TextBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.mailBody = new System.Windows.Forms.TextBox();
            this.mailSendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mailClearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mailAttachBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ImageFile = new System.Windows.Forms.OpenFileDialog();
            this.attactment = new System.Windows.Forms.Label();
            this.attachRmvBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mailDraftBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.attachRmvBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(19, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(19, 91);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // mailTo
            // 
            this.mailTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailTo.Location = new System.Drawing.Point(94, 72);
            this.mailTo.Name = "mailTo";
            this.mailTo.Size = new System.Drawing.Size(565, 20);
            this.mailTo.TabIndex = 1;
            // 
            // mailSubject
            // 
            this.mailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailSubject.Location = new System.Drawing.Point(71, 105);
            this.mailSubject.Name = "mailSubject";
            this.mailSubject.Size = new System.Drawing.Size(588, 20);
            this.mailSubject.TabIndex = 2;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(19, 124);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator3.TabIndex = 0;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // mailBody
            // 
            this.mailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailBody.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBody.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailBody.Location = new System.Drawing.Point(19, 139);
            this.mailBody.Multiline = true;
            this.mailBody.Name = "mailBody";
            this.mailBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mailBody.Size = new System.Drawing.Size(641, 326);
            this.mailBody.TabIndex = 3;
            // 
            // mailSendBtn
            // 
            this.mailSendBtn.Activecolor = System.Drawing.Color.White;
            this.mailSendBtn.BackColor = System.Drawing.Color.White;
            this.mailSendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailSendBtn.BorderRadius = 0;
            this.mailSendBtn.ButtonText = " Send";
            this.mailSendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailSendBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mailSendBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mailSendBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mailSendBtn.Iconimage")));
            this.mailSendBtn.Iconimage_right = null;
            this.mailSendBtn.Iconimage_right_Selected = null;
            this.mailSendBtn.Iconimage_Selected = null;
            this.mailSendBtn.IconMarginLeft = 0;
            this.mailSendBtn.IconMarginRight = 0;
            this.mailSendBtn.IconRightVisible = true;
            this.mailSendBtn.IconRightZoom = 0D;
            this.mailSendBtn.IconVisible = true;
            this.mailSendBtn.IconZoom = 45D;
            this.mailSendBtn.IsTab = false;
            this.mailSendBtn.Location = new System.Drawing.Point(587, 14);
            this.mailSendBtn.Name = "mailSendBtn";
            this.mailSendBtn.Normalcolor = System.Drawing.Color.White;
            this.mailSendBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.mailSendBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.mailSendBtn.selected = false;
            this.mailSendBtn.Size = new System.Drawing.Size(73, 30);
            this.mailSendBtn.TabIndex = 0;
            this.mailSendBtn.Text = " Send";
            this.mailSendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailSendBtn.Textcolor = System.Drawing.Color.Black;
            this.mailSendBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailSendBtn.Click += new System.EventHandler(this.mailSendBtn_Click);
            // 
            // mailClearBtn
            // 
            this.mailClearBtn.Activecolor = System.Drawing.Color.White;
            this.mailClearBtn.BackColor = System.Drawing.Color.White;
            this.mailClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailClearBtn.BorderRadius = 0;
            this.mailClearBtn.ButtonText = " Clear";
            this.mailClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailClearBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mailClearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mailClearBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mailClearBtn.Iconimage")));
            this.mailClearBtn.Iconimage_right = null;
            this.mailClearBtn.Iconimage_right_Selected = null;
            this.mailClearBtn.Iconimage_Selected = null;
            this.mailClearBtn.IconMarginLeft = 0;
            this.mailClearBtn.IconMarginRight = 0;
            this.mailClearBtn.IconRightVisible = true;
            this.mailClearBtn.IconRightZoom = 0D;
            this.mailClearBtn.IconVisible = true;
            this.mailClearBtn.IconZoom = 45D;
            this.mailClearBtn.IsTab = false;
            this.mailClearBtn.Location = new System.Drawing.Point(408, 14);
            this.mailClearBtn.Name = "mailClearBtn";
            this.mailClearBtn.Normalcolor = System.Drawing.Color.White;
            this.mailClearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.mailClearBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.mailClearBtn.selected = false;
            this.mailClearBtn.Size = new System.Drawing.Size(73, 30);
            this.mailClearBtn.TabIndex = 0;
            this.mailClearBtn.Text = " Clear";
            this.mailClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailClearBtn.Textcolor = System.Drawing.Color.Black;
            this.mailClearBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailClearBtn.Click += new System.EventHandler(this.mailClearBtn_Click);
            // 
            // mailAttachBtn
            // 
            this.mailAttachBtn.Activecolor = System.Drawing.Color.White;
            this.mailAttachBtn.BackColor = System.Drawing.Color.White;
            this.mailAttachBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailAttachBtn.BorderRadius = 0;
            this.mailAttachBtn.ButtonText = " Attach File";
            this.mailAttachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailAttachBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mailAttachBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mailAttachBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mailAttachBtn.Iconimage")));
            this.mailAttachBtn.Iconimage_right = null;
            this.mailAttachBtn.Iconimage_right_Selected = null;
            this.mailAttachBtn.Iconimage_Selected = null;
            this.mailAttachBtn.IconMarginLeft = 0;
            this.mailAttachBtn.IconMarginRight = 0;
            this.mailAttachBtn.IconRightVisible = true;
            this.mailAttachBtn.IconRightZoom = 0D;
            this.mailAttachBtn.IconVisible = true;
            this.mailAttachBtn.IconZoom = 45D;
            this.mailAttachBtn.IsTab = false;
            this.mailAttachBtn.Location = new System.Drawing.Point(19, 14);
            this.mailAttachBtn.Name = "mailAttachBtn";
            this.mailAttachBtn.Normalcolor = System.Drawing.Color.White;
            this.mailAttachBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.mailAttachBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.mailAttachBtn.selected = false;
            this.mailAttachBtn.Size = new System.Drawing.Size(103, 30);
            this.mailAttachBtn.TabIndex = 0;
            this.mailAttachBtn.Text = " Attach File";
            this.mailAttachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailAttachBtn.Textcolor = System.Drawing.Color.Black;
            this.mailAttachBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailAttachBtn.Click += new System.EventHandler(this.mailAttachBtn_Click);
            // 
            // ImageFile
            // 
            this.ImageFile.FileName = "ImageFile";
            // 
            // attactment
            // 
            this.attactment.AutoSize = true;
            this.attactment.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attactment.Location = new System.Drawing.Point(25, 42);
            this.attactment.Name = "attactment";
            this.attactment.Size = new System.Drawing.Size(0, 12);
            this.attactment.TabIndex = 15;
            this.attactment.TextChanged += new System.EventHandler(this.attactment_TextChanged);
            // 
            // attachRmvBtn
            // 
            this.attachRmvBtn.BackColor = System.Drawing.Color.White;
            this.attachRmvBtn.Image = ((System.Drawing.Image)(resources.GetObject("attachRmvBtn.Image")));
            this.attachRmvBtn.ImageActive = null;
            this.attachRmvBtn.Location = new System.Drawing.Point(10, 41);
            this.attachRmvBtn.Name = "attachRmvBtn";
            this.attachRmvBtn.Size = new System.Drawing.Size(15, 15);
            this.attachRmvBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attachRmvBtn.TabIndex = 16;
            this.attachRmvBtn.TabStop = false;
            this.attachRmvBtn.Visible = false;
            this.attachRmvBtn.Zoom = 20;
            this.attachRmvBtn.Click += new System.EventHandler(this.attachRmvBtn_Click);
            // 
            // mailDraftBtn
            // 
            this.mailDraftBtn.Activecolor = System.Drawing.Color.White;
            this.mailDraftBtn.BackColor = System.Drawing.Color.White;
            this.mailDraftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailDraftBtn.BorderRadius = 0;
            this.mailDraftBtn.ButtonText = "  Draft";
            this.mailDraftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailDraftBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mailDraftBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mailDraftBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mailDraftBtn.Iconimage")));
            this.mailDraftBtn.Iconimage_right = null;
            this.mailDraftBtn.Iconimage_right_Selected = null;
            this.mailDraftBtn.Iconimage_Selected = null;
            this.mailDraftBtn.IconMarginLeft = 0;
            this.mailDraftBtn.IconMarginRight = 0;
            this.mailDraftBtn.IconRightVisible = true;
            this.mailDraftBtn.IconRightZoom = 0D;
            this.mailDraftBtn.IconVisible = true;
            this.mailDraftBtn.IconZoom = 45D;
            this.mailDraftBtn.IsTab = false;
            this.mailDraftBtn.Location = new System.Drawing.Point(498, 14);
            this.mailDraftBtn.Name = "mailDraftBtn";
            this.mailDraftBtn.Normalcolor = System.Drawing.Color.White;
            this.mailDraftBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.mailDraftBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.mailDraftBtn.selected = false;
            this.mailDraftBtn.Size = new System.Drawing.Size(73, 30);
            this.mailDraftBtn.TabIndex = 17;
            this.mailDraftBtn.Text = "  Draft";
            this.mailDraftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailDraftBtn.Textcolor = System.Drawing.Color.Black;
            this.mailDraftBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailDraftBtn.Click += new System.EventHandler(this.mailDraftBtn_Click);
            // 
            // ComposeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mailDraftBtn);
            this.Controls.Add(this.attachRmvBtn);
            this.Controls.Add(this.attactment);
            this.Controls.Add(this.mailAttachBtn);
            this.Controls.Add(this.mailClearBtn);
            this.Controls.Add(this.mailSendBtn);
            this.Controls.Add(this.mailBody);
            this.Controls.Add(this.mailSubject);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailTo);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Name = "ComposeControl";
            this.Size = new System.Drawing.Size(675, 469);
            ((System.ComponentModel.ISupportInitialize)(this.attachRmvBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton mailSendBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mailClearBtn;
        private Bunifu.Framework.UI.BunifuFlatButton mailAttachBtn;
        private System.Windows.Forms.OpenFileDialog ImageFile;
        private System.Windows.Forms.Label attactment;
        private Bunifu.Framework.UI.BunifuImageButton attachRmvBtn;
        public System.Windows.Forms.TextBox mailTo;
        public System.Windows.Forms.TextBox mailSubject;
        public System.Windows.Forms.TextBox mailBody;
        private Bunifu.Framework.UI.BunifuFlatButton mailDraftBtn;
    }
}
