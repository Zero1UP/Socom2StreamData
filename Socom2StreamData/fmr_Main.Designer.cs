namespace Socom2StreamData
{
    partial class fmr_Main
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
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl_timer_output = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.chk_FPS = new System.Windows.Forms.CheckBox();
            this.lbl_TerroristsAlive = new System.Windows.Forms.Label();
            this.lbl_SealsAlive = new System.Windows.Forms.Label();
            this.chk_HUD = new System.Windows.Forms.CheckBox();
            this.lbl_TotalRounds = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lbl_TerrorWon = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbl_SealsWon = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_PCSX2 = new System.Windows.Forms.Label();
            this.tmr_CheckPCSX2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Label2.Location = new System.Drawing.Point(385, 231);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 19);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "v0.02";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_timer_output
            // 
            this.lbl_timer_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_timer_output.Location = new System.Drawing.Point(182, 156);
            this.lbl_timer_output.Name = "lbl_timer_output";
            this.lbl_timer_output.Size = new System.Drawing.Size(61, 28);
            this.lbl_timer_output.TabIndex = 7;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label44.Location = new System.Drawing.Point(14, 154);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(85, 16);
            this.label44.TabIndex = 6;
            this.label44.Text = "Round Time:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Label1.Location = new System.Drawing.Point(15, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Seals Rounds Won:";
            // 
            // pnl_options
            // 
            this.pnl_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.pnl_options.Controls.Add(this.lbl_timer_output);
            this.pnl_options.Controls.Add(this.label44);
            this.pnl_options.Controls.Add(this.chk_FPS);
            this.pnl_options.Controls.Add(this.Label1);
            this.pnl_options.Controls.Add(this.lbl_TerroristsAlive);
            this.pnl_options.Controls.Add(this.lbl_SealsAlive);
            this.pnl_options.Controls.Add(this.chk_HUD);
            this.pnl_options.Controls.Add(this.lbl_TotalRounds);
            this.pnl_options.Controls.Add(this.Label6);
            this.pnl_options.Controls.Add(this.lbl_TerrorWon);
            this.pnl_options.Controls.Add(this.Label4);
            this.pnl_options.Controls.Add(this.lbl_SealsWon);
            this.pnl_options.Controls.Add(this.Label3);
            this.pnl_options.Controls.Add(this.Label7);
            this.pnl_options.Enabled = false;
            this.pnl_options.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_options.Location = new System.Drawing.Point(12, 36);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(424, 186);
            this.pnl_options.TabIndex = 10;
            // 
            // chk_FPS
            // 
            this.chk_FPS.AutoSize = true;
            this.chk_FPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_FPS.Location = new System.Drawing.Point(241, 43);
            this.chk_FPS.Name = "chk_FPS";
            this.chk_FPS.Size = new System.Drawing.Size(164, 20);
            this.chk_FPS.TabIndex = 5;
            this.chk_FPS.Text = "60 Frames Per Second";
            this.chk_FPS.UseVisualStyleBackColor = true;
            this.chk_FPS.CheckedChanged += new System.EventHandler(this.chk_FPS_CheckedChanged);
            // 
            // lbl_TerroristsAlive
            // 
            this.lbl_TerroristsAlive.AutoSize = true;
            this.lbl_TerroristsAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TerroristsAlive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_TerroristsAlive.Location = new System.Drawing.Point(183, 132);
            this.lbl_TerroristsAlive.Name = "lbl_TerroristsAlive";
            this.lbl_TerroristsAlive.Size = new System.Drawing.Size(0, 16);
            this.lbl_TerroristsAlive.TabIndex = 2;
            // 
            // lbl_SealsAlive
            // 
            this.lbl_SealsAlive.AutoSize = true;
            this.lbl_SealsAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SealsAlive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_SealsAlive.Location = new System.Drawing.Point(183, 107);
            this.lbl_SealsAlive.Name = "lbl_SealsAlive";
            this.lbl_SealsAlive.Size = new System.Drawing.Size(0, 16);
            this.lbl_SealsAlive.TabIndex = 1;
            // 
            // chk_HUD
            // 
            this.chk_HUD.AutoSize = true;
            this.chk_HUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.chk_HUD.Location = new System.Drawing.Point(241, 18);
            this.chk_HUD.Name = "chk_HUD";
            this.chk_HUD.Size = new System.Drawing.Size(159, 20);
            this.chk_HUD.TabIndex = 4;
            this.chk_HUD.Text = "Display In Game HUD";
            this.chk_HUD.UseVisualStyleBackColor = true;
            this.chk_HUD.CheckedChanged += new System.EventHandler(this.chk_HUD_CheckedChanged);
            // 
            // lbl_TotalRounds
            // 
            this.lbl_TotalRounds.AutoSize = true;
            this.lbl_TotalRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalRounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_TotalRounds.Location = new System.Drawing.Point(183, 70);
            this.lbl_TotalRounds.Name = "lbl_TotalRounds";
            this.lbl_TotalRounds.Size = new System.Drawing.Size(0, 16);
            this.lbl_TotalRounds.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Label6.Location = new System.Drawing.Point(14, 130);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(101, 16);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Terrorists Alive:";
            // 
            // lbl_TerrorWon
            // 
            this.lbl_TerrorWon.AutoSize = true;
            this.lbl_TerrorWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TerrorWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_TerrorWon.Location = new System.Drawing.Point(183, 45);
            this.lbl_TerrorWon.Name = "lbl_TerrorWon";
            this.lbl_TerrorWon.Size = new System.Drawing.Size(0, 16);
            this.lbl_TerrorWon.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Label4.Location = new System.Drawing.Point(14, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 16);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Seals Alive:";
            // 
            // lbl_SealsWon
            // 
            this.lbl_SealsWon.AutoSize = true;
            this.lbl_SealsWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SealsWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbl_SealsWon.Location = new System.Drawing.Point(183, 20);
            this.lbl_SealsWon.Name = "lbl_SealsWon";
            this.lbl_SealsWon.Size = new System.Drawing.Size(0, 16);
            this.lbl_SealsWon.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Label3.Location = new System.Drawing.Point(15, 43);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(149, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Terrorists Rounds Won:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Label7.Location = new System.Drawing.Point(15, 68);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(92, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Total Rounds:";
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
            // fmr_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(456, 259);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pnl_options);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_PCSX2);
            this.Name = "fmr_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmr_Main_Load);
            this.pnl_options.ResumeLayout(false);
            this.pnl_options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl_timer_output;
        internal System.Windows.Forms.Label label44;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel pnl_options;
        internal System.Windows.Forms.CheckBox chk_FPS;
        internal System.Windows.Forms.Label lbl_TerroristsAlive;
        internal System.Windows.Forms.Label lbl_SealsAlive;
        internal System.Windows.Forms.CheckBox chk_HUD;
        internal System.Windows.Forms.Label lbl_TotalRounds;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lbl_TerrorWon;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lbl_SealsWon;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Timer tmr_Update;
        internal System.Windows.Forms.Label lbl_Version;
        internal System.Windows.Forms.Label lbl_PCSX2;
        private System.Windows.Forms.Timer tmr_CheckPCSX2;
    }
}

