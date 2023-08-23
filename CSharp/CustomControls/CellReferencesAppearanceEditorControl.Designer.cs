
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
            this.fillColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.fillColorLabel = new System.Windows.Forms.Label();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.borderColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.borderWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fillColorPanelControl
            // 
            this.fillColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.fillColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.fillColorPanelControl.Location = new System.Drawing.Point(83, 8);
            this.fillColorPanelControl.Name = "fillColorPanelControl";
            this.fillColorPanelControl.Size = new System.Drawing.Size(90, 22);
            this.fillColorPanelControl.TabIndex = 6;
            // 
            // fillColorLabel
            // 
            this.fillColorLabel.AutoSize = true;
            this.fillColorLabel.Location = new System.Drawing.Point(4, 12);
            this.fillColorLabel.Name = "fillColorLabel";
            this.fillColorLabel.Size = new System.Drawing.Size(49, 13);
            this.fillColorLabel.TabIndex = 7;
            this.fillColorLabel.Text = "Fill Color:";
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.AutoSize = true;
            this.borderColorLabel.Location = new System.Drawing.Point(4, 41);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(68, 13);
            this.borderColorLabel.TabIndex = 8;
            this.borderColorLabel.Text = "Border Color:";
            // 
            // borderColorPanelControl
            // 
            this.borderColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.borderColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.borderColorPanelControl.Location = new System.Drawing.Point(83, 36);
            this.borderColorPanelControl.Name = "borderColorPanelControl";
            this.borderColorPanelControl.Size = new System.Drawing.Size(90, 22);
            this.borderColorPanelControl.TabIndex = 9;
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(4, 70);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(72, 13);
            this.borderWidthLabel.TabIndex = 10;
            this.borderWidthLabel.Text = "Border Width:";
            // 
            // borderWidthNumericUpDown
            // 
            this.borderWidthNumericUpDown.Location = new System.Drawing.Point(83, 66);
            this.borderWidthNumericUpDown.Name = "borderWidthNumericUpDown";
            this.borderWidthNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.borderWidthNumericUpDown.TabIndex = 11;
            // 
            // CellsAppearanceSettingsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.borderWidthNumericUpDown);
            this.Controls.Add(this.borderWidthLabel);
            this.Controls.Add(this.borderColorPanelControl);
            this.Controls.Add(this.borderColorLabel);
            this.Controls.Add(this.fillColorLabel);
            this.Controls.Add(this.fillColorPanelControl);
            this.Name = "CellsAppearanceSettingsControl";
            this.Size = new System.Drawing.Size(180, 92);
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumericUpDown)).EndInit();
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
    }
}