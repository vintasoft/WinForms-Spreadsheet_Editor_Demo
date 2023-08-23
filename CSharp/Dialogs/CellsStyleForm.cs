﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Vintasoft.Imaging;
using Vintasoft.Imaging.Fonts;
using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.NumberFormats;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the style of cells.
    /// </summary>
    public partial class CellsStyleForm : Form
    {

        #region Fields

        /// <summary>
        /// Current spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        /// <summary>
        /// A value indicating whether form initialization is finished.
        /// </summary>
        bool _initializationFinished = false;

        /// <summary>
        /// Dictionary that contains changed properties: property => new property value.
        /// </summary>
        Dictionary<CellStyleProperty, object> _changedProperties = new Dictionary<CellStyleProperty, object>();

        /// <summary>
        /// Current cells borders.
        /// </summary>
        CellsBorders _currentBorders;

        /// <summary>
        /// Current number format.
        /// </summary>
        NumberFormat _currentFormat;

        /// <summary>
        /// Standard number formats.
        /// </summary>
        List<NumberFormat> _standartFormats = new List<NumberFormat>();

        /// <summary>
        /// Dictionary: format string => number format.
        /// </summary>
        Dictionary<string, NumberFormat> _formatStringToStandartFormat = new Dictionary<string, NumberFormat>();

        /// <summary>
        /// Dictionary: currency format name => currency format.
        /// </summary>
        Dictionary<string, CurrencyFormat> _currencyFormatNameToFormat = new Dictionary<string, CurrencyFormat>();

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CellsStyleForm"/> class.
        /// </summary>
        public CellsStyleForm()
        {
            InitializeComponent();

            // Number Format

            // add currency formats
            foreach (CurrencyFormat currencyFormat in SupportedNumberFormats.GetNumberFormats(NumberFormatCategory.Currency))
                _currencyFormatNameToFormat.Add(currencyFormat.Name, currencyFormat);

            // add date formats
            foreach (DateFormat dateFormat in SupportedNumberFormats.GetNumberFormats(NumberFormatCategory.Date))
                dateFormatsListBox.Items.Add(dateFormat.ToString(FormattingProperties));

            // add time formats
            foreach (TimeFormat timeFormat in SupportedNumberFormats.GetNumberFormats(NumberFormatCategory.Time))
                timeFormatsListBox.Items.Add(timeFormat.ToString(FormattingProperties));

            // add all supported formats
            _standartFormats = SupportedNumberFormats.GetNumberFormats(NumberFormatCategory.All);


            // Alignment
            foreach (TextHorizontalAlign horizontalAlignment in Enum.GetValues(typeof(TextHorizontalAlign)))
                textHorizontalAlignmentComboBox.Items.Add(horizontalAlignment);

            foreach (TextVerticalAlign verticalAlignment in Enum.GetValues(typeof(TextVerticalAlign)))
                textVerticalAlignmentComboBox.Items.Add(verticalAlignment);


            // Font
            foreach (string fontName in GetAvailableFontNames())
                fontNamesListBox.Items.Add(fontName);

            fontStylesListBox.Items.Add("Regular");
            fontStylesListBox.Items.Add("Italic");
            fontStylesListBox.Items.Add("Bold");
            fontStylesListBox.Items.Add("Bold Italic");

            // Borders
            foreach (CellBorderStyle borderStyle in Enum.GetValues(typeof(CellBorderStyle)))
                lineStylesListBox.Items.Add(new CellBorderStyleItem(borderStyle));
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the current culture.
        /// </summary>
        [Browsable(false)]
        public CultureInfo Culture
        {
            get
            {
                if (_visualEditor != null)
                {
                    try
                    {
                        return CultureInfo.GetCultureInfo(_visualEditor.DocumentCulture);
                    }
                    catch
                    {
                    }
                }
                return CultureInfo.CurrentCulture;
            }
        }

        /// <summary>
        /// Gets the formatting properties.
        /// </summary>
        [Browsable(false)]
        public FormattingProperties FormattingProperties
        {
            get
            {
                if (_visualEditor != null)
                    return _visualEditor.Document.Defaults.FormattingProperties;

                return null;
            }
        }

        #endregion



        #region Methods

        #region Number Format

        /// <summary>
        /// Shows this form with opened 'Number' tab.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowNumberFormatDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (CellsStyleForm form = new CellsStyleForm())
            {
                form.SetVisualEditor(visualEditor);
                form.cellStyleTabControl.SelectedTab = form.numberFormatTabPage;
                return form.ShowDialog();
            }
        }

        /// <summary>
        /// Initializes the UI with number format properties.
        /// </summary>
        /// <param name="properties">Initial properties.</param>
        private void InitNumberFormatPropertiesUI(Dictionary<CellStyleProperty, object> commonProperties)
        {
            // fill the formats listBox
            foreach (NumberFormat numberFormat in _standartFormats)
            {
                string standartFormatString = numberFormat.ToString(FormattingProperties);
                customFormatsListBox.Items.Add(standartFormatString);
                _formatStringToStandartFormat.Add(standartFormatString, numberFormat);
            }

            // fill the currency symbol formats comboBox
            foreach (string currencyFormatName in _currencyFormatNameToFormat.Keys)
                currencySymbolComboBox.Items.Add(currencyFormatName);

            currencySymbolComboBox.SelectedItem = currencySymbolComboBox.Items[0];

            // if selection contains different formats
            if (!commonProperties.ContainsKey(CellStyleProperty.NumberFormat))
            {
                _currentFormat = null;
                return;
            }

            // get format string
            string formatString = (string)commonProperties[CellStyleProperty.NumberFormat];
            customFormatTextBox.Text = formatString;

            // get number format
            NumberFormat format = GetNumberingFormat(formatString);

            // select format tab page

            if (format is GeneralFormat)
            {
                formatCategoriesTabControl.SelectedTab = generalTabPage;
            }
            else if (format is NumberingFormat)
            {
                NumberingFormat numberingFormat = (NumberingFormat)format;
                formatCategoriesTabControl.SelectedTab = numberTabPage;
                numberDecimalPlacesNumericUpDown.Value = numberingFormat.DecimalPlaces;
                useThousandsSeparatorCheckBox.Checked = numberingFormat.UseThousandsSeparator;
                useRedColorForNegativeCheckBox.Checked = numberingFormat.NegativeValueColor == "Red";
                hideMinusSignCheckBox.Checked = numberingFormat.HideMinusSign;
            }
            else if (format is DateFormat)
            {
                DateFormat dateFormat = (DateFormat)format;
                formatCategoriesTabControl.SelectedTab = dateTabPage;
                dateFormatsListBox.SelectedItem = dateFormat.ToString(FormattingProperties);
            }
            else if (format is TimeFormat)
            {
                TimeFormat timeFormat = (TimeFormat)format;
                formatCategoriesTabControl.SelectedTab = timeTabPage;
                timeFormatsListBox.SelectedItem = timeFormat.ToString(FormattingProperties);
            }
            else if (format is CurrencyFormat)
            {
                CurrencyFormat currencyFormat = (CurrencyFormat)format;
                formatCategoriesTabControl.SelectedTab = currencyTabPage;
                currencyDecimalPlacesNumericUpDown.Value = currencyFormat.DecimalPlaces;
                if (currencySymbolComboBox.Items.Contains(currencyFormat.Name))
                    currencySymbolComboBox.SelectedItem = currencyFormat.Name;
            }
            else if (format is PercentageFormat)
            {
                PercentageFormat percentageFormat = (PercentageFormat)format;
                formatCategoriesTabControl.SelectedTab = percentageTabPage;
                percentageDecimalPlacesNumericUpDown.Value = percentageFormat.DecimalPlaces;
            }
            else if (format is ScientificFormat)
            {
                ScientificFormat scientificFormat = (ScientificFormat)format;
                formatCategoriesTabControl.SelectedTab = scientificTabPage;
                scientificDecimalPlacesNumericUpDown.Value = scientificFormat.DecimalPlaces;
            }
            else if (format is TextFormat)
            {
                formatCategoriesTabControl.SelectedTab = textTabPage;
            }
            else
            {
                formatCategoriesTabControl.SelectedTab = customTabPage;
                // add custom format to listBox
                if (!customFormatsListBox.Items.Contains(customFormatTextBox.Text))
                    customFormatsListBox.Items.Add(customFormatTextBox.Text);
                // set selected format in listBox
                customFormatsListBox.SelectedItem = customFormatTextBox.Text;
            }

            _currentFormat = format;
        }


        #region Format tab control

        /// <summary>
        /// Handles the SelectedIndexChanged event of FormatCategoriesTabControl object.
        /// </summary>
        private void formatCategoriesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            NumberFormat format = _currentFormat;

            // set a new format from selected tab page

            if (formatCategoriesTabControl.SelectedTab == generalTabPage)
            {
                // create general format
                format = new GeneralFormat();
            }
            else if (formatCategoriesTabControl.SelectedTab == numberTabPage)
            {
                string negativeColor = null;

                if (useRedColorForNegativeCheckBox.Checked)
                    negativeColor = "Red";

                // create numbering format
                format = new NumberingFormat(
                    (int)numberDecimalPlacesNumericUpDown.Value,
                    useThousandsSeparatorCheckBox.Checked,
                    negativeColor,
                    hideMinusSignCheckBox.Checked);
            }
            else if (formatCategoriesTabControl.SelectedTab == currencyTabPage)
            {
                CurrencyFormat currencyFormat = _currencyFormatNameToFormat[currencySymbolComboBox.SelectedItem.ToString()];
                // create currency format
                format = new CurrencyFormat(
                    (int)currencyDecimalPlacesNumericUpDown.Value,
                    currencyFormat.CurrencySymbolFormat,
                    currencyFormat.IsCurrencySymbolBeforeValue);
            }
            else if (formatCategoriesTabControl.SelectedTab == dateTabPage)
            {
                // create date format
                format = DateFormat.Create(dateFormatsListBox.Items[0].ToString());
                dateFormatsListBox.SelectedIndex = 0;
            }
            else if (formatCategoriesTabControl.SelectedTab == timeTabPage)
            {
                // create time format
                format = TimeFormat.Create(timeFormatsListBox.Items[0].ToString());
                timeFormatsListBox.SelectedIndex = 0;
            }
            else if (formatCategoriesTabControl.SelectedTab == percentageTabPage)
            {
                // create percentage format
                format = new PercentageFormat((int)percentageDecimalPlacesNumericUpDown.Value);
            }
            else if (formatCategoriesTabControl.SelectedTab == scientificTabPage)
            {
                // create scientific format
                format = new ScientificFormat((int)scientificDecimalPlacesNumericUpDown.Value);
            }
            else if (formatCategoriesTabControl.SelectedTab == textTabPage)
            {
                // create text format
                format = new TextFormat();
            }
            else if (formatCategoriesTabControl.SelectedTab == customTabPage)
            {
                if (_currentFormat != null)
                {
                    customFormatTextBox.Text = _currentFormat.ToString(FormattingProperties);
                    // add custom format to the listBox
                    if (!customFormatsListBox.Items.Contains(customFormatTextBox.Text))
                        customFormatsListBox.Items.Add(customFormatTextBox.Text);

                    // set selected format in listBox
                    customFormatsListBox.SelectedItem = customFormatTextBox.Text;
                }
            }

            if (_currentFormat != null)
            {
                // update current format
                _currentFormat = format;
                // save changes about number format
                _changedProperties[CellStyleProperty.NumberFormat] = format.ToString(FormattingProperties);
            }
        }

        #endregion


        #region Number tab page

        /// <summary>
        /// Handles the ValueChanged event of NumberDecimalPlacesNumericUpDown object.
        /// </summary>
        private void numberDecimalPlacesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((NumberingFormat)_currentFormat).DecimalPlaces = (int)numberDecimalPlacesNumericUpDown.Value;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        /// <summary>
        /// Handles the CheckedChanged event of UseThousandsSeparatorCheckBox object.
        /// </summary>
        private void useThousandsSeparatorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((NumberingFormat)_currentFormat).UseThousandsSeparator = useThousandsSeparatorCheckBox.Checked;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        /// <summary>
        /// Handles the CheckedChanged event of UseRedColorForNegativeCheckBox object.
        /// </summary>
        private void useRedColorForNegativeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (useRedColorForNegativeCheckBox.Checked)
                ((NumberingFormat)_currentFormat).NegativeValueColor = "Red";
            else
                ((NumberingFormat)_currentFormat).NegativeValueColor = null;

            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        /// <summary>
        /// Handles the CheckedChanged event of HideMinusSignCheckBox object.
        /// </summary>
        private void hideMinusSignCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((NumberingFormat)_currentFormat).HideMinusSign = hideMinusSignCheckBox.Checked;

            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        #endregion


        #region Currency tab page

        /// <summary>
        /// Handles the ValueChanged event of CurrencyDecimalPlacesNumericUpDown object.
        /// </summary>
        private void currencyDecimalPlacesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((CurrencyFormat)_currentFormat).DecimalPlaces = (int)currencyDecimalPlacesNumericUpDown.Value;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event of CurrencySymbolComboBox object.
        /// </summary>
        private void currencySymbolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // get currency symbol format
            CurrencyFormat currencyFormat = _currencyFormatNameToFormat[currencySymbolComboBox.SelectedItem.ToString()];

            ((CurrencyFormat)_currentFormat).CurrencySymbolFormat = currencyFormat.CurrencySymbolFormat;
            ((CurrencyFormat)_currentFormat).IsCurrencySymbolBeforeValue = currencyFormat.IsCurrencySymbolBeforeValue;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        #endregion


        #region Date tab page

        /// <summary>
        /// Handles the SelectedIndexChanged event of DateFormatsListBox object.
        /// </summary>
        private void dateFormatsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // create date format
            _currentFormat = DateFormat.Create(dateFormatsListBox.SelectedItem.ToString());

            if (_currentFormat != null)
            {
                // save changes about number format
                _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
            }
        }

        #endregion


        #region Time tab page


        /// <summary>
        /// Handles the SelectedIndexChanged event of TimeFormatsListBox object.
        /// </summary>
        private void timeFormatsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // create time format
            _currentFormat = TimeFormat.Create(timeFormatsListBox.SelectedItem.ToString());

            if (_currentFormat != null)
            {
                // save changes about number format
                _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
            }
        }

        #endregion


        #region Percentage tab page

        /// <summary>
        /// Handles the ValueChanged event of PercentageDecimalPlacesNumericUpDown object.
        /// </summary>
        private void percentageDecimalPlacesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((PercentageFormat)_currentFormat).DecimalPlaces = (int)percentageDecimalPlacesNumericUpDown.Value;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        #endregion


        #region Scientific tab page

        /// <summary>
        /// Handles the ValueChanged event of ScientificDecimalPlacesNumericUpDown object.
        /// </summary>
        private void scientificDecimalPlacesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            ((ScientificFormat)_currentFormat).DecimalPlaces = (int)scientificDecimalPlacesNumericUpDown.Value;
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        #endregion


        #region Custom tab page

        /// <summary>
        /// Handles the SelectedIndexChanged event of CustomFormatsListBox object.
        /// </summary>
        private void customFormatsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (customFormatsListBox.SelectedItem == null)
                return;

            customFormatTextBox.Text = customFormatsListBox.SelectedItem.ToString();
            // get selected format
            _currentFormat = _visualEditor.Document.ParseNumberFormat(customFormatTextBox.Text);
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        /// <summary>
        /// Handles the Leave event of CustomFormatTextBox object.
        /// </summary>
        private void customFormatTextBox_Leave(object sender, EventArgs e)
        {
            // get format
            _currentFormat = GetNumberingFormat(customFormatTextBox.Text);
            // save changes about number format
            _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
        }

        private void customFormatTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // get format
                _currentFormat = GetNumberingFormat(customFormatTextBox.Text);
                // save changes about number format
                _changedProperties[CellStyleProperty.NumberFormat] = _currentFormat.ToString(FormattingProperties);
            }
        }

        #endregion


        /// <summary>
        /// Returns number format, which is created from specified format string.
        /// </summary>
        /// <param name="formatString">The format string.</param>
        /// <returns>The number format.</returns>
        private NumberFormat GetNumberingFormat(string formatString)
        {
            // if format string corresponds to one of the standart formats
            if (_formatStringToStandartFormat.ContainsKey(formatString))
                return _formatStringToStandartFormat[formatString];

            // parse number format
            return _visualEditor.Document.ParseNumberFormat(formatString);
        }

        #endregion


        #region Alignment

        /// <summary>
        /// Shows this form with opened 'Alignment' tab.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowAlignmentDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (CellsStyleForm form = new CellsStyleForm())
            {
                form.SetVisualEditor(visualEditor);
                form.cellStyleTabControl.SelectedTab = form.alignmentTabPage;
                return form.ShowDialog();
            }
        }

        /// <summary>
        /// Initializes the UI with alignment properties.
        /// </summary>
        /// <param name="properties">Initial properties.</param>
        private void InitAlignmentPropertiesUI(Dictionary<CellStyleProperty, object> properties)
        {
            // init text horizontal alignment
            if (properties.ContainsKey(CellStyleProperty.TextHorizontalAlign))
            {
                textHorizontalAlignmentComboBox.SelectedItem =
                    properties[CellStyleProperty.TextHorizontalAlign];
            }

            // init text vertical alignment
            if (properties.ContainsKey(CellStyleProperty.TextVerticalAlign))
            {
                textVerticalAlignmentComboBox.SelectedItem =
                    properties[CellStyleProperty.TextVerticalAlign];
            }

            // init text indent
            if (properties.ContainsKey(CellStyleProperty.TextIndent))
                textIndentNumericUpDown.Value = (int)properties[CellStyleProperty.TextIndent];
            else
                textIndentNumericUpDown.Text = "";

            // init text wrap
            if (properties.ContainsKey(CellStyleProperty.TextWordWrap))
            {
                wrapTextCheckBox.Checked = (bool)properties[CellStyleProperty.TextWordWrap];
            }
            else
            {
                wrapTextCheckBox.ThreeState = true;
                wrapTextCheckBox.CheckState = CheckState.Indeterminate;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of TextHorizontalAlignmentComboBox object.
        /// </summary>
        private void textHorizontalAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (textHorizontalAlignmentComboBox.SelectedItem != null)
            {
                // save changes about horizontal alignment
                _changedProperties[CellStyleProperty.TextHorizontalAlign] =
                    (TextHorizontalAlign)textHorizontalAlignmentComboBox.SelectedIndex;

                if ((TextHorizontalAlign)textHorizontalAlignmentComboBox.SelectedItem == TextHorizontalAlign.Default ||
                    (TextHorizontalAlign)textHorizontalAlignmentComboBox.SelectedItem == TextHorizontalAlign.Center)
                {
                    // reset the text indent
                    _changedProperties[CellStyleProperty.TextIndent] = 0;
                    textIndentNumericUpDown.Text = "0";
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of TextVerticalAlignmentComboBox object.
        /// </summary>
        private void textVerticalAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (textVerticalAlignmentComboBox.SelectedItem != null)
            {
                // save changes about vertical alignment
                _changedProperties[CellStyleProperty.TextVerticalAlign] =
                    (TextVerticalAlign)textVerticalAlignmentComboBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of TextIndentNumericUpDown object.
        /// </summary>
        private void textIndentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // save changes about text indent
            SetIndentValue();
        }

        private void textIndentNumericUpDown_Validated(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // save changes about text indent
            SetIndentValue();
        }

        /// <summary>
        /// Handles the CheckStateChanged event of WrapTextCheckBox object.
        /// </summary>
        private void wrapTextCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            bool isWordWrapIndeterminated = wrapTextCheckBox.CheckState == CheckState.Indeterminate;

            if (isWordWrapIndeterminated)
            {
                // clear changes about word wrap
                _changedProperties.Remove(CellStyleProperty.TextWordWrap);
            }
            else
            {
                // save changes about word wrap
                _changedProperties[CellStyleProperty.TextWordWrap] = wrapTextCheckBox.Checked;
            }
        }

        /// <summary>
        /// Sets the text indent from the corresponding control.
        /// </summary>
        private void SetIndentValue()
        {
            if (textIndentNumericUpDown.Text != null)
            {
                // save changes about text indent
                _changedProperties[CellStyleProperty.TextIndent] = (int)textIndentNumericUpDown.Value;

                if (textIndentNumericUpDown.Value > 0)
                {
                    // if text alignment does not support text indent
                    if (textHorizontalAlignmentComboBox.SelectedItem == null ||
                        (TextHorizontalAlign)textHorizontalAlignmentComboBox.SelectedItem == TextHorizontalAlign.Default ||
                        (TextHorizontalAlign)textHorizontalAlignmentComboBox.SelectedItem == TextHorizontalAlign.Center)
                    {
                        textHorizontalAlignmentComboBox.SelectedItem = TextHorizontalAlign.Left;
                    }
                }
            }
        }

        #endregion


        #region Font

        /// <summary>
        /// Shows this form with opened 'Font' tab.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowFontDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (CellsStyleForm form = new CellsStyleForm())
            {
                form.SetVisualEditor(visualEditor);
                form.cellStyleTabControl.SelectedTab = form.fontTabPage;
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Initializes the UI with font properties.
        /// </summary>
        /// <param name="properties">Initial properties.</param>
        private void InitFontPropertiesUI(Dictionary<CellStyleProperty, object> properties)
        {
            // init font name
            if (properties.ContainsKey(CellStyleProperty.FontName))
            {
                fontNameTextBox.Text = (string)properties[CellStyleProperty.FontName];
                fontNamesListBox.SelectedItem = fontNameTextBox.Text;
            }

            // init font style
            bool? isBold = null;
            bool? isItalic = null;
            if (properties.ContainsKey(CellStyleProperty.FontIsBold))
                isBold = (bool)properties[CellStyleProperty.FontIsBold];
            if (properties.ContainsKey(CellStyleProperty.FontIsItalic))
                isItalic = (bool)properties[CellStyleProperty.FontIsItalic];

            if (isBold.HasValue && isItalic.HasValue)
            {
                if (isBold.Value && isItalic.Value)
                {
                    fontStyleTextBox.Text = "Bold Italic";
                    fontStylesListBox.SelectedItem = "Bold Italic";
                }
                else if (isBold.Value)
                {
                    fontStyleTextBox.Text = "Bold";
                    fontStylesListBox.SelectedItem = "Bold";
                }
                else if (isItalic.Value)
                {
                    fontStyleTextBox.Text = "Italic";
                    fontStylesListBox.SelectedItem = "Italic";
                }
                else
                {
                    fontStyleTextBox.Text = "Regular";
                    fontStylesListBox.SelectedItem = "Regular";
                }
            }

            // init font size
            if (properties.ContainsKey(CellStyleProperty.FontSize))
            {
                double fontSize = (double)properties[CellStyleProperty.FontSize];
                fontSizeTextBox.Text = fontSize.ToString(Culture);
                if (fontSizesListBox.Items.Contains(fontSizeTextBox.Text))
                    fontSizesListBox.SelectedItem = fontSizeTextBox.Text;
                else
                    fontSizesListBox.SelectedItem = null;
            }

            // init text underline
            if (properties.ContainsKey(CellStyleProperty.FontIsUnderline))
            {
                underlineCheckBox.Checked = (bool)properties[CellStyleProperty.FontIsUnderline];
            }
            else
            {
                underlineCheckBox.ThreeState = true;
                underlineCheckBox.CheckState = CheckState.Indeterminate;
            }

            // init text strikeout
            if (properties.ContainsKey(CellStyleProperty.FontIsStrikeout))
            {
                strikethroughCheckBox.Checked = (bool)properties[CellStyleProperty.FontIsStrikeout];
            }
            else
            {
                strikethroughCheckBox.ThreeState = true;
                strikethroughCheckBox.CheckState = CheckState.Indeterminate;
            }

            // init font color
            if (properties.ContainsKey(CellStyleProperty.FontColor))
            {
                VintasoftColor fontColor = (VintasoftColor)properties[CellStyleProperty.FontColor];
                fontColorPanelControl.Color = Color.FromArgb(fontColor.ToArgb());
            }
            else
            {
                fontColorPanelControl.Color = Color.Empty;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontNamesListBox object.
        /// </summary>
        private void fontNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (fontNamesListBox.SelectedItem != null)
            {
                fontNameTextBox.Text = fontNamesListBox.Text;
                SetFontNameValue();
            }
        }

        /// <summary>
        /// Handles the Leave event of FontNameTextBox object.
        /// </summary>
        private void fontNameTextBox_Leave(object sender, EventArgs e)
        {
            SetFontNameValue();

            if (fontNamesListBox.Items.Contains(fontNameTextBox.Text))
                fontNamesListBox.SelectedItem = fontNameTextBox.Text;
            else
                fontNamesListBox.ClearSelected();
        }

        private void fontNameTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetFontNameValue();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontStylesListBox object.
        /// </summary>
        private void fontStylesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (fontStylesListBox.SelectedItem != null)
            {
                fontStyleTextBox.Text = fontStylesListBox.Text;
                SetFontStyleValue();
            }
        }

        /// <summary>
        /// Handles the Leave event of FontStyleTextBox object.
        /// </summary>
        private void fontStyleTextBox_Leave(object sender, EventArgs e)
        {
            SetFontStyleValue();

            if (fontStylesListBox.Items.Contains(fontStyleTextBox.Text))
                fontStylesListBox.SelectedItem = fontStyleTextBox.Text;
            else
                fontStylesListBox.ClearSelected();
        }

        private void fontStyleTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetFontStyleValue();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of FontSizesListBox object.
        /// </summary>
        private void fontSizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            if (fontSizesListBox.SelectedItem != null)
            {
                fontSizeTextBox.Text = fontSizesListBox.Text;
                SetFontSizeValue();
            }
        }

        /// <summary>
        /// Handles the Leave event of FontSizeTextBox object.
        /// </summary>
        private void fontSizeTextBox_Leave(object sender, EventArgs e)
        {
            SetFontSizeValue();

            if (fontSizesListBox.Items.Contains(fontSizeTextBox.Text))
                fontSizesListBox.SelectedItem = fontSizeTextBox.Text;
            else
                fontSizesListBox.ClearSelected();
        }

        private void fontSizeTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetFontSizeValue();
        }

        /// <summary>
        /// Handles the CheckStateChanged event of UnderlineCheckBox object.
        /// </summary>
        private void underlineCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            bool isUnderlineIndeterminated = underlineCheckBox.CheckState == CheckState.Indeterminate;

            if (isUnderlineIndeterminated)
            {
                // clear changes about underline state
                _changedProperties.Remove(CellStyleProperty.FontIsUnderline);
            }
            else
            {
                // save changes about underline state
                _changedProperties[CellStyleProperty.FontIsUnderline] = underlineCheckBox.Checked;
            }
        }

        /// <summary>
        /// Handles the CheckStateChanged event of StrikethroughCheckBox object.
        /// </summary>
        private void strikethroughCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            bool isStrikethroughIndeterminated = strikethroughCheckBox.CheckState == CheckState.Indeterminate;

            if (isStrikethroughIndeterminated)
            {
                // clear changes about strikethrough state
                _changedProperties.Remove(CellStyleProperty.FontIsStrikeout);
            }
            else
            {
                // save changes about strikethrough state
                _changedProperties[CellStyleProperty.FontIsStrikeout] = strikethroughCheckBox.Checked;
            }
        }

        /// <summary>
        /// Handles the ColorChanged event of FontColorPanelControl object.
        /// </summary>
        private void fontColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            _changedProperties[CellStyleProperty.FontColor] = VintasoftColor.FromArgb(fontColorPanelControl.Color.ToArgb());
        }

        /// <summary>
        /// Handles the Click event of NormalFontButton object.
        /// </summary>
        private void normalFontButton_Click(object sender, EventArgs e)
        {
            if (!_initializationFinished)
                return;

            // get the "Normal" style from spreadsheet document
            CellStyle normalStyle = _visualEditor.Document.Styles[0];

            // set the UI to the "Normal" style
            // style properties will change in event handlers

            fontNamesListBox.SelectedItem = normalStyle.FontProperties.Name;

            if (normalStyle.FontProperties.IsBold && normalStyle.FontProperties.IsItalic)
                fontStylesListBox.SelectedItem = "Bold Italic";
            else if (normalStyle.FontProperties.IsBold)
                fontStylesListBox.SelectedItem = "Bold";
            else if (normalStyle.FontProperties.IsItalic)
                fontStylesListBox.SelectedItem = "Italic";
            else
                fontStylesListBox.SelectedItem = "Regular";

            fontSizeTextBox.Text = normalStyle.FontProperties.Size.ToString(Culture);
            SetFontSizeValue();
            if (fontSizesListBox.Items.Contains(fontSizeTextBox.Text))
                fontSizesListBox.SelectedItem = fontSizeTextBox.Text;
            else
                fontSizesListBox.SelectedItem = null;

            if (normalStyle.FontProperties.IsUnderline)
            {
                underlineCheckBox.Checked = true;
                underlineCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                underlineCheckBox.Checked = false;
            }

            if (normalStyle.FontProperties.IsStrikeout)
            {
                strikethroughCheckBox.Checked = true;
                strikethroughCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                strikethroughCheckBox.Checked = false;
            }

            _changedProperties[CellStyleProperty.FontColor] = normalStyle.FontProperties.Color;
            fontColorPanelControl.Color = Color.FromArgb(normalStyle.FontProperties.Color.ToArgb());
        }

        /// <summary>
        /// Sets the font name from the corresponding text box.
        /// </summary>
        private void SetFontNameValue()
        {
            if (!_initializationFinished)
                return;

            _changedProperties[CellStyleProperty.FontName] = fontNameTextBox.Text;
        }

        /// <summary>
        /// Sets the font style from the corresponding text box.
        /// </summary>
        private void SetFontStyleValue()
        {
            if (!_initializationFinished)
                return;

            if (string.IsNullOrEmpty(fontStyleTextBox.Text))
                return;

            if (fontStylesListBox.Items.Contains(fontStyleTextBox.Text))
            {
                bool isBold = fontStyleTextBox.Text == "Bold" || fontStyleTextBox.Text == "Bold Italic";
                bool isItalic = fontStyleTextBox.Text == "Italic" || fontStyleTextBox.Text == "Bold Italic";

                _changedProperties[CellStyleProperty.FontIsBold] = isBold;
                _changedProperties[CellStyleProperty.FontIsItalic] = isItalic;
            }
            else
            {
                MessageBox.Show(string.Format("Font style with name '{0}' does not exist.", fontStyleTextBox.Text));
            }
        }

        /// <summary>
        /// Sets the font size from the corresponding text box.
        /// </summary>
        private void SetFontSizeValue()
        {
            if (!_initializationFinished)
                return;

            if (!string.IsNullOrEmpty(fontSizeTextBox.Text))
            {
                double fontSize;
                if (double.TryParse(fontSizeTextBox.Text, NumberStyles.Any, Culture, out fontSize))
                    _changedProperties[CellStyleProperty.FontSize] = Math.Round(fontSize, 2);
                else
                    MessageBox.Show("Font size must be an integer or decimal number.");
            }
        }

        /// <summary>
        /// Returns an array of avaliable font names.
        /// </summary>
        public static string[] GetAvailableFontNames()
        {
            List<string> result = new List<string>();
            try
            {
                FileFontProgramsController fontProgramsController =
                    (FileFontProgramsController)Vintasoft.Imaging.Drawing.DrawingFactory.Default.FontProgramsController;
                Dictionary<string, string> systemFonts = fontProgramsController.GetSystemInstalledFonts();
                foreach (string fontName in systemFonts.Keys)
                {
                    if (fontName.ToUpperInvariant().Contains(" BOLD") || fontName.ToUpperInvariant().Contains(" ITALIC"))
                        continue;
                    result.Add(fontName);
                }
            }
            catch
            {
            }
            return result.ToArray();
        }

        #endregion


        #region Border

        /// <summary>
        /// Shows this form with opened 'Border' tab.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowBordersDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (CellsStyleForm form = new CellsStyleForm())
            {
                form.SetVisualEditor(visualEditor);
                form.cellStyleTabControl.SelectedTab = form.bordersTabPage;
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Initializes the UI with border properties.
        /// </summary>
        /// <param name="properties">Initial properties.</param>
        /// <param name="styleIndexes">Cells style indexes.</param>
        private void InitBorderPropertiesUI(CellReferences[] selectedCells)
        {
            lineStylesListBox.SelectedIndex = 6;
            lineColorPanelControl.Color = Color.Black;

            // init borders preview control
            bordersPreviewControl.VisualEditor.Editor = new SpreadsheetEditor();
            bordersPreviewControl.AutoScroll = false;
            bordersPreviewControl.Enabled = false;

            SpreadsheetVisualEditor visualEditor = bordersPreviewControl.VisualEditor;

            visualEditor.ShowHeadings = false;
            visualEditor.FocusedCellsAppearance = null;
            visualEditor.SelectedCellColor = VintasoftColor.Empty;
            visualEditor.CanTransformFocusedFormula = false;
            visualEditor.CanTransfromChart = false;
            visualEditor.CanTransfromComment = false;
            visualEditor.CanTransfromFocusedCells = false;
            visualEditor.CanTransfromPicture = false;
            visualEditor.CanTransfromShape = false;

            bool hasRows = false;
            bool hasColumns = false;

            // identify selection type
            foreach (CellReferences cellReferences in selectedCells)
            {
                if (cellReferences.RowCount > 1)
                    hasRows = true;
                if (cellReferences.ColumnCount > 1)
                    hasColumns = true;
            }

            const int borderPreviewPadding = 15;

            Size previewCellsArea = new Size(
                bordersPreviewControl.Width - borderPreviewPadding,
                bordersPreviewControl.Height - borderPreviewPadding);

            // if multiple rows and columns are selected
            if (hasRows && hasColumns)
            {
                visualEditor.SetFocusedAndSelectedCells(new CellReferences(1, 1, 2, 2));
                visualEditor.ColumnsWidth = previewCellsArea.Width / 2;
                visualEditor.RowsHeight = previewCellsArea.Height / 2;
            }
            // if multiple rows are selected
            else if (hasRows)
            {
                visualEditor.SetFocusedAndSelectedCells(new CellReferences(1, 1, 1, 2));
                visualEditor.ColumnsWidth = previewCellsArea.Width;
                visualEditor.RowsHeight = previewCellsArea.Height / 2;
                verticalBorderButton.Enabled = false;
            }
            // if multiple columns are selected
            else if (hasColumns)
            {
                visualEditor.SetFocusedAndSelectedCells(new CellReferences(1, 1, 2, 1));
                visualEditor.ColumnsWidth = previewCellsArea.Width / 2;
                visualEditor.RowsHeight = previewCellsArea.Height;
                horizontalBorderButton.Enabled = false;
            }
            // if one cell is selected
            else
            {
                visualEditor.SetFocusedAndSelectedCells(new CellReferences(1, 1, 1, 1));
                visualEditor.ColumnsWidth = previewCellsArea.Width;
                visualEditor.RowsHeight = previewCellsArea.Height;
                verticalBorderButton.Enabled = false;
                horizontalBorderButton.Enabled = false;
            }

            VintasoftSize a1Size = visualEditor.FocusedWorksheet.GetCellSize(new CellReference(0, 0));

            visualEditor.ScrollPosition = new VintasoftPoint(a1Size.Width - borderPreviewPadding / 2, a1Size.Height - borderPreviewPadding / 2);

            _currentBorders = _visualEditor.CellsBorders;
            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of NoneBorderPresetButton object.
        /// </summary>
        private void noneBorderPresetButton_Click(object sender, EventArgs e)
        {
            _currentBorders = new CellsBorders(new CellBorders(CellBorder.Invisible), CellBorder.Invisible, CellBorder.Invisible);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of OutlineBorderPresetButton object.
        /// </summary>
        private void outlineBorderPresetButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();
            _currentBorders = new CellsBorders(new CellBorders(border), _currentBorders.HorizontalBorder, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of InsideBorderPresetButton object.
        /// </summary>
        private void insideBorderPresetButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();
            _currentBorders = new CellsBorders(_currentBorders.OutsideBorders, border, border);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of TopBorderButton object.
        /// </summary>
        private void topBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.OutsideBorders.Top, border))
                border = CellBorder.Invisible;

            CellBorders borders = new CellBorders(
                _currentBorders.OutsideBorders.Left,
                _currentBorders.OutsideBorders.Right,
                border,
                _currentBorders.OutsideBorders.Bottom);

            _currentBorders = new CellsBorders(borders, _currentBorders.HorizontalBorder, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of HorizontalBorderButton object.
        /// </summary>
        private void horizontalBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.HorizontalBorder, border))
                border = CellBorder.Invisible;

            _currentBorders = new CellsBorders(_currentBorders.OutsideBorders, border, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of BottomBorderButton object.
        /// </summary>
        private void bottomBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.OutsideBorders.Bottom, border))
                border = CellBorder.Invisible;

            CellBorders borders = new CellBorders(
                _currentBorders.OutsideBorders.Left,
                _currentBorders.OutsideBorders.Right,
                _currentBorders.OutsideBorders.Top,
                border);

            _currentBorders = new CellsBorders(borders, _currentBorders.HorizontalBorder, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of LeftBorderButton object.
        /// </summary>
        private void leftBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.OutsideBorders.Left, border))
                border = CellBorder.Invisible;

            CellBorders borders = new CellBorders(
                border,
                _currentBorders.OutsideBorders.Right,
                _currentBorders.OutsideBorders.Top,
                _currentBorders.OutsideBorders.Bottom);

            _currentBorders = new CellsBorders(borders, _currentBorders.HorizontalBorder, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of VerticalBorderButton object.
        /// </summary>
        private void verticalBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.VerticalBorder, border))
                border = CellBorder.Invisible;

            _currentBorders = new CellsBorders(_currentBorders.OutsideBorders, _currentBorders.HorizontalBorder, border);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Handles the Click event of RightBorderButton object.
        /// </summary>
        private void rightBorderButton_Click(object sender, EventArgs e)
        {
            CellBorder border = GetSelectedBorder();

            if (Equals(_currentBorders.OutsideBorders.Right, border))
                border = CellBorder.Invisible;

            CellBorders borders = new CellBorders(
                _currentBorders.OutsideBorders.Left,
                border,
                _currentBorders.OutsideBorders.Top,
                _currentBorders.OutsideBorders.Bottom);

            _currentBorders = new CellsBorders(borders, _currentBorders.HorizontalBorder, _currentBorders.VerticalBorder);
            _changedProperties[CellStyleProperty.Borders] = _currentBorders;

            bordersPreviewControl.VisualEditor.CellsBorders = _currentBorders;
        }

        /// <summary>
        /// Returns the border with selected border style and color.
        /// </summary>
        private CellBorder GetSelectedBorder()
        {
            CellBorderStyle style = ((CellBorderStyleItem)lineStylesListBox.SelectedItem).CellBorderStyle;

            return new CellBorder(style, VintasoftColor.FromArgb(lineColorPanelControl.Color.ToArgb()));
        }

        #endregion


        #region Fill

        /// <summary>
        /// Initializes the UI with fill properties.
        /// </summary>
        /// <param name="properties">Initial properties.</param>
        /// <param name="styleIndexes">Cells style indexes.</param>
        private void InitFillPropertiesUI(Dictionary<CellStyleProperty, object> properties)
        {
            object fillColor = null;
            if (properties.TryGetValue(CellStyleProperty.FillColor, out fillColor))
                backgroundColorPanelControl.Color = Color.FromArgb(((VintasoftColor)fillColor).ToArgb());
        }

        /// <summary>
        /// Handles the ColorChanged event of BackgroundColorPanelControl object.
        /// </summary>
        private void backgroundColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            _changedProperties[CellStyleProperty.FillColor] = VintasoftColor.FromArgb(backgroundColorPanelControl.Color.ToArgb());
        }

        /// <summary>
        /// Handles the Click event of NoColorButton object.
        /// </summary>
        private void noColorButton_Click(object sender, EventArgs e)
        {
            backgroundColorPanelControl.Color = Color.Empty;
            _changedProperties[CellStyleProperty.FillColor] = VintasoftColor.Empty;
        }

        #endregion


        #region Common

        /// <summary>
        /// Sets the current style parameters.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        private void SetVisualEditor(SpreadsheetVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            CellStyle cellStyle = visualEditor.FocusedCellStyle;

            // get selected cells style indexes
            List<int> cellsStyleIndexes = new List<int>();
            CellReferences[] selectedCells = visualEditor.SelectedCells.ToArray();

            foreach (CellReferences cellReferences in selectedCells)
                cellsStyleIndexes.AddRange(visualEditor.FocusedWorksheet.GetCellsStyleIndexes(cellReferences));

            // get common properties
            Dictionary<CellStyleProperty, object> commonProperties = visualEditor.GetCommonCellsStyleProperties();

            // Number Format
            InitNumberFormatPropertiesUI(commonProperties);

            // Alignment
            InitAlignmentPropertiesUI(commonProperties);

            // Font
            InitFontPropertiesUI(commonProperties);

            // Borders
            InitBorderPropertiesUI(selectedCells);

            // Fill
            InitFillPropertiesUI(commonProperties);

            _initializationFinished = true;
        }

        /// <summary>
        /// Handles the Click event of ButtonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (_changedProperties.Count > 0)
                _visualEditor.ChangeStyleProperties(_changedProperties);
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of ButtonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

        #endregion
       
    }
}
