using DemosCommonCode;
using System.Windows.Forms;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides the "Help" panel.
    /// </summary>
    public partial class HelpPanel : UserControl
    {


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpPanel"/> class.
        /// </summary>
        public HelpPanel()
        {
            InitializeComponent();

            DemosTools.AutoFitToolstripButtons(this.toolStrip1);
        }


        #endregion



        #region Methods

        /// <summary>
        /// Shows the about dialog.
        /// </summary>
        public void ShowAboutDialog()
        {
            using (AboutBoxForm aboutDialog = new AboutBoxForm())
            {
                aboutDialog.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of AboutButton object.
        /// </summary>
        private void aboutButton_Click(object sender, System.EventArgs e)
        {
            ShowAboutDialog();
        }

        #endregion

    }
}
