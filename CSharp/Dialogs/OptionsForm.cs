using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A form that allows to view and change settings of the spreadsheet visual editor.
    /// </summary>
    public partial class OptionsForm : Form
    {

        #region Fields

        /// <summary>
        /// Spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsForm"/> class.
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current visual editor settings.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (OptionsForm form = new OptionsForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the visual editor settings to this form UI.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        private void SetVisualEditor(SpreadsheetVisualEditor visualEditor)
        {
            _visualEditor = visualEditor;
            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            // culture
            cultureComboBox.Text = _visualEditor.DocumentCulture;
            uiCultureComboBox.Text = _visualEditor.DocumentUICulture;

            calculationMinIntervalNumericUpDown.Value = _visualEditor.EditorSettings.CalculationMinInterval;

            // appearances
            focusedCellsAppearanceEditor.CellsAppearance = _visualEditor.FocusedCellsAppearance;
            bufferCellsAppearanceEditor.CellsAppearance = _visualEditor.CellsClipboardAppearance;
            formulaCellsAppearanceEditor.CellsAppearance = _visualEditor.FormulaAppearance;
            focusedFormulaCellsAppearanceEditor.CellsAppearance = _visualEditor.FormulaFocusedAppearance;

            // chart appearances
            seriesNameAppearanceEditor.CellsAppearance = _visualEditor.ChartSeriesNameAppearance;
            seriesValuesAppearanceEditor.CellsAppearance = _visualEditor.ChartSeriesValuesAppearance;
            categoryAxisAppearanceEditor.CellsAppearance = _visualEditor.ChartCategoryAxisAppearance;

            // headings
            headingsColorPanelControl.Color = Color.FromArgb(_visualEditor.HeadingsColor.ToArgb());
            headingsTextColorPanelControl.Color = Color.FromArgb(_visualEditor.HeadingsTextColor.ToArgb());
            headingsBorderColorPanelControl.Color = Color.FromArgb(_visualEditor.HeadingsBorderColor.ToArgb());
            selectedCellColorPanelControl.Color = Color.FromArgb(_visualEditor.SelectedCellColor.ToArgb());
            selectedHeaderColorPanelControl.Color = Color.FromArgb(_visualEditor.SelectedHeaderColor.ToArgb());
            coveredHeaderColorPanelControl.Color = Color.FromArgb(_visualEditor.CoveredHeaderColor.ToArgb());

            // errors
            errorIndicatorColorPanelControl.Color = Color.FromArgb(_visualEditor.ErrorIndicatorColor.ToArgb());
            errorIndicatorSizeNumericUpDown.Value = (int)Math.Round(_visualEditor.ErrorIndicatorSize, 0);

            // comments
            commentIndicatorColorPanelControl.Color = Color.FromArgb(_visualEditor.CommentIndicatorColor.ToArgb());
            commentIndicatorSizeNumericUpDown.Value = (int)Math.Round(_visualEditor.CommentIndicatorSize, 0);
            commentAppearanceEditor.CellsAppearance = _visualEditor.CommentAppearance;
            focusedCommentAppearanceEditor.CellsAppearance = _visualEditor.CommentFocusedAppearance;

            // transform highlight
            showInteractiveAreaHighlightCheckBox.Checked = _visualEditor.ShowInteractiveAreaHighlight;
            headersTransformHighlightAppearanceEditor.CellsAppearance = _visualEditor.HeadersTransformHighlightAppearance;
            sheetDrawingTransformHighlightAppearanceEditor.CellsAppearance = _visualEditor.SheetDrawingTransformHighlightAppearance;
            cellsTransformHighlightAppearanceEditor.CellsAppearance = _visualEditor.CellsTransformHighlightAppearance;

            // miscellaneous
            hyperlinkColorPanelControl.Color = Color.FromArgb(_visualEditor.HyperlinkColor.ToArgb());
            gridColorAlphaNumericUpDown.Value = (int)Math.Round(255 - _visualEditor.GridColorAlpha * 255, 0);
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // culture
            if (_visualEditor.DocumentCulture != cultureComboBox.Text ||
                _visualEditor.DocumentUICulture != uiCultureComboBox.Text)
            {
                _visualEditor.SetDocumentCulture(cultureComboBox.Text, uiCultureComboBox.Text);
            }

            _visualEditor.EditorSettings.CalculationMinInterval = (int)calculationMinIntervalNumericUpDown.Value;

            // appearances
            _visualEditor.FocusedCellsAppearance = focusedCellsAppearanceEditor.CellsAppearance;
            _visualEditor.CellsClipboardAppearance = bufferCellsAppearanceEditor.CellsAppearance;
            _visualEditor.FormulaAppearance = formulaCellsAppearanceEditor.CellsAppearance;
            _visualEditor.FormulaFocusedAppearance = focusedFormulaCellsAppearanceEditor.CellsAppearance;
            
            // chart appearances
            _visualEditor.ChartSeriesNameAppearance = seriesNameAppearanceEditor.CellsAppearance;
            _visualEditor.ChartSeriesValuesAppearance = seriesValuesAppearanceEditor.CellsAppearance;
            _visualEditor.ChartCategoryAxisAppearance = categoryAxisAppearanceEditor.CellsAppearance;

            // headings
            _visualEditor.HeadingsColor = VintasoftColor.FromArgb(headingsColorPanelControl.Color.ToArgb());
            _visualEditor.HeadingsTextColor = VintasoftColor.FromArgb(headingsTextColorPanelControl.Color.ToArgb());
            _visualEditor.HeadingsBorderColor = VintasoftColor.FromArgb(headingsBorderColorPanelControl.Color.ToArgb());
            _visualEditor.SelectedCellColor = VintasoftColor.FromArgb(selectedCellColorPanelControl.Color.ToArgb());
            _visualEditor.SelectedHeaderColor = VintasoftColor.FromArgb(selectedHeaderColorPanelControl.Color.ToArgb());
            _visualEditor.CoveredHeaderColor = VintasoftColor.FromArgb(coveredHeaderColorPanelControl.Color.ToArgb());

            // errors
            _visualEditor.ErrorIndicatorColor = VintasoftColor.FromArgb(errorIndicatorColorPanelControl.Color.ToArgb());
            _visualEditor.ErrorIndicatorSize = (double)errorIndicatorSizeNumericUpDown.Value;

            // comments
            _visualEditor.CommentIndicatorColor = VintasoftColor.FromArgb(commentIndicatorColorPanelControl.Color.ToArgb());
            _visualEditor.CommentIndicatorSize = (double)commentIndicatorSizeNumericUpDown.Value;
            _visualEditor.CommentAppearance = commentAppearanceEditor.CellsAppearance;
            _visualEditor.CommentFocusedAppearance = focusedCommentAppearanceEditor.CellsAppearance;

            // transform highlight
            _visualEditor.ShowInteractiveAreaHighlight = showInteractiveAreaHighlightCheckBox.Checked;
            _visualEditor.HeadersTransformHighlightAppearance = headersTransformHighlightAppearanceEditor.CellsAppearance;
            _visualEditor.SheetDrawingTransformHighlightAppearance = sheetDrawingTransformHighlightAppearanceEditor.CellsAppearance;
            _visualEditor.CellsTransformHighlightAppearance = cellsTransformHighlightAppearanceEditor.CellsAppearance;

            // miscellaneous
            _visualEditor.HyperlinkColor = VintasoftColor.FromArgb(hyperlinkColorPanelControl.Color.ToArgb());
            _visualEditor.GridColorAlpha = 1 - (double)gridColorAlphaNumericUpDown.Value / 255;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of buttonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
