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
    public partial class frmcrearClave : Form
    {
        public frmcrearClave()
        {
            InitializeComponent();
        }

        private void frmcrearClave_Load(object sender, EventArgs e)
        {

        }

        private void chkpassview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpassview.Checked)
            {
                txtclave.PasswordChar = '\0';
                txtconfirmarclave.PasswordChar = '\0';
            }
            else {
                txtclave.PasswordChar ='*';
                txtconfirmarclave.PasswordChar = '*';
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

            encriptada = Estatic.encriptar(txtclave.Text);
            //   MessageBox.Show(encriptada);
            if (String.Equals(txtclave.Text, txtconfirmarclave.Text))
            {
                if (txtclave.Text.Length < 4) {
                    MessageBox.Show("La clave debe ser de al menos 4 letras");
                    return; 
                }
                if (Microsoft.VisualBasic.Information.IsNumeric(txtid.Text))
                {
                    try
                    {
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
            else {
                MessageBox.Show("La clave y su confirmaciòn no son iguales");
                return; 
            }
        }
    }
}
