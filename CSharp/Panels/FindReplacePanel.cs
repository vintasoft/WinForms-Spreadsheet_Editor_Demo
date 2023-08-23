using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.UI;


namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Find and Replace" panel.
    /// </summary>
    public partial class FindReplacePanel : SpreadsheetVisualEditorPanel
    {

        #region Fields

        /// <summary>
        /// The form that allows to find and replace text.
        /// </summary>
        FindReplaceForm _findReplaceForm;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindReplacePanel"/> class.
        /// </summary>
        public FindReplacePanel()
        {
            InitializeComponent();
        }


        #endregion



        #region Methods

        /// <summary>
        /// Shows the find dialog.
        /// </summary>
        public void ShowFindDialog()
        {
            ShowFindReplaceForm(false);
        }

        /// <summary>
        /// Shows the replace dialog.
        /// </summary>
        public void ShowReplaceDialog()
        {
            ShowFindReplaceForm(true);
        }


        /// <summary>
        /// Raises the <see cref="SpreadsheetEditorChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (_findReplaceForm != null)
            {
                if (args.NewValue != null)
                    _findReplaceForm.VisualEditor = args.NewValue.VisualEditor;
                else
                    _findReplaceForm.VisualEditor = null;
            }
        }


        /// <summary>
        /// Handles the Click event of FindButton object.
        /// </summary>
        private void findButton_Click(object sender, EventArgs e)
        {
            ShowFindDialog();
        }

        /// <summary>
        /// Handles the Click event of ReplaceButton object.
        /// </summary>
        private void replaceButton_Click(object sender, EventArgs e)
        {
            ShowReplaceDialog();
        }

        /// <summary>
        /// Shows the find and replace form.
        /// </summary>
        /// <param name="replaceMode">Replace mode.</param>
        private void ShowFindReplaceForm(bool replaceMode)
        {
            bool needSetLocation = false;
            if (_findReplaceForm == null)
            {
                _findReplaceForm = new FindReplaceForm();
                _findReplaceForm.VisualEditor = VisualEditor;
                needSetLocation = true;
            }
            _findReplaceForm.ReplaceMode = replaceMode;
            if (_findReplaceForm.Visible)
            {
                _findReplaceForm.Focus();
            }
            else
            {
                _findReplaceForm.Show();
                if (needSetLocation)
                {
                    Form mainForm = ParentForm;
                    _findReplaceForm.Location = new System.Drawing.Point(
                        mainForm.Location.X + mainForm.Width - _findReplaceForm.Width,
                        mainForm.Location.Y + mainForm.Height - _findReplaceForm.Height - 150);
                }
            }
            _findReplaceForm.Reset();
        }

        #endregion

    }
}
