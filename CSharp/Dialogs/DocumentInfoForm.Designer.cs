
namespace SpreadsheetEditorDemo
{
    partial class DocumentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentInfoForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.creatorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.managerLabel = new System.Windows.Forms.Label();
            this.managerTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.keywordsLabel = new System.Windows.Forms.Label();
            this.keywordsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.hyperlinkBaseLabel = new System.Windows.Forms.Label();
            this.hyperlinkBaseTextBox = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.printedLabel = new System.Windows.Forms.Label();
            this.printedTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedByLabel = new System.Windows.Forms.Label();
            this.lastModifiedByTextBox = new System.Windows.Forms.TextBox();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.applicationTextBox = new System.Windows.Forms.TextBox();
            this.applicationVersionLabel = new System.Windows.Forms.Label();
            this.applicationVersionTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(398, 418);
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
            this.buttonOk.Location = new System.Drawing.Point(317, 418);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // creatorTextBox
            // 
            this.creatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creatorTextBox.Location = new System.Drawing.Point(108, 55);
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.Size = new System.Drawing.Size(350, 20);
            this.creatorTextBox.TabIndex = 88;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(108, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(350, 20);
            this.titleTextBox.TabIndex = 84;
            // 
            // creatorLabel
            // 
            this.creatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(3, 58);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(44, 13);
            this.creatorLabel.TabIndex = 86;
            resources.ApplyResources(this.creatorLabel, "creatorLabel");
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 87;
            resources.ApplyResources(this.titleLabel, "titleLabel");
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(3, 32);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 89;
            resources.ApplyResources(this.subjectLabel, "subjectLabel");
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(108, 29);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(350, 20);
            this.subjectTextBox.TabIndex = 85;
            // 
            // managerLabel
            // 
            this.managerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(3, 84);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(52, 13);
            this.managerLabel.TabIndex = 91;
            resources.ApplyResources(this.managerLabel, "managerLabel");
            // 
            // managerTextBox
            // 
            this.managerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerTextBox.Location = new System.Drawing.Point(108, 81);
            this.managerTextBox.Name = "managerTextBox";
            this.managerTextBox.Size = new System.Drawing.Size(350, 20);
            this.managerTextBox.TabIndex = 90;
            // 
            // companyLabel
            // 
            this.companyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(3, 110);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(54, 13);
            this.companyLabel.TabIndex = 93;
            resources.ApplyResources(this.companyLabel, "companyLabel");
            // 
            // companyTextBox
            // 
            this.companyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyTextBox.Location = new System.Drawing.Point(108, 107);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(350, 20);
            this.companyTextBox.TabIndex = 92;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 136);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 95;
            resources.ApplyResources(this.categoryLabel, "categoryLabel");
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(108, 133);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(350, 20);
            this.categoryTextBox.TabIndex = 94;
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Location = new System.Drawing.Point(3, 162);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.keywordsLabel.TabIndex = 97;
            resources.ApplyResources(this.keywordsLabel, "keywordsLabel");
            // 
            // keywordsTextBox
            // 
            this.keywordsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordsTextBox.Location = new System.Drawing.Point(108, 159);
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.Size = new System.Drawing.Size(350, 20);
            this.keywordsTextBox.TabIndex = 96;
            // 
            // commentsLabel
            // 
            this.commentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(3, 188);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(59, 13);
            this.commentsLabel.TabIndex = 99;
            resources.ApplyResources(this.commentsLabel, "commentsLabel");
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsTextBox.Location = new System.Drawing.Point(108, 185);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(350, 20);
            this.commentsTextBox.TabIndex = 98;
            // 
            // hyperlinkBaseLabel
            // 
            this.hyperlinkBaseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hyperlinkBaseLabel.AutoSize = true;
            this.hyperlinkBaseLabel.Location = new System.Drawing.Point(3, 214);
            this.hyperlinkBaseLabel.Name = "hyperlinkBaseLabel";
            this.hyperlinkBaseLabel.Size = new System.Drawing.Size(80, 13);
            this.hyperlinkBaseLabel.TabIndex = 101;
            resources.ApplyResources(this.hyperlinkBaseLabel, "hyperlinkBaseLabel");
            // 
            // hyperlinkBaseTextBox
            // 
            this.hyperlinkBaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperlinkBaseTextBox.Location = new System.Drawing.Point(108, 211);
            this.hyperlinkBaseTextBox.Name = "hyperlinkBaseTextBox";
            this.hyperlinkBaseTextBox.Size = new System.Drawing.Size(350, 20);
            this.hyperlinkBaseTextBox.TabIndex = 100;
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(3, 240);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 103;
            resources.ApplyResources(this.createdLabel, "createdLabel");
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Enabled = false;
            this.createdTextBox.Location = new System.Drawing.Point(108, 237);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.Size = new System.Drawing.Size(350, 20);
            this.createdTextBox.TabIndex = 102;
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(3, 266);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedLabel.TabIndex = 105;
            resources.ApplyResources(this.modifiedLabel, "modifiedLabel");
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedTextBox.Enabled = false;
            this.modifiedTextBox.Location = new System.Drawing.Point(108, 263);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.Size = new System.Drawing.Size(350, 20);
            this.modifiedTextBox.TabIndex = 104;
            // 
            // printedLabel
            // 
            this.printedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.printedLabel.AutoSize = true;
            this.printedLabel.Location = new System.Drawing.Point(3, 292);
            this.printedLabel.Name = "printedLabel";
            this.printedLabel.Size = new System.Drawing.Size(43, 13);
            this.printedLabel.TabIndex = 107;
            resources.ApplyResources(this.printedLabel, "printedLabel");
            // 
            // printedTextBox
            // 
            this.printedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printedTextBox.Enabled = false;
            this.printedTextBox.Location = new System.Drawing.Point(108, 289);
            this.printedTextBox.Name = "printedTextBox";
            this.printedTextBox.Size = new System.Drawing.Size(350, 20);
            this.printedTextBox.TabIndex = 106;
            // 
            // lastModifiedByLabel
            // 
            this.lastModifiedByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastModifiedByLabel.AutoSize = true;
            this.lastModifiedByLabel.Location = new System.Drawing.Point(3, 318);
            this.lastModifiedByLabel.Name = "lastModifiedByLabel";
            this.lastModifiedByLabel.Size = new System.Drawing.Size(86, 13);
            this.lastModifiedByLabel.TabIndex = 109;
            resources.ApplyResources(this.lastModifiedByLabel, "lastModifiedByLabel");
            // 
            // lastModifiedByTextBox
            // 
            this.lastModifiedByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastModifiedByTextBox.Enabled = false;
            this.lastModifiedByTextBox.Location = new System.Drawing.Point(108, 315);
            this.lastModifiedByTextBox.Name = "lastModifiedByTextBox";
            this.lastModifiedByTextBox.Size = new System.Drawing.Size(350, 20);
            this.lastModifiedByTextBox.TabIndex = 108;
            // 
            // applicationLabel
            // 
            this.applicationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(3, 344);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(62, 13);
            this.applicationLabel.TabIndex = 113;
            resources.ApplyResources(this.applicationLabel, "applicationLabel");
            // 
            // applicationTextBox
            // 
            this.applicationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationTextBox.Enabled = false;
            this.applicationTextBox.Location = new System.Drawing.Point(108, 341);
            this.applicationTextBox.Name = "applicationTextBox";
            this.applicationTextBox.Size = new System.Drawing.Size(350, 20);
            this.applicationTextBox.TabIndex = 112;
            // 
            // applicationVersionLabel
            // 
            this.applicationVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.applicationVersionLabel.AutoSize = true;
            this.applicationVersionLabel.Location = new System.Drawing.Point(3, 370);
            this.applicationVersionLabel.Name = "applicationVersionLabel";
            this.applicationVersionLabel.Size = new System.Drawing.Size(99, 13);
            this.applicationVersionLabel.TabIndex = 115;
            resources.ApplyResources(this.applicationVersionLabel, "applicationVersionLabel");
            // 
            // applicationVersionTextBox
            // 
            this.applicationVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationVersionTextBox.Enabled = false;
            this.applicationVersionTextBox.Location = new System.Drawing.Point(108, 367);
            this.applicationVersionTextBox.Name = "applicationVersionTextBox";
            this.applicationVersionTextBox.Size = new System.Drawing.Size(350, 20);
            this.applicationVersionTextBox.TabIndex = 114;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.applicationVersionTextBox, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.applicationVersionLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.subjectLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.applicationLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.subjectTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.applicationTextBox, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.creatorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastModifiedByLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.creatorTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastModifiedByTextBox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.managerLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.printedLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.managerTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.printedTextBox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.companyLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.modifiedLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.companyTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.modifiedTextBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.createdLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.createdTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.keywordsTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.hyperlinkBaseLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.keywordsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.hyperlinkBaseTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.commentsTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.commentsLabel, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 400);
            this.tableLayoutPanel1.TabIndex = 116;
            // 
            // DocumentInfoForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(485, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            resources.ApplyResources(this, "$this");
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox creatorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.TextBox managerTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label keywordsLabel;
        private System.Windows.Forms.TextBox keywordsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label hyperlinkBaseLabel;
        private System.Windows.Forms.TextBox hyperlinkBaseTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.TextBox modifiedTextBox;
        private System.Windows.Forms.Label printedLabel;
        private System.Windows.Forms.TextBox printedTextBox;
        private System.Windows.Forms.Label lastModifiedByLabel;
        private System.Windows.Forms.TextBox lastModifiedByTextBox;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.TextBox applicationTextBox;
        private System.Windows.Forms.Label applicationVersionLabel;
        private System.Windows.Forms.TextBox applicationVersionTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}