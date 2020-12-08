namespace WinMailClientApp
{
    partial class DrftMsgLbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrftMsgLbl));
            this.mailDltBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailName = new System.Windows.Forms.Label();
            this.mailTime = new System.Windows.Forms.Label();
            this.mailMessage = new System.Windows.Forms.Label();
            this.mailSubject = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keepVisible = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mailDltBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mailDltBtn
            // 
            this.mailDltBtn.BackColor = System.Drawing.SystemColors.Control;
            this.mailDltBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailDltBtn.Image = ((System.Drawing.Image)(resources.GetObject("mailDltBtn.Image")));
            this.mailDltBtn.ImageActive = null;
            this.mailDltBtn.Location = new System.Drawing.Point(589, 31);
            this.mailDltBtn.Name = "mailDltBtn";
            this.mailDltBtn.Size = new System.Drawing.Size(30, 30);
            this.mailDltBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailDltBtn.TabIndex = 16;
            this.mailDltBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.mailDltBtn, "Delete this draft");
            this.mailDltBtn.Zoom = 10;
            this.mailDltBtn.Click += new System.EventHandler(this.mailDltBtn_Click);
            this.mailDltBtn.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailDltBtn.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailName);
            this.panel1.Controls.Add(this.mailTime);
            this.panel1.Controls.Add(this.mailMessage);
            this.panel1.Controls.Add(this.mailSubject);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 70);
            this.panel1.TabIndex = 17;
            this.panel1.Click += new System.EventHandler(this.Click_Event);
            this.panel1.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.panel1.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // emailName
            // 
            this.emailName.BackColor = System.Drawing.SystemColors.Control;
            this.emailName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailName.Location = new System.Drawing.Point(24, 4);
            this.emailName.Name = "emailName";
            this.emailName.Size = new System.Drawing.Size(407, 20);
            this.emailName.TabIndex = 15;
            this.emailName.Text = "adnan.marufamd@gmail.com";
            this.emailName.Click += new System.EventHandler(this.Click_Event);
            this.emailName.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.emailName.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailTime
            // 
            this.mailTime.BackColor = System.Drawing.SystemColors.Control;
            this.mailTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTime.Location = new System.Drawing.Point(542, 4);
            this.mailTime.Name = "mailTime";
            this.mailTime.Size = new System.Drawing.Size(83, 17);
            this.mailTime.TabIndex = 20;
            this.mailTime.Text = "12:12";
            this.mailTime.Click += new System.EventHandler(this.Click_Event);
            this.mailTime.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailTime.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailMessage
            // 
            this.mailMessage.BackColor = System.Drawing.SystemColors.Control;
            this.mailMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailMessage.Location = new System.Drawing.Point(46, 47);
            this.mailMessage.Name = "mailMessage";
            this.mailMessage.Size = new System.Drawing.Size(445, 17);
            this.mailMessage.TabIndex = 19;
            this.mailMessage.Text = "This is a test mail";
            this.mailMessage.Click += new System.EventHandler(this.Click_Event);
            this.mailMessage.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailMessage.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // mailSubject
            // 
            this.mailSubject.BackColor = System.Drawing.SystemColors.Control;
            this.mailSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailSubject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailSubject.Location = new System.Drawing.Point(45, 25);
            this.mailSubject.Name = "mailSubject";
            this.mailSubject.Size = new System.Drawing.Size(446, 18);
            this.mailSubject.TabIndex = 18;
            this.mailSubject.Text = "This is a test mail";
            this.mailSubject.Click += new System.EventHandler(this.Click_Event);
            this.mailSubject.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.mailSubject.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Click_Event);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.pictureBox2.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Click_Event);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.pictureBox1.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            // 
            // keepVisible
            // 
            this.keepVisible.Tick += new System.EventHandler(this.keepVisible_Tick);
            // 
            // DrftMsgLbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mailDltBtn);
            this.Name = "DrftMsgLbl";
            this.Size = new System.Drawing.Size(631, 70);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_Backcolor);
            this.MouseHover += new System.EventHandler(this.MouseHover_Backcolor);
            ((System.ComponentModel.ISupportInitialize)(this.mailDltBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton mailDltBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label emailName;
        public System.Windows.Forms.Label mailTime;
        public System.Windows.Forms.Label mailMessage;
        public System.Windows.Forms.Label mailSubject;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer keepVisible;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
