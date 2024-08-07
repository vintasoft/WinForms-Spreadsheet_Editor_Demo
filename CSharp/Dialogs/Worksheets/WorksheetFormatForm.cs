﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Imaging.Office.Spreadsheet.UI.Controls;

using DemosCommonCode;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A form that allows to view and change the worksheet format properties.
    /// </summary>
    public partial class WorksheetFormatForm : Form
    {

        #region Fields

        /// <summary>
        /// Spreadsheet visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfoForm"/> class.
        /// </summary>
        public WorksheetFormatForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the current culture.
        /// </summary>
        [Browsable(false)]
        public CultureInfo Culture
        {
            get
            {
                if (_visualEditor != null)
                {
                    try
                    {
                        return CultureInfo.GetCultureInfo(_visualEditor.DocumentCulture);
                    }
                    catch
                    {
                    }
                }
                return CultureInfo.CurrentCulture;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows this form with current document information.
        /// </summary>
        /// <param name="visualEditor">Spreadsheet visual editor.</param>
        public static DialogResult ShowDialog(SpreadsheetVisualEditor visualEditor)
        {
            using (WorksheetFormatForm form = new WorksheetFormatForm())
            {
                form.SetVisualEditor(visualEditor);
                return form.ShowDialog();
            }
        }


        /// <summary>
        /// Sets the document information properties to this form UI.
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
            WorksheetFormat format = _visualEditor.FocusedWorksheet.Format;

            rowHeightTextBox.Text = Math.Round(format.RowHeight, 2).ToString(Culture);
            columnWidthTextBox.Text = Math.Round(format.ColumnWidth, 2).ToString(Culture);
            rowAutoHeightCheckBox.Checked = format.AutoHeight;
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            double rowHeight;
            if (!double.TryParse(rowHeightTextBox.Text, NumberStyles.Float, Culture, out rowHeight))
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ROW_HEIGHT_MUST_BE_AN_INTEGER_OR_DECIMAL_NUMBER);
                return;
            }
            if (rowHeight > CellsEditorPanel.MAX_ROW_HEIGHT)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ROW_HEIGHT_MUST_BE_LESS_THAN_OR_EQUAL_ARG0, CellsEditorPanel.MAX_ROW_HEIGHT));
                return;
            }
            if (rowHeight < 0)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ROW_HEIGHT_MUST_BE_GREATER_THAN_OR_EQUAL_0);
                return;
            }

            double columnWidth;
            if (!double.TryParse(columnWidthTextBox.Text, NumberStyles.Float, Culture, out columnWidth))
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN_WIDTH_MUST_BE_AN_INTEGER_OR_DECIMAL_NUMBER);
                return;
            }
            if (columnWidth > CellsEditorPanel.MAX_COLUMN_WIDTH)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN_WIDTH_MUST_BE_LESS_THAN_OR_EQUAL_ARG0, CellsEditorPanel.MAX_COLUMN_WIDTH));
                return;
            }
            if (columnWidth < 0)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN_WIDTH_MUST_BE_GREATER_THAN_OR_EQUAL_0);
                return;
            }

            bool isAutoHeight = rowAutoHeightCheckBox.Checked;

            bool isRowsHiddenByDefault = _visualEditor.FocusedWorksheet.Format.RowsHiddenByDefault;

            WorksheetFormat format = new WorksheetFormat(columnWidth, rowHeight, isAutoHeight, isRowsHiddenByDefault);

            // if format is changed, set it to worksheet
            if (!Equals(format, _visualEditor.FocusedWorksheet.Format))
                _visualEditor.SetWorksheetFormat(format);

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
