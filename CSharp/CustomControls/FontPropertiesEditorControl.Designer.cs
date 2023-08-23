
namespace SpreadsheetEditorDemo.CustomControls
{
    partial class FontPropertiesEditorControl
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.strikethroughCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.fontSizesListBox = new System.Windows.Forms.ListBox();
            this.fontSizeTextBox = new System.Windows.Forms.TextBox();
            this.fontStylesListBox = new System.Windows.Forms.ListBox();
            this.fontStyleTextBox = new System.Windows.Forms.TextBox();
            this.fontNamesListBox = new System.Windows.Forms.ListBox();
            this.fontNameTextBox = new System.Windows.Forms.TextBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.normalFontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(245, 177);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 25;
            this.colorLabel.Text = "Color:";
            // 
            // strikethroughCheckBox
            // 
            this.strikethroughCheckBox.AutoSize = true;
            this.strikethroughCheckBox.Location = new System.Drawing.Point(5, 200);
            this.strikethroughCheckBox.Name = "strikethroughCheckBox";
            this.strikethroughCheckBox.Size = new System.Drawing.Size(89, 17);
            this.strikethroughCheckBox.TabIndex = 23;
            this.strikethroughCheckBox.Text = "Strikethrough";
            this.strikethroughCheckBox.UseVisualStyleBackColor = true;
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(5, 177);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 22;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(342, 6);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.fontSizeLabel.TabIndex = 21;
            this.fontSizeLabel.Text = "Size:";
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Location = new System.Drawing.Point(244, 6);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(55, 13);
            this.fontStyleLabel.TabIndex = 20;
            this.fontStyleLabel.Text = "Font style:";
            // 
            // fontColorPanelControl
            // 
            this.fontColorPanelControl.CanEditAlphaChannel = false;
            this.fontColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.fontColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.fontColorPanelControl.Location = new System.Drawing.Point(247, 194);
            this.fontColorPanelControl.Name = "fontColorPanelControl";
            this.fontColorPanelControl.Size = new System.Drawing.Size(90, 22);
            this.fontColorPanelControl.TabIndex = 24;
            // 
            // fontSizesListBox
            // 
            this.fontSizesListBox.FormattingEnabled = true;
            this.fontSizesListBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizesListBox.Location = new System.Drawing.Point(344, 44);
            this.fontSizesListBox.Name = "fontSizesListBox";
            this.fontSizesListBox.Size = new System.Drawing.Size(90, 121);
            this.fontSizesListBox.TabIndex = 19;
            this.fontSizesListBox.SelectedIndexChanged += new System.EventHandler(this.fontSizesListBox_SelectedIndexChanged);
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.Location = new System.Drawing.Point(344, 22);
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.Size = new System.Drawing.Size(90, 20);
            this.fontSizeTextBox.TabIndex = 18;
            // 
            // fontStylesListBox
            // 
            this.fontStylesListBox.FormattingEnabled = true;
            this.fontStylesListBox.Location = new System.Drawing.Point(247, 44);
            this.fontStylesListBox.Name = "fontStylesListBox";
            this.fontStylesListBox.Size = new System.Drawing.Size(90, 121);
            this.fontStylesListBox.TabIndex = 17;
            this.fontStylesListBox.SelectedIndexChanged += new System.EventHandler(this.fontStylesListBox_SelectedIndexChanged);
            // 
            // fontStyleTextBox
            // 
            this.fontStyleTextBox.Location = new System.Drawing.Point(247, 22);
            this.fontStyleTextBox.Name = "fontStyleTextBox";
            this.fontStyleTextBox.Size = new System.Drawing.Size(90, 20);
            this.fontStyleTextBox.TabIndex = 16;
            // 
            // fontNamesListBox
            // 
            this.fontNamesListBox.FormattingEnabled = true;
            this.fontNamesListBox.Location = new System.Drawing.Point(5, 44);
            this.fontNamesListBox.Name = "fontNamesListBox";
            this.fontNamesListBox.Size = new System.Drawing.Size(234, 121);
            this.fontNamesListBox.TabIndex = 15;
            this.fontNamesListBox.SelectedIndexChanged += new System.EventHandler(this.fontNamesListBox_SelectedIndexChanged);
            // 
            // fontNameTextBox
            // 
            this.fontNameTextBox.Location = new System.Drawing.Point(5, 22);
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.fontNameTextBox.TabIndex = 14;
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(2, 6);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(31, 13);
            this.fontLabel.TabIndex = 13;
            this.fontLabel.Text = "Font:";
            // 
            // normalFontButton
            // 
            this.normalFontButton.Location = new System.Drawing.Point(343, 193);
            this.normalFontButton.Name = "normalFontButton";
            this.normalFontButton.Size = new System.Drawing.Size(90, 23);
            this.normalFontButton.TabIndex = 26;
            this.normalFontButton.Text = "Normal Font";
            this.normalFontButton.UseVisualStyleBackColor = true;
            this.normalFontButton.Click += new System.EventHandler(this.normalFontButton_Click);
            // 
            // FontPropertiesEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.normalFontButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.strikethroughCheckBox);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.fontSizeLabel);
            this.Controls.Add(this.fontStyleLabel);
            this.Controls.Add(this.fontColorPanelControl);
            this.Controls.Add(this.fontSizesListBox);
            this.Controls.Add(this.fontSizeTextBox);
            this.Controls.Add(this.fontStylesListBox);
            this.Controls.Add(this.fontStyleTextBox);
            this.Controls.Add(this.fontNamesListBox);
            this.Controls.Add(this.fontNameTextBox);
            this.Controls.Add(this.fontLabel);
            this.Name = "FontPropertiesEditorControl";
            this.Size = new System.Drawing.Size(440, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.CheckBox strikethroughCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Label fontStyleLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl fontColorPanelControl;
        private System.Windows.Forms.ListBox fontSizesListBox;
        private System.Windows.Forms.TextBox fontSizeTextBox;
        private System.Windows.Forms.ListBox fontStylesListBox;
        private System.Windows.Forms.TextBox fontStyleTextBox;
        private System.Windows.Forms.ListBox fontNamesListBox;
        private System.Windows.Forms.TextBox fontNameTextBox;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Button normalFontButton;
    }
}