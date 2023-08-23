
namespace SpreadsheetEditorDemo
{
    partial class CellPasteSpecialForm
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
            this.copyStylesCheckBox = new System.Windows.Forms.CheckBox();
            this.copyValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.copyFormulasCheckBox = new System.Windows.Forms.CheckBox();
            this.copyCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.copyHyperlinksCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copyStylesCheckBox
            // 
            this.copyStylesCheckBox.AutoSize = true;
            this.copyStylesCheckBox.Checked = true;
            this.copyStylesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyStylesCheckBox.Location = new System.Drawing.Point(12, 10);
            this.copyStylesCheckBox.Name = "copyStylesCheckBox";
            this.copyStylesCheckBox.Size = new System.Drawing.Size(81, 17);
            this.copyStylesCheckBox.TabIndex = 1;
            this.copyStylesCheckBox.Text = "Copy Styles";
            this.copyStylesCheckBox.UseVisualStyleBackColor = true;
            this.copyStylesCheckBox.CheckedChanged += new System.EventHandler(this.copyActionCheckBox_CheckedChanged);
            // 
            // copyValuesCheckBox
            // 
            this.copyValuesCheckBox.AutoSize = true;
            this.copyValuesCheckBox.Checked = true;
            this.copyValuesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyValuesCheckBox.Location = new System.Drawing.Point(12, 33);
            this.copyValuesCheckBox.Name = "copyValuesCheckBox";
            this.copyValuesCheckBox.Size = new System.Drawing.Size(85, 17);
            this.copyValuesCheckBox.TabIndex = 2;
            this.copyValuesCheckBox.Text = "Copy Values";
            this.copyValuesCheckBox.UseVisualStyleBackColor = true;
            this.copyValuesCheckBox.CheckedChanged += new System.EventHandler(this.copyActionCheckBox_CheckedChanged);
            // 
            // copyFormulasCheckBox
            // 
            this.copyFormulasCheckBox.AutoSize = true;
            this.copyFormulasCheckBox.Checked = true;
            this.copyFormulasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyFormulasCheckBox.Location = new System.Drawing.Point(12, 56);
            this.copyFormulasCheckBox.Name = "copyFormulasCheckBox";
            this.copyFormulasCheckBox.Size = new System.Drawing.Size(95, 17);
            this.copyFormulasCheckBox.TabIndex = 3;
            this.copyFormulasCheckBox.Text = "Copy Formulas";
            this.copyFormulasCheckBox.UseVisualStyleBackColor = true;
            this.copyFormulasCheckBox.CheckedChanged += new System.EventHandler(this.copyActionCheckBox_CheckedChanged);
            // 
            // copyCommentsCheckBox
            // 
            this.copyCommentsCheckBox.AutoSize = true;
            this.copyCommentsCheckBox.Checked = true;
            this.copyCommentsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyCommentsCheckBox.Location = new System.Drawing.Point(12, 79);
            this.copyCommentsCheckBox.Name = "copyCommentsCheckBox";
            this.copyCommentsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.copyCommentsCheckBox.TabIndex = 4;
            this.copyCommentsCheckBox.Text = "Copy Comments";
            this.copyCommentsCheckBox.UseVisualStyleBackColor = true;
            this.copyCommentsCheckBox.CheckedChanged += new System.EventHandler(this.copyActionCheckBox_CheckedChanged);
            // 
            // copyHyperlinksCheckBox
            // 
            this.copyHyperlinksCheckBox.AutoSize = true;
            this.copyHyperlinksCheckBox.Checked = true;
            this.copyHyperlinksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyHyperlinksCheckBox.Location = new System.Drawing.Point(12, 102);
            this.copyHyperlinksCheckBox.Name = "copyHyperlinksCheckBox";
            this.copyHyperlinksCheckBox.Size = new System.Drawing.Size(102, 17);
            this.copyHyperlinksCheckBox.TabIndex = 5;
            this.copyHyperlinksCheckBox.Text = "Copy Hyperlinks";
            this.copyHyperlinksCheckBox.UseVisualStyleBackColor = true;
            this.copyHyperlinksCheckBox.CheckedChanged += new System.EventHandler(this.copyActionCheckBox_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(157, 133);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(57, 133);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CellPasteSpecialForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(320, 168);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.copyHyperlinksCheckBox);
            this.Controls.Add(this.copyCommentsCheckBox);
            this.Controls.Add(this.copyFormulasCheckBox);
            this.Controls.Add(this.copyValuesCheckBox);
            this.Controls.Add(this.copyStylesCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellPasteSpecialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paste Cells (Special Mode)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox copyStylesCheckBox;
        private System.Windows.Forms.CheckBox copyValuesCheckBox;
        private System.Windows.Forms.CheckBox copyFormulasCheckBox;
        private System.Windows.Forms.CheckBox copyCommentsCheckBox;
        private System.Windows.Forms.CheckBox copyHyperlinksCheckBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button okButton;
    }
}