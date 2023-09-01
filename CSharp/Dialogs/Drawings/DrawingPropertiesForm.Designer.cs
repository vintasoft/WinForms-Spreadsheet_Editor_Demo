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
            this.commonTabPage = new System.Windows.Forms.TabPage();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.locationAndSizeTabPage = new System.Windows.Forms.TabPage();
            this.sheetDrawingLocationEditorControl = new SpreadsheetEditorDemo.SheetDrawingLocationEditorControl();
            this.rotationAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.commonTabPage.SuspendLayout();
            this.locationAndSizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationAngleNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.commonTabPage);
            this.tabControl1.Controls.Add(this.locationAndSizeTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.MinimumSize = new System.Drawing.Size(300, 200);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // commonTabPage
            // 
            this.commonTabPage.Controls.Add(this.authorLabel);
            this.commonTabPage.Controls.Add(this.nameTextBox);
            this.commonTabPage.Controls.Add(this.commentLabel);
            this.commonTabPage.Controls.Add(this.descriptionTextBox);
            this.commonTabPage.Location = new System.Drawing.Point(4, 22);
            this.commonTabPage.Name = "commonTabPage";
            this.commonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commonTabPage.Size = new System.Drawing.Size(393, 262);
            this.commonTabPage.TabIndex = 0;
            resources.ApplyResources(this.commonTabPage, "commonTabPage");
            this.commonTabPage.UseVisualStyleBackColor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(6, 9);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 7;
            resources.ApplyResources(this.authorLabel, "authorLabel");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(9, 25);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 6, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(374, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(6, 55);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(63, 13);
            this.commentLabel.TabIndex = 8;
            resources.ApplyResources(this.commentLabel, "commentLabel");
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
            this.descriptionTextBox.Size = new System.Drawing.Size(374, 182);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // locationAndSizeTabPage
            // 
            this.locationAndSizeTabPage.Controls.Add(this.tableLayoutPanel1);
            this.locationAndSizeTabPage.Controls.Add(this.sheetDrawingLocationEditorControl);
            this.locationAndSizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.locationAndSizeTabPage.Name = "locationAndSizeTabPage";
            this.locationAndSizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.locationAndSizeTabPage.Size = new System.Drawing.Size(393, 262);
            this.locationAndSizeTabPage.TabIndex = 1;
            resources.ApplyResources(this.locationAndSizeTabPage, "locationAndSizeTabPage");
            this.locationAndSizeTabPage.UseVisualStyleBackColor = true;
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
            this.sheetDrawingLocationEditorControl.Size = new System.Drawing.Size(377, 229);
            this.sheetDrawingLocationEditorControl.TabIndex = 10;
            this.sheetDrawingLocationEditorControl.Worksheet = null;
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
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(244, 297);
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
            this.buttonCancel.Location = new System.Drawing.Point(325, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
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
            // DrawingPropertiesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(405, 331);
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
            this.commonTabPage.ResumeLayout(false);
            this.commonTabPage.PerformLayout();
            this.locationAndSizeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rotationAngleNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage commonTabPage;
        private System.Windows.Forms.TabPage locationAndSizeTabPage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown rotationAngleNumericUpDown;
        private System.Windows.Forms.Label label1;
        private SheetDrawingLocationEditorControl sheetDrawingLocationEditorControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}