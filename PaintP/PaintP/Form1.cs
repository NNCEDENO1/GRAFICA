using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PaintP
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Point lastPoint; // Punto anterior
        BrushDraw brushes = new BrushDraw(); // Instancia de BrushDraw
        string currentBrush = ""; // Pincel actual
        string currentTool = ""; // Herramienta actual
        Color currentColor = Color.Black;

        
        public Form1()
        {
            InitializeComponent();

            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            p = new Pen(Color.Black, 1);
            erase = new Pen(Color.White, 10);

            this.Resize += new EventHandler(Form1_Resize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Ajusta el tamaño del PictureBox
            pic.Width = this.ClientSize.Width - 20; // Ajusta según el borde
            pic.Height = this.ClientSize.Height - 100; // Ajusta según la barra de menú y otros controles

            // Ajustar otros controles si es necesario
            btn_color.Location = new Point(10, this.ClientSize.Height - 60);
            btn_fill.Location = new Point(100, this.ClientSize.Height - 60);
            btn_save.Location = new Point(190, this.ClientSize.Height - 60);
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
           
            paint = true;
            lastPoint = e.Location;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                // Obtener el objeto Graphics del Bitmap
                using (Graphics g = Graphics.FromImage(bm))
                {
                    // Seleccionar la herramienta de dibujo
                    if (index == 1) // Lápiz
                    {
                        g.DrawLine(p, lastPoint, e.Location);
                        lastPoint = e.Location; // Actualizar la última posición
                    }
                    else if (index == 2) // Borrador
                    {
                        g.DrawLine(erase, lastPoint, e.Location);
                        lastPoint = e.Location; // Actualizar la última posición
                    }
                    else if (!string.IsNullOrEmpty(currentBrush))
                    {
                        // Dibuja con el pincel seleccionado
                        switch (currentBrush)
                        {
                            case "Oleo":
                                brushes.DrawOilBrush(g, lastPoint, e.Location);
                                break;
                            case "Aerografo":
                                brushes.DrawAirBrush(g, lastPoint, e.Location);
                                break;
                            case "Acuarela":
                                brushes.DrawWaterColorBrush(g, lastPoint, e.Location);
                                break;
                            case "Crayon":
                                brushes.DrawCrayonBrush(g, lastPoint, e.Location);
                                break;
                            case "Marcador":
                                brushes.DrawMarkerBrush(g, lastPoint, e.Location);
                                break;
                            case "Caligrafia":
                                brushes.DrawCalligraphyBrush(g, lastPoint, e.Location);
                                break;
                            case "Lapiz":
                                brushes.DrawPencilBrush(g, lastPoint, e.Location);
                                break;
                        }
                        lastPoint = e.Location; // Actualizar la última posición
                    }
                }

                // Actualizar el PictureBox
                pic.Invalidate();
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false; // Dejar de pintar

            // Actualizar el bitmap con la última línea dibujada
            using (Graphics g = Graphics.FromImage(bm))
            {
                if (index == 1) // Lápiz
                {
                    g.DrawLine(p, lastPoint, e.Location);
                }
                else if (index == 2) // Borrador
                {
                    g.DrawLine(erase, lastPoint, e.Location);
                }
                else // Dibujo de formas
                {
                    int width = e.X - lastPoint.X;
                    int height = e.Y - lastPoint.Y;

                    switch (index)
                    {
                        case 3: // Elipse
                            g.DrawEllipse(p, lastPoint.X, lastPoint.Y, width, height);
                            break;
                        case 4: // Rectángulo
                            g.DrawRectangle(p, lastPoint.X, lastPoint.Y, width, height);
                            break;
                        case 5: // Línea
                            g.DrawLine(p, lastPoint, e.Location);
                            break;
                        case 6: // Triángulo
                            DrawTriangle(g, p, lastPoint.X, lastPoint.Y, width, height);
                            break;
                        case 7: // Estrella
                            DrawStar(g, p, lastPoint.X, lastPoint.Y, Math.Max(width, height) / 2);
                            break;
                        case 8: // Corazón
                            DrawHeart(g, p, lastPoint.X, lastPoint.Y, Math.Max(width, height) / 2);
                            break;
                        case 9: // Pentágono
                            DrawPentagon(g, p, lastPoint.X, lastPoint.Y, Math.Max(width, height) / 2);
                            break;
                        case 10: // Hexágono
                            DrawHexagon(g, p, lastPoint.X, lastPoint.Y, Math.Max(width, height) / 2);
                            break;
                        case 11: // Flecha hacia arriba
                            DrawArrow(g, p, lastPoint.X, lastPoint.Y, true);
                            break;
                        case 12: // Flecha hacia abajo
                            DrawArrow(g, p, lastPoint.X, lastPoint.Y, false);
                            break;
                        case 13: // Flecha hacia la derecha
                            DrawArrow(g, p, lastPoint.X, lastPoint.Y, true, false);
                            break;
                        case 14: // Flecha hacia la izquierda
                            DrawArrow(g, p, lastPoint.X, lastPoint.Y, false, false);
                            break;
                    }
                }
            }

            pic.Refresh(); // Refrescar para actualizar el PictureBox
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                pic_color.BackColor = new_color;
                p.Color = new_color; // Cambiar el color del lápiz
            }
        }

        private void DrawTriangle(Graphics g, Pen pen, int x, int y, int width, int height)
        {
            Point[] points = {
                new Point(x, y),
                new Point(x + width, y),
                new Point(x + width / 2, y - height)
            };
            g.DrawPolygon(pen, points);
        }

        private void DrawStar(Graphics g, Pen pen, int x, int y, int size)
        {
            Point[] points = new Point[10];
            double angle = Math.PI / 5; // 36 degrees
            for (int i = 0; i < 10; i++)
            {
                int radius = (i % 2 == 0) ? size : size / 2;
                points[i] = new Point(
                    (int)(x + radius * Math.Cos(i * angle)),
                    (int)(y - radius * Math.Sin(i * angle))
                );
            }
            g.DrawPolygon(pen, points);
        }

        private void DrawHeart(Graphics g, Pen pen, int x, int y, int size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y, x - size / 2, y - size / 2, x - size / 2, y + size / 2, x, y + size);
            path.AddBezier(x, y + size, x + size / 2, y + size / 2, x + size / 2, y - size / 2, x, y);
            g.DrawPath(pen, path);
        }

        private void DrawPentagon(Graphics g, Pen pen, int x, int y, int size)
        {
            Point[] points = new Point[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = 2 * Math.PI / 5 * i - Math.PI / 2; // Start at the top
                points[i] = new Point(
                    (int)(x + size * Math.Cos(angle)),
                    (int)(y + size * Math.Sin(angle))
                );
            }
            g.DrawPolygon(pen, points);
        }
        private void DrawHexagon(Graphics g, Pen pen, int x, int y, int size)
        {
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = 2 * Math.PI / 6 * i - Math.PI / 2; // Start at the top
                points[i] = new Point(
                    (int)(x + size * Math.Cos(angle)),
                    (int)(y + size * Math.Sin(angle))
                );
            }
            g.DrawPolygon(pen, points);
        }

        private void DrawArrow(Graphics g, Pen pen, int x, int y, bool up = true, bool horizontal = true)
        {
            if (up)
            {
                g.DrawLine(pen, x, y, x, y - 20); // Flecha hacia arriba
                g.DrawLine(pen, x - 5, y - 15, x, y - 20);
                g.DrawLine(pen, x + 5, y - 15, x, y - 20);
            }
            else if (!up && horizontal)
            {
                g.DrawLine(pen, x, y, x + 20, y); // Flecha hacia la derecha
                g.DrawLine(pen, x + 15, y - 5, x + 20, y);
                g.DrawLine(pen, x + 15, y + 5, x + 20, y);
            }
            else if (!up && !horizontal)
            {
                g.DrawLine(pen, x, y, x, y + 20); // Flecha hacia abajo
                g.DrawLine(pen, x - 5, y + 15, x, y + 20);
                g.DrawLine(pen, x + 5, y + 15, x, y + 20);
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e) => index = 1;

        private void button1_Click(object sender, EventArgs e) // Clear
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
            pic.Refresh();
        }

        private void btn_eraser_Click(object sender, EventArgs e) => index = 2;
        private void btn_ellipse_Click(object sender, EventArgs e) => index = 3;
        private void btn_rect_Click(object sender, EventArgs e) => index = 4;
        private void btn_Line_Click(object sender, EventArgs e) => index = 5;
        private void btn_triangle_Click(object sender, EventArgs e) => index = 6;
        private void btn_star_Click(object sender, EventArgs e) => index = 7;
        private void btn_heart_Click(object sender, EventArgs e) => index = 8;
        private void btn_pentagon_Click(object sender, EventArgs e) => index = 9;
        private void btn_hexagon_Click(object sender, EventArgs e) => index = 10;
        private void btn_arrow_up_Click(object sender, EventArgs e) => index = 11;
        private void btn_arrow_down_Click(object sender, EventArgs e) => index = 12;
        private void btn_arrow_right_Click(object sender, EventArgs e) => index = 13;
        private void btn_arrow_left_Click(object sender, EventArgs e) => index = 14;

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                if (index == 3) // Ellipse
                {
                    e.Graphics.DrawEllipse(p, cX, cY, sX, sY);
                }
                else if (index == 4) // Rectangle
                {
                    e.Graphics.DrawRectangle(p, cX, cY, sX, sY);
                }
                else if (index == 5) // Line
                {
                    e.Graphics.DrawLine(p, cX, cY, x, y);
                }
            }
        }



        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void DisableFontControls()
        {
            // Implementa la lógica para deshabilitar controles relacionados con fuentes, si es necesario
        }

        private void pincelBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Pincel";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void caligraficoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Caligrafia";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void aerografoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Aerografo";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void oleoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Oleo";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void crayonBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Crayon";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void marcadorBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Marcador";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void lapizPincelBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Lapiz";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void acuarelaBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Acuarela";
            pic.Cursor = Cursors.Cross;
            currentTool = null;
            DisableFontControls();
        }

        private void color_picker_Click(object sender, EventArgs e)
        {

        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = new_color;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            if (old_color == new_clr) return;

            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);

            while (pixel.Count > 0)
            {
                Point pt = pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7) // Fill
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
                pic.Refresh(); // Refresh to update the PictureBox
            }
        }

        private void btn_fill_Click(object sender, EventArgs e) => index = 7;

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image (*.png)|*.png|Image (*.jpg)|*.jpg|All files (*.*)|*.*"; // Filtro para PNG y JPG
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);

                // Guardar en el formato seleccionado
                if (sfd.FileName.EndsWith(".png"))
                {
                    btm.Save(sfd.FileName, ImageFormat.Png); // Guardar como PNG
                }
                else if (sfd.FileName.EndsWith(".jpg"))
                {
                    btm.Save(sfd.FileName, ImageFormat.Jpeg); // Guardar como JPG
                }

                MessageBox.Show("Su imagen ha sido guardada exitosamente");
            }
        }



    }
}

