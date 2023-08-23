
namespace SpreadsheetEditorDemo
{
    partial class NavigationPanel
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
            this.worksheetComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.zoomComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.firstWorksheetButton = new System.Windows.Forms.ToolStripButton();
            this.prevWorksheetButton = new System.Windows.Forms.ToolStripButton();
            this.nextWorksheetButton = new System.Windows.Forms.ToolStripButton();
            this.lastWorksheetButton = new System.Windows.Forms.ToolStripButton();
            this.addWorksheetButton = new System.Windows.Forms.ToolStripButton();
            this.worksheetsActionsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHeadingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFormulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.panModeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstWorksheetButton,
            this.prevWorksheetButton,
            this.worksheetComboBox,
            this.nextWorksheetButton,
            this.lastWorksheetButton,
            this.addWorksheetButton,
            this.worksheetsActionsButton,
            this.zoomInButton,
            this.zoomComboBox,
            this.zoomOutButton,
            this.panModeToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // worksheetComboBox
            // 
            this.worksheetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worksheetComboBox.Name = "worksheetComboBox";
            this.worksheetComboBox.Size = new System.Drawing.Size(180, 25);
            this.worksheetComboBox.SelectedIndexChanged += new System.EventHandler(this.worksheetComboBox_SelectedIndexChanged);
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomComboBox.AutoSize = false;
            this.zoomComboBox.Items.AddRange(new object[] {
            "400%",
            "300%",
            "200%",
            "150%",
            "140%",
            "130%",
            "120%",
            "110%",
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "25%",
            "10%"});
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(55, 23);
            this.zoomComboBox.Text = "100%";
            this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
            this.zoomComboBox.Leave += new System.EventHandler(this.zoomComboBox_Leave);
            this.zoomComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zoomComboBox_KeyDown);
            // 
            // firstWorksheetButton
            // 
            this.firstWorksheetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstWorksheetButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NavigateFirst;
            this.firstWorksheetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.firstWorksheetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstWorksheetButton.Name = "firstWorksheetButton";
            this.firstWorksheetButton.Size = new System.Drawing.Size(23, 22);
            this.firstWorksheetButton.Text = "First Worksheet";
            this.firstWorksheetButton.Click += new System.EventHandler(this.firstWorksheetButton_Click);
            // 
            // prevWorksheetButton
            // 
            this.prevWorksheetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevWorksheetButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NavigatePrev;
            this.prevWorksheetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prevWorksheetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevWorksheetButton.Name = "prevWorksheetButton";
            this.prevWorksheetButton.Size = new System.Drawing.Size(23, 22);
            this.prevWorksheetButton.Text = "Previous Worksheet";
            this.prevWorksheetButton.Click += new System.EventHandler(this.prevWorksheetButton_Click);
            // 
            // nextWorksheetButton
            // 
            this.nextWorksheetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextWorksheetButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NavigateNext;
            this.nextWorksheetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nextWorksheetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextWorksheetButton.Name = "nextWorksheetButton";
            this.nextWorksheetButton.Size = new System.Drawing.Size(23, 22);
            this.nextWorksheetButton.Text = "Next Worksheet";
            this.nextWorksheetButton.Click += new System.EventHandler(this.nextWorksheetButton_Click);
            // 
            // lastWorksheetButton
            // 
            this.lastWorksheetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastWorksheetButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NavigateLast;
            this.lastWorksheetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lastWorksheetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastWorksheetButton.Name = "lastWorksheetButton";
            this.lastWorksheetButton.Size = new System.Drawing.Size(23, 22);
            this.lastWorksheetButton.Text = "Last Worksheet";
            this.lastWorksheetButton.Click += new System.EventHandler(this.lastWorksheetButton_Click);
            // 
            // addWorksheetButton
            // 
            this.addWorksheetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addWorksheetButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_Add;
            this.addWorksheetButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addWorksheetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addWorksheetButton.Name = "addWorksheetButton";
            this.addWorksheetButton.Size = new System.Drawing.Size(23, 22);
            this.addWorksheetButton.Text = "Add Woksheet";
            this.addWorksheetButton.Click += new System.EventHandler(this.addWorksheetButton_Click);
            // 
            // worksheetsActionsButton
            // 
            this.worksheetsActionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.worksheetsActionsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.moveMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.worksheetsActionsButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet;
            this.worksheetsActionsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.worksheetsActionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.worksheetsActionsButton.Name = "worksheetsActionsButton";
            this.worksheetsActionsButton.Size = new System.Drawing.Size(34, 22);
            this.worksheetsActionsButton.Text = "Worksheet Actions";
            this.worksheetsActionsButton.ButtonClick += new System.EventHandler(this.worksheetsButton_ButtonClick);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_Copy;
            this.copyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_Delete;
            this.removeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // moveMenuItem
            // 
            this.moveMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_Move;
            this.moveMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moveMenuItem.Name = "moveMenuItem";
            this.moveMenuItem.Size = new System.Drawing.Size(128, 24);
            this.moveMenuItem.Text = "Move...";
            this.moveMenuItem.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_Rename;
            this.renameToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.renameToolStripMenuItem.Text = "Rename...";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHeadingsToolStripMenuItem,
            this.showFormulasToolStripMenuItem,
            this.showGridToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_ViewOptions;
            this.viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showHeadingsToolStripMenuItem
            // 
            this.showHeadingsToolStripMenuItem.Name = "showHeadingsToolStripMenuItem";
            this.showHeadingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showHeadingsToolStripMenuItem.Text = "Show Headings";
            this.showHeadingsToolStripMenuItem.Click += new System.EventHandler(this.showHeadingsToolStripMenuItem_Click);
            // 
            // showFormulasToolStripMenuItem
            // 
            this.showFormulasToolStripMenuItem.Name = "showFormulasToolStripMenuItem";
            this.showFormulasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showFormulasToolStripMenuItem.Text = "Show Formulas";
            this.showFormulasToolStripMenuItem.Click += new System.EventHandler(this.showFormulasToolStripMenuItem_Click);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color...";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Image = global::SpreadsheetEditorDemo.Properties.Resources.Worksheet_FormatProperties;
            this.formatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.formatToolStripMenuItem.Text = "Format...";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ZoomIn;
            this.zoomInButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInButton.Text = "toolStripButton5";
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.ZoomOut;
            this.zoomOutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutButton.Text = "toolStripButton6";
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // panModeToolStripButton
            // 
            this.panModeToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.panModeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panModeToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.PanMode;
            this.panModeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.panModeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panModeToolStripButton.Name = "panModeToolStripButton";
            this.panModeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.panModeToolStripButton.Text = "Pan";
            this.panModeToolStripButton.Click += new System.EventHandler(this.panModeToolStripButton_Click);
            // 
            // NavigationPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton firstWorksheetButton;
        private System.Windows.Forms.ToolStripButton prevWorksheetButton;
        private System.Windows.Forms.ToolStripComboBox worksheetComboBox;
        private System.Windows.Forms.ToolStripButton nextWorksheetButton;
        private System.Windows.Forms.ToolStripButton lastWorksheetButton;
        private System.Windows.Forms.ToolStripSplitButton worksheetsActionsButton;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripComboBox zoomComboBox;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHeadingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFormulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton addWorksheetButton;
        private System.Windows.Forms.ToolStripButton panModeToolStripButton;
    }
}