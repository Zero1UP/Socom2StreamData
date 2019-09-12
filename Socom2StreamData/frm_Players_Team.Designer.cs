namespace Socom2StreamData
{
    partial class frm_Players_Team
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
            this.pnl_Team = new System.Windows.Forms.Panel();
            this.pnl_Team_Players = new System.Windows.Forms.Panel();
            this.hb_Player_p8 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p7 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p6 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p5 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p4 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p3 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p2 = new Socom2StreamData.Controls.HealthBar();
            this.hb_Player_p1 = new Socom2StreamData.Controls.HealthBar();
            this.lbl_Player_p1 = new System.Windows.Forms.Label();
            this.lbl_Player_p8 = new System.Windows.Forms.Label();
            this.lbl_Player_p2 = new System.Windows.Forms.Label();
            this.lbl_Player_p7 = new System.Windows.Forms.Label();
            this.lbl_Player_p3 = new System.Windows.Forms.Label();
            this.lbl_Player_p6 = new System.Windows.Forms.Label();
            this.lbl_Player_p4 = new System.Windows.Forms.Label();
            this.lbl_Player_p5 = new System.Windows.Forms.Label();
            this.lbl_Team = new System.Windows.Forms.Label();
            this.pnl_Team.SuspendLayout();
            this.pnl_Team_Players.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Team
            // 
            this.pnl_Team.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_Team.Controls.Add(this.pnl_Team_Players);
            this.pnl_Team.Controls.Add(this.lbl_Team);
            this.pnl_Team.Location = new System.Drawing.Point(4, 4);
            this.pnl_Team.Name = "pnl_Team";
            this.pnl_Team.Size = new System.Drawing.Size(123, 280);
            this.pnl_Team.TabIndex = 20;
            this.pnl_Team.MouseEnter += new System.EventHandler(this.pnl_Team_MouseEnter);
            this.pnl_Team.MouseLeave += new System.EventHandler(this.pnl_Team_MouseLeave);
            this.pnl_Team.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Team_MouseMove);
            // 
            // pnl_Team_Players
            // 
            this.pnl_Team_Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p8);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p7);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p6);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p5);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p4);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p3);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p2);
            this.pnl_Team_Players.Controls.Add(this.hb_Player_p1);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p1);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p8);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p2);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p7);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p3);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p6);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p4);
            this.pnl_Team_Players.Controls.Add(this.lbl_Player_p5);
            this.pnl_Team_Players.Location = new System.Drawing.Point(3, 26);
            this.pnl_Team_Players.Name = "pnl_Team_Players";
            this.pnl_Team_Players.Size = new System.Drawing.Size(115, 250);
            this.pnl_Team_Players.TabIndex = 16;
            // 
            // hb_Player_p8
            // 
            this.hb_Player_p8.healthSet = false;
            this.hb_Player_p8.Location = new System.Drawing.Point(9, 238);
            this.hb_Player_p8.Name = "hb_Player_p8";
            this.hb_Player_p8.playerHealth = 75;
            this.hb_Player_p8.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p8.TabIndex = 20;
            // 
            // hb_Player_p7
            // 
            this.hb_Player_p7.healthSet = false;
            this.hb_Player_p7.Location = new System.Drawing.Point(9, 208);
            this.hb_Player_p7.Name = "hb_Player_p7";
            this.hb_Player_p7.playerHealth = 75;
            this.hb_Player_p7.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p7.TabIndex = 20;
            // 
            // hb_Player_p6
            // 
            this.hb_Player_p6.healthSet = false;
            this.hb_Player_p6.Location = new System.Drawing.Point(9, 178);
            this.hb_Player_p6.Name = "hb_Player_p6";
            this.hb_Player_p6.playerHealth = 75;
            this.hb_Player_p6.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p6.TabIndex = 20;
            // 
            // hb_Player_p5
            // 
            this.hb_Player_p5.healthSet = false;
            this.hb_Player_p5.Location = new System.Drawing.Point(9, 148);
            this.hb_Player_p5.Name = "hb_Player_p5";
            this.hb_Player_p5.playerHealth = 75;
            this.hb_Player_p5.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p5.TabIndex = 20;
            // 
            // hb_Player_p4
            // 
            this.hb_Player_p4.healthSet = false;
            this.hb_Player_p4.Location = new System.Drawing.Point(9, 118);
            this.hb_Player_p4.Name = "hb_Player_p4";
            this.hb_Player_p4.playerHealth = 75;
            this.hb_Player_p4.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p4.TabIndex = 19;
            // 
            // hb_Player_p3
            // 
            this.hb_Player_p3.healthSet = false;
            this.hb_Player_p3.Location = new System.Drawing.Point(9, 88);
            this.hb_Player_p3.Name = "hb_Player_p3";
            this.hb_Player_p3.playerHealth = 75;
            this.hb_Player_p3.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p3.TabIndex = 18;
            // 
            // hb_Player_p2
            // 
            this.hb_Player_p2.healthSet = false;
            this.hb_Player_p2.Location = new System.Drawing.Point(9, 58);
            this.hb_Player_p2.Name = "hb_Player_p2";
            this.hb_Player_p2.playerHealth = 75;
            this.hb_Player_p2.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p2.TabIndex = 17;
            // 
            // hb_Player_p1
            // 
            this.hb_Player_p1.healthSet = false;
            this.hb_Player_p1.Location = new System.Drawing.Point(9, 28);
            this.hb_Player_p1.Name = "hb_Player_p1";
            this.hb_Player_p1.playerHealth = 75;
            this.hb_Player_p1.Size = new System.Drawing.Size(100, 5);
            this.hb_Player_p1.TabIndex = 16;
            // 
            // lbl_Player_p1
            // 
            this.lbl_Player_p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p1.Location = new System.Drawing.Point(9, 6);
            this.lbl_Player_p1.Name = "lbl_Player_p1";
            this.lbl_Player_p1.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p1.TabIndex = 0;
            this.lbl_Player_p1.Text = "NAME";
            this.lbl_Player_p1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p1.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p8
            // 
            this.lbl_Player_p8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p8.Location = new System.Drawing.Point(9, 216);
            this.lbl_Player_p8.Name = "lbl_Player_p8";
            this.lbl_Player_p8.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p8.TabIndex = 14;
            this.lbl_Player_p8.Text = "NAME";
            this.lbl_Player_p8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p8.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p2
            // 
            this.lbl_Player_p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p2.Location = new System.Drawing.Point(9, 36);
            this.lbl_Player_p2.Name = "lbl_Player_p2";
            this.lbl_Player_p2.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p2.TabIndex = 2;
            this.lbl_Player_p2.Text = "NAME";
            this.lbl_Player_p2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p2.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p7
            // 
            this.lbl_Player_p7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p7.Location = new System.Drawing.Point(9, 186);
            this.lbl_Player_p7.Name = "lbl_Player_p7";
            this.lbl_Player_p7.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p7.TabIndex = 12;
            this.lbl_Player_p7.Text = "NAME";
            this.lbl_Player_p7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p7.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p3
            // 
            this.lbl_Player_p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p3.Location = new System.Drawing.Point(9, 66);
            this.lbl_Player_p3.Name = "lbl_Player_p3";
            this.lbl_Player_p3.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p3.TabIndex = 4;
            this.lbl_Player_p3.Text = "NAME";
            this.lbl_Player_p3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p3.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p6
            // 
            this.lbl_Player_p6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p6.Location = new System.Drawing.Point(9, 156);
            this.lbl_Player_p6.Name = "lbl_Player_p6";
            this.lbl_Player_p6.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p6.TabIndex = 10;
            this.lbl_Player_p6.Text = "NAME";
            this.lbl_Player_p6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p6.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p4
            // 
            this.lbl_Player_p4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p4.Location = new System.Drawing.Point(9, 96);
            this.lbl_Player_p4.Name = "lbl_Player_p4";
            this.lbl_Player_p4.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p4.TabIndex = 6;
            this.lbl_Player_p4.Text = "NAME";
            this.lbl_Player_p4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p4.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Player_p5
            // 
            this.lbl_Player_p5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_Player_p5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Player_p5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Player_p5.Location = new System.Drawing.Point(9, 126);
            this.lbl_Player_p5.Name = "lbl_Player_p5";
            this.lbl_Player_p5.Size = new System.Drawing.Size(100, 19);
            this.lbl_Player_p5.TabIndex = 8;
            this.lbl_Player_p5.Text = "NAME";
            this.lbl_Player_p5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Player_p5.Click += new System.EventHandler(this.playerNameClick);
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Team.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Team.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.lbl_Team.Location = new System.Drawing.Point(18, 5);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(46, 17);
            this.lbl_Team.TabIndex = 0;
            this.lbl_Team.Text = "Team";
            this.lbl_Team.MouseEnter += new System.EventHandler(this.lbl_Team_MouseEnter);
            this.lbl_Team.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Team_MouseMove);
            // 
            // frm_Players_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(130, 288);
            this.Controls.Add(this.pnl_Team);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Players_Team";
            this.Text = "Players_Terrorists";
            this.pnl_Team.ResumeLayout(false);
            this.pnl_Team.PerformLayout();
            this.pnl_Team_Players.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Team;
        private System.Windows.Forms.Panel pnl_Team_Players;
        private Controls.HealthBar hb_Player_p8;
        private Controls.HealthBar hb_Player_p7;
        private Controls.HealthBar hb_Player_p6;
        private Controls.HealthBar hb_Player_p5;
        private Controls.HealthBar hb_Player_p4;
        private Controls.HealthBar hb_Player_p3;
        private Controls.HealthBar hb_Player_p2;
        private Controls.HealthBar hb_Player_p1;
        private System.Windows.Forms.Label lbl_Player_p1;
        private System.Windows.Forms.Label lbl_Player_p8;
        private System.Windows.Forms.Label lbl_Player_p2;
        private System.Windows.Forms.Label lbl_Player_p7;
        private System.Windows.Forms.Label lbl_Player_p3;
        private System.Windows.Forms.Label lbl_Player_p6;
        private System.Windows.Forms.Label lbl_Player_p4;
        private System.Windows.Forms.Label lbl_Player_p5;
        private System.Windows.Forms.Label lbl_Team;
    }
}