using System;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Represents a base UI panel for SpreadsheetVisualEditor.
    /// </summary>
    public partial class SpreadsheetVisualEditorPanel : UserControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetVisualEditorPanel"/> class.
        /// </summary>
        public SpreadsheetVisualEditorPanel()
        {
            InitializeComponent();
            Enabled = false;
        }

        #endregion



        #region Properties

        SpreadsheetEditorControl _spreadsheetEditor;
        /// <summary>
        /// Gets or sets the spreadsheet editor control.
        /// </summary>
        public SpreadsheetEditorControl SpreadsheetEditor
        {
            get
            {
                return _spreadsheetEditor;
            }
            set
            {
                if (_spreadsheetEditor != value)
                {
                    PropertyChangedEventArgs<SpreadsheetEditorControl> args = new PropertyChangedEventArgs<SpreadsheetEditorControl>(_spreadsheetEditor, value);

                    if (_spreadsheetEditor != null)
                    {
                        _spreadsheetEditor.VisualEditor.EditorChanged -= VisualEditor_EditorChanged;
                        _spreadsheetEditor.VisualEditor.InitializationStarted -= VisualEditor_InitializationStarted;
                        _spreadsheetEditor.VisualEditor.InitializationFinished -= VisualEditor_InitializationFinished;
                    }

                    _spreadsheetEditor = value;

                    if (_spreadsheetEditor != null)
                    {
                        _spreadsheetEditor.VisualEditor.EditorChanged += VisualEditor_EditorChanged;
                        _spreadsheetEditor.VisualEditor.InitializationStarted += VisualEditor_InitializationStarted;
                        _spreadsheetEditor.VisualEditor.InitializationFinished += VisualEditor_InitializationFinished;
                    }

                    OnSpreadsheetEditorChanged(args);
                    UpdateCoreUI();
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether this panel is disabled without editor.
        /// </summary>
        protected virtual bool IsDisabledWithoutEditor
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets the spreadsheet visual editor.
        /// </summary>
        [Browsable(false)]
        public SpreadsheetVisualEditor VisualEditor
        {
            get
            {
                if (_spreadsheetEditor != null)
                    return _spreadsheetEditor.VisualEditor;
                return null;
            }
        }

        /// <summary>
        /// Gets the document current culture.
        /// </summary>
        [Browsable(false)]
        public CultureInfo Culture
        {
            get
            {
                if (VisualEditor != null)
                {
                    try
                    {
                        return CultureInfo.GetCultureInfo(VisualEditor.DocumentCulture);
                    }
                    catch
                    {
                    }
                }
                return CultureInfo.CurrentCulture;
            }
        }

        /// <summary>
        /// Gets the document UI current culture.
        /// </summary>
        [Browsable(false)]
        public CultureInfo UICulture
        {
            get
            {
                if (VisualEditor != null)
                {
                    try
                    {
                        return CultureInfo.GetCultureInfo(VisualEditor.DocumentUICulture);
                    }
                    catch
                    {
                    }
                }
                return CultureInfo.CurrentUICulture;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Occurs when <see cref="SpreadsheetEditor"/> is changed.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected virtual void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        protected virtual void UpdateCoreUI()
        {
            if (SpreadsheetEditor == null || VisualEditor.IsInitializing)
            {
                Enabled = false;
            }
            else
            {
                if (IsDisabledWithoutEditor)
                    Enabled = VisualEditor.Editor != null;
                else
                    Enabled = true;
            }
        }


        /// <summary>
        /// Handles the EditorChanged event of the VisualEditor.
        /// </summary>
        private void VisualEditor_EditorChanged(object sender, PropertyChangedEventArgs<Vintasoft.Imaging.Office.Spreadsheet.SpreadsheetEditor> e)
        {
            UpdateCoreUI();
        }

        /// <summary>
        /// Handles the InitializationFinished event of the VisualEditor.
        /// </summary>
        private void VisualEditor_InitializationFinished(object sender, EventArgs e)
        {
            UpdateCoreUI();
        }

        /// <summary>
        /// Handles the InitializationStarted event of the VisualEditor.
        /// </summary>
        private void VisualEditor_InitializationStarted(object sender, EventArgs e)
        {
            UpdateCoreUI();
        }

        #endregion

    }
}
