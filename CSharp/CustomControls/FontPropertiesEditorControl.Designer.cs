
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontPropertiesEditorControl));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(3, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 25;
            resources.ApplyResources(this.colorLabel, "colorLabel");
            // 
            // strikethroughCheckBox
            // 
            this.strikethroughCheckBox.AutoSize = true;
            this.strikethroughCheckBox.Location = new System.Drawing.Point(3, 26);
            this.strikethroughCheckBox.Name = "strikethroughCheckBox";
            this.strikethroughCheckBox.Size = new System.Drawing.Size(89, 17);
            this.strikethroughCheckBox.TabIndex = 23;
            resources.ApplyResources(this.strikethroughCheckBox, "strikethroughCheckBox");
            this.strikethroughCheckBox.UseVisualStyleBackColor = true;
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(3, 3);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 22;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(108, 0);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.fontSizeLabel.TabIndex = 21;
            resources.ApplyResources(this.fontSizeLabel, "fontSizeLabel");
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Location = new System.Drawing.Point(3, 0);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(55, 13);
            this.fontStyleLabel.TabIndex = 20;
            resources.ApplyResources(this.fontStyleLabel, "fontStyleLabel");
            // 
            // fontColorPanelControl
            // 
            this.fontColorPanelControl.CanEditAlphaChannel = false;
            this.fontColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.fontColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.fontColorPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontColorPanelControl.Location = new System.Drawing.Point(3, 16);
            this.fontColorPanelControl.Name = "fontColorPanelControl";
            this.fontColorPanelControl.Size = new System.Drawing.Size(90, 22);
            this.fontColorPanelControl.TabIndex = 24;
            // 
            // fontSizesListBox
            // 
            this.fontSizesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fontSizesListBox.Location = new System.Drawing.Point(108, 42);
            this.fontSizesListBox.Name = "fontSizesListBox";
            this.fontSizesListBox.Size = new System.Drawing.Size(100, 120);
            this.fontSizesListBox.TabIndex = 19;
            this.fontSizesListBox.SelectedIndexChanged += new System.EventHandler(this.fontSizesListBox_SelectedIndexChanged);
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSizeTextBox.Location = new System.Drawing.Point(108, 16);
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.fontSizeTextBox.TabIndex = 18;
            // 
            // fontStylesListBox
            // 
            this.fontStylesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontStylesListBox.FormattingEnabled = true;
            this.fontStylesListBox.Location = new System.Drawing.Point(3, 42);
            this.fontStylesListBox.Name = "fontStylesListBox";
            this.fontStylesListBox.Size = new System.Drawing.Size(99, 120);
            this.fontStylesListBox.TabIndex = 17;
            this.fontStylesListBox.SelectedIndexChanged += new System.EventHandler(this.fontStylesListBox_SelectedIndexChanged);
            // 
            // fontStyleTextBox
            // 
            this.fontStyleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontStyleTextBox.Location = new System.Drawing.Point(3, 16);
            this.fontStyleTextBox.Name = "fontStyleTextBox";
            this.fontStyleTextBox.Size = new System.Drawing.Size(99, 20);
            this.fontStyleTextBox.TabIndex = 16;
            // 
            // fontNamesListBox
            // 
            this.fontNamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontNamesListBox.FormattingEnabled = true;
            this.fontNamesListBox.Location = new System.Drawing.Point(3, 42);
            this.fontNamesListBox.Name = "fontNamesListBox";
            this.fontNamesListBox.Size = new System.Drawing.Size(205, 120);
            this.fontNamesListBox.TabIndex = 15;
            this.fontNamesListBox.SelectedIndexChanged += new System.EventHandler(this.fontNamesListBox_SelectedIndexChanged);
            // 
            // fontNameTextBox
            // 
            this.fontNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.fontNameTextBox.TabIndex = 14;
            // 
            // fontLabel
            // 
            this.fontLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(3, 0);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(31, 13);
            this.fontLabel.TabIndex = 13;
            resources.ApplyResources(this.fontLabel, "fontLabel");
            // 
            // normalFontButton
            // 
            this.normalFontButton.AutoSize = true;
            this.normalFontButton.Location = new System.Drawing.Point(3, 44);
            this.normalFontButton.Name = "normalFontButton";
            this.normalFontButton.Size = new System.Drawing.Size(88, 23);
            this.normalFontButton.TabIndex = 26;
            resources.ApplyResources(this.normalFontButton, "normalFontButton");
            this.normalFontButton.UseVisualStyleBackColor = true;
            this.normalFontButton.Click += new System.EventHandler(this.normalFontButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fontLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fontNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fontNamesListBox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(211, 165);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fontStyleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fontSizeLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fontStyleTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fontSizeTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fontStylesListBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.fontSizesListBox, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(220, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 165);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.underlineCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.strikethroughCheckBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 174);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(211, 72);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.colorLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.fontColorPanelControl, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.normalFontButton, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(220, 174);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(211, 72);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(434, 249);
            this.tableLayoutPanel5.TabIndex = 31;
            // 
            // FontPropertiesEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "FontPropertiesEditorControl";
            this.Size = new System.Drawing.Size(440, 252);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}