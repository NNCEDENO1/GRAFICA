using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using VividVista.Properties;
using VividVista.Tools;
using VividVista.Figures;
using System.Drawing.Imaging;
using VividVista.Brushes;



namespace VividVista
{
    public partial class MainWindow : Form
    {
        private ToolManager toolManager;
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Bitmap drawingBitmap;
        private bool pencilSelected = false;
        private Timer cursorPositionTimer;
        private FigurePaint figures;
        private string shapeType;
        private BrushDraw brushes;
        private string currentBrush;
        private string currentTool;



        public MainWindow()
        {
            InitializeComponent();
            InitializeDrawingBitmap();
            toolManager = new ToolManager();
            figures = new FigurePaint(Color.Black, 1f);
            brushes = new BrushDraw();

            cursorPositionTimer = new Timer();
            cursorPositionTimer.Interval = 1;
            cursorPositionTimer.Tick += CursorPositionTimer_Tick;
            cursorPositionTimer.Start();

            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;
            picCanvas.Paint += PicCanvas_Paint;

           


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - picCanvas.Width) / 2;
            int y = (this.ClientSize.Height - picCanvas.Height) / 2;
            picCanvas.Location = new Point(x, y);
        }

        private void InitializeDrawingBitmap()
        {
            if (picCanvas.Width > 0 && picCanvas.Height > 0)
            {
                drawingBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
                picCanvas.Image = drawingBitmap;
            }
            else
            {
                MessageBox.Show("El tamaño del canvas es inválido.");
            }
        }   

        private void CursorPositionTimer_Tick(object sender, EventArgs e)
        {
            var clientPoint = this.PointToClient(Cursor.Position);
            lblCursorPosition.Text = $"{clientPoint.X}, {clientPoint.Y}px";
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;

                if (toolManager.GetCurrentTool() is TextTool textTool)
                {
                    textTool.CreateTextBox(picCanvas, e.Location); // Crea un TextBox para el texto
                }
            }
        }

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && drawingBitmap != null)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    if (currentTool == "Pencil")
                    {
                        toolManager.Draw(g, lastPoint, e.Location);
                    }
                    else if (currentTool == "Eraser")
                    {
                        using (Brush brush = new SolidBrush(picCanvas.BackColor))
                        {
                            g.FillRectangle(brush, e.X, e.Y, 10, 10); // Ajusta el tamaño según sea necesario
                        }
                    }
                    else
                    {
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
                                brushes.DrawBrush(g, lastPoint, e.Location);
                                break;
                        }
                    }
                }
                lastPoint = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                DrawShape(drawingBitmap, lastPoint, e.Location); // Dibuja la figura en el bitmap
                picCanvas.Invalidate(); // Refresca el canvas
            }
        }

        private void DrawShape(Bitmap bitmap, Point startPoint, Point endPoint)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                switch (shapeType)
                {
                    case "Ellipse":
                        figures.DrawEllipse(g, new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2), new Size(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y)));
                        break;
                    case "Rectangle":
                        figures.DrawRectangle(g, new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y)), new Size(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y)));
                        break;
                    case "Triangle":
                        Point point1 = new Point(startPoint.X, endPoint.Y);
                        Point point2 = new Point(endPoint.X, endPoint.Y);
                        Point point3 = new Point((startPoint.X + endPoint.X) / 2, startPoint.Y);
                        figures.DrawTriangle(g, point1, point2, point3);
                        break;
                    case "Pentagon":
                        figures.DrawPentagon(g, new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2), Math.Abs(endPoint.X - startPoint.X) / 2);
                        break;
                    case "Hexagon":
                        figures.DrawHexagon(g, new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2), Math.Abs(endPoint.X - startPoint.X) / 2);
                        break;
                    case "Line":
                        figures.DrawLine(g, startPoint, endPoint);
                        break;
                }
            }
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, Point.Empty); // Dibuja el bitmap en el canvas
        }


        private void PencilBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new Pencil(Color.Black, 1f));
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            currentTool = "Pencil";
            currentBrush = null;
        }

        private void FillBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new FillTool(Color.Red)); // Puedes cambiar el color según tu necesidad
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            currentTool = null;
            currentBrush = null;
        }
        private void eraserBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new Eraser(10f));
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            currentTool = "Eraser";
            currentBrush = null;
        }



        private Point set_point(PictureBox pic, Point pt)
        {
            float xRatio = 1f * pic.Image.Width / pic.Width;
            float yRatio = 1f * pic.Image.Height / pic.Height;
            return new Point((int)(pt.X * xRatio), (int)(pt.Y * yRatio));
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            shapeType = "Pentagon";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            Font defaultFont = new Font("Arial", 12);
            Color defaultColor = Color.Black;
            toolManager.SetCurrentTool(new TextTool(defaultFont, defaultColor));
            picCanvas.Cursor = toolManager.GetCurrentCursor();
        }
    

    private void DrawLineBox_Click(object sender, EventArgs e)
        {
            shapeType = "Line";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void DrawEllipseBox_Click(object sender, EventArgs e)
        {
            shapeType = "Ellipse";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void DrawRectangleBox_Click(object sender, EventArgs e)
        {
            shapeType = "Rectangle";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void DrawTriangleBox_Click(object sender, EventArgs e)
        {
            shapeType = "Triangle";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void DrawHexagonBox_Click(object sender, EventArgs e)
        {
            shapeType = "Hexagon";
            picCanvas.Cursor = Cursors.Cross;
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage("png");
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage("jpg");
        }
        private void SaveImage(string format)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = format == "png" ? "PNG Image|*.png" : "JPEG Image|*.jpg";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "drawing";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imgFormat = format == "png" ? ImageFormat.Png : ImageFormat.Jpeg;
                    drawingBitmap.Save(saveFileDialog.FileName, imgFormat);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
                    }

        private void pincelBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Pincel";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void caligraficoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Caligrafia";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void aerografoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Aerografo";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void oleoBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Oleo";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void crayonBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Crayon";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void marcadorBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Marcador";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void lapizPincelBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Lapiz";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }

        private void acuarelaBox_Click(object sender, EventArgs e)
        {
            currentBrush = "Acuarela";
            picCanvas.Cursor = Cursors.Cross;
            currentTool = null;
        }
    }
}
    
