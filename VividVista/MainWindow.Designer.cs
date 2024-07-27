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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSlection = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.PictureBox();
            this.fillBox = new System.Windows.Forms.PictureBox();
            this.pencilBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCursorPosition = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CoordinatesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSlection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBox)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.grpSlection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSlection.Name = "grpSlection";
            this.grpSlection.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSlection.Size = new System.Drawing.Size(76, 118);
            this.grpSlection.TabIndex = 7;
            this.grpSlection.TabStop = false;
            this.grpSlection.Text = "Selection";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 71);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // grpImage
            // 
            this.grpImage.Location = new System.Drawing.Point(83, 2);
            this.grpImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpImage.Size = new System.Drawing.Size(140, 118);
            this.grpImage.TabIndex = 8;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Image";
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.pictureBox6);
            this.grpTools.Controls.Add(this.pictureBox4);
            this.grpTools.Controls.Add(this.pictureBox5);
            this.grpTools.Controls.Add(this.textBox);
            this.grpTools.Controls.Add(this.fillBox);
            this.grpTools.Controls.Add(this.pencilBox);
            this.grpTools.Location = new System.Drawing.Point(228, 2);
            this.grpTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTools.Name = "grpTools";
            this.grpTools.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTools.Size = new System.Drawing.Size(144, 118);
            this.grpTools.TabIndex = 9;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Tools";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(99, 63);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 41);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(52, 63);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 41);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(4, 63);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 41);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(99, 17);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(43, 41);
            this.textBox.TabIndex = 2;
            this.textBox.TabStop = false;
            // 
            // fillBox
            // 
            this.fillBox.Location = new System.Drawing.Point(52, 17);
            this.fillBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(43, 41);
            this.fillBox.TabIndex = 1;
            this.fillBox.TabStop = false;
            this.fillBox.Click += new System.EventHandler(this.FillBox_Click);
            // 
            // pencilBox
            // 
            this.pencilBox.Image = ((System.Drawing.Image)(resources.GetObject("pencilBox.Image")));
            this.pencilBox.Location = new System.Drawing.Point(4, 17);
            this.pencilBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pencilBox.Name = "pencilBox";
            this.pencilBox.Size = new System.Drawing.Size(43, 41);
            this.pencilBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pencilBox.TabIndex = 0;
            this.pencilBox.TabStop = false;
            this.pencilBox.Click += new System.EventHandler(this.PencilBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(376, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(72, 118);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brushes";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(453, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(310, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shapes";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(768, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.footerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1434, 42);
            this.footerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblCursorPosition);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // picCanvas
            // 
            this.picCanvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.Image = global::VividVista.Properties.Resources.icons8_paleta_de_pintura_con_pincel_321;
            this.picCanvas.Location = new System.Drawing.Point(571, 171);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(476, 387);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseUp);
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
            this.toolStripMenuItem3});
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
            this.openToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 567);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.Name = "MainWindow";
            this.Text = "VividVista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpSlection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBox)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox fillBox;
        private System.Windows.Forms.GroupBox grpSlection;
        private System.Windows.Forms.GroupBox grpImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

