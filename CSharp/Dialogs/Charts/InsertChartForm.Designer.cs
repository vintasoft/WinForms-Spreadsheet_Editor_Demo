
namespace SpreadsheetEditorDemo
{
    partial class InsertChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertChartForm));
            this.chartTypeListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartViewer = new Vintasoft.Imaging.Office.Spreadsheet.UI.SpreadsheetEditorControl();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.chartSubtypeListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTypeListBox
            // 
            this.chartTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartTypeListBox.FormattingEnabled = true;
            this.chartTypeListBox.ItemHeight = 16;
            this.chartTypeListBox.Location = new System.Drawing.Point(12, 10);
            this.chartTypeListBox.Name = "chartTypeListBox";
            this.chartTypeListBox.Size = new System.Drawing.Size(280, 180);
            this.chartTypeListBox.TabIndex = 0;
            this.chartTypeListBox.SelectedIndexChanged += new System.EventHandler(this.chartTypeListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chartViewer);
            this.panel1.Location = new System.Drawing.Point(298, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 622);
            this.panel1.TabIndex = 3;
            // 
            // chartViewer
            // 
            this.chartViewer.CellCursor = System.Windows.Forms.Cursors.Cross;
            this.chartViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartViewer.HyperlinkCursor = System.Windows.Forms.Cursors.Hand;
            this.chartViewer.Location = new System.Drawing.Point(0, 0);
            this.chartViewer.MoveCursor = System.Windows.Forms.Cursors.SizeAll;
            this.chartViewer.Name = "chartViewer";
            this.chartViewer.PanningCursor = System.Windows.Forms.Cursors.SizeAll;
            this.chartViewer.ResizeColumnCursor = System.Windows.Forms.Cursors.SizeWE;
            this.chartViewer.ResizeCursorNESW = System.Windows.Forms.Cursors.SizeNESW;
            this.chartViewer.ResizeCursorNS = System.Windows.Forms.Cursors.SizeNS;
            this.chartViewer.ResizeCursorNWSE = System.Windows.Forms.Cursors.SizeNWSE;
            this.chartViewer.ResizeCursorWE = System.Windows.Forms.Cursors.SizeWE;
            this.chartViewer.ResizeRowCursor = System.Windows.Forms.Cursors.SizeNS;
            this.chartViewer.SelectAllCursor = System.Windows.Forms.Cursors.PanSE;
            this.chartViewer.SelectColumnCursor = System.Windows.Forms.Cursors.PanSouth;
            this.chartViewer.SelectRowCursor = System.Windows.Forms.Cursors.PanEast;
            this.chartViewer.Size = new System.Drawing.Size(552, 620);
            this.chartViewer.TabIndex = 2;
            this.chartViewer.Text = "spreadsheetEditorControl1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(777, 639);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(696, 639);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // chartSubtypeListBox
            // 
            this.chartSubtypeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartSubtypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartSubtypeListBox.FormattingEnabled = true;
            this.chartSubtypeListBox.Location = new System.Drawing.Point(12, 196);
            this.chartSubtypeListBox.Name = "chartSubtypeListBox";
            this.chartSubtypeListBox.Size = new System.Drawing.Size(280, 433);
            this.chartSubtypeListBox.TabIndex = 6;
            this.chartSubtypeListBox.SelectedIndexChanged += new System.EventHandler(this.chartSubtypeListBox_SelectedIndexChanged);
            // 
            // InsertChartForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(864, 674);
            this.Controls.Add(this.chartSubtypeListBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartTypeListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            resources.ApplyResources(this, "$this");
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox chartTypeListBox;
        private Vintasoft.Imaging.Office.Spreadsheet.UI.SpreadsheetEditorControl chartViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ListBox chartSubtypeListBox;
    }
}