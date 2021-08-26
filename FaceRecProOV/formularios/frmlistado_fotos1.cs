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
using System.Drawing.Imaging;


namespace Detector_facial
{
    public partial class frmlistado_fotos1 : Form
    {
        Bitmap inImg;
        appvb.dsTableAdapters.fotos_selec_empTableAdapter tafs = new appvb.dsTableAdapters.fotos_selec_empTableAdapter();
        appvb.ds.fotos_selec_empDataTable dtff = new appvb.ds.fotos_selec_empDataTable();
        int[] lista = new int[100];
        string ruta_im;
        int posicion;
        string nombre, p1;
        string ruta_borrar, ruta_renom, ruta_nuevo_nom;

        string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";
        string ruta2 = Application.StartupPath;

        public frmlistado_fotos1()
        {
            InitializeComponent();
        }

        private void frmlistado_fotos1_Load(object sender, EventArgs e)
        {
            appvb.dsTableAdapters.vw_cant_fotosTableAdapter  tafe = new appvb.dsTableAdapters.vw_cant_fotosTableAdapter();
            vwcantfotosBindingSource.DataSource = tafe.GetData();
            //dg.DataSource = tafe.GetData();

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            txtcedula.Text = Convert.ToString(dg.CurrentRow.Cells[0].Value);
            txtnombre.Text = Convert.ToString(dg.CurrentRow.Cells[2].Value);
            cargar_empleado(txtcedula.Text, "ced", "1");

            tafs.Fill(dtff, txtcedula.Text);
            dgf.DataSource = dtff;
            cargar_fotos();

        }
        void cargar_fotos() {


            dgim.Columns.Clear();
            dgim.Rows.Clear();

            DataGridViewImageColumn img;
            appvb.ds.fotos_selec_empRow  fila;
            img = new DataGridViewImageColumn();
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            fila = (appvb.ds.fotos_selec_empRow  )dtff.Rows[0];
            ruta_im = String.Concat(ruta2, "\\TrainedFaces\\face", fila.pos.ToString(), ".bmp");
            try
            {

                inImg = (Bitmap)LoadBitmapUnlocked(ruta_im);
            }
            catch
            {
                inImg = (Bitmap)imgg.Image;
            }


            lista[0] = fila.pos;
            //MessageBox.Show(row.Cells[0].Value.ToString()); //es la cedula
            //img.Image = pictureBox1.Image;
            img.Image = inImg;
            img.Width = 140;
            dgim.Columns.Add(img);
            dgim.Rows.Add(1);
            dgim.Rows[0].Height = 140;

            for (int i = 1; i < dtff.Rows.Count; i++)
            {
                DataGridViewImageColumn img2 = new DataGridViewImageColumn();
                img2.ImageLayout = DataGridViewImageCellLayout.Zoom;

                fila = (appvb.ds.fotos_selec_empRow)dtff.Rows[i];
                lista[i] = fila.pos;
                ruta_im = String.Concat(ruta2, "\\TrainedFaces\\face", fila.pos.ToString(), ".bmp");

                try {
                    inImg = (Bitmap)LoadBitmapUnlocked(ruta_im);
                }
                catch(Exception ex) {
                   
                    inImg = (Bitmap)imgg.Image;
                    Console.Write  (ex);
                }
                img2.Image = inImg;
                img2.Width = 140;
                dgim.Columns.Add(img2);
            }
        }


        public void cargar_empleado(string cod, string tipo,string num ) {
            appvb.ds.empleadosDataTable ds_emp;

            if (tipo == "") {
                MessageBox.Show("Debe indicar tipo  ced o id");
                return;
            }
            appvb.dsTableAdapters.empleadosTableAdapter ta;
            ta = new appvb.dsTableAdapters.empleadosTableAdapter();
            ds_emp = new appvb.ds.empleadosDataTable();
            try {
                switch (tipo) {
                    case "id": {
                            ta.FillByID(ds_emp, Convert.ToInt32(cod));
                            break;
                        }
                    case "ced": {
                            ta.FillByCed(ds_emp, cod);
                            break;
                        }
                    case "nom":
                        {
                            ta.FillByNombres (ds_emp, cod);
                            break;
                        }
                }
            }
            catch (Exception ex) {

               MessageBox.Show  (ex.Message);

            }
            try {
                switch (num) {
                    case "1": {
                                txtnombre.Text = ds_emp[0].em_nomlar.ToString();
                                txtcedula.Text = ds_emp[0].ced.ToString();
                                cargar_foto(ds_emp[0].ced.ToString(), img1);
                                break;
                            }
                    case "2": {
                                txtnombre2.Text = ds_emp[0].em_nomlar.ToString();
                                txtcedula2.Text = ds_emp[0].ced.ToString();
                                cargar_foto(ds_emp[0].ced.ToString(), img2);
                                break; 
                        }

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }


        }
        // Load a bitmap without locking it.
        private Bitmap LoadBitmapUnlocked(string file_name) {
            using (Bitmap bm = new Bitmap(file_name)) {
                return new Bitmap(bm);
            }
        }

        public void cargar_foto(string cedula, PictureBox ima ) {
            ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + cedula.Trim() + ".jpg";
           
            if (cedula.Length > 0) {
                try  {
                    if (File.Exists(ruta)) {
                     //   MessageBox.Show(ruta);
                        ima.Image = LoadBitmapUnlocked(ruta);
                    }
                    else {
                        ima.Image = imgg.Image;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message); 
                }
            }
        }


        private void txtcedula2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (txtcedula2.Text.Trim() != "") {
                    cargar_empleado(txtcedula2.Text, "ced","2");
                }
            }
        }

