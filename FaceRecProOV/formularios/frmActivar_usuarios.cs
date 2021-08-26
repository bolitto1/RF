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
    public partial class frmActivar_usuarios : Form
    {
        appvb.ds.empleadosDataTable ds_emp;
        appvb.dsTableAdapters.empleadosTableAdapter ta;
        appvb.ds.empleadosRow fila;
        appvb.dsTableAdapters.rol_usuarioTableAdapter tarolu;

        DataGridViewRow fila_res;
        DataGridViewRow fila_usu;

        int fila_sel;
        int fila_sel_usu;

        public frmActivar_usuarios()
        {
            InitializeComponent();
        }

        private void frmActivar_usuarios_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btngrabar, "Solo actualiza el usuario para el sistema");
            appvb.dsTableAdapters.estado_civilTableAdapter taest = new appvb.dsTableAdapters.estado_civilTableAdapter();
            appvb.dsTableAdapters.cargosTableAdapter tacar = new appvb.dsTableAdapters.cargosTableAdapter();
            appvb.dsTableAdapters.seccionesTableAdapter tasec = new appvb.dsTableAdapters.seccionesTableAdapter();

            cmbestado_civil.DataSource = taest.GetData();
            cmbestado_civil.DisplayMember = "estado";
            cmbestado_civil.ValueMember = "estado";

            cmbcargos.DataSource = tacar.GetData();
            cmbcargos.DisplayMember = "em_cargo";
            cmbcargos.ValueMember = "em_cargo";


            cmbseccion.DataSource = tasec.GetData();
            cmbseccion.DisplayMember = "em_des_seccion";
            cmbseccion.ValueMember = "em_des_seccion";
        }


        void cargar_vacio()
        {
            txtnombre1.Text = "";
            txtcedula1.Text = "";
            txtdireccion.Text = "";
            txttelefonos.Text = "";

            cmbestado_civil.Text = "";
            cmbcargos.Text = "";
            cmbseccion.Text = "";
            txtusuario.Text = "";
            imgfoto.Image = imgnofound.Image;

        }

        void llenar_roles() {
            int i;
            appvb.dsTableAdapters.rolesRestantesTableAdapter tarolesr = new appvb.dsTableAdapters.rolesRestantesTableAdapter();
            appvb.ds.rolesRestantesDataTable dtrolesr = new appvb.ds.rolesRestantesDataTable();
            appvb.ds.rolesRestantesRow fila_rolesr;

             tarolu = new appvb.dsTableAdapters.rol_usuarioTableAdapter();
            appvb.ds.rol_usuarioDataTable dtrolu = new appvb.ds.rol_usuarioDataTable();
            appvb.ds.rol_usuarioRow fila_rolu;

            tarolesr.Fill(dtrolesr, Convert.ToInt32 ( fila.ID));

            tarolu.Fill(dtrolu, Convert.ToInt32(fila.ID));
            dgrestan.Rows.Clear();
            for ( i = 0; i < dtrolesr.Rows.Count; i++) {
                fila_rolesr =   (appvb.ds.rolesRestantesRow)dtrolesr.Rows[i];
                dgrestan.Rows.Add(fila_rolesr.Id, fila_rolesr.rol);  
            }
            dgrolesu.Rows.Clear();
            for (i = 0; i < dtrolu.Rows.Count ; i++) {
                fila_rolu = (appvb.ds.rol_usuarioRow ) dtrolu.Rows[i];
                dgrolesu.Rows.Add(fila_rolu.id_rol, fila_rolu.rol); 
            }
        }


        void cargar_resto()
        {
            txtnombre1.Text = fila.em_nomlar;
            txtcedula1.Text = fila.ced;
            txtdireccion.Text = ds_emp[0].em_direccion.ToString();
            txttelefonos.Text = ds_emp[0].em_telefono.ToString();
            txtid.Text = fila.ID.ToString() ; 
            cmbestado_civil.Text = ds_emp[0].em_estado_civil.ToString();
            cmbcargos.Text = ds_emp[0].em_cargo.ToString();
            cmbseccion.Text = ds_emp[0].em_des_seccion.ToString();
            txtfecha_nac.Value = ds_emp[0].em_fecha_nacimiento;
            try
            {
                txtusuario.Text = ds_emp[0].usuario;
            }
            catch (Exception ex) {
                txtusuario.Text = "";
                Console.Write(ex.Message);

            }
           
            llenar_roles();
            if (ds_emp[0].em_sexo.ToString() == "M")
            {
                cmbsexo.Text = "MASCULINO";
            }
            else
            {
                cmbsexo.Text = "FEMENINO";
            }

            try {
                if (ds_emp[0].es_usuario_sys == true)
                {
                    optes_usuSI.Checked = true;
                }
                else {
                    optes_usuNO.Checked = true; 
                }
            } catch (Exception ex) {
                Console.Write(ex.Message);
                optes_usuSI.Checked = false;
                optes_usuNO.Checked = true;
            }
            try
            {
                if (ds_emp[0].est_usu_sys == true)
                {
                    opt_estadoACT.Checked = true;
                }
                else {
                    opt_estadoNOACT.Checked = true; 
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                opt_estadoACT.Checked = false;
                opt_estadoNOACT.Checked = true;
            }

            cargar_foto();

        }

        public void cargar_foto()
        {
            string ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula1.Text + ".jpg";
            if (txtcedula1.Text.Length > 0)
            {
                try
                {
                    if (File.Exists(ruta))
                    {
                        imgfoto.Image = Estatic.LoadBitmapUnlocked(ruta);
                    }
                    else
                    {
                        if (cmbsexo.Text == "M")
                        {
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(Estatic.rutaM());
                        }
                        else
                        {
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(Estatic.rutaF());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message); 
                }
            }
        }


        public void buscar() {
            ta = new appvb.dsTableAdapters.empleadosTableAdapter();
           ds_emp = new appvb.ds.empleadosDataTable();
            string cad = Microsoft.VisualBasic.Strings.Trim(txtnombre_b.Text);
            string ced = Microsoft.VisualBasic.Strings.Trim(txtcedula_b.Text);
            string id = Microsoft.VisualBasic.Strings.Trim(txtID_B.Text);


            txtnombre_b.Text = "";
            txtcedula_b.Text = "";
            txtID_B.Text = "";

            if (!(String.IsNullOrEmpty(cad)))
            {
                ta.FillByNombres(ds_emp, cad);
                if (ds_emp.Rows.Count > 0)
                {
                    fila = (appvb.ds.empleadosRow)ds_emp.Rows[0];
                    cargar_resto();
                }
                else
                {
                    cargar_vacio();
                }
            }
            else
            {
                //MessageBox.Show("No hay nombre a consultar");
                if (Microsoft.VisualBasic.Information.IsNumeric(ced))
                {
                    ta.FillByCed(ds_emp, ced);
                    if (ds_emp.Rows.Count > 0)
                    {
                        fila = (appvb.ds.empleadosRow)ds_emp.Rows[0];
                        cargar_resto();
                    }
                    else
                    {
                        cargar_vacio();
                    }
                }
                else
                {
                    if (Microsoft.VisualBasic.Information.IsNumeric(id))
                    {
                        ta.FillByID (ds_emp, Convert.ToInt32(id)); 
                        if (ds_emp.Rows.Count > 0)
                        {
                            fila = (appvb.ds.empleadosRow)ds_emp.Rows[0];
                            cargar_resto();
                        }
                        else
                        {
                            cargar_vacio();
                        }

                    }
                    else {
                        MessageBox.Show("No hay nombre o cedula o ID para consultar");
                    }
                       
                }
            }
        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnbuscar_origen_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsetpassw_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtid.Text)) {
                MessageBox.Show("No se ha cargado ningun empleado, para establecer contraseña");
                return; 
            }
            if (String.IsNullOrEmpty(txtusuario.Text)){
                MessageBox.Show("nombre de usuario no debe estar en blanco");
                return;
            }
            frmcrearClave ff = new frmcrearClave();
            ff.MdiParent = this.MdiParent;
            ff.txtid.Text = txtid.Text;
            ff.txtnombre1.Text = txtnombre1.Text;
            ff.txtusuario.Text = txtusuario.Text;  
            ff.Show();

        }

        private void dgrestan_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
           txtestado.Text = Convert.ToString (   e.Cell.RowIndex   );
            fila_sel = e.Cell.RowIndex;
            try
            {
                fila_res = dgrestan.Rows[e.Cell.RowIndex];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            string id, rol;
            try
            {
                if (!(String.IsNullOrEmpty(fila_res.Cells[1].Value.ToString())))
                {
                    rol = fila_res.Cells[1].Value.ToString();
                    id = fila_res.Cells[0].Value.ToString();
                    dgrolesu.Rows.Add(id, rol);
                    dgrestan.Rows.RemoveAt(fila_sel);
                }
            }
            catch (Exception ex) {
                Console.Write(ex.Message); 
            }
        }

        private void dgrolesu_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            txtestado.Text = Convert.ToString(e.Cell.RowIndex);
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

        private void btndesasignar_Click(object sender, EventArgs e)
        {
            string id, rol;
            try
            {
                if (!(String.IsNullOrEmpty(fila_usu.Cells[1].Value.ToString())))
                {
                    rol = fila_usu.Cells[1].Value.ToString();
                    id = fila_usu.Cells[0].Value.ToString();
                    dgrolesu.Rows.RemoveAt(fila_sel_usu);

                    dgrestan.Rows.Add(id, rol);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        void actualizar_roles() {
            



        }
        private void btngrabar_Click(object sender, EventArgs e)
        {
            tarolu = new appvb.dsTableAdapters.rol_usuarioTableAdapter();
            //sino esta vacio el id  tomando en cuenta que este campo no se puede llenar desde el formulario sino solo cuando se consulto
            int id, rol;

            if ((String.IsNullOrWhiteSpace(txtid.Text)))
            {
                MessageBox.Show("No hay datos, recupere algun empleado");
                return;
            }
            else
            {
                //primero borramos todos para volver a grabar los que esten
                id = Convert.ToInt32(txtid.Text);

                tarolu.Del_todos_rol_usu(id);
                for (int i = 0; i < dgrolesu.RowCount - 1; i++)
                {
                    DataGridViewRow fila = dgrolesu.Rows[i];
                    rol = Convert.ToInt32(fila.Cells[0].Value.ToString());
                    tarolu.Ins_rol_usuario(id, rol);
                }

            }
            id = Convert.ToInt32(txtid.Text);
            Boolean es_usu, estado_usu;
            if (optes_usuSI.Checked) {
                es_usu = true;
            } else {
                es_usu = false;
            }

            if (opt_estadoACT.Checked)
            {
                estado_usu = true;
            }
            else
            {
                estado_usu = false;
            }
            ta.Update_usu(es_usu, estado_usu, txtusuario.Text, id);
            MessageBox.Show("Registro Actualizado");
        }


        private void dgrolesu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                buscar();
            }
        }

        private void txtID_B_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtcedula_b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void txtnombre_b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }
    }
}
