
namespace SpreadsheetEditorDemo
{
    partial class OptionsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiCultureComboBox = new System.Windows.Forms.ComboBox();
            this.cultureComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.appearanceTabControl = new System.Windows.Forms.TabControl();
            this.focusedCellsTabPage = new System.Windows.Forms.TabPage();
            this.focusedCellsAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.cellsBufferTabPage = new System.Windows.Forms.TabPage();
            this.bufferCellsAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.formulaTabPage = new System.Windows.Forms.TabPage();
            this.formulaCellsAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.focusedFormulaTabPage = new System.Windows.Forms.TabPage();
            this.focusedFormulaCellsAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.headingsTabPage = new System.Windows.Forms.TabPage();
            this.coveredHeaderColorLabel = new System.Windows.Forms.Label();
            this.headingsColorLabel = new System.Windows.Forms.Label();
            this.selectedHeaderColorLabel = new System.Windows.Forms.Label();
            this.headingsTextColorLabel = new System.Windows.Forms.Label();
            this.selectedCellColorLabel = new System.Windows.Forms.Label();
            this.headingsBorderColorLabel = new System.Windows.Forms.Label();
            this.coveredHeaderColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.headingsColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.headingsTextColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.selectedHeaderColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.headingsBorderColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.selectedCellColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.errorsTabPage = new System.Windows.Forms.TabPage();
            this.errorIndicatorSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorIndicatorColorLabel = new System.Windows.Forms.Label();
            this.errorIndicatorSizeLabel = new System.Windows.Forms.Label();
            this.errorIndicatorColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.commentsTabPage = new System.Windows.Forms.TabPage();
            this.focusedCommentAppearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.focusedCommentAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.commentAppearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.commentAppearanceEditor = new SpreadsheetEditorDemo.CustomControls.CellReferencesAppearanceEditorControl();
            this.commentIndicatorSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.commentIndicatorColorLabel = new System.Windows.Forms.Label();
            this.commentIndicatorSizeLabel = new System.Windows.Forms.Label();
            this.commentIndicatorColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.miscellaneousTabPage = new System.Windows.Forms.TabPage();
            this.hyperlinkColorLabel = new System.Windows.Forms.Label();
            this.gridColorAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridColorAlphaLabel = new System.Windows.Forms.Label();
            this.hyperlinkColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.appearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculationMinIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.appearanceTabControl.SuspendLayout();
            this.focusedCellsTabPage.SuspendLayout();
            this.cellsBufferTabPage.SuspendLayout();
            this.formulaTabPage.SuspendLayout();
            this.focusedFormulaTabPage.SuspendLayout();
            this.headingsTabPage.SuspendLayout();
            this.errorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIndicatorSizeNumericUpDown)).BeginInit();
            this.commentsTabPage.SuspendLayout();
            this.focusedCommentAppearanceGroupBox.SuspendLayout();
            this.commentAppearanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentIndicatorSizeNumericUpDown)).BeginInit();
            this.miscellaneousTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColorAlphaNumericUpDown)).BeginInit();
            this.appearanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculationMinIntervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Culture (number formats, date formats)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "UI Culture (function names, error names and constants)";
            // 
            // uiCultureComboBox
            // 
            this.uiCultureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiCultureComboBox.FormattingEnabled = true;
            this.uiCultureComboBox.Items.AddRange(new object[] {
            "en-US",
            "ru-RU",
            "de-DE",
            "es-ES",
            "fr-FR",
            "it-IT",
            "pt-PT"});
            this.uiCultureComboBox.Location = new System.Drawing.Point(317, 33);
            this.uiCultureComboBox.Name = "uiCultureComboBox";
            this.uiCultureComboBox.Size = new System.Drawing.Size(73, 21);
            this.uiCultureComboBox.TabIndex = 79;
            // 
            // cultureComboBox
            // 
            this.cultureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cultureComboBox.FormattingEnabled = true;
            this.cultureComboBox.Items.AddRange(new object[] {
            "en-US",
            "ru-RU",
            "de-DE",
            "es-ES",
            "fr-FR",
            "it-IT",
            "pt-PT"});
            this.cultureComboBox.Location = new System.Drawing.Point(317, 6);
            this.cultureComboBox.Name = "cultureComboBox";
            this.cultureComboBox.Size = new System.Drawing.Size(73, 21);
            this.cultureComboBox.TabIndex = 78;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(338, 344);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 83;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(257, 344);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // appearanceTabControl
            // 
            this.appearanceTabControl.Controls.Add(this.focusedCellsTabPage);
            this.appearanceTabControl.Controls.Add(this.cellsBufferTabPage);
            this.appearanceTabControl.Controls.Add(this.formulaTabPage);
            this.appearanceTabControl.Controls.Add(this.focusedFormulaTabPage);
            this.appearanceTabControl.Controls.Add(this.headingsTabPage);
            this.appearanceTabControl.Controls.Add(this.errorsTabPage);
            this.appearanceTabControl.Controls.Add(this.commentsTabPage);
            this.appearanceTabControl.Controls.Add(this.miscellaneousTabPage);
            this.appearanceTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appearanceTabControl.Location = new System.Drawing.Point(3, 16);
            this.appearanceTabControl.Multiline = true;
            this.appearanceTabControl.Name = "appearanceTabControl";
            this.appearanceTabControl.SelectedIndex = 0;
            this.appearanceTabControl.Size = new System.Drawing.Size(399, 226);
            this.appearanceTabControl.TabIndex = 84;
            // 
            // focusedCellsTabPage
            // 
            this.focusedCellsTabPage.Controls.Add(this.focusedCellsAppearanceEditor);
            this.focusedCellsTabPage.Location = new System.Drawing.Point(4, 40);
            this.focusedCellsTabPage.Name = "focusedCellsTabPage";
            this.focusedCellsTabPage.Size = new System.Drawing.Size(391, 182);
            this.focusedCellsTabPage.TabIndex = 0;
            this.focusedCellsTabPage.Text = "Focused Cells";
            this.focusedCellsTabPage.UseVisualStyleBackColor = true;
            // 
            // focusedCellsAppearanceEditor
            // 
            this.focusedCellsAppearanceEditor.CellsAppearance = null;
            this.focusedCellsAppearanceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.focusedCellsAppearanceEditor.Location = new System.Drawing.Point(0, 0);
            this.focusedCellsAppearanceEditor.Name = "focusedCellsAppearanceEditor";
            this.focusedCellsAppearanceEditor.Size = new System.Drawing.Size(391, 182);
            this.focusedCellsAppearanceEditor.TabIndex = 0;
            // 
            // cellsBufferTabPage
            // 
            this.cellsBufferTabPage.Controls.Add(this.bufferCellsAppearanceEditor);
            this.cellsBufferTabPage.Location = new System.Drawing.Point(4, 40);
            this.cellsBufferTabPage.Name = "cellsBufferTabPage";
            this.cellsBufferTabPage.Size = new System.Drawing.Size(391, 182);
            this.cellsBufferTabPage.TabIndex = 3;
            this.cellsBufferTabPage.Text = "Clipboard Cells";
            this.cellsBufferTabPage.UseVisualStyleBackColor = true;
            // 
            // bufferCellsAppearanceEditor
            // 
            this.bufferCellsAppearanceEditor.CellsAppearance = null;
            this.bufferCellsAppearanceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferCellsAppearanceEditor.Location = new System.Drawing.Point(0, 0);
            this.bufferCellsAppearanceEditor.Name = "bufferCellsAppearanceEditor";
            this.bufferCellsAppearanceEditor.Size = new System.Drawing.Size(391, 182);
            this.bufferCellsAppearanceEditor.TabIndex = 0;
            // 
            // formulaTabPage
            // 
            this.formulaTabPage.Controls.Add(this.formulaCellsAppearanceEditor);
            this.formulaTabPage.Location = new System.Drawing.Point(4, 40);
            this.formulaTabPage.Name = "formulaTabPage";
            this.formulaTabPage.Size = new System.Drawing.Size(391, 182);
            this.formulaTabPage.TabIndex = 1;
            this.formulaTabPage.Text = "Formula Cells";
            this.formulaTabPage.UseVisualStyleBackColor = true;
            // 
            // formulaCellsAppearanceEditor
            // 
            this.formulaCellsAppearanceEditor.CellsAppearance = null;
            this.formulaCellsAppearanceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formulaCellsAppearanceEditor.Location = new System.Drawing.Point(0, 0);
            this.formulaCellsAppearanceEditor.Name = "formulaCellsAppearanceEditor";
            this.formulaCellsAppearanceEditor.Size = new System.Drawing.Size(391, 182);
            this.formulaCellsAppearanceEditor.TabIndex = 0;
            // 
            // focusedFormulaTabPage
            // 
            this.focusedFormulaTabPage.Controls.Add(this.focusedFormulaCellsAppearanceEditor);
            this.focusedFormulaTabPage.Location = new System.Drawing.Point(4, 40);
            this.focusedFormulaTabPage.Name = "focusedFormulaTabPage";
            this.focusedFormulaTabPage.Size = new System.Drawing.Size(391, 182);
            this.focusedFormulaTabPage.TabIndex = 2;
            this.focusedFormulaTabPage.Text = "Focused Formula Cells";
            this.focusedFormulaTabPage.UseVisualStyleBackColor = true;
            // 
            // focusedFormulaCellsAppearanceEditor
            // 
            this.focusedFormulaCellsAppearanceEditor.CellsAppearance = null;
            this.focusedFormulaCellsAppearanceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.focusedFormulaCellsAppearanceEditor.Location = new System.Drawing.Point(0, 0);
            this.focusedFormulaCellsAppearanceEditor.Name = "focusedFormulaCellsAppearanceEditor";
            this.focusedFormulaCellsAppearanceEditor.Size = new System.Drawing.Size(391, 182);
            this.focusedFormulaCellsAppearanceEditor.TabIndex = 0;
            // 
            // headingsTabPage
            // 
            this.headingsTabPage.Controls.Add(this.coveredHeaderColorLabel);
            this.headingsTabPage.Controls.Add(this.headingsColorLabel);
            this.headingsTabPage.Controls.Add(this.selectedHeaderColorLabel);
            this.headingsTabPage.Controls.Add(this.headingsTextColorLabel);
            this.headingsTabPage.Controls.Add(this.selectedCellColorLabel);
            this.headingsTabPage.Controls.Add(this.headingsBorderColorLabel);
            this.headingsTabPage.Controls.Add(this.coveredHeaderColorPanelControl);
            this.headingsTabPage.Controls.Add(this.headingsColorPanelControl);
            this.headingsTabPage.Controls.Add(this.headingsTextColorPanelControl);
            this.headingsTabPage.Controls.Add(this.selectedHeaderColorPanelControl);
            this.headingsTabPage.Controls.Add(this.headingsBorderColorPanelControl);
            this.headingsTabPage.Controls.Add(this.selectedCellColorPanelControl);
            this.headingsTabPage.Location = new System.Drawing.Point(4, 40);
            this.headingsTabPage.Name = "headingsTabPage";
            this.headingsTabPage.Size = new System.Drawing.Size(391, 182);
            this.headingsTabPage.TabIndex = 4;
            this.headingsTabPage.Text = "Headings and Selection";
            this.headingsTabPage.UseVisualStyleBackColor = true;
            // 
            // coveredHeaderColorLabel
            // 
            this.coveredHeaderColorLabel.AutoSize = true;
            this.coveredHeaderColorLabel.Location = new System.Drawing.Point(4, 153);
            this.coveredHeaderColorLabel.Name = "coveredHeaderColorLabel";
            this.coveredHeaderColorLabel.Size = new System.Drawing.Size(115, 13);
            this.coveredHeaderColorLabel.TabIndex = 17;
            this.coveredHeaderColorLabel.Text = "Covered Header Color:";
            // 
            // headingsColorLabel
            // 
            this.headingsColorLabel.AutoSize = true;
            this.headingsColorLabel.Location = new System.Drawing.Point(4, 13);
            this.headingsColorLabel.Name = "headingsColorLabel";
            this.headingsColorLabel.Size = new System.Drawing.Size(82, 13);
            this.headingsColorLabel.TabIndex = 7;
            this.headingsColorLabel.Text = "Headings Color:";
            // 
            // selectedHeaderColorLabel
            // 
            this.selectedHeaderColorLabel.AutoSize = true;
            this.selectedHeaderColorLabel.Location = new System.Drawing.Point(4, 125);
            this.selectedHeaderColorLabel.Name = "selectedHeaderColorLabel";
            this.selectedHeaderColorLabel.Size = new System.Drawing.Size(117, 13);
            this.selectedHeaderColorLabel.TabIndex = 15;
            this.selectedHeaderColorLabel.Text = "Selected Header Color:";
            // 
            // headingsTextColorLabel
            // 
            this.headingsTextColorLabel.AutoSize = true;
            this.headingsTextColorLabel.Location = new System.Drawing.Point(4, 41);
            this.headingsTextColorLabel.Name = "headingsTextColorLabel";
            this.headingsTextColorLabel.Size = new System.Drawing.Size(106, 13);
            this.headingsTextColorLabel.TabIndex = 9;
            this.headingsTextColorLabel.Text = "Headings Text Color:";
            // 
            // selectedCellColorLabel
            // 
            this.selectedCellColorLabel.AutoSize = true;
            this.selectedCellColorLabel.Location = new System.Drawing.Point(4, 97);
            this.selectedCellColorLabel.Name = "selectedCellColorLabel";
            this.selectedCellColorLabel.Size = new System.Drawing.Size(99, 13);
            this.selectedCellColorLabel.TabIndex = 13;
            this.selectedCellColorLabel.Text = "Selected Cell Color:";
            // 
            // headingsBorderColorLabel
            // 
            this.headingsBorderColorLabel.AutoSize = true;
            this.headingsBorderColorLabel.Location = new System.Drawing.Point(4, 69);
            this.headingsBorderColorLabel.Name = "headingsBorderColorLabel";
            this.headingsBorderColorLabel.Size = new System.Drawing.Size(116, 13);
            this.headingsBorderColorLabel.TabIndex = 11;
            this.headingsBorderColorLabel.Text = "Headings Border Color:";
            // 
            // coveredHeaderColorPanelControl
            // 
            this.coveredHeaderColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coveredHeaderColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.coveredHeaderColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.coveredHeaderColorPanelControl.Location = new System.Drawing.Point(135, 148);
            this.coveredHeaderColorPanelControl.Name = "coveredHeaderColorPanelControl";
            this.coveredHeaderColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.coveredHeaderColorPanelControl.TabIndex = 16;
            // 
            // headingsColorPanelControl
            // 
            this.headingsColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingsColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.headingsColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.headingsColorPanelControl.Location = new System.Drawing.Point(135, 8);
            this.headingsColorPanelControl.Name = "headingsColorPanelControl";
            this.headingsColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.headingsColorPanelControl.TabIndex = 6;
            // 
            // headingsTextColorPanelControl
            // 
            this.headingsTextColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingsTextColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.headingsTextColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.headingsTextColorPanelControl.Location = new System.Drawing.Point(135, 36);
            this.headingsTextColorPanelControl.Name = "headingsTextColorPanelControl";
            this.headingsTextColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.headingsTextColorPanelControl.TabIndex = 8;
            // 
            // selectedHeaderColorPanelControl
            // 
            this.selectedHeaderColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedHeaderColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.selectedHeaderColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.selectedHeaderColorPanelControl.Location = new System.Drawing.Point(135, 120);
            this.selectedHeaderColorPanelControl.Name = "selectedHeaderColorPanelControl";
            this.selectedHeaderColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.selectedHeaderColorPanelControl.TabIndex = 14;
            // 
            // headingsBorderColorPanelControl
            // 
            this.headingsBorderColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingsBorderColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.headingsBorderColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.headingsBorderColorPanelControl.Location = new System.Drawing.Point(135, 64);
            this.headingsBorderColorPanelControl.Name = "headingsBorderColorPanelControl";
            this.headingsBorderColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.headingsBorderColorPanelControl.TabIndex = 10;
            // 
            // selectedCellColorPanelControl
            // 
            this.selectedCellColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCellColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.selectedCellColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.selectedCellColorPanelControl.Location = new System.Drawing.Point(135, 92);
            this.selectedCellColorPanelControl.Name = "selectedCellColorPanelControl";
            this.selectedCellColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.selectedCellColorPanelControl.TabIndex = 12;
            // 
            // errorsTabPage
            // 
            this.errorsTabPage.Controls.Add(this.errorIndicatorSizeNumericUpDown);
            this.errorsTabPage.Controls.Add(this.errorIndicatorColorLabel);
            this.errorsTabPage.Controls.Add(this.errorIndicatorSizeLabel);
            this.errorsTabPage.Controls.Add(this.errorIndicatorColorPanelControl);
            this.errorsTabPage.Location = new System.Drawing.Point(4, 40);
            this.errorsTabPage.Name = "errorsTabPage";
            this.errorsTabPage.Size = new System.Drawing.Size(391, 182);
            this.errorsTabPage.TabIndex = 5;
            this.errorsTabPage.Text = "Errors";
            this.errorsTabPage.UseVisualStyleBackColor = true;
            // 
            // errorIndicatorSizeNumericUpDown
            // 
            this.errorIndicatorSizeNumericUpDown.Location = new System.Drawing.Point(135, 37);
            this.errorIndicatorSizeNumericUpDown.Name = "errorIndicatorSizeNumericUpDown";
            this.errorIndicatorSizeNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.errorIndicatorSizeNumericUpDown.TabIndex = 21;
            // 
            // errorIndicatorColorLabel
            // 
            this.errorIndicatorColorLabel.AutoSize = true;
            this.errorIndicatorColorLabel.Location = new System.Drawing.Point(4, 13);
            this.errorIndicatorColorLabel.Name = "errorIndicatorColorLabel";
            this.errorIndicatorColorLabel.Size = new System.Drawing.Size(78, 13);
            this.errorIndicatorColorLabel.TabIndex = 19;
            this.errorIndicatorColorLabel.Text = "Indicator Color:";
            // 
            // errorIndicatorSizeLabel
            // 
            this.errorIndicatorSizeLabel.AutoSize = true;
            this.errorIndicatorSizeLabel.Location = new System.Drawing.Point(4, 41);
            this.errorIndicatorSizeLabel.Name = "errorIndicatorSizeLabel";
            this.errorIndicatorSizeLabel.Size = new System.Drawing.Size(74, 13);
            this.errorIndicatorSizeLabel.TabIndex = 20;
            this.errorIndicatorSizeLabel.Text = "Indicator Size:";
            // 
            // errorIndicatorColorPanelControl
            // 
            this.errorIndicatorColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorIndicatorColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.errorIndicatorColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.errorIndicatorColorPanelControl.Location = new System.Drawing.Point(135, 8);
            this.errorIndicatorColorPanelControl.Name = "errorIndicatorColorPanelControl";
            this.errorIndicatorColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.errorIndicatorColorPanelControl.TabIndex = 18;
            // 
            // commentsTabPage
            // 
            this.commentsTabPage.Controls.Add(this.focusedCommentAppearanceGroupBox);
            this.commentsTabPage.Controls.Add(this.commentAppearanceGroupBox);
            this.commentsTabPage.Controls.Add(this.commentIndicatorSizeNumericUpDown);
            this.commentsTabPage.Controls.Add(this.commentIndicatorColorLabel);
            this.commentsTabPage.Controls.Add(this.commentIndicatorSizeLabel);
            this.commentsTabPage.Controls.Add(this.commentIndicatorColorPanelControl);
            this.commentsTabPage.Location = new System.Drawing.Point(4, 40);
            this.commentsTabPage.Name = "commentsTabPage";
            this.commentsTabPage.Size = new System.Drawing.Size(391, 182);
            this.commentsTabPage.TabIndex = 6;
            this.commentsTabPage.Text = "Comments";
            this.commentsTabPage.UseVisualStyleBackColor = true;
            // 
            // focusedCommentAppearanceGroupBox
            // 
            this.focusedCommentAppearanceGroupBox.Controls.Add(this.focusedCommentAppearanceEditor);
            this.focusedCommentAppearanceGroupBox.Location = new System.Drawing.Point(197, 65);
            this.focusedCommentAppearanceGroupBox.Name = "focusedCommentAppearanceGroupBox";
            this.focusedCommentAppearanceGroupBox.Size = new System.Drawing.Size(186, 109);
            this.focusedCommentAppearanceGroupBox.TabIndex = 25;
            this.focusedCommentAppearanceGroupBox.TabStop = false;
            this.focusedCommentAppearanceGroupBox.Text = "Focused appearance:";
            // 
            // focusedCommentAppearanceEditor
            // 
            this.focusedCommentAppearanceEditor.CellsAppearance = null;
            this.focusedCommentAppearanceEditor.Location = new System.Drawing.Point(3, 17);
            this.focusedCommentAppearanceEditor.Name = "focusedCommentAppearanceEditor";
            this.focusedCommentAppearanceEditor.Size = new System.Drawing.Size(183, 92);
            this.focusedCommentAppearanceEditor.TabIndex = 22;
            // 
            // commentAppearanceGroupBox
            // 
            this.commentAppearanceGroupBox.Controls.Add(this.commentAppearanceEditor);
            this.commentAppearanceGroupBox.Location = new System.Drawing.Point(5, 65);
            this.commentAppearanceGroupBox.Name = "commentAppearanceGroupBox";
            this.commentAppearanceGroupBox.Size = new System.Drawing.Size(186, 109);
            this.commentAppearanceGroupBox.TabIndex = 24;
            this.commentAppearanceGroupBox.TabStop = false;
            this.commentAppearanceGroupBox.Text = "Appearance:";
            // 
            // commentAppearanceEditor
            // 
            this.commentAppearanceEditor.CellsAppearance = null;
            this.commentAppearanceEditor.Location = new System.Drawing.Point(3, 17);
            this.commentAppearanceEditor.Name = "commentAppearanceEditor";
            this.commentAppearanceEditor.Size = new System.Drawing.Size(183, 92);
            this.commentAppearanceEditor.TabIndex = 22;
            // 
            // commentIndicatorSizeNumericUpDown
            // 
            this.commentIndicatorSizeNumericUpDown.Location = new System.Drawing.Point(135, 37);
            this.commentIndicatorSizeNumericUpDown.Name = "commentIndicatorSizeNumericUpDown";
            this.commentIndicatorSizeNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.commentIndicatorSizeNumericUpDown.TabIndex = 21;
            // 
            // commentIndicatorColorLabel
            // 
            this.commentIndicatorColorLabel.AutoSize = true;
            this.commentIndicatorColorLabel.Location = new System.Drawing.Point(4, 13);
            this.commentIndicatorColorLabel.Name = "commentIndicatorColorLabel";
            this.commentIndicatorColorLabel.Size = new System.Drawing.Size(78, 13);
            this.commentIndicatorColorLabel.TabIndex = 19;
            this.commentIndicatorColorLabel.Text = "Indicator Color:";
            // 
            // commentIndicatorSizeLabel
            // 
            this.commentIndicatorSizeLabel.AutoSize = true;
            this.commentIndicatorSizeLabel.Location = new System.Drawing.Point(4, 41);
            this.commentIndicatorSizeLabel.Name = "commentIndicatorSizeLabel";
            this.commentIndicatorSizeLabel.Size = new System.Drawing.Size(74, 13);
            this.commentIndicatorSizeLabel.TabIndex = 20;
            this.commentIndicatorSizeLabel.Text = "Indicator Size:";
            // 
            // commentIndicatorColorPanelControl
            // 
            this.commentIndicatorColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentIndicatorColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.commentIndicatorColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.commentIndicatorColorPanelControl.Location = new System.Drawing.Point(135, 8);
            this.commentIndicatorColorPanelControl.Name = "commentIndicatorColorPanelControl";
            this.commentIndicatorColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.commentIndicatorColorPanelControl.TabIndex = 18;
            // 
            // miscellaneousTabPage
            // 
            this.miscellaneousTabPage.Controls.Add(this.hyperlinkColorLabel);
            this.miscellaneousTabPage.Controls.Add(this.gridColorAlphaNumericUpDown);
            this.miscellaneousTabPage.Controls.Add(this.gridColorAlphaLabel);
            this.miscellaneousTabPage.Controls.Add(this.hyperlinkColorPanelControl);
            this.miscellaneousTabPage.Location = new System.Drawing.Point(4, 40);
            this.miscellaneousTabPage.Name = "miscellaneousTabPage";
            this.miscellaneousTabPage.Size = new System.Drawing.Size(391, 182);
            this.miscellaneousTabPage.TabIndex = 7;
            this.miscellaneousTabPage.Text = "Miscellaneous";
            this.miscellaneousTabPage.UseVisualStyleBackColor = true;
            // 
            // hyperlinkColorLabel
            // 
            this.hyperlinkColorLabel.AutoSize = true;
            this.hyperlinkColorLabel.Location = new System.Drawing.Point(4, 13);
            this.hyperlinkColorLabel.Name = "hyperlinkColorLabel";
            this.hyperlinkColorLabel.Size = new System.Drawing.Size(81, 13);
            this.hyperlinkColorLabel.TabIndex = 23;
            this.hyperlinkColorLabel.Text = "Hyperlink Color:";
            // 
            // gridColorAlphaNumericUpDown
            // 
            this.gridColorAlphaNumericUpDown.Location = new System.Drawing.Point(135, 37);
            this.gridColorAlphaNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gridColorAlphaNumericUpDown.Name = "gridColorAlphaNumericUpDown";
            this.gridColorAlphaNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.gridColorAlphaNumericUpDown.TabIndex = 25;
            // 
            // gridColorAlphaLabel
            // 
            this.gridColorAlphaLabel.AutoSize = true;
            this.gridColorAlphaLabel.Location = new System.Drawing.Point(4, 41);
            this.gridColorAlphaLabel.Name = "gridColorAlphaLabel";
            this.gridColorAlphaLabel.Size = new System.Drawing.Size(86, 13);
            this.gridColorAlphaLabel.TabIndex = 24;
            this.gridColorAlphaLabel.Text = "Grid Color Alpha:";
            // 
            // hyperlinkColorPanelControl
            // 
            this.hyperlinkColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperlinkColorPanelControl.CanEditAlphaChannel = false;
            this.hyperlinkColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.hyperlinkColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.hyperlinkColorPanelControl.Location = new System.Drawing.Point(135, 8);
            this.hyperlinkColorPanelControl.Name = "hyperlinkColorPanelControl";
            this.hyperlinkColorPanelControl.Size = new System.Drawing.Size(249, 22);
            this.hyperlinkColorPanelControl.TabIndex = 22;
            // 
            // appearanceGroupBox
            // 
            this.appearanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appearanceGroupBox.Controls.Add(this.appearanceTabControl);
            this.appearanceGroupBox.Location = new System.Drawing.Point(8, 90);
            this.appearanceGroupBox.Name = "appearanceGroupBox";
            this.appearanceGroupBox.Size = new System.Drawing.Size(405, 245);
            this.appearanceGroupBox.TabIndex = 85;
            this.appearanceGroupBox.TabStop = false;
            this.appearanceGroupBox.Text = "Appearance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Formulas calculation minimum interval (requires reopen)";
            // 
            // calculationMinIntervalNumericUpDown
            // 
            this.calculationMinIntervalNumericUpDown.Location = new System.Drawing.Point(317, 60);
            this.calculationMinIntervalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.calculationMinIntervalNumericUpDown.Name = "calculationMinIntervalNumericUpDown";
            this.calculationMinIntervalNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.calculationMinIntervalNumericUpDown.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "ms";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(425, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculationMinIntervalNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appearanceGroupBox);
            this.Controls.Add(this.uiCultureComboBox);
            this.Controls.Add(this.cultureComboBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.appearanceTabControl.ResumeLayout(false);
            this.focusedCellsTabPage.ResumeLayout(false);
            this.cellsBufferTabPage.ResumeLayout(false);
            this.formulaTabPage.ResumeLayout(false);
            this.focusedFormulaTabPage.ResumeLayout(false);
            this.headingsTabPage.ResumeLayout(false);
            this.headingsTabPage.PerformLayout();
            this.errorsTabPage.ResumeLayout(false);
            this.errorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIndicatorSizeNumericUpDown)).EndInit();
            this.commentsTabPage.ResumeLayout(false);
            this.commentsTabPage.PerformLayout();
            this.focusedCommentAppearanceGroupBox.ResumeLayout(false);
            this.commentAppearanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentIndicatorSizeNumericUpDown)).EndInit();
            this.miscellaneousTabPage.ResumeLayout(false);
            this.miscellaneousTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColorAlphaNumericUpDown)).EndInit();
            this.appearanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculationMinIntervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiCultureComboBox;
        private System.Windows.Forms.ComboBox cultureComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl appearanceTabControl;
        private System.Windows.Forms.TabPage focusedCellsTabPage;
        private System.Windows.Forms.TabPage formulaTabPage;
        private System.Windows.Forms.TabPage focusedFormulaTabPage;
        private System.Windows.Forms.TabPage cellsBufferTabPage;
        private System.Windows.Forms.GroupBox appearanceGroupBox;
        private DemosCommonCode.CustomControls.ColorPanelControl headingsColorPanelControl;
        private System.Windows.Forms.Label coveredHeaderColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl coveredHeaderColorPanelControl;
        private System.Windows.Forms.Label selectedHeaderColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl selectedHeaderColorPanelControl;
        private System.Windows.Forms.Label selectedCellColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl selectedCellColorPanelControl;
        private System.Windows.Forms.Label headingsBorderColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl headingsBorderColorPanelControl;
        private System.Windows.Forms.Label headingsTextColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl headingsTextColorPanelControl;
        private System.Windows.Forms.Label headingsColorLabel;
        private System.Windows.Forms.NumericUpDown errorIndicatorSizeNumericUpDown;
        private System.Windows.Forms.Label errorIndicatorSizeLabel;
        private System.Windows.Forms.Label errorIndicatorColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl errorIndicatorColorPanelControl;
        private System.Windows.Forms.NumericUpDown commentIndicatorSizeNumericUpDown;
        private System.Windows.Forms.Label commentIndicatorSizeLabel;
        private System.Windows.Forms.Label commentIndicatorColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl commentIndicatorColorPanelControl;
        private System.Windows.Forms.NumericUpDown gridColorAlphaNumericUpDown;
        private System.Windows.Forms.Label gridColorAlphaLabel;
        private System.Windows.Forms.Label hyperlinkColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl hyperlinkColorPanelControl;
        private CustomControls.CellReferencesAppearanceEditorControl focusedCellsAppearanceEditor;
        private CustomControls.CellReferencesAppearanceEditorControl bufferCellsAppearanceEditor;
        private CustomControls.CellReferencesAppearanceEditorControl formulaCellsAppearanceEditor;
        private CustomControls.CellReferencesAppearanceEditorControl focusedFormulaCellsAppearanceEditor;
        private System.Windows.Forms.TabPage headingsTabPage;
        private System.Windows.Forms.TabPage errorsTabPage;
        private System.Windows.Forms.TabPage commentsTabPage;
        private System.Windows.Forms.TabPage miscellaneousTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown calculationMinIntervalNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox commentAppearanceGroupBox;
        private CustomControls.CellReferencesAppearanceEditorControl commentAppearanceEditor;
        private System.Windows.Forms.GroupBox focusedCommentAppearanceGroupBox;
        private CustomControls.CellReferencesAppearanceEditorControl focusedCommentAppearanceEditor;
    }
}