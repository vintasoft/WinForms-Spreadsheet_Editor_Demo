using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.Functions;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A form that allows to view and select the function.
    /// </summary>
    public partial class SelectFunctionForm : Form
    {

        #region Fields

        /// <summary>
        /// The document.
        /// </summary>
        SpreadsheetDocument _document;

        /// <summary>
        /// Dictionary that contains functions divided by categories: category name => function names.
        /// </summary>
        Dictionary<FunctionCategory, string[]> _categoryToFunctions;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectFunctionForm"/> class.
        /// </summary>
        public SelectFunctionForm()
        {
            InitializeComponent();

            categoryComboBox.Items.Add(FunctionCategory.All);
            foreach (FunctionCategory category in SupportedFunctions.Categories)
                categoryComboBox.Items.Add(category);
            categoryComboBox.SelectedIndex = 0;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this dialog and returns selected function.
        /// </summary>
        /// <param name="document">The document.</param>
        public static string SelectFunction(SpreadsheetDocument document)
        {
            using (SelectFunctionForm form = new SelectFunctionForm())
            {
                form._document = document;
                if (form.ShowDialog() == DialogResult.OK)
                    return (string)form.functionsListBox.SelectedItem;
                return null;
            }
        }


        /// <summary>
        /// Raises the <see cref="System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="System.EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _categoryToFunctions = new Dictionary<FunctionCategory, string[]>();
            _categoryToFunctions.Add(FunctionCategory.All, _document.GetSupportedFunctions(FunctionCategory.All));
            foreach (FunctionCategory category in SupportedFunctions.Categories)
                _categoryToFunctions.Add(category, _document.GetSupportedFunctions(category));

            UpdateUI();
        }


        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            if (_categoryToFunctions != null)
            {
                // clear the functions listbox
                functionsListBox.Items.Clear();
                
                // if search textbox has no text
                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    // add all functions by selected category
                    functionsListBox.Items.AddRange(_categoryToFunctions[(FunctionCategory)categoryComboBox.SelectedItem]);
                }
                else
                {
                    string text = searchTextBox.Text.ToUpperInvariant();

                    // add all functions which contains text from search textbox
                    foreach (string functionName in _categoryToFunctions[(FunctionCategory)categoryComboBox.SelectedItem])
                    {
                        if (functionName.ToUpperInvariant().Contains(text))
                            functionsListBox.Items.Add(functionName);
                    }
                }

                // if listbox has elements
                if (functionsListBox.Items.Count > 0)
                    functionsListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of searchTextBox object.
        /// </summary>
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of categoryComboBox object.
        /// </summary>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of buttonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
