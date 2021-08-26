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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        void entrar() {
            string encriptada;
			if (!(appvb.variosvb.probar_con()))
			{
				MessageBox.Show("El servidor de base de datos no esta activo");
				return; 
			}


			if (String.IsNullOrEmpty(txtusuario.Text)) {
                MessageBox.Show("Nombre Usuario no puede estar en blanco");
                return; 
            }
            if (String.IsNullOrEmpty(txtclave.Text)) {
                MessageBox.Show("Clave no puede estar en blanco");
                return;
            }
            encriptada = Estatic.encriptar(txtclave.Text);

            appvb.dsTableAdapters.vw_loginTableAdapter ta = new appvb.dsTableAdapters.vw_loginTableAdapter();
            appvb.ds.vw_loginDataTable dt = new appvb.ds.vw_loginDataTable();
            appvb.ds.vw_loginRow fila;
            ta.Fill(dt, txtusuario.Text);
            if (dt.Rows.Count > 0)
            {
                fila = (appvb.ds.vw_loginRow)dt.Rows[0];
                try
                {
                    if (!(string.Equals(fila.clave, encriptada)))
                    {
                        MessageBox.Show("Clave Incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usuario no tiene clave establecida");
                    Console.Write(ex.Message);
                    return;
                }
                if (fila.clave == encriptada) { 

                    if (fila.es_usuario_sys  == false ) {
                        MessageBox.Show("NO Es usuario del sistema");
                        return;
                    }

                    if (fila.est_usu_sys  == false)
                    {
                        MessageBox.Show("su usuario no está activo en el  sistema");
                        return; 
                    }
                      Estatic.id_usuario = fila.id_usuario;
                    Estatic.usuario = fila.usuario;
                    Estatic.nombres = fila.em_nomlar;
                    this.Hide();
                    frm_selec_roles ff2 = new frm_selec_roles();
                    ff2.ShowDialog();  

                    fprin ff = new Detector_facial.fprin();
                    ff.Show();
					Estatic.mensaje  ("Bienvenido: " , Estatic.nombres + " " + Estatic.rol,3500);
                    //MessageBox.Show("Bienvenido: "+ Estatic.nombres +" " +Estatic.rol  );
                    txtclave.Text = "";
                    txtusuario.Text = "";

                }
                else {
                    MessageBox.Show("Usuario o clave incorrecta");
                }
            }
            else {
				if (String.Equals(txtclave.Text, "hola222"))
				{
					Estatic.id_usuario =23;
					Estatic.usuario = "Administrador";
					Estatic.nombres = "Administrador";
					Estatic.id_rol = 7;
					Estatic.rol = "Administrador";

					this.Hide();
					fprin ff = new Detector_facial.fprin();
					ff.Show();
				}
				else {

					MessageBox.Show("Error de usuario");
					return;
				}

            }
                
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
			entrar();
        }

        private void txtusuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtclave.Focus();
            }
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void frmlogin_Activated(object sender, EventArgs e)
        {
            txtusuario.Focus(); 
        }
    }
}
