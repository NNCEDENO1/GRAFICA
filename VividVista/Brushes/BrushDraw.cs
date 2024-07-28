using System;
using System.Drawing;

namespace VividVista.Brushes
{
    internal class BrushDraw
    {
        public void DrawOilBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 10f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawAirBrush(Graphics g, Point start, Point end)
        {
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                for (int i = 0; i < 10; i++)
                {
                    int offsetX = new Random().Next(-5, 5);
                    int offsetY = new Random().Next(-5, 5);
                    g.FillEllipse(brush, end.X + offsetX, end.Y + offsetY, 2, 2);
                }
            }
        }

        public void DrawWaterColorBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.FromArgb(128, Color.Black), 5f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawCrayonBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 2f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawMarkerBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 15f) { StartCap = System.Drawing.Drawing2D.LineCap.Flat, EndCap = System.Drawing.Drawing2D.LineCap.Flat })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawCalligraphyBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 5f) { StartCap = System.Drawing.Drawing2D.LineCap.Flat, EndCap = System.Drawing.Drawing2D.LineCap.Flat, Alignment = System.Drawing.Drawing2D.PenAlignment.Inset })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawPencilBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 1f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round })
            {
                g.DrawLine(pen, start, end);
            }
        }

        public void DrawBrush(Graphics g, Point start, Point end)
        {
            using (Pen pen = new Pen(Color.Black, 5f) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round })
            {
                g.DrawLine(pen, start, end);
            }
        }
    }
}
