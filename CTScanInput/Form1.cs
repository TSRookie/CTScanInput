using CTScanInputColorScheme;


namespace CTScanInput
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Form1()
        {

            InitializeComponent();
            controlPanel.Controls.Add(new HomeUserControl());
            random = new Random();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                
                    DisableButton();
                    Color color = SelectThemeColor();
                if (btnSender is Button currentButton)
                {
                    currentButton.BackColor = Color.FromArgb(0, 84, 159);
                    currentButton.ForeColor = Color.FromArgb(232, 241, 250);
                    currentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidemenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 127, 183);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
                }
            }
        }



        private void buttonCT_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new CTUserControl());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new Panel1UserControl()); ;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new Panel2UserControl());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new Panel3UserControl());
        }

        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new SettingsUserControl());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(new HomeUserControl());
        }
    }
}
