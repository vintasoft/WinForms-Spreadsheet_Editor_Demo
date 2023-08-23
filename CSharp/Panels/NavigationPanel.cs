using DemosCommonCode;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.UI;
using Vintasoft.Primitives;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Provides the "Naviagation" panel.
    /// </summary>
    public partial class NavigationPanel : SpreadsheetVisualEditorPanel
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPanel"/> class.
        /// </summary>
        public NavigationPanel()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        #region Common

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
                visualEditor.FocusedWorksheetChanged -= VisualEditor_FocusedWorksheetChanged;
                visualEditor.EditorChanged -= VisualEditor_EditorChanged;
                visualEditor.InitializationFinished -= VisualEditor_InitializationFinished;
                visualEditor.ZoomChanged -= VisualEditor_ZoomChanged;
                visualEditor.SynchronizationStarted -= VisualEditor_SynchronizationStarted;
                visualEditor.SynchronizationFinished -= VisualEditor_SynchronizationFinished;
                visualEditor.EditCellValueStarted -= VisualEditor_EditingCellValueStateChanged;
                visualEditor.EditCellValueFinished -= VisualEditor_EditingCellValueStateChanged;
            }
            if (args.NewValue != null)
            {
                SpreadsheetVisualEditor visualEditor = args.NewValue.VisualEditor;
                visualEditor.FocusedWorksheetChanged += VisualEditor_FocusedWorksheetChanged;
                visualEditor.EditorChanged += VisualEditor_EditorChanged;
                visualEditor.InitializationFinished += VisualEditor_InitializationFinished;
                visualEditor.ZoomChanged += VisualEditor_ZoomChanged;
                visualEditor.SynchronizationStarted += VisualEditor_SynchronizationStarted;
                visualEditor.SynchronizationFinished += VisualEditor_SynchronizationFinished;
                visualEditor.EditCellValueStarted += VisualEditor_EditingCellValueStateChanged;
                visualEditor.EditCellValueFinished += VisualEditor_EditingCellValueStateChanged;
            }
            UpdateUI();
        }
       
        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            worksheetComboBox.Items.Clear();
            if (VisualEditor != null && VisualEditor.Document != null)
            {
                foreach (Worksheet worksheet in VisualEditor.Document.Worksheets)
                {
                    worksheetComboBox.Items.Add(worksheet.Name);
                }
            }
            panModeToolStripButton.Checked = VisualEditor.InteractionMode == SpreadsheetVisualEditorInteractionMode.PanAndSelection;
            UpdateFocusedWorksheetUI();
        }

        /// <summary>
        /// Updates the user interface of focused worksheet.
        /// </summary>
        private void UpdateFocusedWorksheetUI()
        {
            // if there is no focused worksheet, disable panel
            if (VisualEditor == null || VisualEditor.Document == null || VisualEditor.Document.FocusedWorksheet == null)
            {
                firstWorksheetButton.Enabled = false;
                prevWorksheetButton.Enabled = false;
                worksheetComboBox.Enabled = false;
                nextWorksheetButton.Enabled = false;
                lastWorksheetButton.Enabled = false;
                addWorksheetButton.Enabled = false;
                worksheetsActionsButton.Enabled = false;
                zoomInButton.Enabled = false;
                zoomComboBox.Enabled = false;
                zoomOutButton.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
            else
            {
                bool isChangingFocusedCellValue = VisualEditor.IsChangingFocusedCellValue;

                int worksheetCount = VisualEditor.Document.Worksheets.Count;
                int worksheetIndex = VisualEditor.FocusedWorksheetIndex;

                // navigation
                firstWorksheetButton.Enabled = worksheetIndex > 0 && !isChangingFocusedCellValue;
                prevWorksheetButton.Enabled = worksheetIndex > 0 && !isChangingFocusedCellValue;
                worksheetComboBox.Enabled = !isChangingFocusedCellValue;
                if (VisualEditor.FocusedWorksheet != null)
                    worksheetComboBox.SelectedItem = VisualEditor.FocusedWorksheet.Name;
                else
                    worksheetComboBox.Text = "";
                nextWorksheetButton.Enabled = worksheetIndex < worksheetCount - 1 && !isChangingFocusedCellValue;
                lastWorksheetButton.Enabled = worksheetIndex < worksheetCount - 1 && !isChangingFocusedCellValue;

                // worksheet manipulation
                copyToolStripMenuItem.Enabled = !VisualEditor.IsSynchronizing && !isChangingFocusedCellValue;
                addWorksheetButton.Enabled = !VisualEditor.IsSynchronizing && !isChangingFocusedCellValue;
                worksheetsActionsButton.Enabled = !isChangingFocusedCellValue;
                removeToolStripMenuItem.Enabled = !VisualEditor.IsSynchronizing && worksheetCount > 1 && !isChangingFocusedCellValue;
                moveMenuItem.Enabled = !VisualEditor.IsSynchronizing && worksheetCount > 1 && !isChangingFocusedCellValue;

                // worksheet properties
                showHeadingsToolStripMenuItem.Checked = VisualEditor.ShowHeadings;
                showFormulasToolStripMenuItem.Checked = VisualEditor.ShowFormulas;
                showGridToolStripMenuItem.Checked = VisualEditor.ShowGrid;

                // zoom
                int zoom = (int)Math.Round(VisualEditor.Zoom);
                zoomOutButton.Enabled = zoom > 10;
                zoomComboBox.Enabled = true;
                zoomComboBox.Text = zoom.ToString() + "%";
                zoomInButton.Enabled = zoom < 400;
            }
        }

        /// <summary>
        /// Handles the Click event of PanModeToolStripButton object.
        /// </summary>
        private void panModeToolStripButton_Click(object sender, EventArgs e)
        {
            panModeToolStripButton.Checked = !panModeToolStripButton.Checked;
            if (panModeToolStripButton.Checked)
                VisualEditor.InteractionMode = SpreadsheetVisualEditorInteractionMode.PanAndSelection;
            else
                VisualEditor.InteractionMode = SpreadsheetVisualEditorInteractionMode.Selection;

        }

        private void VisualEditor_InitializationFinished(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void VisualEditor_EditorChanged(object sender, PropertyChangedEventArgs<Vintasoft.Imaging.Office.Spreadsheet.SpreadsheetEditor> e)
        {
            UpdateUI();
        }

        private void VisualEditor_SynchronizationFinished(object sender, EventArgs e)
        {
            UpdateFocusedWorksheetUI();
        }

        private void VisualEditor_SynchronizationStarted(object sender, EventArgs e)
        {
            UpdateFocusedWorksheetUI();
        }


        private void VisualEditor_FocusedWorksheetChanged(object sender, PropertyChangedEventArgs<Worksheet> e)
        {
            UpdateFocusedWorksheetUI();
        }

        /// <summary>
        /// Handles the EditCellValueStarted/EditCellValueFinished event of the VisualEditor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VisualEditor_EditingCellValueStateChanged(object sender, EventArgs e)
        {
            UpdateFocusedWorksheetUI();
        }

        #endregion


        #region Navigation

        /// <summary>
        /// Handles the Click event of FirstWorksheetButton object.
        /// </summary>
        private void firstWorksheetButton_Click(object sender, EventArgs e)
        {
            // move focused worksheet to the first position
            VisualEditor.FocusedWorksheetIndex = 0;
        }

        /// <summary>
        /// Handles the Click event of PrevWorksheetButton object.
        /// </summary>
        private void prevWorksheetButton_Click(object sender, EventArgs e)
        {
            // move focused worksheet to the previous position
            VisualEditor.FocusedWorksheetIndex--;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of WorksheetComboBox object.
        /// </summary>
        private void worksheetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set focused worksheet
            VisualEditor.FocusedWorksheetIndex = worksheetComboBox.SelectedIndex;
        }

        /// <summary>
        /// Handles the Click event of NextWorksheetButton object.
        /// </summary>
        private void nextWorksheetButton_Click(object sender, EventArgs e)
        {
            // move focused worksheet to the next position
            VisualEditor.FocusedWorksheetIndex++;
        }

        /// <summary>
        /// Handles the Click event of LastWorksheetButton object.
        /// </summary>
        private void lastWorksheetButton_Click(object sender, EventArgs e)
        {
            // move focused worksheet to the last position
            VisualEditor.FocusedWorksheetIndex = VisualEditor.Document.Worksheets.Count - 1;
        }

        #endregion


        #region Worksheet manipulations and properties

        /// <summary>
        /// Handles the Click event of AddWorksheetButton object.
        /// </summary>
        private void addWorksheetButton_Click(object sender, EventArgs e)
        {
            // add new worksheet
            try
            {
                VisualEditor.AddWorksheet();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }

            UpdateUI();
        }

        /// <summary>
        /// Handles the ButtonClick event of WorksheetsButton object.
        /// </summary>
        private void worksheetsButton_ButtonClick(object sender, EventArgs e)
        {
            worksheetsActionsButton.ShowDropDown();
        }

        /// <summary>
        /// Handles the Click event of CopyToolStripMenuItem object.
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // copy focused worksheet
            try
            {
                VisualEditor.CopyWorksheet();
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of RemoveToolStripMenuItem object.
        /// </summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Remove worksheet '{0}'?", VisualEditor.FocusedWorksheet.Name),
                "Remove Worksheet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // remove focused worksheet
                try
                {
                    VisualEditor.RemoveWorksheet();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
                UpdateUI();
            }
        }

        /// <summary>
        /// Handles the Click event of MoveMenuItem object.
        /// </summary>
        private void moveMenuItem_Click(object sender, EventArgs e)
        {
            // show "Move worksheet" dialog
            using (MoveWorksheetForm dlg = new MoveWorksheetForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.IsWorksheetOrderChanged)
                    {
                        UpdateUI();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of RenameToolStripMenuItem object.
        /// </summary>
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show "Rename worksheet" dialog
            using (RenameWorksheetForm dlg = new RenameWorksheetForm(VisualEditor))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.IsWorksheetNameChanged)
                    {
                        UpdateUI();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of ShowHeadingsToolStripMenuItem object.
        /// </summary>
        private void showHeadingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.ShowHeadings = !VisualEditor.ShowHeadings;
            showHeadingsToolStripMenuItem.Checked = VisualEditor.ShowHeadings;
        }

        /// <summary>
        /// Handles the Click event of ShowFormulasToolStripMenuItem object.
        /// </summary>
        private void showFormulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.ShowFormulas = !VisualEditor.ShowFormulas;
            showFormulasToolStripMenuItem.Checked = VisualEditor.ShowFormulas;
        }

        /// <summary>
        /// Handles the Click event of ShowGridToolStripMenuItem object.
        /// </summary>
        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualEditor.ShowGrid = !VisualEditor.ShowGrid;
            showGridToolStripMenuItem.Checked = VisualEditor.ShowGrid;
        }

        /// <summary>
        /// Handles the Click event of GridColorToolStripMenuItem object.
        /// </summary>
        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create "Color" dialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Color.FromArgb(VisualEditor.GridColor.ToArgb());
            colorDialog.FullOpen = true;

            // show "Color" dialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
                VisualEditor.GridColor = VintasoftColor.FromArgb(colorDialog.Color.ToArgb());
        }

        /// <summary>
        /// Handles the Click event of FormatToolStripMenuItem object.
        /// </summary>
        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show "Worksheet Format" dialog
            WorksheetFormatForm.ShowDialog(VisualEditor);
        }

        #endregion


        #region Zoom

        /// <summary>
        /// Handles the Click event of ZoomOutButton object.
        /// </summary>
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            // get current zoom comboBox value
            int index = GetPredefinedZoomIndex();
            int predefinedZoom = int.Parse(GetZoomText(zoomComboBox.Items[index].ToString()));

            // set lower zoom value
            if (predefinedZoom < VisualEditor.Zoom)
                zoomComboBox.SelectedIndex = index;
            else if (index < zoomComboBox.Items.Count - 1)
                zoomComboBox.SelectedIndex = index + 1;
        }

        /// <summary>
        /// Handles the Click event of ZoomInButton object.
        /// </summary>
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            // get current zoom comboBox value
            int index = GetPredefinedZoomIndex();
            int predefinedZoom = int.Parse(GetZoomText(zoomComboBox.Items[index].ToString()));

            // set higher zoom value
            if (predefinedZoom > VisualEditor.Zoom)
                zoomComboBox.SelectedIndex = index;
            else if (index > 0)
                zoomComboBox.SelectedIndex = index - 1;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of ZoomComboBox object.
        /// </summary>
        private void zoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetZoom();
        }

        /// <summary>
        /// Handles the KeyDown event of ZoomComboBox object.
        /// </summary>
        private void zoomComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetZoom();
        }

        /// <summary>
        /// Handles the Leave event of ZoomComboBox object.
        /// </summary>
        private void zoomComboBox_Leave(object sender, EventArgs e)
        {
            SetZoom();
        }

        /// <summary>
        /// Sets the zoom, specified in zoom comboBox.
        /// </summary>
        private void SetZoom()
        {
            if (VisualEditor != null)
            {
                string zoomText = GetZoomText(zoomComboBox.Text);
                int zoom;
                if (int.TryParse(zoomText, out zoom))
                {
                    if (zoom < 10)
                        zoom = 10;
                    else if (zoom > 400)
                        zoom = 400;
                    VisualEditor.Zoom = zoom;
                }
            }
        }

        /// <summary>
        /// Returns the zoom value without percent sign.
        /// </summary>
        /// <param name="text">Zoom value with percent sign.</param>
        private string GetZoomText(string text)
        {
            return text.Replace("%", "").Trim();
        }


        /// <summary>
        /// Returns the index of predefined zoom.
        /// </summary>
        private int GetPredefinedZoomIndex()
        {
            double zoom;
            if (!double.TryParse(GetZoomText(zoomComboBox.Text), NumberStyles.Number, UICulture, out zoom))
                zoom = 100;
            for (int i = zoomComboBox.Items.Count - 1; i >= 0; i--)
            {
                string zoomText = GetZoomText(zoomComboBox.Items[i].ToString());
                if (int.Parse(zoomText) >= zoom)
                    return i;
            }
            return zoomComboBox.Items.Count - 1;
        }

        /// <summary>
        /// Handles the ZoomChanged event of VisualEditor object.
        /// </summary>
        private void VisualEditor_ZoomChanged(object sender, PropertyChangedEventArgs<double> e)
        {
            UpdateFocusedWorksheetUI();
        }

        #endregion

        #endregion

    }
}
