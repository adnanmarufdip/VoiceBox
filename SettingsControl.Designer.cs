namespace WinMailClientApp
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.vrEnDis = new System.Windows.Forms.CheckBox();
            this.vaEnDis = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnResetAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DelayTime = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voice User Interface";
            // 
            // vrEnDis
            // 
            this.vrEnDis.AutoSize = true;
            this.vrEnDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vrEnDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrEnDis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrEnDis.Location = new System.Drawing.Point(56, 98);
            this.vrEnDis.Name = "vrEnDis";
            this.vrEnDis.Size = new System.Drawing.Size(121, 21);
            this.vrEnDis.TabIndex = 2;
            this.vrEnDis.Text = "Enable/Disable";
            this.vrEnDis.UseVisualStyleBackColor = true;
            // 
            // vaEnDis
            // 
            this.vaEnDis.AutoSize = true;
            this.vaEnDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vaEnDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vaEnDis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaEnDis.Location = new System.Drawing.Point(56, 210);
            this.vaEnDis.Name = "vaEnDis";
            this.vaEnDis.Size = new System.Drawing.Size(121, 21);
            this.vaEnDis.TabIndex = 5;
            this.vaEnDis.Text = "Enable/Disable";
            this.vaEnDis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(50, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Virtual Assistant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(502, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Account";
            // 
            // BtnResetAll
            // 
            this.BtnResetAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnResetAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResetAll.BorderRadius = 7;
            this.BtnResetAll.ButtonText = "Reset all";
            this.BtnResetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetAll.DisabledColor = System.Drawing.Color.Gray;
            this.BtnResetAll.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnResetAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnResetAll.Iconimage")));
            this.BtnResetAll.Iconimage_right = null;
            this.BtnResetAll.Iconimage_right_Selected = null;
            this.BtnResetAll.Iconimage_Selected = null;
            this.BtnResetAll.IconMarginLeft = 0;
            this.BtnResetAll.IconMarginRight = 0;
            this.BtnResetAll.IconRightVisible = true;
            this.BtnResetAll.IconRightZoom = 0D;
            this.BtnResetAll.IconVisible = true;
            this.BtnResetAll.IconZoom = 90D;
            this.BtnResetAll.IsTab = false;
            this.BtnResetAll.Location = new System.Drawing.Point(509, 362);
            this.BtnResetAll.Name = "BtnResetAll";
            this.BtnResetAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnResetAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.BtnResetAll.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnResetAll.selected = false;
            this.BtnResetAll.Size = new System.Drawing.Size(121, 29);
            this.BtnResetAll.TabIndex = 8;
            this.BtnResetAll.Text = "Reset all";
            this.BtnResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResetAll.Textcolor = System.Drawing.Color.White;
            this.BtnResetAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetAll.Click += new System.EventHandler(this.BtnResetAll_Click);
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignOut.BorderRadius = 7;
            this.BtnSignOut.ButtonText = "Sign out";
            this.BtnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSignOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSignOut.Iconimage")));
            this.BtnSignOut.Iconimage_right = null;
            this.BtnSignOut.Iconimage_right_Selected = null;
            this.BtnSignOut.Iconimage_Selected = null;
            this.BtnSignOut.IconMarginLeft = 0;
            this.BtnSignOut.IconMarginRight = 0;
            this.BtnSignOut.IconRightVisible = true;
            this.BtnSignOut.IconRightZoom = 0D;
            this.BtnSignOut.IconVisible = true;
            this.BtnSignOut.IconZoom = 90D;
            this.BtnSignOut.IsTab = false;
            this.BtnSignOut.Location = new System.Drawing.Point(509, 397);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.BtnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSignOut.selected = false;
            this.BtnSignOut.Size = new System.Drawing.Size(121, 29);
            this.BtnSignOut.TabIndex = 9;
            this.BtnSignOut.Text = "Sign out";
            this.BtnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSignOut.Textcolor = System.Drawing.Color.White;
            this.BtnSignOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSave.BorderRadius = 7;
            this.BtnSave.ButtonText = "     Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSave.Iconimage")));
            this.BtnSave.Iconimage_right = null;
            this.BtnSave.Iconimage_right_Selected = null;
            this.BtnSave.Iconimage_Selected = null;
            this.BtnSave.IconMarginLeft = 0;
            this.BtnSave.IconMarginRight = 0;
            this.BtnSave.IconRightVisible = true;
            this.BtnSave.IconRightZoom = 0D;
            this.BtnSave.IconVisible = false;
            this.BtnSave.IconZoom = 0D;
            this.BtnSave.IsTab = false;
            this.BtnSave.Location = new System.Drawing.Point(55, 397);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.BtnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSave.selected = false;
            this.BtnSave.Size = new System.Drawing.Size(83, 29);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "     Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Textcolor = System.Drawing.Color.White;
            this.BtnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(213, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Application may restart to make changes";
            // 
            // DelayTime
            // 
            this.DelayTime.Interval = 3000;
            this.DelayTime.Tick += new System.EventHandler(this.DelayTime_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(51, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "(voice-recognition && speech-synthesis)";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.BtnResetAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vaEnDis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrEnDis);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(675, 469);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox vrEnDis;
        private System.Windows.Forms.CheckBox vaEnDis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton BtnResetAll;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSignOut;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer DelayTime;
        private System.Windows.Forms.Label label5;
    }
}
