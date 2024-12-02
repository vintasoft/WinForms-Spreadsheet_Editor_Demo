using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo.CustomControls
{
    /// <summary>
    /// A control that allows to show and change the font properties.
    /// </summary>
    public partial class FontPropertiesEditorControl : UserControl
    {

        #region Fields

        /// <summary>
        /// A value indicating whether control initialization is finished.
        /// </summary>
        bool _initializationFinished = false;

        /// <summary>
        /// The initial font properties.
        /// </summary>
        FontProperties _initialFontProperties;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FontPropertiesEditorControl"/> class.
        /// </summary>
        public FontPropertiesEditorControl()
        {
            InitializeComponent();

            // init font styles listbox
            fontStylesListBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_REGULAR);
            fontStylesListBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_ITALIC);
            fontStylesListBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD);
            fontStylesListBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ITALIC);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets the font properties.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FontProperties FontProperties
        {
            get
            {
                if (DesignMode)
                    return null;
                return GetFontProperties();
            }
            set
            {
                _initialFontProperties = value;

                _initializationFinished = false;
                SetFontProperties(value);
                _initializationFinished = true;
            }
        }

        FontProperties _normalFontProperties;
        /// <summary>
        /// Gets or sets the "Normal" font properties.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FontProperties NormalFontProperties
        {
            get
            {
                if (DesignMode)
                    return null;
                return _normalFontProperties;
            }
            set
            {
                _normalFontProperties = value;
            }
        }

        CultureInfo _culture;
        /// <summary>
        /// The current culture.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CultureInfo Culture
        {
            get
            {
                return _culture;
            }
            set
            {
                _culture = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns the font properties.
        /// </summary>
        /// <returns>The font properties.</returns>
        private FontProperties GetFontProperties()
        {
            // get font name
            string fontName;
            if (!string.IsNullOrEmpty(fontNameTextBox.Text))
                fontName = fontNameTextBox.Text;
            else
                fontName = _initialFontProperties.Name;

            // get font style
            bool isBold = fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ALT1 || fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ITALIC_ALT1;
            bool isItalic = fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_ITALIC_ALT1 || fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ITALIC_ALT2;

            if (fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_REGULAR_ALT1)
            {
                isBold = false;
                isItalic = false;
            }
            else if (fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ALT2)
            {
                isBold = true;
            }
            else if (fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_ITALIC_ALT2)
            {
                isItalic = true;
            }
            else if (fontStyleTextBox.Text == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ITALIC_ALT3)
            {
                isBold = true;
                isItalic = true;
            }
            else if (string.IsNullOrEmpty(fontStyleTextBox.Text))
            {
                isBold = _initialFontProperties.IsBold;
                isItalic = _initialFontProperties.IsItalic;
            }
            else
            {
                throw new Exception(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_FONT_STYLE_WITH_NAME_ARG0_DOES_NOT_EXIST, fontStyleTextBox.Text));
            }

            // get font size
            double fontSize;
            if (!string.IsNullOrEmpty(fontSizeTextBox.Text))
            {
                double parsedFontSize;
                if (double.TryParse(fontSizeTextBox.Text, NumberStyles.Float, _culture, out parsedFontSize))
                    fontSize = Math.Round(parsedFontSize, 2);
                else
                    throw new Exception(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_FONT_SIZE_MUST_BE_AN_INTEGER_OR_DECIMAL_NUMBER);
            }
            else
            {
                fontSize = _initialFontProperties.Size;
            }

            // get font effects
            bool isUnderline = underlineCheckBox.Checked;
            bool isStrikethrough = strikethroughCheckBox.Checked;

            // get font color
            VintasoftColor fontColor = VintasoftColor.FromArgb(fontColorPanelControl.Color.ToArgb());

            return new FontProperties(fontName, fontSize, fontColor, isBold, isItalic, isUnderline, isStrikethrough);
        }

        /// <summary>
        /// Initializes the UI with font properties.
        /// </summary>
        /// <param name="fontProperties">The font properties.</param>
        private void SetFontProperties(FontProperties fontProperties)
        {
            if (fontProperties == null)
            {
                this.Enabled = false;
                return;
            }
            else
            {
                this.Enabled = true;
            }

            if (!_initializationFinished)
            {
                // initialize names of available fonts

                foreach (string fontName in CellsStyleForm.GetAvailableFontNames())
                    fontNamesListBox.Items.Add(fontName);
            }

            // init font name
            fontNamesListBox.SelectedItem = fontProperties.Name;

            // init font style
            if (fontProperties.IsBold && fontProperties.IsItalic)
                fontStylesListBox.SelectedItem = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ITALIC_ALT4;
            else if (fontProperties.IsBold)
                fontStylesListBox.SelectedItem = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_BOLD_ALT3;
            else if (fontProperties.IsItalic)
                fontStylesListBox.SelectedItem = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_ITALIC_ALT3;
            else
                fontStylesListBox.SelectedItem = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOMCONTROLS_REGULAR_ALT2;

            // init font size
            double fontSize = fontProperties.Size;
            fontSizeTextBox.Text = fontSize.ToString(_culture);
            if (fontSizesListBox.Items.Contains(fontSizeTextBox.Text))
                fontSizesListBox.SelectedItem = fontSizeTextBox.Text;
            else
                fontSizesListBox.SelectedItem = null;

            // init text underline
            underlineCheckBox.Checked = fontProperties.IsUnderline;

            // init text strikeout
            strikethroughCheckBox.Checked = fontProperties.IsStrikeout;

            // init font color
            VintasoftColor fontColor = fontProperties.Color;
            fontColorPanelControl.Color = Color.FromArgb(fontColor.ToArgb());
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of fontNamesListBox object.
        /// </summary>
        private void fontNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontNamesListBox.SelectedItem != null)
                fontNameTextBox.Text = fontNamesListBox.Text;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of fontStylesListBox object.
        /// </summary>
        private void fontStylesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontStylesListBox.SelectedItem != null)
                fontStyleTextBox.Text = fontStylesListBox.Text;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of fontSizesListBox object.
        /// </summary>
        private void fontSizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontSizesListBox.SelectedItem != null)
                fontSizeTextBox.Text = fontSizesListBox.Text;
        }

        /// <summary>
        /// Handles the Click event of normalFontButton object.
        /// </summary>
        private void normalFontButton_Click(object sender, EventArgs e)
        {
            // set the UI to the "Normal" style
            SetFontProperties(NormalFontProperties);
        }

        #endregion

    }
}
