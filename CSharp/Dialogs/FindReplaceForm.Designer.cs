
namespace SpreadsheetEditorDemo
{
    partial class FindReplaceForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceCheckBox = new System.Windows.Forms.CheckBox();
            this.findWhatComboBox = new System.Windows.Forms.ComboBox();
            this.replaceWithComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findWithinComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.matchContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.lookInComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.findNextButton = new System.Windows.Forms.Button();
            this.findAllButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addToSelectionButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(421, 190);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find what:";
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(7, 39);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(72, 13);
            this.replaceLabel.TabIndex = 2;
            this.replaceLabel.Text = "Replace with:";
            // 
            // replaceCheckBox
            // 
            this.replaceCheckBox.AutoSize = true;
            this.replaceCheckBox.Location = new System.Drawing.Point(6, 7);
            this.replaceCheckBox.Name = "replaceCheckBox";
            this.replaceCheckBox.Size = new System.Drawing.Size(66, 17);
            this.replaceCheckBox.TabIndex = 3;
            this.replaceCheckBox.Text = "Replace";
            this.replaceCheckBox.UseVisualStyleBackColor = true;
            this.replaceCheckBox.CheckedChanged += new System.EventHandler(this.replaceCheckBox_CheckedChanged);
            // 
            // findWhatComboBox
            // 
            this.findWhatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findWhatComboBox.FormattingEnabled = true;
            this.findWhatComboBox.Location = new System.Drawing.Point(90, 9);
            this.findWhatComboBox.Name = "findWhatComboBox";
            this.findWhatComboBox.Size = new System.Drawing.Size(390, 21);
            this.findWhatComboBox.TabIndex = 4;
            this.findWhatComboBox.TextChanged += new System.EventHandler(this.findWhatComboBox_TextChanged);
            // 
            // replaceWithComboBox
            // 
            this.replaceWithComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceWithComboBox.FormattingEnabled = true;
            this.replaceWithComboBox.Location = new System.Drawing.Point(90, 36);
            this.replaceWithComboBox.Name = "replaceWithComboBox";
            this.replaceWithComboBox.Size = new System.Drawing.Size(390, 21);
            this.replaceWithComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Within:";
            // 
            // findWithinComboBox
            // 
            this.findWithinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findWithinComboBox.FormattingEnabled = true;
            this.findWithinComboBox.Items.AddRange(new object[] {
            "Sheet",
            "Workbook"});
            this.findWithinComboBox.Location = new System.Drawing.Point(90, 69);
            this.findWithinComboBox.Name = "findWithinComboBox";
            this.findWithinComboBox.Size = new System.Drawing.Size(121, 21);
            this.findWithinComboBox.TabIndex = 8;
            this.findWithinComboBox.SelectedIndexChanged += new System.EventHandler(this.findWithinComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "By Rows",
            "By Columns"});
            this.searchComboBox.Location = new System.Drawing.Point(90, 96);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 10;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(230, 71);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.matchCaseCheckBox.TabIndex = 11;
            this.matchCaseCheckBox.Text = "Match case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchContentsCheckBox
            // 
            this.matchContentsCheckBox.AutoSize = true;
            this.matchContentsCheckBox.Location = new System.Drawing.Point(230, 98);
            this.matchContentsCheckBox.Name = "matchContentsCheckBox";
            this.matchContentsCheckBox.Size = new System.Drawing.Size(124, 17);
            this.matchContentsCheckBox.TabIndex = 13;
            this.matchContentsCheckBox.Text = "Match entire content";
            this.matchContentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lookInComboBox
            // 
            this.lookInComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lookInComboBox.FormattingEnabled = true;
            this.lookInComboBox.Items.AddRange(new object[] {
            "Formulas",
            "Values",
            "Comments"});
            this.lookInComboBox.Location = new System.Drawing.Point(90, 123);
            this.lookInComboBox.Name = "lookInComboBox";
            this.lookInComboBox.Size = new System.Drawing.Size(121, 21);
            this.lookInComboBox.TabIndex = 15;
            this.lookInComboBox.SelectedIndexChanged += new System.EventHandler(this.lookInComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Look in:";
            // 
            // findNextButton
            // 
            this.findNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findNextButton.Location = new System.Drawing.Point(315, 190);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(75, 23);
            this.findNextButton.TabIndex = 16;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // findAllButton
            // 
            this.findAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findAllButton.Location = new System.Drawing.Point(234, 190);
            this.findAllButton.Name = "findAllButton";
            this.findAllButton.Size = new System.Drawing.Size(75, 23);
            this.findAllButton.TabIndex = 17;
            this.findAllButton.Text = "Find All";
            this.findAllButton.UseVisualStyleBackColor = true;
            this.findAllButton.Click += new System.EventHandler(this.findAllButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.matchContentsCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.replaceLabel);
            this.panel1.Controls.Add(this.lookInComboBox);
            this.panel1.Controls.Add(this.findWhatComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.replaceWithComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.findWithinComboBox);
            this.panel1.Controls.Add(this.matchCaseCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchComboBox);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 156);
            this.panel1.TabIndex = 18;
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(5, 190);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(75, 23);
            this.replaceAllButton.TabIndex = 20;
            this.replaceAllButton.Text = "Replace All";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            this.replaceAllButton.Click += new System.EventHandler(this.replaceAllButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(86, 190);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 19;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.addToSelectionButton);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.resultListView);
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 144);
            this.panel2.TabIndex = 21;
            // 
            // addToSelectionButton
            // 
            this.addToSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToSelectionButton.Location = new System.Drawing.Point(421, 117);
            this.addToSelectionButton.Name = "addToSelectionButton";
            this.addToSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.addToSelectionButton.TabIndex = 22;
            this.addToSelectionButton.Text = "Select All";
            this.addToSelectionButton.UseVisualStyleBackColor = true;
            this.addToSelectionButton.Click += new System.EventHandler(this.addToSelectionButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 122);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "statusLabel";
            // 
            // resultListView
            // 
            this.resultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.resultListView.FullRowSelect = true;
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(6, 0);
            this.resultListView.MultiSelect = false;
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(489, 114);
            this.resultListView.TabIndex = 1;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sheet";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cell";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Formula";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 100;
            // 
            // FindReplaceForm
            // 
            this.AcceptButton = this.findNextButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(501, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findAllButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.replaceCheckBox);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(476, 258);
            this.Name = "FindReplaceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find and Replace";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindReplaceForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.CheckBox replaceCheckBox;
        private System.Windows.Forms.ComboBox findWhatComboBox;
        private System.Windows.Forms.ComboBox replaceWithComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox findWithinComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.CheckBox matchContentsCheckBox;
        private System.Windows.Forms.ComboBox lookInComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findAllButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button replaceButton;
        internal System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Button addToSelectionButton;
    }
}