namespace WinMailClientApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.userName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignIN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign in ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "to continue to Gmail";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(304, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 20;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // userName
            // 
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.DarkGray;
            this.userName.HintForeColor = System.Drawing.Color.Empty;
            this.userName.HintText = "";
            this.userName.isPassword = false;
            this.userName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.userName.LineIdleColor = System.Drawing.Color.Gray;
            this.userName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.userName.LineThickness = 3;
            this.userName.Location = new System.Drawing.Point(30, 152);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(280, 47);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username";
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.Enter += new System.EventHandler(this.userName_Enter_1);
            // 
            // passWord
            // 
            this.passWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passWord.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.ForeColor = System.Drawing.Color.DarkGray;
            this.passWord.HintForeColor = System.Drawing.Color.Empty;
            this.passWord.HintText = "";
            this.passWord.isPassword = false;
            this.passWord.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.passWord.LineIdleColor = System.Drawing.Color.Gray;
            this.passWord.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.passWord.LineThickness = 3;
            this.passWord.Location = new System.Drawing.Point(30, 205);
            this.passWord.Margin = new System.Windows.Forms.Padding(4);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(280, 47);
            this.passWord.TabIndex = 2;
            this.passWord.Text = "Password";
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWord.Enter += new System.EventHandler(this.passWord_Enter_1);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCheck.ChechedOffColor = System.Drawing.Color.White;
            this.btnCheck.Checked = false;
            this.btnCheck.CheckedOnColor = System.Drawing.Color.White;
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(30, 271);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(20, 20);
            this.btnCheck.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remember me";
            // 
            // btnSignIN
            // 
            this.btnSignIN.ActiveBorderThickness = 1;
            this.btnSignIN.ActiveCornerRadius = 30;
            this.btnSignIN.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnSignIN.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignIN.ActiveLineColor = System.Drawing.Color.White;
            this.btnSignIN.BackColor = System.Drawing.Color.White;
            this.btnSignIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIN.BackgroundImage")));
            this.btnSignIN.ButtonText = "Sign in";
            this.btnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIN.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIN.ForeColor = System.Drawing.Color.White;
            this.btnSignIN.IdleBorderThickness = 1;
            this.btnSignIN.IdleCornerRadius = 30;
            this.btnSignIN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.btnSignIN.IdleForecolor = System.Drawing.Color.White;
            this.btnSignIN.IdleLineColor = System.Drawing.Color.White;
            this.btnSignIN.Location = new System.Drawing.Point(66, 299);
            this.btnSignIN.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(207, 50);
            this.btnSignIN.TabIndex = 0;
            this.btnSignIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // logError
            // 
            this.logError.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logError.ForeColor = System.Drawing.Color.Red;
            this.logError.Image = ((System.Drawing.Image)(resources.GetObject("logError.Image")));
            this.logError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logError.Location = new System.Drawing.Point(35, 363);
            this.logError.Name = "logError";
            this.logError.Size = new System.Drawing.Size(295, 16);
            this.logError.TabIndex = 8;
            this.logError.Text = "      Incorrect email address or password!";
            this.logError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 402);
            this.ControlBox = false;
            this.Controls.Add(this.logError);
            this.Controls.Add(this.btnSignIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignIN;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox btnCheck;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passWord;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userName;
        private System.Windows.Forms.Label logError;
    }
}

