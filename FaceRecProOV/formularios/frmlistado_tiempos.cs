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
	public partial class frmlistado_tiempos : Form
	{
		appvb.dsTableAdapters.evento_fechasTableAdapter taf = new appvb.dsTableAdapters.evento_fechasTableAdapter();
		appvb.dsTableAdapters.evento_deteccion_iTableAdapter  tae = new appvb.dsTableAdapters.evento_deteccion_iTableAdapter();
		
		public frmlistado_tiempos()
		{
			InitializeComponent();
		}

		void cargar() {
			appvb.ds.evento_fechasDataTable dtf = new appvb.ds.evento_fechasDataTable();
			appvb.ds.evento_deteccion_iDataTable  dte = new appvb.ds.evento_deteccion_iDataTable();
			appvb.ds.evento_deteccion_iRow  fila_e;
			appvb.ds.evento_fechasRow  fila_f;
			taf.Fill(dtf);
			dg.Rows.Clear();
			 
			for (int i = 0; i < dtf.Rows.Count; i++) {
				fila_f = (appvb.ds.evento_fechasRow)dtf.Rows[i];
				tae.Fill(dte, fila_f.inicio);
				for (int k = 0; k < dte.Rows.Count; k++) {
					fila_e = (appvb.ds.evento_deteccion_iRow)dte.Rows[k];
					try {
					//	dg.Rows.Add(1, 1, 1, 1);
						dg.Rows.Add(fila_e.fecha,  fila_e.inicio, fila_e.fin, fila_e.tiempo, fila_e.milisegundos,fila_e.em_nomlar, fila_e.cedula  ,fila_e.fotos_en_bd   );
					}
					catch (Exception ex) {
						MessageBox.Show(ex.Message);
					}
					
				}
				
			}



		}
		private void frmlistado_tiempos_Load(object sender, EventArgs e)
		{
			Point tempPoint = new Point(0, 0);
			cargar();

		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
