using System;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.Document.Editors;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to edit the drawing properties.
    /// </summary>
    public partial class DrawingPropertiesForm : Form
    {

        #region Fields

        /// <summary>
        /// The visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        /// <summary>
        /// The drawing.
        /// </summary>
        SheetDrawing _drawing;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawingPropertiesForm"/> class.
        /// </summary>
        public DrawingPropertiesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawingPropertiesForm"/> class.
        /// </summary>
        /// <param name="visualEditor">The visual editor.</param>
        /// <param name="drawing">The drawing.</param>
        public DrawingPropertiesForm(SpreadsheetVisualEditor visualEditor, SheetDrawing drawing)
            : this()
        {
            _visualEditor = visualEditor;
            _drawing = drawing;

            // drawing name
            nameTextBox.Text = drawing.Name;
            // drawing description
            descriptionTextBox.Text = drawing.Description;
            // drawing rotation
            rotationAngleNumericUpDown.Value = (decimal)drawing.Rotation;
            rotationAngleNumericUpDown.Enabled = drawing.Type != DrawingType.Chart;

            // drawing location
            sheetDrawingLocationEditorControl.Worksheet = visualEditor.FocusedWorksheet;
            sheetDrawingLocationEditorControl.SheetDrawingLocation = drawing.Location;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="System.Windows.Forms.Form.Shown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="System.EventArgs" /> that contains the event data.</param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            descriptionTextBox.Focus();
        }


        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckDrawingName();

                // create worksheet editor
                WorksheetEditor worksheetEditor = _visualEditor.Editor.StartEditing(_visualEditor.FocusedWorksheet);
                try
                {
                    // create drawing editor
                    SheetDrawingEditor drawingEditor = worksheetEditor.CreateDrawingEditor(_drawing);

                    // set drawing name
                    drawingEditor.SetName(nameTextBox.Text.Trim());

                    // set drawing description
                    drawingEditor.SetDescription(descriptionTextBox.Text);

                    // set drawing description
                    if (rotationAngleNumericUpDown.Enabled)
                        drawingEditor.SetRotation((double)rotationAngleNumericUpDown.Value);

                    // if drawing location is changed
                    if (!Equals(_drawing.Location, sheetDrawingLocationEditorControl.SheetDrawingLocation))
                        // set the drawing location
                        drawingEditor.SetLocation(sheetDrawingLocationEditorControl.SheetDrawingLocation);
                }
                finally
                {
                    _visualEditor.Editor.FinishEditing();
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Checks the drawing name.
        /// </summary>
        private void CheckDrawingName()
        {
            // get the drawing name
            string name = nameTextBox.Text;

            if (name != null)
                name = name.Trim();

            // if drawing name is empty
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("The drawing name cannot be empty.");

            foreach (SheetDrawing drawing in _visualEditor.FocusedWorksheet.Drawings)
            {
                if (drawing == _drawing)
                    continue;

                // if drawing name exists already
                if (string.Equals(drawing.Name, name, StringComparison.InvariantCultureIgnoreCase))
                    throw new InvalidOperationException(string.Format("The drawing with '{0}' exists already.", name));
            }
        }

        #endregion

    }
}
