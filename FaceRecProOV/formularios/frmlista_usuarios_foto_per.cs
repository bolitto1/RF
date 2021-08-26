using System;
using System.IO;
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
    public partial class frmlista_usuarios_foto_per : Form
    {
        appvb.dsTableAdapters.empleadosTableAdapter ta;
        appvb.ds.empleadosDataTable  dt = new appvb.ds.empleadosDataTable();
        appvb.ds.empleadosRow  fila;
        string ruta, ced;

        public frmlista_usuarios_foto_per()
        {
            InitializeComponent();
        }
        // Load a bitmap without locking it.
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

        void cargar() {
            ta = new appvb.dsTableAdapters.empleadosTableAdapter();
            ta.Fill(dt);
            dg.Rows.Clear();
             
            Bitmap inImg;
            DataGridViewImageColumn img2 = new DataGridViewImageColumn();
            img2.ImageLayout = DataGridViewImageCellLayout.Zoom;
			int cont = 1;
			string estado, es_usu, estado_usu;
			Cursor.Current = Cursors.WaitCursor;
			for (int m = 0; m < dt.Rows.Count; m++)
            {
                fila = (appvb.ds.empleadosRow)dt.Rows[m];
                ced = fila.ced;
                ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + ced + ".jpg";
                // 'MessageBox.Show(ruta);

                if (ced.Length > 0)
                {
                    try
                    {
                        if (File.Exists(ruta))
                        {
							try {
								estado = fila.em_estado;
							}
							catch (Exception ex) {
								estado = "N";
							}
							try
							{
								if (fila.est_usu_sys)
								{
									estado_usu = "S";
								}
								else {
									estado_usu = "N";
								}
							}
							catch (Exception ex)
							{
								estado_usu = "N";
							}

							try
							{
								if (fila.es_usuario_sys)
								{
									es_usu = "S";
								}
								else
								{
									es_usu = "N";
								}
							}
							catch (Exception ex)
							{
								es_usu = "N";
							}
							dg.Rows.Add(cont, fila.ID , fila.ced, fila.em_nomlar,estado, es_usu, estado_usu);
                            inImg = Estatic.LoadBitmapUnlocked(ruta);
                            dg.Rows[cont-1].Cells[4].Value = inImg;
                            dg.Rows[cont-1].Height = 200;
							cont++;
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } 
            }
			Cursor.Current = Cursors.Default;
		}

		void cargar_archivos() {
			string cedula, full;
			appvb.ds.empleadosRow fila;
			int pos;
			ruta = Application.StartupPath.ToString() + "\\foto_ced\\";
			Bitmap inImg;
			DataGridViewImageColumn img2;
			DirectoryInfo dir = new DirectoryInfo(ruta);
	
			dg.Rows.Clear();
			int m = 1;
			foreach (FileInfo file in dir.GetFiles())
			{
				full = file.Name;
				pos = appvb.variosvb.instrvb(file.Name , ".");
				cedula = appvb.variosvb.midvb(file.Name, 1, pos-1);
				if (appvb.variosvb.isnumericvb(cedula)) {
					ta = new appvb.dsTableAdapters.empleadosTableAdapter();
					ta.FillByCed(dt, cedula);
					fila = (appvb.ds.empleadosRow)dt.Rows[0];

					img2 = new DataGridViewImageColumn();
					img2.ImageLayout = DataGridViewImageCellLayout.Zoom;

					ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + cedula + ".jpg";
					dg.Rows.Add(m, fila.ced, fila.em_nomlar);
					inImg = Estatic.LoadBitmapUnlocked(ruta);
					dg.Rows[m].Cells[3].Value = inImg;
					dg.Rows[m].Height = 200;
				}
			}

			ToolStripStatusLabel statusStrip = ((fprin)(this.MdiParent)).toolStripStatus;
			statusStrip.Text = "hola";

		}

		private void btnrecargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void frmlista_usuarios_foto_per_Activated(object sender, EventArgs e)
        {
           // dg.Width = this.Width - 50;
            dg.Height = this.Height - dg.Top - 50;
        }

        private void frmlista_usuarios_foto_per_Resize(object sender, EventArgs e)
        {
          //  dg.Width = this.Width - 50;
            dg.Height = this.Height - dg.Top - 50;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			frmEntrenamiento frd = new frmEntrenamiento();
			string valor;
			try {
				valor = Convert.ToString(dg.Rows[e.RowIndex].Cells[1].Value);

				frd.MdiParent = this.MdiParent;
				//MessageBox.Show(valor);
				frd.Show();
				//frd.txtced.Text = valor;
				frd.cargar_empleado(valor, "id");
			}
			catch (Exception ex) {
				Console.Write(ex.Message);
			}

            
        }

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void frmlista_usuarios_foto_per_Load(object sender, EventArgs e)
        {
			//cargar_archivos();

			cargar();
        }
    }
}
