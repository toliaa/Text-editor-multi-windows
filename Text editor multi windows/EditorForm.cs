using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class EditorForm : Form
    {
        // Конструктор редактора з параметром для культури інтерфейсу
        public EditorForm(CultureInfo culture)
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            // Apply culture-specific settings if necessary

            // Додаємо обробники подій у конструкторі або іншому методі ініціалізації
            this.openMenuItem.Click += new System.EventHandler(this.OpenFile); // Відкриття файлу
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFile); // Збереження файлу
            this.alignLeftMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Left); // Вирівнювання тексту по лівому краю
            this.alignCenterMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Center); // Вирівнювання тексту по центру
            this.alignRightMenuItem.Click += new System.EventHandler((s, e) => richTextBox.SelectionAlignment = HorizontalAlignment.Right); // Вирівнювання тексту по правому краю
            this.fontMenuItem.Click += new System.EventHandler(this.ChangeFont); // Зміна шрифту
            this.insertImageMenuItem.Click += new System.EventHandler(this.InsertImage); // Вставка зображення
        }

        // Метод для відкриття файлу
        private void OpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*"; // Фільтр типів файлів для відкриття
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Відображення діалогового вікна для відкриття файлу
                {
                    richTextBox.LoadFile(openFileDialog.FileName); // Завантаження вибраного файлу у RichTextBox
                }
            }
        }

        // Метод для збереження файлу
        private void SaveFile(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*"; // Фільтр типів файлів для збереження
                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Відображення діалогового вікна для збереження файлу
                {
                    richTextBox.SaveFile(saveFileDialog.FileName); // Збереження вмісту RichTextBox у вибраний файл
                }
            }
        }

        // Метод для зміни шрифту
        private void ChangeFont(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK) // Відображення діалогового вікна для вибору шрифту
                {
                    richTextBox.SelectionFont = fontDialog.Font; // Застосування вибраного шрифту до виділеного тексту
                }
            }
        }

        // Метод для вставки зображення
        private void InsertImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png|All files|*.*"; // Фільтр типів файлів для вставки зображення
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Відображення діалогового вікна для вибору зображення
                {
                    Image img = Image.FromFile(openFileDialog.FileName); // Завантаження вибраного зображення
                    Clipboard.SetImage(img); // Копіювання зображення у буфер обміну
                    richTextBox.Paste(); // Вставка зображення з буфера обміну у RichTextBox
                }
            }
        }
    }
}
