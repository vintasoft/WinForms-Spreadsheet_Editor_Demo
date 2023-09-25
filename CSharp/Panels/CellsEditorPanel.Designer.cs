
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellsEditorPanel));
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
            this.calculateRowAutoHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chartToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.insertChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchRowColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectChartValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.picturePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hypelinkSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHyperlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorksheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveWorksheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
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
            this.chartToolStripSplitButton,
            this.pictureButton,
            this.hypelinkSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(573, 53);
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
            resources.ApplyResources(this.insertButton, "insertButton");
            this.insertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.insertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.insertButton.ButtonClick += new System.EventHandler(this.insertButton_ButtonClick);
            // 
            // insertRowsToolStripMenuItem
            // 
            this.insertRowsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertRows;
            this.insertRowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertRowsToolStripMenuItem.Name = "insertRowsToolStripMenuItem";
            this.insertRowsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            resources.ApplyResources(this.insertRowsToolStripMenuItem, "insertRowsToolStripMenuItem");
            this.insertRowsToolStripMenuItem.Click += new System.EventHandler(this.insertRowsToolStripMenuItem_Click);
            // 
            // insertColumnsToolStripMenuItem
            // 
            this.insertColumnsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertColumns;
            this.insertColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertColumnsToolStripMenuItem.Name = "insertColumnsToolStripMenuItem";
            this.insertColumnsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            resources.ApplyResources(this.insertColumnsToolStripMenuItem, "insertColumnsToolStripMenuItem");
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
            resources.ApplyResources(this.insertCellsToolStripMenuItem, "insertCellsToolStripMenuItem");
            // 
            // insertCellsShiftRightToolStripMenuItem
            // 
            this.insertCellsShiftRightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertCellsAndShiftRight;
            this.insertCellsShiftRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.insertCellsShiftRightToolStripMenuItem.Name = "insertCellsShiftRightToolStripMenuItem";
            this.insertCellsShiftRightToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            resources.ApplyResources(this.insertCellsShiftRightToolStripMenuItem, "insertCellsShiftRightToolStripMenuItem");
            this.insertCellsShiftRightToolStripMenuItem.Click += new System.EventHandler(this.insertCellsShiftRightToolStripMenuItem_Click);
            // 
            // inserCellsShiftDownToolStripMenuItem
            // 
            this.inserCellsShiftDownToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.InsertCellsAndShiftDown;
            this.inserCellsShiftDownToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inserCellsShiftDownToolStripMenuItem.Name = "inserCellsShiftDownToolStripMenuItem";
            this.inserCellsShiftDownToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            resources.ApplyResources(this.inserCellsShiftDownToolStripMenuItem, "inserCellsShiftDownToolStripMenuItem");
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
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.deleteButton.ButtonClick += new System.EventHandler(this.deleteButton_ButtonClick);
            // 
            // deleteRowsToolStripMenuItem
            // 
            this.deleteRowsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteRows;
            this.deleteRowsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            this.deleteRowsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            resources.ApplyResources(this.deleteRowsToolStripMenuItem, "deleteRowsToolStripMenuItem");
            this.deleteRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteRowsToolStripMenuItem_Click);
            // 
            // deleteColumnsToolStripMenuItem
            // 
            this.deleteColumnsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteColumns;
            this.deleteColumnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteColumnsToolStripMenuItem.Name = "deleteColumnsToolStripMenuItem";
            this.deleteColumnsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            resources.ApplyResources(this.deleteColumnsToolStripMenuItem, "deleteColumnsToolStripMenuItem");
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
            resources.ApplyResources(this.deleteCellsToolStripMenuItem, "deleteCellsToolStripMenuItem");
            // 
            // deleteCellsShiftLeftToolStripMenuItem
            // 
            this.deleteCellsShiftLeftToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteCellsAndShiftLeft;
            this.deleteCellsShiftLeftToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteCellsShiftLeftToolStripMenuItem.Name = "deleteCellsShiftLeftToolStripMenuItem";
            this.deleteCellsShiftLeftToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            resources.ApplyResources(this.deleteCellsShiftLeftToolStripMenuItem, "deleteCellsShiftLeftToolStripMenuItem");
            this.deleteCellsShiftLeftToolStripMenuItem.Click += new System.EventHandler(this.deleteCellsShiftLeftToolStripMenuItem_Click);
            // 
            // deleteCellsShiftUpToolStripMenuItem
            // 
            this.deleteCellsShiftUpToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.DeleteCellsAndShiftUp;
            this.deleteCellsShiftUpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteCellsShiftUpToolStripMenuItem.Name = "deleteCellsShiftUpToolStripMenuItem";
            this.deleteCellsShiftUpToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            resources.ApplyResources(this.deleteCellsShiftUpToolStripMenuItem, "deleteCellsShiftUpToolStripMenuItem");
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
            resources.ApplyResources(this.formatButton, "formatButton");
            this.formatButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.formatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.formatButton.ButtonClick += new System.EventHandler(this.formatButton_ButtonClick);
            // 
            // rowHeightToolStripMenuItem
            // 
            this.rowHeightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.RowsHeight;
            this.rowHeightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rowHeightToolStripMenuItem.Name = "rowHeightToolStripMenuItem";
            this.rowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.rowHeightToolStripMenuItem, "rowHeightToolStripMenuItem");
            this.rowHeightToolStripMenuItem.Click += new System.EventHandler(this.rowHeightToolStripMenuItem_Click);
            // 
            // autoFitRowHeightToolStripMenuItem
            // 
            this.autoFitRowHeightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.RowsAutoHeight;
            this.autoFitRowHeightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.autoFitRowHeightToolStripMenuItem.Name = "autoFitRowHeightToolStripMenuItem";
            this.autoFitRowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.autoFitRowHeightToolStripMenuItem, "autoFitRowHeightToolStripMenuItem");
            this.autoFitRowHeightToolStripMenuItem.Click += new System.EventHandler(this.autoFitRowHeightToolStripMenuItem_Click);
            // 
            // setRowAutoheightToolStripMenuItem
            // 
            this.setRowAutoheightToolStripMenuItem.Name = "setRowAutoheightToolStripMenuItem";
            this.setRowAutoheightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.setRowAutoheightToolStripMenuItem, "setRowAutoheightToolStripMenuItem");
            this.setRowAutoheightToolStripMenuItem.Click += new System.EventHandler(this.setRowAutoheightToolStripMenuItem_Click);
            // 
            // calculateRowAutoHeightToolStripMenuItem
            // 
            this.calculateRowAutoHeightToolStripMenuItem.Name = "calculateRowAutoHeightToolStripMenuItem";
            this.calculateRowAutoHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.calculateRowAutoHeightToolStripMenuItem, "calculateRowAutoHeightToolStripMenuItem");
            this.calculateRowAutoHeightToolStripMenuItem.Click += new System.EventHandler(this.calculateRowAutoHeightToolStripMenuItem_Click);
            // 
            // defaultRowHeightToolStripMenuItem
            // 
            this.defaultRowHeightToolStripMenuItem.Name = "defaultRowHeightToolStripMenuItem";
            this.defaultRowHeightToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.defaultRowHeightToolStripMenuItem, "defaultRowHeightToolStripMenuItem");
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
            resources.ApplyResources(this.columnWidthToolStripMenuItem, "columnWidthToolStripMenuItem");
            this.columnWidthToolStripMenuItem.Click += new System.EventHandler(this.columnWidthToolStripMenuItem_Click);
            // 
            // autoFitColumnWidthToolStripMenuItem
            // 
            this.autoFitColumnWidthToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ColumnsAutoWidth;
            this.autoFitColumnWidthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.autoFitColumnWidthToolStripMenuItem.Name = "autoFitColumnWidthToolStripMenuItem";
            this.autoFitColumnWidthToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.autoFitColumnWidthToolStripMenuItem, "autoFitColumnWidthToolStripMenuItem");
            this.autoFitColumnWidthToolStripMenuItem.Click += new System.EventHandler(this.autoFitColumnWidthToolStripMenuItem_Click);
            // 
            // defaultColumnWidthToolStripMenuItem
            // 
            this.defaultColumnWidthToolStripMenuItem.Name = "defaultColumnWidthToolStripMenuItem";
            this.defaultColumnWidthToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.defaultColumnWidthToolStripMenuItem, "defaultColumnWidthToolStripMenuItem");
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
            resources.ApplyResources(this.hideRowsToolStripMenuItem, "hideRowsToolStripMenuItem");
            this.hideRowsToolStripMenuItem.Click += new System.EventHandler(this.hideRowsToolStripMenuItem_Click);
            // 
            // hideColumnsToolStripMenuItem
            // 
            this.hideColumnsToolStripMenuItem.Name = "hideColumnsToolStripMenuItem";
            this.hideColumnsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.hideColumnsToolStripMenuItem, "hideColumnsToolStripMenuItem");
            this.hideColumnsToolStripMenuItem.Click += new System.EventHandler(this.hideColumnsToolStripMenuItem_Click);
            // 
            // showRowsToolStripMenuItem
            // 
            this.showRowsToolStripMenuItem.Name = "showRowsToolStripMenuItem";
            this.showRowsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.showRowsToolStripMenuItem, "showRowsToolStripMenuItem");
            this.showRowsToolStripMenuItem.Click += new System.EventHandler(this.showRowsToolStripMenuItem_Click);
            // 
            // showColumnsToolStripMenuItem
            // 
            this.showColumnsToolStripMenuItem.Name = "showColumnsToolStripMenuItem";
            this.showColumnsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            resources.ApplyResources(this.showColumnsToolStripMenuItem, "showColumnsToolStripMenuItem");
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
            resources.ApplyResources(this.mergeMenuButton, "mergeMenuButton");
            this.mergeMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mergeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.mergeMenuButton.ButtonClick += new System.EventHandler(this.mergeCenterToolStripMenuItem_Click);
            // 
            // mergeCenterToolStripMenuItem
            // 
            this.mergeCenterToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAndCenter;
            this.mergeCenterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeCenterToolStripMenuItem.Name = "mergeCenterToolStripMenuItem";
            this.mergeCenterToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            resources.ApplyResources(this.mergeCenterToolStripMenuItem, "mergeCenterToolStripMenuItem");
            this.mergeCenterToolStripMenuItem.Click += new System.EventHandler(this.mergeCenterToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Merge;
            this.mergeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            resources.ApplyResources(this.mergeToolStripMenuItem, "mergeToolStripMenuItem");
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // mergeAcrossToolStripMenuItem
            // 
            this.mergeAcrossToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.MergeAcross;
            this.mergeAcrossToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mergeAcrossToolStripMenuItem.Name = "mergeAcrossToolStripMenuItem";
            this.mergeAcrossToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            resources.ApplyResources(this.mergeAcrossToolStripMenuItem, "mergeAcrossToolStripMenuItem");
            this.mergeAcrossToolStripMenuItem.Click += new System.EventHandler(this.mergeAcrossToolStripMenuItem_Click);
            // 
            // unmergeToolStripMenuItem
            // 
            this.unmergeToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Unmerge;
            this.unmergeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unmergeToolStripMenuItem.Name = "unmergeToolStripMenuItem";
            this.unmergeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            resources.ApplyResources(this.unmergeToolStripMenuItem, "unmergeToolStripMenuItem");
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
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.clearButton.ButtonClick += new System.EventHandler(this.clearButton_ButtonClick);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearAll;
            this.clearAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            resources.ApplyResources(this.clearAllToolStripMenuItem, "clearAllToolStripMenuItem");
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // clearStylesToolStripMenuItem
            // 
            this.clearStylesToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearStyles;
            this.clearStylesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearStylesToolStripMenuItem.Name = "clearStylesToolStripMenuItem";
            this.clearStylesToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            resources.ApplyResources(this.clearStylesToolStripMenuItem, "clearStylesToolStripMenuItem");
            this.clearStylesToolStripMenuItem.Click += new System.EventHandler(this.clearStylesToolStripMenuItem_Click);
            // 
            // clearContentsToolStripMenuItem
            // 
            this.clearContentsToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearContents;
            this.clearContentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearContentsToolStripMenuItem.Name = "clearContentsToolStripMenuItem";
            this.clearContentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            resources.ApplyResources(this.clearContentsToolStripMenuItem, "clearContentsToolStripMenuItem");
            this.clearContentsToolStripMenuItem.Click += new System.EventHandler(this.clearContentsToolStripMenuItem_Click);
            // 
            // clearHyperlinksToolStripMenuItem
            // 
            this.clearHyperlinksToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.ClearHyperlinks;
            this.clearHyperlinksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearHyperlinksToolStripMenuItem.Name = "clearHyperlinksToolStripMenuItem";
            this.clearHyperlinksToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            resources.ApplyResources(this.clearHyperlinksToolStripMenuItem, "clearHyperlinksToolStripMenuItem");
            this.clearHyperlinksToolStripMenuItem.Click += new System.EventHandler(this.clearHyperlinksToolStripMenuItem_Click);
            // 
            // clearCommentsToolStripMenuItem
            // 
            this.clearCommentsToolStripMenuItem.Name = "clearCommentsToolStripMenuItem";
            this.clearCommentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            resources.ApplyResources(this.clearCommentsToolStripMenuItem, "clearCommentsToolStripMenuItem");
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
            resources.ApplyResources(this.fillButton, "fillButton");
            this.fillButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.fillButton.ButtonClick += new System.EventHandler(this.fillButton_ButtonClick);
            // 
            // fillDownToolStripMenuItem
            // 
            this.fillDownToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillDown;
            this.fillDownToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillDownToolStripMenuItem.Name = "fillDownToolStripMenuItem";
            this.fillDownToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            resources.ApplyResources(this.fillDownToolStripMenuItem, "fillDownToolStripMenuItem");
            this.fillDownToolStripMenuItem.Click += new System.EventHandler(this.fillDownToolStripMenuItem_Click);
            // 
            // fillRightToolStripMenuItem
            // 
            this.fillRightToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillRight;
            this.fillRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillRightToolStripMenuItem.Name = "fillRightToolStripMenuItem";
            this.fillRightToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            resources.ApplyResources(this.fillRightToolStripMenuItem, "fillRightToolStripMenuItem");
            this.fillRightToolStripMenuItem.Click += new System.EventHandler(this.fillRightToolStripMenuItem_Click);
            // 
            // fillUpToolStripMenuItem
            // 
            this.fillUpToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillUp;
            this.fillUpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillUpToolStripMenuItem.Name = "fillUpToolStripMenuItem";
            this.fillUpToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            resources.ApplyResources(this.fillUpToolStripMenuItem, "fillUpToolStripMenuItem");
            this.fillUpToolStripMenuItem.Click += new System.EventHandler(this.fillUpToolStripMenuItem_Click);
            // 
            // fillLeftToolStripMenuItem
            // 
            this.fillLeftToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.FillLeft;
            this.fillLeftToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fillLeftToolStripMenuItem.Name = "fillLeftToolStripMenuItem";
            this.fillLeftToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            resources.ApplyResources(this.fillLeftToolStripMenuItem, "fillLeftToolStripMenuItem");
            this.fillLeftToolStripMenuItem.Click += new System.EventHandler(this.fillLeftToolStripMenuItem_Click);
            // 
            // chartToolStripSplitButton
            // 
            this.chartToolStripSplitButton.AutoSize = false;
            this.chartToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertChartToolStripMenuItem,
            this.removeChartToolStripMenuItem,
            this.switchRowColumnToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectChartValuesToolStripMenuItem,
            this.chartPropertiesToolStripMenuItem});
            this.chartToolStripSplitButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ChartBig;
            this.chartToolStripSplitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chartToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chartToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chartToolStripSplitButton.Name = "chartToolStripSplitButton";
            this.chartToolStripSplitButton.Size = new System.Drawing.Size(60, 50);
            this.chartToolStripSplitButton.Text = "Chart";
            this.chartToolStripSplitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chartToolStripSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.chartToolStripSplitButton.ButtonClick += new System.EventHandler(this.chartToolStripSplitButton_ButtonClick);
            // 
            // insertChartToolStripMenuItem
            // 
            this.insertChartToolStripMenuItem.Name = "insertChartToolStripMenuItem";
            this.insertChartToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resources.ApplyResources(this.insertChartToolStripMenuItem, "insertChartToolStripMenuItem");
            this.insertChartToolStripMenuItem.Click += new System.EventHandler(this.addChartToolStripMenuItem_Click);
            // 
            // removeChartToolStripMenuItem
            // 
            this.removeChartToolStripMenuItem.Name = "removeChartToolStripMenuItem";
            this.removeChartToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resources.ApplyResources(this.removeChartToolStripMenuItem, "removeChartToolStripMenuItem");
            this.removeChartToolStripMenuItem.Click += new System.EventHandler(this.removeChartToolStripMenuItem_Click);
            // 
            // switchRowColumnToolStripMenuItem
            // 
            this.switchRowColumnToolStripMenuItem.Name = "switchRowColumnToolStripMenuItem";
            this.switchRowColumnToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resources.ApplyResources(this.switchRowColumnToolStripMenuItem, "switchRowColumnToolStripMenuItem");
            this.switchRowColumnToolStripMenuItem.Click += new System.EventHandler(this.switchRowColumnToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // selectChartValuesToolStripMenuItem
            // 
            this.selectChartValuesToolStripMenuItem.Name = "selectChartValuesToolStripMenuItem";
            this.selectChartValuesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resources.ApplyResources(this.selectChartValuesToolStripMenuItem, "selectChartValuesToolStripMenuItem");
            this.selectChartValuesToolStripMenuItem.Click += new System.EventHandler(this.selectChartValuesToolStripMenuItem_Click);
            // 
            // chartPropertiesToolStripMenuItem
            // 
            this.chartPropertiesToolStripMenuItem.Name = "chartPropertiesToolStripMenuItem";
            this.chartPropertiesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            resources.ApplyResources(this.chartPropertiesToolStripMenuItem, "chartPropertiesToolStripMenuItem");
            this.chartPropertiesToolStripMenuItem.Click += new System.EventHandler(this.chartPropertiesToolStripMenuItem_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.AutoSize = false;
            this.pictureButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPictureToolStripMenuItem,
            this.setPictureToolStripMenuItem,
            this.removePictureToolStripMenuItem,
            this.toolStripSeparator4,
            this.picturePropertiesToolStripMenuItem});
            this.pictureButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Image;
            this.pictureButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pictureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(60, 50);
            resources.ApplyResources(this.pictureButton, "pictureButton");
            this.pictureButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pictureButton.ButtonClick += new System.EventHandler(this.pictureButton_ButtonClick);
            this.pictureButton.DropDownOpened += new System.EventHandler(this.pictureButton_DropDownOpened);
            // 
            // addPictureToolStripMenuItem
            // 
            this.addPictureToolStripMenuItem.Name = "addPictureToolStripMenuItem";
            this.addPictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            resources.ApplyResources(this.addPictureToolStripMenuItem, "addPictureToolStripMenuItem");
            this.addPictureToolStripMenuItem.Click += new System.EventHandler(this.addPictureToolStripMenuItem_Click);
            // 
            // setPictureToolStripMenuItem
            // 
            this.setPictureToolStripMenuItem.Name = "setPictureToolStripMenuItem";
            this.setPictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            resources.ApplyResources(this.setPictureToolStripMenuItem, "setPictureToolStripMenuItem");
            this.setPictureToolStripMenuItem.Click += new System.EventHandler(this.setPictureToolStripMenuItem_Click);
            // 
            // removePictureToolStripMenuItem
            // 
            this.removePictureToolStripMenuItem.Name = "removePictureToolStripMenuItem";
            this.removePictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            resources.ApplyResources(this.removePictureToolStripMenuItem, "removePictureToolStripMenuItem");
            this.removePictureToolStripMenuItem.Click += new System.EventHandler(this.removePictureToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // picturePropertiesToolStripMenuItem
            // 
            this.picturePropertiesToolStripMenuItem.Name = "picturePropertiesToolStripMenuItem";
            this.picturePropertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            resources.ApplyResources(this.picturePropertiesToolStripMenuItem, "picturePropertiesToolStripMenuItem");
            this.picturePropertiesToolStripMenuItem.Click += new System.EventHandler(this.picturePropertiesToolStripMenuItem_Click);
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
            resources.ApplyResources(this.hypelinkSplitButton, "hypelinkSplitButton");
            this.hypelinkSplitButton.ButtonClick += new System.EventHandler(this.addHyperlinkMenuItem_Click);
            this.hypelinkSplitButton.DropDownOpened += new System.EventHandler(this.hypelinkSplitButton_DropDownOpened);
            // 
            // addHyperlinkMenuItem
            // 
            this.addHyperlinkMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addHyperlinkMenuItem.Name = "addHyperlinkMenuItem";
            this.addHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            resources.ApplyResources(this.addHyperlinkMenuItem, "addHyperlinkMenuItem");
            this.addHyperlinkMenuItem.Click += new System.EventHandler(this.addHyperlinkMenuItem_Click);
            // 
            // editHyperlinkMenuItem
            // 
            this.editHyperlinkMenuItem.Name = "editHyperlinkMenuItem";
            this.editHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            resources.ApplyResources(this.editHyperlinkMenuItem, "editHyperlinkMenuItem");
            this.editHyperlinkMenuItem.Click += new System.EventHandler(this.editHyperlinkToolStripMenuItem_Click);
            // 
            // removeHyperlinkMenuItem
            // 
            this.removeHyperlinkMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeHyperlinkMenuItem.Name = "removeHyperlinkMenuItem";
            this.removeHyperlinkMenuItem.Size = new System.Drawing.Size(171, 22);
            resources.ApplyResources(this.removeHyperlinkMenuItem, "removeHyperlinkMenuItem");
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
            // CellsEditorPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.toolStrip1);
            this.Name = "CellsEditorPanel";
            this.Size = new System.Drawing.Size(573, 53);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripSplitButton chartToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem insertChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectChartValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchRowColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}