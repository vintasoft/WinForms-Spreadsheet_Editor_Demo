using System;
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
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_GENERAL, new GeneralFormat());
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_NUMBER, new NumberingFormat(2, false));
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DATE, DateFormat.Create("mm-dd-yy"));
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TIME, TimeFormat.Create("h:mm"));
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURRENCY, new CurrencyFormat(2, true, "[$$-en-US]"));
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PERCENTAGE, new PercentageFormat(2));
            _panelFormats.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SCIENTIFIC, new ScientificFormat(2));
            _panelFormats.Add("Text", new TextFormat());

            foreach (string formatName in _panelFormats.Keys)
                numberFormatComboBox.Items.Add(formatName);

            numberFormatComboBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOM);
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
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_GENERAL_ALT1;
                    else if (format is NumberingFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_NUMBER_ALT1;
                    else if (format is DateFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DATE_ALT1;
                    else if (format is TimeFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TIME_ALT1;
                    else if (format is CurrencyFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURRENCY_ALT1;
                    else if (format is PercentageFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PERCENTAGE_ALT1;
                    else if (format is ScientificFormat)
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SCIENTIFIC_ALT1;
                    else if (format is TextFormat)
                        numberFormatComboBox.Text = "Text";
                    else
                        numberFormatComboBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CUSTOM_ALT1;
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
            CurrencyFormat format = new CurrencyFormat(2, true, "[$$-en-US]");
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EnglishUnitedKingdomToolStripMenuItem object.
        /// </summary>
        private void englishUnitedKingdomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, true, "[$£-en-GB]");
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EuroToolStripMenuItem object.
        /// </summary>
        private void euroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, true, "[$€-x-euro2]\\ ");
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }
        
        /// <summary>
        /// Handles the Click event of ChineseSimplifiedToolStripMenuItem object.
        /// </summary>
        private void chineseSimplifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, true, "[$¥-zh-CN]");
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of RussianToolStripMenuItem object.
        /// </summary>
        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, false, "\\ [$₽-ru-RU]");
            VisualEditor.NumberFormat = format.ToString(VisualEditor.Document.Defaults.FormattingProperties);
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of EnglishIndiaToolStripMenuItem object.
        /// </summary>
        private void englishIndiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyFormat format = new CurrencyFormat(2, true, "[$₹-en-IN]\\ ");
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
            VisualEditor.NumberFormatDecimalPlaces--;
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of IncreaseDecimalButton object.
        /// </summary>
        private void increaseDecimalButton_Click(object sender, EventArgs e)
        {
            VisualEditor.NumberFormatDecimalPlaces++;
            UpdateUI();
        }

        

        #endregion

    }
}
