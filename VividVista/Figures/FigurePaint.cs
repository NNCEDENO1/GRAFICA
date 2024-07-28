using System;
using System.Drawing;

namespace VividVista.Figures
{
    internal class FigurePaint : IDisposable
    {
        private Pen pen;
        private bool disposed = false;

        public FigurePaint(Color color, float width)
        {
            pen = new Pen(color, width);
        }

        public void DrawEllipse(Graphics g, Point center, Size size)
        {
            g.DrawEllipse(pen, center.X - size.Width / 2, center.Y - size.Height / 2, size.Width, size.Height);
        }

        public void DrawRectangle(Graphics g, Point topLeft, Size size)
        {
            g.DrawRectangle(pen, topLeft.X, topLeft.Y, size.Width, size.Height);
        }

        public void DrawLine(Graphics g, Point start, Point end)
        {
            g.DrawLine(pen, start, end);
        }

        public void DrawTriangle(Graphics g, Point point1, Point point2, Point point3)
        {
            Point[] points = { point1, point2, point3 };
            g.DrawPolygon(pen, points);
        }

        public void DrawPentagon(Graphics g, Point center, int size)
        {
            Point[] points = new Point[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = Math.PI / 2 + (2 * Math.PI / 5) * i;
                points[i] = new Point(
                    (int)(center.X + size * Math.Cos(angle)),
                    (int)(center.Y - size * Math.Sin(angle))
                );
            }
            g.DrawPolygon(pen, points);
        }

        public void DrawHexagon(Graphics g, Point center, int size)
        {
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 2 + (2 * Math.PI / 6) * i;
                points[i] = new Point(
                    (int)(center.X + size * Math.Cos(angle)),
                    (int)(center.Y - size * Math.Sin(angle))
                );
            }
            g.DrawPolygon(pen, points);
        }

        public void FillEllipse(Graphics g, Brush brush, Point center, Size size)
        {
            g.FillEllipse(brush, center.X - size.Width / 2, center.Y - size.Height / 2, size.Width, size.Height);
        }

        public void FillRectangle(Graphics g, Brush brush, Point topLeft, Size size)
        {
            g.FillRectangle(brush, topLeft.X, topLeft.Y, size.Width, size.Height);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    pen?.Dispose();
                }
                disposed = true;
            }
        }
    }
}