namespace WinMailClientApp
{
    partial class InfoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoControl));
            this.CntrlMesLbl = new System.Windows.Forms.Label();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.CntrlCloseBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CntrlCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CntrlMesLbl
            // 
            this.CntrlMesLbl.AutoSize = true;
            this.CntrlMesLbl.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlMesLbl.ForeColor = System.Drawing.Color.White;
            this.CntrlMesLbl.Location = new System.Drawing.Point(2, 0);
            this.CntrlMesLbl.Name = "CntrlMesLbl";
            this.CntrlMesLbl.Size = new System.Drawing.Size(74, 14);
            this.CntrlMesLbl.TabIndex = 1;
            this.CntrlMesLbl.Text = "INFORMATION";
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 3000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // CntrlCloseBtn
            // 
            this.CntrlCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CntrlCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CntrlCloseBtn.Image")));
            this.CntrlCloseBtn.Location = new System.Drawing.Point(246, 2);
            this.CntrlCloseBtn.Name = "CntrlCloseBtn";
            this.CntrlCloseBtn.Size = new System.Drawing.Size(11, 11);
            this.CntrlCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CntrlCloseBtn.TabIndex = 2;
            this.CntrlCloseBtn.TabStop = false;
            this.CntrlCloseBtn.Click += new System.EventHandler(this.CntrlCloseBtn_Click);
            // 
            // InfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.CntrlCloseBtn);
            this.Controls.Add(this.CntrlMesLbl);
            this.Name = "InfoControl";
            this.Size = new System.Drawing.Size(259, 15);
            this.Load += new System.EventHandler(this.InfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CntrlCloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label CntrlMesLbl;
        public System.Windows.Forms.PictureBox CntrlCloseBtn;
        public System.Windows.Forms.Timer CloseTimer;
    }
}
