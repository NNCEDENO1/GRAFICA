using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VividVista
{
    public abstract class Figure
    {
        protected List<PointF> Points { get; set; }
        protected PointF Center { get; set; }
        protected float CurrentRotation { get; set; }
        protected float ZoomFactor { get; set; }

        public Figure()
        {
            Points = new List<PointF>();
            Center = PointF.Empty;
            CurrentRotation = 0;
            ZoomFactor = 1.0f;
        }

        public abstract void PlotShape(Graphics g);

        protected abstract void GeneratePoints();
    }

}

