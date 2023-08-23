
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
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyButton,
            this.pasteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(187, 53);
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
            this.copyButton.Text = "Copy";
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.copyButton.ToolTipText = "Copy (Ctrl+C)";
            this.copyButton.ButtonClick += new System.EventHandler(this.copyButton_ButtonClick);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Cut;
            this.cutMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(95, 24);
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.ToolTipText = "Cut (Ctrl+X)";
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
            this.pasteButton.Text = "Paste";
            this.pasteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pasteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pasteButton.ToolTipText = "Paste (Ctrl+V) (keep Ctrl to paste to focused cells)";
            this.pasteButton.ButtonClick += new System.EventHandler(this.pasteButton_ButtonClick);
            this.pasteButton.DropDownOpened += new System.EventHandler(this.pasteButton_DropDownOpened);
            // 
            // pasteContentsToolStripMenuItem
            // 
            this.pasteContentsToolStripMenuItem.Name = "pasteContentsToolStripMenuItem";
            this.pasteContentsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteContentsToolStripMenuItem.Text = "Paste Contents";
            this.pasteContentsToolStripMenuItem.Click += new System.EventHandler(this.pasteContentsToolStripMenuItem_Click);
            // 
            // pasteValuesAndStyleToolStripMenuItem
            // 
            this.pasteValuesAndStyleToolStripMenuItem.Name = "pasteValuesAndStyleToolStripMenuItem";
            this.pasteValuesAndStyleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteValuesAndStyleToolStripMenuItem.Text = "Paste Values and Styles";
            this.pasteValuesAndStyleToolStripMenuItem.Click += new System.EventHandler(this.pasteValuesAndStyleToolStripMenuItem_Click);
            // 
            // pasteValuesToolStripMenuItem
            // 
            this.pasteValuesToolStripMenuItem.Name = "pasteValuesToolStripMenuItem";
            this.pasteValuesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteValuesToolStripMenuItem.Text = "Paste Values";
            this.pasteValuesToolStripMenuItem.Click += new System.EventHandler(this.pasteValuesToolStripMenuItem_Click);
            // 
            // pasteFormulasToolStripMenuItem
            // 
            this.pasteFormulasToolStripMenuItem.Name = "pasteFormulasToolStripMenuItem";
            this.pasteFormulasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteFormulasToolStripMenuItem.Text = "Paste Formulas";
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
            this.pasteSpecialToolStripMenuItem.Text = "Paste Special...";
            this.pasteSpecialToolStripMenuItem.Click += new System.EventHandler(this.pasteSpecialToolStripMenuItem_Click);
            // 
            // CopyPastePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "CopyPastePanel";
            this.Size = new System.Drawing.Size(187, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

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