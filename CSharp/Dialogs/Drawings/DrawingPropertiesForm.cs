using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DemosCommonCode;

using Vintasoft.Imaging.Office.Spreadsheet.Document;
using Vintasoft.Imaging.Office.Spreadsheet.Document.Editors;
using Vintasoft.Imaging.Office.Spreadsheet.UI;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// A dialog that allows to edit the drawing properties.
    /// </summary>
    public partial class DrawingPropertiesForm : Form
    {

        #region Fields

        /// <summary>
        /// The visual editor.
        /// </summary>
        SpreadsheetVisualEditor _visualEditor;

        /// <summary>
        /// The drawing.
        /// </summary>
        SheetDrawing _drawing;

        /// <summary>
        /// The chart series.
        /// </summary>
        List<ChartDataSeries> _series = new List<ChartDataSeries>();

        /// <summary>
        /// The chart series, which are selected in combobox.
        /// </summary>
        ChartDataSeries _selectedSeries;

        /// <summary>
        /// A value indicating whether chart properties are being initialized.
        /// </summary>
        bool _isChartPropertiesInitializing;

        /// <summary>
        /// A value indicating whether series properties are being initialized.
        /// </summary>
        bool _isSeriesPropertiesInitializing;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawingPropertiesForm"/> class.
        /// </summary>
        public DrawingPropertiesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawingPropertiesForm"/> class.
        /// </summary>
        /// <param name="visualEditor">The spreadsheet visual editor.</param>
        /// <param name="drawing">The sheet drawing.</param>
        public DrawingPropertiesForm(SpreadsheetVisualEditor visualEditor, SheetDrawing drawing)
            : this()
        {
            _visualEditor = visualEditor;
            _drawing = drawing;

            // drawing name
            nameTextBox.Text = drawing.Name;
            // drawing description
            descriptionTextBox.Text = drawing.Description;
            // drawing rotation
            rotationAngleNumericUpDown.Value = (decimal)drawing.Rotation;
            rotationAngleNumericUpDown.Enabled = drawing.Type != DrawingType.Chart;

            // drawing location
            sheetDrawingLocationEditorControl.Worksheet = visualEditor.FocusedWorksheet;
            sheetDrawingLocationEditorControl.SheetDrawingLocation = drawing.Location;

            // chart
            if (drawing.ChartProperties == null)
            {
                tabControl1.TabPages.Remove(chartTabPage);
            }
            else
            {
                _isChartPropertiesInitializing = true;

                // chart type
                chartTabPage.Text = string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CHART_ARG0, drawing.ChartProperties.ChartType);

                // cancel button is disabled because chart changes applies immediately
                buttonCancel.Enabled = false;

                // init marker style comboBox
                foreach (ChartMarkerStyle markerStyle in Enum.GetValues(typeof(ChartMarkerStyle)))
                    markerTypeComboBox.Items.Add(markerStyle);

                // chart title
                titleTextBox.Text = drawing.ChartProperties.Title;

                // data range
                try
                {
                    dataRangeTextBox.Text = drawing.ChartProperties.GetCellReferencesSet().GetBounds().ToString();
                }
                catch
                {
                    dataRangeTextBox.Text = drawing.ChartProperties.GetCellReferencesSet().ToString(visualEditor.Document);
                }

                // init series comboBox
                if (drawing.ChartProperties.Series.Count > 0)
                {
                    int seriesIndex = 0;
                    for (int i = 0; i < drawing.ChartProperties.Series.Count; i++)
                    {
                        if (drawing.ChartProperties.Series[i].SeriesType == ChartDataSeriesType.DataSeries)
                        {
                            seriesComboBox.Items.Add(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SERIES_ARG0, seriesIndex + 1));
                            seriesIndex++;

                            _series.Add(drawing.ChartProperties.Series[i]);
                        }
                    }

                    seriesComboBox.SelectedIndex = 0;
                }

                // categories axis data range
                if (drawing.ChartProperties.CategoryAxis != null)
                    categoriesDataRangeTextBox.Text = drawing.ChartProperties.CategoryAxis.ToString(visualEditor.Document);
                else
                    categoriesDataRangeTextBox.Text = "";

                if (drawing.ChartProperties.ChartType == ChartType.Line ||
                    drawing.ChartProperties.ChartType == ChartType.Bar2D ||
                    drawing.ChartProperties.ChartType == ChartType.Bar3D ||
                    drawing.ChartProperties.ChartType == ChartType.Axial ||
                    drawing.ChartProperties.ChartType == ChartType.Scatter)
                {
                    categoryAxisTitleTextBox.Text = drawing.ChartProperties.CategoryAxisTitle;
                    valuesAxisTitleTextBox.Text = drawing.ChartProperties.ValuesAxisTitle;
                }
                else
                {
                    categoryAxisTitleTextBox.Enabled = false;
                    valuesAxisTitleTextBox.Enabled = false;
                }


                if (drawing.ChartProperties.ChartType == ChartType.Line)
                    smoothLineCheckBox.Enabled = true;
                else
                    smoothLineCheckBox.Enabled = false;

                _isChartPropertiesInitializing = false;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="System.Windows.Forms.Form.Shown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="System.EventArgs" /> that contains the event data.</param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            descriptionTextBox.Focus();
        }


        #region UI

        /// <summary>
        /// Handles the SelectedIndexChanged event of seriesComboBox object.
        /// </summary>
        private void seriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isSeriesPropertiesInitializing = true;

            // get selected series
            _selectedSeries = _series[seriesComboBox.SelectedIndex];

            // set the selected series properties to the UI
            if (_selectedSeries.Name != null)
                nameRangeTextBox.Text = _selectedSeries.Name.ToString(_visualEditor.Document);
            else
                nameRangeTextBox.Text = "";

            if (_selectedSeries.Values != null)
                valuesRangeTextBox.Text = _selectedSeries.Values.ToString(_visualEditor.Document);
            else
                valuesRangeTextBox.Text = "";

            // clear data points combobox
            dataPointComboBox.Items.Clear();

            // init data points combobox
            // add 'All' item to data point combobox
            dataPointComboBox.Items.Add(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ALL);

            // if series contains data points
            if (_selectedSeries.DataPoints != null && _selectedSeries.DataPoints.Length > 0)
            {
                // add data point items
                for (int i = 0; i < _selectedSeries.DataPoints.Length; i++)
                    dataPointComboBox.Items.Add(string.Format(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DATA_POINT_ARG0, i + 1));

                dataPointComboBox.SelectedIndex = 0;
            }

            smoothLineCheckBox.Checked = _selectedSeries.SmoothLine;

            _isSeriesPropertiesInitializing = false;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of dataPointComboBox object.
        /// </summary>
        private void dataPointComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isSeriesPropertiesInitializing = true;

            // if 'All' is selected
            if (dataPointComboBox.SelectedItem.ToString() == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ALL_ALT1)
            {
                // set the series appearance properties
                dataPointAppearanceEditor.ShapeAppearance = _selectedSeries.AppearanceProperties;
                dataPointAppearanceGroupBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SERIES_APPEARANCE;

                // if series marker is set
                if (_selectedSeries.Marker != null)
                {
                    markerAppearanceGroupBox.Enabled = true;
                    // set marker properties to the UI
                    markerAppearanceEditor.ShapeAppearance = _selectedSeries.Marker.AppearanceProperties;
                    markerTypeComboBox.SelectedItem = _selectedSeries.Marker.Style;
                    markerSizeNumericUpDown.Value = (decimal)_selectedSeries.Marker.Size;
                }
                else
                {
                    markerAppearanceGroupBox.Enabled = false;
                }
            }
            else
            {
                // get selected data point
                ChartDataPoint selectedDataPoint = _selectedSeries.DataPoints[dataPointComboBox.SelectedIndex - 1];

                // set the data point appearance properties
                dataPointAppearanceEditor.ShapeAppearance = selectedDataPoint.AppearanceProperties;
                dataPointAppearanceGroupBox.Text = SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DATA_POINT_APPEARANCE;

                // if data point marker is set
                if (selectedDataPoint.Marker != null)
                {
                    markerAppearanceGroupBox.Enabled = true;
                    // set marker properties to the UI
                    markerAppearanceEditor.ShapeAppearance = selectedDataPoint.Marker.AppearanceProperties;
                    markerTypeComboBox.SelectedItem = selectedDataPoint.Marker.Style;
                    markerSizeNumericUpDown.Value = (decimal)selectedDataPoint.Marker.Size;
                }
                else
                {
                    markerAppearanceGroupBox.Enabled = false;
                }
            }

            _isSeriesPropertiesInitializing = false;
        }

        /// <summary>
        /// Handles the ShapeAppearanceChanged event of dataPointAppearanceEditor object.
        /// </summary>
        private void dataPointAppearanceEditor_ShapeAppearanceChanged(object sender, EventArgs e)
        {
            if (_isSeriesPropertiesInitializing)
                return;

            // create worksheet editor
            WorksheetEditor worksheetEditor = _visualEditor.Editor.StartEditing(_visualEditor.FocusedWorksheet);
            try
            {
                // create chart series editor
                SheetDrawingEditor drawingEditor = worksheetEditor.CreateDrawingEditor(_drawing);
                ChartPropertiesEditor chartPropertiesEditor = drawingEditor.CreateChartPropertiesEditor();
                ChartDataSeriesEditor chartSeriesEditor = chartPropertiesEditor.CreateChartDataSeriesEditor(_selectedSeries);

                // data points
                ChartDataPoint[] points = _selectedSeries.DataPoints;

                // if 'All' item is selected
                if (dataPointComboBox.SelectedItem.ToString() == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ALL_ALT2)
                {
                    // set the appearance properties to the series
                    chartSeriesEditor.SetAppearanceProperties(dataPointAppearanceEditor.ShapeAppearance);

                    // set the appearance properties to all points
                    if (points != null && points.Length > 0)
                    {
                        for (int i = 0; i < points.Length; i++)
                            points[i] = new ChartDataPoint(points[i].Marker, dataPointAppearanceEditor.ShapeAppearance);
                    }
                }
                else
                {
                    // set the appearance properties to the point
                    // get selected data point
                    int selectedIndex = dataPointComboBox.SelectedIndex - 1;
                    ChartDataPoint selectedPoint = points[selectedIndex];
                    // create data point with new appearance
                    ChartDataPoint newPoint = new ChartDataPoint(selectedPoint.Marker, dataPointAppearanceEditor.ShapeAppearance);
                    // set new point
                    points[selectedIndex] = newPoint;
                }

                // set data points
                chartSeriesEditor.SetDataPoints(points);
            }
            finally
            {
                _visualEditor.Editor.FinishEditing();
            }
        }

        /// <summary>
        /// Handles the Changed event of markerProperties object.
        /// </summary>
        private void markerProperties_Changed(object sender, EventArgs e)
        {
            if (_isSeriesPropertiesInitializing)
                return;

            // create worksheet editor
            WorksheetEditor worksheetEditor = _visualEditor.Editor.StartEditing(_visualEditor.FocusedWorksheet);
            try
            {
                // create chart series editor
                SheetDrawingEditor drawingEditor = worksheetEditor.CreateDrawingEditor(_drawing);
                ChartPropertiesEditor chartPropertiesEditor = drawingEditor.CreateChartPropertiesEditor();
                ChartDataSeriesEditor chartSeriesEditor = chartPropertiesEditor.CreateChartDataSeriesEditor(_selectedSeries);

                // create new marker
                ChartMarker marker = new ChartMarker(
                    (ChartMarkerStyle)markerTypeComboBox.SelectedItem,
                    (double)markerSizeNumericUpDown.Value,
                    markerAppearanceEditor.ShapeAppearance);

                // if 'All' item is selected
                if (dataPointComboBox.SelectedItem.ToString() == SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_ALL_ALT3)
                {
                    // set marker properties to the series
                    chartSeriesEditor.SetMarker(marker);
                }
                else
                {
                    // set marker properties to the point
                    // get selected data point
                    ChartDataPoint[] points = _selectedSeries.DataPoints;
                    int selectedIndex = dataPointComboBox.SelectedIndex - 1;
                    ChartDataPoint selectedPoint = points[selectedIndex];
                    // create data point with new marker
                    ChartDataPoint newPoint = new ChartDataPoint(marker, selectedPoint.AppearanceProperties);
                    // set new point
                    points[selectedIndex] = newPoint;
                    // set data points
                    chartSeriesEditor.SetDataPoints(points);
                }
            }
            finally
            {
                _visualEditor.Editor.FinishEditing();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of smoothLineCheckBox object.
        /// </summary>
        private void smoothLineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_isChartPropertiesInitializing)
                return;

            // create worksheet editor
            WorksheetEditor worksheetEditor = _visualEditor.Editor.StartEditing(_visualEditor.FocusedWorksheet);
            try
            {
                // create drawing editor
                ChartDataSeriesEditor seriesEditor = worksheetEditor.CreateDrawingEditor(_drawing).CreateChartPropertiesEditor().CreateChartDataSeriesEditor(_selectedSeries);
                // set chart title
                seriesEditor.SetSmoothLine(smoothLineCheckBox.Checked);
            }
            finally
            {
                _visualEditor.Editor.FinishEditing();
            }
        }

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckDrawingName();

                // create worksheet editor
                WorksheetEditor worksheetEditor = _visualEditor.Editor.StartEditing(_visualEditor.FocusedWorksheet);
                try
                {
                    // create drawing editor
                    SheetDrawingEditor drawingEditor = worksheetEditor.CreateDrawingEditor(_drawing);

                    // set drawing name
                    drawingEditor.SetName(nameTextBox.Text.Trim());

                    // set drawing description
                    drawingEditor.SetDescription(descriptionTextBox.Text);

                    // set drawing description
                    if (rotationAngleNumericUpDown.Enabled)
                        drawingEditor.SetRotation((double)rotationAngleNumericUpDown.Value);

                    // if drawing location is changed
                    if (!Equals(_drawing.Location, sheetDrawingLocationEditorControl.SheetDrawingLocation))
                        // set the drawing location
                        drawingEditor.SetLocation(sheetDrawingLocationEditorControl.SheetDrawingLocation);
                }
                finally
                {
                    _visualEditor.Editor.FinishEditing();
                }

                if (_drawing.Type == DrawingType.Chart)
                {
                    _visualEditor.StartEditing(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SET_CHART_PROPERTIES);
                    try
                    {
                        // set chart title
                        if (IsTitleChanged(_visualEditor.ChartTitle, titleTextBox.Text))
                            _visualEditor.ChartTitle = titleTextBox.Text;
                        // set category axis title
                        if (categoryAxisTitleTextBox.Enabled && IsTitleChanged(_visualEditor.ChartCategoryAxisTitle, categoryAxisTitleTextBox.Text))
                            _visualEditor.ChartCategoryAxisTitle = categoryAxisTitleTextBox.Text;
                        // set values axis title
                        if (valuesAxisTitleTextBox.Enabled && IsTitleChanged(_visualEditor.ChartValuesAxisTitle, valuesAxisTitleTextBox.Text))
                            _visualEditor.ChartValuesAxisTitle = valuesAxisTitleTextBox.Text;
                    }
                    finally
                    {
                        _visualEditor.FinishEditing();
                    }
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowWarningMessage("Spreadsheet Editor Demo", ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        #endregion


        /// <summary>
        /// Checks the drawing name.
        /// </summary>
        private void CheckDrawingName()
        {
            // get the drawing name
            string name = nameTextBox.Text;

            if (name != null)
                name = name.Trim();

            // if drawing name is empty
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException(SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_THE_DRAWING_NAME_CANNOT_BE_EMPTY);
        }

        /// <summary>
        /// Returns a value indicating whether title value is changed.
        /// </summary>
        /// <param name="oldValue">Old title value.</param>
        /// <param name="newValue">New title value.</param>
        /// <returns>A value indicating whether title value is changed.</returns>
        private bool IsTitleChanged(string oldValue, string newValue)
        {
            // for title, null and empty string are equal values
            if (string.IsNullOrEmpty(oldValue) && string.IsNullOrEmpty(newValue))
                return false;

            return oldValue != newValue;
        }

        #endregion

    }
}
