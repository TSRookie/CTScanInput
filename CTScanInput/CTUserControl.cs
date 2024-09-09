using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTScanInput
{
    public partial class CTUserControl : UserControl
    {
        private ScanDataModel _Model = new();
        private readonly System.Threading.Timer _Clock;

        public CTUserControl()
        {

            InitializeComponent();
            _Clock = new(TimerTick, null, 0, 1_000);

            var materials = ResourceHandler.GetMaterials();
            textBoxProjectName.TextChanged += TextBoxProjectname_TextChanged;
            textBoxCellName.TextChanged += TextBoxCellName_TextChanged;
            textBoxTimestamp.Text = _Model.GetTimestampString();
            textBoxCellId.TextChanged += TextBoxCellId_TextChanged;
            textBoxProjectName.TextChanged += TextBoxProjectname_TextChanged;
            textBoxDeviceName.TextChanged += TextBoxDeviceName_TextChanged;
            comboBoxMaterial.TextChanged += ComboBoxMaterial_TextChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            SendButton.Click += SendButton_Click;


            foreach (var item in groupBoxRadioButtons.Controls.OfType<RadioButton>())
            {
                item.CheckedChanged += Item_CheckedChanged;
            }
            foreach (string Material in materials)
            {
                comboBoxMaterial.Items.Add(Material);
            }
        }

        private void ComboBoxMaterial_TextChanged1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is not RadioButton radioButton)
            {
                return;
            }
            if (radioButton.Checked)
            {
                _Model.SecurityLevel = radioButton.Text;
            }
        }

        private void TextBoxCellId_TextChanged(object? sender, EventArgs e)
        {
            _Model.CellID = textBoxCellId.Text;
        }

        private void TextBoxProjectname_TextChanged(object? sender, EventArgs e)
        {
            _Model.ProjectName = textBoxProjectName.Text;
        }

        private void TextBoxCellName_TextChanged(object? sender, EventArgs e)
        {
            _Model.CellName = textBoxCellName.Text;
        }

        private void TextBoxDeviceName_TextChanged(object? sender, EventArgs e)
        {
            _Model.DeviceName = textBoxDeviceName.Text;
        }
        private void ComboBoxMaterial_TextChanged(object? sender, EventArgs e)
        {
            _Model.Material = comboBoxMaterial.Text;
        }



        private void TimerTick(object? state)
        {
            _Model.Timestamp = DateTime.Now;
            if (InvokeRequired)
            {
                Invoke(() => textBoxTimestamp.Text = _Model.GetTimestampString());
            }
            else
            {
                textBoxTimestamp.Text = _Model.GetTimestampString();
            }
        }
        private static void CreateAndSaveTextFile(string filePath, string content)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Überprüft, ob die Datei bereits existiert
                if (File.Exists(filePath))
                {
                    Console.WriteLine("Die Datei existiert bereits. Sie wird überschrieben.");
                }

                // Erzeugt eine neue Datei und schreibt den Inhalt hinein
                File.WriteAllText(filePath, content);

                Console.WriteLine("Die Datei wurde erfolgreich erstellt und gespeichert.");
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung
                Console.WriteLine("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }



        private void SendButton_Click(object? sender, EventArgs e)
        {
            var options1 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            var resourcePath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(resourcePath, @"Output\OutputFile.txt");
            _Model.FileName = $"{_Model.Timestamp:yyyy_MM_dd_HH:mm} Messung: {_Model.CellName}";
            var jsonString = JsonSerializer.Serialize(_Model, options1);
            string message = ("Projectname: " + textBoxProjectName.Text
                               + "\n" + "Cellname: " + textBoxCellName.Text
                               + "\n" + "Devicename: " + textBoxDeviceName.Text
                               + "\n" + "Cell-ID: " + textBoxCellId.Text
                               + "\n" + "Material: " + comboBoxMaterial.Text
                               + "\n" + "Securitylevel: " + _Model.SecurityLevel);
            MessageBox.Show(message + "\n\n" + "Sie können die Anwendung nun beenden!", "Parameters saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //CreateAndSaveTextFile(filePath, message);
            CreateAndSaveTextFile(filePath, jsonString);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            _Model.OptionalText = richTextBox1.Text;
        }

    }
}
