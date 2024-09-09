using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTScanInput
{
    public partial class SettingsUserControl : UserControl
    {
        private string? ressourcePath;

        public SettingsUserControl()
        {
            InitializeComponent();
            var materials = ResourceHandler.GetMaterials();
            comboBox1.TextChanged += comboBox1_TextChanged;
            foreach (string Material in materials)
            {
                if (!comboBox1.Items.Contains(Material))
                {
                    comboBox1.Items.Add(Material);
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            SaveMaterials();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Remove(comboBox1.Text);
            }
            SaveMaterials();
        }

        private void SaveMaterials()
        {
            ResourceHandler.SaveMaterials(comboBox1.Items.Cast<string>().ToList());
        }
    }
}
