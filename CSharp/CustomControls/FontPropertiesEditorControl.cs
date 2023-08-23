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
            fontStylesListBox.Items.Add("Regular");
            fontStylesListBox.Items.Add("Italic");
            fontStylesListBox.Items.Add("Bold");
            fontStylesListBox.Items.Add("Bold Italic");
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets the font properties.
        /// </summary>
        [Browsable(false)]
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
            bool isBold = fontStyleTextBox.Text == "Bold" || fontStyleTextBox.Text == "Bold Italic";
            bool isItalic = fontStyleTextBox.Text == "Italic" || fontStyleTextBox.Text == "Bold Italic";

            if (fontStyleTextBox.Text == "Regular")
            {
                isBold = false;
                isItalic = false;
            }
            else if (fontStyleTextBox.Text == "Bold")
            {
                isBold = true;
            }
            else if (fontStyleTextBox.Text == "Italic")
            {
                isItalic = true;
            }
            else if (fontStyleTextBox.Text == "Bold Italic")
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
                throw new Exception(string.Format("Font style with name '{0}' does not exist.", fontStyleTextBox.Text));
            }

            // get font size
            double fontSize;
            if (!string.IsNullOrEmpty(fontSizeTextBox.Text))
            {
                double parsedFontSize;
                if (double.TryParse(fontSizeTextBox.Text, NumberStyles.Float, _culture, out parsedFontSize))
                    fontSize = Math.Round(parsedFontSize, 2);
                else
                    throw new Exception("Font size must be an integer or decimal number.");
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
                fontStylesListBox.SelectedItem = "Bold Italic";
            else if (fontProperties.IsBold)
                fontStylesListBox.SelectedItem = "Bold";
            else if (fontProperties.IsItalic)
                fontStylesListBox.SelectedItem = "Italic";
            else
                fontStylesListBox.SelectedItem = "Regular";

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
        /// Handles the SelectedIndexChanged event of FontNamesListBox object.
        /// </summary>
        private void fontNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontNamesListBox.SelectedItem != null)
                fontNameTextBox.Text = fontNamesListBox.Text;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontStylesListBox object.
        /// </summary>
        private void fontStylesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontStylesListBox.SelectedItem != null)
                fontStyleTextBox.Text = fontStylesListBox.Text;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontSizesListBox object.
        /// </summary>
        private void fontSizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontSizesListBox.SelectedItem != null)
                fontSizeTextBox.Text = fontSizesListBox.Text;
        }

        /// <summary>
        /// Handles the Click event of NormalFontButton object.
        /// </summary>
        private void normalFontButton_Click(object sender, EventArgs e)
        {
            // set the UI to the "Normal" style
            SetFontProperties(NormalFontProperties);
        }

        #endregion

    }
}
