
namespace SpreadsheetEditorDemo
{
    partial class FindReplacePanel
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
            this.findButton = new System.Windows.Forms.ToolStripButton();
            this.replaceButton = new System.Windows.Forms.ToolStripButton();
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
            this.findButton,
            this.replaceButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(236, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // findButton
            // 
            this.findButton.AutoSize = false;
            this.findButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.FindContent;
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.findButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.findButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(50, 50);
            this.findButton.Text = "Find";
            this.findButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.findButton.ToolTipText = "Find (Ctrl+F)";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.AutoSize = false;
            this.replaceButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ReplaceContent;
            this.replaceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.replaceButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replaceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(50, 50);
            this.replaceButton.Text = "Replace";
            this.replaceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.replaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.replaceButton.ToolTipText = "Replace (Ctrl+H)";
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // FindReplacePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "FindReplacePanel";
            this.Size = new System.Drawing.Size(236, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton findButton;
        private System.Windows.Forms.ToolStripButton replaceButton;
    }
}