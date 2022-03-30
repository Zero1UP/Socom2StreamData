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
            this.chk_HUD = new System.Windows.Forms.CheckBox();
            this.chk_ScoreBoardAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_PCSX2 = new System.Windows.Forms.Label();
            this.tmr_CheckPCSX2 = new System.Windows.Forms.Timer(this.components);
            this.chk_SealPlayersAlwaysTopWindow = new System.Windows.Forms.CheckBox();
            this.chk_TerroristPlayersAlwaysTopWindow = new System.Windows.Forms.CheckBox();
            this.pnl_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProgramVersion
            // 
            this.lbl_ProgramVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ProgramVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgramVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_ProgramVersion.Location = new System.Drawing.Point(0, 200);
            this.lbl_ProgramVersion.Name = "lbl_ProgramVersion";
            this.lbl_ProgramVersion.Size = new System.Drawing.Size(456, 19);
            this.lbl_ProgramVersion.TabIndex = 9;
            this.lbl_ProgramVersion.Text = "VERSION";
            this.lbl_ProgramVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnl_Options
            // 
            this.pnl_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pnl_Options.Controls.Add(this.chk_ShowTerroristHealthBars);
            this.pnl_Options.Controls.Add(this.chk_ShowSealHealthBars);
            this.pnl_Options.Controls.Add(this.chk_HUD);
            this.pnl_Options.Enabled = false;
            this.pnl_Options.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Options.Location = new System.Drawing.Point(12, 36);
            this.pnl_Options.Name = "pnl_Options";
            this.pnl_Options.Size = new System.Drawing.Size(424, 92);
            this.pnl_Options.TabIndex = 10;
            // 
            // chk_ShowTerroristHealthBars
            // 
            this.chk_ShowTerroristHealthBars.AutoSize = true;
            this.chk_ShowTerroristHealthBars.Checked = true;
            this.chk_ShowTerroristHealthBars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShowTerroristHealthBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowTerroristHealthBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_ShowTerroristHealthBars.Location = new System.Drawing.Point(7, 60);
            this.chk_ShowTerroristHealthBars.Name = "chk_ShowTerroristHealthBars";
            this.chk_ShowTerroristHealthBars.Size = new System.Drawing.Size(278, 20);
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
            this.chk_ShowSealHealthBars.Location = new System.Drawing.Point(7, 34);
            this.chk_ShowSealHealthBars.Name = "chk_ShowSealHealthBars";
            this.chk_ShowSealHealthBars.Size = new System.Drawing.Size(233, 20);
            this.chk_ShowSealHealthBars.TabIndex = 5;
            this.chk_ShowSealHealthBars.Text = "Show SEAL player\'s health window";
            this.chk_ShowSealHealthBars.UseVisualStyleBackColor = true;
            this.chk_ShowSealHealthBars.CheckedChanged += new System.EventHandler(this.chk_ShowSealHealthBars_CheckedChanged);
            // 
            // chk_HUD
            // 
            this.chk_HUD.AutoSize = true;
            this.chk_HUD.Checked = true;
            this.chk_HUD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_HUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_HUD.Location = new System.Drawing.Point(7, 13);
            this.chk_HUD.Name = "chk_HUD";
            this.chk_HUD.Size = new System.Drawing.Size(158, 20);
            this.chk_HUD.TabIndex = 4;
            this.chk_HUD.Text = "Display In Game HUD";
            this.chk_HUD.UseVisualStyleBackColor = true;
            this.chk_HUD.CheckedChanged += new System.EventHandler(this.chk_HUD_CheckedChanged);
            // 
            // chk_ScoreBoardAlwaysOnTop
            // 
            this.chk_ScoreBoardAlwaysOnTop.AutoSize = true;
            this.chk_ScoreBoardAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ScoreBoardAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_ScoreBoardAlwaysOnTop.Location = new System.Drawing.Point(19, 135);
            this.chk_ScoreBoardAlwaysOnTop.Name = "chk_ScoreBoardAlwaysOnTop";
            this.chk_ScoreBoardAlwaysOnTop.Size = new System.Drawing.Size(212, 20);
            this.chk_ScoreBoardAlwaysOnTop.TabIndex = 5;
            this.chk_ScoreBoardAlwaysOnTop.Text = "Scoreboard always top window";
            this.chk_ScoreBoardAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chk_ScoreBoardAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chk_ScoreBoardAlwaysOnTop_CheckedChanged);
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 1000;
            this.tmr_Update.Tick += new System.EventHandler(this.tmr_Update_Tick);
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
            // chk_SealPlayersAlwaysTopWindow
            // 
            this.chk_SealPlayersAlwaysTopWindow.AutoSize = true;
            this.chk_SealPlayersAlwaysTopWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SealPlayersAlwaysTopWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_SealPlayersAlwaysTopWindow.Location = new System.Drawing.Point(19, 154);
            this.chk_SealPlayersAlwaysTopWindow.Name = "chk_SealPlayersAlwaysTopWindow";
            this.chk_SealPlayersAlwaysTopWindow.Size = new System.Drawing.Size(222, 20);
            this.chk_SealPlayersAlwaysTopWindow.TabIndex = 5;
            this.chk_SealPlayersAlwaysTopWindow.Text = "SEAL players always top window";
            this.chk_SealPlayersAlwaysTopWindow.UseVisualStyleBackColor = true;
            this.chk_SealPlayersAlwaysTopWindow.CheckedChanged += new System.EventHandler(this.chk_SealPlayersAlwaysTopWindow_CheckedChanged);
            // 
            // chk_TerroristPlayersAlwaysTopWindow
            // 
            this.chk_TerroristPlayersAlwaysTopWindow.AutoSize = true;
            this.chk_TerroristPlayersAlwaysTopWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_TerroristPlayersAlwaysTopWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_TerroristPlayersAlwaysTopWindow.Location = new System.Drawing.Point(19, 175);
            this.chk_TerroristPlayersAlwaysTopWindow.Name = "chk_TerroristPlayersAlwaysTopWindow";
            this.chk_TerroristPlayersAlwaysTopWindow.Size = new System.Drawing.Size(267, 20);
            this.chk_TerroristPlayersAlwaysTopWindow.TabIndex = 5;
            this.chk_TerroristPlayersAlwaysTopWindow.Text = "TERRORIST players always top window";
            this.chk_TerroristPlayersAlwaysTopWindow.UseVisualStyleBackColor = true;
            this.chk_TerroristPlayersAlwaysTopWindow.CheckedChanged += new System.EventHandler(this.chk_TerroristPlayersAlwaysTopWindow_CheckedChanged);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(456, 219);
            this.Controls.Add(this.chk_TerroristPlayersAlwaysTopWindow);
            this.Controls.Add(this.chk_SealPlayersAlwaysTopWindow);
            this.Controls.Add(this.chk_ScoreBoardAlwaysOnTop);
            this.Controls.Add(this.lbl_ProgramVersion);
            this.Controls.Add(this.pnl_Options);
            this.Controls.Add(this.lbl_PCSX2);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socom 2 Stream Data";
            this.Load += new System.EventHandler(this.fmr_Main_Load);
            this.pnl_Options.ResumeLayout(false);
            this.pnl_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_ProgramVersion;
        internal System.Windows.Forms.Panel pnl_Options;
        internal System.Windows.Forms.CheckBox chk_HUD;
        internal System.Windows.Forms.Timer tmr_Update;
        internal System.Windows.Forms.Label lbl_PCSX2;
        private System.Windows.Forms.Timer tmr_CheckPCSX2;
        internal System.Windows.Forms.CheckBox chk_ShowSealHealthBars;
        internal System.Windows.Forms.CheckBox chk_ShowTerroristHealthBars;
        internal System.Windows.Forms.CheckBox chk_ScoreBoardAlwaysOnTop;
        internal System.Windows.Forms.CheckBox chk_SealPlayersAlwaysTopWindow;
        internal System.Windows.Forms.CheckBox chk_TerroristPlayersAlwaysTopWindow;
    }
}

