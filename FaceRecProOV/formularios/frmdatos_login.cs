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
    public partial class frmdatos_login : Form
    {
        public frmdatos_login()
        {
            InitializeComponent();
        }

        private void frmdatos_login_Load(object sender, EventArgs e)
        {
            txtnombres.Text = Estatic.nombres;
            txtrol.Text = Estatic.rol;
            txtusuario.Text = Estatic.usuario;     
        }
    }
}
