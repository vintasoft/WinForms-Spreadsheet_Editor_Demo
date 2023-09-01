
namespace SpreadsheetEditorDemo
{
    partial class FontPropertiesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontPropertiesPanel));
            this.fontPropertiesToolStrip = new System.Windows.Forms.ToolStrip();
            this.fontNameToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.incFontSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.decFontSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textPropertiesToolStrip = new System.Windows.Forms.ToolStrip();
            this.boldFontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicFontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.strikeoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillColorButton = new System.Windows.Forms.ToolStripSplitButton();
            this.noFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorButton = new System.Windows.Forms.ToolStripSplitButton();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bordersButton = new System.Windows.Forms.ToolStripSplitButton();
            this.bottomBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.noBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outsideBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickOutsideBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bottomDoubleBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickBottomBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAndBottomBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAndThickBottomBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAndDoubleBottomBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyStyleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontPropertiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontPropertiesToolStrip.SuspendLayout();
            this.textPropertiesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontPropertiesToolStrip
            // 
            this.fontPropertiesToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontPropertiesToolStrip.AutoSize = false;
            this.fontPropertiesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fontPropertiesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fontPropertiesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontNameToolStripComboBox,
            this.fontSizeToolStripComboBox,
            this.incFontSizeToolStripButton,
            this.decFontSizeToolStripButton});
            this.fontPropertiesToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.fontPropertiesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fontPropertiesToolStrip.Name = "fontPropertiesToolStrip";
            this.fontPropertiesToolStrip.Size = new System.Drawing.Size(298, 25);
            this.fontPropertiesToolStrip.TabIndex = 4;
            // 
            // fontNameToolStripComboBox
            // 
            this.fontNameToolStripComboBox.AutoSize = false;
            this.fontNameToolStripComboBox.Name = "fontNameToolStripComboBox";
            this.fontNameToolStripComboBox.Size = new System.Drawing.Size(161, 23);
            this.fontNameToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontNameToolStripComboBox_SelectedIndexChanged);
            this.fontNameToolStripComboBox.Leave += new System.EventHandler(this.fontNameToolStripComboBox_Leave);
            this.fontNameToolStripComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fontNameToolStripComboBox_KeyDown);
            this.fontNameToolStripComboBox.TextChanged += new System.EventHandler(this.fontNameToolStripComboBox_TextChanged);
            // 
            // fontSizeToolStripComboBox
            // 
            this.fontSizeToolStripComboBox.AutoSize = false;
            this.fontSizeToolStripComboBox.Items.AddRange(new object[] {
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
            this.fontSizeToolStripComboBox.Name = "fontSizeToolStripComboBox";
            this.fontSizeToolStripComboBox.Size = new System.Drawing.Size(50, 23);
            this.fontSizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeToolStripComboBox_SelectedIndexChanged);
            this.fontSizeToolStripComboBox.Leave += new System.EventHandler(this.fontSizeToolStripComboBox_Leave);
            this.fontSizeToolStripComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fontSizeToolStripComboBox_KeyDown);
            this.fontSizeToolStripComboBox.TextChanged += new System.EventHandler(this.fontSizeToolStripComboBox_TextChanged);
            // 
            // incFontSizeToolStripButton
            // 
            this.incFontSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incFontSizeToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.IncreaseTextSize;
            this.incFontSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.incFontSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incFontSizeToolStripButton.Name = "incFontSizeToolStripButton";
            this.incFontSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.incFontSizeToolStripButton, "incFontSizeToolStripButton");
            this.incFontSizeToolStripButton.Click += new System.EventHandler(this.incFontSizeToolStripButton_Click);
            // 
            // decFontSizeToolStripButton
            // 
            this.decFontSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decFontSizeToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DecreaseTextSize;
            this.decFontSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decFontSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decFontSizeToolStripButton.Name = "decFontSizeToolStripButton";
            this.decFontSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.decFontSizeToolStripButton, "decFontSizeToolStripButton");
            this.decFontSizeToolStripButton.Click += new System.EventHandler(this.decFontSizeToolStripButton_Click);
            // 
            // textPropertiesToolStrip
            // 
            this.textPropertiesToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPropertiesToolStrip.AutoSize = false;
            this.textPropertiesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.textPropertiesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.textPropertiesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldFontToolStripButton,
            this.italicFontToolStripButton,
            this.underlineToolStripButton,
            this.strikeoutToolStripButton,
            this.toolStripSeparator1,
            this.fillColorButton,
            this.fontColorButton,
            this.toolStripSeparator2,
            this.bordersButton,
            this.toolStripSeparator3,
            this.copyStyleToolStripButton,
            this.toolStripSeparator4,
            this.fontPropertiesToolStripButton});
            this.textPropertiesToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.textPropertiesToolStrip.Location = new System.Drawing.Point(0, 26);
            this.textPropertiesToolStrip.Name = "textPropertiesToolStrip";
            this.textPropertiesToolStrip.Size = new System.Drawing.Size(298, 25);
            this.textPropertiesToolStrip.TabIndex = 5;
            this.textPropertiesToolStrip.Text = "toolStrip2";
            // 
            // boldFontToolStripButton
            // 
            this.boldFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldFontToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.BoldText;
            this.boldFontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.boldFontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldFontToolStripButton.Name = "boldFontToolStripButton";
            this.boldFontToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.boldFontToolStripButton, "boldFontToolStripButton");
            this.boldFontToolStripButton.Click += new System.EventHandler(this.boldFontToolStripButton_Click);
            // 
            // italicFontToolStripButton
            // 
            this.italicFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicFontToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ItalicText;
            this.italicFontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.italicFontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicFontToolStripButton.Name = "italicFontToolStripButton";
            this.italicFontToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.italicFontToolStripButton, "italicFontToolStripButton");
            this.italicFontToolStripButton.Click += new System.EventHandler(this.italicFontToolStripButton_Click);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.UnderlinedText;
            this.underlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineToolStripButton.Text = "Underline";
            this.underlineToolStripButton.Click += new System.EventHandler(this.underlineToolStripButton_Click);
            // 
            // strikeoutToolStripButton
            // 
            this.strikeoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeoutToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.StrikeoutText;
            this.strikeoutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.strikeoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeoutToolStripButton.Name = "strikeoutToolStripButton";
            this.strikeoutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.strikeoutToolStripButton.Text = "Strikeout";
            this.strikeoutToolStripButton.Click += new System.EventHandler(this.strikeoutToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // fillColorButton
            // 
            this.fillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noFillToolStripMenuItem,
            this.selectFillColorToolStripMenuItem});
            this.fillColorButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillColor;
            this.fillColorButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(34, 22);
            resources.ApplyResources(this.fillColorButton, "fillColorButton");
            this.fillColorButton.ButtonClick += new System.EventHandler(this.fillColorButton_ButtonClick);
            // 
            // noFillToolStripMenuItem
            // 
            this.noFillToolStripMenuItem.Name = "noFillToolStripMenuItem";
            this.noFillToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            resources.ApplyResources(this.noFillToolStripMenuItem, "noFillToolStripMenuItem");
            this.noFillToolStripMenuItem.Click += new System.EventHandler(this.noFillToolStripMenuItem_Click);
            // 
            // selectFillColorToolStripMenuItem
            // 
            this.selectFillColorToolStripMenuItem.Name = "selectFillColorToolStripMenuItem";
            this.selectFillColorToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            resources.ApplyResources(this.selectFillColorToolStripMenuItem, "selectFillColorToolStripMenuItem");
            this.selectFillColorToolStripMenuItem.Click += new System.EventHandler(this.selectFillColorToolStripMenuItem_Click);
            // 
            // fontColorButton
            // 
            this.fontColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.fontColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColorToolStripMenuItem});
            this.fontColorButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.FontColor;
            this.fontColorButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fontColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(34, 22);
            resources.ApplyResources(this.fontColorButton, "fontColorButton");
            this.fontColorButton.ButtonClick += new System.EventHandler(this.fontColorButton_ButtonClick);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            resources.ApplyResources(this.selectColorToolStripMenuItem, "selectColorToolStripMenuItem");
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectFontColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // bordersButton
            // 
            this.bordersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bordersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomBorderToolStripMenuItem,
            this.topBorderToolStripMenuItem,
            this.leftBorderToolStripMenuItem,
            this.rightBorderToolStripMenuItem,
            this.toolStripSeparator5,
            this.noBorderToolStripMenuItem,
            this.allBordersToolStripMenuItem,
            this.outsideBordersToolStripMenuItem,
            this.thickOutsideBordersToolStripMenuItem,
            this.toolStripSeparator6,
            this.bottomDoubleBorderToolStripMenuItem,
            this.thickBottomBorderToolStripMenuItem,
            this.topAndBottomBorderToolStripMenuItem,
            this.topAndThickBottomBorderToolStripMenuItem,
            this.topAndDoubleBottomBorderToolStripMenuItem,
            this.toolStripSeparator7,
            this.borderColorToolStripMenuItem,
            this.moreBordersToolStripMenuItem});
            this.bordersButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_ThinAll;
            this.bordersButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bordersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bordersButton.Name = "bordersButton";
            this.bordersButton.Size = new System.Drawing.Size(34, 22);
            resources.ApplyResources(this.bordersButton, "bordersButton");
            this.bordersButton.ButtonClick += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // bottomBorderToolStripMenuItem
            // 
            this.bottomBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_Bottom;
            this.bottomBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bottomBorderToolStripMenuItem.Name = "bottomBorderToolStripMenuItem";
            this.bottomBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.bottomBorderToolStripMenuItem, "bottomBorderToolStripMenuItem");
            this.bottomBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // topBorderToolStripMenuItem
            // 
            this.topBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_Top;
            this.topBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topBorderToolStripMenuItem.Name = "topBorderToolStripMenuItem";
            this.topBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.topBorderToolStripMenuItem, "topBorderToolStripMenuItem");
            this.topBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // leftBorderToolStripMenuItem
            // 
            this.leftBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_Left;
            this.leftBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leftBorderToolStripMenuItem.Name = "leftBorderToolStripMenuItem";
            this.leftBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.leftBorderToolStripMenuItem, "leftBorderToolStripMenuItem");
            this.leftBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // rightBorderToolStripMenuItem
            // 
            this.rightBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_Right;
            this.rightBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rightBorderToolStripMenuItem.Name = "rightBorderToolStripMenuItem";
            this.rightBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.rightBorderToolStripMenuItem, "rightBorderToolStripMenuItem");
            this.rightBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(237, 6);
            // 
            // noBorderToolStripMenuItem
            // 
            this.noBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_No;
            this.noBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem";
            this.noBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.noBorderToolStripMenuItem, "noBorderToolStripMenuItem");
            this.noBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // allBordersToolStripMenuItem
            // 
            this.allBordersToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_ThinAll;
            this.allBordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allBordersToolStripMenuItem.Name = "allBordersToolStripMenuItem";
            this.allBordersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.allBordersToolStripMenuItem, "allBordersToolStripMenuItem");
            this.allBordersToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // outsideBordersToolStripMenuItem
            // 
            this.outsideBordersToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_Outside;
            this.outsideBordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.outsideBordersToolStripMenuItem.Name = "outsideBordersToolStripMenuItem";
            this.outsideBordersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.outsideBordersToolStripMenuItem, "outsideBordersToolStripMenuItem");
            this.outsideBordersToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // thickOutsideBordersToolStripMenuItem
            // 
            this.thickOutsideBordersToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_ThickOutside;
            this.thickOutsideBordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thickOutsideBordersToolStripMenuItem.Name = "thickOutsideBordersToolStripMenuItem";
            this.thickOutsideBordersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.thickOutsideBordersToolStripMenuItem, "thickOutsideBordersToolStripMenuItem");
            this.thickOutsideBordersToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(237, 6);
            // 
            // bottomDoubleBorderToolStripMenuItem
            // 
            this.bottomDoubleBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_BottomDouble;
            this.bottomDoubleBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bottomDoubleBorderToolStripMenuItem.Name = "bottomDoubleBorderToolStripMenuItem";
            this.bottomDoubleBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.bottomDoubleBorderToolStripMenuItem, "bottomDoubleBorderToolStripMenuItem");
            this.bottomDoubleBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // thickBottomBorderToolStripMenuItem
            // 
            this.thickBottomBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_BottomThick;
            this.thickBottomBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thickBottomBorderToolStripMenuItem.Name = "thickBottomBorderToolStripMenuItem";
            this.thickBottomBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.thickBottomBorderToolStripMenuItem, "thickBottomBorderToolStripMenuItem");
            this.thickBottomBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // topAndBottomBorderToolStripMenuItem
            // 
            this.topAndBottomBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_TopBottom;
            this.topAndBottomBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topAndBottomBorderToolStripMenuItem.Name = "topAndBottomBorderToolStripMenuItem";
            this.topAndBottomBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.topAndBottomBorderToolStripMenuItem, "topAndBottomBorderToolStripMenuItem");
            this.topAndBottomBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // topAndThickBottomBorderToolStripMenuItem
            // 
            this.topAndThickBottomBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_TopBottomThick;
            this.topAndThickBottomBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topAndThickBottomBorderToolStripMenuItem.Name = "topAndThickBottomBorderToolStripMenuItem";
            this.topAndThickBottomBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.topAndThickBottomBorderToolStripMenuItem, "topAndThickBottomBorderToolStripMenuItem");
            this.topAndThickBottomBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // topAndDoubleBottomBorderToolStripMenuItem
            // 
            this.topAndDoubleBottomBorderToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_TopBottomDouble;
            this.topAndDoubleBottomBorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topAndDoubleBottomBorderToolStripMenuItem.Name = "topAndDoubleBottomBorderToolStripMenuItem";
            this.topAndDoubleBottomBorderToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.topAndDoubleBottomBorderToolStripMenuItem, "topAndDoubleBottomBorderToolStripMenuItem");
            this.topAndDoubleBottomBorderToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripDropDownButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(237, 6);
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.borderColorToolStripMenuItem, "borderColorToolStripMenuItem");
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.borderColorToolStripMenuItem_Click);
            // 
            // moreBordersToolStripMenuItem
            // 
            this.moreBordersToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Borders_ThinAll;
            this.moreBordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moreBordersToolStripMenuItem.Name = "moreBordersToolStripMenuItem";
            this.moreBordersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            resources.ApplyResources(this.moreBordersToolStripMenuItem, "moreBordersToolStripMenuItem");
            this.moreBordersToolStripMenuItem.Click += new System.EventHandler(this.moreBordersToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // copyStyleToolStripButton
            // 
            this.copyStyleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyStyleToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.StylePainter;
            this.copyStyleToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyStyleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyStyleToolStripButton.Name = "copyStyleToolStripButton";
            this.copyStyleToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.copyStyleToolStripButton, "copyStyleToolStripButton");
            this.copyStyleToolStripButton.Click += new System.EventHandler(this.copyStyleToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // fontPropertiesToolStripButton
            // 
            this.fontPropertiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontPropertiesToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.TextProperties;
            this.fontPropertiesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fontPropertiesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontPropertiesToolStripButton.Name = "fontPropertiesToolStripButton";
            this.fontPropertiesToolStripButton.Size = new System.Drawing.Size(23, 22);
            resources.ApplyResources(this.fontPropertiesToolStripButton, "fontPropertiesToolStripButton");
            this.fontPropertiesToolStripButton.Click += new System.EventHandler(this.fontPropertiesToolStripButton_Click);
            // 
            // FontPropertiesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textPropertiesToolStrip);
            this.Controls.Add(this.fontPropertiesToolStrip);
            this.Name = "FontPropertiesPanel";
            this.Size = new System.Drawing.Size(300, 52);
            this.VisibleChanged += new System.EventHandler(this.FontPropertiesPanel_VisibleChanged);
            this.fontPropertiesToolStrip.ResumeLayout(false);
            this.fontPropertiesToolStrip.PerformLayout();
            this.textPropertiesToolStrip.ResumeLayout(false);
            this.textPropertiesToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip fontPropertiesToolStrip;
        private System.Windows.Forms.ToolStripComboBox fontNameToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox fontSizeToolStripComboBox;
        private System.Windows.Forms.ToolStripButton incFontSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton decFontSizeToolStripButton;
        private System.Windows.Forms.ToolStrip textPropertiesToolStrip;
        private System.Windows.Forms.ToolStripButton boldFontToolStripButton;
        private System.Windows.Forms.ToolStripButton italicFontToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.ToolStripButton strikeoutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton bordersButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton fontPropertiesToolStripButton;
        private System.Windows.Forms.ToolStripButton copyStyleToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem allBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickOutsideBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem moreBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noBorderToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSplitButton fillColorButton;
        private System.Windows.Forms.ToolStripMenuItem noFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton fontColorButton;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outsideBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomDoubleBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickBottomBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topAndBottomBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topAndThickBottomBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topAndDoubleBottomBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}