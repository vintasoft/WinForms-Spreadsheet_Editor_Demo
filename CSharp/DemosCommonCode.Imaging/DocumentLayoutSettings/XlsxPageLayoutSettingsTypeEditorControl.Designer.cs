namespace DemosCommonCode.Imaging
{
    partial class XlsxPageLayoutSettingsTypeEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XlsxPageLayoutSettingsTypeEditorControl));
            this.useWorksheetWidthAsPageWidthCheckBox = new System.Windows.Forms.CheckBox();
            this.useWorksheetHeightAsPageHeightCheckBox = new System.Windows.Forms.CheckBox();
            this.usePrintAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.usePageMarginCheckBox = new System.Windows.Forms.CheckBox();
            this.usePageScaleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // useWorksheetWidthAsPageWidthCheckBox
            // 
            this.useWorksheetWidthAsPageWidthCheckBox.AutoSize = true;
            this.useWorksheetWidthAsPageWidthCheckBox.Location = new System.Drawing.Point(0, 0);
            this.useWorksheetWidthAsPageWidthCheckBox.Name = "useWorksheetWidthAsPageWidthCheckBox";
            this.useWorksheetWidthAsPageWidthCheckBox.Size = new System.Drawing.Size(211, 19);
            this.useWorksheetWidthAsPageWidthCheckBox.TabIndex = 0;
            resources.ApplyResources(this.useWorksheetWidthAsPageWidthCheckBox, "useWorksheetWidthAsPageWidthCheckBox");
            this.useWorksheetWidthAsPageWidthCheckBox.UseVisualStyleBackColor = true;
            this.useWorksheetWidthAsPageWidthCheckBox.CheckedChanged += new System.EventHandler(this.useWorksheetWidthAsPageWidthCheckBox_CheckedChanged);
            // 
            // useWorksheetHeightAsPageHeightCheckBox
            // 
            this.useWorksheetHeightAsPageHeightCheckBox.AutoSize = true;
            this.useWorksheetHeightAsPageHeightCheckBox.Location = new System.Drawing.Point(0, 23);
            this.useWorksheetHeightAsPageHeightCheckBox.Name = "useWorksheetHeightAsPageHeightCheckBox";
            this.useWorksheetHeightAsPageHeightCheckBox.Size = new System.Drawing.Size(219, 19);
            this.useWorksheetHeightAsPageHeightCheckBox.TabIndex = 1;
            resources.ApplyResources(this.useWorksheetHeightAsPageHeightCheckBox, "useWorksheetHeightAsPageHeightCheckBox");
            this.useWorksheetHeightAsPageHeightCheckBox.UseVisualStyleBackColor = true;
            this.useWorksheetHeightAsPageHeightCheckBox.CheckedChanged += new System.EventHandler(this.useWorksheetHeightAsPageHeightCheckBox_CheckedChanged);
            // 
            // usePrintAreaCheckBox
            // 
            this.usePrintAreaCheckBox.AutoSize = true;
            this.usePrintAreaCheckBox.Location = new System.Drawing.Point(0, 46);
            this.usePrintAreaCheckBox.Name = "usePrintAreaCheckBox";
            this.usePrintAreaCheckBox.Size = new System.Drawing.Size(98, 19);
            this.usePrintAreaCheckBox.TabIndex = 2;
            resources.ApplyResources(this.usePrintAreaCheckBox, "usePrintAreaCheckBox");
            this.usePrintAreaCheckBox.UseVisualStyleBackColor = true;
            // 
            // usePageMarginCheckBox
            // 
            this.usePageMarginCheckBox.AutoSize = true;
            this.usePageMarginCheckBox.Location = new System.Drawing.Point(0, 69);
            this.usePageMarginCheckBox.Name = "usePageMarginCheckBox";
            this.usePageMarginCheckBox.Size = new System.Drawing.Size(115, 19);
            this.usePageMarginCheckBox.TabIndex = 3;
            resources.ApplyResources(this.usePageMarginCheckBox, "usePageMarginCheckBox");
            this.usePageMarginCheckBox.UseVisualStyleBackColor = true;
            // 
            // usePageScaleCheckBox
            // 
            this.usePageScaleCheckBox.AutoSize = true;
            this.usePageScaleCheckBox.Location = new System.Drawing.Point(0, 92);
            this.usePageScaleCheckBox.Name = "usePageScaleCheckBox";
            this.usePageScaleCheckBox.Size = new System.Drawing.Size(103, 19);
            this.usePageScaleCheckBox.TabIndex = 4;
            resources.ApplyResources(this.usePageScaleCheckBox, "usePageScaleCheckBox");
            this.usePageScaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // XlsxPageLayoutSettingsTypeEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.usePageScaleCheckBox);
            this.Controls.Add(this.usePageMarginCheckBox);
            this.Controls.Add(this.usePrintAreaCheckBox);
            this.Controls.Add(this.useWorksheetHeightAsPageHeightCheckBox);
            this.Controls.Add(this.useWorksheetWidthAsPageWidthCheckBox);
            this.MinimumSize = new System.Drawing.Size(202, 107);
            this.Name = "XlsxPageLayoutSettingsTypeEditorControl";
            this.Size = new System.Drawing.Size(220, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useWorksheetWidthAsPageWidthCheckBox;
        private System.Windows.Forms.CheckBox useWorksheetHeightAsPageHeightCheckBox;
        private System.Windows.Forms.CheckBox usePrintAreaCheckBox;
        private System.Windows.Forms.CheckBox usePageMarginCheckBox;
        private System.Windows.Forms.CheckBox usePageScaleCheckBox;
    }
}