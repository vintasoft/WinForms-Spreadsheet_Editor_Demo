
namespace SpreadsheetEditorDemo
{
    partial class EditCommentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCommentForm));
            this.authorLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.commentTabControl = new System.Windows.Forms.TabControl();
            this.commonTabPage = new System.Windows.Forms.TabPage();
            this.colorLabel = new System.Windows.Forms.Label();
            this.commentColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.showAuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.textAlignTabPage = new System.Windows.Forms.TabPage();
            this.textVerticalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.textVerticalAlignmentLabel = new System.Windows.Forms.Label();
            this.textHorizontalAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.textHorizontalAlignmentlabel = new System.Windows.Forms.Label();
            this.fontPropertiesTabPage = new System.Windows.Forms.TabPage();
            this.fontPropertiesEditorControl = new SpreadsheetEditorDemo.CustomControls.FontPropertiesEditorControl();
            this.locationAndSizeTabPage = new System.Windows.Forms.TabPage();
            this.sheetDrawingLocationEditorControl1 = new SpreadsheetEditorDemo.SheetDrawingLocationEditorControl();
            this.fontColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.commentTabControl.SuspendLayout();
            this.commonTabPage.SuspendLayout();
            this.textAlignTabPage.SuspendLayout();
            this.fontPropertiesTabPage.SuspendLayout();
            this.locationAndSizeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(7, 3);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 0;
            resources.ApplyResources(this.authorLabel, "authorLabel");
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(7, 120);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(54, 13);
            this.commentLabel.TabIndex = 2;
            resources.ApplyResources(this.commentLabel, "commentLabel");
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(10, 19);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(427, 20);
            this.authorTextBox.TabIndex = 4;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Location = new System.Drawing.Point(10, 136);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 6);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(427, 129);
            this.commentTextBox.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(355, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 9;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(255, 311);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // commentTabControl
            // 
            this.commentTabControl.Controls.Add(this.commonTabPage);
            this.commentTabControl.Controls.Add(this.textAlignTabPage);
            this.commentTabControl.Controls.Add(this.fontPropertiesTabPage);
            this.commentTabControl.Controls.Add(this.locationAndSizeTabPage);
            this.commentTabControl.Location = new System.Drawing.Point(1, 3);
            this.commentTabControl.Name = "commentTabControl";
            this.commentTabControl.SelectedIndex = 0;
            this.commentTabControl.Size = new System.Drawing.Size(451, 300);
            this.commentTabControl.TabIndex = 10;
            // 
            // commonTabPage
            // 
            this.commonTabPage.Controls.Add(this.colorLabel);
            this.commonTabPage.Controls.Add(this.commentColorPanelControl);
            this.commonTabPage.Controls.Add(this.showAuthorCheckBox);
            this.commonTabPage.Controls.Add(this.authorLabel);
            this.commonTabPage.Controls.Add(this.authorTextBox);
            this.commonTabPage.Controls.Add(this.commentLabel);
            this.commonTabPage.Controls.Add(this.commentTextBox);
            this.commonTabPage.Location = new System.Drawing.Point(4, 22);
            this.commonTabPage.Name = "commonTabPage";
            this.commonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commonTabPage.Size = new System.Drawing.Size(443, 274);
            this.commonTabPage.TabIndex = 0;
            resources.ApplyResources(this.commonTabPage, "commonTabPage");
            this.commonTabPage.UseVisualStyleBackColor = true;
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(7, 72);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 14;
            resources.ApplyResources(this.colorLabel, "colorLabel");
            // 
            // commentColorPanelControl
            // 
            this.commentColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.commentColorPanelControl.CanEditAlphaChannel = false;
            this.commentColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.commentColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.commentColorPanelControl.Location = new System.Drawing.Point(10, 88);
            this.commentColorPanelControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.commentColorPanelControl.Name = "commentColorPanelControl";
            this.commentColorPanelControl.Size = new System.Drawing.Size(116, 22);
            this.commentColorPanelControl.TabIndex = 13;
            // 
            // showAuthorCheckBox
            // 
            this.showAuthorCheckBox.AutoSize = true;
            this.showAuthorCheckBox.Location = new System.Drawing.Point(10, 45);
            this.showAuthorCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.showAuthorCheckBox.Name = "showAuthorCheckBox";
            this.showAuthorCheckBox.Size = new System.Drawing.Size(87, 17);
            this.showAuthorCheckBox.TabIndex = 7;
            resources.ApplyResources(this.showAuthorCheckBox, "showAuthorCheckBox");
            this.showAuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // textAlignTabPage
            // 
            this.textAlignTabPage.Controls.Add(this.textVerticalAlignmentComboBox);
            this.textAlignTabPage.Controls.Add(this.textVerticalAlignmentLabel);
            this.textAlignTabPage.Controls.Add(this.textHorizontalAlignmentComboBox);
            this.textAlignTabPage.Controls.Add(this.textHorizontalAlignmentlabel);
            this.textAlignTabPage.Location = new System.Drawing.Point(4, 22);
            this.textAlignTabPage.Name = "textAlignTabPage";
            this.textAlignTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textAlignTabPage.Size = new System.Drawing.Size(192, 74);
            this.textAlignTabPage.TabIndex = 1;
            resources.ApplyResources(this.textAlignTabPage, "textAlignTabPage");
            this.textAlignTabPage.UseVisualStyleBackColor = true;
            // 
            // textVerticalAlignmentComboBox
            // 
            this.textVerticalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textVerticalAlignmentComboBox.FormattingEnabled = true;
            this.textVerticalAlignmentComboBox.Location = new System.Drawing.Point(10, 67);
            this.textVerticalAlignmentComboBox.Name = "textVerticalAlignmentComboBox";
            this.textVerticalAlignmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.textVerticalAlignmentComboBox.TabIndex = 7;
            // 
            // textVerticalAlignmentLabel
            // 
            this.textVerticalAlignmentLabel.AutoSize = true;
            this.textVerticalAlignmentLabel.Location = new System.Drawing.Point(7, 51);
            this.textVerticalAlignmentLabel.Name = "textVerticalAlignmentLabel";
            this.textVerticalAlignmentLabel.Size = new System.Drawing.Size(116, 13);
            this.textVerticalAlignmentLabel.TabIndex = 6;
            resources.ApplyResources(this.textVerticalAlignmentLabel, "textVerticalAlignmentLabel");
            // 
            // textHorizontalAlignmentComboBox
            // 
            this.textHorizontalAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textHorizontalAlignmentComboBox.FormattingEnabled = true;
            this.textHorizontalAlignmentComboBox.Location = new System.Drawing.Point(10, 25);
            this.textHorizontalAlignmentComboBox.Name = "textHorizontalAlignmentComboBox";
            this.textHorizontalAlignmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.textHorizontalAlignmentComboBox.TabIndex = 5;
            // 
            // textHorizontalAlignmentlabel
            // 
            this.textHorizontalAlignmentlabel.AutoSize = true;
            this.textHorizontalAlignmentlabel.Location = new System.Drawing.Point(7, 9);
            this.textHorizontalAlignmentlabel.Name = "textHorizontalAlignmentlabel";
            this.textHorizontalAlignmentlabel.Size = new System.Drawing.Size(127, 13);
            this.textHorizontalAlignmentlabel.TabIndex = 4;
            resources.ApplyResources(this.textHorizontalAlignmentlabel, "textHorizontalAlignmentlabel");
            // 
            // fontPropertiesTabPage
            // 
            this.fontPropertiesTabPage.Controls.Add(this.fontPropertiesEditorControl);
            this.fontPropertiesTabPage.Location = new System.Drawing.Point(4, 22);
            this.fontPropertiesTabPage.Name = "fontPropertiesTabPage";
            this.fontPropertiesTabPage.Size = new System.Drawing.Size(443, 274);
            this.fontPropertiesTabPage.TabIndex = 2;
            resources.ApplyResources(this.fontPropertiesTabPage, "fontPropertiesTabPage");
            this.fontPropertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // fontPropertiesEditorControl
            // 
            this.fontPropertiesEditorControl.Culture = null;
            this.fontPropertiesEditorControl.FontProperties = null;
            this.fontPropertiesEditorControl.Location = new System.Drawing.Point(3, 3);
            this.fontPropertiesEditorControl.Name = "fontPropertiesEditorControl";
            this.fontPropertiesEditorControl.NormalFontProperties = null;
            this.fontPropertiesEditorControl.Size = new System.Drawing.Size(440, 268);
            this.fontPropertiesEditorControl.TabIndex = 0;
            // 
            // locationAndSizeTabPage
            // 
            this.locationAndSizeTabPage.Controls.Add(this.sheetDrawingLocationEditorControl1);
            this.locationAndSizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.locationAndSizeTabPage.Name = "locationAndSizeTabPage";
            this.locationAndSizeTabPage.Size = new System.Drawing.Size(192, 74);
            this.locationAndSizeTabPage.TabIndex = 3;
            resources.ApplyResources(this.locationAndSizeTabPage, "locationAndSizeTabPage");
            this.locationAndSizeTabPage.UseVisualStyleBackColor = true;
            // 
            // sheetDrawingLocationEditorControl1
            // 
            this.sheetDrawingLocationEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetDrawingLocationEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.sheetDrawingLocationEditorControl1.MinimumSize = new System.Drawing.Size(240, 200);
            this.sheetDrawingLocationEditorControl1.Name = "sheetDrawingLocationEditorControl1";
            this.sheetDrawingLocationEditorControl1.SheetDrawingLocation = null;
            this.sheetDrawingLocationEditorControl1.Size = new System.Drawing.Size(240, 200);
            this.sheetDrawingLocationEditorControl1.TabIndex = 0;
            this.sheetDrawingLocationEditorControl1.Worksheet = null;
            // 
            // fontColorPanelControl
            // 
            this.fontColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fontColorPanelControl.CanEditAlphaChannel = false;
            this.fontColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.fontColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.fontColorPanelControl.Location = new System.Drawing.Point(66, 72);
            this.fontColorPanelControl.Name = "fontColorPanelControl";
            this.fontColorPanelControl.Size = new System.Drawing.Size(116, 22);
            this.fontColorPanelControl.TabIndex = 13;
            // 
            // EditCommentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(461, 346);
            this.Controls.Add(this.commentTabControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "EditCommentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            resources.ApplyResources(this, "$this");
            this.commentTabControl.ResumeLayout(false);
            this.commonTabPage.ResumeLayout(false);
            this.commonTabPage.PerformLayout();
            this.textAlignTabPage.ResumeLayout(false);
            this.textAlignTabPage.PerformLayout();
            this.fontPropertiesTabPage.ResumeLayout(false);
            this.locationAndSizeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabControl commentTabControl;
        private System.Windows.Forms.TabPage commonTabPage;
        private System.Windows.Forms.TabPage textAlignTabPage;
        private System.Windows.Forms.TabPage fontPropertiesTabPage;
        private CustomControls.FontPropertiesEditorControl fontPropertiesEditorControl;
        private System.Windows.Forms.ComboBox textVerticalAlignmentComboBox;
        private System.Windows.Forms.Label textVerticalAlignmentLabel;
        private System.Windows.Forms.ComboBox textHorizontalAlignmentComboBox;
        private System.Windows.Forms.Label textHorizontalAlignmentlabel;
        private System.Windows.Forms.CheckBox showAuthorCheckBox;
        private System.Windows.Forms.Label colorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl commentColorPanelControl;
        private DemosCommonCode.CustomControls.ColorPanelControl fontColorPanelControl;
        private System.Windows.Forms.TabPage locationAndSizeTabPage;
        private SheetDrawingLocationEditorControl sheetDrawingLocationEditorControl1;
    }
}