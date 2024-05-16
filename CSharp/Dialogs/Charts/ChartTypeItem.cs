namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Represents the chart type item.
    /// </summary>
    public class ChartTypeItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartTypeItem"/> class.
        /// </summary>
        /// <param name="value">The name of chart type.</param>
        public ChartTypeItem(string value)
        {
            _value = value;
        }



        string _value;
        /// <summary>
        /// Gets the name of chart type.
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
        }



        /// <summary>
        /// Returns a string that represents description of chart type.
        /// </summary>
        public override string ToString()
        {
            switch (Value)
            {
                case "Column":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_COLUMN;

                case "Line":
                    return "Line";

                case "Pie":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_PIE_ALT1;

                case "Bar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_BAR;

                case "Area":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_AREA_ALT1;

                case "Stock":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_STOCK;

                case "Scatter":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_SCATTER_ALT1;

                case "Radar":
                    return SpreadsheetEditorDemo.Localization.Strings.SPREADSHEETEDITORDEMO_RADAR_ALT1;

                default:
                    return Value;
            }
        }

    }
}
