
namespace SpreadsheetEditorDemo
{
    partial class SelectDefinedNameForm
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
            this.namesLabel = new System.Windows.Forms.Label();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Location = new System.Drawing.Point(12, 9);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(43, 13);
            this.namesLabel.TabIndex = 0;
            this.namesLabel.Text = "Names:";
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(15, 25);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(298, 225);
            this.namesListBox.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(219, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(119, 256);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectDefinedNameForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(329, 291);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.namesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDefinedNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Defined Name List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
    }
}