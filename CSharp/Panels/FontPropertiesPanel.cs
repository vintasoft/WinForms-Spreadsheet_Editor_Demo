using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A panel control that allows to edit font properties.
    /// </summary>
    public partial class FontPropertiesPanel : SpreadsheetVisualEditorPanel
    {

        #region Fields

        /// <summary>
        /// Indicates whether the UI is updating now.
        /// </summary>
        bool _updateUI = false;

        /// <summary>
        /// Indicates whether the font size was changed.
        /// </summary>
        bool _fontSizeChanged = false;
      
        /// <summary>
        /// Current border color, that is applied when setting borders.
        /// </summary>
        Color _borderColor = Color.Black;

        /// <summary>
        /// Current font color, that is applied by font color button.
        /// </summary>
        Color _fontColor = Color.Red;

        /// <summary>
        /// Current fill color, that is applied by fill color button.
        /// </summary>
        Color _fillColor = Color.Yellow;

        /// <summary>
        /// Dictionary: border button => cells borders.
        /// </summary>
        Dictionary<ToolStripDropDownItem, CellsBorders> _buttonsToBorders = new Dictionary<ToolStripDropDownItem, CellsBorders>();

        /// <summary>
        /// The flage that inducates when font name is changed.
        /// </summary>
        bool _fontNameChanged = false;

        /// <summary>
        /// Indicates whether style painting was executed.
        /// </summary>
        bool _setStyleCellIsExecuted = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FontPropertiesPanel"/> class.
        /// </summary>
        public FontPropertiesPanel()
        {
            InitializeComponent();

            foreach (string fontName in CellsStyleForm.GetAvailableFontNames())
                fontNameToolStripComboBox.Items.Add(fontName);

            fontColorButton.BackColor = _fontColor;
            fillColorButton.BackColor = _fillColor;

            // create dictionary to specify transparent areas on buttons icons
            Dictionary<ToolStripSplitButton, Rectangle> buttonsTransparentAreas =
                new Dictionary<ToolStripSplitButton, Rectangle>();

            buttonsTransparentAreas.Add(fontColorButton, new Rectangle(1, 13, 16, 4));
            buttonsTransparentAreas.Add(fillColorButton, new Rectangle(1, 13, 16, 4));
            // create renderer to customize panel icons rendering
            textPropertiesToolStrip.Renderer = new PanelToolStripRenderer(buttonsTransparentAreas);

            InitBordersDropDownMenu();
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Raises the OnSpreadsheetEditorChanged event.
        /// </summary>
        /// <param name="args">The event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (args.OldValue != null)
            {
                args.OldValue.VisualEditor.FocusedCellChanged -= VisualEditor_FocusedCellChanged;
                args.OldValue.VisualEditor.FocusedCellsChanged -= VisualEditor_FocusedCellsChanged;
                args.OldValue.VisualEditor.FocusedCommentChanged -= VisualEditor_FocusedCommentChanged;
                args.OldValue.VisualEditor.CellsStylePropertiesChanged -= VisualEditor_CellsStylePropertiesChanged;
                args.OldValue.VisualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
            }
            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
                args.NewValue.VisualEditor.FocusedCellsChanged += VisualEditor_FocusedCellsChanged;
                args.NewValue.VisualEditor.FocusedCommentChanged += VisualEditor_FocusedCommentChanged;
                args.NewValue.VisualEditor.CellsStylePropertiesChanged += VisualEditor_CellsStylePropertiesChanged;
                args.NewValue.VisualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
            }
            UpdateUI();
        }      

        #endregion


        #region PRIVATE

        #region UI

        private void FontPropertiesPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (VisualEditor != null)
                UpdateUI();
        }

        #region Panel buttons

        #region Font

        /// <summary>
        /// Handles the Leave event of FontNameToolStripComboBox object.
        /// </summary>
        private void fontNameToolStripComboBox_Leave(object sender, EventArgs e)
        {
            SetFontName();
        }

        private void SetFontName()
        {
            if (_fontNameChanged)
            {
                _fontNameChanged = false;
                VisualEditor.FontName = fontNameToolStripComboBox.Text;
                UpdateUI();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of FontNameToolStripComboBox object.
        /// </summary>
        private void fontNameToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!_updateUI)
                _fontNameChanged = true;
        }

        /// <summary>
        /// Handles the KeyDown event of FontNameToolStripComboBox object.
        /// </summary>
        private void fontNameToolStripComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _fontNameChanged = true;
                SetFontName();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontNameToolStripComboBox object.
        /// </summary>
        private void fontNameToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFontName();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the TextChanged event of FontSizeToolStripComboBox object.
        /// </summary>
        private void fontSizeToolStripComboBox_TextChanged(object sender, System.EventArgs e)
        {
            if (_updateUI)
                return;
            _fontSizeChanged = true;
        }

        /// <summary>
        /// Handles the Leave event of FontSizeToolStripComboBox object.
        /// </summary>
        private void fontSizeToolStripComboBox_Leave(object sender, EventArgs e)
        {
            SetFontSize();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontSizeToolStripComboBox object.
        /// </summary>
        private void fontSizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_updateUI)
                return;
            SetFontSize();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the KeyDown event of FontSizeToolStripComboBox object.
        /// </summary>
        private void fontSizeToolStripComboBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetFontSize();
        }

        /// <summary>
        /// Handles the Click event of IncFontSizeToolStripButton object.
        /// </summary>
        private void incFontSizeToolStripButton_Click(object sender, System.EventArgs e)
        {
            int index = GetPredefinedSizeIndex();
            int predefinedFontSize = int.Parse(fontSizeToolStripComboBox.Items[index].ToString());
            if (predefinedFontSize > VisualEditor.FontSize)
                fontSizeToolStripComboBox.SelectedIndex = index;
            else if (index < fontSizeToolStripComboBox.Items.Count - 1)
                fontSizeToolStripComboBox.SelectedIndex = index + 1;
        }

        /// <summary>
        /// Handles the Click event of DecFontSizeToolStripButton object.
        /// </summary>
        private void decFontSizeToolStripButton_Click(object sender, System.EventArgs e)
        {
            int index = GetPredefinedSizeIndex();
            int predefinedFontSize = int.Parse(fontSizeToolStripComboBox.Items[index].ToString());
            if (predefinedFontSize < VisualEditor.FontSize)
                fontSizeToolStripComboBox.SelectedIndex = index;
            else if (index > 0)
                fontSizeToolStripComboBox.SelectedIndex = index - 1;
        }

        /// <summary>
        /// Handles the Click event of BoldFontToolStripButton object.
        /// </summary>
        private void boldFontToolStripButton_Click(object sender, EventArgs e)
        {
            VisualEditor.IsFontBold = !boldFontToolStripButton.Checked;
            UpdateUI();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of ItalicFontToolStripButton object.
        /// </summary>
        private void italicFontToolStripButton_Click(object sender, EventArgs e)
        {
            VisualEditor.IsFontItalic = !italicFontToolStripButton.Checked;
            UpdateUI();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of UnderlineToolStripButton object.
        /// </summary>
        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            VisualEditor.IsFontUnderline = !underlineToolStripButton.Checked;
            UpdateUI();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of StrikeoutToolStripButton object.
        /// </summary>
        private void strikeoutToolStripButton_Click(object sender, EventArgs e)
        {
            VisualEditor.IsFontStrikeout = !strikeoutToolStripButton.Checked;
            UpdateUI();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of NoFillToolStripMenuItem object.
        /// </summary>
        private void noFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fillColor = Color.Empty;
            VisualEditor.FillColor = VintasoftColor.FromArgb(_fillColor.ToArgb());
            fillColorButton.BackColor = _fillColor;
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of SelectFillColorToolStripMenuItem object.
        /// </summary>
        private void selectFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _fillColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog1.Color;
                VisualEditor.FillColor = VintasoftColor.FromArgb(_fillColor.ToArgb());
                fillColorButton.BackColor = _fillColor;
            }
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the ButtonClick event of FontColorButton object.
        /// </summary>
        private void fontColorButton_ButtonClick(object sender, EventArgs e)
        {
            VisualEditor.FontColor = VintasoftColor.FromArgb(_fontColor.ToArgb());
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of SelectFontColorToolStripMenuItem object.
        /// </summary>
        private void selectFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _fontColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _fontColor = colorDialog1.Color;
                VisualEditor.FontColor = VintasoftColor.FromArgb(_fontColor.ToArgb());
                fontColorButton.BackColor = _fontColor;
            }
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Click event of FontPropertiesToolStripButton object.
        /// </summary>
        private void fontPropertiesToolStripButton_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowFontDialog(VisualEditor);
            UpdateUI();
        }

        #endregion


        #region Fill

        /// <summary>
        /// Handles the ButtonClick event of FillColorButton object.
        /// </summary>
        private void fillColorButton_ButtonClick(object sender, EventArgs e)
        {
            VisualEditor.FillColor = VintasoftColor.FromArgb(_fillColor.ToArgb());
            SpreadsheetEditor.Focus();
        }

        #endregion


        #region Borders

        /// <summary>
        /// Initializes border styles for panel button and it's drop down menu items.
        /// </summary>
        private void InitBordersDropDownMenu()
        {
            CellBorder thinBorder = new CellBorder(CellBorderStyle.Thin, VintasoftColor.FromArgb(_borderColor.ToArgb()));
            CellBorder mediumBorder = new CellBorder(CellBorderStyle.Medium, VintasoftColor.FromArgb(_borderColor.ToArgb()));
            CellBorder doubleBorder = new CellBorder(CellBorderStyle.Double, VintasoftColor.FromArgb(_borderColor.ToArgb()));

            // default border for button is "all borders"
            CellsBorders borders = new CellsBorders(new CellBorders(thinBorder), thinBorder, thinBorder);
            _buttonsToBorders.Add(bordersButton, borders);

            // bottom border
            borders = new CellsBorders(new CellBorders(null, null, null, thinBorder), null, null);
            _buttonsToBorders.Add(bottomBorderToolStripMenuItem, borders);

            // top border
            borders = new CellsBorders(new CellBorders(null, null, thinBorder, null), null, null);
            _buttonsToBorders.Add(topBorderToolStripMenuItem, borders);

            // left border
            borders = new CellsBorders(new CellBorders(thinBorder, null, null, null), null, null);
            _buttonsToBorders.Add(leftBorderToolStripMenuItem, borders);

            // right border
            borders = new CellsBorders(new CellBorders(null, thinBorder, null, null), null, null);
            _buttonsToBorders.Add(rightBorderToolStripMenuItem, borders);

            // no border
            _buttonsToBorders.Add(noBorderToolStripMenuItem, null);

            // all borders
            borders = new CellsBorders(new CellBorders(thinBorder), thinBorder, thinBorder);
            _buttonsToBorders.Add(allBordersToolStripMenuItem, borders);

            // outside borders
            borders = new CellsBorders(new CellBorders(thinBorder), null, null);
            _buttonsToBorders.Add(outsideBordersToolStripMenuItem, borders);

            // thick outside borders
            borders = new CellsBorders(new CellBorders(mediumBorder), null, null);
            _buttonsToBorders.Add(thickOutsideBordersToolStripMenuItem, borders);

            // bottom double border
            borders = new CellsBorders(new CellBorders(null, null, null, doubleBorder), null, null);
            _buttonsToBorders.Add(bottomDoubleBorderToolStripMenuItem, borders);

            // thick bottom border
            borders = new CellsBorders(new CellBorders(null, null, null, mediumBorder), null, null);
            _buttonsToBorders.Add(thickBottomBorderToolStripMenuItem, borders);

            // top and bottom borders
            borders = new CellsBorders(new CellBorders(null, null, thinBorder, thinBorder), null, null);
            _buttonsToBorders.Add(topAndBottomBorderToolStripMenuItem, borders);

            // top and thick bottom border
            borders = new CellsBorders(new CellBorders(null, null, thinBorder, mediumBorder), null, null);
            _buttonsToBorders.Add(topAndThickBottomBorderToolStripMenuItem, borders);

            // top and double bottom border
            borders = new CellsBorders(new CellBorders(null, null, thinBorder, doubleBorder), null, null);
            _buttonsToBorders.Add(topAndDoubleBottomBorderToolStripMenuItem, borders);
        }

        /// <summary>
        /// Handles the Click event of BordersToolStripDropDownButton object.
        /// </summary>
        private void bordersToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            ToolStripSplitButton bordersButton = sender as ToolStripSplitButton;
            // if the borders button is clicked
            if (bordersButton != null && bordersButton == this.bordersButton)
            {
                // if border is set
                if (_buttonsToBorders[bordersButton] != null)
                {
                    // set the selected borders style with current border color
                    VisualEditor.CellsBorders = ChangeBordersColor(_buttonsToBorders[bordersButton], _borderColor);
                }
                else
                {
                    // set invisible border
                    VisualEditor.CellsBorders = new CellsBorders(new CellBorders(CellBorder.Invisible), CellBorder.Invisible, CellBorder.Invisible);
                }
                return;
            }

            ToolStripMenuItem borderMenuButton = sender as ToolStripMenuItem;
            // if the menu item is clicked
            if (borderMenuButton != null)
            {
                // if border is set
                if (_buttonsToBorders[borderMenuButton] != null)
                {
                    // get the selected borders with current border color
                    CellsBorders borders = ChangeBordersColor(_buttonsToBorders[borderMenuButton], _borderColor);
                    // set the selected borders to the cells
                    VisualEditor.CellsBorders = borders;
                    // set the selected borders for borders button
                    _buttonsToBorders[this.bordersButton] = borders;
                }
                else
                {
                    // set invisible borders to the cells
                    VisualEditor.CellsBorders = new CellsBorders(new CellBorders(CellBorder.Invisible), CellBorder.Invisible, CellBorder.Invisible);
                    // set null for borders button
                    _buttonsToBorders[this.bordersButton] = null;
                }
                
                // update image of borders button
                this.bordersButton.Image = borderMenuButton.Image;
            }
        }

        /// <summary>
        /// Handles the Click event of BorderColorToolStripMenuItem object.
        /// </summary>
        private void borderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _borderColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _borderColor = colorDialog1.Color;
                VisualEditor.BordersColor = VintasoftColor.FromArgb(_borderColor.ToArgb());
            }
        }

        /// <summary>
        /// Handles the Click event of MoreBordersToolStripMenuItem object.
        /// </summary>
        private void moreBordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowBordersDialog(VisualEditor);
        }

        /// <summary>
        /// Returns a copy of <see cref="CellsBorders"/> with a specified color.
        /// </summary>
        /// <param name="borders">Cells borders.</param>
        /// <param name="color">Color.</param>
        private CellsBorders ChangeBordersColor(CellsBorders borders, Color borderColor)
        {
            VintasoftColor color = VintasoftColor.FromArgb(borderColor.ToArgb());

            CellBorder leftBorder = null;
            CellBorder rightBorder = null;
            CellBorder topBorder = null;
            CellBorder bottomBorder = null;

            if (borders.OutsideBorders != null)
            {
                if (borders.OutsideBorders.Left != null)
                    leftBorder = new CellBorder(borders.OutsideBorders.Left.Style, color);
                if (borders.OutsideBorders.Right != null)
                    rightBorder = new CellBorder(borders.OutsideBorders.Right.Style, color);
                if (borders.OutsideBorders.Top != null)
                    topBorder = new CellBorder(borders.OutsideBorders.Top.Style, color);
                if (borders.OutsideBorders.Bottom != null)
                    bottomBorder = new CellBorder(borders.OutsideBorders.Bottom.Style, color);
            }

            CellBorder horizontalBorder = null;
            if (borders.HorizontalBorder != null)
                horizontalBorder = new CellBorder(borders.HorizontalBorder.Style, color);

            CellBorder verticalBorder = null;
            if (borders.VerticalBorder != null)
                verticalBorder = new CellBorder(borders.VerticalBorder.Style, color);

            CellBorders outsideBorders = new CellBorders(leftBorder, rightBorder, topBorder, bottomBorder);

            return new CellsBorders(outsideBorders, horizontalBorder, verticalBorder);
        }

        #endregion


        #region Style paint

        /// <summary>
        /// Handles the Click event of CopyStyleToolStripButton object.
        /// </summary>
        private void copyStyleToolStripButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.StylePainterSource != null)
                FinishStylePaint();
            else
                StartStylePaint();
        }

        #endregion

        #endregion


        #region Visual Editor

        private void VisualEditor_CellsStylePropertiesChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedCellsChanged(object sender, PropertyChangedEventArgs<CellReferences> e)
        {
            // if source style cell is selected and new selection is complete
            if (VisualEditor.StylePainterSource != null && Equals(e.NewValue, e.OldValue))
            {
                bool isControlKeyPressed = (ModifierKeys & Keys.Control) != 0;

                // if control key is pressed and style painting is executing
                if (isControlKeyPressed || !_setStyleCellIsExecuted)
                    VisualEditor.PerformStylePaint();

                // if control key is not pressed
                if (!isControlKeyPressed)
                    FinishStylePaint();

                _setStyleCellIsExecuted = true;
            }
        }

        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedCommentChanged(object sender, PropertyChangedEventArgs<CellComment> e)
        {
            UpdateUI();
        }

        #endregion

        #endregion


        #region UI state

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        public void UpdateUI()
        {
            if (VisualEditor.IsFocusedWorksheetChanging)
                return;

            _updateUI = true;
            try
            {
                if (VisualEditor.FocusedCell == null && VisualEditor.FocusedComment == null)
                {
                    Enabled = false;
                }
                else
                {
                    Enabled = true;
                    // update panel state from focused cell properties
                    FontProperties fontProperties = VisualEditor.FocusedFontProperties;
                    fontNameToolStripComboBox.Text = fontProperties.Name;
                    fontSizeToolStripComboBox.Text = fontProperties.Size.ToString(UICulture);
                    _fontSizeChanged = false;
                    boldFontToolStripButton.Checked = fontProperties.IsBold;
                    italicFontToolStripButton.Checked = fontProperties.IsItalic;
                    underlineToolStripButton.Checked = fontProperties.IsUnderline;
                    strikeoutToolStripButton.Checked = fontProperties.IsStrikeout;

                    bool commentIsFocused = VisualEditor.FocusedComment != null;
                    bordersButton.Enabled = !commentIsFocused;
                    fontPropertiesToolStripButton.Enabled = !commentIsFocused;
                    copyStyleToolStripButton.Enabled = !commentIsFocused;
                }
            }
            finally
            {
                _updateUI = false;
            }
        }

        #endregion


        #region Font size

        /// <summary>
        /// Sets the font size.
        /// </summary>
        private void SetFontSize()
        {
            if (_fontSizeChanged)
            {
                if (!_updateUI)
                {
                    double size;
                    if (double.TryParse(fontSizeToolStripComboBox.Text, NumberStyles.Number, UICulture, out size))
                        VisualEditor.FontSize = size;
                    UpdateUI();
                }
            }
        }

        /// <summary>
        /// Returns the index of the font size value in the font size combo box.
        /// </summary>
        private int GetPredefinedSizeIndex()
        {
            double size;
            if (!double.TryParse(fontSizeToolStripComboBox.Text, NumberStyles.Number, UICulture, out size))
                size = VisualEditor.Document.Styles[0].FontProperties.Size;
            for (int i = 0; i < fontSizeToolStripComboBox.Items.Count; i++)
                if (int.Parse(fontSizeToolStripComboBox.Items[i].ToString()) >= size)
                    return i;
            return fontSizeToolStripComboBox.Items.Count - 1;
        }

        #endregion


        #region Style painting

        /// <summary>
        /// Activates style painting mode.
        /// </summary>
        private void StartStylePaint()
        {
            _setStyleCellIsExecuted = false;
            copyStyleToolStripButton.CheckState = CheckState.Checked;
            VisualEditor.StylePainterSource = VisualEditor.FocusedCells;
        }

        /// <summary>
        /// Deactivates style painting mode.
        /// </summary>
        private void FinishStylePaint()
        {
            VisualEditor.StylePainterSource = null;
            copyStyleToolStripButton.CheckState = CheckState.Unchecked;
        }

        #endregion

        #endregion

        #endregion

    }
}
