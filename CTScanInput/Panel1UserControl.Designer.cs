namespace CTScanInput
{
    partial class Panel1UserControl
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
            panelTitle = new Panel();
            labelTitle = new Label();
            panelTitle.SuspendLayout();
            SuspendLayout();
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
            panelTitle.TabIndex = 25;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(232, 241, 250);
            labelTitle.Location = new Point(212, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(242, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Hier wird noch gebaut 1";
            // 
            // Panel1UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CARL_logo;
            Controls.Add(panelTitle);
            Name = "Panel1UserControl";
            Size = new Size(650, 466);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelTitle;
    }
}
