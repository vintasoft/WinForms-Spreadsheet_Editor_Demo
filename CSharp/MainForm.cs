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
                DemosTools.ShowWarningMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_ADDRESS_OF_THIS_SITE_IS_NOT_VALID + e.Uri);
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
                hyperlinkDecription = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_LINK + hyperlinkDecription;
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
            DemosTools.ShowWarningMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ERROR_ALT2 + cell.Value, errorMessage);
            e.Handled = true;
        }

        private void VisualEditor_InvalidCellReferences(object sender, CellReferencesEventArgs e)
        {
            MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REFERENCE_IS_NOT_VALID, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ERROR_ALT3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            if (e.NewValue != null)
            {
                SheetCell cell = VisualEditor.FocusedWorksheet.FindCell(e.NewValue);
                if (cell != null && cell.ErrorType != CellErrorType.NoError)
                {
                    SetStatus(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CELL_ARG0_WITH_FORMULA_ARG1_CALCULATION_ERROR_ARG2, e.NewValue, cell.Formula, GetErrorMessage(cell.ErrorType)));
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
                SetStatus(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PROCESSING);
            else
                SetStatus(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_LOADING);
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
                    statusLabel.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_READY;
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
            Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_VINTASOFT_SPREADSHEET_EDITOR_DEMO_V + ImagingGlobalSettings.ProductVersion;
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
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_UNKNOWN_ERROR;
                case CellErrorType.DivByZero:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ANY_NUMBER_INCLUDING_ZERO_OR_ANY_ERROR_CODE_IS_DIVIDED_BY_ZERO;
                case CellErrorType.External:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EXTERNAL_ERROR;
                case CellErrorType.GettingData:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_A_CELL_REFERENCE_CANNOT_BE_EVALUATED_BECAUSE_THE_VALUE_FOR_THE_CELL_HAS_NOT_BEEN_RETRIEVED_OR_CALCULATED;
                case CellErrorType.Name:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_LOOKS_LIKE_A_NAME_IS_USED_BUT_NO_SUCH_NAME_HAS_BEEN_DEFINED;
                case CellErrorType.NoError:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_NO_ERROR;
                case CellErrorType.NotANumber:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_A_DESIGNATED_VALUE_IS_NOT_AVAILABLE;
                case CellErrorType.Null:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TWO_AREAS_ARE_REQUIRED_TO_INTERSECT_BUT_DO_NOT;
                case CellErrorType.Num:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_AN_ARGUMENT_TO_A_FUNCTION_HAS_A_COMPATIBLE_TYPE_BUT_HAS_A_VALUE_THAT_IS_OUTSIDE_THE_DOMAIN_OVER_WHICH_THAT_FUNCTION_IS_DEFINED;
                case CellErrorType.Ref:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_A_CELL_REFERENCE_CANNOT_BE_EVALUATED;
                case CellErrorType.Value:
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_AN_INCOMPATIBLE_TYPE_ARGUMENT_IS_PASSED_TO_A_FUNCTION_OR_AN_INCOMPATIBLE_TYPE_OPERAND_IS_USED_WITH_AN_OPERATOR;
            }
            return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_UNEXPECTED_ERROR;
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
