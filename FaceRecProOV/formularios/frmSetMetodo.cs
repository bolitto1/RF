using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector_facial
{
	public partial class frmSetMetodo : Form
	{
		string metodo;
		appvb.dsTableAdapters.parametrosTableAdapter ta = new appvb.dsTableAdapters.parametrosTableAdapter();
		appvb.ds.parametrosDataTable dt = new appvb.ds.parametrosDataTable();
		appvb.ds.parametrosRow fila;

		public frmSetMetodo()
		{
			InitializeComponent();
		}

		private void btnestablecer_Click(object sender, EventArgs e)
		{
            if (OPTEigen.Checked)
            {
                metodo = "EMGU.CV.EigenFaceRecognizer";
            }
            if (OptFisher.Checked)
			{
				metodo = "EMGU.CV.FisherFaceRecognizer";
			}
			if (OptLBPH.Checked)
			{
				metodo = "EMGU.CV.LBPHFaceRecognizer";
			}
			ta.Update_par(metodo);
			continuar(); 

		}

		private void frmSetMetodo_Load(object sender, EventArgs e)
		{
			ta.Fill(dt);
			fila = (appvb.ds.parametrosRow)dt.Rows[0];

			switch (fila.metodo)
			{
                case ("EMGU.CV.EigenFaceRecognizer"):
                    OPTEigen.Checked = true; break;
                case ("EMGU.CV.FisherFaceRecognizer"):
					OptFisher.Checked = true; break;
				case ("EMGU.CV.LBPHFaceRecognizer"):
					OptLBPH.Checked = true; break;
			}
		}

		void continuar() {
			Cursor.Current = Cursors.WaitCursor;
			this.Dispose();

			frmReconocimiento_batch ff = new frmReconocimiento_batch();
			ff.MdiParent = this.MdiParent ;
			ff.Show();
			Cursor.Current = Cursors.Default;
		}

		private void btncontinuar_Click(object sender, EventArgs e)
		{
			continuar();
		}
	}
}
