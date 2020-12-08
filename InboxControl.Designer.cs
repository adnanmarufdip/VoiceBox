namespace WinMailClientApp
{
    partial class InboxControl
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.timerT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(675, 463);
            this.scrollPanel.TabIndex = 4;
            // 
            // timerT
            // 
            this.timerT.Interval = 300;
            this.timerT.Tick += new System.EventHandler(this.timerT_Tick);
            // 
            // InboxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.scrollPanel);
            this.Name = "InboxControl";
            this.Size = new System.Drawing.Size(675, 469);
            this.Load += new System.EventHandler(this.InboxControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Timer timerT;
    }
}
