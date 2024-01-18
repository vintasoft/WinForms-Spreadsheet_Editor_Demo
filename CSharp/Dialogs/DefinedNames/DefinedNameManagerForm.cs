using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to view and manage the defined names.
    /// </summary>
    public partial class DefinedNameManagerForm : Form
    {

        #region Fields

        /// <summary>
        /// The global scope.
        /// </summary>
        const string GLOBAL_SCOPE = "Workbook";

        /// <summary>
        /// The spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _spreadsheetVisualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedNameManagerForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        public DefinedNameManagerForm(SpreadsheetVisualEditor spreadsheetVisualEditor)
        {
            InitializeComponent();

            _spreadsheetVisualEditor = spreadsheetVisualEditor;

            InitDefinedNameListView();
        }

        #endregion



        #region Methods

        /// <summary>
        /// "New..." button is clicked.
        /// </summary>
        private void newButton_Click(object sender, System.EventArgs e)
        {
            // create dialog that allows to add new defined name
            using (EditDefinedNameForm dlg = new EditDefinedNameForm(_spreadsheetVisualEditor))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    InitDefinedNameListView();
                }
            }
        }

        /// <summary>
        /// "Edit..." button is clicked.
        /// </summary>
        private void editButton_Click(object sender, System.EventArgs e)
        {
            if (definedNameListView.SelectedItems.Count == 0)
                return;

            // get selected list item
            ListViewItem listViewItem = definedNameListView.SelectedItems[0];

            // get the defined name that should be edited
            DefinedName definedName = (DefinedName)listViewItem.Tag;

            // create dialog that allows to edit the defined name
            using (EditDefinedNameForm dlg = new EditDefinedNameForm(_spreadsheetVisualEditor, definedName))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    InitDefinedNameListView();
                }
            }
        }

        /// <summary>
        /// "Delete" button is clicked.
        /// </summary>
        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (definedNameListView.SelectedItems.Count == 0)
                return;

            // get selected list item
            ListViewItem listViewItem = definedNameListView.SelectedItems[0];

            // get the defined name that should be deleted
            DefinedName definedName = (DefinedName)listViewItem.Tag;
            // get the index of defined name in defined name list
            int definedNameIndex = _spreadsheetVisualEditor.Document.DefinedNames.IndexOf(definedName);
            // delete defined name by index
            _spreadsheetVisualEditor.Editor.RemoveDefinedNameAt(definedNameIndex);

            // delete item that represents defined name in the list view
            definedNameListView.Items.Remove(listViewItem);
        }

        /// <summary>
        /// Selected defined name is changed.
        /// </summary>
        private void definedNameListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            bool isEditButtonEnabled = definedNameListView.SelectedItems.Count > 0;
            editButton.Enabled = isEditButtonEnabled;
            deleteButton.Enabled = isEditButtonEnabled;
        }

        /// <summary>
        /// Initializes the list view with defined names.
        /// </summary>
        private void InitDefinedNameListView()
        {
            definedNameListView.Items.Clear();
            foreach (DefinedName definedName in _spreadsheetVisualEditor.Document.DefinedNames)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = definedName;
                listViewItem.Text = definedName.Name;
                listViewItem.SubItems.Add(_spreadsheetVisualEditor.GetActualValueByDefinedName(definedName.Name));

                string worksheetName = definedName.WorksheetName;
                if (string.IsNullOrEmpty(worksheetName))
                    worksheetName = GLOBAL_SCOPE;

                listViewItem.SubItems.Add(worksheetName);
                listViewItem.SubItems.Add(definedName.Comment);

                definedNameListView.Items.Add(listViewItem);
            }
        }

        #endregion

    }
}
