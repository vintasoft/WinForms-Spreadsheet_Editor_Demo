using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpreadsheetEditorDemo
{
    /// <summary>
    /// Handles the painting functionality for System.Windows.Forms.ToolStrip objects.
    /// </summary>
    public class PanelToolStripRenderer : ToolStripProfessionalRenderer
    {

        /// <summary>
        /// A dictionary that binds toolstrip split buttons and their transparent icon areas.
        /// Transparent area rectangle is in icon image space.
        /// </summary>
        Dictionary<ToolStripSplitButton, Rectangle> _buttonsTransparentAreas;



        /// <summary>
        /// Initializes a new instance of the <see cref="PanelToolStripRenderer"/> class.
        /// </summary>
        /// <param name="buttonsTransparentAreas">A dictionary that binds toolstrip split buttons and their transparent icon areas.</param>
        public PanelToolStripRenderer(Dictionary<ToolStripSplitButton, Rectangle> buttonsTransparentAreas)
        {
            _buttonsTransparentAreas = buttonsTransparentAreas;
        }



        /// <summary>
        /// Raises the System.Windows.Forms.ToolStripRenderer.RenderItemImage event.
        /// </summary>
        /// <param name="e">A System.Windows.Forms.ToolStripItemImageRenderEventArgs that contains the event data.</param>
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            base.OnRenderItemImage(e);

            ToolStripSplitButton button = e.Item as ToolStripSplitButton;

            if (button != null && button.Enabled && button.BackColor != Color.Transparent)
            {
                SolidBrush brush = new SolidBrush(button.BackColor);
                // calculate an offset of icon from button bounds
                Rectangle buttonRect = button.ButtonBounds;
                Rectangle iconRect = new Rectangle(new Point(0, 0), button.Image.Size);
                int offsetX = (buttonRect.Width - iconRect.Width) / 2;
                int offsetY = (buttonRect.Height - iconRect.Height) / 2;

                // add offset to transparent area rectangle
                Rectangle areaRect = _buttonsTransparentAreas[button];
                Rectangle fillRect = new Rectangle(areaRect.X + offsetX, areaRect.Y + offsetY, areaRect.Width, areaRect.Height);

                // fill the transparent area
                e.Graphics.FillRectangle(brush, fillRect);
            }
        }

    }
}
