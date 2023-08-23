
namespace SpreadsheetEditorDemo
{
    partial class NumberFormatPanel
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
            this.numberFormatComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.currencyButton = new System.Windows.Forms.ToolStripSplitButton();
            this.englishUnitedStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUnitedKingdomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseSimplifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishIndiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.increaseDecimalButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseDecimalButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.percentStyleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numberFormatPropertiesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberFormatComboBox});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(195, 25);
            this.toolStrip1.TabIndex = 4;
            // 
            // numberFormatComboBox
            // 
            this.numberFormatComboBox.AutoSize = false;
            this.numberFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberFormatComboBox.Name = "numberFormatComboBox";
            this.numberFormatComboBox.Size = new System.Drawing.Size(137, 23);
            this.numberFormatComboBox.ToolTipText = "Number Format";
            this.numberFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.numberFormatComboBox_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyButton,
            this.toolStripSeparator3,
            this.increaseDecimalButton,
            this.decreaseDecimalButton,
            this.toolStripSeparator1,
            this.percentStyleButton,
            this.toolStripSeparator2,
            this.numberFormatPropertiesButton});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(195, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // currencyButton
            // 
            this.currencyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.currencyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishUnitedStatesToolStripMenuItem,
            this.englishUnitedKingdomToolStripMenuItem,
            this.euroToolStripMenuItem,
            this.chineseSimplifiedToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.englishIndiaToolStripMenuItem});
            this.currencyButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NumberFormat_Accounting;
            this.currencyButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currencyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currencyButton.Name = "currencyButton";
            this.currencyButton.Size = new System.Drawing.Size(34, 22);
            this.currencyButton.Text = "Currency";
            this.currencyButton.ButtonClick += new System.EventHandler(this.englishUnitedStatesToolStripMenuItem_Click);
            // 
            // englishUnitedStatesToolStripMenuItem
            // 
            this.englishUnitedStatesToolStripMenuItem.Name = "englishUnitedStatesToolStripMenuItem";
            this.englishUnitedStatesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.englishUnitedStatesToolStripMenuItem.Text = "$ English (United States)";
            this.englishUnitedStatesToolStripMenuItem.Click += new System.EventHandler(this.englishUnitedStatesToolStripMenuItem_Click);
            // 
            // englishUnitedKingdomToolStripMenuItem
            // 
            this.englishUnitedKingdomToolStripMenuItem.Name = "englishUnitedKingdomToolStripMenuItem";
            this.englishUnitedKingdomToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.englishUnitedKingdomToolStripMenuItem.Text = "£ English (United Kingdom)";
            this.englishUnitedKingdomToolStripMenuItem.Click += new System.EventHandler(this.englishUnitedKingdomToolStripMenuItem_Click);
            // 
            // euroToolStripMenuItem
            // 
            this.euroToolStripMenuItem.Name = "euroToolStripMenuItem";
            this.euroToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.euroToolStripMenuItem.Text = "€ Euro (€ 123)";
            this.euroToolStripMenuItem.Click += new System.EventHandler(this.euroToolStripMenuItem_Click);
            // 
            // chineseSimplifiedToolStripMenuItem
            // 
            this.chineseSimplifiedToolStripMenuItem.Name = "chineseSimplifiedToolStripMenuItem";
            this.chineseSimplifiedToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.chineseSimplifiedToolStripMenuItem.Text = "¥ Chinese (Simplified, Mainland China)";
            this.chineseSimplifiedToolStripMenuItem.Click += new System.EventHandler(this.chineseSimplifiedToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.russianToolStripMenuItem.Text = "₽ Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // englishIndiaToolStripMenuItem
            // 
            this.englishIndiaToolStripMenuItem.Name = "englishIndiaToolStripMenuItem";
            this.englishIndiaToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.englishIndiaToolStripMenuItem.Text = "₹ English (India)";
            this.englishIndiaToolStripMenuItem.Click += new System.EventHandler(this.englishIndiaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // increaseDecimalButton
            // 
            this.increaseDecimalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseDecimalButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NumberFormat_IncDecimal;
            this.increaseDecimalButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseDecimalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseDecimalButton.Name = "increaseDecimalButton";
            this.increaseDecimalButton.Size = new System.Drawing.Size(23, 22);
            this.increaseDecimalButton.Text = "Increase Decimal";
            this.increaseDecimalButton.Click += new System.EventHandler(this.increaseDecimalButton_Click);
            // 
            // decreaseDecimalButton
            // 
            this.decreaseDecimalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseDecimalButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NumberFormat_DecDecimal;
            this.decreaseDecimalButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseDecimalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseDecimalButton.Name = "decreaseDecimalButton";
            this.decreaseDecimalButton.Size = new System.Drawing.Size(23, 22);
            this.decreaseDecimalButton.Text = "Decrease Decimal";
            this.decreaseDecimalButton.Click += new System.EventHandler(this.decreaseDecimalButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // percentStyleButton
            // 
            this.percentStyleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.percentStyleButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NumberFormat_Percent;
            this.percentStyleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.percentStyleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.percentStyleButton.Name = "percentStyleButton";
            this.percentStyleButton.Size = new System.Drawing.Size(23, 22);
            this.percentStyleButton.Text = "Percent Style";
            this.percentStyleButton.Click += new System.EventHandler(this.percentStyleButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // numberFormatPropertiesButton
            // 
            this.numberFormatPropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.numberFormatPropertiesButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NumberFormatProperties;
            this.numberFormatPropertiesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.numberFormatPropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.numberFormatPropertiesButton.Name = "numberFormatPropertiesButton";
            this.numberFormatPropertiesButton.Size = new System.Drawing.Size(23, 22);
            this.numberFormatPropertiesButton.Text = "Number Format Properties...";
            this.numberFormatPropertiesButton.Click += new System.EventHandler(this.numberFormatPropertiesButton_Click);
            // 
            // NumberFormatPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NumberFormatPanel";
            this.Size = new System.Drawing.Size(197, 52);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox numberFormatComboBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton increaseDecimalButton;
        private System.Windows.Forms.ToolStripButton decreaseDecimalButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton percentStyleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton numberFormatPropertiesButton;
        private System.Windows.Forms.ToolStripSplitButton currencyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem englishUnitedStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseSimplifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUnitedKingdomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishIndiaToolStripMenuItem;
    }
}