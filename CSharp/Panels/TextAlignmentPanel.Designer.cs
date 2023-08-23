
namespace SpreadsheetEditorDemo
{
    partial class TextAlignmentPanel
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.mergeButton = new System.Windows.Forms.ToolStripButton();
            this.mergeAndCenterButton = new System.Windows.Forms.ToolStripButton();
            this.mergeAcrossButton = new System.Windows.Forms.ToolStripButton();
            this.unmergeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.decreaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.increaseIndentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.alignmentPropertiesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.verticalAlignTopButton = new System.Windows.Forms.ToolStripButton();
            this.verticalAlignMiddleButton = new System.Windows.Forms.ToolStripButton();
            this.verticalAlignmentBottomButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.horizontalAlignmentLeftButton = new System.Windows.Forms.ToolStripButton();
            this.horizontalAlignmentCenterButton = new System.Windows.Forms.ToolStripButton();
            this.horizontalAlignmentRightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textWrapButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeButton,
            this.mergeAndCenterButton,
            this.mergeAcrossButton,
            this.unmergeButton,
            this.toolStripSeparator3,
            this.decreaseIndentButton,
            this.increaseIndentButton,
            this.toolStripSeparator4,
            this.alignmentPropertiesButton});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(206, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // mergeButton
            // 
            this.mergeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mergeButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Merge;
            this.mergeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(23, 22);
            this.mergeButton.Text = "Merge";
            this.mergeButton.ToolTipText = "Merge Cells";
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // mergeAndCenterButton
            // 
            this.mergeAndCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mergeAndCenterButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAndCenter;
            this.mergeAndCenterButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeAndCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mergeAndCenterButton.Name = "mergeAndCenterButton";
            this.mergeAndCenterButton.Size = new System.Drawing.Size(23, 22);
            this.mergeAndCenterButton.Text = "Merge And Center";
            this.mergeAndCenterButton.Click += new System.EventHandler(this.mergeAndCenterButton_Click);
            // 
            // mergeAcrossButton
            // 
            this.mergeAcrossButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mergeAcrossButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAcross;
            this.mergeAcrossButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeAcrossButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mergeAcrossButton.Name = "mergeAcrossButton";
            this.mergeAcrossButton.Size = new System.Drawing.Size(23, 22);
            this.mergeAcrossButton.Text = "Merge Across";
            this.mergeAcrossButton.Click += new System.EventHandler(this.mergeAcrossButton_Click);
            // 
            // unmergeButton
            // 
            this.unmergeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unmergeButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Unmerge;
            this.unmergeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unmergeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unmergeButton.Name = "unmergeButton";
            this.unmergeButton.Size = new System.Drawing.Size(23, 22);
            this.unmergeButton.Text = "Unmerge Cells";
            this.unmergeButton.Click += new System.EventHandler(this.unmergeButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // decreaseIndentButton
            // 
            this.decreaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextIndent_Dec;
            this.decreaseIndentButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseIndentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseIndentButton.Name = "decreaseIndentButton";
            this.decreaseIndentButton.Size = new System.Drawing.Size(23, 22);
            this.decreaseIndentButton.Text = "Decrease Indent";
            this.decreaseIndentButton.Click += new System.EventHandler(this.decreaseIndentButton_Click);
            // 
            // increaseIndentButton
            // 
            this.increaseIndentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseIndentButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextIndent_Inc;
            this.increaseIndentButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseIndentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseIndentButton.Name = "increaseIndentButton";
            this.increaseIndentButton.Size = new System.Drawing.Size(23, 22);
            this.increaseIndentButton.Text = "Increase Indent";
            this.increaseIndentButton.Click += new System.EventHandler(this.increaseIndentButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // alignmentPropertiesButton
            // 
            this.alignmentPropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignmentPropertiesButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextAlignProperties;
            this.alignmentPropertiesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alignmentPropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignmentPropertiesButton.Name = "alignmentPropertiesButton";
            this.alignmentPropertiesButton.Size = new System.Drawing.Size(23, 22);
            this.alignmentPropertiesButton.Text = "Text Alignment Properties...";
            this.alignmentPropertiesButton.Click += new System.EventHandler(this.alignmentPropertiesButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalAlignTopButton,
            this.verticalAlignMiddleButton,
            this.verticalAlignmentBottomButton,
            this.toolStripSeparator1,
            this.horizontalAlignmentLeftButton,
            this.horizontalAlignmentCenterButton,
            this.horizontalAlignmentRightButton,
            this.toolStripSeparator2,
            this.textWrapButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(206, 25);
            this.toolStrip1.TabIndex = 4;
            // 
            // verticalAlignTopButton
            // 
            this.verticalAlignTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verticalAlignTopButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextVerticalAlign_Top;
            this.verticalAlignTopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verticalAlignTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verticalAlignTopButton.Name = "verticalAlignTopButton";
            this.verticalAlignTopButton.Size = new System.Drawing.Size(23, 22);
            this.verticalAlignTopButton.Text = "Top Align";
            this.verticalAlignTopButton.ToolTipText = "Align text to the top";
            this.verticalAlignTopButton.Click += new System.EventHandler(this.verticalAlignTopButton_Click);
            // 
            // verticalAlignMiddleButton
            // 
            this.verticalAlignMiddleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verticalAlignMiddleButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextVerticalAlign_Midle;
            this.verticalAlignMiddleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verticalAlignMiddleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verticalAlignMiddleButton.Name = "verticalAlignMiddleButton";
            this.verticalAlignMiddleButton.Size = new System.Drawing.Size(23, 22);
            this.verticalAlignMiddleButton.Text = "Middle Align";
            this.verticalAlignMiddleButton.ToolTipText = "Align text to the middle";
            this.verticalAlignMiddleButton.Click += new System.EventHandler(this.verticalAlignMiddleButton_Click);
            // 
            // verticalAlignmentBottomButton
            // 
            this.verticalAlignmentBottomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verticalAlignmentBottomButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextVerticalAlign_Bottom;
            this.verticalAlignmentBottomButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verticalAlignmentBottomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verticalAlignmentBottomButton.Name = "verticalAlignmentBottomButton";
            this.verticalAlignmentBottomButton.Size = new System.Drawing.Size(23, 22);
            this.verticalAlignmentBottomButton.Text = "Bottom Align";
            this.verticalAlignmentBottomButton.ToolTipText = "Align text to the bottom";
            this.verticalAlignmentBottomButton.Click += new System.EventHandler(this.verticalAlignmentBottomButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // horizontalAlignmentLeftButton
            // 
            this.horizontalAlignmentLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.horizontalAlignmentLeftButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextHorizontalAlign_Left;
            this.horizontalAlignmentLeftButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.horizontalAlignmentLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.horizontalAlignmentLeftButton.Name = "horizontalAlignmentLeftButton";
            this.horizontalAlignmentLeftButton.Size = new System.Drawing.Size(23, 22);
            this.horizontalAlignmentLeftButton.Text = "Align text to the left";
            this.horizontalAlignmentLeftButton.Click += new System.EventHandler(this.horizontalAlignmentLeftButton_Click);
            // 
            // horizontalAlignmentCenterButton
            // 
            this.horizontalAlignmentCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.horizontalAlignmentCenterButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextHorizontalAlign_Center;
            this.horizontalAlignmentCenterButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.horizontalAlignmentCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.horizontalAlignmentCenterButton.Name = "horizontalAlignmentCenterButton";
            this.horizontalAlignmentCenterButton.Size = new System.Drawing.Size(23, 22);
            this.horizontalAlignmentCenterButton.Text = "Align Center";
            this.horizontalAlignmentCenterButton.ToolTipText = "Align text to the center";
            this.horizontalAlignmentCenterButton.Click += new System.EventHandler(this.horizontalAlignmentCenterButton_Click);
            // 
            // horizontalAlignmentRightButton
            // 
            this.horizontalAlignmentRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.horizontalAlignmentRightButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextHorizontalAlign_Right;
            this.horizontalAlignmentRightButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.horizontalAlignmentRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.horizontalAlignmentRightButton.Name = "horizontalAlignmentRightButton";
            this.horizontalAlignmentRightButton.Size = new System.Drawing.Size(23, 22);
            this.horizontalAlignmentRightButton.Text = "Align Right";
            this.horizontalAlignmentRightButton.ToolTipText = "Align text to the right";
            this.horizontalAlignmentRightButton.Click += new System.EventHandler(this.horizontalAlignmentRightButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // textWrapButton
            // 
            this.textWrapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textWrapButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextWrap;
            this.textWrapButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.textWrapButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textWrapButton.Name = "textWrapButton";
            this.textWrapButton.Size = new System.Drawing.Size(23, 22);
            this.textWrapButton.Text = "Wrap Text";
            this.textWrapButton.ToolTipText = "Wrap long text to multiple lines";
            this.textWrapButton.Click += new System.EventHandler(this.textWrapButton_Click);
            // 
            // TextAlignmentPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TextAlignmentPanel";
            this.Size = new System.Drawing.Size(208, 52);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mergeAndCenterButton;
        private System.Windows.Forms.ToolStripButton mergeAcrossButton;
        private System.Windows.Forms.ToolStripButton unmergeButton;
        private System.Windows.Forms.ToolStripButton mergeButton;
        private System.Windows.Forms.ToolStripButton decreaseIndentButton;
        private System.Windows.Forms.ToolStripButton increaseIndentButton;
        private System.Windows.Forms.ToolStripButton alignmentPropertiesButton;
        private System.Windows.Forms.ToolStripButton verticalAlignTopButton;
        private System.Windows.Forms.ToolStripButton verticalAlignMiddleButton;
        private System.Windows.Forms.ToolStripButton verticalAlignmentBottomButton;
        private System.Windows.Forms.ToolStripButton horizontalAlignmentLeftButton;
        private System.Windows.Forms.ToolStripButton horizontalAlignmentCenterButton;
        private System.Windows.Forms.ToolStripButton horizontalAlignmentRightButton;
        private System.Windows.Forms.ToolStripButton textWrapButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}