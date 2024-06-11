using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        private ResourceManager resManager;
        private CultureInfo currentCulture;

        public MainForm()
        {
            InitializeComponent();
            InitializeLocalization();
            this.WindowState = FormWindowState.Maximized;
            // Додаємо обробники подій у конструкторі або іншому методі ініціалізації
            this.newMenuItem.Click += new System.EventHandler(this.NewEditorWindow);
            this.exitMenuItem.Click += new System.EventHandler((s, e) => this.Close());
            this.englishMenuItem.Click += new System.EventHandler((s, e) => ChangeLanguage("en"));
            this.ukrainianMenuItem.Click += new System.EventHandler((s, e) => ChangeLanguage("uk"));
        }

        private void InitializeLocalization()
        {
            resManager = new ResourceManager("TextEditor.Resources", typeof(MainForm).Assembly);
            currentCulture = CultureInfo.CurrentCulture;
        }

        private void ChangeLanguage(string lang)
        {
            currentCulture = new CultureInfo(lang);
            // Change UI text to the selected language if needed
        }

        private void NewEditorWindow(object sender, EventArgs e)
        {
            EditorForm editorForm = new EditorForm(currentCulture);
            editorForm.MdiParent = this;
            editorForm.Show();
        }
    }
}
