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
using System.Diagnostics;

namespace Detector_facial
{
	public partial class frmlistado_usuariosf : Form
	{
		appvb.dsTableAdapters.listado_empleadosTableAdapter tal = new appvb.dsTableAdapters.listado_empleadosTableAdapter();
		appvb.ds.listado_empleadosDataTable dt = new appvb.ds.listado_empleadosDataTable();
		appvb.ds.listado_empleadosRow fila;
		public frmlistado_usuariosf()
		{
			InitializeComponent();
		}

		void llenar() {
			dg.Rows.Clear();
			string ced;
			string ruta;
			Bitmap inImg;
			DataGridViewImageColumn img2 = new DataGridViewImageColumn();
			txttotal.Text = dt.Rows.Count.ToString();   
			for (int i = 0; i <= dt.Rows.Count - 1; i++)
			{
				fila = (appvb.ds.listado_empleadosRow)dt.Rows[i];
				dg.Rows.Add(i + 1, fila.em_nomlar, fila.ID, fila.ced, fila.em_fecha_contratacion, fila.SEXO, fila.estado, fila.ES_USU_SYS, fila.ESTA_USU_SYS, fila.em_estado_civil, fila.usuario,null,fila.SEXO);
				ced = fila.ced;
				ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + ced + ".jpg";
				// 'MessageBox.Show(ruta);

				if (ced.Length > 0)
				{
					if (File.Exists(ruta))
					{
						inImg =Estatic.LoadBitmapUnlocked (ruta);
						dg.Rows[i ].Cells[11].Value = inImg;
						dg.Rows[i ].Height = 150;
					}
				}
			}
		}

		private void frmlistado_usuariosf_Load(object sender, EventArgs e)
		{
			Point tempPoint = new Point(0, 0);
			 dt = new appvb.ds.listado_empleadosDataTable();
			tal.Fill (dt);
			llenar();
		}

		private void btnlistodos_Click(object sender, EventArgs e)
		{

		}

		void activos() {
			tal.Fill(dt);
			llenar();
		}


		private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_listado_noActivos_Click(object sender, EventArgs e)
		{

		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose(); 
		}

		private void btnli_act_Click(object sender, EventArgs e)
		{

		}

		private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//llamar datos de una fila
			try {
				DataGridViewRow row = dg.Rows[e.RowIndex];

				frmEntrenamiento frm = new frmEntrenamiento();
				frm.txtid.Text = row.Cells[2].Value.ToString();
				frm.MdiParent = this.MdiParent;
				frm.Show();
				frm.cargar_empleado(frm.txtid.Text, "id");
			}
			catch  {
				return;

			}

		}

		private void dg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmlistado_usuariosf_SizeChanged(object sender, EventArgs e)
		{
			//resize
			dg.Size = new Size(this.Size.Width - 40 - dg.Left, this.Size.Height - dg.Top - 50);
		}

		private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dt = new appvb.ds.listado_empleadosDataTable();
			tal.Fill(dt);
			llenar();
		}

		private void listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dt = new appvb.ds.listado_empleadosDataTable();
			tal.FillBy_usuarios(dt);
			llenar();
		}

		private void listadoDeEmpleadosNoActivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			appvb.dsTableAdapters.listado_empleadosTableAdapter tal = new appvb.dsTableAdapters.listado_empleadosTableAdapter();
			dt = new appvb.ds.listado_empleadosDataTable();
			tal.FillByNoA(dt);
			llenar();
			/*
			appvb.ds.listado_empleadosRow fila;
			dg.Rows.Clear();
			for (int i = 0; i <= dt.Rows.Count - 1; i++)
			{
				fila = (appvb.ds.listado_empleadosRow)dt.Rows[i];
				dg.Rows.Add(i + 1, fila.em_nomlar, fila.ID, fila.ced, fila.em_fecha_contratacion, fila.SEXO, fila.estado, fila.ES_USU_SYS, fila.ESTA_USU_SYS, fila.em_estado_civil, fila.usuario);

			} */
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dt = new appvb.ds.listado_empleadosDataTable();
			tal.Fill_Act_sinFoto (dt);
			llenar();
		}

		private void listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dt = new appvb.ds.listado_empleadosDataTable();
			tal.Fill_Act_con_Foto  (dt);
			llenar();
		}
	}
}
