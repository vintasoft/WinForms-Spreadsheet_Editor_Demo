
namespace SpreadsheetEditorDemo
{
    partial class CommentsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.prevButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.showHideButton = new System.Windows.Forms.ToolStripButton();
            this.showAllButton = new System.Windows.Forms.ToolStripButton();
            this.hideAllButton = new System.Windows.Forms.ToolStripButton();
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
            this.newButton,
            this.editButton,
            this.deleteButton,
            this.prevButton,
            this.nextButton,
            this.showHideButton,
            this.showAllButton,
            this.hideAllButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(526, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.AutoSize = false;
            this.newButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_New;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.newButton, "newButton");
            this.newButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = false;
            this.editButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_Edit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_Delete;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.AutoSize = false;
            this.prevButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_Prev;
            this.prevButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prevButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.prevButton, "prevButton");
            this.prevButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prevButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = false;
            this.nextButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_Next;
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // showHideButton
            // 
            this.showHideButton.AutoSize = false;
            this.showHideButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_ShowHide;
            this.showHideButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showHideButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showHideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showHideButton.Name = "showHideButton";
            this.showHideButton.Size = new System.Drawing.Size(70, 50);
            resources.ApplyResources(this.showHideButton, "showHideButton");
            this.showHideButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showHideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.showHideButton.Click += new System.EventHandler(this.showHideButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.AutoSize = false;
            this.showAllButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_ShowAll;
            this.showAllButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showAllButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(70, 50);
            resources.ApplyResources(this.showAllButton, "showAllButton");
            this.showAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // hideAllButton
            // 
            this.hideAllButton.AutoSize = false;
            this.hideAllButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Comment_HideAll;
            this.hideAllButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hideAllButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hideAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hideAllButton.Name = "hideAllButton";
            this.hideAllButton.Size = new System.Drawing.Size(70, 50);
            resources.ApplyResources(this.hideAllButton, "hideAllButton");
            this.hideAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hideAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.hideAllButton.Click += new System.EventHandler(this.hideAllButton_Click);
            // 
            // CommentsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "CommentsPanel";
            this.Size = new System.Drawing.Size(526, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripButton hideAllButton;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton prevButton;
        private System.Windows.Forms.ToolStripButton nextButton;
        private System.Windows.Forms.ToolStripButton showHideButton;
        private System.Windows.Forms.ToolStripButton showAllButton;
    }
}