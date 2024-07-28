using System.Drawing;
using System.Windows.Forms;
using VividVista.Tools;

public class TextTool : Tool
{
    private Font font;
    private Color color;

    public TextTool(Font font, Color color)
    {
        this.font = font;
        this.color = color;
    }

    public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
    {
        // Este método no hará nada para TextTool ya que el texto se maneja en un TextBox
    }

    public override Cursor GetCursor()
    {
        return Cursors.IBeam;
    }

    public void SetFont(Font font)
    {
        this.font = font;
    }

    public void SetColor(Color color)
    {
        this.color = color;
    }

    public void CreateTextBox(Control parentControl, Point location)
    {
        TextBox textBox = new TextBox
        {
            Font = font,
            ForeColor = color,
            Location = location,
            BorderStyle = BorderStyle.None,
            Multiline = true
        };

        textBox.LostFocus += (s, e) =>
        {
            parentControl.Controls.Remove(textBox);
            using (Graphics g = Graphics.FromImage(((PictureBox)parentControl).Image))
            {
                g.DrawString(textBox.Text, font, new SolidBrush(color), location);
            }
            parentControl.Invalidate();
        };

        parentControl.Controls.Add(textBox);
        textBox.Focus();
    }
}
