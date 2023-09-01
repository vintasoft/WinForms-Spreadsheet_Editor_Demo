using DemosCommonCode;
using System;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;


namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides the "Defined Names" panel.
    /// </summary>
    public partial class DefinedNamesPanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedNamesPanel"/> class.
        /// </summary>
        public DefinedNamesPanel()
        {
            InitializeComponent();

            DemosTools.AutoFitToolstripButtons(this.toolStrip1);
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the OnSpreadsheetEditorChanged event.
        /// </summary>
        /// <param name="args">The event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (args.OldValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.NewValue.VisualEditor;
                visualEditor.EditCellValueStarted -= VisualEditor_EditCellValueStarted;
                visualEditor.EditCellValueFinished -= VisualEditor_EditCellValueFinished;
            }
            if (args.NewValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.NewValue.VisualEditor;
                visualEditor.EditCellValueStarted += VisualEditor_EditCellValueStarted;
                visualEditor.EditCellValueFinished += VisualEditor_EditCellValueFinished;
                visualEditor.EditorChanged += VisualEditor_EditorChanged;
                visualEditor.InitializationFinished += VisualEditor_InitializationFinished;
            }
            UpdateUI();
        }


        /// <summary>
        /// "Insert name" button is clicked.
        /// </summary>
        private void insertDefinedNameInFormulaButton_Click(object sender, EventArgs e)
        {
            // get a list of defined names, which are defined on focused worksheet
            DefinedName[] definedNames = VisualEditor.GetFocusedWorksheetDefinedNames();

            // create dialog that allows to select defined name
            using (SelectDefinedNameForm dlg = new SelectDefinedNameForm(definedNames))
            {
                // show the dialog
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // get selected defined name
                    string selectedDefinedName = dlg.SelectedDefinedName;

                    // insert formula in focused cell
                    VisualEditor.InsertFormulaInFocusedCell(selectedDefinedName);
                }
            }
            UpdateUI();
        }

        /// <summary>
        /// "Define name" button is clicked.
        /// </summary>
        private void addDefineNameButton_Click(object sender, EventArgs e)
        {
            // get value for defined name
            string value = VisualEditor.GetFixedSelectedCells().ToString(VisualEditor.Document.Defaults.FormattingProperties);

            // create dialog that allows to add new defined name
            using (EditDefinedNameForm dlg = new EditDefinedNameForm(SpreadsheetEditor.VisualEditor, value))
            {
                // show the dialog
                dlg.ShowDialog();
            }
            UpdateUI();
        }

        /// <summary>
        /// "Defined Names" button is clicked.
        /// </summary>
        private void definedNamesButton_Click(object sender, EventArgs e)
        {
            using (DefinedNameManagerForm dlg = new DefinedNameManagerForm(SpreadsheetEditor.VisualEditor))
            {
                dlg.ShowDialog();
            }
            UpdateUI();
        }

        private void VisualEditor_InitializationFinished(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void VisualEditor_EditorChanged(object sender, PropertyChangedEventArgs<Vintasoft.Imaging.Office.Spreadsheet.SpreadsheetEditor> e)
        {
            UpdateUI();
        }

        private void VisualEditor_EditCellValueFinished(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void VisualEditor_EditCellValueStarted(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            addDefineNameButton.Enabled = !VisualEditor.IsChangingFocusedCellValue;
            insertDefinedNameButton.Enabled = VisualEditor.Document != null && VisualEditor.GetFocusedWorksheetDefinedNames().Length > 0;
        }

        #endregion

    }
}
