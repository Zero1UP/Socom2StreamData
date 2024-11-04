namespace Socom2StreamData.Controls
{
    partial class HealthBar
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
            panel1 = new Panel();
            pnl_HealthBar = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 75, 75);
            panel1.Controls.Add(pnl_HealthBar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 6);
            panel1.TabIndex = 0;
            // 
            // pnl_HealthBar
            // 
            pnl_HealthBar.BackColor = Color.FromArgb(25, 140, 25);
            pnl_HealthBar.Dock = DockStyle.Left;
            pnl_HealthBar.Location = new Point(0, 0);
            pnl_HealthBar.Margin = new Padding(4, 3, 4, 3);
            pnl_HealthBar.Name = "pnl_HealthBar";
            pnl_HealthBar.Size = new Size(117, 6);
            pnl_HealthBar.TabIndex = 0;
            // 
            // HealthBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HealthBar";
            Size = new Size(117, 6);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_HealthBar;
    }
}
