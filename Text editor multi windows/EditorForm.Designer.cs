using System.Windows.Forms;

namespace TextEditor
{
    partial class EditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem alignLeftMenuItem;
        private ToolStripMenuItem alignCenterMenuItem;
        private ToolStripMenuItem alignRightMenuItem;
        private ToolStripMenuItem fontMenuItem;
        private ToolStripMenuItem insertImageMenuItem;
        private RichTextBox richTextBox;

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
            this.openMenuItem = new ToolStripMenuItem();
            this.saveMenuItem = new ToolStripMenuItem();
            this.formatMenu = new ToolStripMenuItem();
            this.alignLeftMenuItem = new ToolStripMenuItem();
            this.alignCenterMenuItem = new ToolStripMenuItem();
            this.alignRightMenuItem = new ToolStripMenuItem();
            this.fontMenuItem = new ToolStripMenuItem();
            this.insertImageMenuItem = new ToolStripMenuItem();
            this.richTextBox = new RichTextBox();

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileMenu,
            this.formatMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";

            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";

            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveMenuItem.Text = "Save";

            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new ToolStripItem[] {
            this.alignLeftMenuItem,
            this.alignCenterMenuItem,
            this.alignRightMenuItem,
            this.fontMenuItem,
            this.insertImageMenuItem});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(57, 20);
            this.formatMenu.Text = "Format";

            // 
            // alignLeftMenuItem
            // 
            this.alignLeftMenuItem.Name = "alignLeftMenuItem";
            this.alignLeftMenuItem.Size = new System.Drawing.Size(137, 22);
            this.alignLeftMenuItem.Text = "Align Left";

            // 
            // alignCenterMenuItem
            // 
            this.alignCenterMenuItem.Name = "alignCenterMenuItem";
            this.alignCenterMenuItem.Size = new System.Drawing.Size(137, 22);
            this.alignCenterMenuItem.Text = "Align Center";

            // 
            // alignRightMenuItem
            // 
            this.alignRightMenuItem.Name = "alignRightMenuItem";
            this.alignRightMenuItem.Size = new System.Drawing.Size(137, 22);
            this.alignRightMenuItem.Text = "Align Right";

            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fontMenuItem.Text = "Font";

            // 
            // insertImageMenuItem
            // 
            this.insertImageMenuItem.Name = "insertImageMenuItem";
            this.insertImageMenuItem.Size = new System.Drawing.Size(137, 22);
            this.insertImageMenuItem.Text = "Insert Image";

            // 
            // richTextBox
            // 
            this.richTextBox.Dock = DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 24);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 576);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";

            // 
            // EditorForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditorForm";
            this.Text = "Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
        }
    }
}
