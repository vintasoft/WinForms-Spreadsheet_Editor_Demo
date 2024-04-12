using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a context menu for spreadsheet comments in spreadsheet visual editor.
    /// </summary>
    public partial class SpreadsheetCommentContextMenu : SpreadsheetVisualEditorContextMenu
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetCommentContextMenu"/> class.
        /// </summary>
        public SpreadsheetCommentContextMenu()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns a value indicating whether this context menu must be shown.
        /// </summary>
        protected override bool NeedShowContextMenu()
        {
            return SpreadsheetEditor.VisualEditor.FocusedComment != null;
        }

        /// <summary>
        /// Shows the context menu.
        /// </summary>
        /// <param name="spreadsheetEditor">Spreadsheet editor control.</param>
        /// <param name="menuLocation">The menu location.</param>
        protected override void ShowContextMenu(SpreadsheetEditorControl spreadsheetEditor, Point menuLocation)
        {
            Show(spreadsheetEditor, menuLocation);
        }

        /// <summary>
        /// Handles the Click event of editCommentToolStripMenuItem object.
        /// </summary>
        private void editCommentToolStripMenuItem_Click(object sender, EventArgs e)
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
                    visualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EDIT_COMMENT_ALT1);
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
        /// Handles the Click event of deleteCommentToolStripMenuItem object.
        /// </summary>
        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveFocusedComment();
        }

        /// <summary>
        /// Handles the Click event of hideCommentToolStripMenuItem object.
        /// </summary>
        private void hideCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.SetCommentIsVisible(false);
            SpreadsheetEditor.VisualEditor.FocusedComment = null;
        }

        #endregion

    }
}