        private void txtnombre2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (txtcedula2.Text.Trim() != "") {
                    cargar_empleado(txtnombre2.Text, "nom","2");
                }
            }
        }

        private void dgim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpos.Text = lista[e.ColumnIndex ].ToString();
            posicion = lista[e.ColumnIndex];
            MemoryStream ms = new MemoryStream();
            Bitmap img33 = (Bitmap)dgim.CurrentRow.Cells[e.ColumnIndex ].Value;
            img33.Save(ms, ImageFormat.Jpeg);
            img.Image = Image.FromStream(ms);
        }

        private void cmdgenerar_Click(object sender, EventArgs e)
        {
            //se vuelve a crear el archivo + "\\TrainedFaces\\TrainedLabels.txt";
            //y se renombran las fotos
            recrear();

            //string text2 = "This is text to be appended";
            //File.AppendAllText(ruta, text2);

        }

        private void dg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
            }
        }

        private void dgf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void nuevo_arch_texto() { 
        }

        void recrear() {

            int nueva_pos;
            appvb.dsTableAdapters.fotos_selec_empTableAdapter  ta = new appvb.dsTableAdapters.fotos_selec_empTableAdapter();
            appvb.ds.fotos_selec_empDataTable  dt = new appvb.ds.fotos_selec_empDataTable();
            appvb.ds.fotos_selec_empRow fila;
            ta.FillByTODOS(dt);

            string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels2.txt";
            string text1 = dt.Rows.Count.ToString() ;
            File.WriteAllText(ruta, text1);
           // MessageBox.Show("hola");
            File.AppendAllText(ruta, "%");
            fila = (appvb.ds.fotos_selec_empRow)dt.Rows[dt.Rows.Count-1];
            text1 = Convert.ToString(fila.ced);
            File.AppendAllText(ruta, text1);
            File.AppendAllText(ruta, "%");

            for (nueva_pos = 0; nueva_pos < dt.Rows.Count; nueva_pos++)
            {
                fila = (appvb.ds.fotos_selec_empRow)dt.Rows[nueva_pos ];
                text1 = Convert.ToString(fila.ced );
                File.AppendAllText(ruta, text1);
                File.AppendAllText(ruta, "%");
            }
            

            for (nueva_pos = 0; nueva_pos< dt.Rows.Count; nueva_pos++) {
                fila = (appvb.ds.fotos_selec_empRow)dt.Rows[nueva_pos ];
                p1=Convert.ToString(nueva_pos+1);
                p1 = p1.Trim();
                if (fila.pos != (nueva_pos+1)) {
                    ruta_renom = String.Concat(ruta2, "\\TrainedFaces\\face", fila.pos.ToString(), ".bmp");
                    ruta_nuevo_nom = String.Concat(ruta2, "\\TrainedFaces\\face", p1, ".bmp");
                    MessageBox.Show(ruta_renom, ruta_nuevo_nom);
                    try
                    {
                        File.Move(ruta_renom, ruta_nuevo_nom);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    nombre = String.Concat("face", p1);
                    try
                    {
                        ta.Update(nueva_pos, nombre, fila.id, fila.id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    
                   
                } 
            }
        }
        private void cmdborrar_Click(object sender, EventArgs e)        {
            //al borrar se debe volver a crear el archivo texto
            //renombrar todas las imagenes
            //primero borrar en la tabla
            //y en base a la tabla recorrer hasta llegar a al posicion
            //y a partir de la posicion ir renombrando los archivos

            appvb.dsTableAdapters.fotos_selec_empTableAdapter ta = new appvb.dsTableAdapters.fotos_selec_empTableAdapter();

            ruta_borrar = String.Concat(ruta2, "\\TrainedFaces\\face", posicion.ToString(), ".bmp");
            

            if (File.Exists(ruta_borrar))
            {
                MessageBox.Show(ruta_borrar);
                try {
                    File.Delete(ruta_borrar);
                    ta.Delete(posicion);
                    recrear();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }



            }
        }
    }
}
