using System;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormNotpad
{
    public partial class Form1 : Form
    {
        public class Seria
        {
            public string Name { get; set; }
            public string RichText { get; set; }
            public Seria(string name, string richText)
            {
                Name = name;
                RichText = richText;
            }

        }
        List<Seria> serias = new List<Seria>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var item in FontFamily.Families)
            {
                comboBoxFont.Items.Add(item.Name);
            }
            for (int i = 0; i <= 78; i += 2)
            {
                comboBoxSize.Items.Add(i);
            }


            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                comboBoxColor.Items.Add(color.Name);
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBoxFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBoxSize.Font.ToString(), int.Parse(comboBoxSize.SelectedItem.ToString()));
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Bold.ToString(), richTextBox1.Font.Size);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);

        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Inherit;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColorName = comboBoxColor.SelectedItem.ToString();
            richTextBox1.ForeColor = Color.FromName(selectedColorName);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            foreach (var item in serias)
            {
                if (item.Name==LoadTextBox.Text)
                {
                    richTextBox1.Text = item.RichText;
                }
            }
            LoadTextBox.Text = default;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Seria seriaa = new Seria(SaveTextBox.Text,richTextBox1.Text);
            serias.Add(seriaa);
            richTextBox1.Text = default;
            SaveTextBox.Text = default;
        }
    }
}
