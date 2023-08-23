﻿using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to add or edit the defined name.
    /// </summary>
    public partial class EditDefinedNameForm : Form
    {

        #region Fields

        /// <summary>
        /// Global scope name.
        /// </summary>
        const string GLOBAL_SCOPE = "Workbook";

        /// <summary>
        /// Spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _spreadsheetVisualEditor;

        /// <summary>
        /// Defined name to edit.
        /// </summary>
        DefinedName _definedName;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDefinedNameForm"/> class.
        /// </summary>
        public EditDefinedNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDefinedNameForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        /// <param name="value">Value of new defined name.</param>
        public EditDefinedNameForm(SpreadsheetVisualEditor spreadsheetVisualEditor, string value)
            : this()
        {
            _spreadsheetVisualEditor = spreadsheetVisualEditor;

            // initialize the scope combobox
            InitScopeComboBox();

            scopeComboBox.SelectedItem = GLOBAL_SCOPE;
            scopeComboBox.Enabled = true;

            if (string.IsNullOrEmpty(value))
                value = CreateRefersTo();
            if (!value.StartsWith("="))
                value = "=" + value;

            refersToTextBox.Text = value;

            this.Text = "Add Defined Name";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDefinedNameForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        public EditDefinedNameForm(SpreadsheetVisualEditor spreadsheetVisualEditor)
            : this(spreadsheetVisualEditor, string.Empty)
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EditDefinedNameForm"/> class.
        /// </summary>
        /// <param name="spreadsheetVisualEditor">The spreadsheet visual editor.</param>
        /// <param name="definedName">The defined name that should be edited.</param>
        public EditDefinedNameForm(SpreadsheetVisualEditor spreadsheetVisualEditor, DefinedName definedName)
            : this()
        {
            if (spreadsheetVisualEditor == null)
                throw new ArgumentNullException("spreadsheetVisualEditor");
            if (definedName == null)
                throw new ArgumentNullException("definedName");

            _spreadsheetVisualEditor = spreadsheetVisualEditor;
            _definedName = definedName;

            // initialize the scope combobox
            InitScopeComboBox();

            if (string.IsNullOrEmpty(definedName.WorksheetName))
                scopeComboBox.SelectedItem = GLOBAL_SCOPE;
            else
                scopeComboBox.SelectedItem = definedName.WorksheetName;
            scopeComboBox.Enabled = false;

            nameTextBox.Text = definedName.Name;
            commentTextBox.Text = definedName.Comment;
            refersToTextBox.Text = "=" + definedName.Value;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                DemosTools.ShowErrorMessage("Name is not defined.");
                nameTextBox.Focus();
                return;
            }

            string worksheetName = (string)scopeComboBox.SelectedItem;
            if (worksheetName == GLOBAL_SCOPE)
                worksheetName = null;

            try
            {
                // if existing defined name is editing
                if (_definedName != null)
                {
                    // set/change the defined name
                    _spreadsheetVisualEditor.SetDefinedName(_definedName, name, worksheetName, refersToTextBox.Text, commentTextBox.Text);
                }
                else
                {
                    // add the defined name
                    _spreadsheetVisualEditor.AddDefinedName(name, worksheetName, refersToTextBox.Text, commentTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Initializes combo box with scope (worksheet names).
        /// </summary>
        private void InitScopeComboBox()
        {
            // add "Workbook" (for ability to add global defined name) to the combobox
            scopeComboBox.Items.Add(GLOBAL_SCOPE);

            // for each worksheet
            foreach (Worksheet worksheet in _spreadsheetVisualEditor.Document.Worksheets)
            {
                // add the worksheet name to the combobox
                scopeComboBox.Items.Add(worksheet.Name);
            }
        }

        /// <summary>
        /// Returns a string that represents reference to the focused cell in focused worksheet.
        /// </summary>
        private string CreateRefersTo()
        {
            return _spreadsheetVisualEditor.GetFixedSelectedCells().ToString(_spreadsheetVisualEditor.Document.Defaults.FormattingProperties);
        }

        #endregion

    }
}
