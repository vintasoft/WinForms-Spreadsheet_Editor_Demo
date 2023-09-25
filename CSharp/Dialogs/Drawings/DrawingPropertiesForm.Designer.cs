namespace SpreadsheetEditorDemo
{
    partial class DrawingPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingPropertiesForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chartTabPage = new System.Windows.Forms.TabPage();
            this.dataRangeTextBox = new System.Windows.Forms.TextBox();
            this.dataRangeLabel = new System.Windows.Forms.Label();
            this.categoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.categoriesDataRangeTextBox = new System.Windows.Forms.TextBox();
            this.seriesGroupBox = new System.Windows.Forms.GroupBox();
            this.dataPointGroupBox = new System.Windows.Forms.GroupBox();
            this.markerAppearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.markerAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.ShapeAppearanceEditorControl();
            this.markerSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.markerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.markerSizeLabel = new System.Windows.Forms.Label();
            this.markerTypeLabel = new System.Windows.Forms.Label();
            this.dataPointAppearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.dataPointAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.ShapeAppearanceEditorControl();
            this.dataPointComboBox = new System.Windows.Forms.ComboBox();
            this.nameRangeLabel = new System.Windows.Forms.Label();
            this.nameRangeTextBox = new System.Windows.Forms.TextBox();
            this.valuesRangeLabel = new System.Windows.Forms.Label();
            this.valuesRangeTextBox = new System.Windows.Forms.TextBox();
            this.seriesComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.commonTabPage = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.locationAndSizeTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rotationAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sheetDrawingLocationEditorControl = new SpreadsheetEditorDemo.SheetDrawingLocationEditorControl();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.smoothLineCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.chartTabPage.SuspendLayout();
            this.categoriesGroupBox.SuspendLayout();
            this.seriesGroupBox.SuspendLayout();
            this.dataPointGroupBox.SuspendLayout();
            this.markerAppearanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markerSizeNumericUpDown)).BeginInit();
            this.dataPointAppearanceGroupBox.SuspendLayout();
            this.commonTabPage.SuspendLayout();
            this.locationAndSizeTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationAngleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.chartTabPage);
            this.tabControl1.Controls.Add(this.commonTabPage);
            this.tabControl1.Controls.Add(this.locationAndSizeTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.MinimumSize = new System.Drawing.Size(300, 200);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // chartTabPage
            // 
            this.chartTabPage.Controls.Add(this.dataRangeTextBox);
            this.chartTabPage.Controls.Add(this.dataRangeLabel);
            this.chartTabPage.Controls.Add(this.categoriesGroupBox);
            this.chartTabPage.Controls.Add(this.seriesGroupBox);
            this.chartTabPage.Controls.Add(this.titleTextBox);
            this.chartTabPage.Controls.Add(this.titleLabel);
            this.chartTabPage.Location = new System.Drawing.Point(4, 22);
            this.chartTabPage.Name = "chartTabPage";
            this.chartTabPage.Size = new System.Drawing.Size(430, 424);
            this.chartTabPage.TabIndex = 2;
            this.chartTabPage.Text = "Chart";
            this.chartTabPage.UseVisualStyleBackColor = true;
            // 
            // dataRangeTextBox
            // 
            this.dataRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRangeTextBox.Location = new System.Drawing.Point(150, 36);
            this.dataRangeTextBox.Name = "dataRangeTextBox";
            this.dataRangeTextBox.ReadOnly = true;
            this.dataRangeTextBox.Size = new System.Drawing.Size(273, 20);
            this.dataRangeTextBox.TabIndex = 5;
            // 
            // dataRangeLabel
            // 
            this.dataRangeLabel.AutoSize = true;
            this.dataRangeLabel.Location = new System.Drawing.Point(5, 39);
            this.dataRangeLabel.Name = "dataRangeLabel";
            this.dataRangeLabel.Size = new System.Drawing.Size(92, 13);
            this.dataRangeLabel.TabIndex = 4;
            resources.ApplyResources(this.dataRangeLabel, "dataRangeLabel");
            // 
            // categoriesGroupBox
            // 
            this.categoriesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesGroupBox.Controls.Add(this.categoriesDataRangeTextBox);
            this.categoriesGroupBox.Location = new System.Drawing.Point(8, 371);
            this.categoriesGroupBox.Name = "categoriesGroupBox";
            this.categoriesGroupBox.Size = new System.Drawing.Size(415, 50);
            this.categoriesGroupBox.TabIndex = 3;
            this.categoriesGroupBox.TabStop = false;
            resources.ApplyResources(this.categoriesGroupBox, "categoriesGroupBox");
            // 
            // categoriesDataRangeTextBox
            // 
            this.categoriesDataRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesDataRangeTextBox.Location = new System.Drawing.Point(9, 19);
            this.categoriesDataRangeTextBox.Name = "categoriesDataRangeTextBox";
            this.categoriesDataRangeTextBox.ReadOnly = true;
            this.categoriesDataRangeTextBox.Size = new System.Drawing.Size(400, 20);
            this.categoriesDataRangeTextBox.TabIndex = 0;
            // 
            // seriesGroupBox
            // 
            this.seriesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesGroupBox.Controls.Add(this.smoothLineCheckBox);
            this.seriesGroupBox.Controls.Add(this.dataPointGroupBox);
            this.seriesGroupBox.Controls.Add(this.nameRangeLabel);
            this.seriesGroupBox.Controls.Add(this.nameRangeTextBox);
            this.seriesGroupBox.Controls.Add(this.valuesRangeLabel);
            this.seriesGroupBox.Controls.Add(this.valuesRangeTextBox);
            this.seriesGroupBox.Controls.Add(this.seriesComboBox);
            this.seriesGroupBox.Location = new System.Drawing.Point(8, 72);
            this.seriesGroupBox.Name = "seriesGroupBox";
            this.seriesGroupBox.Size = new System.Drawing.Size(415, 295);
            this.seriesGroupBox.TabIndex = 2;
            this.seriesGroupBox.TabStop = false;
            resources.ApplyResources(this.seriesGroupBox, "seriesGroupBox");
            // 
            // dataPointGroupBox
            // 
            this.dataPointGroupBox.Controls.Add(this.markerAppearanceGroupBox);
            this.dataPointGroupBox.Controls.Add(this.dataPointAppearanceGroupBox);
            this.dataPointGroupBox.Controls.Add(this.dataPointComboBox);
            this.dataPointGroupBox.Location = new System.Drawing.Point(9, 104);
            this.dataPointGroupBox.Name = "dataPointGroupBox";
            this.dataPointGroupBox.Size = new System.Drawing.Size(400, 185);
            this.dataPointGroupBox.TabIndex = 16;
            this.dataPointGroupBox.TabStop = false;
            resources.ApplyResources(this.dataPointGroupBox, "dataPointGroupBox");
            // 
            // markerAppearanceGroupBox
            // 
            this.markerAppearanceGroupBox.Controls.Add(this.markerAppearanceEditor);
            this.markerAppearanceGroupBox.Controls.Add(this.markerSizeNumericUpDown);
            this.markerAppearanceGroupBox.Controls.Add(this.markerTypeComboBox);
            this.markerAppearanceGroupBox.Controls.Add(this.markerSizeLabel);
            this.markerAppearanceGroupBox.Controls.Add(this.markerTypeLabel);
            this.markerAppearanceGroupBox.Location = new System.Drawing.Point(204, 24);
            this.markerAppearanceGroupBox.Name = "markerAppearanceGroupBox";
            this.markerAppearanceGroupBox.Size = new System.Drawing.Size(190, 155);
            this.markerAppearanceGroupBox.TabIndex = 18;
            this.markerAppearanceGroupBox.TabStop = false;
            resources.ApplyResources(this.markerAppearanceGroupBox, "markerAppearanceGroupBox");
            // 
            // markerAppearanceEditor
            // 
            this.markerAppearanceEditor.Location = new System.Drawing.Point(6, 14);
            this.markerAppearanceEditor.Name = "markerAppearanceEditor";
            this.markerAppearanceEditor.ShapeAppearance = null;
            this.markerAppearanceEditor.Size = new System.Drawing.Size(180, 79);
            this.markerAppearanceEditor.TabIndex = 0;
            this.markerAppearanceEditor.ShapeAppearanceChanged += new System.EventHandler(this.markerProperties_Changed);
            // 
            // markerSizeNumericUpDown
            // 
            this.markerSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markerSizeNumericUpDown.Location = new System.Drawing.Point(89, 126);
            this.markerSizeNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.markerSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.markerSizeNumericUpDown.Name = "markerSizeNumericUpDown";
            this.markerSizeNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.markerSizeNumericUpDown.TabIndex = 11;
            this.markerSizeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.markerSizeNumericUpDown.ValueChanged += new System.EventHandler(this.markerProperties_Changed);
            // 
            // markerTypeComboBox
            // 
            this.markerTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markerTypeComboBox.FormattingEnabled = true;
            this.markerTypeComboBox.Location = new System.Drawing.Point(89, 99);
            this.markerTypeComboBox.Name = "markerTypeComboBox";
            this.markerTypeComboBox.Size = new System.Drawing.Size(95, 21);
            this.markerTypeComboBox.TabIndex = 10;
            this.markerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.markerProperties_Changed);
            // 
            // markerSizeLabel
            // 
            this.markerSizeLabel.AutoSize = true;
            this.markerSizeLabel.Location = new System.Drawing.Point(8, 128);
            this.markerSizeLabel.Name = "markerSizeLabel";
            this.markerSizeLabel.Size = new System.Drawing.Size(63, 13);
            this.markerSizeLabel.TabIndex = 9;
            resources.ApplyResources(this.markerSizeLabel, "markerSizeLabel");
            // 
            // markerTypeLabel
            // 
            this.markerTypeLabel.AutoSize = true;
            this.markerTypeLabel.Location = new System.Drawing.Point(8, 103);
            this.markerTypeLabel.Name = "markerTypeLabel";
            this.markerTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.markerTypeLabel.TabIndex = 8;
            resources.ApplyResources(this.markerTypeLabel, "markerTypeLabel");
            // 
            // dataPointAppearanceGroupBox
            // 
            this.dataPointAppearanceGroupBox.Controls.Add(this.dataPointAppearanceEditor);
            this.dataPointAppearanceGroupBox.Location = new System.Drawing.Point(6, 24);
            this.dataPointAppearanceGroupBox.Name = "dataPointAppearanceGroupBox";
            this.dataPointAppearanceGroupBox.Size = new System.Drawing.Size(190, 99);
            this.dataPointAppearanceGroupBox.TabIndex = 17;
            this.dataPointAppearanceGroupBox.TabStop = false;
            resources.ApplyResources(this.dataPointAppearanceGroupBox, "dataPointAppearanceGroupBox");
            // 
            // dataPointAppearanceEditor
            // 
            this.dataPointAppearanceEditor.Location = new System.Drawing.Point(6, 14);
            this.dataPointAppearanceEditor.Name = "dataPointAppearanceEditor";
            this.dataPointAppearanceEditor.ShapeAppearance = null;
            this.dataPointAppearanceEditor.Size = new System.Drawing.Size(180, 85);
            this.dataPointAppearanceEditor.TabIndex = 16;
            this.dataPointAppearanceEditor.ShapeAppearanceChanged += new System.EventHandler(this.dataPointAppearanceEditor_ShapeAppearanceChanged);
            // 
            // dataPointComboBox
            // 
            this.dataPointComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataPointComboBox.FormattingEnabled = true;
            this.dataPointComboBox.Location = new System.Drawing.Point(269, 0);
            this.dataPointComboBox.Name = "dataPointComboBox";
            this.dataPointComboBox.Size = new System.Drawing.Size(124, 21);
            this.dataPointComboBox.TabIndex = 15;
            this.dataPointComboBox.SelectedIndexChanged += new System.EventHandler(this.dataPointComboBox_SelectedIndexChanged);
            // 
            // nameRangeLabel
            // 
            this.nameRangeLabel.AutoSize = true;
            this.nameRangeLabel.Location = new System.Drawing.Point(6, 32);
            this.nameRangeLabel.Name = "nameRangeLabel";
            this.nameRangeLabel.Size = new System.Drawing.Size(35, 13);
            this.nameRangeLabel.TabIndex = 14;
            resources.ApplyResources(this.nameRangeLabel, "nameRangeLabel");
            // 
            // nameRangeTextBox
            // 
            this.nameRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameRangeTextBox.Location = new System.Drawing.Point(142, 29);
            this.nameRangeTextBox.Name = "nameRangeTextBox";
            this.nameRangeTextBox.ReadOnly = true;
            this.nameRangeTextBox.Size = new System.Drawing.Size(267, 20);
            this.nameRangeTextBox.TabIndex = 13;
            // 
            // valuesRangeLabel
            // 
            this.valuesRangeLabel.AutoSize = true;
            this.valuesRangeLabel.Location = new System.Drawing.Point(6, 59);
            this.valuesRangeLabel.Name = "valuesRangeLabel";
            this.valuesRangeLabel.Size = new System.Drawing.Size(39, 13);
            this.valuesRangeLabel.TabIndex = 12;
            resources.ApplyResources(this.valuesRangeLabel, "valuesRangeLabel");
            // 
            // valuesRangeTextBox
            // 
            this.valuesRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesRangeTextBox.Location = new System.Drawing.Point(142, 56);
            this.valuesRangeTextBox.Name = "valuesRangeTextBox";
            this.valuesRangeTextBox.ReadOnly = true;
            this.valuesRangeTextBox.Size = new System.Drawing.Size(267, 20);
            this.valuesRangeTextBox.TabIndex = 1;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seriesComboBox.FormattingEnabled = true;
            this.seriesComboBox.Location = new System.Drawing.Point(266, 0);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Size = new System.Drawing.Size(143, 21);
            this.seriesComboBox.TabIndex = 0;
            this.seriesComboBox.SelectedIndexChanged += new System.EventHandler(this.seriesComboBox_SelectedIndexChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(150, 9);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(273, 20);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            resources.ApplyResources(this.titleLabel, "titleLabel");
            // 
            // commonTabPage
            // 
            this.commonTabPage.Controls.Add(this.nameLabel);
            this.commonTabPage.Controls.Add(this.nameTextBox);
            this.commonTabPage.Controls.Add(this.descriptionLabel);
            this.commonTabPage.Controls.Add(this.descriptionTextBox);
            this.commonTabPage.Location = new System.Drawing.Point(4, 22);
            this.commonTabPage.Name = "commonTabPage";
            this.commonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commonTabPage.Size = new System.Drawing.Size(430, 406);
            this.commonTabPage.TabIndex = 0;
            resources.ApplyResources(this.commonTabPage, "commonTabPage");
            this.commonTabPage.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            resources.ApplyResources(this.nameLabel, "nameLabel");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(9, 25);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(411, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 8;
            resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(9, 71);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(411, 326);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // locationAndSizeTabPage
            // 
            this.locationAndSizeTabPage.Controls.Add(this.tableLayoutPanel1);
            this.locationAndSizeTabPage.Controls.Add(this.sheetDrawingLocationEditorControl);
            this.locationAndSizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.locationAndSizeTabPage.Name = "locationAndSizeTabPage";
            this.locationAndSizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.locationAndSizeTabPage.Size = new System.Drawing.Size(430, 406);
            this.locationAndSizeTabPage.TabIndex = 1;
            resources.ApplyResources(this.locationAndSizeTabPage, "locationAndSizeTabPage");
            this.locationAndSizeTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rotationAngleNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 26);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rotationAngleNumericUpDown
            // 
            this.rotationAngleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rotationAngleNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rotationAngleNumericUpDown.Location = new System.Drawing.Point(56, 3);
            this.rotationAngleNumericUpDown.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.rotationAngleNumericUpDown.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.rotationAngleNumericUpDown.Name = "rotationAngleNumericUpDown";
            this.rotationAngleNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.rotationAngleNumericUpDown.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            resources.ApplyResources(this.label1, "label1");
            // 
            // sheetDrawingLocationEditorControl
            // 
            this.sheetDrawingLocationEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sheetDrawingLocationEditorControl.Location = new System.Drawing.Point(6, 32);
            this.sheetDrawingLocationEditorControl.MinimumSize = new System.Drawing.Size(240, 200);
            this.sheetDrawingLocationEditorControl.Name = "sheetDrawingLocationEditorControl";
            this.sheetDrawingLocationEditorControl.SheetDrawingLocation = null;
            this.sheetDrawingLocationEditorControl.Size = new System.Drawing.Size(414, 373);
            this.sheetDrawingLocationEditorControl.TabIndex = 10;
            this.sheetDrawingLocationEditorControl.Worksheet = null;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(281, 459);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(362, 459);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // smoothLineCheckBox
            // 
            this.smoothLineCheckBox.AutoSize = true;
            this.smoothLineCheckBox.Location = new System.Drawing.Point(9, 81);
            this.smoothLineCheckBox.Name = "smoothLineCheckBox";
            this.smoothLineCheckBox.Size = new System.Drawing.Size(85, 17);
            this.smoothLineCheckBox.TabIndex = 17;
            resources.ApplyResources(this.smoothLineCheckBox, "smoothLineCheckBox");
            this.smoothLineCheckBox.UseVisualStyleBackColor = true;
            this.smoothLineCheckBox.CheckedChanged += new System.EventHandler(this.smoothLineCheckBox_CheckedChanged);
            // 
            // DrawingPropertiesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 493);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 280);
            this.Name = "DrawingPropertiesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            resources.ApplyResources(this, "$this");
            this.tabControl1.ResumeLayout(false);
            this.chartTabPage.ResumeLayout(false);
            this.chartTabPage.PerformLayout();
            this.categoriesGroupBox.ResumeLayout(false);
            this.categoriesGroupBox.PerformLayout();
            this.seriesGroupBox.ResumeLayout(false);
            this.seriesGroupBox.PerformLayout();
            this.dataPointGroupBox.ResumeLayout(false);
            this.markerAppearanceGroupBox.ResumeLayout(false);
            this.markerAppearanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markerSizeNumericUpDown)).EndInit();
            this.dataPointAppearanceGroupBox.ResumeLayout(false);
            this.commonTabPage.ResumeLayout(false);
            this.commonTabPage.PerformLayout();
            this.locationAndSizeTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationAngleNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage commonTabPage;
        private System.Windows.Forms.TabPage locationAndSizeTabPage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown rotationAngleNumericUpDown;
        private System.Windows.Forms.Label label1;
        private SheetDrawingLocationEditorControl sheetDrawingLocationEditorControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage chartTabPage;
        private System.Windows.Forms.GroupBox categoriesGroupBox;
        private System.Windows.Forms.GroupBox seriesGroupBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox categoriesDataRangeTextBox;
        private System.Windows.Forms.Label valuesRangeLabel;
        private System.Windows.Forms.NumericUpDown markerSizeNumericUpDown;
        private System.Windows.Forms.ComboBox markerTypeComboBox;
        private System.Windows.Forms.Label markerSizeLabel;
        private System.Windows.Forms.Label markerTypeLabel;
        private System.Windows.Forms.TextBox valuesRangeTextBox;
        private System.Windows.Forms.ComboBox seriesComboBox;
        private System.Windows.Forms.Label nameRangeLabel;
        private System.Windows.Forms.TextBox nameRangeTextBox;
        private System.Windows.Forms.TextBox dataRangeTextBox;
        private System.Windows.Forms.Label dataRangeLabel;
        private System.Windows.Forms.ComboBox dataPointComboBox;
        private System.Windows.Forms.GroupBox dataPointGroupBox;
        private System.Windows.Forms.GroupBox markerAppearanceGroupBox;
        private CustomControls.ShapeAppearanceEditorControl markerAppearanceEditor;
        private System.Windows.Forms.GroupBox dataPointAppearanceGroupBox;
        private CustomControls.ShapeAppearanceEditorControl dataPointAppearanceEditor;
        private System.Windows.Forms.CheckBox smoothLineCheckBox;
    }
}