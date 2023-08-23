
namespace SpreadsheetEditorDemo
{
    partial class RenameWorksheetForm
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
            this.worksheetNameLabel = new System.Windows.Forms.Label();
            this.worksheetNameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worksheetNameLabel
            // 
            this.worksheetNameLabel.AutoSize = true;
            this.worksheetNameLabel.Location = new System.Drawing.Point(12, 9);
            this.worksheetNameLabel.Name = "worksheetNameLabel";
            this.worksheetNameLabel.Size = new System.Drawing.Size(93, 13);
            this.worksheetNameLabel.TabIndex = 0;
            this.worksheetNameLabel.Text = "Worksheet Name:";
            // 
            // worksheetNameTextBox
            // 
            this.worksheetNameTextBox.Location = new System.Drawing.Point(15, 25);
            this.worksheetNameTextBox.Name = "worksheetNameTextBox";
            this.worksheetNameTextBox.Size = new System.Drawing.Size(369, 20);
            this.worksheetNameTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(190, 59);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(290, 59);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // RenameWorksheetForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(399, 94);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.worksheetNameTextBox);
            this.Controls.Add(this.worksheetNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameWorksheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename Worksheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label worksheetNameLabel;
        private System.Windows.Forms.TextBox worksheetNameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
    }
}