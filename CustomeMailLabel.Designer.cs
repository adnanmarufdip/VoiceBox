namespace WinMailClientApp
{
    partial class CustomeMailLabel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomeMailLabel));
            this.mailMessage = new System.Windows.Forms.Label();
            this.mailSubject = new System.Windows.Forms.Label();
            this.emailName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mailFrdBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mailReplyBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mailTime = new System.Windows.Forms.Label();
            this.keepVisible = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mailFrdBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailReplyBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mailMessage
            // 
            this.mailMessage.BackColor = System.Drawing.SystemColors.Control;
            this.mailMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailMessage.Location = new System.Drawing.Point(45, 46);
            this.mailMessage.Name = "mailMessage";
            this.mailMessage.Size = new System.Drawing.Size(445, 17);
            this.mailMessage.TabIndex = 10;
            this.mailMessage.Text = "This is a test mail";
            this.mailMessage.Click += new System.EventHandler(this.Click_event);
            this.mailMessage.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailMessage.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailSubject
            // 
            this.mailSubject.BackColor = System.Drawing.SystemColors.Control;
            this.mailSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailSubject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailSubject.Location = new System.Drawing.Point(44, 24);
            this.mailSubject.Name = "mailSubject";
            this.mailSubject.Size = new System.Drawing.Size(446, 18);
            this.mailSubject.TabIndex = 9;
            this.mailSubject.Text = "This is a test mail";
            this.mailSubject.Click += new System.EventHandler(this.Click_event);
            this.mailSubject.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailSubject.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // emailName
            // 
            this.emailName.BackColor = System.Drawing.SystemColors.Control;
            this.emailName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailName.Location = new System.Drawing.Point(23, 3);
            this.emailName.Name = "emailName";
            this.emailName.Size = new System.Drawing.Size(407, 20);
            this.emailName.TabIndex = 5;
            this.emailName.Text = "adnan.marufamd@gmail.com";
            this.emailName.Click += new System.EventHandler(this.Click_event);
            this.emailName.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.emailName.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailFrdBtn
            // 
            this.mailFrdBtn.BackColor = System.Drawing.SystemColors.Control;
            this.mailFrdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailFrdBtn.Image = ((System.Drawing.Image)(resources.GetObject("mailFrdBtn.Image")));
            this.mailFrdBtn.ImageActive = null;
            this.mailFrdBtn.Location = new System.Drawing.Point(588, 30);
            this.mailFrdBtn.Name = "mailFrdBtn";
            this.mailFrdBtn.Size = new System.Drawing.Size(30, 30);
            this.mailFrdBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailFrdBtn.TabIndex = 13;
            this.mailFrdBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.mailFrdBtn, "Forword this mail");
            this.mailFrdBtn.Zoom = 10;
            this.mailFrdBtn.Click += new System.EventHandler(this.mailFrdBtn_Click);
            this.mailFrdBtn.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailFrdBtn.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailReplyBtn
            // 
            this.mailReplyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.mailReplyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailReplyBtn.Image = ((System.Drawing.Image)(resources.GetObject("mailReplyBtn.Image")));
            this.mailReplyBtn.ImageActive = null;
            this.mailReplyBtn.Location = new System.Drawing.Point(541, 30);
            this.mailReplyBtn.Name = "mailReplyBtn";
            this.mailReplyBtn.Size = new System.Drawing.Size(30, 30);
            this.mailReplyBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailReplyBtn.TabIndex = 12;
            this.mailReplyBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.mailReplyBtn, "Reply to this mail");
            this.mailReplyBtn.Zoom = 10;
            this.mailReplyBtn.Click += new System.EventHandler(this.mailReplyBtn_Click);
            this.mailReplyBtn.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailReplyBtn.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mailTime);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Click_event);
            this.panel1.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.panel1.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailTime
            // 
            this.mailTime.BackColor = System.Drawing.SystemColors.Control;
            this.mailTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTime.Location = new System.Drawing.Point(541, 3);
            this.mailTime.Name = "mailTime";
            this.mailTime.Size = new System.Drawing.Size(83, 17);
            this.mailTime.TabIndex = 14;
            this.mailTime.Text = "12:12";
            this.mailTime.Click += new System.EventHandler(this.Click_event);
            this.mailTime.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailTime.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // keepVisible
            // 
            this.keepVisible.Tick += new System.EventHandler(this.keepVisible_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Click_event);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.pictureBox2.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Click_event);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.pictureBox1.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // CustomeMailLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.mailMessage);
            this.Controls.Add(this.mailSubject);
            this.Controls.Add(this.emailName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mailFrdBtn);
            this.Controls.Add(this.mailReplyBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomeMailLabel";
            this.Size = new System.Drawing.Size(632, 72);
            this.Load += new System.EventHandler(this.CustomeMailLabel_Load);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            ((System.ComponentModel.ISupportInitialize)(this.mailFrdBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailReplyBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton mailReplyBtn;
        private Bunifu.Framework.UI.BunifuImageButton mailFrdBtn;
        private System.Windows.Forms.Timer keepVisible;
        public System.Windows.Forms.Label mailMessage;
        public System.Windows.Forms.Label mailSubject;
        public System.Windows.Forms.Label emailName;
        public System.Windows.Forms.Label mailTime;
    }
}
