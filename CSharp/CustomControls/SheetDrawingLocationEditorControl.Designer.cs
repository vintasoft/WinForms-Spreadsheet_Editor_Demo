namespace SpreadsheetEditorDemo
{
    partial class SheetDrawingLocationEditorControl
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
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.positioningGroupBox = new System.Windows.Forms.GroupBox();
            this.dontMoveOrSizeWithCellsRadioButton = new System.Windows.Forms.RadioButton();
            this.moveButDontSizeWithCellsRadioButton = new System.Windows.Forms.RadioButton();
            this.moveAndSizeWithCellsRadioButton = new System.Windows.Forms.RadioButton();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.positioningGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.sizeGroupBox.Location = new System.Drawing.Point(3, 57);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(424, 53);
            this.sizeGroupBox.TabIndex = 9;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.widthLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.widthNumericUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.heightNumericUpDown, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 28);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(209, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Height:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(3, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(51, 26);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthNumericUpDown.Location = new System.Drawing.Point(60, 3);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.widthNumericUpDown.TabIndex = 4;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightNumericUpDown.Location = new System.Drawing.Point(266, 3);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.heightNumericUpDown.TabIndex = 3;
            // 
            // positioningGroupBox
            // 
            this.positioningGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positioningGroupBox.Controls.Add(this.dontMoveOrSizeWithCellsRadioButton);
            this.positioningGroupBox.Controls.Add(this.moveButDontSizeWithCellsRadioButton);
            this.positioningGroupBox.Controls.Add(this.moveAndSizeWithCellsRadioButton);
            this.positioningGroupBox.Location = new System.Drawing.Point(3, 116);
            this.positioningGroupBox.Name = "positioningGroupBox";
            this.positioningGroupBox.Size = new System.Drawing.Size(424, 83);
            this.positioningGroupBox.TabIndex = 8;
            this.positioningGroupBox.TabStop = false;
            this.positioningGroupBox.Text = "Positioning";
            // 
            // dontMoveOrSizeWithCellsRadioButton
            // 
            this.dontMoveOrSizeWithCellsRadioButton.AutoSize = true;
            this.dontMoveOrSizeWithCellsRadioButton.Location = new System.Drawing.Point(7, 58);
            this.dontMoveOrSizeWithCellsRadioButton.Name = "dontMoveOrSizeWithCellsRadioButton";
            this.dontMoveOrSizeWithCellsRadioButton.Size = new System.Drawing.Size(158, 17);
            this.dontMoveOrSizeWithCellsRadioButton.TabIndex = 2;
            this.dontMoveOrSizeWithCellsRadioButton.TabStop = true;
            this.dontMoveOrSizeWithCellsRadioButton.Text = "Don\'t move or size with cells";
            this.dontMoveOrSizeWithCellsRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveButDontSizeWithCellsRadioButton
            // 
            this.moveButDontSizeWithCellsRadioButton.AutoSize = true;
            this.moveButDontSizeWithCellsRadioButton.Location = new System.Drawing.Point(7, 38);
            this.moveButDontSizeWithCellsRadioButton.Name = "moveButDontSizeWithCellsRadioButton";
            this.moveButDontSizeWithCellsRadioButton.Size = new System.Drawing.Size(163, 17);
            this.moveButDontSizeWithCellsRadioButton.TabIndex = 1;
            this.moveButDontSizeWithCellsRadioButton.TabStop = true;
            this.moveButDontSizeWithCellsRadioButton.Text = "Move but don\'t size with cells";
            this.moveButDontSizeWithCellsRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveAndSizeWithCellsRadioButton
            // 
            this.moveAndSizeWithCellsRadioButton.AutoSize = true;
            this.moveAndSizeWithCellsRadioButton.Location = new System.Drawing.Point(7, 18);
            this.moveAndSizeWithCellsRadioButton.Name = "moveAndSizeWithCellsRadioButton";
            this.moveAndSizeWithCellsRadioButton.Size = new System.Drawing.Size(140, 17);
            this.moveAndSizeWithCellsRadioButton.TabIndex = 0;
            this.moveAndSizeWithCellsRadioButton.TabStop = true;
            this.moveAndSizeWithCellsRadioButton.Text = "Move and size with cells";
            this.moveAndSizeWithCellsRadioButton.UseVisualStyleBackColor = true;
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.locationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(424, 53);
            this.locationGroupBox.TabIndex = 11;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.xNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yNumericUpDown, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 28);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(209, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xNumericUpDown.Location = new System.Drawing.Point(60, 3);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.xNumericUpDown.TabIndex = 4;
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yNumericUpDown.Location = new System.Drawing.Point(266, 3);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.yNumericUpDown.TabIndex = 3;
            // 
            // SheetDrawingLocationEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.positioningGroupBox);
            this.MinimumSize = new System.Drawing.Size(240, 200);
            this.Name = "SheetDrawingLocationEditorControl";
            this.Size = new System.Drawing.Size(435, 200);
            this.sizeGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.positioningGroupBox.ResumeLayout(false);
            this.positioningGroupBox.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.GroupBox positioningGroupBox;
        private System.Windows.Forms.RadioButton dontMoveOrSizeWithCellsRadioButton;
        private System.Windows.Forms.RadioButton moveButDontSizeWithCellsRadioButton;
        private System.Windows.Forms.RadioButton moveAndSizeWithCellsRadioButton;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}