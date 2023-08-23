using System;
using System.ComponentModel;
using System.Drawing;

using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;
using System.Windows.Forms;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a context menu for cells, rows or columns.
    /// </summary>
    public partial class SpreadsheetCellContextMenu : SpreadsheetVisualEditorContextMenu
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetCellContextMenu"/> class.
        /// </summary>
        public SpreadsheetCellContextMenu()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        CommentsPanel _commentsPanel;
        /// <summary>
        /// Gets or sets the comment panel.
        /// </summary>
        [Description("The comment panel.")]
        public CommentsPanel CommentsPanel
        {
            get
            {
                return _commentsPanel;
            }
            set
            {
                _commentsPanel = value;
            }
        }

        CellsEditorPanel _cellsEditorPanel;
        /// <summary>
        /// Gets or sets the cells editor panel.
        /// </summary>
        [Description("The cells editor panel.")]
        public CellsEditorPanel CellsEditorPanel
        {
            get
            {
                return _cellsEditorPanel;
            }
            set
            {
                _cellsEditorPanel = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns a value indicating whether the context menu must be shown.
        /// </summary>
        protected override bool NeedShowContextMenu()
        {
            return SpreadsheetEditor.VisualEditor.FocusedCells != null &&
                   SpreadsheetEditor.VisualEditor.FocusedComment == null;
        }

        /// <summary>
        /// Handles the Click event of CopyToolStripMenuItem object.
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.Copy();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of CutToolStripMenuItem object.
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.Cut();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of PasteToolStripMenuItem object.
        /// </summary>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.PasteWithFill = (ModifierKeys & Keys.Control) != 0;
                SpreadsheetEditor.VisualEditor.Paste();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                SpreadsheetEditor.VisualEditor.PasteWithFill = false;
            }
        }

        /// <summary>
        /// Handles the Click event of InsertColumnsToolStripMenuItem object.
        /// </summary>
        private void insertColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertEmptyColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertRowsToolStripMenuItem object.
        /// </summary>
        private void insertRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertEmptyRows();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteColumnsToolStripMenuItem object.
        /// </summary>
        private void deleteColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteRowsToolStripMenuItem object.
        /// </summary>
        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveRows();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ShiftCellsRightToolStripMenuItem object.
        /// </summary>
        private void shiftCellsRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertCellsAndShiftRight();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ShiftCellsDownToolStripMenuItem object.
        /// </summary>
        private void shiftCellsDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertCellsAndShiftDown();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertEntireRowToolStripMenuItem object.
        /// </summary>
        private void insertEntireRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertEmptyRows();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertEntireColumnToolStripMenuItem object.
        /// </summary>
        private void insertEntireColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.InsertEmptyColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ShiftCellsLeftToolStripMenuItem object.
        /// </summary>
        private void shiftCellsLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveCellsAndShiftLeft();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ShiftCellsUpToolStripMenuItem object.
        /// </summary>
        private void shiftCellsUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveCellsAndShiftUp();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteEntireRowToolStripMenuItem object.
        /// </summary>
        private void deleteEntireRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveRows();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteEntireColumnToolStripMenuItem object.
        /// </summary>
        private void deleteEntireColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.RemoveColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ClearContentsToolStripMenuItem object.
        /// </summary>
        private void clearContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpreadsheetEditor.VisualEditor.ClearCellsContents();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertCommentToolStripMenuItem object.
        /// </summary>
        private void insertCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommentsPanel.NewComment();
        }

        /// <summary>
        /// Handles the Click event of EditCellCommentToolStripMenuItem object.
        /// </summary>
        private void editCellCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommentsPanel.EditComment();
        }

        /// <summary>
        /// Handles the Click event of DeleteCellCommentToolStripMenuItem object.
        /// </summary>
        private void deleteCellCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveComments();
        }

        /// <summary>
        /// Handles the Click event of ShowHideCommentToolStripMenuItem object.
        /// </summary>
        private void showHideCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.SetCommentIsVisible(!SpreadsheetEditor.VisualEditor.FocusedCellComment.IsVisible);
        }

        /// <summary>
        /// Handles the Click event of FormatCellsToolStripMenuItem object.
        /// </summary>
        private void formatCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowNumberFormatDialog(SpreadsheetEditor.VisualEditor);
        }

        /// <summary>
        /// Handles the Click event of DefineNameToolStripMenuItem object.
        /// </summary>
        private void defineNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get value for defined name
            string value = SpreadsheetEditor.VisualEditor.GetFixedSelectedCells().ToString(SpreadsheetEditor.VisualEditor.Document.Defaults.FormattingProperties);

            // create dialog that allows to add new defined name
            using (EditDefinedNameForm dlg = new EditDefinedNameForm(SpreadsheetEditor.VisualEditor, value))
            {
                // show the dialog
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of LinkToolStripMenuItem object.
        /// </summary>
        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SpreadsheetEditor.VisualEditor.FocusedHyperlink != null && SpreadsheetEditor.VisualEditor.SelectionContainsSingleCell)
                EditHyperlinkForm.ShowDialog(SpreadsheetEditor.VisualEditor, true);
            else
                EditHyperlinkForm.ShowDialog(SpreadsheetEditor.VisualEditor, false);
        }

        /// <summary>
        /// Handles the Click event of RemoveLinkToolStripMenuItem object.
        /// </summary>
        private void removeLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveHyperlinks();
        }

        /// <summary>
        /// Handles the Click event of ColumnWidthToolStripMenuItem object.
        /// </summary>
        private void columnWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellsEditorPanel.SetColumnWidth();
        }

        /// <summary>
        /// Handles the Click event of RowHeightToolStripMenuItem object.
        /// </summary>
        private void rowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellsEditorPanel.SetRowHeight();
        }

        /// <summary>
        /// Handles the Click event of HideColumnsToolStripMenuItem object.
        /// </summary>
        private void hideColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.HideColumns();
        }

        /// <summary>
        /// Handles the Click event of HideRowsToolStripMenuItem object.
        /// </summary>
        private void hideRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.HideRows();
        }

        /// <summary>
        /// Handles the Click event of UnhideColumnsToolStripMenuItem object.
        /// </summary>
        private void unhideColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.ShowColumns();
        }

        /// <summary>
        /// Handles the Click event of UnhideRowsToolStripMenuItem object.
        /// </summary>
        private void unhideRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.ShowRows();
        }

        /// <summary>
        /// Shows the context menu.
        /// </summary>
        /// <param name="spreadsheetEditor">Spreadsheet editor control.</param>
        /// <param name="menuLocation">The menu location.</param>
        protected override void ShowContextMenu(SpreadsheetEditorControl spreadsheetEditor, Point menuLocation)
        {
            // selection contains whole columns
            bool isCoverColumns = SpreadsheetEditor.VisualEditor.FocusedCells.IsCoverColumns;
            // selection contains whole rows
            bool isCoverRows = SpreadsheetEditor.VisualEditor.FocusedCells.IsCoverRows;
            // context menu was opened on "select all" button (top left corner of the grid)
            bool isSelectAllHovered = SpreadsheetEditor.VisualEditor.HoveredCell.RowIndex < 0 && 
                                      SpreadsheetEditor.VisualEditor.HoveredCell.ColumnIndex < 0;

            // all cells selected or selection does not have whole rows or columns
            bool addCellsMenuItems = isSelectAllHovered || !isCoverColumns && !isCoverRows;
            // menu was opened on column header or selection contains whole columns, but not whole rows
            bool addColumnsMenuItems = !addCellsMenuItems && (SpreadsheetEditor.VisualEditor.HoveredCell.RowIndex < 0 || isCoverColumns && !isCoverRows);
            // none of the previous conditions were met and selection contains whole rows
            bool addRowsMenuItems = !addCellsMenuItems && !addColumnsMenuItems && isCoverRows;

            // add menu items, which allow to manage cells
            insertCellsToolStripMenuItem.Visible = addCellsMenuItems;
            deleteCellsToolStripMenuItem.Visible = addCellsMenuItems;
            defineNameToolStripMenuItem.Visible = addCellsMenuItems;
            linkToolStripMenuItem.Visible = addCellsMenuItems;
            removeLinkToolStripMenuItem.Visible = addCellsMenuItems;

            // focused cell comment
            bool cellHasComment = SpreadsheetEditor.VisualEditor.FocusedCellComment != null;
            bool isSingleCellSelection = SpreadsheetEditor.VisualEditor.SelectionContainsSingleCell;
            // add menu items, which allow to manage cell comments
            insertCommentToolStripMenuItem.Visible = addCellsMenuItems && !cellHasComment && isSingleCellSelection;
            editCellCommentToolStripMenuItem.Visible = addCellsMenuItems && cellHasComment && isSingleCellSelection;
            showHideCommentToolStripMenuItem.Visible = addCellsMenuItems && cellHasComment && isSingleCellSelection;
            deleteCellCommentToolStripMenuItem.Visible = addCellsMenuItems && SpreadsheetEditor.VisualEditor.SelectedCellsHasComments;
            toolStripSeparator3.Visible = addCellsMenuItems && (isSingleCellSelection || SpreadsheetEditor.VisualEditor.SelectedCellsHasComments);

            // add menu items, which allow to manage columns
            columnWidthToolStripMenuItem.Visible = addColumnsMenuItems;
            insertColumnsToolStripMenuItem.Visible = addColumnsMenuItems;
            deleteColumnsToolStripMenuItem.Visible = addColumnsMenuItems;
            hideColumnsToolStripMenuItem.Visible = addColumnsMenuItems;
            unhideColumnsToolStripMenuItem.Visible = addColumnsMenuItems;

            // add menu items, which allow to manage rows
            rowHeightToolStripMenuItem.Visible = addRowsMenuItems;
            insertRowsToolStripMenuItem.Visible = addRowsMenuItems;
            deleteRowsToolStripMenuItem.Visible = addRowsMenuItems;
            hideRowsToolStripMenuItem.Visible = addRowsMenuItems;
            unhideRowsToolStripMenuItem.Visible = addRowsMenuItems;

            Show(SpreadsheetEditor, menuLocation);
        }

        #endregion
    }
}
