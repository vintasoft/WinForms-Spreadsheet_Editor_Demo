using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging.Office.Spreadsheet.UI.Controls;

using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a context menu for cells, rows or columns in spreadsheet visual editor.
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



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Returns a value indicating whether the context menu must be shown.
        /// </summary>
        protected override bool NeedShowContextMenu()
        {
            return SpreadsheetEditor.VisualEditor.FocusedCells != null &&
                   SpreadsheetEditor.VisualEditor.FocusedComment == null;
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


        #region PRIVATE

        /// <summary>
        /// Handles the Click event of copyToolStripMenuItem object.
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
        /// Handles the Click event of cutToolStripMenuItem object.
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
        /// Handles the Click event of pasteToolStripMenuItem object.
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
        /// Handles the Click event of insertColumnsToolStripMenuItem object.
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
        /// Handles the Click event of insertRowsToolStripMenuItem object.
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
        /// Handles the Click event of deleteColumnsToolStripMenuItem object.
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
        /// Handles the Click event of deleteRowsToolStripMenuItem object.
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
        /// Handles the Click event of shiftCellsRightToolStripMenuItem object.
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
        /// Handles the Click event of shiftCellsDownToolStripMenuItem object.
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
        /// Handles the Click event of insertEntireRowToolStripMenuItem object.
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
        /// Handles the Click event of insertEntireColumnToolStripMenuItem object.
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
        /// Handles the Click event of shiftCellsLeftToolStripMenuItem object.
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
        /// Handles the Click event of shiftCellsUpToolStripMenuItem object.
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
        /// Handles the Click event of deleteEntireRowToolStripMenuItem object.
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
        /// Handles the Click event of deleteEntireColumnToolStripMenuItem object.
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
        /// Handles the Click event of clearContentsToolStripMenuItem object.
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
        /// Handles the Click event of insertCommentToolStripMenuItem object.
        /// </summary>
        private void insertCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetVisualEditor visualEditor = SpreadsheetEditor.VisualEditor;

            // get the focused cell
            CellReference focusedCell = visualEditor.FocusedCell;

            // create dialog that allows to edit the comment
            using (EditCommentForm dlg = new EditCommentForm(visualEditor))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CellComment newCellComment = new CellComment(focusedCell, dlg.Comment, true, dlg.CommentLocation);

                    visualEditor.SetCellComment(newCellComment);

                    visualEditor.FocusedComment = visualEditor.FocusedCellComment;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of editCellCommentToolStripMenuItem object.
        /// </summary>
        private void editCellCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetVisualEditor visualEditor = SpreadsheetEditor.VisualEditor;

            CellComment sourceCellComment = visualEditor.FocusedComment ?? visualEditor.FocusedCellComment;
            Comment sourceComment = sourceCellComment.Comment;
            SheetDrawingLocation sourceLocation = sourceCellComment.Location;

            // create dialog that allows to edit the comment
            using (EditCommentForm dlg = new EditCommentForm(visualEditor, sourceComment, sourceLocation))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    visualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EDIT_COMMENT);
                    try
                    {
                        visualEditor.SetComment(dlg.Comment);
                        visualEditor.SetCommentLocation(dlg.CommentLocation);
                    }
                    finally
                    {
                        visualEditor.FinishEditing();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of deleteCellCommentToolStripMenuItem object.
        /// </summary>
        private void deleteCellCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveComments();
        }

        /// <summary>
        /// Handles the Click event of showHideCommentToolStripMenuItem object.
        /// </summary>
        private void showHideCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.SetCommentIsVisible(!SpreadsheetEditor.VisualEditor.FocusedCellComment.IsVisible);
        }

        /// <summary>
        /// Handles the Click event of formatCellsToolStripMenuItem object.
        /// </summary>
        private void formatCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowNumberFormatDialog(SpreadsheetEditor.VisualEditor);
        }

        /// <summary>
        /// Handles the Click event of defineNameToolStripMenuItem object.
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
        /// Handles the Click event of linkToolStripMenuItem object.
        /// </summary>
        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SpreadsheetEditor.VisualEditor.FocusedHyperlink != null && SpreadsheetEditor.VisualEditor.SelectionContainsSingleCell)
                EditHyperlinkForm.ShowDialog(SpreadsheetEditor.VisualEditor, true);
            else
                EditHyperlinkForm.ShowDialog(SpreadsheetEditor.VisualEditor, false);
        }

        /// <summary>
        /// Handles the Click event of removeLinkToolStripMenuItem object.
        /// </summary>
        private void removeLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveHyperlinks();
        }

        /// <summary>
        /// Handles the Click event of columnWidthToolStripMenuItem object.
        /// </summary>
        private void columnWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetVisualEditor visualEditor = SpreadsheetEditor.VisualEditor;

            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(visualEditor, visualEditor.ColumnsWidth, 0, CellsEditorPanel.MAX_COLUMN_WIDTH, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN_WIDTH))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set width of focused columns
                    visualEditor.ColumnsWidth = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of rowHeightToolStripMenuItem object.
        /// </summary>
        private void rowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetVisualEditor visualEditor = SpreadsheetEditor.VisualEditor;

            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(visualEditor, visualEditor.RowsHeight, 0, CellsEditorPanel.MAX_ROW_HEIGHT, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ROW_HEIGHT))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set height of focused rows
                    visualEditor.RowsHeight = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of hideColumnsToolStripMenuItem object.
        /// </summary>
        private void hideColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.HideColumns();
        }

        /// <summary>
        /// Handles the Click event of hideRowsToolStripMenuItem object.
        /// </summary>
        private void hideRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.HideRows();
        }

        /// <summary>
        /// Handles the Click event of unhideColumnsToolStripMenuItem object.
        /// </summary>
        private void unhideColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.ShowColumns();
        }

        /// <summary>
        /// Handles the Click event of unhideRowsToolStripMenuItem object.
        /// </summary>
        private void unhideRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.ShowRows();
        }

        #endregion

        #endregion

    }
}
