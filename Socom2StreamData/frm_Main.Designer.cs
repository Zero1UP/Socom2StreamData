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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            lbl_ProgramVersion = new Label();
            pnl_Options = new Panel();
            chk_ShowTerroristHealthBars = new CheckBox();
            chk_ShowSealHealthBars = new CheckBox();
            chk_HUD = new CheckBox();
            chk_ScoreBoardAlwaysOnTop = new CheckBox();
            tmr_Update = new System.Windows.Forms.Timer(components);
            lbl_PCSX2 = new Label();
            tmr_CheckPCSX2 = new System.Windows.Forms.Timer(components);
            chk_SealPlayersAlwaysTopWindow = new CheckBox();
            chk_TerroristPlayersAlwaysTopWindow = new CheckBox();
            pnl_Options.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ProgramVersion
            // 
            lbl_ProgramVersion.Dock = DockStyle.Bottom;
            lbl_ProgramVersion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProgramVersion.ForeColor = Color.FromArgb(60, 60, 60);
            lbl_ProgramVersion.Location = new Point(0, 231);
            lbl_ProgramVersion.Margin = new Padding(4, 0, 4, 0);
            lbl_ProgramVersion.Name = "lbl_ProgramVersion";
            lbl_ProgramVersion.Size = new Size(532, 22);
            lbl_ProgramVersion.TabIndex = 9;
            lbl_ProgramVersion.Text = "VERSION";
            lbl_ProgramVersion.TextAlign = ContentAlignment.TopRight;
            // 
            // pnl_Options
            // 
            pnl_Options.BackColor = Color.FromArgb(50, 50, 54);
            pnl_Options.Controls.Add(chk_ShowTerroristHealthBars);
            pnl_Options.Controls.Add(chk_ShowSealHealthBars);
            pnl_Options.Controls.Add(chk_HUD);
            pnl_Options.Enabled = false;
            pnl_Options.ForeColor = SystemColors.ControlLight;
            pnl_Options.Location = new Point(14, 42);
            pnl_Options.Margin = new Padding(4, 3, 4, 3);
            pnl_Options.Name = "pnl_Options";
            pnl_Options.Size = new Size(495, 106);
            pnl_Options.TabIndex = 10;
            // 
            // chk_ShowTerroristHealthBars
            // 
            chk_ShowTerroristHealthBars.AutoSize = true;
            chk_ShowTerroristHealthBars.Checked = true;
            chk_ShowTerroristHealthBars.CheckState = CheckState.Checked;
            chk_ShowTerroristHealthBars.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_ShowTerroristHealthBars.ForeColor = Color.FromArgb(160, 190, 190);
            chk_ShowTerroristHealthBars.Location = new Point(8, 69);
            chk_ShowTerroristHealthBars.Margin = new Padding(4, 3, 4, 3);
            chk_ShowTerroristHealthBars.Name = "chk_ShowTerroristHealthBars";
            chk_ShowTerroristHealthBars.Size = new Size(278, 20);
            chk_ShowTerroristHealthBars.TabIndex = 5;
            chk_ShowTerroristHealthBars.Text = "Show TERRORIST player's health window";
            chk_ShowTerroristHealthBars.UseVisualStyleBackColor = true;
            chk_ShowTerroristHealthBars.CheckedChanged += chk_ShowTerroristHealthBars_CheckedChanged;
            // 
            // chk_ShowSealHealthBars
            // 
            chk_ShowSealHealthBars.AutoSize = true;
            chk_ShowSealHealthBars.Checked = true;
            chk_ShowSealHealthBars.CheckState = CheckState.Checked;
            chk_ShowSealHealthBars.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_ShowSealHealthBars.ForeColor = Color.FromArgb(160, 190, 190);
            chk_ShowSealHealthBars.Location = new Point(8, 39);
            chk_ShowSealHealthBars.Margin = new Padding(4, 3, 4, 3);
            chk_ShowSealHealthBars.Name = "chk_ShowSealHealthBars";
            chk_ShowSealHealthBars.Size = new Size(233, 20);
            chk_ShowSealHealthBars.TabIndex = 5;
            chk_ShowSealHealthBars.Text = "Show SEAL player's health window";
            chk_ShowSealHealthBars.UseVisualStyleBackColor = true;
            chk_ShowSealHealthBars.CheckedChanged += chk_ShowSealHealthBars_CheckedChanged;
            // 
            // chk_HUD
            // 
            chk_HUD.AutoSize = true;
            chk_HUD.Checked = true;
            chk_HUD.CheckState = CheckState.Checked;
            chk_HUD.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_HUD.ForeColor = Color.FromArgb(160, 190, 190);
            chk_HUD.Location = new Point(8, 15);
            chk_HUD.Margin = new Padding(4, 3, 4, 3);
            chk_HUD.Name = "chk_HUD";
            chk_HUD.Size = new Size(158, 20);
            chk_HUD.TabIndex = 4;
            chk_HUD.Text = "Display In Game HUD";
            chk_HUD.UseVisualStyleBackColor = true;
            chk_HUD.CheckedChanged += chk_HUD_CheckedChanged;
            // 
            // chk_ScoreBoardAlwaysOnTop
            // 
            chk_ScoreBoardAlwaysOnTop.AutoSize = true;
            chk_ScoreBoardAlwaysOnTop.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_ScoreBoardAlwaysOnTop.ForeColor = Color.FromArgb(160, 190, 190);
            chk_ScoreBoardAlwaysOnTop.Location = new Point(22, 156);
            chk_ScoreBoardAlwaysOnTop.Margin = new Padding(4, 3, 4, 3);
            chk_ScoreBoardAlwaysOnTop.Name = "chk_ScoreBoardAlwaysOnTop";
            chk_ScoreBoardAlwaysOnTop.Size = new Size(212, 20);
            chk_ScoreBoardAlwaysOnTop.TabIndex = 5;
            chk_ScoreBoardAlwaysOnTop.Text = "Scoreboard always top window";
            chk_ScoreBoardAlwaysOnTop.UseVisualStyleBackColor = true;
            chk_ScoreBoardAlwaysOnTop.CheckedChanged += chk_ScoreBoardAlwaysOnTop_CheckedChanged;
            // 
            // tmr_Update
            // 
            tmr_Update.Enabled = true;
            tmr_Update.Interval = 1000;
            tmr_Update.Tick += tmr_Update_Tick;
            // 
            // lbl_PCSX2
            // 
            lbl_PCSX2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PCSX2.ForeColor = Color.FromArgb(120, 120, 120);
            lbl_PCSX2.Location = new Point(18, 9);
            lbl_PCSX2.Margin = new Padding(4, 0, 4, 0);
            lbl_PCSX2.Name = "lbl_PCSX2";
            lbl_PCSX2.Size = new Size(491, 32);
            lbl_PCSX2.TabIndex = 8;
            lbl_PCSX2.Text = "Waiting for PCSX2...";
            lbl_PCSX2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tmr_CheckPCSX2
            // 
            tmr_CheckPCSX2.Enabled = true;
            tmr_CheckPCSX2.Tick += tmr_CheckPCSX2_Tick;
            // 
            // chk_SealPlayersAlwaysTopWindow
            // 
            chk_SealPlayersAlwaysTopWindow.AutoSize = true;
            chk_SealPlayersAlwaysTopWindow.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_SealPlayersAlwaysTopWindow.ForeColor = Color.FromArgb(160, 190, 190);
            chk_SealPlayersAlwaysTopWindow.Location = new Point(22, 178);
            chk_SealPlayersAlwaysTopWindow.Margin = new Padding(4, 3, 4, 3);
            chk_SealPlayersAlwaysTopWindow.Name = "chk_SealPlayersAlwaysTopWindow";
            chk_SealPlayersAlwaysTopWindow.Size = new Size(222, 20);
            chk_SealPlayersAlwaysTopWindow.TabIndex = 5;
            chk_SealPlayersAlwaysTopWindow.Text = "SEAL players always top window";
            chk_SealPlayersAlwaysTopWindow.UseVisualStyleBackColor = true;
            chk_SealPlayersAlwaysTopWindow.CheckedChanged += chk_SealPlayersAlwaysTopWindow_CheckedChanged;
            // 
            // chk_TerroristPlayersAlwaysTopWindow
            // 
            chk_TerroristPlayersAlwaysTopWindow.AutoSize = true;
            chk_TerroristPlayersAlwaysTopWindow.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_TerroristPlayersAlwaysTopWindow.ForeColor = Color.FromArgb(160, 190, 190);
            chk_TerroristPlayersAlwaysTopWindow.Location = new Point(22, 202);
            chk_TerroristPlayersAlwaysTopWindow.Margin = new Padding(4, 3, 4, 3);
            chk_TerroristPlayersAlwaysTopWindow.Name = "chk_TerroristPlayersAlwaysTopWindow";
            chk_TerroristPlayersAlwaysTopWindow.Size = new Size(267, 20);
            chk_TerroristPlayersAlwaysTopWindow.TabIndex = 5;
            chk_TerroristPlayersAlwaysTopWindow.Text = "TERRORIST players always top window";
            chk_TerroristPlayersAlwaysTopWindow.UseVisualStyleBackColor = true;
            chk_TerroristPlayersAlwaysTopWindow.CheckedChanged += chk_TerroristPlayersAlwaysTopWindow_CheckedChanged;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 40);
            ClientSize = new Size(532, 253);
            Controls.Add(chk_TerroristPlayersAlwaysTopWindow);
            Controls.Add(chk_SealPlayersAlwaysTopWindow);
            Controls.Add(chk_ScoreBoardAlwaysOnTop);
            Controls.Add(lbl_ProgramVersion);
            Controls.Add(pnl_Options);
            Controls.Add(lbl_PCSX2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socom 2 Stream Data";
            Load += fmr_Main_Load;
            pnl_Options.ResumeLayout(false);
            pnl_Options.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

