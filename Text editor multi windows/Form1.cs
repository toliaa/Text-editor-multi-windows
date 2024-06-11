using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        // Декларація ресурсного менеджера та культури для багатомовного інтерфейсу
        private ResourceManager resManager;
        private CultureInfo currentCulture;

        // Конструктор головної форми
        public MainForm()
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializeLocalization(); // Ініціалізація локалізації
            this.WindowState = FormWindowState.Maximized; // Встановлення повноекранного режиму при запуску

            // Прив'язка подій до елементів меню
            this.newMenuItem.Click += new System.EventHandler(this.NewEditorWindow); // Відкриття нового вікна редактора
            this.exitMenuItem.Click += new System.EventHandler((s, e) => this.Close()); // Закриття програми
            this.englishMenuItem.Click += new System.EventHandler((s, e) => ChangeLanguage("en")); // Зміна мови на англійську
            this.ukrainianMenuItem.Click += new System.EventHandler((s, e) => ChangeLanguage("uk")); // Зміна мови на українську
        }

        // Метод для ініціалізації локалізації
        private void InitializeLocalization()
        {
            resManager = new ResourceManager("TextEditor.Resources", typeof(MainForm).Assembly); // Ініціалізація ресурсного менеджера
            currentCulture = CultureInfo.CurrentCulture; // Встановлення поточної культури
        }

        // Метод для зміни мови інтерфейсу
        private void ChangeLanguage(string lang)
        {
            currentCulture = new CultureInfo(lang); // Зміна поточної культури на вибрану
            // Тут можна додати код для зміни тексту інтерфейсу на обрану мову
        }

        // Метод для створення нового вікна редактора
        private void NewEditorWindow(object sender, EventArgs e)
        {
            EditorForm editorForm = new EditorForm(currentCulture); // Створення нового вікна редактора з поточною культурою
            editorForm.MdiParent = this; // Встановлення батьківського вікна
            editorForm.Show(); // Показ вікна редактора
        }
    }
}
