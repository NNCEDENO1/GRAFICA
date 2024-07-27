using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using VividVista.Properties;
using VividVista.Tools;


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

        public MainWindow()
        {
            InitializeComponent();
            InitializeDrawingBitmap();
            toolManager = new ToolManager();

            cursorPositionTimer = new Timer();
            cursorPositionTimer.Interval = 1;
            cursorPositionTimer.Tick += CursorPositionTimer_Tick;
            cursorPositionTimer.Start();

            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

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
            if (pencilSelected && e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }


        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (toolManager == null)
            {
                MessageBox.Show("ToolManager no está inicializado.");
                return;
            }

            if (isDrawing && drawingBitmap != null && toolManager.GetCurrentTool() != null)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    toolManager.Draw(g, lastPoint, e.Location);
                }
                picCanvas.Invalidate(); // Asegúrate de que el canvas se vuelva a dibujar
                lastPoint = e.Location;
            }
        }






        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
            }
        }

        private void PencilBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new Pencil(Color.Black, 1f));
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            pencilSelected = true;
        }

        private void FillBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new FillTool(Color.Red)); // Puedes cambiar el color según tu necesidad
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            pencilSelected = false;
        }
        private void eraserBox_Click(object sender, EventArgs e)
        {
            if (toolManager == null)
            {
                toolManager = new ToolManager();
            }

            toolManager.SetCurrentTool(new Eraser(10f));
            picCanvas.Cursor = toolManager.GetCurrentCursor();
            pencilSelected = false;
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

        }
    }
}
