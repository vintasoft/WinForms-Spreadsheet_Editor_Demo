using System;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

using DemosCommonCode;


namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides a "Text Alignment" panel.
    /// </summary>
    public partial class TextAlignmentPanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignmentPanel"/> class.
        /// </summary>
        public TextAlignmentPanel()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="SpreadsheetEditorChanged" /> event.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs{SpreadsheetEditorControl}"/> instance containing the event data.</param>
        protected override void OnSpreadsheetEditorChanged(PropertyChangedEventArgs<SpreadsheetEditorControl> args)
        {
            base.OnSpreadsheetEditorChanged(args);

            if (args.OldValue != null)
            {
                args.OldValue.VisualEditor.FocusedCellChanged -= VisualEditor_FocusedCellChanged;
                args.OldValue.VisualEditor.FocusedCommentChanged -= VisualEditor_FocusedCommentChanged;
                args.OldValue.VisualEditor.SelectedCells.Changed -= SelectedCells_Changed;
                args.OldValue.VisualEditor.CellsStylePropertiesChanged -= VisualEditor_CellsStylePropertiesChanged;
                args.OldValue.VisualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
            }

            if (args.NewValue != null)
            {
                args.NewValue.VisualEditor.FocusedCellChanged += VisualEditor_FocusedCellChanged;
                args.NewValue.VisualEditor.FocusedCommentChanged += VisualEditor_FocusedCommentChanged;
                args.NewValue.VisualEditor.SelectedCells.Changed += SelectedCells_Changed;
                args.NewValue.VisualEditor.CellsStylePropertiesChanged += VisualEditor_CellsStylePropertiesChanged;
                args.NewValue.VisualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
            }

            UpdateUI();
        }

        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateUI();
        }

        private void VisualEditor_CellsStylePropertiesChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of VerticalAlignTopButton object.
        /// </summary>
        private void verticalAlignTopButton_Click(object sender, EventArgs e)
        {
            VisualEditor.TextVerticalAlign = TextVerticalAlign.Top;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of VerticalAlignMiddleButton object.
        /// </summary>
        private void verticalAlignMiddleButton_Click(object sender, EventArgs e)
        {
            VisualEditor.TextVerticalAlign = TextVerticalAlign.Middle;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of VerticalAlignmentBottomButton object.
        /// </summary>
        private void verticalAlignmentBottomButton_Click(object sender, EventArgs e)
        {
            VisualEditor.TextVerticalAlign = TextVerticalAlign.Bottom;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of HorizontalAlignmentLeftButton object.
        /// </summary>
        private void horizontalAlignmentLeftButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.TextHorizontalAlign == TextHorizontalAlign.Left)
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Default;
            else
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Left;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of HorizontalAlignmentCenterButton object.
        /// </summary>
        private void horizontalAlignmentCenterButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.TextHorizontalAlign == TextHorizontalAlign.Center)
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Default;
            else
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Center;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of HorizontalAlignmentRightButton object.
        /// </summary>
        private void horizontalAlignmentRightButton_Click(object sender, EventArgs e)
        {
            if (VisualEditor.TextHorizontalAlign == TextHorizontalAlign.Right)
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Default;
            else
                VisualEditor.TextHorizontalAlign = TextHorizontalAlign.Right;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of MergeButton object.
        /// </summary>
        private void mergeButton_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCells();
                OnTextPropertyChanged();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of MergeAndCenterButton object.
        /// </summary>
        private void mergeAndCenterButton_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCellsAndCenterText();
                OnTextPropertyChanged();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of MergeAcrossButton object.
        /// </summary>
        private void mergeAcrossButton_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.MergeCellsAcross();
                OnTextPropertyChanged();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of UnmergeButton object.
        /// </summary>
        private void unmergeButton_Click(object sender, EventArgs e)
        {
            try
            {
                VisualEditor.UnmergeCells();
                OnTextPropertyChanged();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of DecreaseIndentButton object.
        /// </summary>
        private void decreaseIndentButton_Click(object sender, EventArgs e)
        {
            VisualEditor.TextIndent = Math.Max(0, VisualEditor.TextIndent - 1);
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of IncreaseIndentButton object.
        /// </summary>
        private void increaseIndentButton_Click(object sender, EventArgs e)
        {
            VisualEditor.TextIndent = VisualEditor.TextIndent + 1;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of AlignmentPropertiesButton object.
        /// </summary>
        private void alignmentPropertiesButton_Click(object sender, EventArgs e)
        {
            CellsStyleForm.ShowAlignmentDialog(VisualEditor);
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Handles the Click event of TextWrapButton object.
        /// </summary>
        private void textWrapButton_Click(object sender, EventArgs e)
        {
            VisualEditor.WrapText = !VisualEditor.WrapText;
            OnTextPropertyChanged();
        }

        /// <summary>
        /// Called when text property is changed.
        /// </summary>
        private void OnTextPropertyChanged()
        {
            UpdateUI();
            SpreadsheetEditor.Focus();
        }

        /// <summary>
        /// Handles the Changed event of the VisualEditor.SelectedCells.
        /// </summary>
        private void SelectedCells_Changed(object sender, EventArgs e)
        {
            if (!VisualEditor.IsFocusedCellsChanging)
                UpdateUI();
        }

        /// <summary>
        /// Handles the FocusedCellChanged event of the VisualEditor.
        /// </summary>
        private void VisualEditor_FocusedCellChanged(object sender, PropertyChangedEventArgs<CellReference> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the FocusedCommentChanged event of the VisualEditor.
        /// </summary>
        private void VisualEditor_FocusedCommentChanged(object sender, PropertyChangedEventArgs<CellComment> e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
        private void UpdateUI()
        {
            if (VisualEditor.IsFocusedWorksheetChanging)
                return;

            if (VisualEditor.FocusedWorksheet == null || (VisualEditor.FocusedCell == null && VisualEditor.FocusedComment == null))
            {
                Enabled = false;
            }
            else
            {
                Enabled = true;

                // get focused text properties
                TextProperties focusedTextProperties = VisualEditor.FocusedTextProperties;

                switch (focusedTextProperties.HorizontalAlign)
                {
                    case TextHorizontalAlign.Default:
                        horizontalAlignmentLeftButton.Checked = false;
                        horizontalAlignmentCenterButton.Checked = false;
                        horizontalAlignmentRightButton.Checked = false;
                        break;
                    case TextHorizontalAlign.Left:
                        horizontalAlignmentLeftButton.Checked = true;
                        horizontalAlignmentCenterButton.Checked = false;
                        horizontalAlignmentRightButton.Checked = false;
                        break;
                    case TextHorizontalAlign.Center:
                        horizontalAlignmentLeftButton.Checked = false;
                        horizontalAlignmentCenterButton.Checked = true;
                        horizontalAlignmentRightButton.Checked = false;
                        break;
                    case TextHorizontalAlign.Right:
                        horizontalAlignmentLeftButton.Checked = false;
                        horizontalAlignmentCenterButton.Checked = false;
                        horizontalAlignmentRightButton.Checked = true;
                        break;
                }

                switch (focusedTextProperties.VerticalAlign)
                {
                    case TextVerticalAlign.Top:
                        verticalAlignTopButton.Checked = true;
                        verticalAlignMiddleButton.Checked = false;
                        verticalAlignmentBottomButton.Checked = false;
                        break;
                    case TextVerticalAlign.Middle:
                        verticalAlignTopButton.Checked = false;
                        verticalAlignMiddleButton.Checked = true;
                        verticalAlignmentBottomButton.Checked = false;
                        break;
                    case TextVerticalAlign.Bottom:
                        verticalAlignTopButton.Checked = false;
                        verticalAlignMiddleButton.Checked = false;
                        verticalAlignmentBottomButton.Checked = true;
                        break;
                }

                unmergeButton.Checked = VisualEditor.CanUnmergeCells;
                textWrapButton.Checked = focusedTextProperties.WrapText;

                bool canMerge = VisualEditor.CanMergeCells;
                mergeButton.Enabled = canMerge;
                mergeAndCenterButton.Enabled = canMerge;
                mergeAcrossButton.Enabled = canMerge;

                unmergeButton.Checked = VisualEditor.CanUnmergeCells;

                bool commentIsFocused = VisualEditor.FocusedComment != null;
                textWrapButton.Enabled = !commentIsFocused;
                mergeButton.Enabled = !commentIsFocused;
                mergeAndCenterButton.Enabled = !commentIsFocused;
                mergeAcrossButton.Enabled = !commentIsFocused;
                unmergeButton.Enabled = !commentIsFocused;
                decreaseIndentButton.Enabled = !commentIsFocused;
                increaseIndentButton.Enabled = !commentIsFocused;
                alignmentPropertiesButton.Enabled = !commentIsFocused;
            }
        }

        #endregion

    }
}
