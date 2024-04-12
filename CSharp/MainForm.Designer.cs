
using Vintasoft.Imaging.Office.Spreadsheet.UI.Controls;

namespace SpreadsheetEditorDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveWorksheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openWorksheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.imagePrintDocument1 = new Vintasoft.Imaging.Print.ImagePrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentEditorControl = new Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.SpreadsheetDocumentEditorControl();
            this.spreadsheetCellContextMenu = new SpreadsheetEditorDemo.SpreadsheetCellContextMenu();
            this.spreadsheetCommentContextMenu = new SpreadsheetEditorDemo.SpreadsheetCommentContextMenu();
            this.spreadsheetDrawingContextMenu = new SpreadsheetEditorDemo.SpreadsheetDrawingContextMenu();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            resources.ApplyResources(this.statusLabel, "statusLabel");
            // 
            // saveWorksheetFileDialog
            // 
            this.saveWorksheetFileDialog.Filter = "XLSX files|*.xlsx";
            // 
            // openWorksheetFileDialog
            // 
            this.openWorksheetFileDialog.Filter = "XLSX files|*.xlsx|XLS files|*.xls|TSV files|*.tsv;*.tab|CSV files|*.csv|All suppo" +
    "rted Workbooks|*.xlsx;*.xls;*.tsv;*.tab;*.csv";
            this.openWorksheetFileDialog.FilterIndex = 5;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.imagePrintDocument1;
            // 
            // imagePrintDocument1
            // 
            this.imagePrintDocument1.Center = false;
            this.imagePrintDocument1.DistanceBetweenImages = 0;
            this.imagePrintDocument1.PrintScaleMode = Vintasoft.Imaging.Print.PrintScaleMode.None;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.imagePrintDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DocumentEditorControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 711);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DocumentEditorControl
            // 
            this.DocumentEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentEditorControl.Location = new System.Drawing.Point(0, 0);
            this.DocumentEditorControl.Margin = new System.Windows.Forms.Padding(0);
            this.DocumentEditorControl.Name = "DocumentEditorControl";
            this.DocumentEditorControl.Size = new System.Drawing.Size(1084, 689);
            this.DocumentEditorControl.TabIndex = 2;
            this.DocumentEditorControl.VisualEditorError += new System.EventHandler<Vintasoft.Imaging.ExceptionEventArgs>(this.SpreadsheetVisualEditorPanel_VisualEditorError);
            this.DocumentEditorControl.SetDefaultRowHeight += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_SetDefaultRowHeight);
            this.DocumentEditorControl.SetRowHeight += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_SetRowHeight);
            this.DocumentEditorControl.SetDefaultColumnWidth += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_SetDefaultColumnWidth);
            this.DocumentEditorControl.SetColumnWidth += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_SetColumnWidth);
            this.DocumentEditorControl.AddChart += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_AddChart);
            this.DocumentEditorControl.EditDrawing += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_EditDrawing);
            this.DocumentEditorControl.ImageStreamRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.StreamRequestEventArgs>(this.CellsEditorPanel_ImageStreamRequest);
            this.DocumentEditorControl.AddHyperlink += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_AddHyperlink);
            this.DocumentEditorControl.EditHyperlink += new System.EventHandler<System.EventArgs>(this.CellsEditorPanel_EditHyperlink);
            this.DocumentEditorControl.NewComment += new System.EventHandler<System.EventArgs>(this.CommentsPanel_NewComment);
            this.DocumentEditorControl.EditComment += new System.EventHandler<System.EventArgs>(this.CommentsPanel_EditComment);
            this.DocumentEditorControl.ShowCellPasteSpecial += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ActionRequestEventArgs>(this.CopyPastePanel_ShowCellPasteSpecial);
            this.DocumentEditorControl.InsertDefinedNameInFormula += new System.EventHandler<System.EventArgs>(this.DefinedNamesPanel_InsertDefinedNameInFormula);
            this.DocumentEditorControl.AddDefinedName += new System.EventHandler<System.EventArgs>(this.DefinedNamesPanel_AddDefinedName);
            this.DocumentEditorControl.ShowDefinedNamesManager += new System.EventHandler<System.EventArgs>(this.DefinedNamesPanel_ShowDefinedNamesManager);
            this.DocumentEditorControl.FilenameChanged += new System.EventHandler(this.FilePanel_FilenameChanged);
            this.DocumentEditorControl.OpenFileRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.FilenameEventArgs>(this.FilePanel_OpenFileRequest);
            this.DocumentEditorControl.ExportFile += new System.EventHandler<System.EventArgs>(this.FilePanel_ExportFile);
            this.DocumentEditorControl.PrintDocument += new System.EventHandler<System.EventArgs>(this.FilePanel_PrintDocument);
            this.DocumentEditorControl.ShowPrintLayoutSettings += new System.EventHandler<System.EventArgs>(this.FilePanel_ShowPrintLayoutSettings);
            this.DocumentEditorControl.ShowPrintPageSettings += new System.EventHandler<System.EventArgs>(this.FilePanel_ShowPrintPageSettings);
            this.DocumentEditorControl.ShowPrintPreview += new System.EventHandler<System.EventArgs>(this.FilePanel_ShowPrintPreview);
            this.DocumentEditorControl.SaveChangesRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ActionRequestEventArgs>(this.FilePanel_SaveChangesRequest);
            this.DocumentEditorControl.SaveAsRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.FilenameEventArgs>(this.FilePanel_SaveAsRequest);
            this.DocumentEditorControl.ShowDocumentInfo += new System.EventHandler<System.EventArgs>(this.FilePanel_ShowDocumentInfo);
            this.DocumentEditorControl.ShowVisualEditorOptions += new System.EventHandler<System.EventArgs>(this.FilePanel_ShowVisualEditorOptions);
            this.DocumentEditorControl.ColorRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ColorEventArgs>(this.FontPropertiesPanel_ColorRequest);
            this.DocumentEditorControl.FontProperties += new System.EventHandler<System.EventArgs>(this.FontPropertiesPanel_FontProperties);
            this.DocumentEditorControl.Borders += new System.EventHandler<System.EventArgs>(this.FontPropertiesPanel_Borders);
            this.DocumentEditorControl.InsertFunction += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.XlsxFunctionNameEventArgs>(this.FunctionsPanel_InsertFunction);
            this.DocumentEditorControl.NumberFormatProperties += new System.EventHandler<System.EventArgs>(this.NumberFormatPanel_NumberFormatProperties);
            this.DocumentEditorControl.AlignmentProperties += new System.EventHandler<System.EventArgs>(this.TextAlignmentPanel_AlignmentProperties);
            this.DocumentEditorControl.EditCellFormulaError += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ExceptionActionEventArgs>(this.FormulaPanel_EditCellFormulaError);
            this.DocumentEditorControl.FormulaPanelInsertFunction += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.XlsxFunctionNameEventArgs>(this.FormulaPanel_InsertFunction);
            this.DocumentEditorControl.RemoveWorksheet += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ActionRequestEventArgs>(this.NavigationPanel_RemoveWorksheet);
            this.DocumentEditorControl.MoveWorksheet += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ActionRequestEventArgs>(this.NavigationPanel_MoveWorksheet);
            this.DocumentEditorControl.RenameWorksheet += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ActionRequestEventArgs>(this.NavigationPanel_RenameWorksheet);
            this.DocumentEditorControl.NavigationPanelColorRequest += new System.EventHandler<Vintasoft.Imaging.Office.Spreadsheet.UI.Controls.ColorEventArgs>(this.NavigationPanel_ColorRequest);
            this.DocumentEditorControl.WorksheetFormat += new System.EventHandler<System.EventArgs>(this.NavigationPanel_WorksheetFormat);
            // 
            // spreadsheetCellContextMenu
            // 
            this.spreadsheetCellContextMenu.Name = "spreadsheetCellContextMenu";
            this.spreadsheetCellContextMenu.Size = new System.Drawing.Size(191, 550);
            this.spreadsheetCellContextMenu.SpreadsheetEditor = this.DocumentEditorControl.SpreadsheetEditorControl;
            // 
            // spreadsheetCommentContextMenu
            // 
            this.spreadsheetCommentContextMenu.Name = "commentContextMenuStrip";
            this.spreadsheetCommentContextMenu.Size = new System.Drawing.Size(165, 70);
            this.spreadsheetCommentContextMenu.SpreadsheetEditor = this.DocumentEditorControl.SpreadsheetEditorControl;
            // 
            // spreadsheetDrawingContextMenu
            // 
            this.spreadsheetDrawingContextMenu.Name = "drawingContextMenuStrip";
            this.spreadsheetDrawingContextMenu.Size = new System.Drawing.Size(143, 126);
            this.spreadsheetDrawingContextMenu.SpreadsheetEditor = this.DocumentEditorControl.SpreadsheetEditorControl;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            resources.ApplyResources(this, "$this");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private SpreadsheetCommentContextMenu spreadsheetCommentContextMenu;
        private SpreadsheetDrawingContextMenu spreadsheetDrawingContextMenu;
        private SpreadsheetCellContextMenu spreadsheetCellContextMenu;
        private System.Windows.Forms.SaveFileDialog saveWorksheetFileDialog;
        private System.Windows.Forms.OpenFileDialog openWorksheetFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Vintasoft.Imaging.Print.ImagePrintDocument imagePrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SpreadsheetDocumentEditorControl DocumentEditorControl;
    }
}