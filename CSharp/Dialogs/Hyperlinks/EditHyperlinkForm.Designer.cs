
namespace SpreadsheetEditorDemo
{
    partial class EditHyperlinkForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.hyperlinkTabControl = new System.Windows.Forms.TabControl();
            this.addressTabPage = new System.Windows.Forms.TabPage();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.referenceTabPage = new System.Windows.Forms.TabPage();
            this.sheetLabel = new System.Windows.Forms.Label();
            this.sheetComboBox = new System.Windows.Forms.ComboBox();
            this.cellReferenceLabel = new System.Windows.Forms.Label();
            this.cellReferenceTextBox = new System.Windows.Forms.TextBox();
            this.nameTabPage = new System.Windows.Forms.TabPage();
            this.definedNamesLabel = new System.Windows.Forms.Label();
            this.definedNamesListBox = new System.Windows.Forms.ListBox();
            this.hyperlinkTabControl.SuspendLayout();
            this.addressTabPage.SuspendLayout();
            this.referenceTabPage.SuspendLayout();
            this.nameTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(237, 213);
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
            this.buttonOk.Location = new System.Drawing.Point(156, 213);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // hyperlinkTabControl
            // 
            this.hyperlinkTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperlinkTabControl.Controls.Add(this.addressTabPage);
            this.hyperlinkTabControl.Controls.Add(this.referenceTabPage);
            this.hyperlinkTabControl.Controls.Add(this.nameTabPage);
            this.hyperlinkTabControl.Location = new System.Drawing.Point(0, 0);
            this.hyperlinkTabControl.Name = "hyperlinkTabControl";
            this.hyperlinkTabControl.SelectedIndex = 0;
            this.hyperlinkTabControl.Size = new System.Drawing.Size(324, 204);
            this.hyperlinkTabControl.TabIndex = 84;
            // 
            // addressTabPage
            // 
            this.addressTabPage.Controls.Add(this.addressLabel);
            this.addressTabPage.Controls.Add(this.addressTextBox);
            this.addressTabPage.Location = new System.Drawing.Point(4, 22);
            this.addressTabPage.Name = "addressTabPage";
            this.addressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addressTabPage.Size = new System.Drawing.Size(316, 178);
            this.addressTabPage.TabIndex = 0;
            this.addressTabPage.Text = "Existing File or Web Page";
            this.addressTabPage.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(9, 7);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(7, 25);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 20);
            this.addressTextBox.TabIndex = 0;
            // 
            // referenceTabPage
            // 
            this.referenceTabPage.Controls.Add(this.sheetLabel);
            this.referenceTabPage.Controls.Add(this.sheetComboBox);
            this.referenceTabPage.Controls.Add(this.cellReferenceLabel);
            this.referenceTabPage.Controls.Add(this.cellReferenceTextBox);
            this.referenceTabPage.Location = new System.Drawing.Point(4, 22);
            this.referenceTabPage.Name = "referenceTabPage";
            this.referenceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.referenceTabPage.Size = new System.Drawing.Size(316, 178);
            this.referenceTabPage.TabIndex = 1;
            this.referenceTabPage.Text = "Cell Reference";
            this.referenceTabPage.UseVisualStyleBackColor = true;
            // 
            // sheetLabel
            // 
            this.sheetLabel.AutoSize = true;
            this.sheetLabel.Location = new System.Drawing.Point(9, 53);
            this.sheetLabel.Name = "sheetLabel";
            this.sheetLabel.Size = new System.Drawing.Size(38, 13);
            this.sheetLabel.TabIndex = 7;
            this.sheetLabel.Text = "Sheet:";
            // 
            // sheetComboBox
            // 
            this.sheetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetComboBox.FormattingEnabled = true;
            this.sheetComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sheetComboBox.Location = new System.Drawing.Point(7, 71);
            this.sheetComboBox.Name = "sheetComboBox";
            this.sheetComboBox.Size = new System.Drawing.Size(301, 21);
            this.sheetComboBox.TabIndex = 6;
            // 
            // cellReferenceLabel
            // 
            this.cellReferenceLabel.AutoSize = true;
            this.cellReferenceLabel.Location = new System.Drawing.Point(9, 7);
            this.cellReferenceLabel.Name = "cellReferenceLabel";
            this.cellReferenceLabel.Size = new System.Drawing.Size(80, 13);
            this.cellReferenceLabel.TabIndex = 3;
            this.cellReferenceLabel.Text = "Cell Reference:";
            // 
            // cellReferenceTextBox
            // 
            this.cellReferenceTextBox.Location = new System.Drawing.Point(7, 25);
            this.cellReferenceTextBox.Name = "cellReferenceTextBox";
            this.cellReferenceTextBox.Size = new System.Drawing.Size(301, 20);
            this.cellReferenceTextBox.TabIndex = 2;
            // 
            // nameTabPage
            // 
            this.nameTabPage.Controls.Add(this.definedNamesLabel);
            this.nameTabPage.Controls.Add(this.definedNamesListBox);
            this.nameTabPage.Location = new System.Drawing.Point(4, 22);
            this.nameTabPage.Name = "nameTabPage";
            this.nameTabPage.Size = new System.Drawing.Size(316, 178);
            this.nameTabPage.TabIndex = 2;
            this.nameTabPage.Text = "Defined Name";
            this.nameTabPage.UseVisualStyleBackColor = true;
            // 
            // definedNamesLabel
            // 
            this.definedNamesLabel.AutoSize = true;
            this.definedNamesLabel.Location = new System.Drawing.Point(9, 7);
            this.definedNamesLabel.Name = "definedNamesLabel";
            this.definedNamesLabel.Size = new System.Drawing.Size(83, 13);
            this.definedNamesLabel.TabIndex = 7;
            this.definedNamesLabel.Text = "Defined Names:";
            // 
            // definedNamesListBox
            // 
            this.definedNamesListBox.FormattingEnabled = true;
            this.definedNamesListBox.Location = new System.Drawing.Point(7, 25);
            this.definedNamesListBox.Name = "definedNamesListBox";
            this.definedNamesListBox.Size = new System.Drawing.Size(301, 134);
            this.definedNamesListBox.TabIndex = 6;
            // 
            // EditHyperlinkForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(324, 248);
            this.Controls.Add(this.hyperlinkTabControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditHyperlinkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Hyperlink";
            this.hyperlinkTabControl.ResumeLayout(false);
            this.addressTabPage.ResumeLayout(false);
            this.addressTabPage.PerformLayout();
            this.referenceTabPage.ResumeLayout(false);
            this.referenceTabPage.PerformLayout();
            this.nameTabPage.ResumeLayout(false);
            this.nameTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl hyperlinkTabControl;
        private System.Windows.Forms.TabPage addressTabPage;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TabPage referenceTabPage;
        private System.Windows.Forms.Label cellReferenceLabel;
        private System.Windows.Forms.TextBox cellReferenceTextBox;
        private System.Windows.Forms.Label sheetLabel;
        private System.Windows.Forms.ComboBox sheetComboBox;
        private System.Windows.Forms.TabPage nameTabPage;
        private System.Windows.Forms.ListBox definedNamesListBox;
        private System.Windows.Forms.Label definedNamesLabel;
    }
}