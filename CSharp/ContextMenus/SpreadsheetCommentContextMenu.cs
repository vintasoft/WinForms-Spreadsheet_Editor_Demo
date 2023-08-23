using System;
using System.ComponentModel;
using System.Drawing;

using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a context menu for comments.
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
        /// Handles the Click event of EditCommentToolStripMenuItem object.
        /// </summary>
        private void editCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommentsPanel.EditComment();
        }

        /// <summary>
        /// Handles the Click event of DeleteCommentToolStripMenuItem object.
        /// </summary>
        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveFocusedComment();
        }

        /// <summary>
        /// Handles the Click event of HideCommentToolStripMenuItem object.
        /// </summary>
        private void hideCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.SetCommentIsVisible(false);
            SpreadsheetEditor.VisualEditor.FocusedComment = null;
        }

        #endregion
    }
}
