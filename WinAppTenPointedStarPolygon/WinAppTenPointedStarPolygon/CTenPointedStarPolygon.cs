using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppTenPointedStarPolygon
{
    class CTenPointedStarPolygon
    {
        private PictureBox pictureBox;
        private int starSize;
        private int starWidth;
        private int starHeight;
        private Color[] colors;

        public CTenPointedStarPolygon(PictureBox pictureBox, int starSize)
        {
            this.pictureBox = pictureBox;
            this.starSize = starSize;
            this.colors = new Color[] { Color.Red, Color.Green, Color.Blue };
        }

        public void SetStarSize(int size)
        {
            starSize = size; // Establece el tamaño de la estrella
        }

        public void DrawStar()
        {
            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;

            Point[] starPoints = CalculateStarPoints(centerX, centerY, starSize);
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(Color.White);

            // Crear un array de colores para el relleno
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple, Color.Cyan, Color.Magenta };

            // Dibujar el relleno multicolor
            for (int i = 0; i < starPoints.Length; i += 2)
            {
                using (Brush brush = new SolidBrush(colors[(i / 2) % colors.Length]))
                {
                    Point[] fillPoints = { starPoints[i], starPoints[i + 1], starPoints[(i + 2) % starPoints.Length] };
                    graphics.FillPolygon(brush, fillPoints);
                }
            }

            // Dibujar el contorno de la estrella
            using (Pen pen = new Pen(Color.Black, 2))
            {
                graphics.DrawPolygon(pen, starPoints);
            }

            // Dibujar líneas desde el centro a cada vértice
            for (int i = 0; i < starPoints.Length; i++)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    graphics.DrawLine(pen, new Point(centerX, centerY), starPoints[i]);
                }
            }
        }

        public void SetStarColors(Color[] newColors)
        {
            colors = newColors; // Actualiza los colores
        }

        private Point[] CalculateStarPoints(int centerX, int centerY, int starSize)
        {
            Point[] starPoints = new Point[16];

            double outerRadius = starSize / 2.0 * 10;
            double innerRadius = outerRadius * 0.4;

            double angle = Math.PI / 4; // 45 grados

            for (int i = 0; i < 8; i++)
            {
                double currentAngle = i * angle;
                double x = centerX + outerRadius * Math.Cos(currentAngle);
                double y = centerY + outerRadius * Math.Sin(currentAngle);
                starPoints[2 * i] = new Point((int)x, (int)y);

                currentAngle += angle / 2;
                x = centerX + innerRadius * Math.Cos(currentAngle);
                y = centerY + innerRadius * Math.Sin(currentAngle);
                starPoints[2 * i + 1] = new Point((int)x, (int)y);
            }

            return starPoints;
        }
        
    }
}



