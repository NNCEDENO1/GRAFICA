using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividVista.Tools
{
    public class Eraser : Tool
    {
        private Pen mPen;

        public Eraser(float width)
        {
            // Usamos el color blanco 
            mPen = new Pen(Color.White, width);
        }

        public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
        {
            graphics.DrawLine(mPen, startPoint, endPoint);
        }

        public override Cursor GetCursor()
        {
            return Cursors.Cross;
        }

        public void SetWidth(float width)
        {
            mPen.Width = width;
        }
    }
}