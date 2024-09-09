namespace CTScanInput
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSidemenu = new Panel();
            buttonSettings = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            buttonCT = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            controlPanel = new Panel();
            panelSidemenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelSidemenu
            // 
            panelSidemenu.BackColor = Color.FromArgb(0, 84, 159);
            panelSidemenu.Controls.Add(buttonSettings);
            panelSidemenu.Controls.Add(button4);
            panelSidemenu.Controls.Add(button3);
            panelSidemenu.Controls.Add(button2);
            panelSidemenu.Controls.Add(buttonCT);
            panelSidemenu.Controls.Add(panel1);
            panelSidemenu.Dock = DockStyle.Left;
            panelSidemenu.Location = new Point(0, 0);
            panelSidemenu.Name = "panelSidemenu";
            panelSidemenu.Size = new Size(178, 466);
            panelSidemenu.TabIndex = 11;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(64, 127, 183);
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSettings.Location = new Point(0, 325);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(178, 65);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 127, 183);
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.Location = new Point(0, 260);
            button4.Name = "button4";
            button4.Size = new Size(178, 65);
            button4.TabIndex = 3;
            button4.Text = "Placeholder";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 127, 183);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(0, 195);
            button3.Name = "button3";
            button3.Size = new Size(178, 65);
            button3.TabIndex = 2;
            button3.Text = "Placeholder";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 127, 183);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(0, 130);
            button2.Name = "button2";
            button2.Size = new Size(178, 65);
            button2.TabIndex = 1;
            button2.Text = "Placeholder";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // buttonCT
            // 
            buttonCT.BackColor = Color.FromArgb(64, 127, 183);
            buttonCT.Dock = DockStyle.Top;
            buttonCT.FlatAppearance.BorderSize = 0;
            buttonCT.FlatStyle = FlatStyle.Flat;
            buttonCT.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCT.Location = new Point(0, 65);
            buttonCT.Name = "buttonCT";
            buttonCT.Size = new Size(178, 65);
            buttonCT.TabIndex = 0;
            buttonCT.Text = "CT-Scan";
            buttonCT.TextAlign = ContentAlignment.MiddleLeft;
            buttonCT.UseVisualStyleBackColor = false;
            buttonCT.Click += buttonCT_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(142, 186, 229);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.CARL_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // controlPanel
            // 
            controlPanel.Dock = DockStyle.Fill;
            controlPanel.Location = new Point(178, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(650, 466);
            controlPanel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(142, 186, 229);
            ClientSize = new Size(828, 466);
            Controls.Add(controlPanel);
            Controls.Add(panelSidemenu);
            Name = "Form1";
            Text = "Thorstens Ding";
            panelSidemenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSidemenu;
        private Button buttonSettings;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button buttonCT;
        private Panel panel1;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private Panel controlPanel;
    }
}
