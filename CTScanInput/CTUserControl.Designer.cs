namespace CTScanInput
{
    partial class CTUserControl
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
            richTextBox1 = new RichTextBox();
            groupBoxRadioButtons = new GroupBox();
            radioButtonBGA = new RadioButton();
            radioButtonNDA = new RadioButton();
            radioButtonOEGP = new RadioButton();
            label5 = new Label();
            panelTitle = new Panel();
            labelTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelMaterial = new Label();
            textBoxCellId = new TextBox();
            label4 = new Label();
            textBoxDeviceName = new TextBox();
            label3 = new Label();
            textBoxCellName = new TextBox();
            label2 = new Label();
            textBoxTimestamp = new TextBox();
            dateTime = new Label();
            label1 = new Label();
            textBoxProjectName = new TextBox();
            comboBoxMaterial = new ComboBox();
            SendButton = new Button();
            groupBoxRadioButtons.SuspendLayout();
            panelTitle.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(294, 124);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 174);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // groupBoxRadioButtons
            // 
            groupBoxRadioButtons.BackgroundImageLayout = ImageLayout.None;
            groupBoxRadioButtons.Controls.Add(radioButtonBGA);
            groupBoxRadioButtons.Controls.Add(radioButtonNDA);
            groupBoxRadioButtons.Controls.Add(radioButtonOEGP);
            groupBoxRadioButtons.Location = new Point(294, 306);
            groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            groupBoxRadioButtons.Size = new Size(200, 100);
            groupBoxRadioButtons.TabIndex = 24;
            groupBoxRadioButtons.TabStop = false;
            // 
            // radioButtonBGA
            // 
            radioButtonBGA.AutoSize = true;
            radioButtonBGA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonBGA.Location = new Point(12, 44);
            radioButtonBGA.Name = "radioButtonBGA";
            radioButtonBGA.Size = new Size(52, 21);
            radioButtonBGA.TabIndex = 16;
            radioButtonBGA.TabStop = true;
            radioButtonBGA.Text = "BGA";
            radioButtonBGA.UseVisualStyleBackColor = true;
            // 
            // radioButtonNDA
            // 
            radioButtonNDA.AutoSize = true;
            radioButtonNDA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonNDA.Location = new Point(12, 69);
            radioButtonNDA.Name = "radioButtonNDA";
            radioButtonNDA.Size = new Size(55, 21);
            radioButtonNDA.TabIndex = 17;
            radioButtonNDA.TabStop = true;
            radioButtonNDA.Text = "NDA";
            radioButtonNDA.UseVisualStyleBackColor = true;
            // 
            // radioButtonOEGP
            // 
            radioButtonOEGP.AutoSize = true;
            radioButtonOEGP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonOEGP.Location = new Point(12, 19);
            radioButtonOEGP.Name = "radioButtonOEGP";
            radioButtonOEGP.Size = new Size(53, 21);
            radioButtonOEGP.TabIndex = 15;
            radioButtonOEGP.TabStop = true;
            radioButtonOEGP.Text = "ÖGP";
            radioButtonOEGP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 104);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 23;
            label5.Text = "Optional Info";
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
            panelTitle.TabIndex = 22;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(232, 241, 250);
            labelTitle.Location = new Point(294, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(36, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CT";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(142, 186, 229);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelMaterial, 0, 8);
            tableLayoutPanel1.Controls.Add(textBoxCellId, 0, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 6);
            tableLayoutPanel1.Controls.Add(textBoxDeviceName, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxCellName, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxTimestamp, 0, 11);
            tableLayoutPanel1.Controls.Add(dateTime, 0, 10);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxProjectName, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxMaterial, 0, 9);
            tableLayoutPanel1.Location = new Point(10, 78);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.53968239F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3015871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.73016F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(271, 385);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.BackColor = Color.FromArgb(142, 186, 229);
            labelMaterial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaterial.ForeColor = Color.Black;
            labelMaterial.Location = new Point(0, 181);
            labelMaterial.Margin = new Padding(0);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(59, 17);
            labelMaterial.TabIndex = 11;
            labelMaterial.Text = "Material";
            labelMaterial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCellId
            // 
            textBoxCellId.Location = new Point(3, 155);
            textBoxCellId.Name = "textBoxCellId";
            textBoxCellId.Size = new Size(63, 23);
            textBoxCellId.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(142, 186, 229);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 136);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 9;
            label4.Text = "Cell-ID\r\n";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDeviceName
            // 
            textBoxDeviceName.Location = new Point(3, 110);
            textBoxDeviceName.Name = "textBoxDeviceName";
            textBoxDeviceName.Size = new Size(240, 23);
            textBoxDeviceName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(142, 186, 229);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 91);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 7;
            label3.Text = "Devicename";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCellName
            // 
            textBoxCellName.Location = new Point(3, 65);
            textBoxCellName.Name = "textBoxCellName";
            textBoxCellName.Size = new Size(240, 23);
            textBoxCellName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(142, 186, 229);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 45);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Cellname";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTimestamp
            // 
            textBoxTimestamp.Location = new Point(3, 246);
            textBoxTimestamp.Name = "textBoxTimestamp";
            textBoxTimestamp.Size = new Size(163, 23);
            textBoxTimestamp.TabIndex = 3;
            // 
            // dateTime
            // 
            dateTime.AutoSize = true;
            dateTime.BackColor = Color.FromArgb(142, 186, 229);
            dateTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime.ForeColor = Color.Black;
            dateTime.Location = new Point(0, 226);
            dateTime.Margin = new Padding(0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(39, 17);
            dateTime.TabIndex = 2;
            dateTime.Text = "Time";
            dateTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(142, 186, 229);
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 0;
            label1.Text = "Projectname";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(3, 19);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(240, 23);
            textBoxProjectName.TabIndex = 1;
            // 
            // comboBoxMaterial
            // 
            comboBoxMaterial.FormattingEnabled = true;
            comboBoxMaterial.Location = new Point(3, 201);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.Size = new Size(237, 23);
            comboBoxMaterial.TabIndex = 20;
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendButton.ForeColor = SystemColors.ControlText;
            SendButton.Location = new Point(560, 427);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 27);
            SendButton.TabIndex = 21;
            SendButton.Text = "Save Data";
            SendButton.UseVisualStyleBackColor = true;
            // 
            // CTUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(groupBoxRadioButtons);
            Controls.Add(label5);
            Controls.Add(panelTitle);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SendButton);
            Name = "CTUserControl";
            Size = new Size(650, 466);
            groupBoxRadioButtons.ResumeLayout(false);
            groupBoxRadioButtons.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private GroupBox groupBoxRadioButtons;
        private RadioButton radioButtonBGA;
        private RadioButton radioButtonNDA;
        private RadioButton radioButtonOEGP;
        private Label label5;
        private Panel panelTitle;
        private Label labelTitle;
        public TableLayoutPanel tableLayoutPanel1;
        private Label labelMaterial;
        private TextBox textBoxCellId;
        private Label label4;
        private TextBox textBoxDeviceName;
        private Label label3;
        private TextBox textBoxCellName;
        private Label label2;
        private TextBox textBoxTimestamp;
        private Label dateTime;
        private Label label1;
        private TextBox textBoxProjectName;
        private ComboBox comboBoxMaterial;
        private Button SendButton;
    }
}
