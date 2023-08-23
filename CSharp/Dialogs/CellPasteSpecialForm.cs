using System.Windows.Forms;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to copy content of worksheet cells with special settings.
    /// </summary>
    public partial class CellPasteSpecialForm : Form
    {

        /// <summary>
        /// The spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _spreadsheetVisualEditor;



        /// <summary>
        /// Initializes a new instance of the <see cref="CellPasteSpecialForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        public CellPasteSpecialForm(SpreadsheetVisualEditor spreadsheetVisualEditor)
        {
            InitializeComponent();

            _spreadsheetVisualEditor = spreadsheetVisualEditor;
        }



        /// <summary>
        /// Checkbox is checked.
        /// </summary>
        private void copyActionCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!copyStylesCheckBox.Checked && !copyValuesCheckBox.Checked && !copyFormulasCheckBox.Checked &&
                !copyCommentsCheckBox.Checked && !copyHyperlinksCheckBox.Checked)
            {
                MessageBox.Show("All checkboxes cannot be disabled.", "Error");

                CheckBox checkBox = (CheckBox)sender;
                checkBox.Checked = true;
            }
        }

        /// <summary>
        /// "OK" button is clicked.
        /// </summary>
        private void okButton_Click(object sender, System.EventArgs e)
        {
            Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode sheetCellsCopyMode = Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyAll;
            if (!copyStylesCheckBox.Checked)
                sheetCellsCopyMode ^= Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyCellStyle;
            if (!copyValuesCheckBox.Checked)
                sheetCellsCopyMode ^= Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyCellValue;
            if (!copyFormulasCheckBox.Checked)
                sheetCellsCopyMode ^= Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyCellFormula;
            if (!copyCommentsCheckBox.Checked)
                sheetCellsCopyMode ^= Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyCellComment;
            if (!copyHyperlinksCheckBox.Checked)
                sheetCellsCopyMode ^= Vintasoft.Imaging.Office.Spreadsheet.SheetCellsCopyMode.CopyHyperlinks;

            _spreadsheetVisualEditor.PasteCells(sheetCellsCopyMode);

            DialogResult = DialogResult.OK;
        }

    }
}
