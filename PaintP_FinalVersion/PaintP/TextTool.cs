using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintP
{
    public class TextTool : Tool
    {
        private Font font;
        private Color color;
        private FontStyle fontStyle = FontStyle.Regular;

        public TextTool(Font font, Color color)
        {
            this.font = font;
            this.color = color;
        }

        public void SetFont(Font font)
        {
            this.font = font;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetFontStyle(FontStyle style)
        {
            if ((fontStyle & style) == style)
            {
                fontStyle &= ~style;
            }
            else
            {
                fontStyle |= style;
            }
            UpdateFont();
        }

        private void UpdateFont()
        {
            this.font = new Font(this.font.FontFamily, this.font.Size, fontStyle);
        }

        public void CreateTextBox(Control parentControl, Point location)
        {
            TextBox textBox = new TextBox
            {
                Font = font,
                ForeColor = color,
                Location = location,
                BorderStyle = BorderStyle.None,
                Multiline = true,
                BackColor = Color.White,
                Width = 200 // Ajusta el ancho según sea necesario
            };

            textBox.LostFocus += (s, e) =>
            {
                // Remover el TextBox del control padre
                parentControl.Controls.Remove(textBox);

                // Dibujar el texto en el PictureBox
                if (parentControl is PictureBox pictureBox)
                {
                    using (Graphics g = Graphics.FromImage(pictureBox.Image))
                    {
                        // Asegúrate de usar las propiedades correctas de la fuente y color
                        using (Brush textBrush = new SolidBrush(color))
                        {
                            g.DrawString(textBox.Text, font, textBrush, location);
                        }
                    }

                    // Invalida el PictureBox para que se vuelva a dibujar
                    pictureBox.Invalidate();
                }
            };

            parentControl.Controls.Add(textBox);
            textBox.Focus();
        }

        public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
        {
            // Método Draw no se usa para TextTool, pero debe implementarse
        }

        public override Cursor GetCursor()
        {
            return Cursors.IBeam;
        }
    }
}
