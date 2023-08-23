using System;

using Vintasoft.Imaging.Office.Spreadsheet.Document;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Represents the <see cref="CellBorderStyle"/> enum value and it's string value.
    /// </summary>
    public class CellBorderStyleItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CellBorderStyleItem"/> class.
        /// </summary>
        /// <param name="borderStyle">The <see cref="CellBorderStyle"/> enum value.</param>
        public CellBorderStyleItem(CellBorderStyle borderStyle)
        {
            _cellBorderStyle = borderStyle;
        }



        CellBorderStyle _cellBorderStyle;
        /// <summary>
        /// Gets the cell border style.
        /// </summary>
        public CellBorderStyle CellBorderStyle
        {
            get
            {
                return _cellBorderStyle;
            }
        }



        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            switch (CellBorderStyle)
            {
                case CellBorderStyle.Hair:
                    return "Hair";
                case CellBorderStyle.Dotted:
                    return "Dotted";
                case CellBorderStyle.DashDotDot:
                    return "Dash Dot Dot";
                case CellBorderStyle.DashDot:
                    return "Dash Dot";
                case CellBorderStyle.Dashed:
                    return "Dashed";
                case CellBorderStyle.Thin:
                    return "Thin";
                case CellBorderStyle.MediumDashDotDot:
                    return "Medium Dash Dot Dot";
                case CellBorderStyle.MediumDashDot:
                    return "Medium Dash Dot";
                case CellBorderStyle.MediumDashed:
                    return "Medium Dashed";
                case CellBorderStyle.Medium:
                    return "Medium";
                case CellBorderStyle.Thick:
                    return "Thick";
                case CellBorderStyle.Double:
                    return "Double";
                case CellBorderStyle.None:
                    return "None";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
