namespace VividVista
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Libera recursos administrados aquí
                if (drawingBitmap != null)
                {
                    drawingBitmap.Dispose();
                    drawingBitmap = null;
                }
                if (cursorPositionTimer != null)
                {
                    cursorPositionTimer.Dispose();
                    cursorPositionTimer = null;
                }
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSlection = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.zoomBox = new System.Windows.Forms.PictureBox();
            this.goteroBox = new System.Windows.Forms.PictureBox();
            this.eraserBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.PictureBox();
            this.fillBox = new System.Windows.Forms.PictureBox();
            this.pencilBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oleoBox = new System.Windows.Forms.PictureBox();
            this.lapizPincelBox = new System.Windows.Forms.PictureBox();
            this.acuarelaBox = new System.Windows.Forms.PictureBox();
            this.crayonBox = new System.Windows.Forms.PictureBox();
            this.marcadorBox = new System.Windows.Forms.PictureBox();
            this.aerografoBox = new System.Windows.Forms.PictureBox();
            this.caligraficoBox = new System.Windows.Forms.PictureBox();
            this.pincelBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.DrawHexagonBox = new System.Windows.Forms.PictureBox();
            this.DrawPentagonBox = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.DrawTriangleBox = new System.Windows.Forms.PictureBox();
            this.DrawIrregularBox = new System.Windows.Forms.PictureBox();
            this.DrawRectangleBox = new System.Windows.Forms.PictureBox();
            this.DrawEllipseBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DrawLineBox = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCursorPosition = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CoordinatesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.cmbFontText = new System.Windows.Forms.ComboBox();
            this.cmbSizeText = new System.Windows.Forms.ComboBox();
            this.picBold = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picItalics = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSlection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goteroBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oleoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapizPincelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acuarelaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crayonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aerografoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caligraficoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincelBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawHexagonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPentagonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawTriangleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawIrregularBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawRectangleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawEllipseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLineBox)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBold)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItalics)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.grpSlection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpTools, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1425, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpSlection
            // 
            this.grpSlection.Controls.Add(this.pictureBox2);
            this.grpSlection.Location = new System.Drawing.Point(2, 2);
            this.grpSlection.Margin = new System.Windows.Forms.Padding(2);
            this.grpSlection.Name = "grpSlection";
            this.grpSlection.Padding = new System.Windows.Forms.Padding(2);
            this.grpSlection.Size = new System.Drawing.Size(76, 118);
            this.grpSlection.TabIndex = 7;
            this.grpSlection.TabStop = false;
            this.grpSlection.Text = "Selection";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 71);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // grpImage
            // 
            this.grpImage.Location = new System.Drawing.Point(83, 2);
            this.grpImage.Margin = new System.Windows.Forms.Padding(2);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(2);
            this.grpImage.Size = new System.Drawing.Size(140, 118);
            this.grpImage.TabIndex = 8;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Image";
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.zoomBox);
            this.grpTools.Controls.Add(this.goteroBox);
            this.grpTools.Controls.Add(this.eraserBox);
            this.grpTools.Controls.Add(this.textBox);
            this.grpTools.Controls.Add(this.fillBox);
            this.grpTools.Controls.Add(this.pencilBox);
            this.grpTools.Location = new System.Drawing.Point(228, 2);
            this.grpTools.Margin = new System.Windows.Forms.Padding(2);
            this.grpTools.Name = "grpTools";
            this.grpTools.Padding = new System.Windows.Forms.Padding(2);
            this.grpTools.Size = new System.Drawing.Size(144, 118);
            this.grpTools.TabIndex = 9;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Tools";
            // 
            // zoomBox
            // 
            this.zoomBox.BackColor = System.Drawing.Color.White;
            this.zoomBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomBox.Image = ((System.Drawing.Image)(resources.GetObject("zoomBox.Image")));
            this.zoomBox.Location = new System.Drawing.Point(99, 63);
            this.zoomBox.Margin = new System.Windows.Forms.Padding(2);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(43, 41);
            this.zoomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoomBox.TabIndex = 5;
            this.zoomBox.TabStop = false;
            // 
            // goteroBox
            // 
            this.goteroBox.BackColor = System.Drawing.Color.White;
            this.goteroBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goteroBox.BackgroundImage")));
            this.goteroBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goteroBox.Location = new System.Drawing.Point(52, 63);
            this.goteroBox.Margin = new System.Windows.Forms.Padding(2);
            this.goteroBox.Name = "goteroBox";
            this.goteroBox.Size = new System.Drawing.Size(43, 41);
            this.goteroBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goteroBox.TabIndex = 4;
            this.goteroBox.TabStop = false;
            this.goteroBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // eraserBox
            // 
            this.eraserBox.BackColor = System.Drawing.Color.White;
            this.eraserBox.Image = ((System.Drawing.Image)(resources.GetObject("eraserBox.Image")));
            this.eraserBox.Location = new System.Drawing.Point(4, 63);
            this.eraserBox.Margin = new System.Windows.Forms.Padding(2);
            this.eraserBox.Name = "eraserBox";
            this.eraserBox.Size = new System.Drawing.Size(43, 41);
            this.eraserBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraserBox.TabIndex = 3;
            this.eraserBox.TabStop = false;
            this.eraserBox.Click += new System.EventHandler(this.eraserBox_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Image = global::VividVista.Properties.Resources.icons8_add_text_501;
            this.textBox.Location = new System.Drawing.Point(99, 17);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(43, 41);
            this.textBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.textBox.TabIndex = 2;
            this.textBox.TabStop = false;
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            // 
            // fillBox
            // 
            this.fillBox.BackColor = System.Drawing.Color.White;
            this.fillBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillBox.BackgroundImage")));
            this.fillBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fillBox.Location = new System.Drawing.Point(52, 17);
            this.fillBox.Margin = new System.Windows.Forms.Padding(0);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(43, 41);
            this.fillBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fillBox.TabIndex = 1;
            this.fillBox.TabStop = false;
            this.fillBox.Click += new System.EventHandler(this.FillBox_Click);
            // 
            // pencilBox
            // 
            this.pencilBox.BackColor = System.Drawing.Color.White;
            this.pencilBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencilBox.BackgroundImage")));
            this.pencilBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencilBox.Location = new System.Drawing.Point(4, 17);
            this.pencilBox.Margin = new System.Windows.Forms.Padding(2);
            this.pencilBox.Name = "pencilBox";
            this.pencilBox.Size = new System.Drawing.Size(43, 41);
            this.pencilBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pencilBox.TabIndex = 0;
            this.pencilBox.TabStop = false;
            this.pencilBox.Click += new System.EventHandler(this.PencilBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oleoBox);
            this.groupBox1.Controls.Add(this.lapizPincelBox);
            this.groupBox1.Controls.Add(this.acuarelaBox);
            this.groupBox1.Controls.Add(this.crayonBox);
            this.groupBox1.Controls.Add(this.marcadorBox);
            this.groupBox1.Controls.Add(this.aerografoBox);
            this.groupBox1.Controls.Add(this.caligraficoBox);
            this.groupBox1.Controls.Add(this.pincelBox);
            this.groupBox1.Location = new System.Drawing.Point(376, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(72, 118);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brushes";
            // 
            // oleoBox
            // 
            this.oleoBox.BackColor = System.Drawing.Color.White;
            this.oleoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oleoBox.BackgroundImage")));
            this.oleoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oleoBox.Location = new System.Drawing.Point(39, 45);
            this.oleoBox.Name = "oleoBox";
            this.oleoBox.Size = new System.Drawing.Size(24, 21);
            this.oleoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oleoBox.TabIndex = 30;
            this.oleoBox.TabStop = false;
            this.oleoBox.Click += new System.EventHandler(this.oleoBox_Click);
            // 
            // lapizPincelBox
            // 
            this.lapizPincelBox.BackColor = System.Drawing.Color.White;
            this.lapizPincelBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lapizPincelBox.BackgroundImage")));
            this.lapizPincelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lapizPincelBox.Location = new System.Drawing.Point(5, 95);
            this.lapizPincelBox.Name = "lapizPincelBox";
            this.lapizPincelBox.Size = new System.Drawing.Size(24, 21);
            this.lapizPincelBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lapizPincelBox.TabIndex = 29;
            this.lapizPincelBox.TabStop = false;
            this.lapizPincelBox.Click += new System.EventHandler(this.lapizPincelBox_Click);
            // 
            // acuarelaBox
            // 
            this.acuarelaBox.BackColor = System.Drawing.Color.White;
            this.acuarelaBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acuarelaBox.BackgroundImage")));
            this.acuarelaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acuarelaBox.Location = new System.Drawing.Point(39, 95);
            this.acuarelaBox.Name = "acuarelaBox";
            this.acuarelaBox.Size = new System.Drawing.Size(24, 21);
            this.acuarelaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acuarelaBox.TabIndex = 28;
            this.acuarelaBox.TabStop = false;
            this.acuarelaBox.Click += new System.EventHandler(this.acuarelaBox_Click);
            // 
            // crayonBox
            // 
            this.crayonBox.BackColor = System.Drawing.Color.White;
            this.crayonBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crayonBox.BackgroundImage")));
            this.crayonBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crayonBox.Location = new System.Drawing.Point(5, 68);
            this.crayonBox.Name = "crayonBox";
            this.crayonBox.Size = new System.Drawing.Size(24, 21);
            this.crayonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crayonBox.TabIndex = 27;
            this.crayonBox.TabStop = false;
            this.crayonBox.Click += new System.EventHandler(this.crayonBox_Click);
            // 
            // marcadorBox
            // 
            this.marcadorBox.BackColor = System.Drawing.Color.White;
            this.marcadorBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("marcadorBox.BackgroundImage")));
            this.marcadorBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.marcadorBox.Location = new System.Drawing.Point(39, 68);
            this.marcadorBox.Name = "marcadorBox";
            this.marcadorBox.Size = new System.Drawing.Size(24, 21);
            this.marcadorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.marcadorBox.TabIndex = 26;
            this.marcadorBox.TabStop = false;
            this.marcadorBox.Click += new System.EventHandler(this.marcadorBox_Click);
            // 
            // aerografoBox
            // 
            this.aerografoBox.BackColor = System.Drawing.Color.White;
            this.aerografoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aerografoBox.BackgroundImage")));
            this.aerografoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aerografoBox.Location = new System.Drawing.Point(5, 45);
            this.aerografoBox.Name = "aerografoBox";
            this.aerografoBox.Size = new System.Drawing.Size(24, 21);
            this.aerografoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aerografoBox.TabIndex = 25;
            this.aerografoBox.TabStop = false;
            this.aerografoBox.Click += new System.EventHandler(this.aerografoBox_Click);
            // 
            // caligraficoBox
            // 
            this.caligraficoBox.BackColor = System.Drawing.Color.White;
            this.caligraficoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caligraficoBox.BackgroundImage")));
            this.caligraficoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.caligraficoBox.Location = new System.Drawing.Point(39, 17);
            this.caligraficoBox.Name = "caligraficoBox";
            this.caligraficoBox.Size = new System.Drawing.Size(24, 21);
            this.caligraficoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caligraficoBox.TabIndex = 24;
            this.caligraficoBox.TabStop = false;
            this.caligraficoBox.Click += new System.EventHandler(this.caligraficoBox_Click);
            // 
            // pincelBox
            // 
            this.pincelBox.BackColor = System.Drawing.Color.White;
            this.pincelBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pincelBox.BackgroundImage")));
            this.pincelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pincelBox.Location = new System.Drawing.Point(5, 18);
            this.pincelBox.Name = "pincelBox";
            this.pincelBox.Size = new System.Drawing.Size(24, 21);
            this.pincelBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pincelBox.TabIndex = 23;
            this.pincelBox.TabStop = false;
            this.pincelBox.Click += new System.EventHandler(this.pincelBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox24);
            this.groupBox2.Controls.Add(this.pictureBox23);
            this.groupBox2.Controls.Add(this.pictureBox22);
            this.groupBox2.Controls.Add(this.pictureBox21);
            this.groupBox2.Controls.Add(this.pictureBox20);
            this.groupBox2.Controls.Add(this.pictureBox19);
            this.groupBox2.Controls.Add(this.pictureBox18);
            this.groupBox2.Controls.Add(this.pictureBox17);
            this.groupBox2.Controls.Add(this.pictureBox16);
            this.groupBox2.Controls.Add(this.pictureBox15);
            this.groupBox2.Controls.Add(this.pictureBox14);
            this.groupBox2.Controls.Add(this.pictureBox13);
            this.groupBox2.Controls.Add(this.DrawHexagonBox);
            this.groupBox2.Controls.Add(this.DrawPentagonBox);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.DrawTriangleBox);
            this.groupBox2.Controls.Add(this.DrawIrregularBox);
            this.groupBox2.Controls.Add(this.DrawRectangleBox);
            this.groupBox2.Controls.Add(this.DrawEllipseBox);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.DrawLineBox);
            this.groupBox2.Controls.Add(this.menuStrip2);
            this.groupBox2.Location = new System.Drawing.Point(453, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(310, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shapes";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(95, 72);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(24, 21);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(65, 72);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(24, 21);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 21;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(35, 72);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(24, 21);
            this.pictureBox22.TabIndex = 20;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(5, 72);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(24, 21);
            this.pictureBox21.TabIndex = 19;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(245, 45);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(24, 21);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 18;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(215, 45);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(24, 21);
            this.pictureBox19.TabIndex = 17;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(185, 45);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 21);
            this.pictureBox18.TabIndex = 16;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(155, 45);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(24, 21);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 15;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(125, 45);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(24, 21);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 14;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(95, 45);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(24, 21);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 13;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(65, 45);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(24, 21);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 12;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(35, 45);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(24, 21);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 11;
            this.pictureBox13.TabStop = false;
            // 
            // DrawHexagonBox
            // 
            this.DrawHexagonBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawHexagonBox.Image")));
            this.DrawHexagonBox.Location = new System.Drawing.Point(5, 45);
            this.DrawHexagonBox.Name = "DrawHexagonBox";
            this.DrawHexagonBox.Size = new System.Drawing.Size(24, 21);
            this.DrawHexagonBox.TabIndex = 10;
            this.DrawHexagonBox.TabStop = false;
            this.DrawHexagonBox.Click += new System.EventHandler(this.DrawHexagonBox_Click);
            // 
            // DrawPentagonBox
            // 
            this.DrawPentagonBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawPentagonBox.Image")));
            this.DrawPentagonBox.Location = new System.Drawing.Point(245, 18);
            this.DrawPentagonBox.Name = "DrawPentagonBox";
            this.DrawPentagonBox.Size = new System.Drawing.Size(24, 21);
            this.DrawPentagonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawPentagonBox.TabIndex = 9;
            this.DrawPentagonBox.TabStop = false;
            this.DrawPentagonBox.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(215, 18);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 21);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(185, 18);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 21);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // DrawTriangleBox
            // 
            this.DrawTriangleBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangleBox.Image")));
            this.DrawTriangleBox.Location = new System.Drawing.Point(155, 18);
            this.DrawTriangleBox.Name = "DrawTriangleBox";
            this.DrawTriangleBox.Size = new System.Drawing.Size(24, 21);
            this.DrawTriangleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawTriangleBox.TabIndex = 6;
            this.DrawTriangleBox.TabStop = false;
            this.DrawTriangleBox.Click += new System.EventHandler(this.DrawTriangleBox_Click);
            // 
            // DrawIrregularBox
            // 
            this.DrawIrregularBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawIrregularBox.Image")));
            this.DrawIrregularBox.Location = new System.Drawing.Point(125, 18);
            this.DrawIrregularBox.Name = "DrawIrregularBox";
            this.DrawIrregularBox.Size = new System.Drawing.Size(24, 21);
            this.DrawIrregularBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawIrregularBox.TabIndex = 5;
            this.DrawIrregularBox.TabStop = false;
            // 
            // DrawRectangleBox
            // 
            this.DrawRectangleBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawRectangleBox.Image")));
            this.DrawRectangleBox.Location = new System.Drawing.Point(95, 18);
            this.DrawRectangleBox.Name = "DrawRectangleBox";
            this.DrawRectangleBox.Size = new System.Drawing.Size(24, 21);
            this.DrawRectangleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawRectangleBox.TabIndex = 4;
            this.DrawRectangleBox.TabStop = false;
            this.DrawRectangleBox.Click += new System.EventHandler(this.DrawRectangleBox_Click);
            // 
            // DrawEllipseBox
            // 
            this.DrawEllipseBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawEllipseBox.Image")));
            this.DrawEllipseBox.Location = new System.Drawing.Point(65, 18);
            this.DrawEllipseBox.Name = "DrawEllipseBox";
            this.DrawEllipseBox.Size = new System.Drawing.Size(24, 21);
            this.DrawEllipseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawEllipseBox.TabIndex = 3;
            this.DrawEllipseBox.TabStop = false;
            this.DrawEllipseBox.Click += new System.EventHandler(this.DrawEllipseBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(35, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // DrawLineBox
            // 
            this.DrawLineBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineBox.Image")));
            this.DrawLineBox.Location = new System.Drawing.Point(5, 18);
            this.DrawLineBox.Name = "DrawLineBox";
            this.DrawLineBox.Size = new System.Drawing.Size(24, 21);
            this.DrawLineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawLineBox.TabIndex = 1;
            this.DrawLineBox.TabStop = false;
            this.DrawLineBox.Click += new System.EventHandler(this.DrawLineBox_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(2, 15);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(306, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(768, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(258, 116);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.footerPanel.Controls.Add(this.panel1);
            this.footerPanel.Location = new System.Drawing.Point(2, 522);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1434, 42);
            this.footerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblCursorPosition);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 32);
            this.panel1.TabIndex = 0;
            // 
            // lblCursorPosition
            // 
            this.lblCursorPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCursorPosition.AutoSize = true;
            this.lblCursorPosition.Location = new System.Drawing.Point(44, 8);
            this.lblCursorPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCursorPosition.Name = "lblCursorPosition";
            this.lblCursorPosition.Size = new System.Drawing.Size(10, 13);
            this.lblCursorPosition.TabIndex = 0;
            this.lblCursorPosition.Text = ":";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordinatesStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CoordinatesStatus
            // 
            this.CoordinatesStatus.Name = "CoordinatesStatus";
            this.CoordinatesStatus.Size = new System.Drawing.Size(45, 17);
            this.CoordinatesStatus.Text = "Coords";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "View";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGToolStripMenuItem,
            this.jPGToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jPGToolStripMenuItem.Text = "JPEG";
            this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.Location = new System.Drawing.Point(571, 171);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(476, 387);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseUp);
            // 
            // cmbFontText
            // 
            this.cmbFontText.AutoCompleteCustomSource.AddRange(new string[] {
            "Microsoft Tai Le",
            "MingLiU_HKSCS-ExtB",
            "Mistral",
            "Monotype Corsiva",
            "MV Boli",
            "OCR A",
            "Onyx",
            "Palatino Linotype",
            "Papyrus",
            "Ravie",
            "Rockwell"});
            this.cmbFontText.FormattingEnabled = true;
            this.cmbFontText.Items.AddRange(new object[] {
            "Microsoft Tai Le",
            "MingLiU_HKSCS-ExtB",
            "Mistral",
            "Monotype Corsiva",
            "MV Boli",
            "OCR A",
            "Onyx",
            "Palatino Linotype",
            "Papyrus",
            "Ravie",
            "Rockwell"});
            this.cmbFontText.Location = new System.Drawing.Point(12, 7);
            this.cmbFontText.Name = "cmbFontText";
            this.cmbFontText.Size = new System.Drawing.Size(121, 21);
            this.cmbFontText.TabIndex = 8;
            this.cmbFontText.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbSizeText
            // 
            this.cmbSizeText.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "10",
            "12",
            "14",
            "22",
            "26",
            "32",
            "36"});
            this.cmbSizeText.FormattingEnabled = true;
            this.cmbSizeText.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "22",
            "24",
            "32",
            "36"});
            this.cmbSizeText.Location = new System.Drawing.Point(139, 7);
            this.cmbSizeText.Name = "cmbSizeText";
            this.cmbSizeText.Size = new System.Drawing.Size(121, 21);
            this.cmbSizeText.TabIndex = 9;
            this.cmbSizeText.SelectedIndexChanged += new System.EventHandler(this.cmbSizeText_SelectedIndexChanged);
            // 
            // picBold
            // 
            this.picBold.BackColor = System.Drawing.Color.White;
            this.picBold.Image = ((System.Drawing.Image)(resources.GetObject("picBold.Image")));
            this.picBold.Location = new System.Drawing.Point(266, 7);
            this.picBold.Name = "picBold";
            this.picBold.Size = new System.Drawing.Size(24, 19);
            this.picBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBold.TabIndex = 10;
            this.picBold.TabStop = false;
            this.picBold.Click += new System.EventHandler(this.picBold_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.picItalics);
            this.panel2.Controls.Add(this.cmbFontText);
            this.panel2.Controls.Add(this.picBold);
            this.panel2.Controls.Add(this.cmbSizeText);
            this.panel2.Location = new System.Drawing.Point(41, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 31);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(500, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(24, 21);
            this.pictureBox12.TabIndex = 27;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(470, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 21);
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BackgroundImage = global::VividVista.Properties.Resources.icons8_align_right_50;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(440, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 21);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = global::VividVista.Properties.Resources.icons8_alinear_al_centro_50;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(410, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 21);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::VividVista.Properties.Resources.icons8_alinear_a_la_izquierda_50;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(380, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 21);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(353, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 19);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::VividVista.Properties.Resources.icons8_subrayar_501;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(326, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // picItalics
            // 
            this.picItalics.BackColor = System.Drawing.Color.White;
            this.picItalics.BackgroundImage = global::VividVista.Properties.Resources.icons8_cursiva_501;
            this.picItalics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItalics.Image = global::VividVista.Properties.Resources.icons8_cursiva_50;
            this.picItalics.Location = new System.Drawing.Point(296, 7);
            this.picItalics.Name = "picItalics";
            this.picItalics.Size = new System.Drawing.Size(24, 19);
            this.picItalics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItalics.TabIndex = 20;
            this.picItalics.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.Name = "MainWindow";
            this.Text = "VividVista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpSlection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goteroBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oleoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapizPincelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acuarelaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crayonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aerografoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caligraficoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pincelBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawHexagonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPentagonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawTriangleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawIrregularBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawRectangleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawEllipseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLineBox)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBold)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItalics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel footerPanel;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblCursorPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CoordinatesStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pencilBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpSlection;
        private System.Windows.Forms.GroupBox grpImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.PictureBox zoomBox;
        private System.Windows.Forms.PictureBox goteroBox;
        private System.Windows.Forms.PictureBox eraserBox;
        private System.Windows.Forms.PictureBox textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        public System.Windows.Forms.PictureBox fillBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox DrawPentagonBox;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox DrawTriangleBox;
        private System.Windows.Forms.PictureBox DrawIrregularBox;
        private System.Windows.Forms.PictureBox DrawRectangleBox;
        private System.Windows.Forms.PictureBox DrawEllipseBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox DrawLineBox;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox DrawHexagonBox;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
        private System.Windows.Forms.PictureBox oleoBox;
        private System.Windows.Forms.PictureBox lapizPincelBox;
        private System.Windows.Forms.PictureBox acuarelaBox;
        private System.Windows.Forms.PictureBox crayonBox;
        private System.Windows.Forms.PictureBox marcadorBox;
        private System.Windows.Forms.PictureBox aerografoBox;
        private System.Windows.Forms.PictureBox caligraficoBox;
        private System.Windows.Forms.PictureBox pincelBox;
        private System.Windows.Forms.ComboBox cmbFontText;
        private System.Windows.Forms.ComboBox cmbSizeText;
        private System.Windows.Forms.PictureBox picBold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picItalics;
    }
}

