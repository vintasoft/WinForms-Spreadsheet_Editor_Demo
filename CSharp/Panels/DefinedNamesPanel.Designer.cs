
namespace SpreadsheetEditorDemo
{
    partial class DefinedNamesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinedNamesPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertDefinedNameButton = new System.Windows.Forms.ToolStripButton();
            this.addDefineNameButton = new System.Windows.Forms.ToolStripButton();
            this.definedNamesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDefinedNameButton,
            this.addDefineNameButton,
            this.definedNamesButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(272, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertDefinedNameButton
            // 
            this.insertDefinedNameButton.AutoSize = false;
            this.insertDefinedNameButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DefinedNamesUseInFormula;
            this.insertDefinedNameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertDefinedNameButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertDefinedNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertDefinedNameButton.Name = "insertDefinedNameButton";
            this.insertDefinedNameButton.Size = new System.Drawing.Size(90, 50);
            resources.ApplyResources(this.insertDefinedNameButton, "insertDefinedNameButton");
            this.insertDefinedNameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insertDefinedNameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.insertDefinedNameButton.Click += new System.EventHandler(this.insertDefinedNameInFormulaButton_Click);
            // 
            // addDefineNameButton
            // 
            this.addDefineNameButton.AutoSize = false;
            this.addDefineNameButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DefinedNamesAdd;
            this.addDefineNameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDefineNameButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addDefineNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDefineNameButton.Name = "addDefineNameButton";
            this.addDefineNameButton.Size = new System.Drawing.Size(90, 50);
            resources.ApplyResources(this.addDefineNameButton, "addDefineNameButton");
            this.addDefineNameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addDefineNameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.addDefineNameButton.Click += new System.EventHandler(this.addDefineNameButton_Click);
            // 
            // definedNamesButton
            // 
            this.definedNamesButton.AutoSize = false;
            this.definedNamesButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DefinedNamesManager;
            this.definedNamesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.definedNamesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.definedNamesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.definedNamesButton.Name = "definedNamesButton";
            this.definedNamesButton.Size = new System.Drawing.Size(90, 50);
            resources.ApplyResources(this.definedNamesButton, "definedNamesButton");
            this.definedNamesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.definedNamesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.definedNamesButton.Click += new System.EventHandler(this.definedNamesButton_Click);
            // 
            // DefinedNamesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.toolStrip1);
            this.Name = "DefinedNamesPanel";
            this.Size = new System.Drawing.Size(272, 52);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton definedNamesButton;
        private System.Windows.Forms.ToolStripButton addDefineNameButton;
        private System.Windows.Forms.ToolStripButton insertDefinedNameButton;
    }
}