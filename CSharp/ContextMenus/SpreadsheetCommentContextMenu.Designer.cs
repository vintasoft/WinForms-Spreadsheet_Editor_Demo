
namespace SpreadsheetEditorDemo
{
    partial class SpreadsheetCommentContextMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetCommentContextMenu));
            components = new System.ComponentModel.Container();
            this.editCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // commentContextMenuStrip
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCommentToolStripMenuItem,
            this.deleteCommentToolStripMenuItem,
            this.hideCommentToolStripMenuItem});
            this.Name = "commentContextMenuStrip";
            this.Size = new System.Drawing.Size(165, 70);
            // 
            // editCommentToolStripMenuItem
            // 
            this.editCommentToolStripMenuItem.Name = "editCommentToolStripMenuItem";
            this.editCommentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.editCommentToolStripMenuItem, "editCommentToolStripMenuItem");
            this.editCommentToolStripMenuItem.Click += new System.EventHandler(this.editCommentToolStripMenuItem_Click);
            // 
            // deleteCommentToolStripMenuItem
            // 
            this.deleteCommentToolStripMenuItem.Name = "deleteCommentToolStripMenuItem";
            this.deleteCommentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.deleteCommentToolStripMenuItem, "deleteCommentToolStripMenuItem");
            this.deleteCommentToolStripMenuItem.Click += new System.EventHandler(this.deleteCommentToolStripMenuItem_Click);
            // 
            // hideCommentToolStripMenuItem
            // 
            this.hideCommentToolStripMenuItem.Name = "hideCommentToolStripMenuItem";
            this.hideCommentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.hideCommentToolStripMenuItem, "hideCommentToolStripMenuItem");
            this.hideCommentToolStripMenuItem.Click += new System.EventHandler(this.hideCommentToolStripMenuItem_Click);
        }

        private System.Windows.Forms.ToolStripMenuItem editCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideCommentToolStripMenuItem;

        #endregion
    }
}
