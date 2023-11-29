
namespace SpreadsheetEditorDemo
{
    partial class FilePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.infoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.layoutSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.optionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openWorksheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveWorksheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.imagePrintDocument1 = new Vintasoft.Imaging.Print.ImagePrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.infoToolStripButton,
            this.saveToolStripButton,
            this.saveAsToolStripButton,
            this.exportToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripSplitButton,
            this.toolStripSeparator2,
            this.closeToolStripButton,
            this.optionsToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(561, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.NewBlankWorksheet;
            this.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.newToolStripButton, "newToolStripButton");
            this.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.AutoSize = false;
            this.openToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Open;
            this.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // infoToolStripButton
            // 
            this.infoToolStripButton.AutoSize = false;
            this.infoToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.DocumentInfo;
            this.infoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.infoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoToolStripButton.Name = "infoToolStripButton";
            this.infoToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.infoToolStripButton, "infoToolStripButton");
            this.infoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.infoToolStripButton.Click += new System.EventHandler(this.infoToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AutoSize = false;
            this.saveToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Save;
            this.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // saveAsToolStripButton
            // 
            this.saveAsToolStripButton.AutoSize = false;
            this.saveAsToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.SaveAs;
            this.saveAsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveAsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripButton.Name = "saveAsToolStripButton";
            this.saveAsToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.saveAsToolStripButton, "saveAsToolStripButton");
            this.saveAsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveAsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.saveAsToolStripButton.Click += new System.EventHandler(this.saveAsToolStripButton_Click);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.AutoSize = false;
            this.exportToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Export;
            this.exportToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.exportToolStripButton, "exportToolStripButton");
            this.exportToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.exportToolStripButton.Click += new System.EventHandler(this.exportToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // printToolStripSplitButton
            // 
            this.printToolStripSplitButton.AutoSize = false;
            this.printToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutSettingsToolStripMenuItem,
            this.pageSettingsToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.printToolStripSplitButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Print;
            this.printToolStripSplitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripSplitButton.Name = "printToolStripSplitButton";
            this.printToolStripSplitButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.printToolStripSplitButton, "printToolStripSplitButton");
            this.printToolStripSplitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printToolStripSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.printToolStripSplitButton.ButtonClick += new System.EventHandler(this.printToolStripSplitButton_ButtonClick);
            // 
            // layoutSettingsToolStripMenuItem
            // 
            this.layoutSettingsToolStripMenuItem.Name = "layoutSettingsToolStripMenuItem";
            this.layoutSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.layoutSettingsToolStripMenuItem, "layoutSettingsToolStripMenuItem");
            this.layoutSettingsToolStripMenuItem.Click += new System.EventHandler(this.layoutSettingsToolStripMenuItem_Click);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.pageSettingsToolStripMenuItem, "pageSettingsToolStripMenuItem");
            this.pageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pageSettingsToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.AutoSize = false;
            this.closeToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Close;
            this.closeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.closeToolStripButton, "closeToolStripButton");
            this.closeToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // optionsToolStripButton
            // 
            this.optionsToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripButton.AutoSize = false;
            this.optionsToolStripButton.Image = global::SpreadsheetEditorDemo.Properties.Resources.Settings;
            this.optionsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optionsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optionsToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.optionsToolStripButton.Name = "optionsToolStripButton";
            this.optionsToolStripButton.Size = new System.Drawing.Size(50, 50);
            resources.ApplyResources(this.optionsToolStripButton, "optionsToolStripButton");
            this.optionsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.optionsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            this.optionsToolStripButton.Click += new System.EventHandler(this.optionsToolStripButton_Click);
            // 
            // openWorksheetFileDialog
            // 
            this.openWorksheetFileDialog.Filter = "XLSX files|*.xlsx|XLS files|*.xls|TSV files|*.tsv;*.tab|CSV files|*.csv|All suppo" +
    "rted Workbooks|*.xlsx;*.xls;*.tsv;*.tab;*.csv";
            this.openWorksheetFileDialog.FilterIndex = 5;
            // 
            // saveWorksheetFileDialog
            // 
            this.saveWorksheetFileDialog.Filter = "XLSX files|*.xlsx";
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
            // FilePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip1);
            this.Name = "FilePanel";
            this.Size = new System.Drawing.Size(561, 52);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton infoToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripButton optionsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openWorksheetFileDialog;
        private System.Windows.Forms.SaveFileDialog saveWorksheetFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ToolStripSplitButton printToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem layoutSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Vintasoft.Imaging.Print.ImagePrintDocument imagePrintDocument1;
    }
}