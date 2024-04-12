namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Represents the chart subtype item.
    /// </summary>
    public class ChartSubtypeItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSubtypeItem"/> class.
        /// </summary>
        /// <param name="value">The name of chart subtype.</param>
        public ChartSubtypeItem(string value)
        {
            _value = value;
        }



        string _value;
        /// <summary>
        /// Gets the name of chart subtype.
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
        }



        /// <summary>
        /// Returns a string that represents description of chart subtype.
        /// </summary>
        public override string ToString()
        {
            switch (Value)
            {
                case "Clustered_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CLUSTERED_COLUMN;

                case "Stacked_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_COLUMN;

                case "100%_Stacked_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_COLUMN;

                case "3D_Clustered_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_3D_CLUSTERED_COLUMN;

                case "3D_Stacked_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_3D_STACKED_COLUMN;

                case "3D_100%_Stacked_Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_3D_100_STACKED_COLUMN;

                case "Line":
                    return "Line";

                case "Stacked_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_LINE;

                case "100%_Stacked_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_LINE;

                case "Line_With_Markers":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_LINE_WITH_MARKERS;

                case "Stacked_Line_With_Markers":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_LINE_WITH_MARKERS;

                case "100%_Stacked_Line_With_Mar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_LINE_WITH_MARKERS;

                case "Curved_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURVED_LINE;

                case "Stacked_Curved_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_CURVED_LINE;

                case "100%_Stacked_Curved_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_CURVED_LINE;

                case "Curved_Line_With_Markers":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CURVED_LINE_WITH_MARKERS;

                case "Stacked_CurvLine_With_Mark":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_CURVED_LINE_WITH_MARKERS;

                case "100%_Stacked_CurvLineMark":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_CURVED_LINE_WITH_MARKERS;

                case "3D_Line":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_3D_LINE;

                case "Pie":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PIE;

                case "Pie_Explosion":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PIE_EXPLOSION;

                case "Doughnut":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_DOUGHNUT;

                case "Clustered_Bar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_CLUSTERED_BAR;

                case "Stacked_Bar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_BAR;

                case "100%_Stacked_Bar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_BAR;

                case "Area":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_AREA;

                case "Stacked_Area":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STACKED_AREA;

                case "100%_Stacked_Area":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_100_STACKED_AREA;

                default:
                    return Value;
            }
        }

    }
}
