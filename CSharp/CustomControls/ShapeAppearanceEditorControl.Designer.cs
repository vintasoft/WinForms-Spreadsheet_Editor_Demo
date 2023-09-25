
namespace SpreadsheetEditorDemo.CustomControls
{
    partial class ShapeAppearanceEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeAppearanceEditorControl));
            this.fillColorLabel = new System.Windows.Forms.Label();
            this.outlineColorLabel = new System.Windows.Forms.Label();
            this.outlineWidthLabel = new System.Windows.Forms.Label();
            this.outlineWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fillColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.outlineColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.outlineWidthNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fillColorLabel.AutoSize = true;
            this.fillColorLabel.Location = new System.Drawing.Point(3, 7);
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(49, 13);
            this.fillColorLabel.TabIndex = 7;
            resources.ApplyResources(this.fillColorLabel, "fillColorLabel");
            // 
            // outlineColorLabel
            // 
            this.outlineColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outlineColorLabel.AutoSize = true;
            this.outlineColorLabel.Location = new System.Drawing.Point(3, 35);
            this.outlineColorLabel.Name = "outlineColorLabel";
            this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
            this.outlineColorLabel.TabIndex = 8;
            resources.ApplyResources(this.outlineColorLabel, "outlineColorLabel");
            // 
            // outlineWidthLabel
            // 
            this.outlineWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outlineWidthLabel.AutoSize = true;
            this.outlineWidthLabel.Location = new System.Drawing.Point(3, 62);
            this.outlineWidthLabel.Name = "outlineWidthLabel";
            this.outlineWidthLabel.Size = new System.Drawing.Size(74, 13);
            this.outlineWidthLabel.TabIndex = 10;
            resources.ApplyResources(this.outlineWidthLabel, "outlineWidthLabel");
            // 
            // outlineWidthNumericUpDown
            // 
            this.outlineWidthNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outlineWidthNumericUpDown.Location = new System.Drawing.Point(83, 59);
            this.outlineWidthNumericUpDown.Name = "outlineWidthNumericUpDown";
            this.outlineWidthNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.outlineWidthNumericUpDown.TabIndex = 11;
            this.outlineWidthNumericUpDown.ValueChanged += new System.EventHandler(this.outlineWidthNumericUpDown_ValueChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.fillColorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fillColorPanelControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outlineWidthLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outlineColorLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outlineColorPanelControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outlineWidthNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 85);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // fillColorPanelControl
            // 
            this.fillColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fillColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.fillColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.fillColorPanelControl.Location = new System.Drawing.Point(83, 3);
            this.fillColorPanelControl.Name = "fillColorPanelControl";
            this.fillColorPanelControl.Size = new System.Drawing.Size(94, 22);
            this.fillColorPanelControl.TabIndex = 6;
            this.fillColorPanelControl.ColorChanged += new System.EventHandler(this.fillColorPanelControl_ColorChanged);
            // 
            // outlineColorPanelControl
            // 
            this.outlineColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.outlineColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.outlineColorPanelControl.Location = new System.Drawing.Point(83, 31);
            this.outlineColorPanelControl.Name = "outlineColorPanelControl";
            this.outlineColorPanelControl.Size = new System.Drawing.Size(94, 22);
            this.outlineColorPanelControl.TabIndex = 9;
            this.outlineColorPanelControl.ColorChanged += new System.EventHandler(this.outlineColorPanelControl_ColorChanged);
            // 
            // ShapeAppearanceEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShapeAppearanceEditorControl";
            this.Size = new System.Drawing.Size(180, 85);
            ((System.ComponentModel.ISupportInitialize)(this.outlineWidthNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DemosCommonCode.CustomControls.ColorPanelControl fillColorPanelControl;
        private System.Windows.Forms.Label fillColorLabel;
        private System.Windows.Forms.Label outlineColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl outlineColorPanelControl;
        private System.Windows.Forms.Label outlineWidthLabel;
        private System.Windows.Forms.NumericUpDown outlineWidthNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}