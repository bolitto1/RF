using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector_facial
{
	public partial class frm_asistencia_detales : Form
	{
		appvb.dsTableAdapters.asis_ima_fechaTableAdapter ta = new appvb.dsTableAdapters.asis_ima_fechaTableAdapter();
		public frm_asistencia_detales()
		{
			InitializeComponent();
		}

		private void frm_asistencia_detales_Load(object sender, EventArgs e)
		{

		}

		private void btnconsultar_Click(object sender, EventArgs e)
		{
			DateTime fe;
			DataTable dtt = new DataTable() ;
			DataRow fil;
			string ffe = txtfecha.Value.ToString("yyyy-MM-dd 00:00:00");
			string ced, ruta, hora;
			DateTime hh;
			Bitmap inImg;
			fe = Convert.ToDateTime(ffe);

			dg.Rows.Clear();
			//	MessageBox.Show(fe.ToString());
			dtt = appvb.variosvb.get_asis(ffe);


			string mili="";
			Cursor.Current = Cursors.WaitCursor;
			for (int kl = 0; kl < dtt.Rows.Count; kl++) {

				fil = dtt.Rows[kl];
				ced = fil[2].ToString();
				ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + ced + ".jpg";
				// 'MessageBox.Show(ruta);
				hh = Convert.ToDateTime(fil[1]);

				hora = hh.ToString("HH:mm:ss.fff");           
				if (kl > 0)
				{
					DateTime date1 = Convert.ToDateTime(dg.Rows[kl - 1].Cells[1].Value);
					DateTime date2 = Convert.ToDateTime(hora);
					System.TimeSpan diff1 = date2.Subtract(date1);
					mili= diff1.ToString();
				}


				dg.Rows.Add(fil[0], hora, fil[2], fil[3], fil[4], fil[5], fil[6], fil[7],null,mili);
				if (ced.Length > 0)
				{
					if (File.Exists(ruta))
					{
						inImg = Estatic.LoadBitmapUnlocked(ruta);
						inImg =(System.Drawing.Bitmap ) Estatic.ResizeImage(inImg, 100, 150);
						dg.Rows[kl].Cells[8].Value = inImg;
						dg.Rows[kl].Height = 150;
					}
				}
			}
			Cursor.Current = Cursors.Default;
			//dg.DataSource = dt;

		}

		private void btnC_falsos_Click(object sender, EventArgs e)
		{
			DateTime fe;
			DataTable dtt = new DataTable();
			DataRow fil;
			string ffe = txtfecha.Value.ToString("yyyy-MM-dd 00:00:00");
			string ced,ruta, hora;
			DateTime hh;
			Bitmap inImg;
			fe = Convert.ToDateTime(ffe);

			appvb.ds.asis_ima_fechaDataTable dt = new appvb.ds.asis_ima_fechaDataTable();
			appvb.ds.asis_ima_fechaRow fila;

			//	MessageBox.Show(fe.ToString());
			dtt = appvb.variosvb.get_asis_falsos  (ffe);
			dg.Rows.Clear();
			for (int kl = 0; kl < dtt.Rows.Count; kl++)
			{
				fil = dtt.Rows[kl];
				ced = fil[2].ToString() ;
				ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + ced + ".jpg";
				// 'MessageBox.Show(ruta);
				hh = Convert.ToDateTime(fil[1]);

				hora = hh.ToString("HH:mm:ss.fff");
				dg.Rows.Add(fil[0], hora, fil[2], fil[3], fil[4], fil[5], fil[6], fil[7]);
				if (ced.Length > 0)
				{
					if (File.Exists(ruta))
					{
						inImg = Estatic.LoadBitmapUnlocked(ruta);
						dg.Rows[kl].Cells[8].Value = inImg;
						dg.Rows[kl].Height = 150;
					}
				}

			

			}

		}

		private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frm_asistencia_detales_SizeChanged(object sender, EventArgs e)
		{
			//resize
			dg.Size = new Size( this.Size.Width - 40 - dg.Left , this.Size.Height - dg.Top - 50);
		}

		private void btnC_falsos_sin_fe_Click(object sender, EventArgs e)
		{
			DateTime fe;
			DataTable dtt = new DataTable();
			DataRow fil;
			string ffe = txtfecha.Value.ToString("yyyy-MM-dd 00:00:00");
			string ced, ruta, hora;
			DateTime hh;
			Bitmap inImg;
			fe = Convert.ToDateTime(ffe);

			appvb.ds.asis_ima_fechaDataTable dt = new appvb.ds.asis_ima_fechaDataTable();
			appvb.ds.asis_ima_fechaRow fila;

			//	MessageBox.Show(fe.ToString());
			dtt = appvb.variosvb.get_asis_falsos_todos();
			dg.Rows.Clear();
			for (int kl = 0; kl < dtt.Rows.Count; kl++)
			{
				fil = dtt.Rows[kl];
				ced = fil[2].ToString();
				ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + ced + ".jpg";
				// 'MessageBox.Show(ruta);
				hh = Convert.ToDateTime(fil[1]);

				hora = hh.ToString("HH:mm:ss.fff");
				dg.Rows.Add(fil[0], hora, fil[2], fil[3], fil[4], fil[5], fil[6], fil[7]);
				if (ced.Length > 0)
				{
					if (File.Exists(ruta))
					{
						inImg = Estatic.LoadBitmapUnlocked(ruta);
						dg.Rows[kl].Cells[8].Value = inImg;
						dg.Rows[kl].Height = 150;
					}
				}
			}
		}
	}
}
