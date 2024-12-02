using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Primitives;
using Vintasoft.Imaging.Office.Spreadsheet.Document;

namespace SpreadsheetEditorDemo.CustomControls
{
    /// <summary>
    /// A control that allows to show and change the <see cref="Vintasoft.Imaging.Office.Spreadsheet.Document.ShapeAppearance"/>.
    /// </summary>
    public partial class ShapeAppearanceEditorControl : UserControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAppearanceEditorControl"/> class.
        /// </summary>
        public ShapeAppearanceEditorControl()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets the shape appearance.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ShapeAppearance ShapeAppearance
        {
            get
            {
                if (DesignMode)
                    return null;
                VintasoftColor fillColor = VintasoftColor.FromArgb(fillColorPanelControl.Color.ToArgb());
                VintasoftColor borderColor = VintasoftColor.FromArgb(outlineColorPanelControl.Color.ToArgb());
                int outlineWidth = (int)outlineWidthNumericUpDown.Value;

                return new ShapeAppearance(fillColor, borderColor, outlineWidth);
            }
            set
            {
                if (value != null)
                {
                    fillColorPanelControl.Color = Color.FromArgb(value.FillColor.ToArgb());
                    outlineColorPanelControl.Color = Color.FromArgb(value.OutlineColor.ToArgb());
                    outlineWidthNumericUpDown.Value = (int)Math.Round(value.OutlineWidth, 0);
                }
                else
                {
                    fillColorPanelControl.Color = Color.Empty;
                    outlineColorPanelControl.Color = Color.Empty;
                    outlineWidthNumericUpDown.Value = 0;
                }

                OnShapeAppearanceChanged();
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="ShapeAppearanceChanged" /> event.
        /// </summary>
        public void OnShapeAppearanceChanged()
        {
            if (ShapeAppearanceChanged != null)
                ShapeAppearanceChanged(this, null);
        }

        /// <summary>
        /// Handles the ColorChanged event of fillColorPanelControl object.
        /// </summary>
        private void fillColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            OnShapeAppearanceChanged();
        }

        /// <summary>
        /// Handles the ColorChanged event of outlineColorPanelControl object.
        /// </summary>
        private void outlineColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            OnShapeAppearanceChanged();
        }

        /// <summary>
        /// Handles the ValueChanged event of outlineWidthNumericUpDown object.
        /// </summary>
        private void outlineWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OnShapeAppearanceChanged();
        }

        #endregion



        #region Events

        /// <summary>
        /// Occurs when <see cref="ShapeAppearance"/> property is changed.
        /// </summary>
        public event EventHandler ShapeAppearanceChanged;


        #endregion

    }
}
