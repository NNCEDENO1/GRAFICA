using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividVista.Tools
{
    public class ToolManager
    {
        private Tool currentTool;

        public void SetCurrentTool(Tool tool)
        {
            currentTool = tool;
        }

        public Tool GetCurrentTool()
        {
            return currentTool;
        }

        public void Draw(Graphics graphics, Point startPoint, Point endPoint)
        {
            currentTool?.Draw(graphics, startPoint, endPoint);
        }

        public void Fill(Bitmap bitmap, Point point, Color targetColor)
        {
            if (currentTool is FillTool fillTool)
            {
                fillTool.Fill(bitmap, point, targetColor);
            }
        }

        public Cursor GetCurrentCursor()
        {
            return currentTool?.GetCursor() ?? Cursors.Default;
        }
    }
}
