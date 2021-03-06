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
	public partial class frm_cambiar_clave : Form
	{
		public frm_cambiar_clave()
		{
			InitializeComponent();
		}

		private void chkpassview_CheckedChanged(object sender, EventArgs e)
		{
			if (chkpassview.Checked)
			{
				txtclave.PasswordChar = '\0';
				txtconfirmarclave.PasswordChar = '\0';
				txtanteriorclave.PasswordChar = '\0';
			}
			else
			{
				txtclave.PasswordChar = '*';
				txtconfirmarclave.PasswordChar = '*';
				txtanteriorclave.PasswordChar = '*';
			}
		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btngrabar_Click(object sender, EventArgs e)
		{

			string encriptada;
			appvb.dsTableAdapters.empleadosTableAdapter ta = new appvb.dsTableAdapters.empleadosTableAdapter();
			appvb.ds.empleadosDataTable dt = new appvb.ds.empleadosDataTable();
			appvb.ds.empleadosRow fila;	
			encriptada = Estatic.encriptar(txtanteriorclave.Text);
			ta.FillByUsu_clave(dt,  Convert.ToInt32(txtid.Text));
			if (dt.Rows.Count <= 0) {
				MessageBox.Show("No hay ID");
				return;
			}
			else { 
				fila = (appvb.ds.empleadosRow)dt.Rows[0];
				if (!(string.Equals(fila.clave, encriptada))){
					MessageBox.Show("La clave anterior no coincide con la almacenada en la base de datos");
					return;
				} else {


				}
			}

			//   MessageBox.Show(encriptada);
			if (String.Equals(txtclave.Text, txtconfirmarclave.Text))
			{
				if (txtclave.Text.Length < 4)
				{
					MessageBox.Show("La clave debe ser de al menos 4 letras");
					return;
				}
				if (Microsoft.VisualBasic.Information.IsNumeric(txtid.Text))
				{
					try
					{
						encriptada = Estatic.encriptar(txtclave.Text);
						ta.Update_clave(encriptada, Convert.ToInt32(txtid.Text));
						MessageBox.Show("Nueva Contraseña establecida correctamente");
						this.Dispose();
					}
					catch (Exception ex)
					{
						Console.Write(ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("La clave y su confirmaciòn no son iguales");
				return;
			}
		}

		private void frm_cambiar_clave_Load(object sender, EventArgs e)
		{
			txtusuario.Text = Estatic.usuario;
			txtid.Text = Estatic.id_usuario.ToString() ;
			txtnombre1.Text = Estatic.nombres;  
				  
		}
	}
}
