using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging.Codecs;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a context menu for spreadsheet drawings in spreadsheet visual editor.
    /// </summary>
    public partial class SpreadsheetDrawingContextMenu : SpreadsheetVisualEditorContextMenu
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetDrawingContextMenu"/> class.
        /// </summary>
        public SpreadsheetDrawingContextMenu()
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
            return SpreadsheetEditor.VisualEditor.FocusedDrawing != null;
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
        /// Handles the Opening event of drawingContextMenuStrip object.
        /// </summary>
        private void drawingContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            drawingRemoveLinkToolStripMenuItem.Enabled = SpreadsheetEditor.VisualEditor.FocusedDrawing.Hyperlink != null;
            drawingSetImageToolStripMenuItem.Enabled = SpreadsheetEditor.VisualEditor.FocusedDrawing.Type == DrawingType.Picture;
        }

        /// <summary>
        /// Handles the Click event of drawingSetImageToolStripMenuItem object.
        /// </summary>
        private void drawingSetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create dialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // set demo images folder
                DemosTools.SetTestFilesFolder(dialog);
                // set image filters
                CodecsFileFilters.SetOpenFileDialogFilter(dialog);

                // if image must be changed
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = dialog.OpenFile())
                        SpreadsheetEditor.VisualEditor.SetDrawingPicture(new ImageData(stream));
                }
            }
        }

        /// <summary>
        /// Handles the Click event of deleteDrawingToolStripMenuItem object.
        /// </summary>
        private void deleteDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveFocusedDrawing();
        }

        /// <summary>
        /// Handles the Click event of drawingLinkToolStripMenuItem object.
        /// </summary>
        private void drawingLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHyperlinkForm.ShowDialog(SpreadsheetEditor.VisualEditor, SpreadsheetEditor.VisualEditor.FocusedDrawing.Hyperlink != null);
        }

        /// <summary>
        /// Handles the Click event of drawingRemoveLinkToolStripMenuItem object.
        /// </summary>
        private void drawingRemoveLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpreadsheetEditor.VisualEditor.RemoveHyperlinks();
        }

        /// <summary>
        /// Handles the Click event of drawingPropertiesToolStripMenuItem object.
        /// </summary>
        private void drawingPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DrawingPropertiesForm form = new DrawingPropertiesForm(SpreadsheetEditor.VisualEditor, SpreadsheetEditor.VisualEditor.FocusedDrawing))
            {
                form.ShowDialog();
            }
        }

        #endregion
    }
}
