using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to view a list of defined names and select the defined name.
    /// </summary>
    public partial class SelectDefinedNameForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectDefinedNameForm"/> class.
        /// </summary>
        /// <param name="definedNames">The defined names.</param>
        public SelectDefinedNameForm(DefinedName[] definedNames)
        {
            if (definedNames == null)
                throw new ArgumentNullException("definedNames");

            InitializeComponent();

            foreach (DefinedName definedName in definedNames)
                namesListBox.Items.Add(definedName.Name);
        }


        /// <summary>
        /// Gets the selected defined name.
        /// </summary>
        public string SelectedDefinedName
        {
            get
            {
                return (string)namesListBox.SelectedItem;
            }
        }


        /// <summary>
        /// "OK" button is clicked.
        /// </summary>
        private void okButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
