using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VividVista.Tools
{
    public class FillTool : Tool
    {
        private Color fillColor;

        public FillTool(Color fillColor)
        {
            this.fillColor = fillColor;
        }

        public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
        {
            // El método Draw no se usa para el relleno.
        }


        public void Fill(Bitmap bitmap, Point startPoint, Color targetColor)
        {
            if (bitmap.GetPixel(startPoint.X, startPoint.Y) == fillColor)
                return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(startPoint);

            while (pixels.Count > 0)
            {
                Point p = pixels.Dequeue();
                if (p.X < 0 || p.X >= bitmap.Width || p.Y < 0 || p.Y >= bitmap.Height)
                    continue;

                if (bitmap.GetPixel(p.X, p.Y) == targetColor)
                {
                    bitmap.SetPixel(p.X, p.Y, fillColor);

                    pixels.Enqueue(new Point(p.X + 1, p.Y));
                    pixels.Enqueue(new Point(p.X - 1, p.Y));
                    pixels.Enqueue(new Point(p.X, p.Y + 1));
                    pixels.Enqueue(new Point(p.X, p.Y - 1));
                }
            }
        }


        public override Cursor GetCursor()
        {
            return Cursors.Default;
        }
    }
}



        