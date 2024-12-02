using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo.CustomControls
{
    /// <summary>
    /// A control that allows to show and change the appearance settings of cells.
    /// </summary>
    public partial class CellReferencesAppearanceEditorControl : UserControl
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CellReferencesAppearanceEditorControl"/> class.
        /// </summary>
        public CellReferencesAppearanceEditorControl()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Gets or sets the appearance of current cell.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CellReferencesAppearance CellsAppearance
        {
            get
            {
                if (DesignMode)
                    return null;
                VintasoftColor fillColor = VintasoftColor.FromArgb(fillColorPanelControl.Color.ToArgb());
                VintasoftColor borderColor = VintasoftColor.FromArgb(borderColorPanelControl.Color.ToArgb());
                int borderWidth = (int)borderWidthNumericUpDown.Value;

                return new CellReferencesAppearance(fillColor, borderColor, borderWidth);
            }
            set
            {
                if (value != null)
                {
                    fillColorPanelControl.Color = Color.FromArgb(value.FillColor.ToArgb());
                    borderColorPanelControl.Color = Color.FromArgb(value.BorderColor.ToArgb());
                    borderWidthNumericUpDown.Value = (int)Math.Round(value.BorderWidth, 0);
                }
                else
                {
                    fillColorPanelControl.Color = Color.Empty;
                    borderColorPanelControl.Color = Color.Empty;
                    borderWidthNumericUpDown.Value = 0;
                }
            }
        }

    }
}
