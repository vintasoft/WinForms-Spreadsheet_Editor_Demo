using System;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging.Codecs;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Cells Editor" panel.
    /// </summary>
    public partial class CellsEditorPanel : SpreadsheetVisualEditorPanel
    {

        #region Constants

        /// <summary>
        /// Maximum column width in DIP.
        /// </summary>
        const double MAX_COLUMN_WIDTH = 1908;

        /// <summary>
        /// Maximum row height in DIP.
        /// </summary>
        const double MAX_ROW_HEIGHT = 545;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CellsEditorPanel"/> class.
        /// </summary>
        public CellsEditorPanel()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        #region Common

        /// <summary>
        /// Raises the <see cref="E:SpreadsheetEditorChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (args.OldValue != null)
            {
                args.OldValue.VisualEditor.FocusedCellsChanged -= VisualEditor_FocusedCellsChanged;
                args.OldValue.MouseDoubleClick -= SpreadsheetEditorControl_MouseDoubleClick;
            }

            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.FocusedCellsChanged += VisualEditor_FocusedCellsChanged;
                args.NewValue.MouseDoubleClick += SpreadsheetEditorControl_MouseDoubleClick;
            }

            UpdateUI();
        }


        private void VisualEditor_FocusedCellsChanged(object sender, PropertyChangedEventArgs<CellReferences> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.FocusedWorksheet == null)
            {
                Enabled = false;
            }
            else
            {
                Enabled = true;
                bool hasFcousedCells = VisualEditor.FocusedCells != null;
                insertButton.Enabled = hasFcousedCells;
                deleteButton.Enabled = hasFcousedCells;
                formatButton.Enabled = hasFcousedCells;
                mergeMenuButton.Enabled = hasFcousedCells;
                clearButton.Enabled = hasFcousedCells;
                fillButton.Enabled = hasFcousedCells;
                insertColumnsToolStripMenuItem.Enabled = VisualEditor.CanInsertEmptyColumns;
                insertRowsToolStripMenuItem.Enabled = VisualEditor.CanInsertEmptyRows;
            }
        }

        #endregion


        #region Insert

        /// <summary>
        /// Handles the ButtonClick event of InsertButton object.
        /// </summary>
        private void insertButton_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                // if focused cells contain more rows than columns
                if (VisualEditor.FocusedCells.RowCount > VisualEditor.FocusedCells.ColumnCount)
                {
                    // if full columns are focused
                    if (VisualEditor.FocusedCells.IsCoverColumns)
                        VisualEditor.InsertEmptyColumns();
                    else
                        VisualEditor.InsertCellsAndShiftRight();
                }
                else
                {
                    // if full rows are focused
                    if (VisualEditor.FocusedCells.IsCoverRows)
                        VisualEditor.InsertEmptyRows();
                    else
                        VisualEditor.InsertCellsAndShiftDown();
                }
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
                VisualEditor.InsertEmptyRows();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertColumnsToolStripMenuItem object.
        /// </summary>
        private void insertColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.InsertEmptyColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InsertCellsShiftRightToolStripMenuItem object.
        /// </summary>
        private void insertCellsShiftRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.InsertCellsAndShiftRight();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of InserCellsShiftDownToolStripMenuItem object.
        /// </summary>
        private void inserCellsShiftDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.InsertCellsAndShiftDown();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region Delete

        /// <summary>
        /// Handles the ButtonClick event of DeleteButton object.
        /// </summary>
        private void deleteButton_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                // if focused cells contain more rows than columns
                if (VisualEditor.FocusedCells.RowCount > VisualEditor.FocusedCells.ColumnCount)
                {
                    // if full columns are focused
                    if (VisualEditor.FocusedCells.IsCoverColumns)
                        VisualEditor.RemoveColumns();
                    else
                        VisualEditor.RemoveCellsAndShiftLeft();
                }
                else
                {
                    // if full rows are focused
                    if (VisualEditor.FocusedCells.IsCoverRows)
                        VisualEditor.RemoveRows();
                    else
                        VisualEditor.RemoveCellsAndShiftUp();
                }
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
                VisualEditor.RemoveRows();
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
                VisualEditor.RemoveColumns();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteCellsShiftLeftToolStripMenuItem object.
        /// </summary>
        private void deleteCellsShiftLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.RemoveCellsAndShiftLeft();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DeleteCellsShiftUpToolStripMenuItem object.
        /// </summary>
        private void deleteCellsShiftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.RemoveCellsAndShiftUp();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region Format

        /// <summary>
        /// Handles the ButtonClick event of FormatButton object.
        /// </summary>
        private void formatButton_ButtonClick(object sender, EventArgs e)
        {
            formatButton.ShowDropDown();
        }

        /// <summary>
        /// Handles the Click event of AutoFitRowHeightToolStripMenuItem object.
        /// </summary>
        private void autoFitRowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.AutoFitRowHeight();
        }

        /// <summary>
        /// Handles the Click event of SetRowAutoheightToolStripMenuItem object.
        /// </summary>
        private void setRowAutoheightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.SetRowAutoHeight();
        }

        /// <summary>
        /// Handles the Click event of CalculateRowAutoHeightToolStripMenuItem object.
        /// </summary>
        private void calculateRowAutoHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.CalculateRowAutoHeight();
        }

        /// <summary>
        /// Handles the Click event of RowHeightToolStripMenuItem object.
        /// </summary>
        private void rowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRowHeight();
        }

        /// <summary>
        /// Shows a dialog, which allows to enter a new row height value, and applies height to the selected rows.
        /// </summary>
        public void SetRowHeight()
        {
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, VisualEditor.RowsHeight, 0, MAX_ROW_HEIGHT, "Row height"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set height of focused rows
                    VisualEditor.RowsHeight = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of DefaultRowHeightToolStripMenuItem object.
        /// </summary>
        private void defaultRowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorksheetFormat sheetFormat = VisualEditor.FocusedWorksheet.Format;
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, sheetFormat.RowHeight, 0, MAX_ROW_HEIGHT, "Default row height"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set visual format with new default row height
                    VisualEditor.SetWorksheetFormat(new WorksheetFormat(sheetFormat.ColumnWidth, dlg.Value, sheetFormat.AutoHeight, sheetFormat.RowsHiddenByDefault));
                }
            }
        }

        /// <summary>
        /// Handles the Click event of ColumnWidthToolStripMenuItem object.
        /// </summary>
        private void columnWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColumnWidth();
        }

        /// <summary>
        /// Shows a dialog, which allows to enter a new column width value, and applies width to the selected columns.
        /// </summary>
        public void SetColumnWidth()
        {
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, VisualEditor.ColumnsWidth, 0, MAX_COLUMN_WIDTH, "Column width"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set width of focused columns
                    VisualEditor.ColumnsWidth = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of DefaultColumnWidthToolStripMenuItem object.
        /// </summary>
        private void defaultColumnWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorksheetFormat sheetFormat = VisualEditor.FocusedWorksheet.Format;
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, sheetFormat.ColumnWidth, 0, MAX_COLUMN_WIDTH, "Default column width"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set visual format with new default column width
                    VisualEditor.SetWorksheetFormat(new WorksheetFormat(dlg.Value, sheetFormat.RowHeight, sheetFormat.AutoHeight, sheetFormat.RowsHiddenByDefault));
                }
            }
        }

        /// <summary>
        /// Handles the Click event of AutoFitColumnWidthToolStripMenuItem object.
        /// </summary>
        private void autoFitColumnWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.AutoFitColumnWidth();
        }

        /// <summary>
        /// Handles the Click event of HideRowsToolStripMenuItem object.
        /// </summary>
        private void hideRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.HideRows();
        }

        /// <summary>
        /// Handles the Click event of HideColumnsToolStripMenuItem object.
        /// </summary>
        private void hideColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.HideColumns();
        }

        /// <summary>
        /// Handles the Click event of ShowRowsToolStripMenuItem object.
        /// </summary>
        private void showRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.ShowRows();
        }

        /// <summary>
        /// Handles the Click event of ShowColumnsToolStripMenuItem object.
        /// </summary>
        private void showColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.ShowColumns();
        }

        #endregion


        #region Merge

        /// <summary>
        /// Handles the Click event of MergeCenterToolStripMenuItem object.
        /// </summary>
        private void mergeCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCellsAndCenterText();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of MergeToolStripMenuItem object.
        /// </summary>
        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCells();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of MergeAcrossToolStripMenuItem object.
        /// </summary>
        private void mergeAcrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCellsAcross();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of UnmergeToolStripMenuItem object.
        /// </summary>
        private void unmergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.UnmergeCells();
        }

        #endregion


        #region Clear

        /// <summary>
        /// Handles the ButtonClick event of ClearButton object.
        /// </summary>
        private void clearButton_ButtonClick(object sender, EventArgs e)
        {
            clearButton.ShowDropDown();
        }

        /// <summary>
        /// Handles the Click event of ClearAllToolStripMenuItem object.
        /// </summary>
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.ClearCells();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ClearStylesToolStripMenuItem object.
        /// </summary>
        private void clearStylesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.ClearCellsStyle();
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
                VisualEditor.ClearCellsContents();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ClearHyperlinksToolStripMenuItem object.
        /// </summary>
        private void clearHyperlinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.RemoveHyperlinks();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of ClearCommentsToolStripMenuItem object.
        /// </summary>
        private void clearCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.RemoveComments();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region Fill

        /// <summary>
        /// Handles the ButtonClick event of FillButton object.
        /// </summary>
        private void fillButton_ButtonClick(object sender, EventArgs e)
        {
            fillButton.ShowDropDown();
        }

        /// <summary>
        /// Handles the Click event of FillDownToolStripMenuItem object.
        /// </summary>
        private void fillDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.FillCells(CellsFillDirection.Down);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of FillRightToolStripMenuItem object.
        /// </summary>
        private void fillRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.FillCells(CellsFillDirection.Right);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of FillUpToolStripMenuItem object.
        /// </summary>
        private void fillUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.FillCells(CellsFillDirection.Up);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of FillLeftToolStripMenuItem object.
        /// </summary>
        private void fillLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.FillCells(CellsFillDirection.Left);
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region Image

        /// <summary>
        /// Handles the DropDownOpened event of PictureButton object.
        /// </summary>
        private void pictureButton_DropDownOpened(object sender, EventArgs e)
        {
            setPictureToolStripMenuItem.Enabled = VisualEditor.FocusedDrawing != null && VisualEditor.FocusedDrawing.Type == DrawingType.Picture;
            picturePropertiesToolStripMenuItem.Enabled = VisualEditor.FocusedDrawing != null;
            removePictureToolStripMenuItem.Enabled = VisualEditor.FocusedDrawing != null;
        }

        /// <summary>
        /// Handles the ButtonClick event of PictureButton object.
        /// </summary>
        private void pictureButton_ButtonClick(object sender, EventArgs e)
        {
            pictureButton.ShowDropDown();
        }

        /// <summary>
        /// Handles the Click event of AddPictureToolStripMenuItem object.
        /// </summary>
        private void addPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stream imageStream = GetImageStream();
                if (imageStream != null)
                    using (imageStream)
                        VisualEditor.AddPicture(new ImageData(imageStream));
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of SetPictureToolStripMenuItem object.
        /// </summary>
        private void setPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stream imageStream = GetImageStream();

                if (imageStream != null)
                    using (imageStream)
                        VisualEditor.SetDrawingPicture(new ImageData(imageStream));
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of SpreadsheetEditorControl object.
        /// </summary>
        private void SpreadsheetEditorControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && VisualEditor.FocusedDrawing != null)
                EditDrawing();
        }

        /// <summary>
        /// Handles the Click event of PicturePropertiesToolStripMenuItem object.
        /// </summary>
        private void picturePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDrawing();
        }

        /// <summary>
        /// Handles the Click event of RemovePictureToolStripMenuItem object.
        /// </summary>
        private void removePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.RemoveFocusedDrawing();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Edits the focused drawing.
        /// </summary>
        private void EditDrawing()
        {
            try
            {
                using (DrawingPropertiesForm form = new DrawingPropertiesForm(VisualEditor, VisualEditor.FocusedDrawing))
                {
                    form.Owner = ParentForm;

                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Returns the image stream.
        /// </summary>
        private Stream GetImageStream()
        {
            // create dialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // specify that dialog should open folder with demo images
                DemosTools.SetTestFilesFolder(dialog);
                // set image filters
                CodecsFileFilters.SetOpenFileDialogFilter(dialog);

                // if image must be loaded
                if (dialog.ShowDialog() == DialogResult.OK)
                    // return image stream
                    return dialog.OpenFile();
            }

            return null;
        }

        #endregion


        #region Link

        /// <summary>
        /// Handles the DropDownOpened event of HypelinkSplitButton object.
        /// </summary>
        private void hypelinkSplitButton_DropDownOpened(object sender, EventArgs e)
        {
            editHyperlinkMenuItem.Enabled = VisualEditor.FocusedHyperlink != null;
            removeHyperlinkMenuItem.Enabled = !VisualEditor.SelectionContainsSingleCell || VisualEditor.FocusedHyperlink != null;
        }

        /// <summary>
        /// Handles the Click event of AddHyperlinkMenuItem object.
        /// </summary>
        private void addHyperlinkMenuItem_Click(object sender, EventArgs e)
        {
            EditHyperlinkForm.ShowDialog(VisualEditor, false);
        }

        /// <summary>
        /// Handles the Click event of EditHyperlinkToolStripMenuItem object.
        /// </summary>
        private void editHyperlinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHyperlinkForm.ShowDialog(VisualEditor, true);
        }

        /// <summary>
        /// Handles the Click event of RemoveHyperlinkMenuItem object.
        /// </summary>
        private void removeHyperlinkMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.RemoveHyperlinks();
        }

        #endregion

        #endregion


    }
}
