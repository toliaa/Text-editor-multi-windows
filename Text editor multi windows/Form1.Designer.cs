using System.Windows.Forms;

namespace TextEditor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem languageMenu;
        private ToolStripMenuItem englishMenuItem;
        private ToolStripMenuItem ukrainianMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new MenuStrip();
            this.fileMenu = new ToolStripMenuItem();
            this.newMenuItem = new ToolStripMenuItem();
            this.exitMenuItem = new ToolStripMenuItem();
            this.languageMenu = new ToolStripMenuItem();
            this.englishMenuItem = new ToolStripMenuItem();
            this.ukrainianMenuItem = new ToolStripMenuItem();

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileMenu,
            this.languageMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";

            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newMenuItem.Text = "New";

            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitMenuItem.Text = "Exit";

            // 
            // languageMenu
            // 
            this.languageMenu.DropDownItems.AddRange(new ToolStripItem[] {
            this.englishMenuItem,
            this.ukrainianMenuItem});
            this.languageMenu.Name = "languageMenu";
            this.languageMenu.Size = new System.Drawing.Size(71, 20);
            this.languageMenu.Text = "Language";

            // 
            // englishMenuItem
            // 
            this.englishMenuItem.Name = "englishMenuItem";
            this.englishMenuItem.Size = new System.Drawing.Size(125, 22);
            this.englishMenuItem.Text = "English";

            // 
            // ukrainianMenuItem
            // 
            this.ukrainianMenuItem.Name = "ukrainianMenuItem";
            this.ukrainianMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ukrainianMenuItem.Text = "Ukrainian";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Text Editor";
            this.IsMdiContainer = true;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
        }
    }
}
