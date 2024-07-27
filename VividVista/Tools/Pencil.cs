using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VividVista.Tools;

public class Pencil : Tool
{
    private Pen mPen;

    public Pencil(Color color, float width)
    {
        mPen = new Pen(color, width);
    }

    public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
    {
        graphics.DrawLine(mPen, startPoint, endPoint);
    }

    public override Cursor GetCursor()
    {
        return Cursors.Cross;
    }

    public void SetColor(Color color)
    {
            mPen.Color = color;
    }

    public void SetWidth(float width)
    {
        mPen.Width = width;
    }
}


