
namespace SpreadsheetEditorDemo
{
    partial class WorksheetFormatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksheetFormatForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.rowHeightTextBox = new System.Windows.Forms.TextBox();
            this.rowHeightLabel = new System.Windows.Forms.Label();
            this.columnWidthLabel = new System.Windows.Forms.Label();
            this.columnWidthTextBox = new System.Windows.Forms.TextBox();
            this.rowAutoHeightCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(164, 137);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 83;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(83, 137);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // rowHeightTextBox
            // 
            this.rowHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rowHeightTextBox.Location = new System.Drawing.Point(15, 25);
            this.rowHeightTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.rowHeightTextBox.Name = "rowHeightTextBox";
            this.rowHeightTextBox.Size = new System.Drawing.Size(224, 20);
            this.rowHeightTextBox.TabIndex = 84;
            // 
            // rowHeightLabel
            // 
            this.rowHeightLabel.AutoSize = true;
            this.rowHeightLabel.Location = new System.Drawing.Point(12, 9);
            this.rowHeightLabel.Name = "rowHeightLabel";
            this.rowHeightLabel.Size = new System.Drawing.Size(64, 13);
            this.rowHeightLabel.TabIndex = 87;
            resources.ApplyResources(this.rowHeightLabel, "rowHeightLabel");
            // 
            // columnWidthLabel
            // 
            this.columnWidthLabel.AutoSize = true;
            this.columnWidthLabel.Location = new System.Drawing.Point(12, 55);
            this.columnWidthLabel.Name = "columnWidthLabel";
            this.columnWidthLabel.Size = new System.Drawing.Size(73, 13);
            this.columnWidthLabel.TabIndex = 89;
            resources.ApplyResources(this.columnWidthLabel, "columnWidthLabel");
            // 
            // columnWidthTextBox
            // 
            this.columnWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnWidthTextBox.Location = new System.Drawing.Point(15, 71);
            this.columnWidthTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.columnWidthTextBox.Name = "columnWidthTextBox";
            this.columnWidthTextBox.Size = new System.Drawing.Size(224, 20);
            this.columnWidthTextBox.TabIndex = 85;
            // 
            // rowAutoHeightCheckBox
            // 
            this.rowAutoHeightCheckBox.AutoSize = true;
            this.rowAutoHeightCheckBox.Location = new System.Drawing.Point(15, 104);
            this.rowAutoHeightCheckBox.Name = "rowAutoHeightCheckBox";
            this.rowAutoHeightCheckBox.Size = new System.Drawing.Size(104, 17);
            this.rowAutoHeightCheckBox.TabIndex = 92;
            resources.ApplyResources(this.rowAutoHeightCheckBox, "rowAutoHeightCheckBox");
            this.rowAutoHeightCheckBox.UseVisualStyleBackColor = true;
            // 
            // WorksheetFormatForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(251, 172);
            this.Controls.Add(this.rowAutoHeightCheckBox);
            this.Controls.Add(this.columnWidthLabel);
            this.Controls.Add(this.columnWidthTextBox);
            this.Controls.Add(this.rowHeightLabel);
            this.Controls.Add(this.rowHeightTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorksheetFormatForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox rowHeightTextBox;
        private System.Windows.Forms.Label rowHeightLabel;
        private System.Windows.Forms.Label columnWidthLabel;
        private System.Windows.Forms.TextBox columnWidthTextBox;
        private System.Windows.Forms.CheckBox rowAutoHeightCheckBox;
    }
}