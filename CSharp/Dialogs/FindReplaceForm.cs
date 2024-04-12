using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// "Find and Replace" form.
    /// </summary>
    public partial class FindReplaceForm : Form
    {

        #region Fields

        /// <summary>
        /// A value indicating whether <see cref="_textFindReplace"/> must be reset.
        /// </summary>
        bool _needReset = true;

        /// <summary>
        /// The text find and replace engine.
        /// </summary>
        SpreadsheetFindReplace _textFindReplace;

        /// <summary>
        /// The current results.
        /// </summary>
        SpreadsheetCellReference[] _currentResults;

        bool _updateFocusedCell = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindReplaceForm"/> class.
        /// </summary>
        public FindReplaceForm()
        {
            InitializeComponent();

            findWithinComboBox.SelectedIndex = 0;
            lookInComboBox.SelectedIndex = 0;
            searchComboBox.SelectedIndex = 0;

            Height = MinimumSize.Height;

            UpdateUI();
        }

        #endregion



        #region Properties

        SpreadsheetVisualEditor _visualEditor;
        /// <summary>
        /// Gets or sets the visual editor.
        /// </summary>
        public SpreadsheetVisualEditor VisualEditor
        {
            get
            {
                return _visualEditor;
            }
            set
            {
                if (_visualEditor != null)
                {
                    _visualEditor.SelectedCells.Changed -= SelectedCells_Changed;
                    _visualEditor.FocusedWorksheetChanged -= visualEditor_FocusedWorksheetChanged;
                }

                _visualEditor = value;

                if (_visualEditor != null)
                {
                    _visualEditor.SelectedCells.Changed += SelectedCells_Changed;
                    _visualEditor.FocusedWorksheetChanged += visualEditor_FocusedWorksheetChanged;
                }
                _textFindReplace = null;
                UpdateUI();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether replace mode is used.
        /// </summary>
        public bool ReplaceMode
        {
            get
            {
                return replaceCheckBox.Checked;
            }
            set
            {
                replaceCheckBox.Checked = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Resets the dialog.
        /// </summary>
        public void Reset()
        {
            _needReset = true;
            findWhatComboBox.Focus();
        }


        #region UI

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            Enabled = VisualEditor != null;
            replaceAllButton.Visible = ReplaceMode;
            replaceButton.Visible = ReplaceMode;
            replaceLabel.Visible = ReplaceMode;
            replaceWithComboBox.Visible = ReplaceMode;
            addToSelectionButton.Enabled = _currentResults != null && _currentResults.Length > 0;
            if (ReplaceMode)
            {
                lookInComboBox.Enabled = false;
                lookInComboBox.SelectedIndex = 0;
            }
            else
            {
                lookInComboBox.Enabled = true;
            }
            UpdateStatus();

            bool hasWorksheet = VisualEditor != null && VisualEditor.FocusedWorksheet != null;
            replaceAllButton.Enabled = hasWorksheet;
            replaceButton.Enabled = hasWorksheet;
            findAllButton.Enabled = hasWorksheet;
            findNextButton.Enabled = hasWorksheet;
        }

        /// <summary>
        /// Handles the Click event of closeButton object.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Height = MinimumSize.Height;
        }

        /// <summary>
        /// Handles the FormClosing event of FindReplaceForm object.
        /// </summary>
        private void FindReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
            Height = MinimumSize.Height;
        }

        /// <summary>
        /// Handles the CheckedChanged event of replaceCheckBox object.
        /// </summary>
        private void replaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of findNextButton object.
        /// </summary>
        private void findNextButton_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        /// <summary>
        /// Handles the Click event of addToSelectionButton object.
        /// </summary>
        private void addToSelectionButton_Click(object sender, EventArgs e)
        {
            VisualEditor.SetFocusedAndSelectedCells(_currentResults);
        }

        /// <summary>
        /// Handles the Click event of findAllButton object.
        /// </summary>
        private void findAllButton_Click(object sender, EventArgs e)
        {
            SpreadsheetFindReplace textReplacer = GetTextFindReplace();
            if (textReplacer != null)
            {
                if (Height < MinimumSize.Height + 50)
                    Height = MinimumSize.Height + 150;

                ShowResults(textReplacer.FindAll());
                UpdateStatus();
                if (textReplacer.FoundCellCount == 0)
                    ShowMessage(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TEXT_ARG0_IS_NOT_FOUND, textReplacer.Text));
            }
        }

        /// <summary>
        /// Handles the Click event of replaceButton object.
        /// </summary>
        private void replaceButton_Click(object sender, EventArgs e)
        {
            SpreadsheetFindReplace textReplacer = GetTextFindReplace();
            if (textReplacer != null)
            {
                bool result;
                VisualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REPLACE);
                try
                {
                    result = textReplacer.Replace(replaceWithComboBox.Text);
                }
                finally
                {
                    VisualEditor.FinishEditing();
                }
                if (result)
                    FindNext();
                else
                    ShowMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CANNOT_FIND_A_MATCH);
            }
        }

        /// <summary>
        /// Handles the Click event of replaceAllButton object.
        /// </summary>
        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            SpreadsheetFindReplace textReplacer = GetTextFindReplace();
            if (textReplacer != null)
            {
                if (Height < MinimumSize.Height + 50)
                    Height = MinimumSize.Height + 150;

                SpreadsheetCellReference[] result;
                VisualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REPLACE_ALL);
                try
                {
                    result = textReplacer.ReplaceAll(replaceWithComboBox.Text);
                }
                finally
                {
                    VisualEditor.FinishEditing();
                }

                ShowResults(result);

                UpdateStatus();
                if (textReplacer.FoundCellCount == 0)
                    ShowMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COULD_NOT_FIND_ANYTHING_TO_REPLACE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REPLACE_ALT1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    ShowMessage(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ARG0_REPLACEMENTS_ARE_MADE, textReplacer.FoundCellCount), SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REPLACE_ALT2, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the TextChanged event of findWhatComboBox object.
        /// </summary>
        private void findWhatComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of resultListView object.
        /// </summary>
        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListView.SelectedIndices.Count > 0)
            {
                SpreadsheetCellReference workbookCellReference = (SpreadsheetCellReference)resultListView.Items[resultListView.SelectedIndices[0]].Tag;
                if (_textFindReplace.SelectedCells != null)
                    VisualEditor.FocusedSpreadsheetCell = workbookCellReference;
                else
                    VisualEditor.SetFocusedAndSelectedCells(workbookCellReference);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of findWithinComboBox object.
        /// </summary>
        private void findWithinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needReset = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of searchComboBox object.
        /// </summary>
        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needReset = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of lookInComboBox object.
        /// </summary>
        private void lookInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needReset = true;
        }

        #endregion


        /// <summary>
        /// Handles the Changed event of SelectedCells object.
        /// </summary>
        private void SelectedCells_Changed(object sender, EventArgs e)
        {
            if (!_updateFocusedCell && _textFindReplace != null)
                _needReset = true;
        }

        /// <summary>
        /// Handles the FocusedWorksheetChanged event of visualEditor object.
        /// </summary>
        private void visualEditor_FocusedWorksheetChanged(object sender, Vintasoft.Imaging.PropertyChangedEventArgs<Worksheet> e)
        {
            if (e.NewValue == null)
            {
                ShowResults(null);
                Height = MinimumSize.Height;
            }

            UpdateUI();
        }


        /// <summary>
        /// Finds the next cell.
        /// </summary>
        private void FindNext()
        {
            ShowResults(null);
            SpreadsheetFindReplace textReplacer = GetTextFindReplace();
            bool found = false;
            if (textReplacer != null)
            {
                found = textReplacer.FindNext();
                UpdateStatus();
                if (!found)
                {
                    if (textReplacer.FoundCellCount == 0)
                    {
                        ShowMessage(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TEXT_ARG0_IS_NOT_FOUND_ALT1, textReplacer.Text));
                    }
                    else
                    {
                        // find again
                        found = textReplacer.FindNext();
                    }
                }
            }
            if (found)
            {
                _updateFocusedCell = true;
                VisualEditor.FocusedSpreadsheetCell = textReplacer.GetCurrentSpreadsheetCell();
                _updateFocusedCell = false;
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus()
        {
            if (_textFindReplace == null || _textFindReplace.FoundCellCount == 0)
                statusLabel.Text = "";
            else
                statusLabel.Text = string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ARG0_CELLS_FOUND, _textFindReplace.FoundCellCount);
        }

        /// <summary>
        /// Shows the results.
        /// </summary>
        /// <param name="cellReferences">The cell references.</param>
        private void ShowResults(SpreadsheetCellReference[] cellReferences)
        {
            resultListView.Items.Clear();
            _currentResults = cellReferences;
            if (cellReferences != null)
            {
                addToSelectionButton.Enabled = cellReferences.Length > 0;
                foreach (SpreadsheetCellReference cellReference in cellReferences)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Tag = cellReference;
                    listViewItem.Text = cellReference.Sheet.Name;
                    listViewItem.SubItems.Add(cellReference.Reference.GetA1Name());
                    if (_textFindReplace.LookInValues)
                        listViewItem.SubItems.Add(cellReference.FormattedValue);
                    else
                        listViewItem.SubItems.Add(cellReference.Value);
                    listViewItem.SubItems.Add(cellReference.Formula);
                    listViewItem.SubItems.Add(cellReference.CommentText);
                    resultListView.Items.Add(listViewItem);
                }
            }
            else
            {
                addToSelectionButton.Enabled = false;
            }
        }

        /// <summary>
        /// Returns the text find replace engine.
        /// </summary>
        private SpreadsheetFindReplace GetTextFindReplace()
        {
            VisualEditor.FinishEditCellValue();

            if (_textFindReplace == null)
                _textFindReplace = new SpreadsheetFindReplace();

            SetTextFindReplaceProperties(_textFindReplace);

            if (_textFindReplace.SearchInWorkbook)
            {
                _updateFocusedCell = true;
                _visualEditor.SetFocusedAndSelectedCells(new CellReferences(_visualEditor.FocusedCell));
                _updateFocusedCell = false;
            }

            string text = findWhatComboBox.Text;
            if (_needReset || _textFindReplace.Editor != VisualEditor.Editor || _textFindReplace.Text != text)
            {
                VisualEditor.InitializeFindReplace(_textFindReplace, text);
                _needReset = false;
            }

            if (!string.IsNullOrEmpty(findWhatComboBox.Text) && !findWhatComboBox.Items.Contains(findWhatComboBox.Text))
                findWhatComboBox.Items.Insert(0, findWhatComboBox.Text);

            if (!string.IsNullOrEmpty(replaceWithComboBox.Text) && !replaceWithComboBox.Items.Contains(replaceWithComboBox.Text))
                replaceWithComboBox.Items.Insert(0, replaceWithComboBox.Text);

            return _textFindReplace;
        }

        /// <summary>
        /// Sets the properties of text find and replace.
        /// </summary>
        /// <param name="textFindReplace">The text replacer.</param>
        private void SetTextFindReplaceProperties(SpreadsheetFindReplace textFindReplace)
        {
            textFindReplace.MatchCase = matchCaseCheckBox.Checked;
            textFindReplace.MatchEntireContent = matchContentsCheckBox.Checked;
            switch (findWithinComboBox.SelectedIndex)
            {
                case 0:
                    textFindReplace.SearchInWorkbook = false;
                    break;
                case 1:
                    textFindReplace.SearchInWorkbook = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (searchComboBox.SelectedIndex)
            {
                case 0:
                    textFindReplace.SearchByRows = true;
                    break;
                case 1:
                    textFindReplace.SearchByRows = false;
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (lookInComboBox.SelectedIndex)
            {
                case 0:
                    textFindReplace.LookInFormulas = true;
                    textFindReplace.LookInValues = false;
                    textFindReplace.LookInComments = false;
                    break;
                case 1:
                    textFindReplace.LookInFormulas = false;
                    textFindReplace.LookInValues = true;
                    textFindReplace.LookInComments = false;
                    break;
                case 2:
                    textFindReplace.LookInFormulas = false;
                    textFindReplace.LookInValues = false;
                    textFindReplace.LookInComments = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="message">The message.</param>
        private void ShowMessage(string message)
        {
            ShowMessage(message, "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="message">The message.</param>
        private void ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            bool topMost = TopMost;
            TopMost = false;
            MessageBox.Show(message, caption, buttons, icon);
            TopMost = topMost;
        }

        #endregion

    }
}
