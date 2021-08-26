using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector_facial
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.empleados' table. You can move, or remove it, as needed.
          
            Point tempPoint = new Point(0, 0);
            // Set the location of the form using the Point object.
            this.DesktopLocation = tempPoint;
        }

		private void btndeteccion_Click(object sender, EventArgs e)
		{
            frmDeteccion fr = new frmDeteccion();
            fr.Show();
        }

		private void btneditar_Click(object sender, EventArgs e)
		{
			frmregistrados frmr;
			frmr = new frmregistrados();
			frmr.Show();

		}

		private void brnruta_Click(object sender, EventArgs e)
		{
            frmlistado_usuariosf frml = new frmlistado_usuariosf();
            frml.Show();
		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void btntest_Click(object sender, EventArgs e)
		{
			//string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";
			//string text1 = "This is some text.";
			//File.WriteAllText(ruta, text1);

			//string text2 = "This is text to be appended";
			//File.AppendAllText(ruta, text2);

		}
	}
}
