
namespace SpreadsheetEditorDemo
{
    partial class FormulaPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cellValueTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cellsReferenceComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.buttonCancel = new System.Windows.Forms.ToolStripButton();
            this.buttonOk = new System.Windows.Forms.ToolStripButton();
            this.insertFunctionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellValueTextBox
            // 
            this.cellValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cellValueTextBox.Location = new System.Drawing.Point(225, 2);
            this.cellValueTextBox.Name = "cellValueTextBox";
            this.cellValueTextBox.Size = new System.Drawing.Size(335, 20);
            this.cellValueTextBox.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellsReferenceComboBox,
            this.buttonCancel,
            this.buttonOk,
            this.insertFunctionToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(222, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cellsReferenceComboBox
            // 
            this.cellsReferenceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cellsReferenceComboBox.Name = "cellsReferenceComboBox";
            this.cellsReferenceComboBox.Size = new System.Drawing.Size(121, 25);
            this.cellsReferenceComboBox.ToolTipText = "Focused Cell Name";
            this.cellsReferenceComboBox.SelectedIndexChanged += new System.EventHandler(this.cellsReferenceComboBox_SelectedIndexChanged);
            this.cellsReferenceComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellsReferenceComboBox_KeyDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = false;
            this.buttonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancel.Image = global::SpreadsheetEditorDemo.Properties.Resources.FocusedCellValuePanel_Cancel;
            this.buttonCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(30, 22);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.AutoSize = false;
            this.buttonOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOk.Image = global::SpreadsheetEditorDemo.Properties.Resources.FocusedCellValuePanel_Ok;
            this.buttonOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(30, 22);
            this.buttonOk.Text = "Enter";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // insertFunctionToolStripButton
            // 
            this.insertFunctionToolStripButton.AutoSize = false;
            this.insertFunctionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertFunctionToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.FocusedCellValuePanel_Function;
            this.insertFunctionToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertFunctionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertFunctionToolStripButton.Name = "insertFunctionToolStripButton";
            this.insertFunctionToolStripButton.Size = new System.Drawing.Size(30, 22);
            this.insertFunctionToolStripButton.Text = "Insert Function";
            this.insertFunctionToolStripButton.Click += new System.EventHandler(this.insertFunctionButton_Click);
            // 
            // FormulaPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cellValueTextBox);
            this.Name = "FormulaPanel";
            this.Size = new System.Drawing.Size(561, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cellValueTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cellsReferenceComboBox;
        private System.Windows.Forms.ToolStripButton buttonCancel;
        private System.Windows.Forms.ToolStripButton buttonOk;
        private System.Windows.Forms.ToolStripButton insertFunctionToolStripButton;
    }
}