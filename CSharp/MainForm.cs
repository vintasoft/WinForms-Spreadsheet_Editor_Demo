using System;
using System.IO;
using System.Windows.Forms;

using DemosCommonCode;
using DemosCommonCode.Imaging;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Main form.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Classes

        /// <summary>
        /// SetStatus delegate.
        /// </summary>
        /// <param name="status">The status.</param>
        delegate void SetStatusDelegate(string status);

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            // set CustomFontProgramsController for all opened documents
            CustomFontProgramsController.SetDefaultFontProgramsController();

            InitializeComponent();
            
            VisualEditor.SynchronizationStarted += VisualEditor_SynchronizationStarted;
            VisualEditor.SynchronizationFinished += VisualEditor_SynchronizationFinished;
            VisualEditor.SynchronizationException += VisualEditor_SynchronizationException;
            VisualEditor.HoveredHyperlinkChanged += VisualEditor_HoveredHyperlinkChanged;
            VisualEditor.HoveredDrawingChanged += VisualEditor_HoveredDrawingChanged;
            VisualEditor.HoveredCellChanged += VisualEditor_HoveredCellChanged;
            VisualEditor.UriOpen += VisualEditor_UriOpen;
            VisualEditor.CellErrorClick += VisualEditor_CellErrorClick;
            VisualEditor.CellCommentClick += VisualEditor_CellCommentClick;
            VisualEditor.InvalidCellReferences += VisualEditor_InvalidCellReferences;
            VisualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
            VisualEditor.Editor = null;
            SetStatus("");

            UpdateUI();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the visual editor.
        /// </summary>
        public SpreadsheetVisualEditor VisualEditor
        {
            get
            {
                return spreadsheetEditorControl1.VisualEditor;
            }
        }


        #endregion



        #region Methods

        #region Common

        /// <summary>
        /// Handles the FormClosing event of MainForm object.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!filePanel1.CheckChanges())
                e.Cancel = true;
        }

        private void VisualEditor_HoveredDrawingChanged(object sender, PropertyChangedEventArgs<SheetDrawing> e)
        {
            if (e.NewValue != null)
                SetStatus(e.NewValue.Name);
            else
                SetStatus("");
        }


        private void VisualEditor_HoveredCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            if (e.NewValue != null)
            {
                CellComment cellComment = VisualEditor.FocusedWorksheet.GetCellComment(e.NewValue);
                if (cellComment != null)
                {
                    string text = cellComment.Comment.Text;
                    text = text.Replace(Environment.NewLine, " ");
                    text = text.Replace("\n", " ");
                    SetStatus(cellComment.Comment.Author + ": " + text);
                }
                else if (e.OldValue != null)
                {
                    cellComment = VisualEditor.FocusedWorksheet.GetCellComment(e.OldValue);
                    if (cellComment != null)
                        SetStatus("");
                }
            }
        }

        private void VisualEditor_CellCommentClick(object sender, SheetCellMouseEventArgs e)
        {
            VisualEditor.SetCommentIsVisible(!VisualEditor.FocusedCellComment.IsVisible);
            e.Handled = true;
        }

        private void VisualEditor_UriOpen(object sender, UriEventArgs e)
        {
            try
            {
                Uri uri = new Uri(e.Uri);
                DemosTools.OpenBrowser(uri.AbsoluteUri);
            }
            catch 
            {
                DemosTools.ShowWarningMessage("The address of this site is not valid: " + e.Uri);
            }
        }

        private void VisualEditor_HoveredHyperlinkChanged(object sender, PropertyChangedEventArgs<Hyperlink> e)
        {
            Hyperlink hyperlink = e.NewValue;
            if (hyperlink == null)
            {
                SetStatus("");
            }
            else
            {
                string hyperlinkDecription;
                if (hyperlink.Name != null)
                    hyperlink = spreadsheetEditorControl1.VisualEditor.GetHyperlinkByDefinedName(hyperlink.Name);
                if (!string.IsNullOrEmpty(hyperlink.Url))
                    hyperlinkDecription = hyperlink.Url;
                else if (hyperlink.Location != null)
                    hyperlinkDecription = hyperlink.Location.ToString();
                else
                    hyperlinkDecription = hyperlink.Name;
                hyperlinkDecription = "Link: " + hyperlinkDecription;
                if (VisualEditor.HoveredDrawing != null)
                    SetStatus(VisualEditor.HoveredDrawing.Name + ": " + hyperlinkDecription);
                else
                    SetStatus(hyperlinkDecription);
            }
        }

        private void VisualEditor_CellErrorClick(object sender, SheetCellMouseEventArgs e)
        {
            Worksheet worksheet = spreadsheetEditorControl1.VisualEditor.FocusedWorksheet;
            SheetCell cell = worksheet.FindCell(e.Cell);
            string errorMessage = GetErrorMessage(cell.ErrorType);
            DemosTools.ShowWarningMessage("Error: " + cell.Value, errorMessage);
            e.Handled = true;
        }

        private void VisualEditor_InvalidCellReferences(object sender, CellReferencesEventArgs e)
        {
            MessageBox.Show("Reference is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            if (e.NewValue != null)
            {
                SheetCell cell = VisualEditor.FocusedWorksheet.FindCell(e.NewValue);
                if (cell != null && cell.ErrorType != CellErrorType.NoError)
                {
                    SetStatus(string.Format("Cell {0} with formula '={1}' calculation error: {2}", e.NewValue, cell.Formula, GetErrorMessage(cell.ErrorType)));
                    return;
                }
            }
            if (e.OldValue != null)
            {
                SheetCell cell = VisualEditor.FocusedWorksheet.FindCell(e.OldValue);
                if (cell != null && cell.ErrorType != CellErrorType.NoError)
                {
                    SetStatus("");
                }
            }
        }

        private void VisualEditor_SynchronizationFinished(object sender, EventArgs e)
        {
            SetStatus("");
        }

        private void VisualEditor_SynchronizationStarted(object sender, EventArgs e)
        {
            if (VisualEditor.IsInitialized)
                SetStatus("Processing...");
            else
                SetStatus("Loading...");
        }

        private void VisualEditor_SynchronizationException(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage(e.Exception);
            filePanel1.CloseDocument(false);
        }

        private void SetStatus(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new SetStatusDelegate(SetStatus), status);
            }
            else
            {
                if (string.IsNullOrEmpty(status))
                    statusLabel.Text = "Ready";
                else
                    statusLabel.Text = status;
            }
        }

        private void filePanel1_FilenameChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        private void UpdateUI()
        {
            Text = "VintaSoft Spreadsheet Editor Demo v" + ImagingGlobalSettings.ProductVersion;
            if (!string.IsNullOrEmpty(filePanel1.Filename))
                Text += " - " + Path.GetFileName(filePanel1.Filename);
        }


        /// <summary>
        /// Returns the error message.
        /// </summary>
        /// <param name="errorType">Type of the error.</param>
        private string GetErrorMessage(CellErrorType errorType)
        {
            switch (errorType)
            {
                case CellErrorType.Unknown:
                    return "Unknown error.";
                case CellErrorType.DivByZero:
                    return "Any number (including zero) or any error code is divided by zero.";
                case CellErrorType.External:
                    return "External error.";
                case CellErrorType.GettingData:
                    return "A cell reference cannot be evaluated because the value for the cell has not been retrieved or calculated.";
                case CellErrorType.Name:
                    return "Looks like a name is used but no such name has been defined.";
                case CellErrorType.NoError:
                    return "No error.";
                case CellErrorType.NotANumber:
                    return "A designated value is not available.";
                case CellErrorType.Null:
                    return "Two areas are required to intersect but do not.";
                case CellErrorType.Num:
                    return "An argument to a function has a compatible type but has a value that is outside the domain over which that function is defined.";
                case CellErrorType.Ref:
                    return "A cell reference cannot be evaluated.";
                case CellErrorType.Value:
                    return "An incompatible type argument is passed to a function, or an incompatible type operand is used with an operator.";
            }
            return "Unexpected error.";
        }

        /// <summary>
        /// Handles the KeyDown event of MainForm object.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Ctrl+O
                if (e.Control && e.KeyCode == Keys.O)
                {
                    if (filePanel1.OpenDocument())
                        e.Handled = true;
                }

                // Ctrl+N
                if (e.Control && e.KeyCode == Keys.N)
                {
                    if (filePanel1.NewDocument())
                        e.Handled = true;
                }

                // Ctrl+S
                if (e.Control && e.KeyCode == Keys.S)
                {
                    if (filePanel1.SaveDocumentChanges())
                        e.Handled = true;
                }

                // Ctrl+Shift+S
                if (e.Control && e.Shift && e.KeyCode == Keys.S)
                {
                    if (filePanel1.SaveDocumentAs())
                        e.Handled = true;
                }

                // Ctrl+P
                if (e.Control && e.KeyCode == Keys.P)
                {
                    if (filePanel1.PrintDocument())
                        e.Handled = true;
                }             
               
                // Ctrl+F
                if (e.Control && e.KeyCode == Keys.F)
                {
                    if (VisualEditor.FocusedWorksheet != null)
                        findReplacePanel1.ShowFindDialog();
                }

                // Ctrl+H
                if (e.Control && e.KeyCode == Keys.H)
                {
                    if (VisualEditor.FocusedWorksheet != null)
                        findReplacePanel1.ShowReplaceDialog();
                }

                // F1
                if (e.KeyCode == Keys.F1)
                {
                    helpPanel1.ShowAboutDialog();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
                e.Handled = true;
            }
        }

        #endregion

        #endregion

    }
}
