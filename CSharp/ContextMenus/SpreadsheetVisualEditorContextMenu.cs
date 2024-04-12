using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a base class for context menu for spreadsheet visual editor.
    /// </summary>
    public partial class SpreadsheetVisualEditorContextMenu : ContextMenuStrip
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetVisualEditorContextMenu"/> class.
        /// </summary>
        public SpreadsheetVisualEditorContextMenu()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        SpreadsheetEditorControl _spreadsheetEditor;
        /// <summary>
        /// Gets or sets the spreadsheet editor control.
        /// </summary>
        [Description("The spreadsheet editor control.")]
        public SpreadsheetEditorControl SpreadsheetEditor
        {
            get
            {
                return _spreadsheetEditor;
            }
            set
            {
                if (_spreadsheetEditor != null)
                {
                    _spreadsheetEditor.VisualEditor.ContextMenuOpen -= VisualEditor_ContextMenuOpen;
                }

                _spreadsheetEditor = value;

                if (_spreadsheetEditor != null)
                {
                    _spreadsheetEditor.VisualEditor.ContextMenuOpen += VisualEditor_ContextMenuOpen;
                }
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns a value indicating whether this context menu must be shown.
        /// </summary>
        protected virtual bool NeedShowContextMenu()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the context menu.
        /// </summary>
        /// <param name="spreadsheetEditor">Spreadsheet editor control.</param>
        /// <param name="menuLocation">The menu location.</param>
        protected virtual void ShowContextMenu(SpreadsheetEditorControl spreadsheetEditor, Point menuLocation)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Handles the ContextMenuOpen event of VisualEditor object.
        /// </summary>
        private void VisualEditor_ContextMenuOpen(object sender, Vintasoft.Imaging.UI.VintasoftControlMouseEventArgs e)
        {
            // if context menu should be shown
            if (NeedShowContextMenu() && !e.Handled)
            {
                // show context menu
                ShowContextMenu(SpreadsheetEditor, new Point((int)e.Location.X, (int)e.Location.Y));
                e.Handled = true;
            }
        }

        #endregion

    }
}
