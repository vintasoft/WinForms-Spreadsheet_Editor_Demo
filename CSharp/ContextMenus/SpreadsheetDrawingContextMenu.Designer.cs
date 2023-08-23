
namespace SpreadsheetEditorDemo
{
    partial class SpreadsheetDrawingContextMenu
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
            components = new System.ComponentModel.Container();
            this.drawingSetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.drawingLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingRemoveLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // drawingContextMenuStrip
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawingSetImageToolStripMenuItem,
            this.toolStripSeparator5,
            this.drawingLinkToolStripMenuItem,
            this.drawingRemoveLinkToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteDrawingToolStripMenuItem,
            this.drawingPropertiesToolStripMenuItem});
            this.Name = "drawingContextMenuStrip";
            this.Size = new System.Drawing.Size(143, 126);
            this.Opening += new System.ComponentModel.CancelEventHandler(this.drawingContextMenuStrip_Opening);
            // 
            // drawingSetImageToolStripMenuItem
            // 
            this.drawingSetImageToolStripMenuItem.Name = "drawingSetImageToolStripMenuItem";
            this.drawingSetImageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.drawingSetImageToolStripMenuItem.Text = "Set Image...";
            this.drawingSetImageToolStripMenuItem.Click += new System.EventHandler(this.drawingSetImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(139, 6);
            // 
            // drawingLinkToolStripMenuItem
            // 
            this.drawingLinkToolStripMenuItem.Name = "drawingLinkToolStripMenuItem";
            this.drawingLinkToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.drawingLinkToolStripMenuItem.Text = "Set Link...";
            this.drawingLinkToolStripMenuItem.Click += new System.EventHandler(this.drawingLinkToolStripMenuItem_Click);
            // 
            // drawingRemoveLinkToolStripMenuItem
            // 
            this.drawingRemoveLinkToolStripMenuItem.Name = "drawingRemoveLinkToolStripMenuItem";
            this.drawingRemoveLinkToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.drawingRemoveLinkToolStripMenuItem.Text = "Remove Link";
            this.drawingRemoveLinkToolStripMenuItem.Click += new System.EventHandler(this.drawingRemoveLinkToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(139, 6);
            // 
            // deleteDrawingToolStripMenuItem
            // 
            this.deleteDrawingToolStripMenuItem.Name = "deleteDrawingToolStripMenuItem";
            this.deleteDrawingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteDrawingToolStripMenuItem.Text = "Delete";
            this.deleteDrawingToolStripMenuItem.Click += new System.EventHandler(this.deleteDrawingToolStripMenuItem_Click);
            // 
            // drawingPropertiesToolStripMenuItem
            // 
            this.drawingPropertiesToolStripMenuItem.Name = "drawingPropertiesToolStripMenuItem";
            this.drawingPropertiesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.drawingPropertiesToolStripMenuItem.Text = "Properties...";
            this.drawingPropertiesToolStripMenuItem.Click += new System.EventHandler(this.drawingPropertiesToolStripMenuItem_Click);
        }

        private System.Windows.Forms.ToolStripMenuItem drawingSetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem drawingLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingRemoveLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDrawingToolStripMenuItem;

        #endregion
    }
}
