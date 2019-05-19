namespace Socom2StreamData
{
    partial class frm_Main
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
            this.lbl_ProgramVersion = new System.Windows.Forms.Label();
            this.pnl_Options = new System.Windows.Forms.Panel();
            this.chk_ShowTerroristHealthBars = new System.Windows.Forms.CheckBox();
            this.chk_ShowSealHealthBars = new System.Windows.Forms.CheckBox();
            this.chk_FPS = new System.Windows.Forms.CheckBox();
            this.chk_HUD = new System.Windows.Forms.CheckBox();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_PCSX2 = new System.Windows.Forms.Label();
            this.tmr_CheckPCSX2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProgramVersion
            // 
            this.lbl_ProgramVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgramVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_ProgramVersion.Location = new System.Drawing.Point(385, 231);
            this.lbl_ProgramVersion.Name = "lbl_ProgramVersion";
            this.lbl_ProgramVersion.Size = new System.Drawing.Size(61, 19);
            this.lbl_ProgramVersion.TabIndex = 9;
            this.lbl_ProgramVersion.Text = "VERSION";
            this.lbl_ProgramVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnl_Options
            // 
            this.pnl_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pnl_Options.Controls.Add(this.chk_ShowTerroristHealthBars);
            this.pnl_Options.Controls.Add(this.chk_ShowSealHealthBars);
            this.pnl_Options.Controls.Add(this.chk_FPS);
            this.pnl_Options.Controls.Add(this.chk_HUD);
            this.pnl_Options.Enabled = false;
            this.pnl_Options.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Options.Location = new System.Drawing.Point(12, 36);
            this.pnl_Options.Name = "pnl_Options";
            this.pnl_Options.Size = new System.Drawing.Size(424, 186);
            this.pnl_Options.TabIndex = 10;
            // 
            // chk_ShowTerroristHealthBars
            // 
            this.chk_ShowTerroristHealthBars.AutoSize = true;
            this.chk_ShowTerroristHealthBars.Checked = true;
            this.chk_ShowTerroristHealthBars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShowTerroristHealthBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowTerroristHealthBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_ShowTerroristHealthBars.Location = new System.Drawing.Point(7, 90);
            this.chk_ShowTerroristHealthBars.Name = "chk_ShowTerroristHealthBars";
            this.chk_ShowTerroristHealthBars.Size = new System.Drawing.Size(279, 20);
            this.chk_ShowTerroristHealthBars.TabIndex = 5;
            this.chk_ShowTerroristHealthBars.Text = "Show TERRORIST player\'s health window";
            this.chk_ShowTerroristHealthBars.UseVisualStyleBackColor = true;
            this.chk_ShowTerroristHealthBars.CheckedChanged += new System.EventHandler(this.chk_ShowTerroristHealthBars_CheckedChanged);
            // 
            // chk_ShowSealHealthBars
            // 
            this.chk_ShowSealHealthBars.AutoSize = true;
            this.chk_ShowSealHealthBars.Checked = true;
            this.chk_ShowSealHealthBars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShowSealHealthBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowSealHealthBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_ShowSealHealthBars.Location = new System.Drawing.Point(7, 64);
            this.chk_ShowSealHealthBars.Name = "chk_ShowSealHealthBars";
            this.chk_ShowSealHealthBars.Size = new System.Drawing.Size(234, 20);
            this.chk_ShowSealHealthBars.TabIndex = 5;
            this.chk_ShowSealHealthBars.Text = "Show SEAL player\'s health window";
            this.chk_ShowSealHealthBars.UseVisualStyleBackColor = true;
            this.chk_ShowSealHealthBars.CheckedChanged += new System.EventHandler(this.chk_ShowSealHealthBars_CheckedChanged);
            // 
            // chk_FPS
            // 
            this.chk_FPS.AutoSize = true;
            this.chk_FPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_FPS.Location = new System.Drawing.Point(7, 38);
            this.chk_FPS.Name = "chk_FPS";
            this.chk_FPS.Size = new System.Drawing.Size(164, 20);
            this.chk_FPS.TabIndex = 5;
            this.chk_FPS.Text = "60 Frames Per Second";
            this.chk_FPS.UseVisualStyleBackColor = true;
            this.chk_FPS.CheckedChanged += new System.EventHandler(this.chk_FPS_CheckedChanged);
            // 
            // chk_HUD
            // 
            this.chk_HUD.AutoSize = true;
            this.chk_HUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_HUD.Location = new System.Drawing.Point(7, 13);
            this.chk_HUD.Name = "chk_HUD";
            this.chk_HUD.Size = new System.Drawing.Size(159, 20);
            this.chk_HUD.TabIndex = 4;
            this.chk_HUD.Text = "Display In Game HUD";
            this.chk_HUD.UseVisualStyleBackColor = true;
            this.chk_HUD.CheckedChanged += new System.EventHandler(this.chk_HUD_CheckedChanged);
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 1000;
            this.tmr_Update.Tick += new System.EventHandler(this.tmr_Update_Tick);
            // 
            // lbl_Version
            // 
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_Version.Location = new System.Drawing.Point(57, 226);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(342, 19);
            this.lbl_Version.TabIndex = 11;
            this.lbl_Version.Text = "...";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_PCSX2
            // 
            this.lbl_PCSX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PCSX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lbl_PCSX2.Location = new System.Drawing.Point(15, 8);
            this.lbl_PCSX2.Name = "lbl_PCSX2";
            this.lbl_PCSX2.Size = new System.Drawing.Size(421, 28);
            this.lbl_PCSX2.TabIndex = 8;
            this.lbl_PCSX2.Text = "Waiting for PCSX2...";
            this.lbl_PCSX2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmr_CheckPCSX2
            // 
            this.tmr_CheckPCSX2.Enabled = true;
            this.tmr_CheckPCSX2.Tick += new System.EventHandler(this.tmr_CheckPCSX2_Tick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(456, 251);
            this.Controls.Add(this.lbl_ProgramVersion);
            this.Controls.Add(this.pnl_Options);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_PCSX2);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socom 2 Stream Data";
            this.Load += new System.EventHandler(this.fmr_Main_Load);
            this.pnl_Options.ResumeLayout(false);
            this.pnl_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lbl_ProgramVersion;
        internal System.Windows.Forms.Panel pnl_Options;
        internal System.Windows.Forms.CheckBox chk_FPS;
        internal System.Windows.Forms.CheckBox chk_HUD;
        internal System.Windows.Forms.Timer tmr_Update;
        internal System.Windows.Forms.Label lbl_Version;
        internal System.Windows.Forms.Label lbl_PCSX2;
        private System.Windows.Forms.Timer tmr_CheckPCSX2;
        internal System.Windows.Forms.CheckBox chk_ShowSealHealthBars;
        internal System.Windows.Forms.CheckBox chk_ShowTerroristHealthBars;
    }
}

