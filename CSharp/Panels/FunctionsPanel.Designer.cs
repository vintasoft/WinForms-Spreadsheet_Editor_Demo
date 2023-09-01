
namespace SpreadsheetEditorDemo
{
    partial class FunctionsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionsPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertFunctionButton = new System.Windows.Forms.ToolStripButton();
            this.showFomulasButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertFunctionButton,
            this.showFomulasButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(182, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertFunctionButton
            // 
            this.insertFunctionButton.AutoSize = false;
            this.insertFunctionButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertFunction;
            this.insertFunctionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertFunctionButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertFunctionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertFunctionButton.Name = "insertFunctionButton";
            this.insertFunctionButton.Size = new System.Drawing.Size(90, 50);
            resources.ApplyResources(this.insertFunctionButton, "insertFunctionButton");
            this.insertFunctionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insertFunctionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.insertFunctionButton.Click += new System.EventHandler(this.insertFunctionButton_Click);
            // 
            // showFomulasButton
            // 
            this.showFomulasButton.AutoSize = false;
            this.showFomulasButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ShowFormulas;
            this.showFomulasButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showFomulasButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showFomulasButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showFomulasButton.Name = "showFomulasButton";
            this.showFomulasButton.Size = new System.Drawing.Size(90, 50);
            resources.ApplyResources(this.showFomulasButton, "showFomulasButton");
            this.showFomulasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showFomulasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.showFomulasButton.Click += new System.EventHandler(this.showFomulasButton_Click);
            // 
            // FunctionsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.toolStrip1);
            this.Name = "FunctionsPanel";
            this.Size = new System.Drawing.Size(182, 52);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton insertFunctionButton;
        private System.Windows.Forms.ToolStripButton showFomulasButton;
    }
}