
namespace SpreadsheetEditorDemo.CustomControls
{
    partial class CellReferencesAppearanceEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellReferencesAppearanceEditorControl));
            this.fillColorLabel = new System.Windows.Forms.Label();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.borderWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fillColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.borderColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumericUpDown)).BeginInit();
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
            // borderColorLabel
            // 
            this.borderColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borderColorLabel.AutoSize = true;
            this.borderColorLabel.Location = new System.Drawing.Point(3, 35);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(68, 13);
            this.borderColorLabel.TabIndex = 8;
            resources.ApplyResources(this.borderColorLabel, "borderColorLabel");
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(3, 62);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(72, 13);
            this.borderWidthLabel.TabIndex = 10;
            resources.ApplyResources(this.borderWidthLabel, "borderWidthLabel");
            // 
            // borderWidthNumericUpDown
            // 
            this.borderWidthNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borderWidthNumericUpDown.Location = new System.Drawing.Point(81, 59);
            this.borderWidthNumericUpDown.Name = "borderWidthNumericUpDown";
            this.borderWidthNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.borderWidthNumericUpDown.TabIndex = 11;
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
            this.tableLayoutPanel1.Controls.Add(this.borderWidthLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.borderColorLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.borderColorPanelControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.borderWidthNumericUpDown, 1, 2);
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
            this.fillColorPanelControl.Location = new System.Drawing.Point(81, 3);
            this.fillColorPanelControl.Name = "fillColorPanelControl";
            this.fillColorPanelControl.Size = new System.Drawing.Size(96, 22);
            this.fillColorPanelControl.TabIndex = 6;
            // 
            // borderColorPanelControl
            // 
            this.borderColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borderColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.borderColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.borderColorPanelControl.Location = new System.Drawing.Point(81, 31);
            this.borderColorPanelControl.Name = "borderColorPanelControl";
            this.borderColorPanelControl.Size = new System.Drawing.Size(96, 22);
            this.borderColorPanelControl.TabIndex = 9;
            // 
            // CellReferencesAppearanceEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CellReferencesAppearanceEditorControl";
            this.Size = new System.Drawing.Size(180, 85);
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DemosCommonCode.CustomControls.ColorPanelControl fillColorPanelControl;
        private System.Windows.Forms.Label fillColorLabel;
        private System.Windows.Forms.Label borderColorLabel;
        private DemosCommonCode.CustomControls.ColorPanelControl borderColorPanelControl;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.NumericUpDown borderWidthNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}