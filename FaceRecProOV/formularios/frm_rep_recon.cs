using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 


namespace Detector_facial
{
	public partial class frm_rep_recon : Form
	{
		appvb.dsTableAdapters.reconocimiento_pTableAdapter ta = new appvb.dsTableAdapters.reconocimiento_pTableAdapter();
		appvb.ds.reconocimiento_pDataTable dt;
		appvb.ds.reconocimiento_pRow fila;
		DataGridViewRow fila_dg;

		appvb.dsTableAdapters.vw_reconoTableAdapter ta_r = new appvb.dsTableAdapters.vw_reconoTableAdapter();
		appvb.ds.vw_reconoDataTable dt_r = new appvb.ds.vw_reconoDataTable();
		appvb.ds.vw_reconoRow fila_r;


		public frm_rep_recon()
		{
			InitializeComponent();
		}

		private void btnexportar_Click(object sender, EventArgs e)
		{
			if (!(Directory.Exists("c:\\temp")) ){
				Directory.CreateDirectory("c:\\temp");

			}

			string outCsvFile = string.Format("C:\\temp\\datos {0}.csv", DateTime.Now.ToString ("_yyyyMMdd HHmmss.fff"));

			String newLine = "";
			var stream = File.CreateText(outCsvFile);

			newLine = "RECONOCIMIENTO FACIAL,,,,,,,";
			stream.WriteLine(newLine);
			newLine = "FECHA:,"+txtfecha.Text + ",,,METODO:,"+txtmetodo.Text  +",ID,"+txtid.Text + "";
			stream.WriteLine(newLine);

			newLine = "Id , num, Tiempo de deteccion y reconocimiento , Ruta del archivo, Cedula, Distancia, Comentario, Tiempo de Reconocimiento";
			stream.WriteLine(newLine);
			for (int kl = 1; kl < dgd.Rows.Count-1; kl++) {
				fila_dg = dgd.Rows[kl];
				newLine = fila_dg.Cells[0].Value.ToString() + ",";
				newLine = newLine + fila_dg.Cells[1].Value.ToString() + ",";
				newLine = newLine + fila_dg.Cells[2].Value.ToString() + ",";
				newLine = newLine + fila_dg.Cells[3].Value.ToString() + ",'";
				newLine = newLine + fila_dg.Cells[4].Value.ToString() + "',";
				newLine = newLine + fila_dg.Cells[5].Value.ToString() + ",";
				newLine = newLine + fila_dg.Cells[6].Value.ToString() + ",";
				newLine = newLine + fila_dg.Cells[7].Value.ToString() + ",";
				stream.WriteLine(newLine);
			}

			stream.Close();
			string argument = "/select, " + outCsvFile;

			System.Diagnostics.Process.Start("explorer.exe", argument);

			MessageBox.Show ( outCsvFile+" GRABADO");
		}

		private void frm_rep_recon_Load(object sender, EventArgs e)
		{
			dt = new appvb.ds.reconocimiento_pDataTable();
			ta.Fill(dt);
			dgp.Rows.Clear();
			for (int kl = 0; kl < dt.Rows.Count; kl++)
			{
				fila = (appvb.ds.reconocimiento_pRow)dt.Rows[kl];
				dgp.Rows.Add(fila.id, fila.fecha, fila.metodo);

			}
		}

		private void dgp_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
		{
			//fila_sel_usu = e.Cell.RowIndex;
			try
			{
				fila_dg = dgp.Rows[e.Cell.RowIndex];
				txtid.Text = fila_dg.Cells[0].Value.ToString();
				txtfecha.Text = fila_dg.Cells[1].Value.ToString();
				txtmetodo.Text = fila_dg.Cells[2].Value.ToString();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}

		private void dgp_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dt_r = new appvb.ds.vw_reconoDataTable();
			if (txtid.Text.Length > 0)
			{
				ta_r.Fill(dt_r, Convert.ToInt64(txtid.Text));
				if (dt_r.Rows.Count > 0)
				{
					dgd.Rows.Clear();
					for (int kl = 0; kl < dt_r.Rows.Count; kl++)
					{
						fila_r = (appvb.ds.vw_reconoRow)dt_r.Rows[kl];
						dgd.Rows.Add(fila_r.id, fila_r.num, fila_r.milisegundos, fila_r.nombre_archivo, fila_r.cedula,  Convert.ToInt32 ( fila_r.distancia), fila_r.comentario, fila_r.mili_recon);
					}

				}

			}

		}

	}
}
