namespace WinMailClientApp
{
    partial class VoiceBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceBox));
            this.PowerBtn = new System.Windows.Forms.Button();
            this.VBDisplay = new System.Windows.Forms.Label();
            this.MicLvl = new System.Windows.Forms.PictureBox();
            this.MasterOnOff = new System.Windows.Forms.Timer(this.components);
            this.AppRestartTime = new System.Windows.Forms.Timer(this.components);
            this.PutBacktoSleep = new System.Windows.Forms.Timer(this.components);
            this.vaTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseBtn = new System.Windows.Forms.Label();
            this.vaStart = new System.Windows.Forms.Timer(this.components);
            this.loginDelay = new System.Windows.Forms.Timer(this.components);
            this.afterLoginDelay = new System.Windows.Forms.Timer(this.components);
            this.compDelay = new System.Windows.Forms.Timer(this.components);
            this.taskFinishtklDelay = new System.Windows.Forms.Timer(this.components);
            this.inboxDelay = new System.Windows.Forms.Timer(this.components);
            this.AfterReadDelay = new System.Windows.Forms.Timer(this.components);
            this.sentDelay = new System.Windows.Forms.Timer(this.components);
            this.AfterReadDelaySent = new System.Windows.Forms.Timer(this.components);
            this.afterSntDelDelay = new System.Windows.Forms.Timer(this.components);
            this.afterInbDelDelay = new System.Windows.Forms.Timer(this.components);
            this.draftDelay = new System.Windows.Forms.Timer(this.components);
            this.afterDrftDelDelay = new System.Windows.Forms.Timer(this.components);
            this.AfterReadDelayDraft = new System.Windows.Forms.Timer(this.components);
            this.settingsDelay = new System.Windows.Forms.Timer(this.components);
            this.VAResetAuto = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MicLvl)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerBtn
            // 
            this.PowerBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PowerBtn.BackgroundImage")));
            this.PowerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerBtn.Enabled = false;
            this.PowerBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.FlatAppearance.BorderSize = 0;
            this.PowerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.PowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerBtn.Location = new System.Drawing.Point(10, 12);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(58, 36);
            this.PowerBtn.TabIndex = 1;
            this.PowerBtn.UseVisualStyleBackColor = false;
            this.PowerBtn.MouseLeave += new System.EventHandler(this.PowerBtn_MouseLeave);
            this.PowerBtn.MouseHover += new System.EventHandler(this.PowerBtn_MouseHover);
            // 
            // VBDisplay
            // 
            this.VBDisplay.AutoSize = true;
            this.VBDisplay.BackColor = System.Drawing.Color.Transparent;
            this.VBDisplay.Font = new System.Drawing.Font("Quartz", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VBDisplay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.VBDisplay.Location = new System.Drawing.Point(77, 27);
            this.VBDisplay.Name = "VBDisplay";
            this.VBDisplay.Size = new System.Drawing.Size(199, 21);
            this.VBDisplay.TabIndex = 0;
            this.VBDisplay.Text = "VB: Sleeping........!";
            // 
            // MicLvl
            // 
            this.MicLvl.BackColor = System.Drawing.Color.Transparent;
            this.MicLvl.Location = new System.Drawing.Point(337, 27);
            this.MicLvl.Name = "MicLvl";
            this.MicLvl.Size = new System.Drawing.Size(8, 21);
            this.MicLvl.TabIndex = 43;
            this.MicLvl.TabStop = false;
            // 
            // MasterOnOff
            // 
            this.MasterOnOff.Interval = 10000;
            this.MasterOnOff.Tick += new System.EventHandler(this.MasterOnOff_Tick);
            // 
            // AppRestartTime
            // 
            this.AppRestartTime.Interval = 2000;
            this.AppRestartTime.Tick += new System.EventHandler(this.AppRestartTime_Tick);
            // 
            // PutBacktoSleep
            // 
            this.PutBacktoSleep.Interval = 1000;
            this.PutBacktoSleep.Tick += new System.EventHandler(this.PutBacktoSleep_Tick);
            // 
            // vaTimer
            // 
            this.vaTimer.Interval = 1000;
            this.vaTimer.Tick += new System.EventHandler(this.vaTimer_Tick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.CloseBtn.Location = new System.Drawing.Point(335, 8);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(14, 11);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            this.CloseBtn.MouseHover += new System.EventHandler(this.CloseBtn_MouseHover);
            // 
            // vaStart
            // 
            this.vaStart.Interval = 1200;
            this.vaStart.Tick += new System.EventHandler(this.vaStart_Tick);
            // 
            // loginDelay
            // 
            this.loginDelay.Interval = 200;
            this.loginDelay.Tick += new System.EventHandler(this.loginDelay_Tick);
            // 
            // afterLoginDelay
            // 
            this.afterLoginDelay.Interval = 2000;
            this.afterLoginDelay.Tick += new System.EventHandler(this.afterLoginDelay_Tick);
            // 
            // compDelay
            // 
            this.compDelay.Interval = 1000;
            this.compDelay.Tick += new System.EventHandler(this.compDelay_Tick);
            // 
            // taskFinishtklDelay
            // 
            this.taskFinishtklDelay.Interval = 1000;
            this.taskFinishtklDelay.Tick += new System.EventHandler(this.taskFinishtklDelay_Tick);
            // 
            // inboxDelay
            // 
            this.inboxDelay.Interval = 1000;
            this.inboxDelay.Tick += new System.EventHandler(this.inboxDelay_Tick);
            // 
            // AfterReadDelay
            // 
            this.AfterReadDelay.Interval = 1100;
            this.AfterReadDelay.Tick += new System.EventHandler(this.AfterReadDelay_Tick);
            // 
            // sentDelay
            // 
            this.sentDelay.Interval = 1000;
            this.sentDelay.Tick += new System.EventHandler(this.sentDelay_Tick);
            // 
            // AfterReadDelaySent
            // 
            this.AfterReadDelaySent.Interval = 1100;
            this.AfterReadDelaySent.Tick += new System.EventHandler(this.AfterReadDelaySent_Tick);
            // 
            // afterSntDelDelay
            // 
            this.afterSntDelDelay.Interval = 1100;
            this.afterSntDelDelay.Tick += new System.EventHandler(this.afterSntDelDelay_Tick);
            // 
            // afterInbDelDelay
            // 
            this.afterInbDelDelay.Interval = 1100;
            this.afterInbDelDelay.Tick += new System.EventHandler(this.afterInbDelDelay_Tick);
            // 
            // draftDelay
            // 
            this.draftDelay.Interval = 1000;
            this.draftDelay.Tick += new System.EventHandler(this.draftDelay_Tick);
            // 
            // afterDrftDelDelay
            // 
            this.afterDrftDelDelay.Interval = 1100;
            this.afterDrftDelDelay.Tick += new System.EventHandler(this.afterDrftDelDelay_Tick);
            // 
            // AfterReadDelayDraft
            // 
            this.AfterReadDelayDraft.Interval = 1100;
            this.AfterReadDelayDraft.Tick += new System.EventHandler(this.AfterReadDelayDraft_Tick);
            // 
            // settingsDelay
            // 
            this.settingsDelay.Interval = 1000;
            this.settingsDelay.Tick += new System.EventHandler(this.settingsDelay_Tick);
            // 
            // VAResetAuto
            // 
            this.VAResetAuto.Interval = 1000;
            this.VAResetAuto.Tick += new System.EventHandler(this.VAResetAuto_Tick);
            // 
            // VoiceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 60);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MicLvl);
            this.Controls.Add(this.VBDisplay);
            this.Controls.Add(this.PowerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoiceBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VoiceBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VoiceBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MicLvl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.PictureBox MicLvl;
        private System.Windows.Forms.Label VBDisplay;
        private System.Windows.Forms.Timer MasterOnOff;
        private System.Windows.Forms.Timer AppRestartTime;
        private System.Windows.Forms.Timer PutBacktoSleep;
        private System.Windows.Forms.Timer vaTimer;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Timer vaStart;
        private System.Windows.Forms.Timer loginDelay;
        private System.Windows.Forms.Timer afterLoginDelay;
        private System.Windows.Forms.Timer compDelay;
        private System.Windows.Forms.Timer taskFinishtklDelay;
        private System.Windows.Forms.Timer inboxDelay;
        private System.Windows.Forms.Timer AfterReadDelay;
        private System.Windows.Forms.Timer sentDelay;
        private System.Windows.Forms.Timer AfterReadDelaySent;
        private System.Windows.Forms.Timer afterSntDelDelay;
        private System.Windows.Forms.Timer afterInbDelDelay;
        private System.Windows.Forms.Timer draftDelay;
        private System.Windows.Forms.Timer afterDrftDelDelay;
        private System.Windows.Forms.Timer AfterReadDelayDraft;
        private System.Windows.Forms.Timer settingsDelay;
        private System.Windows.Forms.Timer VAResetAuto;
    }
}