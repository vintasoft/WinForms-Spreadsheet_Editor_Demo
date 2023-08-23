
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
            this.topTabControl = new System.Windows.Forms.TabControl();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.fileToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.filePanel1 = new SpreadsheetEditorDemo.FilePanel();
            this.spreadsheetEditorControl1 = new Vintasoft.Imaging.Office.Spreadsheet.UI.SpreadsheetEditorControl();
            this.homeTabPage = new System.Windows.Forms.TabPage();
            this.undoPanel2 = new SpreadsheetEditorDemo.UndoPanel();
            this.numberFormatPanel1 = new SpreadsheetEditorDemo.NumberFormatPanel();
            this.copyPastePanel2 = new SpreadsheetEditorDemo.CopyPastePanel();
            this.textAlignmentPanel1 = new SpreadsheetEditorDemo.TextAlignmentPanel();
            this.fontPropertiesPanel1 = new SpreadsheetEditorDemo.FontPropertiesPanel();
            this.editTabPage = new System.Windows.Forms.TabPage();
            this.findReplacePanel1 = new SpreadsheetEditorDemo.FindReplacePanel();
            this.cellsEditorPanel1 = new SpreadsheetEditorDemo.CellsEditorPanel();
            this.copyPastePanel1 = new SpreadsheetEditorDemo.CopyPastePanel();
            this.formulasTabPage = new System.Windows.Forms.TabPage();
            this.definedNamesPanel1 = new SpreadsheetEditorDemo.DefinedNamesPanel();
            this.functionsPanel1 = new SpreadsheetEditorDemo.FunctionsPanel();
            this.reviewTabPage = new System.Windows.Forms.TabPage();
            this.commentsPanel1 = new SpreadsheetEditorDemo.CommentsPanel();
            this.helpTabPage = new System.Windows.Forms.TabPage();
            this.helpPanel1 = new SpreadsheetEditorDemo.HelpPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.editorPanel = new System.Windows.Forms.Panel();
            this.navigationPanel1 = new SpreadsheetEditorDemo.NavigationPanel();
            this.formulaPanel1 = new SpreadsheetEditorDemo.FormulaPanel();
            this.spreadsheetCellContextMenu = new SpreadsheetEditorDemo.SpreadsheetCellContextMenu();
            this.spreadsheetCommentContextMenu = new SpreadsheetEditorDemo.SpreadsheetCommentContextMenu();
            this.spreadsheetDrawingContextMenu = new SpreadsheetEditorDemo.SpreadsheetDrawingContextMenu();
            this.topTabControl.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.fileToolStripContainer.ContentPanel.SuspendLayout();
            this.fileToolStripContainer.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.editTabPage.SuspendLayout();
            this.formulasTabPage.SuspendLayout();
            this.reviewTabPage.SuspendLayout();
            this.helpTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.editorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topTabControl
            // 
            this.topTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topTabControl.Controls.Add(this.fileTabPage);
            this.topTabControl.Controls.Add(this.homeTabPage);
            this.topTabControl.Controls.Add(this.editTabPage);
            this.topTabControl.Controls.Add(this.formulasTabPage);
            this.topTabControl.Controls.Add(this.reviewTabPage);
            this.topTabControl.Controls.Add(this.helpTabPage);
            this.topTabControl.ItemSize = new System.Drawing.Size(42, 18);
            this.topTabControl.Location = new System.Drawing.Point(3, 3);
            this.topTabControl.Multiline = true;
            this.topTabControl.Name = "topTabControl";
            this.topTabControl.SelectedIndex = 0;
            this.topTabControl.Size = new System.Drawing.Size(756, 81);
            this.topTabControl.TabIndex = 0;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.fileToolStripContainer);
            this.fileTabPage.Location = new System.Drawing.Point(4, 22);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Size = new System.Drawing.Size(748, 55);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "File";
            this.fileTabPage.UseVisualStyleBackColor = true;
            // 
            // fileToolStripContainer
            // 
            this.fileToolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // fileToolStripContainer.ContentPanel
            // 
            this.fileToolStripContainer.ContentPanel.Controls.Add(this.filePanel1);
            this.fileToolStripContainer.ContentPanel.Size = new System.Drawing.Size(748, 55);
            this.fileToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileToolStripContainer.LeftToolStripPanelVisible = false;
            this.fileToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.fileToolStripContainer.Name = "fileToolStripContainer";
            this.fileToolStripContainer.RightToolStripPanelVisible = false;
            this.fileToolStripContainer.Size = new System.Drawing.Size(748, 55);
            this.fileToolStripContainer.TabIndex = 0;
            this.fileToolStripContainer.Text = "toolStripContainer1";
            this.fileToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // filePanel1
            // 
            this.filePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePanel1.Enabled = false;
            this.filePanel1.Location = new System.Drawing.Point(1, 2);
            this.filePanel1.Name = "filePanel1";
            this.filePanel1.Size = new System.Drawing.Size(745, 52);
            this.filePanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.filePanel1.TabIndex = 0;
            this.filePanel1.FilenameChanged += new System.EventHandler(this.filePanel1_FilenameChanged);
            // 
            // spreadsheetEditorControl1
            // 
            this.spreadsheetEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetEditorControl1.AutoScrollMinSize = new System.Drawing.Size(897, 501);
            this.spreadsheetEditorControl1.CellCursor = System.Windows.Forms.Cursors.Cross;
            this.spreadsheetEditorControl1.HyperlinkCursor = System.Windows.Forms.Cursors.Hand;
            this.spreadsheetEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetEditorControl1.MoveCursor = System.Windows.Forms.Cursors.SizeAll;
            this.spreadsheetEditorControl1.Name = "spreadsheetEditorControl1";
            this.spreadsheetEditorControl1.PanningCursor = System.Windows.Forms.Cursors.SizeAll;
            this.spreadsheetEditorControl1.ResizeColumnCursor = System.Windows.Forms.Cursors.SizeWE;
            this.spreadsheetEditorControl1.ResizeCursorNESW = System.Windows.Forms.Cursors.SizeNESW;
            this.spreadsheetEditorControl1.ResizeCursorNS = System.Windows.Forms.Cursors.SizeNS;
            this.spreadsheetEditorControl1.ResizeCursorNWSE = System.Windows.Forms.Cursors.SizeNWSE;
            this.spreadsheetEditorControl1.ResizeCursorWE = System.Windows.Forms.Cursors.SizeWE;
            this.spreadsheetEditorControl1.ResizeRowCursor = System.Windows.Forms.Cursors.SizeNS;
            this.spreadsheetEditorControl1.SelectAllCursor = System.Windows.Forms.Cursors.PanSE;
            this.spreadsheetEditorControl1.SelectColumnCursor = System.Windows.Forms.Cursors.PanSouth;
            this.spreadsheetEditorControl1.SelectRowCursor = System.Windows.Forms.Cursors.PanEast;
            this.spreadsheetEditorControl1.Size = new System.Drawing.Size(876, 493);
            this.spreadsheetEditorControl1.TabIndex = 3;
            this.spreadsheetEditorControl1.Text = "spreadsheetEditorControl1";
            // 
            // homeTabPage
            // 
            this.homeTabPage.Controls.Add(this.numberFormatPanel1);
            this.homeTabPage.Controls.Add(this.copyPastePanel2);
            this.homeTabPage.Controls.Add(this.textAlignmentPanel1);
            this.homeTabPage.Controls.Add(this.fontPropertiesPanel1);
            this.homeTabPage.Location = new System.Drawing.Point(4, 22);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Size = new System.Drawing.Size(748, 55);
            this.homeTabPage.TabIndex = 1;
            this.homeTabPage.Text = "Home";
            this.homeTabPage.UseVisualStyleBackColor = true;
            // 
            // undoPanel2
            // 
            this.undoPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undoPanel2.Enabled = false;
            this.undoPanel2.Location = new System.Drawing.Point(759, 25);
            this.undoPanel2.Name = "undoPanel2";
            this.undoPanel2.Size = new System.Drawing.Size(122, 54);
            this.undoPanel2.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.undoPanel2.TabIndex = 8;
            // 
            // numberFormatPanel1
            // 
            this.numberFormatPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberFormatPanel1.Enabled = false;
            this.numberFormatPanel1.Location = new System.Drawing.Point(578, 2);
            this.numberFormatPanel1.Name = "numberFormatPanel1";
            this.numberFormatPanel1.Size = new System.Drawing.Size(170, 52);
            this.numberFormatPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.numberFormatPanel1.TabIndex = 6;
            // 
            // copyPastePanel2
            // 
            this.copyPastePanel2.Enabled = false;
            this.copyPastePanel2.Location = new System.Drawing.Point(1, 2);
            this.copyPastePanel2.Name = "copyPastePanel2";
            this.copyPastePanel2.Size = new System.Drawing.Size(122, 52);
            this.copyPastePanel2.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.copyPastePanel2.TabIndex = 5;
            // 
            // textAlignmentPanel1
            // 
            this.textAlignmentPanel1.Enabled = false;
            this.textAlignmentPanel1.Location = new System.Drawing.Point(397, 2);
            this.textAlignmentPanel1.Name = "textAlignmentPanel1";
            this.textAlignmentPanel1.Size = new System.Drawing.Size(180, 52);
            this.textAlignmentPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.textAlignmentPanel1.TabIndex = 2;
            // 
            // fontPropertiesPanel1
            // 
            this.fontPropertiesPanel1.Enabled = false;
            this.fontPropertiesPanel1.Location = new System.Drawing.Point(126, 2);
            this.fontPropertiesPanel1.Name = "fontPropertiesPanel1";
            this.fontPropertiesPanel1.Size = new System.Drawing.Size(270, 52);
            this.fontPropertiesPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.fontPropertiesPanel1.TabIndex = 1;
            // 
            // editTabPage
            // 
            this.editTabPage.Controls.Add(this.findReplacePanel1);
            this.editTabPage.Controls.Add(this.cellsEditorPanel1);
            this.editTabPage.Controls.Add(this.copyPastePanel1);
            this.editTabPage.Location = new System.Drawing.Point(4, 22);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Size = new System.Drawing.Size(748, 55);
            this.editTabPage.TabIndex = 2;
            this.editTabPage.Text = "Edit";
            this.editTabPage.UseVisualStyleBackColor = true;
            // 
            // findReplacePanel1
            // 
            this.findReplacePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findReplacePanel1.Enabled = false;
            this.findReplacePanel1.Location = new System.Drawing.Point(611, 2);
            this.findReplacePanel1.Name = "findReplacePanel1";
            this.findReplacePanel1.Size = new System.Drawing.Size(136, 52);
            this.findReplacePanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.findReplacePanel1.TabIndex = 6;
            // 
            // cellsEditorPanel1
            // 
            this.cellsEditorPanel1.Enabled = false;
            this.cellsEditorPanel1.Location = new System.Drawing.Point(126, 2);
            this.cellsEditorPanel1.Name = "cellsEditorPanel1";
            this.cellsEditorPanel1.Size = new System.Drawing.Size(482, 52);
            this.cellsEditorPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.cellsEditorPanel1.TabIndex = 5;
            // 
            // copyPastePanel1
            // 
            this.copyPastePanel1.Enabled = false;
            this.copyPastePanel1.Location = new System.Drawing.Point(1, 2);
            this.copyPastePanel1.Name = "copyPastePanel1";
            this.copyPastePanel1.Size = new System.Drawing.Size(122, 52);
            this.copyPastePanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.copyPastePanel1.TabIndex = 4;
            // 
            // formulasTabPage
            // 
            this.formulasTabPage.Controls.Add(this.definedNamesPanel1);
            this.formulasTabPage.Controls.Add(this.functionsPanel1);
            this.formulasTabPage.Location = new System.Drawing.Point(4, 22);
            this.formulasTabPage.Name = "formulasTabPage";
            this.formulasTabPage.Size = new System.Drawing.Size(748, 55);
            this.formulasTabPage.TabIndex = 3;
            this.formulasTabPage.Text = "Formulas";
            this.formulasTabPage.UseVisualStyleBackColor = true;
            // 
            // definedNamesPanel1
            // 
            this.definedNamesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.definedNamesPanel1.Enabled = false;
            this.definedNamesPanel1.Location = new System.Drawing.Point(186, 1);
            this.definedNamesPanel1.Name = "definedNamesPanel1";
            this.definedNamesPanel1.Size = new System.Drawing.Size(560, 53);
            this.definedNamesPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.definedNamesPanel1.TabIndex = 1;
            // 
            // functionsPanel1
            // 
            this.functionsPanel1.Enabled = false;
            this.functionsPanel1.Location = new System.Drawing.Point(1, 1);
            this.functionsPanel1.Name = "functionsPanel1";
            this.functionsPanel1.Size = new System.Drawing.Size(183, 53);
            this.functionsPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.functionsPanel1.TabIndex = 0;
            // 
            // reviewTabPage
            // 
            this.reviewTabPage.Controls.Add(this.commentsPanel1);
            this.reviewTabPage.Location = new System.Drawing.Point(4, 22);
            this.reviewTabPage.Name = "reviewTabPage";
            this.reviewTabPage.Size = new System.Drawing.Size(748, 55);
            this.reviewTabPage.TabIndex = 5;
            this.reviewTabPage.Text = "Comments";
            this.reviewTabPage.UseVisualStyleBackColor = true;
            // 
            // commentsPanel1
            // 
            this.commentsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsPanel1.Enabled = false;
            this.commentsPanel1.Location = new System.Drawing.Point(1, 2);
            this.commentsPanel1.Name = "commentsPanel1";
            this.commentsPanel1.Size = new System.Drawing.Size(745, 52);
            this.commentsPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.commentsPanel1.TabIndex = 0;
            // 
            // helpTabPage
            // 
            this.helpTabPage.Controls.Add(this.helpPanel1);
            this.helpTabPage.Location = new System.Drawing.Point(4, 22);
            this.helpTabPage.Name = "helpTabPage";
            this.helpTabPage.Size = new System.Drawing.Size(748, 55);
            this.helpTabPage.TabIndex = 6;
            this.helpTabPage.Text = "Help";
            this.helpTabPage.UseVisualStyleBackColor = true;
            // 
            // helpPanel1
            // 
            this.helpPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpPanel1.Location = new System.Drawing.Point(1, 1);
            this.helpPanel1.Name = "helpPanel1";
            this.helpPanel1.Size = new System.Drawing.Size(746, 53);
            this.helpPanel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // editorPanel
            // 
            this.editorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorPanel.Controls.Add(this.spreadsheetEditorControl1);
            this.editorPanel.Location = new System.Drawing.Point(3, 110);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(878, 495);
            this.editorPanel.TabIndex = 4;
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel1.Enabled = false;
            this.navigationPanel1.Location = new System.Drawing.Point(4, 611);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.Size = new System.Drawing.Size(877, 25);
            this.navigationPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.navigationPanel1.TabIndex = 5;
            // 
            // formulaPanel1
            // 
            this.formulaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formulaPanel1.Enabled = false;
            this.formulaPanel1.Location = new System.Drawing.Point(2, 85);
            this.formulaPanel1.Name = "formulaPanel1";
            this.formulaPanel1.Size = new System.Drawing.Size(880, 27);
            this.formulaPanel1.SpreadsheetEditor = this.spreadsheetEditorControl1;
            this.formulaPanel1.TabIndex = 2;
            // 
            // spreadsheetCellContextMenu
            // 
            this.spreadsheetCellContextMenu.CellsEditorPanel = this.cellsEditorPanel1;
            this.spreadsheetCellContextMenu.CommentsPanel = this.commentsPanel1;
            this.spreadsheetCellContextMenu.Name = "spreadsheetCellContextMenu";
            this.spreadsheetCellContextMenu.Size = new System.Drawing.Size(191, 550);
            this.spreadsheetCellContextMenu.SpreadsheetEditor = this.spreadsheetEditorControl1;
            // 
            // spreadsheetCommentContextMenu
            // 
            this.spreadsheetCommentContextMenu.CommentsPanel = this.commentsPanel1;
            this.spreadsheetCommentContextMenu.Name = "commentContextMenuStrip";
            this.spreadsheetCommentContextMenu.Size = new System.Drawing.Size(165, 70);
            this.spreadsheetCommentContextMenu.SpreadsheetEditor = this.spreadsheetEditorControl1;
            // 
            // spreadsheetDrawingContextMenu
            // 
            this.spreadsheetDrawingContextMenu.Name = "drawingContextMenuStrip";
            this.spreadsheetDrawingContextMenu.Size = new System.Drawing.Size(143, 126);
            this.spreadsheetDrawingContextMenu.SpreadsheetEditor = this.spreadsheetEditorControl1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.undoPanel2);
            this.Controls.Add(this.navigationPanel1);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.formulaPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.topTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Spreadsheet Editor Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.topTabControl.ResumeLayout(false);
            this.fileTabPage.ResumeLayout(false);
            this.fileToolStripContainer.ContentPanel.ResumeLayout(false);
            this.fileToolStripContainer.ResumeLayout(false);
            this.fileToolStripContainer.PerformLayout();
            this.homeTabPage.ResumeLayout(false);
            this.editTabPage.ResumeLayout(false);
            this.formulasTabPage.ResumeLayout(false);
            this.reviewTabPage.ResumeLayout(false);
            this.helpTabPage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.editorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl topTabControl;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.ToolStripContainer fileToolStripContainer;
        private System.Windows.Forms.TabPage editTabPage;
        private System.Windows.Forms.TabPage formulasTabPage;
        private System.Windows.Forms.TabPage reviewTabPage;
        private System.Windows.Forms.TabPage helpTabPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private FontPropertiesPanel fontPropertiesPanel1;
        private FormulaPanel formulaPanel1;
        private Vintasoft.Imaging.Office.Spreadsheet.UI.SpreadsheetEditorControl spreadsheetEditorControl1;
        private System.Windows.Forms.Panel editorPanel;
        private FilePanel filePanel1;
        private NavigationPanel navigationPanel1;
        private TextAlignmentPanel textAlignmentPanel1;
        private CopyPastePanel copyPastePanel2;
        private CellsEditorPanel cellsEditorPanel1;
        private CopyPastePanel copyPastePanel1;
        private NumberFormatPanel numberFormatPanel1;
        private FunctionsPanel functionsPanel1;
        private DefinedNamesPanel definedNamesPanel1;
        private FindReplacePanel findReplacePanel1;
        private HelpPanel helpPanel1;
        private CommentsPanel commentsPanel1;
        private SpreadsheetCommentContextMenu spreadsheetCommentContextMenu;
        private SpreadsheetDrawingContextMenu spreadsheetDrawingContextMenu;
        private SpreadsheetCellContextMenu spreadsheetCellContextMenu;
        private UndoPanel undoPanel2;
    }
}