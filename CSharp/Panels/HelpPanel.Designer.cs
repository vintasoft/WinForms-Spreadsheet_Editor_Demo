
namespace SpreadsheetEditorDemo
{
    partial class HelpPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertDefinedNameButton = new System.Windows.Forms.ToolStripButton();
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
            this.insertDefinedNameButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(302, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertDefinedNameButton
            // 
            this.insertDefinedNameButton.AutoSize = false;
            this.insertDefinedNameButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Help;
            this.insertDefinedNameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertDefinedNameButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertDefinedNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertDefinedNameButton.Name = "insertDefinedNameButton";
            this.insertDefinedNameButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.insertDefinedNameButton, "insertDefinedNameButton");
            this.insertDefinedNameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insertDefinedNameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.insertDefinedNameButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // HelpPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "HelpPanel";
            this.Size = new System.Drawing.Size(302, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton insertDefinedNameButton;
    }
}