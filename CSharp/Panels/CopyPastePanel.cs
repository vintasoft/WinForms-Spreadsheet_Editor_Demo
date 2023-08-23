using System;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet;
using System.Windows.Forms;
using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Copy/Paste" panel.
    /// </summary>
    public partial class CopyPastePanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyPastePanel"/> class.
        /// </summary>
        public CopyPastePanel()
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
                args.OldValue.VisualEditor.CellsClipboardChanged -= VisualEditor_CellsBufferChanged;
                args.OldValue.VisualEditor.FocusedCellsChanged -= VisualEditor_FocusedCellsChanged;
                args.OldValue.VisualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
            }

            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.CellsClipboardChanged += VisualEditor_CellsBufferChanged;
                args.NewValue.VisualEditor.FocusedCellsChanged += VisualEditor_FocusedCellsChanged;
                args.NewValue.VisualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
            }

            UpdateUI();
        }

        private void VisualEditor_FocusedCellsChanged(object sender, PropertyChangedEventArgs<CellReferences> e)
        {
            UpdateUI();
        }

        private void VisualEditor_CellsBufferChanged(object sender, PropertyChangedEventArgs<SheetCellsClipboard> e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.IsFocusedWorksheetChanging)
                return;

            if (VisualEditor.FocusedWorksheet == null || VisualEditor.FocusedCells == null)
            {
                Enabled = false;
            }
            else
            {
                Enabled = true;
                if (VisualEditor.CellsClipboard != null)
                {
                    pasteButton.Enabled = true;
                    pasteContentsToolStripMenuItem.Enabled = !VisualEditor.IsChangingFocusedCellValue;
                    pasteFormulasToolStripMenuItem.Enabled = !VisualEditor.IsChangingFocusedCellValue;
                    pasteSpecialToolStripMenuItem.Enabled = !VisualEditor.IsChangingFocusedCellValue;
                    pasteValuesAndStyleToolStripMenuItem.Enabled = !VisualEditor.IsChangingFocusedCellValue;
                    pasteValuesToolStripMenuItem.Enabled = !VisualEditor.IsChangingFocusedCellValue;
                }
                else
                {
                    pasteContentsToolStripMenuItem.Enabled = false;
                    pasteFormulasToolStripMenuItem.Enabled = false;
                    pasteSpecialToolStripMenuItem.Enabled = false;
                    pasteValuesAndStyleToolStripMenuItem.Enabled = false;
                    pasteValuesToolStripMenuItem.Enabled = false;
                }
                pasteButton.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the ButtonClick event of CopyButton object.
        /// </summary>
        private void copyButton_ButtonClick(object sender, EventArgs e)
        {
            VisualEditor.Copy();
        }

        /// <summary>
        /// Handles the Click event of CutMenuItem object.
        /// </summary>
        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.Cut();
        }

        /// <summary>
        /// Handles the ButtonClick event of PasteButton object.
        /// </summary>
        private void pasteButton_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.PasteWithFill = (ModifierKeys & Keys.Control) != 0;
                VisualEditor.Paste();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                VisualEditor.PasteWithFill = false;
            }
        }

        /// <summary>
        /// Handles the Click event of PasteContentsToolStripMenuItem object.
        /// </summary>
        private void pasteContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.PasteCellsContent();
        }

        /// <summary>
        /// Handles the Click event of PasteValuesAndStyleToolStripMenuItem object.
        /// </summary>
        private void pasteValuesAndStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.PasteCellsValueAndStyle();
        }

        /// <summary>
        /// Handles the Click event of PasteValuesToolStripMenuItem object.
        /// </summary>
        private void pasteValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.PasteCellsValue();
        }

        /// <summary>
        /// Handles the Click event of PasteFormulasToolStripMenuItem object.
        /// </summary>
        private void pasteFormulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.PasteCellsFormula();
        }

        /// <summary>
        /// Handles the Click event of PasteSpecialToolStripMenuItem object.
        /// </summary>
        private void pasteSpecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CellPasteSpecialForm dlg = new CellPasteSpecialForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    UpdateUI();
                }
            }
        }

        /// <summary>
        /// Handles the DropDownOpened event of PasteButton object.
        /// </summary>
        private void pasteButton_DropDownOpened(object sender, EventArgs e)
        {
            UpdateUI();
        }

        #endregion

    }
}
