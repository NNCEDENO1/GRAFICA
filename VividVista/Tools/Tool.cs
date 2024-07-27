using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividVista.Tools
{
    public abstract class Tool
    {
        public abstract void Draw(Graphics graphics, Point startPoint, Point endPoint);
        public abstract Cursor GetCursor();
    }
}