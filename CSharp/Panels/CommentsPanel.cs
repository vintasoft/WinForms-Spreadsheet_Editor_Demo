using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging.Office.Spreadsheet.Document;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides the "Comments" panel.
    /// </summary>
    public partial class CommentsPanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsPanel"/> class.
        /// </summary>
        public CommentsPanel()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Creates a new comment for focused cell.
        /// </summary>
        public void NewComment()
        {
            // get the focused cell
            CellReference focusedCell = VisualEditor.FocusedCell;

            // create dialog that allows to edit the comment
            using (EditCommentForm dlg = new EditCommentForm(VisualEditor))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CellComment newCellComment = new CellComment(focusedCell, dlg.Comment, true, dlg.CommentLocation);

                    VisualEditor.SetCellComment(newCellComment);

                    VisualEditor.FocusedComment = VisualEditor.FocusedCellComment;
                }
            }
        }

        /// <summary>
        /// Edits the focused comment.
        /// </summary>
        internal void EditComment()
        {
            CellComment sourceCellComment = VisualEditor.FocusedComment ?? VisualEditor.FocusedCellComment;
            Comment sourceComment = sourceCellComment.Comment;
            SheetDrawingLocation sourceLocation = sourceCellComment.Location;

            // create dialog that allows to edit the comment
            using (EditCommentForm dlg = new EditCommentForm(VisualEditor, sourceComment, sourceLocation))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    VisualEditor.StartEditing("Edit comment");
                    try
                    {
                        VisualEditor.SetComment(dlg.Comment);
                        VisualEditor.SetCommentLocation(dlg.CommentLocation);
                    }
                    finally
                    {
                        VisualEditor.FinishEditing();
                    }
                }
            }
        }

        #endregion


        #region PROTECTED

        /// <summary>
        /// Raises the <see cref="E:SpreadsheetEditorChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            SpreadsheetVisualEditor visualEditor;

            if (args.OldValue != null)
            {
                visualEditor = args.OldValue.VisualEditor;
                visualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
                visualEditor.FocusedCellChanged -= VisualEditor_FocusedCellChanged;
                visualEditor.FocusedCommentChanged -= VisualEditor_FocusedCommentChanged;
                args.OldValue.MouseDoubleClick -= SpreadsheetEditorControl_MouseDoubleClick;
            }

            if (args.NewValue != null)
            {
                visualEditor = args.NewValue.VisualEditor;
                visualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
                visualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
                visualEditor.FocusedCommentChanged += VisualEditor_FocusedCommentChanged;
                args.NewValue.MouseDoubleClick += SpreadsheetEditorControl_MouseDoubleClick;
            }

            UpdateUI();
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handles the Click event of NewButton object.
        /// </summary>
        private void newButton_Click(object sender, EventArgs e)
        {
            NewComment();
        }

        /// <summary>
        /// Handles the Click event of EditButton object.
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            EditComment();
        }

        /// <summary>
        /// Handles the Click event of DeleteButton object.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            VisualEditor.RemoveComments();
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of PrevButton object.
        /// </summary>
        private void prevButton_Click(object sender, EventArgs e)
        {
            int currentIndex = 0;
            // get focused comment
            CellComment focusedComment = VisualEditor.FocusedComment;
            if (focusedComment == null)
            {
                // get focused cell comment
                focusedComment = VisualEditor.FocusedCellComment;
            }

            if (focusedComment != null)
            {
                // get index of comment
                currentIndex = VisualEditor.FocusedWorksheet.CellComments.IndexOf(focusedComment);
            }

            // get previous comment index
            if (currentIndex == 0)
                currentIndex = VisualEditor.FocusedWorksheet.CellComments.Count - 1;
            else
                currentIndex--;

            // focus previous comment
            VisualEditor.FocusedComment = VisualEditor.FocusedWorksheet.CellComments[currentIndex];
        }

        /// <summary>
        /// Handles the Click event of NextButton object.
        /// </summary>
        private void nextButton_Click(object sender, EventArgs e)
        {
            int currentIndex = 0;
            // get focused comment
            CellComment focusedComment = VisualEditor.FocusedComment;
            if (focusedComment == null)
            {
                // get focused cell comment
                focusedComment = VisualEditor.FocusedCellComment;
            }

            if (focusedComment != null)
            {
                // get index of comment
                currentIndex = VisualEditor.FocusedWorksheet.CellComments.IndexOf(focusedComment);
            }

            // get next comment index
            if (currentIndex == VisualEditor.FocusedWorksheet.CellComments.Count - 1)
                currentIndex = 0;
            else
                currentIndex++;

            // focus next comment
            VisualEditor.FocusedComment = VisualEditor.FocusedWorksheet.CellComments[currentIndex];
        }

        /// <summary>
        /// Handles the Click event of ShowHideButton object.
        /// </summary>
        private void showHideButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.FocusedCellComment != null)
            {
                VisualEditor.SetCommentIsVisible(!VisualEditor.FocusedCellComment.IsVisible);
                UpdateUI();
            }
        }

        /// <summary>
        /// Handles the Click event of ShowAllButton object.
        /// </summary>
        private void showAllButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.SelectionContainsSingleCell)
                VisualEditor.ShowAllComments();
            else
                VisualEditor.ShowComments();
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of HideAllButton object.
        /// </summary>
        private void hideAllButton_Click(object sender, EventArgs e)
        {
            VisualEditor.FocusedComment = null;
            if (VisualEditor.SelectionContainsSingleCell)
                VisualEditor.HideAllComments();
            else
                VisualEditor.HideComments();
            UpdateUI();
        }

        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateUI();
        }
        private void VisualEditor_FocusedCommentChanged(object sender, PropertyChangedEventArgs<CellComment> e)
        {
            UpdateUI();
        }

        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of SpreadsheetEditorControl object.
        /// </summary>
        private void SpreadsheetEditorControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && VisualEditor.FocusedComment != null)
                EditComment();
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
                bool hasFocusedComment = VisualEditor.FocusedComment != null;
                bool focusedCellHasComment = VisualEditor.FocusedCellComment != null;
                bool hasFocusedCell = VisualEditor.FocusedCell != null;
                bool sheetHasComments = VisualEditor.FocusedWorksheet.CellComments.Count > 0;
                newButton.Enabled = hasFocusedCell && !focusedCellHasComment;
                editButton.Enabled = hasFocusedComment || hasFocusedCell && focusedCellHasComment;
                deleteButton.Enabled = VisualEditor.SelectedCellsHasComments;
                prevButton.Enabled = sheetHasComments;
                nextButton.Enabled = sheetHasComments;
                showHideButton.Enabled = focusedCellHasComment || hasFocusedComment;
                showAllButton.Enabled = sheetHasComments;
                hideAllButton.Enabled = sheetHasComments;
            }
        }

        #endregion

        #endregion

    }
}
