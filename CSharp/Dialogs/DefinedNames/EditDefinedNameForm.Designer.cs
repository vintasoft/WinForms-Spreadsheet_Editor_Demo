
namespace SpreadsheetEditorDemo
{
    partial class EditDefinedNameForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.scopeLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.refersToLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.scopeComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.refersToTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // scopeLabel
            // 
            this.scopeLabel.AutoSize = true;
            this.scopeLabel.Location = new System.Drawing.Point(12, 42);
            this.scopeLabel.Name = "scopeLabel";
            this.scopeLabel.Size = new System.Drawing.Size(41, 13);
            this.scopeLabel.TabIndex = 1;
            this.scopeLabel.Text = "Scope:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(12, 68);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(54, 13);
            this.commentLabel.TabIndex = 2;
            this.commentLabel.Text = "Comment:";
            // 
            // refersToLabel
            // 
            this.refersToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refersToLabel.AutoSize = true;
            this.refersToLabel.Location = new System.Drawing.Point(12, 172);
            this.refersToLabel.Name = "refersToLabel";
            this.refersToLabel.Size = new System.Drawing.Size(37, 13);
            this.refersToLabel.TabIndex = 3;
            this.refersToLabel.Text = "Value:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(82, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(355, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // scopeComboBox
            // 
            this.scopeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scopeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scopeComboBox.FormattingEnabled = true;
            this.scopeComboBox.Location = new System.Drawing.Point(82, 38);
            this.scopeComboBox.Name = "scopeComboBox";
            this.scopeComboBox.Size = new System.Drawing.Size(355, 21);
            this.scopeComboBox.TabIndex = 5;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Location = new System.Drawing.Point(82, 65);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(355, 97);
            this.commentTextBox.TabIndex = 6;
            // 
            // refersToTextBox
            // 
            this.refersToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refersToTextBox.Location = new System.Drawing.Point(82, 168);
            this.refersToTextBox.Name = "refersToTextBox";
            this.refersToTextBox.Size = new System.Drawing.Size(356, 20);
            this.refersToTextBox.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(343, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(243, 198);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // EditDefinedNameForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(449, 233);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.refersToTextBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.scopeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.refersToLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.scopeLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "EditDefinedNameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Defined Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scopeLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label refersToLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox scopeComboBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox refersToTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
    }
}