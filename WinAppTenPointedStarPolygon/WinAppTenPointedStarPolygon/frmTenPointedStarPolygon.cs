using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTenPointedStarPolygon
{
    public partial class frmTenPointedStarPolygon : Form
    {
        // Definición de un objeto de tipo CTenPointedStarPolygon.
        private CTenPointedStarPolygon starCalculator;

        public frmTenPointedStarPolygon()
        {
            InitializeComponent();
            starCalculator = new CTenPointedStarPolygon(picCanvas, 100);
        }

        private void frmTenPointedStarPolygon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            //starCalculator.InitializeData(txtSide, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (starCalculator != null)
            {
                int starSize = Convert.ToInt32(txtSide.Text);

                if (starSize < 10) // Tamaño pequeño, ajuste para hacerlo más grande
                {
                    starSize *= 10;
                }

                starCalculator.SetStarSize(starSize);
                starCalculator.DrawStar();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            //ObjTenPointedStarPolygon.InitializeData(txtSide, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            Close();
        }

        private void btnColor_MousrClick(object sender, MouseEventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cambiar todos los colores de la estrella al color seleccionado
                    UpdateStarColor(colorDialog.Color);
                }
            }
        }

        private void UpdateStarColor(Color color)
        {
            // Cambiar todos los colores de la estrella a un solo color seleccionado
            starCalculator.SetStarColors(new Color[] { color }); // Actualizar los colores
            starCalculator.DrawStar(); // Redibuja la estrella con los nuevos colores
        }
    }
}

