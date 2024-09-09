namespace CTScanInput
{
    partial class HomeUserControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            panelTitle = new Panel();
            pictureBox1 = new PictureBox();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(232, 241, 250);
            labelTitle.Location = new Point(279, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(68, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Home";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 84, 159);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Font = new Font("Segoe UI", 15F);
            panelTitle.ForeColor = SystemColors.ControlLightLight;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(650, 65);
            panelTitle.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.CARL_logo;
            pictureBox1.Location = new Point(22, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(panelTitle);
            Name = "HomeUserControl";
            Size = new Size(650, 466);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelTitle;
        private PictureBox pictureBox1;
    }
}
