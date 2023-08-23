using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging.UI.WinForms;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Formula" panel.
    /// </summary>
    public partial class FormulaPanel : SpreadsheetVisualEditorPanel
    {

        #region Fields

        /// <summary>
        /// Indicates when changing <see cref="cellsReferenceComboBox"/>.Text.
        /// </summary>
        bool _changingCellsReferenceComboBoxText = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaPanel"/> class.
        /// </summary>
        public FormulaPanel()
        {
            InitializeComponent();
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
                SpreadsheetVisualEditor visualEditor = args.OldValue.VisualEditor;
                visualEditor.EditCellValueStarted -= VisualEditor_EditCellValueStarted;
                visualEditor.EditCellValueFinished -= VisualEditor_EditCellValueFinished;
                visualEditor.FocusedCellChanged -= VisualEditor_FocusedCellChanged;
                visualEditor.FocusedCellsChanged -= VisualEditor_FocusedCellsChanged;
                visualEditor.FormulaSyntaxError -= VisualEditor_FormulaSyntaxError;
            }
            if (args.NewValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.NewValue.VisualEditor;
                visualEditor.CellValueExternalEditor = new WinFormsTextBoxProvider(cellValueTextBox);
                visualEditor.EditCellValueStarted += VisualEditor_EditCellValueStarted;
                visualEditor.EditCellValueFinished += VisualEditor_EditCellValueFinished;
                visualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
                visualEditor.FocusedCellsChanged += VisualEditor_FocusedCellsChanged;
                visualEditor.FormulaSyntaxError += VisualEditor_FormulaSyntaxError;
            }
            else
            {
                cellsReferenceComboBox.Text = "";
            }
            buttonCancel.Enabled = VisualEditor.IsChangingFocusedCellValue;
            buttonOk.Enabled = VisualEditor.IsChangingFocusedCellValue;
        }


        /// <summary>
        /// Handles the FocusedCellsChanged event of the VisualEditor control.
        /// </summary>
        private void VisualEditor_FocusedCellsChanged(object sender, PropertyChangedEventArgs<CellReferences> e)
        {
            if (e.NewValue != null)
            {
                if (VisualEditor.IsFocusedCellsChanging)
                {
                    if (e.NewValue.ColumnCount == 1 && e.NewValue.RowCount == 1)
                    {
                        cellsReferenceComboBox.Text = VisualEditor.FocusedCell.GetA1Name();
                    }
                    else
                    {
                        cellsReferenceComboBox.Text = string.Format("{0}R x {1}C", e.NewValue.RowCount, e.NewValue.ColumnCount);
                        Update();
                    }
                }
            }
            else
            {
                cellsReferenceComboBox.Text = "";
            }
        }

        /// <summary>
        /// Handles the FocusedCellChanged event of the VisualEditor control.
        /// </summary>
        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            if (!VisualEditor.IsFocusedCellsChanging)
            {
                _changingCellsReferenceComboBoxText = true;
                if (e.NewValue != null)
                {
                    cellsReferenceComboBox.Text = e.NewValue.GetA1Name();
                }
                else
                {
                    cellsReferenceComboBox.Text = "";
                }
                _changingCellsReferenceComboBoxText = false;
            }
        }

        /// <summary>
        /// Handles the EditCellValueStarted event of the VisualEditor control.
        /// </summary>
        private void VisualEditor_EditCellValueStarted(object sender, EventArgs e)
        {
            buttonCancel.Enabled = true;
            buttonOk.Enabled = true;
        }

        /// <summary>
        /// Handles the EditCellValueFinished event of the VisualEditor control.
        /// </summary>
        private void VisualEditor_EditCellValueFinished(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonOk.Enabled = false;
        }

        /// <summary>
        /// Handles the KeyDown event of the cellsReferenceComboBox control.
        /// </summary>
        private void cellsReferenceComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CellReferences cellReferences = SetCellReference();
                if (cellReferences != null)
                    if (!cellsReferenceComboBox.Items.Contains(cellReferences))
                        cellsReferenceComboBox.Items.Insert(0, cellReferences);
            }
        }

        /// <summary>
        /// Sets the cell reference.
        /// </summary>
        /// <returns></returns>
        private CellReferences SetCellReference()
        {
            try
            {
                if (!string.IsNullOrEmpty(cellsReferenceComboBox.Text))
                    return VisualEditor.SetFocusedAndSelectedCells(cellsReferenceComboBox.Text);
            }
            catch (Exception ex)
            {
                DemosCommonCode.DemosTools.ShowErrorMessage(ex);
            }
            return null;
        }

        /// <summary>
        /// Handles the Click event of the buttonCancel control.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            VisualEditor.CancelEditCellValue();
        }

        /// <summary>
        /// Handles the Click event of the buttonOk control.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Exception parsingException = null;
            if (!VisualEditor.TryFinishEditCellFormula(out parsingException))
            {
                if (MessageBox.Show(parsingException.Message, "Formula Syntax Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    VisualEditor.CancelEditCellValue();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cellsReferenceComboBox control.
        /// </summary>
        private void cellsReferenceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!VisualEditor.IsFocusedCellsChanging && !_changingCellsReferenceComboBoxText)
                SetCellReference();
        }

        /// <summary>
        /// Handles the Click event of InsertFunctionButton object.
        /// </summary>
        private void insertFunctionButton_Click(object sender, EventArgs e)
        {
            string function = SelectFunctionForm.SelectFunction(VisualEditor.Document);
            if (function != null)
            {
                VisualEditor.InsertFormulaInFocusedCell(function + "()");
            }
            else
            {
                VisualEditor.StartEditFocusedCellFormula(true);
            }
        }

        /// <summary>
        /// Handles the FormulaSyntaxError event of the VisualEditor.
        /// </summary>
        private void VisualEditor_FormulaSyntaxError(object sender, ExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Formula Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

    }
}
