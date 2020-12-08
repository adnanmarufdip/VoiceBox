namespace WinMailClientApp
{
    partial class ReadBoxControl_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadBoxControl_));
            this.ReadBox = new System.Windows.Forms.Panel();
            this.rMialDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.rMailForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.rGoBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.rMailTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rMailBody = new System.Windows.Forms.TextBox();
            this.rMailSubject = new System.Windows.Forms.TextBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.rMailAddress = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ReadBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMialDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMailForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadBox
            // 
            this.ReadBox.Controls.Add(this.rMialDelete);
            this.ReadBox.Controls.Add(this.rMailForward);
            this.ReadBox.Controls.Add(this.rGoBack);
            this.ReadBox.Controls.Add(this.rMailTime);
            this.ReadBox.Controls.Add(this.label4);
            this.ReadBox.Controls.Add(this.rMailBody);
            this.ReadBox.Controls.Add(this.rMailSubject);
            this.ReadBox.Controls.Add(this.bunifuSeparator3);
            this.ReadBox.Controls.Add(this.label2);
            this.ReadBox.Controls.Add(this.rMailAddress);
            this.ReadBox.Controls.Add(this.bunifuSeparator2);
            this.ReadBox.Controls.Add(this.bunifuSeparator1);
            this.ReadBox.Controls.Add(this.label1);
            this.ReadBox.Location = new System.Drawing.Point(0, 0);
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.Size = new System.Drawing.Size(675, 469);
            this.ReadBox.TabIndex = 2;
            // 
            // rMialDelete
            // 
            this.rMialDelete.BackColor = System.Drawing.Color.White;
            this.rMialDelete.Image = ((System.Drawing.Image)(resources.GetObject("rMialDelete.Image")));
            this.rMialDelete.ImageActive = null;
            this.rMialDelete.Location = new System.Drawing.Point(374, 13);
            this.rMialDelete.Name = "rMialDelete";
            this.rMialDelete.Size = new System.Drawing.Size(30, 30);
            this.rMialDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rMialDelete.TabIndex = 21;
            this.rMialDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.rMialDelete, "Delete this mail");
            this.rMialDelete.Zoom = 10;
            this.rMialDelete.Click += new System.EventHandler(this.rMialDelete_Click);
            // 
            // rMailForward
            // 
            this.rMailForward.BackColor = System.Drawing.Color.White;
            this.rMailForward.Image = ((System.Drawing.Image)(resources.GetObject("rMailForward.Image")));
            this.rMailForward.ImageActive = null;
            this.rMailForward.Location = new System.Drawing.Point(424, 13);
            this.rMailForward.Name = "rMailForward";
            this.rMailForward.Size = new System.Drawing.Size(30, 30);
            this.rMailForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rMailForward.TabIndex = 20;
            this.rMailForward.TabStop = false;
            this.toolTip1.SetToolTip(this.rMailForward, "Forward this mail");
            this.rMailForward.Zoom = 10;
            this.rMailForward.Click += new System.EventHandler(this.rMailForward_Click);
            // 
            // rGoBack
            // 
            this.rGoBack.BackColor = System.Drawing.Color.White;
            this.rGoBack.Image = ((System.Drawing.Image)(resources.GetObject("rGoBack.Image")));
            this.rGoBack.ImageActive = null;
            this.rGoBack.Location = new System.Drawing.Point(19, 13);
            this.rGoBack.Name = "rGoBack";
            this.rGoBack.Size = new System.Drawing.Size(30, 30);
            this.rGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rGoBack.TabIndex = 18;
            this.rGoBack.TabStop = false;
            this.toolTip1.SetToolTip(this.rGoBack, "Go back to sent");
            this.rGoBack.Zoom = 10;
            this.rGoBack.Click += new System.EventHandler(this.rGoBack_Click);
            // 
            // rMailTime
            // 
            this.rMailTime.AutoSize = true;
            this.rMailTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMailTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rMailTime.Location = new System.Drawing.Point(528, 21);
            this.rMailTime.Name = "rMailTime";
            this.rMailTime.Size = new System.Drawing.Size(0, 16);
            this.rMailTime.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(462, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date/Time:";
            // 
            // rMailBody
            // 
            this.rMailBody.BackColor = System.Drawing.Color.White;
            this.rMailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rMailBody.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMailBody.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rMailBody.Location = new System.Drawing.Point(17, 137);
            this.rMailBody.Multiline = true;
            this.rMailBody.Name = "rMailBody";
            this.rMailBody.ReadOnly = true;
            this.rMailBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rMailBody.Size = new System.Drawing.Size(641, 320);
            this.rMailBody.TabIndex = 11;
            // 
            // rMailSubject
            // 
            this.rMailSubject.BackColor = System.Drawing.Color.White;
            this.rMailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rMailSubject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMailSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rMailSubject.Location = new System.Drawing.Point(62, 103);
            this.rMailSubject.Name = "rMailSubject";
            this.rMailSubject.ReadOnly = true;
            this.rMailSubject.Size = new System.Drawing.Size(595, 19);
            this.rMailSubject.TabIndex = 10;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(17, 121);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator3.TabIndex = 4;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // rMailAddress
            // 
            this.rMailAddress.BackColor = System.Drawing.Color.White;
            this.rMailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rMailAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMailAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rMailAddress.Location = new System.Drawing.Point(62, 70);
            this.rMailAddress.Name = "rMailAddress";
            this.rMailAddress.ReadOnly = true;
            this.rMailAddress.Size = new System.Drawing.Size(596, 19);
            this.rMailAddress.TabIndex = 9;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(17, 88);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 55);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(641, 14);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "To:";
            // 
            // ReadBoxControl_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReadBox);
            this.Name = "ReadBoxControl_";
            this.Size = new System.Drawing.Size(675, 469);
            this.ReadBox.ResumeLayout(false);
            this.ReadBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMialDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMailForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGoBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReadBox;
        private Bunifu.Framework.UI.BunifuImageButton rMialDelete;
        private Bunifu.Framework.UI.BunifuImageButton rMailForward;
        private Bunifu.Framework.UI.BunifuImageButton rGoBack;
        public System.Windows.Forms.Label rMailTime;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox rMailBody;
        public System.Windows.Forms.TextBox rMailSubject;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox rMailAddress;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
