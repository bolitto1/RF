using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Detector_facial
{
    public partial class frmRoles : Form
    {
        appvb.dsTableAdapters.rolesTableAdapter tar;

        public frmRoles()
        {
            InitializeComponent();
        }

        void cargar()
        {
            tar = new appvb.dsTableAdapters.rolesTableAdapter();
            appvb.ds.rolesDataTable dt = new appvb.ds.rolesDataTable();
            appvb.ds.rolesRow fila;
            Boolean estado;


            tar.Fill(dt);
            dg.Rows.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fila = (appvb.ds.rolesRow)dt.Rows[i];

                try
                {
                    estado = fila.estado;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    estado = false;
                }

                dg.Rows.Add(estado, fila.rol, fila.Id, estado);

            }


        }
        private void frmRoles_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            Boolean estado, esta2;
            int id;
            string rol;

            for (int i = 0; i < dg.RowCount - 1; i++)
            {
                DataGridViewRow fila = dg.Rows[i];
                id = Convert.ToInt32(fila.Cells[2].Value.ToString());
                rol = fila.Cells[1].Value.ToString();
                estado = Convert.ToBoolean(fila.Cells[0].Value);
                esta2 = Convert.ToBoolean(fila.Cells[3].Value);

                if (rol.Length <3)
                {
                    MessageBox.Show("Los nombres de los roles no pueden ser de menos de 3 letras");
                    return;
                }

            }

            for (int i = 0; i < dg.RowCount - 1; i++)
            {
                DataGridViewRow fila = dg.Rows[i];
                id = Convert.ToInt32(fila.Cells[2].Value.ToString());
                rol = fila.Cells[1].Value.ToString();
                estado = Convert.ToBoolean(fila.Cells[0].Value);
                esta2 = Convert.ToBoolean(fila.Cells[3].Value);
                if (estado != esta2)
                {
                    if (rol.Length > 2)
                    {
						if (id != 7) {
							tar.Update_R(rol, estado, id);
						}
                        
                    }
                }
            }MessageBox.Show("Roles Actualizados"); 

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string rol;
            rol= txtrol.Text;
            rol = rol.TrimEnd(' ');
            rol = rol.TrimStart (' ');
            if (string.Equals(rol, "")) {
                MessageBox.Show("No se puede agregar Rol en blanco");
                return; 
            }
            appvb.dsTableAdapters.rolesTableAdapter tar = new appvb.dsTableAdapters.rolesTableAdapter();
            appvb.ds.rolesDataTable dt = new appvb.ds.rolesDataTable();
            appvb.ds.rolesRow fila;

            tar.FillByrol(dt, rol);

			if (dt.Rows.Count > 0) {
                MessageBox.Show("No se puede agregar Rol porque ya existe");
                return;
            }
            tar.Insert(rol, true);
			cargar();
		}

		private void btnlimpiar_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Puede ingresar nuevos");
		}
	}
}
