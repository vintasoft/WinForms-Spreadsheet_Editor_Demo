using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Office.OpenXml;
using Vintasoft.Imaging.Office.Spreadsheet;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;


namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides the "File" panel.
    /// </summary>
    public partial class FilePanel : SpreadsheetVisualEditorPanel
    {

        #region Fields

        /// <summary>
        /// A value indicating whether document is new.
        /// </summary>
        bool _isNewDocument = true;

        /// <summary>
        /// The document converter.
        /// </summary>
        DocumentConverter _converter;

        /// <summary>
        /// The layout settings manager.
        /// </summary>
        ImageCollectionXlsxLayoutSettingsManager _layoutSettingsManager;

        /// <summary>
        /// A value indicating whether the layout settings are initialized.
        /// </summary>
        bool _isLayoutSettingsInitialized;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaPanel"/> class.
        /// </summary>
        public FilePanel()
        {
            InitializeComponent();

            _converter = new DocumentConverter();
            _layoutSettingsManager = new ImageCollectionXlsxLayoutSettingsManager(_converter.Images);
            XlsxDocumentLayoutSettings layoutSettings = new XlsxDocumentLayoutSettings();
            layoutSettings.PageLayoutSettingsType = XlsxPageLayoutSettingsType.UseWorksheetWidth;
            _layoutSettingsManager.LayoutSettings = layoutSettings;

            CodecsFileFilters.SetSaveFileDialogFilter(exportFileDialog, false, false);

            // set default filter index to PDF
            string[] filters = exportFileDialog.Filter.Split('|');
            for (int i = 1; i < filters.Length; i++)
            {
                if (filters[i].ToUpperInvariant().Contains("PDF"))
                    exportFileDialog.FilterIndex = i / 2 + 1;
            }

            DemosTools.SetTestXlsxFolder(openWorksheetFileDialog);

            DemosTools.AutoFitToolstripButtons(this.toolStrip1);
        }

        #endregion



        #region Properties

        string _filename;
        /// <summary>
        /// Gets the filename.
        /// </summary>
        public string Filename
        {
            get
            {
                return _filename;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this panel is disabled without editor.
        /// </summary>
        protected override bool IsDisabledWithoutEditor
        {
            get
            {
                return false;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Creates new document.
        /// </summary>
        public bool NewDocument()
        {
            if (CheckChanges())
            {
                SetFilename("NewWorksheet1.xlsx");
                VisualEditor.NewDocument();
                _isNewDocument = true;
            }
            return true;
        }

        /// <summary>
        /// Opens the spreadsheet document.
        /// </summary>
        public bool OpenDocument()
        {
            if (CheckChanges())
            {
                // close previously opened XLSX document
                VisualEditor.CloseDocument();

                // show dialog for opening the XLSX file
                if (openWorksheetFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get file path from open dialog
                    string filename = openWorksheetFileDialog.FileName;
                    try
                    {
                        // if file is XLS file
                        if (XlsxDecoder.IsXlsDocument(filename))
                        {
                            if (MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_LOADED_FILE_IS_XLS_FILE_TO_OPEN_XLS_FILE_APPLICATION_NEEDS_TO_CONVERT_XLS_FILE_TO_THE_XLSX_FILE_DO_YOU_WANT_TO_CREATE_XLSX_FILE_FROM_XLS_FILE, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CONVERT_XLS_TO_XLSX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return true;

                            // create path to an XLSX file
                            filename = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename) + ".xlsx");
                            // set file to the save dialog
                            saveWorksheetFileDialog.FileName = filename;
                            // show the save dialog
                            if (saveWorksheetFileDialog.ShowDialog() != DialogResult.OK)
                                return true;
                            // get file path from save dialog
                            filename = saveWorksheetFileDialog.FileName;
                            // convert XLS file to the XLSX file
                            OpenXmlDocumentConverter.ConvertXlsToXlsx(openWorksheetFileDialog.FileName, filename);
                        }

                        // save information about path to XLSX file
                        SetFilename(filename);
                        // open XLSX file
                        VisualEditor.OpenDocument(filename);
                        _isNewDocument = false;
                    }
                    catch (Exception ex)
                    {
                        DemosTools.ShowErrorMessage(ex);
                        SetFilename(null);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Saves the document changes.
        /// </summary>
        public bool SaveDocumentChanges()
        {
            if (VisualEditor.IsDocumentSourceChanged)
            {
                try
                {
                    VisualEditor.SaveDocumentChanges();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Closes the document.
        /// </summary>
        public bool CloseDocument(bool checkChanges)
        {
            if (VisualEditor.Document != null)
            {
                if (!checkChanges || CheckChanges())
                {
                    VisualEditor.CloseDocument();
                    SetFilename(null);
                    UpdateUI();
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Saves the document as new file.
        /// </summary>
        public bool SaveDocumentAs()
        {
            if (VisualEditor.Document != null)
            {
                try
                {
                    SaveAs();
                    UpdateUI();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prints the document.
        /// </summary>
        public bool PrintDocument()
        {
            if (VisualEditor.Document == null)
                return false;
            try
            {
                // if layout settings are not initialized
                if (!_isLayoutSettingsInitialized)
                {
                    // set layout settings
                    if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                        _isLayoutSettingsInitialized = true;
                    else
                        return true;
                }

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
                // show error message
                DemosTools.ShowErrorMessage(ex);
            }
            return true;
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

            if (args.OldValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.OldValue.VisualEditor;
                visualEditor.DocumentSourceChanged -= VisualEditor_DocumentSourceChanged;
                visualEditor.EditorChanged -= VisualEditor_EditorChanged;
                visualEditor.DocumentSavingStarted -= VisualEditor_DocumentSavingStarted;
                visualEditor.DocumentSavingFinished -= VisualEditor_DocumentSavingFinished;
            }

            if (args.NewValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.NewValue.VisualEditor;
                visualEditor.DocumentSourceChanged += VisualEditor_DocumentSourceChanged;
                visualEditor.EditorChanged += VisualEditor_EditorChanged;
                visualEditor.DocumentSavingStarted += VisualEditor_DocumentSavingStarted;
                visualEditor.DocumentSavingFinished += VisualEditor_DocumentSavingFinished;
            }

            UpdateUI();
        }

    


        /// <summary>
        /// Raises the <see cref="FilenameChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnFilenameChanged(EventArgs args)
        {
            if (FilenameChanged != null)
                FilenameChanged(this, args);
        }

        #endregion


        #region PRIVATE

        #region UI

        /// <summary>
        /// "New" button is clicked.
        /// </summary>
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewDocument();
        }
       
        /// <summary>
        /// "Open" button is clicked.
        /// </summary>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        /// <summary>
        /// "Info" button is clicked.
        /// </summary>
        private void infoToolStripButton_Click(object sender, EventArgs e)
        {
            DocumentInfoForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// "Save" button is clicked.
        /// </summary>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDocumentChanges();
        }

        /// <summary>
        /// "Save As" button is clicked.
        /// </summary>
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }
        

        #region Export

        /// <summary>
        /// "Export" button is clicked.
        /// </summary>
        private void exportToolStripButton_Click(object sender, EventArgs e)
        {
            exportFileDialog.FileName = Path.GetFileNameWithoutExtension(Filename);
            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!_isLayoutSettingsInitialized)
                {
                    // set layout settings
                    if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                        _isLayoutSettingsInitialized = true;
                    else
                        return;
                }

                try
                {
                    // create a temporary stream
                    using (MemoryStream tempStream = new MemoryStream())
                    {
                        // save XLSX file to a temporary stream
                        VisualEditor.SaveDocumentTo(tempStream);

                        // add XLSX file to the image collection of document converter
                        _converter.Images.Add(tempStream);

                        // create dialog that displays progress for document conversion process
                        using (ActionProgressForm dlg = new ActionProgressForm(ExportDocument, 1, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_EXPORT_DOCUMENT))
                        {
                            // specify that dialog should be closed when conversion is finished
                            dlg.CloseAfterComplete = true;
                            // show dialog and run conversion process
                            dlg.RunAndShowDialog(this.FindForm());
                        }

                        // clear image collection of document converter
                        _converter.Images.ClearAndDisposeItems();
                    }
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Exports the XLSX document.
        /// </summary>
        /// <param name="progressController">Progress controller.</param>
        private void ExportDocument(Vintasoft.Imaging.Utils.IActionProgressController progressController)
        {
            // set progress controller for document converter
            _converter.ProgressController = progressController;

            // convert XLSX to the selected format            
            _converter.Convert(exportFileDialog.FileName);
        }

        #endregion


        #region Print

        /// <summary>
        /// "Print" button is clicked.
        /// </summary>
        private void printToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            PrintDocument();            
        }


        /// <summary>
        /// "Layout settings" menu is selected.
        /// </summary>
        private void layoutSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                _isLayoutSettingsInitialized = true;
        }

        /// <summary>
        /// "Page settings" menu is selected.
        /// </summary>
        private void pageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show dialog with page setup setings
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// "Print preview" menu is selected.
        /// </summary>
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // if layout settings are not initialized
                if (!_isLayoutSettingsInitialized)
                {
                    // set layout settings
                    if (_layoutSettingsManager.EditLayoutSettingsUseDialog())
                        _isLayoutSettingsInitialized = true;
                    else
                        return;
                }

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
                // show error message
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        /// <summary>
        /// "Close" button is clicked.
        /// </summary>
        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            CloseDocument(true);
        }

        #endregion


        /// <summary>
        /// Checks changes in document and saves document if necessary.
        /// </summary>
        public bool CheckChanges()
        {
            if (VisualEditor.Document == null)
                return true;

            VisualEditor.FinishEditCellValue();

            if (VisualEditor.Editor.IsVirtual)
                return true;

            if (VisualEditor.IsDocumentSourceChanged)
            {
                DialogResult result = MessageBox.Show(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURRENT_WORKBOOK_IS_CHANGED_DO_YOU_WANT_TO_SAVE_CHANGES, SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_NEW_WORKBOOK, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Cancel)
                    return false;
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (_isNewDocument)
                        {
                            if (!SaveAs())
                                return false;
                        }
                        else
                        {
                            VisualEditor.SaveDocumentChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        DemosTools.ShowErrorMessage(ex);
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// "Options" button is clicked.
        /// </summary>
        private void optionsToolStripButton_Click(object sender, EventArgs e)
        {
            OptionsForm.ShowDialog(VisualEditor);
        }

        /// <summary>
        /// Handles the EditorChanged event of the <see cref="SpreadsheetVisualEditorPanel.VisualEditor"/>.
        /// </summary>
        private void VisualEditor_EditorChanged(object sender, PropertyChangedEventArgs<Vintasoft.Imaging.Office.Spreadsheet.SpreadsheetEditor> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the DocumentSourceChanged event of the <see cref="SpreadsheetVisualEditorPanel.VisualEditor"/>.
        /// </summary>
        private void VisualEditor_DocumentSourceChanged(object sender, EventArgs e)
        {
            saveToolStripButton.Enabled = !_isNewDocument;
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.Document == null)
            {
                infoToolStripButton.Enabled = false;
                saveToolStripButton.Enabled = false;
                saveAsToolStripButton.Enabled = false;
                exportToolStripButton.Enabled = false;
                printToolStripSplitButton.Enabled = false;
                closeToolStripButton.Enabled = false;
                SpreadsheetEditor.Visible = false;
            }
            else
            {
                SpreadsheetEditor.Visible = true;
                infoToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = VisualEditor.IsDocumentSourceChanged;
                saveAsToolStripButton.Enabled = true;
                exportToolStripButton.Enabled = true;
                printToolStripSplitButton.Enabled = true;
                closeToolStripButton.Enabled = true;
            }
        }

        /// <summary>
        /// Saves document as.
        /// </summary>
        private bool SaveAs()
        {
            saveWorksheetFileDialog.FileName = Filename;
            if (saveWorksheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                VisualEditor.SaveDocumentAs(saveWorksheetFileDialog.FileName);
                SetFilename(saveWorksheetFileDialog.FileName);
                _isNewDocument = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets the filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        private void SetFilename(string filename)
        {
            if (_filename != filename)
            {
                _filename = filename;
                OnFilenameChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Handles the DocumentSavingStarted event of the VisualEditor.
        /// </summary>
        private void VisualEditor_DocumentSavingStarted(object sender, EventArgs e)
        {
            SpreadsheetEditor editor = VisualEditor.Editor;
            DocumentInformation info = new DocumentInformation(editor.DocumentInformation);

            // set the user name that last modified this document
            info.LastModifiedBy = Environment.UserName;

            // set the modified date
            info.ModifiedDate = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            // set DocumentInformation
            editor.DocumentInformation = info;
        }


        /// <summary>
        /// Handles the DocumentSavingFinished event of the VisualEditor.
        /// </summary>
        private void VisualEditor_DocumentSavingFinished(object sender, EventArgs e)
        {
            saveToolStripButton.Enabled = false;
        }

       
        #endregion

        #endregion



        #region Events

        /// <summary>
        /// Occurs when <see cref="Filename"/> is changed.
        /// </summary>
        public event EventHandler FilenameChanged;

        #endregion

    }
}
