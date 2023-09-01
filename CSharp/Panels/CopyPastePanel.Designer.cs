
namespace SpreadsheetEditorDemo
{
    partial class CopyPastePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyPastePanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.copyButton = new System.Windows.Forms.ToolStripSplitButton();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteButton = new System.Windows.Forms.ToolStripSplitButton();
            this.pasteContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteValuesAndStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteFormulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyButton,
            this.pasteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(122, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = false;
            this.copyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuItem});
            this.copyButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Copy;
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copyButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(60, 50);
            resources.ApplyResources(this.copyButton, "copyButton");
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.copyButton.ButtonClick += new System.EventHandler(this.copyButton_ButtonClick);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Cut;
            this.cutMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(182, 24);
            resources.ApplyResources(this.cutMenuItem, "cutMenuItem");
            
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.AutoSize = false;
            this.pasteButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteContentsToolStripMenuItem,
            this.pasteValuesAndStyleToolStripMenuItem,
            this.pasteValuesToolStripMenuItem,
            this.pasteFormulasToolStripMenuItem,
            this.toolStripSeparator1,
            this.pasteSpecialToolStripMenuItem});
            this.pasteButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Paste;
            this.pasteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pasteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(60, 50);
            resources.ApplyResources(this.pasteButton, "pasteButton");
            this.pasteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pasteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.pasteButton.ButtonClick += new System.EventHandler(this.pasteButton_ButtonClick);
            this.pasteButton.DropDownOpened += new System.EventHandler(this.pasteButton_DropDownOpened);
            // 
            // pasteContentsToolStripMenuItem
            // 
            this.pasteContentsToolStripMenuItem.Name = "pasteContentsToolStripMenuItem";
            this.pasteContentsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            resources.ApplyResources(this.pasteContentsToolStripMenuItem, "pasteContentsToolStripMenuItem");
            this.pasteContentsToolStripMenuItem.Click += new System.EventHandler(this.pasteContentsToolStripMenuItem_Click);
            // 
            // pasteValuesAndStyleToolStripMenuItem
            // 
            this.pasteValuesAndStyleToolStripMenuItem.Name = "pasteValuesAndStyleToolStripMenuItem";
            this.pasteValuesAndStyleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            resources.ApplyResources(this.pasteValuesAndStyleToolStripMenuItem, "pasteValuesAndStyleToolStripMenuItem");
            this.pasteValuesAndStyleToolStripMenuItem.Click += new System.EventHandler(this.pasteValuesAndStyleToolStripMenuItem_Click);
            // 
            // pasteValuesToolStripMenuItem
            // 
            this.pasteValuesToolStripMenuItem.Name = "pasteValuesToolStripMenuItem";
            this.pasteValuesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            resources.ApplyResources(this.pasteValuesToolStripMenuItem, "pasteValuesToolStripMenuItem");
            this.pasteValuesToolStripMenuItem.Click += new System.EventHandler(this.pasteValuesToolStripMenuItem_Click);
            // 
            // pasteFormulasToolStripMenuItem
            // 
            this.pasteFormulasToolStripMenuItem.Name = "pasteFormulasToolStripMenuItem";
            this.pasteFormulasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            resources.ApplyResources(this.pasteFormulasToolStripMenuItem, "pasteFormulasToolStripMenuItem");
            this.pasteFormulasToolStripMenuItem.Click += new System.EventHandler(this.pasteFormulasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // pasteSpecialToolStripMenuItem
            // 
            this.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem";
            this.pasteSpecialToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            resources.ApplyResources(this.pasteSpecialToolStripMenuItem, "pasteSpecialToolStripMenuItem");
            this.pasteSpecialToolStripMenuItem.Click += new System.EventHandler(this.pasteSpecialToolStripMenuItem_Click);
            // 
            // CopyPastePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.toolStrip1);
            this.Name = "CopyPastePanel";
            this.Size = new System.Drawing.Size(122, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton copyButton;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripSplitButton pasteButton;
        private System.Windows.Forms.ToolStripMenuItem pasteContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteValuesAndStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteFormulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pasteSpecialToolStripMenuItem;
    }
}