
namespace SpreadsheetEditorDemo
{
    partial class CellsEditorPanel
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertButton = new System.Windows.Forms.ToolStripSplitButton();
            this.insertRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCellsShiftRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserCellsShiftDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.ToolStripSplitButton();
            this.deleteRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCellsShiftLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCellsShiftUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatButton = new System.Windows.Forms.ToolStripSplitButton();
            this.rowHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFitRowHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRowAutoheightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultRowHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.columnWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFitColumnWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultColumnWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeMenuButton = new System.Windows.Forms.ToolStripSplitButton();
            this.mergeCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeAcrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.ToolStripSplitButton();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHyperlinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCommentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillButton = new System.Windows.Forms.ToolStripSplitButton();
            this.fillDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hypelinkSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorksheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveWorksheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.calculateRowAutoHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertButton,
            this.deleteButton,
            this.formatButton,
            this.mergeMenuButton,
            this.clearButton,
            this.fillButton,
            this.pictureButton,
            this.hypelinkSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(505, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = false;
            this.insertButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertRowsToolStripMenuItem,
            this.insertColumnsToolStripMenuItem,
            this.insertCellsToolStripMenuItem});
            this.insertButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertRowsBig;
            this.insertButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(60, 50);
            this.insertButton.Text = "Insert";
            this.insertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.insertButton.ToolTipText = "Insert Cells";
            this.insertButton.ButtonClick += new System.EventHandler(this.insertButton_ButtonClick);
            // 
            // insertRowsToolStripMenuItem
            // 
            this.insertRowsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertRows;
            this.insertRowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertRowsToolStripMenuItem.Name = "insertRowsToolStripMenuItem";
            this.insertRowsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.insertRowsToolStripMenuItem.Text = "Insert Rows";
            this.insertRowsToolStripMenuItem.Click += new System.EventHandler(this.insertRowsToolStripMenuItem_Click);
            // 
            // insertColumnsToolStripMenuItem
            // 
            this.insertColumnsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertColumns;
            this.insertColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertColumnsToolStripMenuItem.Name = "insertColumnsToolStripMenuItem";
            this.insertColumnsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.insertColumnsToolStripMenuItem.Text = "Insert Columns";
            this.insertColumnsToolStripMenuItem.Click += new System.EventHandler(this.insertColumnsToolStripMenuItem_Click);
            // 
            // insertCellsToolStripMenuItem
            // 
            this.insertCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertCellsShiftRightToolStripMenuItem,
            this.inserCellsShiftDownToolStripMenuItem});
            this.insertCellsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertCells;
            this.insertCellsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertCellsToolStripMenuItem.Name = "insertCellsToolStripMenuItem";
            this.insertCellsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.insertCellsToolStripMenuItem.Text = "Insert Cells";
            // 
            // insertCellsShiftRightToolStripMenuItem
            // 
            this.insertCellsShiftRightToolStripMenuItem.Name = "insertCellsShiftRightToolStripMenuItem";
            this.insertCellsShiftRightToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.insertCellsShiftRightToolStripMenuItem.Text = "Shift Right";
            this.insertCellsShiftRightToolStripMenuItem.Click += new System.EventHandler(this.insertCellsShiftRightToolStripMenuItem_Click);
            // 
            // inserCellsShiftDownToolStripMenuItem
            // 
            this.inserCellsShiftDownToolStripMenuItem.Name = "inserCellsShiftDownToolStripMenuItem";
            this.inserCellsShiftDownToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.inserCellsShiftDownToolStripMenuItem.Text = "Shift Down";
            this.inserCellsShiftDownToolStripMenuItem.Click += new System.EventHandler(this.inserCellsShiftDownToolStripMenuItem_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowsToolStripMenuItem,
            this.deleteColumnsToolStripMenuItem,
            this.deleteCellsToolStripMenuItem});
            this.deleteButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteRowsBig;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 50);
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.deleteButton.ToolTipText = "Delete Cells";
            this.deleteButton.ButtonClick += new System.EventHandler(this.deleteButton_ButtonClick);
            // 
            // deleteRowsToolStripMenuItem
            // 
            this.deleteRowsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteRows;
            this.deleteRowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            this.deleteRowsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteRowsToolStripMenuItem.Text = "Delete Rows";
            this.deleteRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteRowsToolStripMenuItem_Click);
            // 
            // deleteColumnsToolStripMenuItem
            // 
            this.deleteColumnsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteColumns;
            this.deleteColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteColumnsToolStripMenuItem.Name = "deleteColumnsToolStripMenuItem";
            this.deleteColumnsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteColumnsToolStripMenuItem.Text = "Delete Columns";
            this.deleteColumnsToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnsToolStripMenuItem_Click);
            // 
            // deleteCellsToolStripMenuItem
            // 
            this.deleteCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCellsShiftLeftToolStripMenuItem,
            this.deleteCellsShiftUpToolStripMenuItem});
            this.deleteCellsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteCells;
            this.deleteCellsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteCellsToolStripMenuItem.Name = "deleteCellsToolStripMenuItem";
            this.deleteCellsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteCellsToolStripMenuItem.Text = "Delete Cells";
            // 
            // deleteCellsShiftLeftToolStripMenuItem
            // 
            this.deleteCellsShiftLeftToolStripMenuItem.Name = "deleteCellsShiftLeftToolStripMenuItem";
            this.deleteCellsShiftLeftToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteCellsShiftLeftToolStripMenuItem.Text = "Shift Left";
            this.deleteCellsShiftLeftToolStripMenuItem.Click += new System.EventHandler(this.deleteCellsShiftLeftToolStripMenuItem_Click);
            // 
            // deleteCellsShiftUpToolStripMenuItem
            // 
            this.deleteCellsShiftUpToolStripMenuItem.Name = "deleteCellsShiftUpToolStripMenuItem";
            this.deleteCellsShiftUpToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteCellsShiftUpToolStripMenuItem.Text = "Shift Up";
            this.deleteCellsShiftUpToolStripMenuItem.Click += new System.EventHandler(this.deleteCellsShiftUpToolStripMenuItem_Click);
            // 
            // formatButton
            // 
            this.formatButton.AutoSize = false;
            this.formatButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowHeightToolStripMenuItem,
            this.autoFitRowHeightToolStripMenuItem,
            this.setRowAutoheightToolStripMenuItem,
            this.calculateRowAutoHeightToolStripMenuItem,
            this.defaultRowHeightToolStripMenuItem,
            this.toolStripSeparator1,
            this.columnWidthToolStripMenuItem,
            this.autoFitColumnWidthToolStripMenuItem,
            this.defaultColumnWidthToolStripMenuItem,
            this.toolStripSeparator2,
            this.hideRowsToolStripMenuItem,
            this.hideColumnsToolStripMenuItem,
            this.showRowsToolStripMenuItem,
            this.showColumnsToolStripMenuItem});
            this.formatButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.RowColumnFormat;
            this.formatButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.formatButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.formatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(60, 50);
            this.formatButton.Text = "Format";
            this.formatButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.formatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.formatButton.ToolTipText = "Format";
            this.formatButton.ButtonClick += new System.EventHandler(this.formatButton_ButtonClick);
            // 
            // rowHeightToolStripMenuItem
            // 
            this.rowHeightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.RowsHeight;
            this.rowHeightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rowHeightToolStripMenuItem.Name = "rowHeightToolStripMenuItem";
            this.rowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.rowHeightToolStripMenuItem.Text = "Row Height...";
            this.rowHeightToolStripMenuItem.Click += new System.EventHandler(this.rowHeightToolStripMenuItem_Click);
            // 
            // autoFitRowHeightToolStripMenuItem
            // 
            this.autoFitRowHeightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.RowsAutoHeight;
            this.autoFitRowHeightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.autoFitRowHeightToolStripMenuItem.Name = "autoFitRowHeightToolStripMenuItem";
            this.autoFitRowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.autoFitRowHeightToolStripMenuItem.Text = "AutoFit Row Height";
            this.autoFitRowHeightToolStripMenuItem.Click += new System.EventHandler(this.autoFitRowHeightToolStripMenuItem_Click);
            // 
            // setRowAutoheightToolStripMenuItem
            // 
            this.setRowAutoheightToolStripMenuItem.Name = "setRowAutoheightToolStripMenuItem";
            this.setRowAutoheightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.setRowAutoheightToolStripMenuItem.Text = "Set Row Auto-Height";
            this.setRowAutoheightToolStripMenuItem.Click += new System.EventHandler(this.setRowAutoheightToolStripMenuItem_Click);
            // 
            // defaultRowHeightToolStripMenuItem
            // 
            this.defaultRowHeightToolStripMenuItem.Name = "defaultRowHeightToolStripMenuItem";
            this.defaultRowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.defaultRowHeightToolStripMenuItem.Text = "Default Row Height...";
            this.defaultRowHeightToolStripMenuItem.Click += new System.EventHandler(this.defaultRowHeightToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // columnWidthToolStripMenuItem
            // 
            this.columnWidthToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ColumnsWidth;
            this.columnWidthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.columnWidthToolStripMenuItem.Name = "columnWidthToolStripMenuItem";
            this.columnWidthToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.columnWidthToolStripMenuItem.Text = "Column Width...";
            this.columnWidthToolStripMenuItem.Click += new System.EventHandler(this.columnWidthToolStripMenuItem_Click);
            // 
            // autoFitColumnWidthToolStripMenuItem
            // 
            this.autoFitColumnWidthToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ColumnsAutoWidth;
            this.autoFitColumnWidthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.autoFitColumnWidthToolStripMenuItem.Name = "autoFitColumnWidthToolStripMenuItem";
            this.autoFitColumnWidthToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.autoFitColumnWidthToolStripMenuItem.Text = "AutoFit Column Width";
            this.autoFitColumnWidthToolStripMenuItem.Click += new System.EventHandler(this.autoFitColumnWidthToolStripMenuItem_Click);
            // 
            // defaultColumnWidthToolStripMenuItem
            // 
            this.defaultColumnWidthToolStripMenuItem.Name = "defaultColumnWidthToolStripMenuItem";
            this.defaultColumnWidthToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.defaultColumnWidthToolStripMenuItem.Text = "Default Column Width...";
            this.defaultColumnWidthToolStripMenuItem.Click += new System.EventHandler(this.defaultColumnWidthToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // hideRowsToolStripMenuItem
            // 
            this.hideRowsToolStripMenuItem.Name = "hideRowsToolStripMenuItem";
            this.hideRowsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.hideRowsToolStripMenuItem.Text = "Hide Rows";
            this.hideRowsToolStripMenuItem.Click += new System.EventHandler(this.hideRowsToolStripMenuItem_Click);
            // 
            // hideColumnsToolStripMenuItem
            // 
            this.hideColumnsToolStripMenuItem.Name = "hideColumnsToolStripMenuItem";
            this.hideColumnsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.hideColumnsToolStripMenuItem.Text = "Hide Columns";
            this.hideColumnsToolStripMenuItem.Click += new System.EventHandler(this.hideColumnsToolStripMenuItem_Click);
            // 
            // showRowsToolStripMenuItem
            // 
            this.showRowsToolStripMenuItem.Name = "showRowsToolStripMenuItem";
            this.showRowsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.showRowsToolStripMenuItem.Text = "Show Rows";
            this.showRowsToolStripMenuItem.Click += new System.EventHandler(this.showRowsToolStripMenuItem_Click);
            // 
            // showColumnsToolStripMenuItem
            // 
            this.showColumnsToolStripMenuItem.Name = "showColumnsToolStripMenuItem";
            this.showColumnsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.showColumnsToolStripMenuItem.Text = "Show Columns";
            this.showColumnsToolStripMenuItem.Click += new System.EventHandler(this.showColumnsToolStripMenuItem_Click);
            // 
            // mergeMenuButton
            // 
            this.mergeMenuButton.AutoSize = false;
            this.mergeMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeCenterToolStripMenuItem,
            this.mergeToolStripMenuItem,
            this.mergeAcrossToolStripMenuItem,
            this.unmergeToolStripMenuItem});
            this.mergeMenuButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAndCenterBig;
            this.mergeMenuButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mergeMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mergeMenuButton.Name = "mergeMenuButton";
            this.mergeMenuButton.Size = new System.Drawing.Size(60, 50);
            this.mergeMenuButton.Text = "Merge";
            this.mergeMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mergeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.mergeMenuButton.ToolTipText = "Merge and Center";
            this.mergeMenuButton.ButtonClick += new System.EventHandler(this.mergeCenterToolStripMenuItem_Click);
            // 
            // mergeCenterToolStripMenuItem
            // 
            this.mergeCenterToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAndCenter;
            this.mergeCenterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeCenterToolStripMenuItem.Name = "mergeCenterToolStripMenuItem";
            this.mergeCenterToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.mergeCenterToolStripMenuItem.Text = "Merge && Center";
            this.mergeCenterToolStripMenuItem.Click += new System.EventHandler(this.mergeCenterToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Merge;
            this.mergeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // mergeAcrossToolStripMenuItem
            // 
            this.mergeAcrossToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAcross;
            this.mergeAcrossToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeAcrossToolStripMenuItem.Name = "mergeAcrossToolStripMenuItem";
            this.mergeAcrossToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.mergeAcrossToolStripMenuItem.Text = "Merge Across";
            this.mergeAcrossToolStripMenuItem.Click += new System.EventHandler(this.mergeAcrossToolStripMenuItem_Click);
            // 
            // unmergeToolStripMenuItem
            // 
            this.unmergeToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Unmerge;
            this.unmergeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unmergeToolStripMenuItem.Name = "unmergeToolStripMenuItem";
            this.unmergeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.unmergeToolStripMenuItem.Text = "Unmerge";
            this.unmergeToolStripMenuItem.Click += new System.EventHandler(this.unmergeToolStripMenuItem_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = false;
            this.clearButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.clearStylesToolStripMenuItem,
            this.clearContentsToolStripMenuItem,
            this.clearHyperlinksToolStripMenuItem,
            this.clearCommentsToolStripMenuItem});
            this.clearButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearAllBig;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 50);
            this.clearButton.Text = "Clear";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.clearButton.ToolTipText = "Clear";
            this.clearButton.ButtonClick += new System.EventHandler(this.clearButton_ButtonClick);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearAll;
            this.clearAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // clearStylesToolStripMenuItem
            // 
            this.clearStylesToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearStyles;
            this.clearStylesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearStylesToolStripMenuItem.Name = "clearStylesToolStripMenuItem";
            this.clearStylesToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearStylesToolStripMenuItem.Text = "Clear Styles";
            this.clearStylesToolStripMenuItem.Click += new System.EventHandler(this.clearStylesToolStripMenuItem_Click);
            // 
            // clearContentsToolStripMenuItem
            // 
            this.clearContentsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearContents;
            this.clearContentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearContentsToolStripMenuItem.Name = "clearContentsToolStripMenuItem";
            this.clearContentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearContentsToolStripMenuItem.Text = "Clear Contents";
            this.clearContentsToolStripMenuItem.Click += new System.EventHandler(this.clearContentsToolStripMenuItem_Click);
            // 
            // clearHyperlinksToolStripMenuItem
            // 
            this.clearHyperlinksToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearHyperlinks;
            this.clearHyperlinksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearHyperlinksToolStripMenuItem.Name = "clearHyperlinksToolStripMenuItem";
            this.clearHyperlinksToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearHyperlinksToolStripMenuItem.Text = "Clear Hyperlinks";
            this.clearHyperlinksToolStripMenuItem.Click += new System.EventHandler(this.clearHyperlinksToolStripMenuItem_Click);
            // 
            // clearCommentsToolStripMenuItem
            // 
            this.clearCommentsToolStripMenuItem.Name = "clearCommentsToolStripMenuItem";
            this.clearCommentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.clearCommentsToolStripMenuItem.Text = "Clear Comments";
            this.clearCommentsToolStripMenuItem.Click += new System.EventHandler(this.clearCommentsToolStripMenuItem_Click);
            // 
            // fillButton
            // 
            this.fillButton.AutoSize = false;
            this.fillButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillDownToolStripMenuItem,
            this.fillRightToolStripMenuItem,
            this.fillUpToolStripMenuItem,
            this.fillLeftToolStripMenuItem});
            this.fillButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillDownBig;
            this.fillButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fillButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(60, 50);
            this.fillButton.Text = "Fill";
            this.fillButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.fillButton.ToolTipText = "Fill";
            this.fillButton.ButtonClick += new System.EventHandler(this.fillButton_ButtonClick);
            // 
            // fillDownToolStripMenuItem
            // 
            this.fillDownToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillDown;
            this.fillDownToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillDownToolStripMenuItem.Name = "fillDownToolStripMenuItem";
            this.fillDownToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.fillDownToolStripMenuItem.Text = "Down";
            this.fillDownToolStripMenuItem.Click += new System.EventHandler(this.fillDownToolStripMenuItem_Click);
            // 
            // fillRightToolStripMenuItem
            // 
            this.fillRightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillRight;
            this.fillRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillRightToolStripMenuItem.Name = "fillRightToolStripMenuItem";
            this.fillRightToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.fillRightToolStripMenuItem.Text = "Right";
            this.fillRightToolStripMenuItem.Click += new System.EventHandler(this.fillRightToolStripMenuItem_Click);
            // 
            // fillUpToolStripMenuItem
            // 
            this.fillUpToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillUp;
            this.fillUpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillUpToolStripMenuItem.Name = "fillUpToolStripMenuItem";
            this.fillUpToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.fillUpToolStripMenuItem.Text = "Up";
            this.fillUpToolStripMenuItem.Click += new System.EventHandler(this.fillUpToolStripMenuItem_Click);
            // 
            // fillLeftToolStripMenuItem
            // 
            this.fillLeftToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillLeft;
            this.fillLeftToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillLeftToolStripMenuItem.Name = "fillLeftToolStripMenuItem";
            this.fillLeftToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.fillLeftToolStripMenuItem.Text = "Left";
            this.fillLeftToolStripMenuItem.Click += new System.EventHandler(this.fillLeftToolStripMenuItem_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.AutoSize = false;
            this.pictureButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPictureToolStripMenuItem,
            this.setPictureToolStripMenuItem,
            this.picturePropertiesToolStripMenuItem,
            this.removePictureToolStripMenuItem});
            this.pictureButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Image;
            this.pictureButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pictureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(60, 50);
            this.pictureButton.Text = "Picture";
            this.pictureButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pictureButton.ButtonClick += new System.EventHandler(this.pictureButton_ButtonClick);
            this.pictureButton.DropDownOpened += new System.EventHandler(this.pictureButton_DropDownOpened);
            // 
            // addPictureToolStripMenuItem
            // 
            this.addPictureToolStripMenuItem.Name = "addPictureToolStripMenuItem";
            this.addPictureToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addPictureToolStripMenuItem.Text = "Add Picture...";
            this.addPictureToolStripMenuItem.Click += new System.EventHandler(this.addPictureToolStripMenuItem_Click);
            // 
            // setPictureToolStripMenuItem
            // 
            this.setPictureToolStripMenuItem.Name = "setPictureToolStripMenuItem";
            this.setPictureToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setPictureToolStripMenuItem.Text = "Set Picture...";
            this.setPictureToolStripMenuItem.Click += new System.EventHandler(this.setPictureToolStripMenuItem_Click);
            // 
            // picturePropertiesToolStripMenuItem
            // 
            this.picturePropertiesToolStripMenuItem.Name = "picturePropertiesToolStripMenuItem";
            this.picturePropertiesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.picturePropertiesToolStripMenuItem.Text = "Properties...";
            this.picturePropertiesToolStripMenuItem.Click += new System.EventHandler(this.picturePropertiesToolStripMenuItem_Click);
            // 
            // removePictureToolStripMenuItem
            // 
            this.removePictureToolStripMenuItem.Name = "removePictureToolStripMenuItem";
            this.removePictureToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removePictureToolStripMenuItem.Text = "Remove Picture";
            this.removePictureToolStripMenuItem.Click += new System.EventHandler(this.removePictureToolStripMenuItem_Click);
            // 
            // hypelinkSplitButton
            // 
            this.hypelinkSplitButton.AutoSize = false;
            this.hypelinkSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHyperlinkMenuItem,
            this.editHyperlinkMenuItem,
            this.removeHyperlinkMenuItem});
            this.hypelinkSplitButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Hyperlink;
            this.hypelinkSplitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hypelinkSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hypelinkSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hypelinkSplitButton.Name = "hypelinkSplitButton";
            this.hypelinkSplitButton.Size = new System.Drawing.Size(60, 50);
            this.hypelinkSplitButton.Text = "Link";
            this.hypelinkSplitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hypelinkSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.hypelinkSplitButton.ToolTipText = "Add Hyperlink...";
            this.hypelinkSplitButton.ButtonClick += new System.EventHandler(this.addHyperlinkMenuItem_Click);
            this.hypelinkSplitButton.DropDownOpened += new System.EventHandler(this.hypelinkSplitButton_DropDownOpened);
            // 
            // addHyperlinkMenuItem
            // 
            this.addHyperlinkMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addHyperlinkMenuItem.Name = "addHyperlinkMenuItem";
            this.addHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addHyperlinkMenuItem.Text = "Add Hyperlink...";
            this.addHyperlinkMenuItem.Click += new System.EventHandler(this.addHyperlinkMenuItem_Click);
            // 
            // editHyperlinkMenuItem
            // 
            this.editHyperlinkMenuItem.Name = "editHyperlinkMenuItem";
            this.editHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editHyperlinkMenuItem.Text = "Edit Hyperlink...";
            this.editHyperlinkMenuItem.Click += new System.EventHandler(this.editHyperlinkToolStripMenuItem_Click);
            // 
            // removeHyperlinkMenuItem
            // 
            this.removeHyperlinkMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeHyperlinkMenuItem.Name = "removeHyperlinkMenuItem";
            this.removeHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removeHyperlinkMenuItem.Text = "Remove Hyperlink";
            this.removeHyperlinkMenuItem.Click += new System.EventHandler(this.removeHyperlinkMenuItem_Click);
            // 
            // openWorksheetFileDialog
            // 
            this.openWorksheetFileDialog.Filter = "XLSX files|*.xlsx|XLS files|*.xls|All supported Workbooks|*.xlsx;*.xls";
            this.openWorksheetFileDialog.FilterIndex = 3;
            // 
            // saveWorksheetFileDialog
            // 
            this.saveWorksheetFileDialog.Filter = "XLSX files|*.xlsx";
            // 
            // calculateRowAutoHeightToolStripMenuItem
            // 
            this.calculateRowAutoHeightToolStripMenuItem.Name = "calculateRowAutoHeightToolStripMenuItem";
            this.calculateRowAutoHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.calculateRowAutoHeightToolStripMenuItem.Text = "Calculate Row Auto-Height";
            this.calculateRowAutoHeightToolStripMenuItem.Click += new System.EventHandler(this.calculateRowAutoHeightToolStripMenuItem_Click);
            // 
            // CellsEditorPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "CellsEditorPanel";
            this.Size = new System.Drawing.Size(505, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openWorksheetFileDialog;
        private System.Windows.Forms.SaveFileDialog saveWorksheetFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ToolStripSplitButton insertButton;
        private System.Windows.Forms.ToolStripMenuItem insertRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton deleteButton;
        private System.Windows.Forms.ToolStripMenuItem deleteRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton formatButton;
        private System.Windows.Forms.ToolStripSplitButton clearButton;
        private System.Windows.Forms.ToolStripSplitButton fillButton;
        private System.Windows.Forms.ToolStripSplitButton mergeMenuButton;
        private System.Windows.Forms.ToolStripMenuItem rowHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFitRowHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem columnWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFitColumnWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultColumnWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem hideRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeAcrossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unmergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHyperlinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCellsShiftRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserCellsShiftDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCellsShiftLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCellsShiftUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRowAutoheightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultRowHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton hypelinkSplitButton;
        private System.Windows.Forms.ToolStripMenuItem addHyperlinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeHyperlinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHyperlinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCommentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton pictureButton;
        private System.Windows.Forms.ToolStripMenuItem addPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateRowAutoHeightToolStripMenuItem;
    }
}