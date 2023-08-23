﻿using System;
using System.Collections.Generic;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.NumberFormats;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Number Format" panel.
    /// </summary>
    public partial class NumberFormatPanel : SpreadsheetVisualEditorPanel
    {

        #region Fields

        /// <summary>
        /// The formats, which can be set using this panel.
        /// </summary>
        Dictionary<string, NumberFormat> _panelFormats = new Dictionary<string, NumberFormat>();

        /// <summary>
        /// Indicates whether the UI is currently updating.
        /// </summary>
        bool _isUpdateUI = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFormatPanel"/> class.
        /// </summary>
        public NumberFormatPanel()
        {
            InitializeComponent();

            // create formats for panel comboBox
            _panelFormats.Add("General", new GeneralFormat());
            _panelFormats.Add("Number", new NumberingFormat(2, false));
            _panelFormats.Add("Date", DateFormat.Create("mm-dd-yy"));
            _panelFormats.Add("Time", TimeFormat.Create("h:mm"));
            _panelFormats.Add("Currency", new CurrencyFormat(2, "[$$-en-US]", true));
            _panelFormats.Add("Percentage", new PercentageFormat(2));
            _panelFormats.Add("Scientific", new ScientificFormat(2));
            _panelFormats.Add("Text", new TextFormat());

            foreach (string formatName in _panelFormats.Keys)
                numberFormatComboBox.Items.Add(formatName);

            numberFormatComboBox.Items.Add("Custom");
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="E:SpreadsheetEditorChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (args.OldValue != null)
            {
                args.OldValue.VisualEditor.FocusedCellChanged -= VisualEditor_FocusedCellChanged;
                args.OldValue.VisualEditor.CellsStylePropertiesChanged -= VisualEditor_CellsStylePropertiesChanged;
                args.NewValue.VisualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
            }
            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
                args.NewValue.VisualEditor.CellsStylePropertiesChanged += VisualEditor_CellsStylePropertiesChanged;
                args.NewValue.VisualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
            }
            UpdateUI();
        }

        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            UpdateUI();
        }

        private void VisualEditor_CellsStylePropertiesChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this panel.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.IsFocusedWorksheetChanging)
                return;

            _isUpdateUI = true;
            try
            {

                if (VisualEditor.FocusedCell == null)
                {
                    Enabled = false;
                }
                else
                {
                    Enabled = true;

                    // get focused cell format
                    string formatString = VisualEditor.NumberFormat;
                    NumberFormat format = VisualEditor.Document.ParseNumberFormat(formatString);

                    // update comboBox value
                    if (format is GeneralFormat)
                        numberFormatComboBox.Text = "General";
                    else if (format is NumberingFormat)
                        numberFormatComboBox.Text = "Number";
                    else if (format is DateFormat)
                        numberFormatComboBox.Text = "Date";
                    else if (format is TimeFormat)
                        numberFormatComboBox.Text = "Time";
                    else if (format is CurrencyFormat)
                        numberFormatComboBox.Text = "Currency";
                    else if (format is PercentageFormat)
                        numberFormatComboBox.Text = "Percentage";
                    else if (format is ScientificFormat)
                        numberFormatComboBox.Text = "Scientific";
                    else if (format is TextFormat)
                        numberFormatComboBox.Text = "Text";
                    else
                        numberFormatComboBox.Text = "Custom";
                }
            }
            finally
            {
                _isUpdateUI = false;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of NumberFormatComboBox object.
        /// </summary>
        private void numberFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdateUI)
            {
                if (_panelFormats.ContainsKey(numberFormatComboBox.Text))
                {
                    // update cell number format
                    VisualEditor.NumberFormat = _panelFormats[numberFormatComboBox.Text].ToString(VisualEditor.Document.Defaults.FormattingProperties);
                }

                SpreadsheetEditor.Focus();
            }
        }

        /// <summary>
        /// Handles the Click event of EnglishUnitedStatesToolStripMenuItem object.
        /// </summary>
        private void englishUnitedStatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "[$$-en-US]", true);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EnglishUnitedKingdomToolStripMenuItem object.
        /// </summary>
        private void englishUnitedKingdomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "[$£-en-GB]", true);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EuroToolStripMenuItem object.
        /// </summary>
        private void euroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "[$€-x-euro2]\\ ", true);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }
        
        /// <summary>
        /// Handles the Click event of ChineseSimplifiedToolStripMenuItem object.
        /// </summary>
        private void chineseSimplifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "[$¥-zh-CN]", true);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of RussianToolStripMenuItem object.
        /// </summary>
        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "\\ [$₽-ru-RU]", false);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EnglishIndiaToolStripMenuItem object.
        /// </summary>
        private void englishIndiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, "[$₹-en-IN]\\ ", true);
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of PercentStyleButton object.
        /// </summary>
        private void percentStyleButton_Click(object sender, EventArgs e)
        {
            VisualEditor.NumberFormat = "0%";
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of NumberFormatPropertiesButton object.
        /// </summary>
        private void numberFormatPropertiesButton_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowNumberFormatDialog(VisualEditor);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of DecreaseDecimalButton object.
        /// </summary>
        private void decreaseDecimalButton_Click(object sender, EventArgs e)
        {
            EditDecimalPlacesNumber(-1);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of IncreaseDecimalButton object.
        /// </summary>
        private void increaseDecimalButton_Click(object sender, EventArgs e)
        {
            EditDecimalPlacesNumber(1);
            UpdateUI();
        }

        /// <summary>
        /// Edits the number of decimal places of numbering format.
        /// </summary>
        /// <param name="changeAmount">The amount of decimal places to add (<i>changeAmount</i> is greater than 0)
        /// or remove (<i>changeAmount</i> is less than 0).</param>
        private void EditDecimalPlacesNumber(int changeAmount)
        {
            // get a string that represents the number format of focused cell
            string formatString = VisualEditor.NumberFormat;
            // convert string to the number format
            NumberFormat format = VisualEditor.Document.ParseNumberFormat(formatString);

            if (format is NumberingFormatBase)
            {
                NumberingFormatBase numberFormat = (NumberingFormatBase)format;
                // change decimal places and set new format
                numberFormat.DecimalPlaces += changeAmount;
                VisualEditor.NumberFormat = numberFormat.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            }
            else if (format is GeneralFormat)
            {
                // if number format can be created from cell value
                NumberingFormat parsedFormat = null;
                if (TryGetNumberFormat(VisualEditor.FocusedSpreadsheetCell.Value, out parsedFormat))
                {
                    // change decimal places and set new format
                    parsedFormat.DecimalPlaces += changeAmount;
                    VisualEditor.NumberFormat = parsedFormat.ToString(VisualEditor.Document.Defaults.FormattingProperties);
                }
            }
        }

        /// <summary>
        /// Creates the numbering format from cell value.
        /// </summary>
        /// <param name="cellText">Cell value.</param>
        /// <param name="format">Created numbering format.</param>
        /// <returns><b>True</b> if cellText is parsed successfully; otherwise, <b>false</b>.</returns>
        private bool TryGetNumberFormat(string cellText, out NumberingFormat format)
        {
            // if cell value successfully parsed into a number
            double number;
            if (double.TryParse(cellText, System.Globalization.NumberStyles.Float, Culture, out number))
            {
                // find separator index
                int separatorIndex = cellText.IndexOf(Culture.NumberFormat.NumberDecimalSeparator);
                int decimalPlaces = 0;

                // get the number of decimal places
                if (separatorIndex > 0)
                    decimalPlaces = cellText.Length - separatorIndex - 1;

                // create the numbering format
                format = new NumberingFormat(decimalPlaces, false);
                return true;
            }

            format = null;
            return false;
        }

        #endregion

    }
}
