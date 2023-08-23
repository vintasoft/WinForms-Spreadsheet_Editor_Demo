using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the worksheet format properties.
    /// </summary>
    public partial class WorksheetFormatForm : Form
    {

        #region Fields

        /// <summary>
        /// Spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfoForm"/> class.
        /// </summary>
        public WorksheetFormatForm()
        {
            InitializeComponent();
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

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current document information.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (WorksheetFormatForm form = new WorksheetFormatForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the document information properties to this form UI.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        private void SetVisualEditor(SpreadsheetVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            WorksheetFormat format = _visualEditor.FocusedWorksheet.Format;

            rowHeightTextBox.Text = Math.Round(format.RowHeight, 2).ToString(Culture);
            columnWidthTextBox.Text = Math.Round(format.ColumnWidth, 2).ToString(Culture);
            rowAutoHeightCheckBox.Checked = format.AutoHeight;
        }

        /// <summary>
        /// Handles the Click event of ButtonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            double rowHeight;
            if (!double.TryParse(rowHeightTextBox.Text, NumberStyles.Float, Culture, out rowHeight))
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", "Row height must be an integer or decimal number.");
                return;
            }

            double columnWidth;
            if (!double.TryParse(columnWidthTextBox.Text, NumberStyles.Float, Culture, out columnWidth))
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", "Column width must be an integer or decimal number.");
                return;
            }

            bool isAutoHeight = rowAutoHeightCheckBox.Checked;

            bool isRowsHiddenByDefault = _visualEditor.FocusedWorksheet.Format.RowsHiddenByDefault;

            WorksheetFormat format = new WorksheetFormat(columnWidth, rowHeight, isAutoHeight, isRowsHiddenByDefault);

            // if format is changed, set it to worksheet
            if (!Equals(format, _visualEditor.FocusedWorksheet.Format))
                _visualEditor.SetWorksheetFormat(format);

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

    }
}
