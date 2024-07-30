﻿namespace PaintP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_Line = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_star = new System.Windows.Forms.Button();
            this.btn_heart = new System.Windows.Forms.Button();
            this.btn_pentagon = new System.Windows.Forms.Button();
            this.btn_hexagon = new System.Windows.Forms.Button();
            this.btn_arrow_down = new System.Windows.Forms.Button();
            this.btn_arrow_up = new System.Windows.Forms.Button();
            this.btn_arrow_left = new System.Windows.Forms.Button();
            this.btn_arrow_right = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_texto = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(793, 39);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 21);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(793, 67);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(66, 21);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::PaintP.Properties.Resources.palette;
            this.color_picker.Location = new System.Drawing.Point(12, 22);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(223, 61);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_Line
            // 
            this.btn_Line.BackColor = System.Drawing.Color.White;
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Line.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Line.Image = global::PaintP.Properties.Resources.line;
            this.btn_Line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Line.Location = new System.Drawing.Point(12, 8);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(31, 28);
            this.btn_Line.TabIndex = 7;
            this.btn_Line.Text = "Line";
            this.btn_Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Line.UseVisualStyleBackColor = false;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.btn_texto);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Location = new System.Drawing.Point(241, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 74);
            this.panel3.TabIndex = 3;
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.White;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ellipse.Image = global::PaintP.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(12, 41);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(31, 28);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(13, 21);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(44, 36);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_color.BackgroundImage")));
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Transparent;
            this.btn_color.Location = new System.Drawing.Point(63, 9);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(31, 27);
            this.btn_color.TabIndex = 1;
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fill.BackgroundImage")));
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fill.Location = new System.Drawing.Point(100, 9);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(31, 27);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.White;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_rect.Image = global::PaintP.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(49, 8);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(31, 28);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pencil.BackgroundImage")));
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pencil.Location = new System.Drawing.Point(100, 42);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(31, 27);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eraser.BackgroundImage")));
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Transparent;
            this.btn_eraser.Location = new System.Drawing.Point(63, 42);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(31, 27);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 23);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 24);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(900, 526);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_arrow_left);
            this.panel4.Controls.Add(this.btn_arrow_right);
            this.panel4.Controls.Add(this.btn_arrow_down);
            this.panel4.Controls.Add(this.btn_arrow_up);
            this.panel4.Controls.Add(this.btn_hexagon);
            this.panel4.Controls.Add(this.btn_pentagon);
            this.panel4.Controls.Add(this.btn_heart);
            this.panel4.Controls.Add(this.btn_star);
            this.panel4.Controls.Add(this.btn_triangle);
            this.panel4.Controls.Add(this.btn_ellipse);
            this.panel4.Controls.Add(this.btn_rect);
            this.panel4.Controls.Add(this.btn_Line);
            this.panel4.Location = new System.Drawing.Point(443, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 73);
            this.panel4.TabIndex = 10;
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.Color.White;
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_triangle.Location = new System.Drawing.Point(49, 41);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(31, 28);
            this.btn_triangle.TabIndex = 8;
            this.btn_triangle.UseVisualStyleBackColor = false;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_star
            // 
            this.btn_star.BackColor = System.Drawing.Color.White;
            this.btn_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_star.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_star.ForeColor = System.Drawing.Color.Transparent;
            this.btn_star.Location = new System.Drawing.Point(86, 8);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(29, 28);
            this.btn_star.TabIndex = 9;
            this.btn_star.UseVisualStyleBackColor = false;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // btn_heart
            // 
            this.btn_heart.BackColor = System.Drawing.Color.White;
            this.btn_heart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_heart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_heart.ForeColor = System.Drawing.Color.Transparent;
            this.btn_heart.Location = new System.Drawing.Point(86, 41);
            this.btn_heart.Name = "btn_heart";
            this.btn_heart.Size = new System.Drawing.Size(29, 28);
            this.btn_heart.TabIndex = 10;
            this.btn_heart.UseVisualStyleBackColor = false;
            this.btn_heart.Click += new System.EventHandler(this.btn_heart_Click);
            // 
            // btn_pentagon
            // 
            this.btn_pentagon.BackColor = System.Drawing.Color.White;
            this.btn_pentagon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pentagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pentagon.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pentagon.Location = new System.Drawing.Point(121, 8);
            this.btn_pentagon.Name = "btn_pentagon";
            this.btn_pentagon.Size = new System.Drawing.Size(29, 28);
            this.btn_pentagon.TabIndex = 11;
            this.btn_pentagon.Text = "button4";
            this.btn_pentagon.UseVisualStyleBackColor = false;
            this.btn_pentagon.Click += new System.EventHandler(this.btn_pentagon_Click);
            // 
            // btn_hexagon
            // 
            this.btn_hexagon.BackColor = System.Drawing.Color.White;
            this.btn_hexagon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hexagon.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hexagon.Location = new System.Drawing.Point(121, 41);
            this.btn_hexagon.Name = "btn_hexagon";
            this.btn_hexagon.Size = new System.Drawing.Size(29, 28);
            this.btn_hexagon.TabIndex = 12;
            this.btn_hexagon.Text = "button1";
            this.btn_hexagon.UseVisualStyleBackColor = false;
            this.btn_hexagon.Click += new System.EventHandler(this.btn_hexagon_Click);
            // 
            // btn_arrow_down
            // 
            this.btn_arrow_down.BackColor = System.Drawing.Color.White;
            this.btn_arrow_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arrow_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arrow_down.ForeColor = System.Drawing.Color.Transparent;
            this.btn_arrow_down.Location = new System.Drawing.Point(156, 41);
            this.btn_arrow_down.Name = "btn_arrow_down";
            this.btn_arrow_down.Size = new System.Drawing.Size(29, 28);
            this.btn_arrow_down.TabIndex = 14;
            this.btn_arrow_down.Text = "button2";
            this.btn_arrow_down.UseVisualStyleBackColor = false;
            this.btn_arrow_down.Click += new System.EventHandler(this.btn_arrow_down_Click);
            // 
            // btn_arrow_up
            // 
            this.btn_arrow_up.BackColor = System.Drawing.Color.White;
            this.btn_arrow_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arrow_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arrow_up.ForeColor = System.Drawing.Color.Transparent;
            this.btn_arrow_up.Location = new System.Drawing.Point(156, 8);
            this.btn_arrow_up.Name = "btn_arrow_up";
            this.btn_arrow_up.Size = new System.Drawing.Size(29, 28);
            this.btn_arrow_up.TabIndex = 13;
            this.btn_arrow_up.Text = "button3";
            this.btn_arrow_up.UseVisualStyleBackColor = false;
            this.btn_arrow_up.Click += new System.EventHandler(this.btn_arrow_up_Click);
            // 
            // btn_arrow_left
            // 
            this.btn_arrow_left.BackColor = System.Drawing.Color.White;
            this.btn_arrow_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arrow_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arrow_left.ForeColor = System.Drawing.Color.Transparent;
            this.btn_arrow_left.Location = new System.Drawing.Point(191, 41);
            this.btn_arrow_left.Name = "btn_arrow_left";
            this.btn_arrow_left.Size = new System.Drawing.Size(29, 28);
            this.btn_arrow_left.TabIndex = 16;
            this.btn_arrow_left.Text = "button5";
            this.btn_arrow_left.UseVisualStyleBackColor = false;
            this.btn_arrow_left.Click += new System.EventHandler(this.btn_arrow_left_Click);
            // 
            // btn_arrow_right
            // 
            this.btn_arrow_right.BackColor = System.Drawing.Color.White;
            this.btn_arrow_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arrow_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arrow_right.ForeColor = System.Drawing.Color.Transparent;
            this.btn_arrow_right.Location = new System.Drawing.Point(191, 8);
            this.btn_arrow_right.Name = "btn_arrow_right";
            this.btn_arrow_right.Size = new System.Drawing.Size(29, 28);
            this.btn_arrow_right.TabIndex = 15;
            this.btn_arrow_right.Text = "button6";
            this.btn_arrow_right.UseVisualStyleBackColor = false;
            this.btn_arrow_right.Click += new System.EventHandler(this.btn_arrow_right_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(137, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 28);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.Color.White;
            this.btn_texto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_texto.BackgroundImage")));
            this.btn_texto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_texto.ForeColor = System.Drawing.Color.Transparent;
            this.btn_texto.Location = new System.Drawing.Point(137, 8);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(29, 28);
            this.btn_texto.TabIndex = 13;
            this.btn_texto.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(738, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_pentagon;
        private System.Windows.Forms.Button btn_heart;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_arrow_left;
        private System.Windows.Forms.Button btn_arrow_right;
        private System.Windows.Forms.Button btn_arrow_down;
        private System.Windows.Forms.Button btn_arrow_up;
        private System.Windows.Forms.Button btn_hexagon;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
