using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;

using Vintasoft.Imaging.Office;
using Vintasoft.Imaging.Office.OpenXml;
using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging.Office.Spreadsheet.UI.Controls;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Main form.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Constants

        /// <summary>
        /// The name of chart templates resource.
        /// </summary>
        const string ChartTemplatesResourceName = "ChartSource.xlsx";

        #endregion



        #region Fields

        /// <summary>
        /// The document converter.
        /// </summary>
        DocumentConverter _documentConverter;

        /// <summary>
        /// A value indicating whether the layout settings are initialized.
        /// </summary>
        bool _isLayoutSettingsInitialized;

        /// <summary>
        /// The layout settings manager.
        /// </summary>
        ImageCollectionXlsxLayoutSettingsManager _layoutSettingsManager;

        /// <summary>
        /// Panel with "Help" button.
        /// </summary>
        HelpPanel _helpPanel;

        /// <summary>
        /// Panel with "Find" and "Replace" buttons.
        /// </summary>
        FindReplacePanel _findReplacePanel;

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
            VisualEditor.FocusedCellsChanged += VisualEditor_FocusedCellsChanged;
            VisualEditor.ChartTemplatesRequest += VisualEditor_ChartTemplatesRequest;
            VisualEditor.DocumentSavingStarted += VisualEditor_DocumentSavingStarted;
            VisualEditor.Editor = null;
            SetStatus("");


            _documentConverter = new DocumentConverter();
            _layoutSettingsManager = new ImageCollectionXlsxLayoutSettingsManager(_documentConverter.Images);
            XlsxDocumentLayoutSettings layoutSettings = new XlsxDocumentLayoutSettings();
            layoutSettings.PageLayoutSettingsType = XlsxPageLayoutSettingsType.UseWorksheetWidth;
            _layoutSettingsManager.LayoutSettings = layoutSettings;


            // set file filter for file dialog
            CodecsFileFilters.SetSaveFileDialogFilter(exportFileDialog, false, false);
            exportFileDialog.Filter += SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TSV_FILESTSVCSV_FILESCSV;

            string[] filters = exportFileDialog.Filter.Split('|');
            // for each file filter
            for (int i = 1; i < filters.Length; i++)
            {
                // if filter represents PDF encoder
                if (filters[i].ToUpperInvariant().Contains("PDF"))
                    // specify that PDF format must be used as the default export format
                    exportFileDialog.FilterIndex = i / 2 + 1;
            }

            // set folder with test XLSX files as initial folder for the file dialog
            DemosTools.SetTestXlsxFolder(openWorksheetFileDialog);


            // add custom panels to the MainMenuPanel
            AddCustomPanels();

            // update UI
            UpdateUI();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the spreadsheet visual editor.
        /// </summary>
        public SpreadsheetVisualEditor VisualEditor
        {
            get
            {
                return DocumentEditorControl.VisualEditor;
            }
        }

        #endregion



        #region Methods

        #region UI

        /// <summary>
        /// Adds custom panels to the <see cref="MainMenuPanel"/>.
        /// </summary>
        private void AddCustomPanels()
        {
            // create "Find and replace" panel
            _findReplacePanel = new FindReplacePanel();
            _findReplacePanel.Margin = new Padding(1, 2, 2, 1);
            _findReplacePanel.Dock = DockStyle.Fill;
            // add "Find and replace" panel to the "Edit" tab of MainMenuPanel
            DocumentEditorControl.MainMenuPanel.AddTabItem(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EDIT, _findReplacePanel);

            // add "Help" tab to the MainMenuPanel
            DocumentEditorControl.MainMenuPanel.AddTab(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_HELP, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_HELP_ALT1);

            // create "Help" panel
            _helpPanel = new HelpPanel();
            _helpPanel.Margin = new Padding(1, 2, 2, 1);
            _helpPanel.Dock = DockStyle.Fill;
            // add "Help" panel to the "Help" tab of MainMenuPanel
            DocumentEditorControl.MainMenuPanel.AddTabItem(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_HELP_ALT2, _helpPanel);
        }

        /// <summary>
        /// The key is pressed in the form.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Ctrl+O
                if (e.Control && e.KeyCode == Keys.O)
                {
                    DocumentEditorControl.MainMenuPanel.OpenDocument();
                    e.Handled = true;
                }

                // Ctrl+N
                if (e.Control && e.KeyCode == Keys.N)
                {
                    DocumentEditorControl.MainMenuPanel.NewDocument();
                    e.Handled = true;
                }

                // Ctrl+S
                if (e.Control && e.KeyCode == Keys.S)
                {
                    DocumentEditorControl.MainMenuPanel.SaveDocumentChanges();
                    e.Handled = true;
                }

                // Ctrl+Shift+S
                if (e.Control && e.Shift && e.KeyCode == Keys.S)
                {
                    if (DocumentEditorControl.MainMenuPanel.SaveDocumentAs())
                        e.Handled = true;
                }

                // Ctrl+P
                if (e.Control && e.KeyCode == Keys.P)
                {
                    if (PrintDocument())
                        e.Handled = true;
                }

                // Ctrl+F
                if (e.Control && e.KeyCode == Keys.F)
                {
                    if (VisualEditor.FocusedWorksheet != null)
                        _findReplacePanel.ShowFindDialog();
                }

                // Ctrl+H
                if (e.Control && e.KeyCode == Keys.H)
                {
                    if (VisualEditor.FocusedWorksheet != null)
                        _findReplacePanel.ShowReplaceDialog();
                }

                // F1
                if (e.KeyCode == Keys.F1)
                {
                    _helpPanel.ShowAboutDialog();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
                e.Handled = true;
            }
        }

        /// <summary>
        /// The form is closing.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DocumentEditorControl.MainMenuPanel.CheckChanges())
                e.Cancel = true;
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        private void UpdateUI()
        {
            Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_VINTASOFT_SPREADSHEET_EDITOR_DEMO_V + ImagingGlobalSettings.ProductVersion;
            if (!string.IsNullOrEmpty(DocumentEditorControl.MainMenuPanel.Filename))
                Text += " - " + Path.GetFileName(DocumentEditorControl.MainMenuPanel.Filename);
        }

        #endregion


        #region Spreasheet visual editor events

        /// <summary>
        /// Handles the HoveredDrawingChanged event of VisualEditor object.
        /// </summary>
        private void VisualEditor_HoveredDrawingChanged(object sender, PropertyChangedEventArgs<SheetDrawing> e)
        {
            if (e.NewValue != null)
                SetStatus(e.NewValue.Name);
            else
                SetStatus("");
        }

        /// <summary>
        /// Handles the FocusedCellsChanged event of VisualEditor object.
        /// </summary>
        private void VisualEditor_FocusedCellsChanged(object sender, PropertyChangedEventArgs<CellReferences> e)
        {
            if (e.NewValue != null)
            {
                if (VisualEditor.IsFocusedCellsChanging)
                    SetStatus(e.NewValue.ToString());
                else if (Equals(e.NewValue, e.OldValue))
                    SetStatus("");
            }
            else
            {
                SetStatus("");
            }
        }

        /// <summary>
        /// Handles the HoveredCellChanged event of VisualEditor object.
        /// </summary>
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

        /// <summary>
        /// Handles the CellCommentClick event of VisualEditor object.
        /// </summary>
        private void VisualEditor_CellCommentClick(object sender, SheetCellMouseEventArgs e)
        {
            VisualEditor.SetCommentIsVisible(!VisualEditor.FocusedCellComment.IsVisible);
            e.Handled = true;
        }

        /// <summary>
        /// Handles the UriOpen event of VisualEditor object.
        /// </summary>
        private void VisualEditor_UriOpen(object sender, UriEventArgs e)
        {
            try
            {
                Uri uri = new Uri(e.Uri);
                DemosTools.OpenBrowser(uri.AbsoluteUri);
            }
            catch
            {
                DemosTools.ShowWarningMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_URI_IS_NOT_VALID + e.Uri);
            }
        }

        /// <summary>
        /// Handles the HoveredHyperlinkChanged event of VisualEditor object.
        /// </summary>
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
                    hyperlink = VisualEditor.GetHyperlinkByDefinedName(hyperlink.Name);
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

        /// <summary>
        /// Handles the CellErrorClick event of VisualEditor object.
        /// </summary>
        private void VisualEditor_CellErrorClick(object sender, SheetCellMouseEventArgs e)
        {
            Worksheet worksheet = VisualEditor.FocusedWorksheet;
            SheetCell cell = worksheet.FindCell(e.Cell);
            string errorMessage = GetErrorMessage(cell.ErrorType);
            DemosTools.ShowWarningMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ERROR_ALT2 + cell.Value, errorMessage);
            e.Handled = true;
        }

        /// <summary>
        /// Handles the InvalidCellReferences event of VisualEditor object.
        /// </summary>
        private void VisualEditor_InvalidCellReferences(object sender, CellReferencesEventArgs e)
        {
            MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REFERENCE_IS_NOT_VALID, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ERROR_ALT3, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Handles the FocusedCellChanged event of VisualEditor object.
        /// </summary>
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

        /// <summary>
        /// Handles the SynchronizationFinished event of VisualEditor object.
        /// </summary>
        private void VisualEditor_SynchronizationFinished(object sender, EventArgs e)
        {
            SetStatus("");
        }

        /// <summary>
        /// Handles the SynchronizationStarted event of VisualEditor object.
        /// </summary>
        private void VisualEditor_SynchronizationStarted(object sender, EventArgs e)
        {
            if (VisualEditor.IsInitialized)
                SetStatus(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PROCESSING);
            else
                SetStatus(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_LOADING);
        }

        /// <summary>
        /// Handles the SynchronizationException event of VisualEditor object.
        /// </summary>
        private void VisualEditor_SynchronizationException(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage(e.Exception);
            DocumentEditorControl.MainMenuPanel.CloseDocument(false);
        }

        /// <summary>
        /// Handles the ChartTemplatesRequest event of VisualEditor object.
        /// </summary>
        private void VisualEditor_ChartTemplatesRequest(object sender, StreamRequestEventArgs e)
        {
            e.Stream = DemosResourcesManager.GetResourceAsStream(ChartTemplatesResourceName);
        }

        /// <summary>
        /// Handles the DocumentSavingStarted event of VisualEditor object.
        /// </summary>
        private void VisualEditor_DocumentSavingStarted(object sender, EventArgs e)
        {
            SpreadsheetEditor editor = VisualEditor.Editor;
            DocumentInformation info = new DocumentInformation(editor.DocumentInformation);

            // set information about user, who last modified this document
            info.LastModifiedBy = Environment.UserName;

            // set the modified date
            info.ModifiedDate = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            // set the document information
            editor.DocumentInformation = info;
        }

        #endregion


        #region Panel events

        #region SpreadsheetVisualEditorPanel

        /// <summary>
        /// Handles the VisualEditorError event of SpreadsheetVisualEditorPanel object.
        /// </summary>
        private void SpreadsheetVisualEditorPanel_VisualEditorError(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage(e.Exception);
        }

        #endregion


        #region FilePanel  

        /// <summary>
        /// Handles the FilenameChanged event of FilePanel object.
        /// </summary>
        private void FilePanel_FilenameChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the OpenFileRequest event of FilePanel object.
        /// </summary>
        private void FilePanel_OpenFileRequest(object sender, FilenameEventArgs e)
        {
            e.Filename = null;
            e.AllowAction = false;

            // show dialog for opening the XLSX file
            if (openWorksheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file path from open dialog
                string filename = openWorksheetFileDialog.FileName;
                // if file is XLS file
                if (XlsxDecoder.IsXlsDocument(filename))
                {
                    if (MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_LOADED_FILE_IS_XLS_FILE_TO_OPEN_XLS_FILE_APPLICATION_NEEDS_TO_CONVERT_XLS_FILE_TO_THE_XLSX_FILE_DO_YOU_WANT_TO_CREATE_XLSX_FILE_FROM_XLS_FILE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CONVERT_XLS_TO_XLSX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    // create path to an XLSX file
                    filename = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename) + ".xlsx");
                    // set file to the save dialog
                    saveWorksheetFileDialog.FileName = filename;
                    // show the save dialog
                    if (saveWorksheetFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    // get file path from save dialog
                    filename = saveWorksheetFileDialog.FileName;
                    // convert XLS file to the XLSX file
                    OpenXmlDocumentConverter.ConvertXlsToXlsx(openWorksheetFileDialog.FileName, filename);
                }
                // if file is CSV file
                else if (XlsxDecoder.IsCsvFile(filename))
                {
                    if (MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_LOADED_FILE_IS_CSV_FILE_TO_OPEN_CSV_FILE_APPLICATION_NEEDS_TO_CONVERT_CSV_FILE_TO_THE_XLSX_FILE_DO_YOU_WANT_TO_CREATE_XLSX_FILE_FROM_CSV_FILE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CONVERT_CSV_TO_XLSX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    // create path to an XLSX file
                    filename = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename) + ".xlsx");
                    // set file to the save dialog
                    saveWorksheetFileDialog.FileName = filename;
                    // show the save dialog
                    if (saveWorksheetFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    // get file path from save dialog
                    filename = saveWorksheetFileDialog.FileName;
                    // convert XLS file to the XLSX file
                    OpenXmlDocumentConverter.ConvertCsvToXlsx(openWorksheetFileDialog.FileName, filename);
                }
                // if file is TSV file
                else if (XlsxDecoder.IsTsvFile(filename))
                {
                    if (MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_LOADED_FILE_IS_TSV_FILE_TO_OPEN_TSV_FILE_APPLICATION_NEEDS_TO_CONVERT_TSV_FILE_TO_THE_XLSX_FILE_DO_YOU_WANT_TO_CREATE_XLSX_FILE_FROM_TSV_FILE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CONVERT_TSV_TO_XLSX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    // create path to an XLSX file
                    filename = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename) + ".xlsx");
                    // set file to the save dialog
                    saveWorksheetFileDialog.FileName = filename;
                    // show the save dialog
                    if (saveWorksheetFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    // get file path from save dialog
                    filename = saveWorksheetFileDialog.FileName;
                    // convert XLS file to the XLSX file
                    OpenXmlDocumentConverter.ConvertTsvToXlsx(openWorksheetFileDialog.FileName, filename);
                }
                // if file is encrypted XLSX file
                else if (Path.GetExtension(filename).ToUpperInvariant() == ".XLSX" && OfficeDocumentCryptography.IsSecuredOfficeDocument(filename))
                {
                    if (MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_LOADED_FILE_IS_SECURED_XLSX_FILE_TO_OPEN_SECURED_FILE_APPLICATION_NEEDS_TO_DECRYPT_XLSX_FILE_DO_YOU_WANT_TO_CREATE_DECRYPTED_XLSX_FILE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DECRYPT_XLSX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    // set file to the save dialog
                    saveWorksheetFileDialog.FileName = filename;
                    // show the save dialog
                    if (saveWorksheetFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    while (true)
                    {
                        using (DocumentPasswordForm passwordForm = new DocumentPasswordForm())
                        {
                            passwordForm.Filename = filename;

                            // enter password
                            if (passwordForm.ShowDialog() != DialogResult.OK)
                                return;

                            // try decrypt XLSX document
                            if (OfficeDocumentCryptography.TryDecryptOfficeDocument(filename, passwordForm.Password, saveWorksheetFileDialog.FileName))
                            {
                                break;
                            }
                            else
                            {
                                passwordForm.ShowIncorrectPasswordMessage();
                            }
                        }
                    }

                    // get file path from save dialog
                    filename = saveWorksheetFileDialog.FileName;
                }
                e.Filename = filename;
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the ExportFile event of FilePanel object.
        /// </summary>
        private void FilePanel_ExportFile(object sender, EventArgs e)
        {
            exportFileDialog.FileName = Path.GetFileNameWithoutExtension(DocumentEditorControl.MainMenuPanel.Filename);
            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(exportFileDialog.FileName);

                    if (string.Equals(extension, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TSV, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(extension, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CSV, StringComparison.OrdinalIgnoreCase))
                    {
                        if (MessageBox.Show(
                            SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_SELECTED_FILE_TYPE_DOES_NOT_SUPPORT_WORKBOOKS_THAT_CONTAIN_MULTIPLE_SHEETSRNTO_SAVE_ONLY_THE_ACTIVE_SHEET_CLICK_OKRNTO_SAVE_ALL_SHEETS_SAVE_THEM_INDIVIDUALLY_USING_A_DIFFERENT_FILE_NAME_FOR_EACH_OR_CHOOSE_A_FILE_TYPE_THAT_SUPPORTS_MULTIPLE_SHEETS,
                            SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EXPORT_DOCUMENT, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            // create a temporary stream
                            using (MemoryStream tempStream = new MemoryStream())
                            {
                                // save XLSX file to a temporary stream
                                VisualEditor.SaveDocumentTo(tempStream);

                                tempStream.Position = 0;

                                using (Stream stream = File.Create(exportFileDialog.FileName))
                                {
                                    DocumentEnvironmentProperties environmentProperties = DocumentEnvironmentProperties.Default;
                                    environmentProperties.Culture = CultureInfo.CurrentCulture;
                                    environmentProperties.UICulture = CultureInfo.CurrentUICulture;

                                    if (string.Equals(extension, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_TSV_ALT1, StringComparison.OrdinalIgnoreCase))
                                        OpenXmlDocumentConverter.ConvertXlsxToTsv(environmentProperties, tempStream, VisualEditor.FocusedWorksheetIndex, stream);
                                    else
                                        OpenXmlDocumentConverter.ConvertXlsxToCsv(environmentProperties, tempStream, VisualEditor.FocusedWorksheetIndex, stream, System.Text.Encoding.UTF8);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!InitLayoutSettings())
                            return;

                        // create a temporary stream
                        using (MemoryStream tempStream = new MemoryStream())
                        {
                            // save XLSX file to a temporary stream
                            VisualEditor.SaveDocumentTo(tempStream);

                            // add XLSX file to the image collection of document converter
                            _documentConverter.Images.Add(tempStream);

                            // create dialog that displays progress for document conversion process
                            using (ActionProgressForm dlg = new ActionProgressForm(ExportDocument, 1, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EXPORT_DOCUMENT_ALT1))
                            {
                                // specify that dialog should be closed when conversion is finished
                                dlg.CloseAfterComplete = true;
                                // show dialog and run conversion process
                                dlg.RunAndShowDialog(this.FindForm());
                            }

                            // clear image collection of document converter
                            _documentConverter.Images.ClearAndDisposeItems();
                        }
                    }
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the PrintDocument event of FilePanel object.
        /// </summary>
        private void FilePanel_PrintDocument(object sender, EventArgs e)
        {
            PrintDocument();
        }

        /// <summary>
        /// Handles the ShowPrintLayoutSettings event of FilePanel object.
        /// </summary>
        private void FilePanel_ShowPrintLayoutSettings(object sender, EventArgs e)
        {
            if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                _isLayoutSettingsInitialized = true;
        }

        /// <summary>
        /// Handles the ShowPrintPageSettings event of FilePanel object.
        /// </summary>
        private void FilePanel_ShowPrintPageSettings(object sender, EventArgs e)
        {
            // show dialog with page setup settings
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// Handles the ShowPrintPreview event of FilePanel object.
        /// </summary>
        private void FilePanel_ShowPrintPreview(object sender, EventArgs e)
        {
            try
            {
                if (!InitLayoutSettings())
                    return;

                // create a temporary stream
                using (MemoryStream tempStream = new MemoryStream())
                {
                    // save XLSX file to a temporary stream
                    VisualEditor.SaveDocumentTo(tempStream);

                    // create a dialog that allows to preview and print XLSX document
                    using (PrintPreviewForm dlg = new PrintPreviewForm(tempStream, imagePrintDocument1, printDialog1, pageSetupDialog1))
                    {
                        // show the dialog
                        dlg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the SaveChangesRequest event of FilePanel object.
        /// </summary>
        private void FilePanel_SaveChangesRequest(object sender, ActionRequestEventArgs e)
        {
            DialogResult result = MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURRENT_WORKBOOK_IS_CHANGED_DO_YOU_WANT_TO_SAVE_CHANGES, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_NEW_WORKBOOK, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            switch (result)
            {
                case DialogResult.Yes:
                    e.AllowAction = true;
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        /// <summary>
        /// Handles the SaveAsRequest event of FilePanel object.
        /// </summary>
        private void FilePanel_SaveAsRequest(object sender, FilenameEventArgs e)
        {
            saveWorksheetFileDialog.FileName = DocumentEditorControl.MainMenuPanel.Filename;
            if (saveWorksheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                e.Filename = saveWorksheetFileDialog.FileName;
                e.AllowAction = true;
            }
            else
            {
                e.Filename = null;
                e.AllowAction = false;
            }
        }

        /// <summary>
        /// Handles the ShowDocumentInfo event of FilePanel object.
        /// </summary>
        private void FilePanel_ShowDocumentInfo(object sender, EventArgs e)
        {
            DocumentInfoForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the ShowVisualEditorOptions event of FilePanel object.
        /// </summary>
        private void FilePanel_ShowVisualEditorOptions(object sender, EventArgs e)
        {
            OptionsForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Prints the XLSX document.
        /// </summary>
        private bool PrintDocument()
        {
            if (VisualEditor.Document == null)
                return false;
            try
            {
                if (!InitLayoutSettings())
                    return true;

                // create a temporary stream
                using (MemoryStream tempStream = new MemoryStream())
                {
                    // save XLSX file to a temporary stream
                    VisualEditor.SaveDocumentTo(tempStream);

                    // create print manager
                    using (PrintManager printManager = new PrintManager(tempStream, imagePrintDocument1, printDialog1))
                    {
                        // print XLSX document
                        printManager.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            return true;
        }

        /// <summary>
        /// Exports the XLSX document.
        /// </summary>
        /// <param name="progressController">Progress controller.</param>
        private void ExportDocument(Vintasoft.Imaging.Utils.IActionProgressController progressController)
        {
            // set progress controller for document converter
            _documentConverter.ProgressController = progressController;

            // convert XLSX to the selected format            
            _documentConverter.Convert(exportFileDialog.FileName);
        }

        /// <summary>
        /// Initializes the layout settings of XLSX document.
        /// </summary>
        private bool InitLayoutSettings()
        {
            // if layout settings are not initialized
            if (!_isLayoutSettingsInitialized)
            {
                // set layout settings
                if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                    _isLayoutSettingsInitialized = true;
                else
                    return false;
            }

            return true;
        }

        #endregion


        #region CellsEditorPanel

        /// <summary>
        /// Handles the SetRowHeight event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_SetRowHeight(object sender, EventArgs e)
        {
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, VisualEditor.RowsHeight, 0, CellsEditorPanel.MAX_ROW_HEIGHT, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ROW_HEIGHT_ALT1))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set height of focused rows
                    VisualEditor.RowsHeight = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the SetDefaultRowHeight event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_SetDefaultRowHeight(object sender, EventArgs e)
        {
            WorksheetFormat sheetFormat = VisualEditor.FocusedWorksheet.Format;
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, sheetFormat.RowHeight, 0, CellsEditorPanel.MAX_ROW_HEIGHT, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DEFAULT_ROW_HEIGHT))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set visual format with new default row height
                    VisualEditor.SetWorksheetFormat(new WorksheetFormat(sheetFormat.ColumnWidth, dlg.Value, sheetFormat.AutoHeight, sheetFormat.RowsHiddenByDefault));
                }
            }
        }

        /// <summary>
        /// Handles the SetColumnWidth event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_SetColumnWidth(object sender, EventArgs e)
        {
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, VisualEditor.ColumnsWidth, 0, CellsEditorPanel.MAX_COLUMN_WIDTH, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN_WIDTH_ALT1))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set width of focused columns
                    VisualEditor.ColumnsWidth = dlg.Value;
                }
            }
        }

        /// <summary>
        /// Handles the SetDefaultColumnWidth event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_SetDefaultColumnWidth(object sender, EventArgs e)
        {
            WorksheetFormat sheetFormat = VisualEditor.FocusedWorksheet.Format;
            // show value editor dialog
            using (NumberValueEditorForm dlg = new NumberValueEditorForm(VisualEditor, sheetFormat.ColumnWidth, 0, CellsEditorPanel.MAX_COLUMN_WIDTH, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DEFAULT_COLUMN_WIDTH))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // set visual format with new default column width
                    VisualEditor.SetWorksheetFormat(new WorksheetFormat(dlg.Value, sheetFormat.RowHeight, sheetFormat.AutoHeight, sheetFormat.RowsHiddenByDefault));
                }
            }
        }

        /// <summary>
        /// Handles the AddChart event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_AddChart(object sender, EventArgs e)
        {
            try
            {
                InsertChartForm chartForm = new InsertChartForm();
                chartForm.SetChartDataSource(VisualEditor, ChartTemplatesResourceName);
                chartForm.ShowDialog();
            }
            catch (Exception ex)
            {
                DemosTools.ShowWarningMessage(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_INSERT_CHART, ex.Message);
            }
        }

        /// <summary>
        /// Handles the EditDrawing event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_EditDrawing(object sender, EventArgs e)
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
        /// Handles the ImageStreamRequest event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_ImageStreamRequest(object sender, StreamRequestEventArgs e)
        {
            // create dialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // specify that dialog should open folder with demo images
                DemosTools.SetTestFilesFolder(dialog);
                // set image filters
                DemosCommonCode.Imaging.Codecs.CodecsFileFilters.SetOpenFileDialogFilter(dialog);

                // if image must be loaded
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    e.Stream = dialog.OpenFile();
                    return;
                }
            }

            e.Stream = null;
        }

        /// <summary>
        /// Handles the AddHyperlink event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_AddHyperlink(object sender, EventArgs e)
        {
            EditHyperlinkForm.ShowDialog(VisualEditor, false);
        }

        /// <summary>
        /// Handles the EditHyperlink event of CellsEditorPanel object.
        /// </summary>
        private void CellsEditorPanel_EditHyperlink(object sender, EventArgs e)
        {
            EditHyperlinkForm.ShowDialog(VisualEditor, true);
        }

        #endregion


        #region CommentsPanel

        /// <summary>
        /// Handles the NewComment event of CommentsPanel object.
        /// </summary>
        private void CommentsPanel_NewComment(object sender, EventArgs e)
        {
            // get the focused cell
            CellReference focusedCell = VisualEditor.FocusedCell;

            // create dialog that allows to edit a comment
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
        /// Handles the EditComment event of CommentsPanel object.
        /// </summary>
        private void CommentsPanel_EditComment(object sender, EventArgs e)
        {
            CellComment sourceCellComment = VisualEditor.FocusedComment ?? VisualEditor.FocusedCellComment;
            Comment sourceComment = sourceCellComment.Comment;
            SheetDrawingLocation sourceLocation = sourceCellComment.Location;

            // create dialog that allows to edit a comment
            using (EditCommentForm dlg = new EditCommentForm(VisualEditor, sourceComment, sourceLocation))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    VisualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EDIT_COMMENT_ALT2);
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


        #region CopyPastePanel

        /// <summary>
        /// Handles the ShowCellPasteSpecial event of CopyPastePanel object.
        /// </summary>
        private void CopyPastePanel_ShowCellPasteSpecial(object sender, ActionRequestEventArgs e)
        {
            using (CellPasteSpecialForm dlg = new CellPasteSpecialForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    e.AllowAction = true;
                }
            }
        }

        #endregion  


        #region DefinedNamesPanel

        /// <summary>
        /// Handles the InsertDefinedNameInFormula event of DefinedNamesPanel object.
        /// </summary>
        private void DefinedNamesPanel_InsertDefinedNameInFormula(object sender, EventArgs e)
        {
            // get a list of defined names, which are defined on focused worksheet
            DefinedName[] definedNames = VisualEditor.GetFocusedWorksheetDefinedNames();

            // create dialog that allows to select defined name
            using (SelectDefinedNameForm dlg = new SelectDefinedNameForm(definedNames))
            {
                // show the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // get selected defined name
                    string selectedDefinedName = dlg.SelectedDefinedName;

                    // insert formula in focused cell
                    VisualEditor.InsertFormulaInFocusedCell(selectedDefinedName);
                }
            }
        }

        /// <summary>
        /// Handles the AddDefinedName event of DefinedNamesPanel object.
        /// </summary>
        private void DefinedNamesPanel_AddDefinedName(object sender, EventArgs e)
        {
            // get value for defined name
            string value = VisualEditor.GetFixedSelectedCells().ToString(VisualEditor.Document.Defaults.FormattingProperties);

            // create dialog that allows to add new defined name
            using (EditDefinedNameForm dlg = new EditDefinedNameForm(VisualEditor, value))
            {
                // show the dialog
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the ShowDefinedNamesManager event of DefinedNamesPanel object.
        /// </summary>
        private void DefinedNamesPanel_ShowDefinedNamesManager(object sender, EventArgs e)
        {
            using (DefinedNameManagerForm dlg = new DefinedNameManagerForm(VisualEditor))
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region FontPropertiesPanel

        /// <summary>
        /// Handles the ColorRequest event of FontPropertiesPanel object.
        /// </summary>
        private void FontPropertiesPanel_ColorRequest(object sender, ColorEventArgs e)
        {
            colorDialog1.Color = e.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                e.Color = colorDialog1.Color;
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the FontProperties event of FontPropertiesPanel object.
        /// </summary>
        private void FontPropertiesPanel_FontProperties(object sender, EventArgs e)
        {
            CellsStyleForm.ShowFontDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the Borders event of FontPropertiesPanel object.
        /// </summary>
        private void FontPropertiesPanel_Borders(object sender, EventArgs e)
        {
            CellsStyleForm.ShowBordersDialog(VisualEditor);
        }

        #endregion   


        #region FormulaPanel     

        /// <summary>
        /// Handles the EditCellFormulaError event of FormulaPanel object.
        /// </summary>
        private void FormulaPanel_EditCellFormulaError(object sender, ExceptionActionEventArgs e)
        {
            Exception exception = e.Exception;

            if (MessageBox.Show(exception.Message, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_FORMULA_SYNTAX_ERROR, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                e.AllowAction = true;
        }

        /// <summary>
        /// Handles the InsertFunction event of FormulaPanel object.
        /// </summary>
        private void FormulaPanel_InsertFunction(object sender, XlsxFunctionNameEventArgs e)
        {
            e.FunctionName = SelectFunctionForm.SelectFunction(VisualEditor.Document);
            e.AllowAction = true;
        }

        #endregion    


        #region FunctionPanel    

        /// <summary>
        /// Handles the InsertFunction event of FunctionsPanel object.
        /// </summary>
        private void FunctionsPanel_InsertFunction(object sender, XlsxFunctionNameEventArgs e)
        {
            e.FunctionName = SelectFunctionForm.SelectFunction(VisualEditor.Document);
            e.AllowAction = true;
        }

        #endregion    


        #region NavigationPanel    

        /// <summary>
        /// Handles the RemoveWorksheet event of NavigationPanel object.
        /// </summary>
        private void NavigationPanel_RemoveWorksheet(object sender, ActionRequestEventArgs e)
        {
            if (MessageBox.Show(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REMOVE_WORKSHEET_ARG0, VisualEditor.FocusedWorksheet.Name),
                SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_REMOVE_WORKSHEET, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the MoveWorksheet event of NavigationPanel object.
        /// </summary>
        private void NavigationPanel_MoveWorksheet(object sender, ActionRequestEventArgs e)
        {
            // show "Move worksheet" dialog
            using (MoveWorksheetForm dlg = new MoveWorksheetForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.IsWorksheetOrderChanged)
                    {
                        e.AllowAction = true;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the RenameWorksheet event of NavigationPanel object.
        /// </summary>
        private void NavigationPanel_RenameWorksheet(object sender, ActionRequestEventArgs e)
        {
            // show "Rename worksheet" dialog
            using (RenameWorksheetForm dlg = new RenameWorksheetForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.IsWorksheetNameChanged)
                    {
                        e.AllowAction = true;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the ColorRequest event of NavigationPanel object.
        /// </summary>
        private void NavigationPanel_ColorRequest(object sender, ColorEventArgs e)
        {
            // create "Color" dialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Color.FromArgb(VisualEditor.GridColor.ToArgb());
            colorDialog.FullOpen = true;

            // show the dialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                e.Color = colorDialog.Color;
                e.AllowAction = true;
            }
        }

        /// <summary>
        /// Handles the WorksheetFormat event of NavigationPanel object.
        /// </summary>
        private void NavigationPanel_WorksheetFormat(object sender, EventArgs e)
        {
            // show "Worksheet Format" dialog
            WorksheetFormatForm.ShowDialog(VisualEditor);
        }

        #endregion   


        #region NumberFormatPanel    

        /// <summary>
        /// Handles the NumberFormatProperties event of NumberFormatPanel object.
        /// </summary>
        private void NumberFormatPanel_NumberFormatProperties(object sender, EventArgs e)
        {
            CellsStyleForm.ShowNumberFormatDialog(VisualEditor);
        }

        #endregion  


        #region TextAlignmentPanel    

        /// <summary>
        /// Handles the AlignmentProperties event of TextAlignmentPanel object.
        /// </summary>
        private void TextAlignmentPanel_AlignmentProperties(object sender, EventArgs e)
        {
            CellsStyleForm.ShowAlignmentDialog(VisualEditor);
        }

        #endregion

        #endregion



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

        #endregion



        #region Delegates

        /// <summary>
        /// SetStatus delegate.
        /// </summary>
        /// <param name="status">The status.</param>
        delegate void SetStatusDelegate(string status);

        #endregion

    }
}
