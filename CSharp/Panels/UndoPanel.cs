using DemosCommonCode;
using System.Windows.Forms;
using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Undo" panel.
    /// </summary>
    public partial class UndoPanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoPanel"/> class.
        /// </summary>
        public UndoPanel()
        {
            InitializeComponent();

            DemosTools.AutoFitToolstripButtons(this.toolStrip1);
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
                args.OldValue.VisualEditor.UndoManagerStateChanged -= VisualEditor_UndoManagerStateChanged;
            }

            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.UndoManagerStateChanged += VisualEditor_UndoManagerStateChanged;
            }

            UpdateUI();
        }
     
        /// <summary>
        /// Handles the UndoManagerStateChanged event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void VisualEditor_UndoManagerStateChanged(object sender, System.EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        protected override void UpdateCoreUI()
        {
            base.UpdateCoreUI();
            if (Enabled)
                UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.IsFocusedWorksheetChanging)
                return;

            if (VisualEditor.FocusedWorksheet == null)
            {
                Enabled = false;
            }
            else
            {
                Enabled = true;

                if (VisualEditor.CanUndo)
                {
                    undoButton.Enabled = true;
                    undoButton.ToolTipText = VisualEditor.UndoManager.CurrentUndoAction.Description;
                }
                else
                {
                    undoButton.Enabled = false;
                }
                if (VisualEditor.CanRedo)
                {
                    redoButton.Enabled = true;
                    redoButton.ToolTipText = VisualEditor.UndoManager.CurrentRedoAction.Description;
                }
                else
                {
                    redoButton.Enabled = false;
                }
            }
        }

      
        /// <summary>
        /// Handles the ButtonClick event of UndoButton object.
        /// </summary>
        private void undoButton_ButtonClick(object sender, System.EventArgs e)
        {
            VisualEditor.UndoManager.Undo();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the ButtonClick event of RedoButton object.
        /// </summary>
        private void redoButton_ButtonClick(object sender, System.EventArgs e)
        {
            VisualEditor.UndoManager.Redo();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the DropDownOpening event of UndoButton object.
        /// </summary>
        private void undoButton_DropDownOpening(object sender, System.EventArgs e)
        {
            SpreadsheetEditorUndoAction[] availableUndoActions = VisualEditor.UndoManager.GetAvailableUndoActions();
            undoButton.DropDownItems.Clear();
            for(int i=0;i<availableUndoActions.Length;i++)
            {
                ToolStripItem item = undoButton.DropDownItems.Add(availableUndoActions[i].Description);
                item.Tag = i + 1;
                item.Click += UndoItem_Click;
            }
        }

        /// <summary>
        /// Handles the Click event of UndoItem object.
        /// </summary>
        private void UndoItem_Click(object sender, System.EventArgs e)
        {
            VisualEditor.UndoManager.Undo((int)((ToolStripItem)sender).Tag);
        }

        /// <summary>
        /// Handles the DropDownOpening event of RedoButton object.
        /// </summary>
        private void redoButton_DropDownOpening(object sender, System.EventArgs e)
        {
            SpreadsheetEditorUndoAction[] availableRedoActions = VisualEditor.UndoManager.GetAvailableRedoActions();
            redoButton.DropDownItems.Clear();
            for (int i = 0; i < availableRedoActions.Length; i++)
            {
                ToolStripItem item = redoButton.DropDownItems.Add(availableRedoActions[i].Description);
                item.Tag = i + 1;
                item.Click += RedoItem_Click;
            }
        }

        /// <summary>
        /// Handles the Click event of RedoItem object.
        /// </summary>
        private void RedoItem_Click(object sender, System.EventArgs e)
        {
            VisualEditor.UndoManager.Redo((int)((ToolStripItem)sender).Tag);
        }

        #endregion

    }
}
