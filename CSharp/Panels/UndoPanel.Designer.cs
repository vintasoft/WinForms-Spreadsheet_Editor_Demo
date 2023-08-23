
namespace SpreadsheetEditorDemo
{
    partial class UndoPanel
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
            this.undoButton = new System.Windows.Forms.ToolStripSplitButton();
            this.redoButton = new System.Windows.Forms.ToolStripSplitButton();
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
            this.undoButton,
            this.redoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(187, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // undoButton
            // 
            this.undoButton.AutoSize = false;
            this.undoButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Undo;
            this.undoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.undoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(60, 50);
            this.undoButton.Text = "Undo";
            this.undoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.undoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.undoButton.ToolTipText = "Undo";
            this.undoButton.ButtonClick += new System.EventHandler(this.undoButton_ButtonClick);
            this.undoButton.DropDownOpening += new System.EventHandler(this.undoButton_DropDownOpening);
            // 
            // redoButton
            // 
            this.redoButton.AutoSize = false;
            this.redoButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Redo;
            this.redoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.redoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(60, 50);
            this.redoButton.Text = "Redo";
            this.redoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.redoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.redoButton.ToolTipText = "Redo";
            this.redoButton.ButtonClick += new System.EventHandler(this.redoButton_ButtonClick);
            this.redoButton.DropDownOpening += new System.EventHandler(this.redoButton_DropDownOpening);
            // 
            // UndoPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "UndoPanel";
            this.Size = new System.Drawing.Size(187, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton undoButton;
        private System.Windows.Forms.ToolStripSplitButton redoButton;
    }
}