using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to rename the worksheet.
    /// </summary>
    public partial class RenameWorksheetForm : Form
    {

        #region Fields

        /// <summary>
        /// The spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _spreadsheetVisualEditor;

        #endregion



        #region Constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="RenameWorksheetForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        public RenameWorksheetForm(SpreadsheetVisualEditor spreadsheetVisualEditor)
        {
            InitializeComponent();

            _spreadsheetVisualEditor = spreadsheetVisualEditor;

            worksheetNameTextBox.Text = spreadsheetVisualEditor.FocusedWorksheet.Name;
        }

        #endregion



        #region Properties

        bool _isWorksheetNameChanged = false;
        /// <summary>
        /// Gets a value indicating whether worksheet name is changed.
        /// </summary>
        public bool IsWorksheetNameChanged
        {
            get
            {
                return _isWorksheetNameChanged;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            string worksheetName = worksheetNameTextBox.Text;
            if (worksheetName.Length > 31)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_WORKSHEET_NAME_CANNOT_CONTAINS_MORE_THAN_31_SYMBOLS);
                return;
            }

            try
            {
                _spreadsheetVisualEditor.RenameWorksheet(worksheetName);
                _isWorksheetNameChanged = true;
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
                return;
            }

            DialogResult = DialogResult.OK;
        }


        #endregion

    }
}
