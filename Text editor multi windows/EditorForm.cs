using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class EditorForm : Form
    {
        public EditorForm(CultureInfo culture)
        {
            InitializeComponent();
            // Apply culture-specific settings if necessary

            // Додаємо обробники подій у конструкторі або іншому методі ініціалізації
            this.openMenuItem.Click += new System.EventHandler(this.OpenFile);
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFile);
            this.alignLeftMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Left);
            this.alignCenterMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Center);
            this.alignRightMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Right);
            this.fontMenuItem.Click += new System.EventHandler(this.ChangeFont);
            this.insertImageMenuItem.Click += new System.EventHandler(this.InsertImage);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.LoadFile(openFileDialog.FileName);
                }
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void InsertImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    Clipboard.SetImage(img);
                    richTextBox.Paste();
                }
            }
        }
    }
}
