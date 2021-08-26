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
    public partial class frm_selec_roles : Form
    {
        public frm_selec_roles()
        {
            InitializeComponent();
        }

        DataGridViewRow fila_usu;

        int fila_sel_usu;

        void llenar_roles()
        {
            int i;
            appvb.dsTableAdapters.rol_usuarioTableAdapter tarolu;

            appvb.dsTableAdapters.rolesRestantesTableAdapter tarolesr = new appvb.dsTableAdapters.rolesRestantesTableAdapter();
            appvb.ds.rolesRestantesDataTable dtrolesr = new appvb.ds.rolesRestantesDataTable();
   

            tarolu = new appvb.dsTableAdapters.rol_usuarioTableAdapter();
            appvb.ds.rol_usuarioDataTable dtrolu = new appvb.ds.rol_usuarioDataTable();
            appvb.ds.rol_usuarioRow fila_rolu;

            tarolu.Fill(dtrolu, Convert.ToInt32(Estatic.id_usuario ));

            dgrolesu.Rows.Clear();
            if (dtrolu.Rows.Count < 1) {
                MessageBox.Show("Usuario no tiene roles");
                return; 
            }
            for (i = 0; i < dtrolu.Rows.Count; i++)
            {
                fila_rolu = (appvb.ds.rol_usuarioRow)dtrolu.Rows[i];
                dgrolesu.Rows.Add(fila_rolu.id_rol, fila_rolu.rol);
            }
        }

        private void frm_selec_roles_Load(object sender, EventArgs e)
        {
            llenar_roles();
        }


        private void dgrolesu_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

            fila_sel_usu = e.Cell.RowIndex;
            try
            {
                fila_usu = dgrolesu.Rows[e.Cell.RowIndex];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            string rol;
            int id_rol;
            try {
                if (!(String.IsNullOrEmpty(fila_usu.Cells[1].Value.ToString())))
                {
                    id_rol = Convert.ToInt32(fila_usu.Cells[0].Value.ToString());
                    rol = fila_usu.Cells[1].Value.ToString();
                    
                    Estatic.rol = rol;
                    Estatic.id_rol = id_rol;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Debe hacer clic y seleccionar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("No ha elegido Rol");
                Console.Write(ex.Message); 
                this.Dispose();
            }



        }

        private void dgrolesu_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }
        

       
    }
}
