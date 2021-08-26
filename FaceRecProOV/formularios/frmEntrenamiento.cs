

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Imaging;

namespace Detector_facial
{
    public partial class frmEntrenamiento : Form
    {
		string id_asis = "5";
		string id_asis_ant = "5";
		Int32 total;
		string ruta, rutaM, rutaF;
        appvb.ds.empleadosDataTable ds_emp;
		appvb.dsTableAdapters.asis_ima_fechaTableAdapter ta_asi = new appvb.dsTableAdapters.asis_ima_fechaTableAdapter();
		appvb.ds.asis_ima_fechaDataTable dt_asi = new appvb.ds.asis_ima_fechaDataTable();
		appvb.ds.asis_ima_fechaRow fila_asi;
		appvb.dsTableAdapters.tmp_fotosTableAdapter ta_tmp = new appvb.dsTableAdapters.tmp_fotosTableAdapter();
		appvb.ds.tmp_fotosDataTable dt_tmp = new appvb.ds.tmp_fotosDataTable();
		appvb.ds.tmp_fotosRow fila_fotos; 
		string sexo;
		string sobretiempo;
		string cargas;
		string estado;
		string fondos_r;
		int contador;

		appvb.dsTableAdapters.evento_deteccionTableAdapter ta = new appvb.dsTableAdapters.evento_deteccionTableAdapter();


		int? idd = 0;

		//Declararation of all variables, vectors and haarcascades
		Image<Bgr, Byte> currentFrame;
        Capture grabber;


		 CascadeClassifier cara = new CascadeClassifier("haarcascade_frontalface_default.xml");//Our face detection method 

		MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;

		Image<Gray, byte> gray_frame = null; //grayscale current image aquired from webcam for processing

		List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
		string  entrada="NORMAL";//archivo txt sin novedades

		Classifier_Train Eigen_Recog = new Classifier_Train();

		string[] Labels;
		

		public frmEntrenamiento()
        {
            InitializeComponent();

			//Load haarcascades for face detection
			/*
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
				ta_tmp.Fill(dt_tmp);

                //Load of previus trainned faces and labels for each image
            //    string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
             //   string[] Labels = Labelsinfo.Split('%');
                NumLabels = dt_tmp.Rows.Count;
				ContTrain = NumLabels;
				llenar_labels();
				string LoadFaces;

                for (int tf = 1; tf < NumLabels+1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
				entrada = "NORMAL";
            }
            catch(Exception e)
            {
				//MessageBox.Show(e.ToString());
				entrada = "MAL";
                MessageBox.Show("La base de datos de archivo texto esta vacia, Intente regenerar el archivo desde la  opcion fotos usuario, o agregue nuevos rostros ", "Carga de fotos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Estatic.logger(e.Message); 
            }
			*/
		}

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
	
			contador = 1;
			total = Eigen_Recog.trainingImages.Count();
			appvb.dsTableAdapters.estado_civilTableAdapter taest = new appvb.dsTableAdapters.estado_civilTableAdapter();
            appvb.dsTableAdapters.cargosTableAdapter tacar = new appvb.dsTableAdapters.cargosTableAdapter();
            appvb.dsTableAdapters.seccionesTableAdapter tasec = new appvb.dsTableAdapters.seccionesTableAdapter();
           // dgf.DataSource = fotos_empTableAdapter1.GetData();

            rutaM = Application.StartupPath.ToString() + "\\foto_ced\\generico.jpg";
            rutaF = Application.StartupPath.ToString() + "\\foto_ced\\generica.jpg";
            cmbestado_civil.DataSource = taest.GetData();
            cmbestado_civil.DisplayMember = "estado";
            cmbestado_civil.ValueMember = "estado";

            cmbcargos.DataSource = tacar.GetData();
            cmbcargos.DisplayMember = "em_cargo";
            cmbcargos.ValueMember = "em_cargo";


            cmbseccion.DataSource = tasec.GetData();
            cmbseccion.DisplayMember = "em_des_seccion";
            cmbseccion.ValueMember = "em_des_seccion";
			llenar_asis50();

		}



        void nuevo() {

            chkagregando.Checked = false;
            txtcomentario.Text = "";
            txtsueldo.Text = "0.0";
            txtsu_extra.Text = "0.0";
            txtnombre.Text = "";
			imgfoto.Image = null;
			imgmini.Image = null;
            txtcedula.Text = "";
            txttelefonos.Text = "";
            txtdireccion.Text = "";
            cmbseccion.Text = "";
            cmbcargos.Text = "";
            cmbestado_civil.Text = "";
            cmbsexo.Text = "MASCULINO";
			imgfoto.Image = null;
			imgmini.Image = null;
		}

        public void cargar_empleado(string cod,string tipo) {
			txtrutafoto.Text = "";

			if (cod == "")
            {
               // MessageBox.Show("Debe indicar tipo  ced o id");
                return;
            }

            if (tipo == "") {
                MessageBox.Show("Debe indicar tipo  ced o id");
                return;
            }

            appvb.dsTableAdapters.empleadosTableAdapter ta;
            ta = new appvb.dsTableAdapters.empleadosTableAdapter();
            ds_emp = new appvb.ds.empleadosDataTable();
            try {
                switch (tipo)
                {
                    case "id":
                        {
                            ta.FillByID(ds_emp, Convert.ToInt32(cod));
                            break;
                        }
                    case "ced":
                        {
                            ta.FillByCed(ds_emp, cod);
                            break;
                        }
                    case "nom":
                        {
                            ta.FillByNombres (ds_emp, cod);
                            break;
                        }
                }
                
                try
                {
                    txtnombre.Text = ds_emp[0].em_nomlar.ToString();
                    txtcedula.Text = ds_emp[0].ced.ToString();
                
                    txtid.Text = ds_emp[0].ID.ToString();
                    txtdireccion.Text = ds_emp[0].em_direccion.ToString();
                    txttelefonos.Text = ds_emp[0].em_telefono.ToString();
         
                    cmbestado_civil.Text = ds_emp[0].em_estado_civil.ToString();
                    cmbcargos.Text = ds_emp[0].em_cargo.ToString();
                    cmbseccion.Text = ds_emp[0].em_des_seccion.ToString();
                    txtfecha_nac.Value = ds_emp[0].em_fecha_nacimiento;
                    txtsueldo.Text = ds_emp[0].em_sueldo.ToString () ;
                    txtsu_extra.Text = ds_emp[0].em_sueldo_extra.ToString();
                    txtcomentario.Text = ds_emp[0].em_comentario.ToString();
                    txtfecha_contrata.Value = ds_emp[0].em_fecha_contratacion;
					string fe;

					try {
						fe = System.Convert.ToDateTime(ds_emp[0].em_fecha_sal.ToString()).ToString("dd/MM/yyyy");
						txtfecha_salida.Text =fe;
					}
					catch (Exception ex) {
						txtfecha_salida.Text = "  /  /";
					}

					if (ds_emp[0].em_estado.ToString() == "V")
					{
						optEstadoACT.Checked = true;
						optEstadoNO_A.Checked = false;
					}
					else
					{
						optEstadoACT.Checked = false;
						optEstadoNO_A.Checked = true;
					}

					if (ds_emp[0].em_cargas.ToString() == "S")
					{
						optCargasSI.Checked = true;
						optCargasNO.Checked = false;
					}
					else
					{
						optCargasSI.Checked = false;
						optCargasNO.Checked = true;
					}


					if (ds_emp[0].em_sobretiempo.ToString() == "S")
                    {
                        optsobSI.Checked = true;
                        optsobNO.Checked = false; 
                    }
                    else
                    {
                        optsobSI.Checked = false ;
                        optsobNO.Checked = true ;
                    }

                    if (ds_emp[0].em_pago_fdo_reserva.ToString() == "S")
                    {
                        optfondosSI.Checked = true;
                        optfondosNO.Checked = false;
                    }
                    else
                    {
                        optfondosSI.Checked = false;
                        optfondosNO.Checked = true;
                    }


                    if (ds_emp[0].em_sexo.ToString() == "M")
                    {
                        cmbsexo.Text = "MASCULINO";
                    }
                    else
                    {
                        cmbsexo.Text = "FEMENINO";
                    }
                    cargar_foto();
                }
                catch (Exception ex)
                {
                    txtestado.Text = ex.Message.ToString();
                    txtestado3.Text = cod;
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            catch (Exception ex) {
                txtestado3.Text = cod;
                Console.WriteLine(ex.Message);
            }
        }

		private void btngrabar_Click(object sender, EventArgs e)
		{
            appvb.dsTableAdapters.Act_emp_TableAdapter ta;
            ta = new appvb.dsTableAdapters.Act_emp_TableAdapter();

            if (!( txtcedula.Text.Length>0 ))
            {
                MessageBox.Show("Numero no valido");
                return;
            }
            if (System.IO.File.Exists(openFileDialog1.FileName) == true)
            {
                ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula.Text + ".jpg";
                if (File.Exists(ruta)) {
                    File.Delete(ruta);
                }
				imgmini.Image = imgfoto.Image;
                File.Copy(openFileDialog1.FileName, ruta);
                ta.Actualiza_emp(ruta,txtnombre.Text, txtcedula.Text);
				Estatic.mensaje("", "Foto de perfil grabada");
                //MessageBox.Show("Grabado");
            }
        }


		private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
		{
            appvb.claseVb objvb = new appvb.claseVb();
            if (objvb.isnumber(toolStripStatusLabel1.Text)) {
                if (chkagregando.Checked == false) {
                    cargar_empleado(toolStripStatusLabel1.Text, "ced");
                }
            }
		}

		
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }

		Boolean  validar() {
			Boolean valor = false;
			if ((String.IsNullOrEmpty(txtnombre.Text)))
			{
				MessageBox.Show("Nombre esta vacio, Ingrese Apellidos y nombres");
				txtnombre.Focus();
				return false;
			}
			if (txtnombre.Text.Length < 9)
			{
				MessageBox.Show("Ingrese al menos un nombre y apellido");
				txtnombre.Focus();
				return false;
			}
			if ((String.IsNullOrEmpty(txttelefonos.Text)))
			{
				MessageBox.Show("telefono esta vacio");
				txttelefonos.Focus();
				return false;
			}
			if (txttelefonos.Text.Length < 6)
			{
				MessageBox.Show("ingrese al menos 6 digitos de número de teléfono");
				txttelefonos.Focus();
				return false;
			}

			if ((String.IsNullOrEmpty(txtdireccion.Text)))
			{
				MessageBox.Show("Direccion esta vacia");
				txtdireccion.Focus();
				return false;
			}
			if (txtdireccion.Text.Length < 6)
			{
				MessageBox.Show("Dirección es muy corta");
				txtdireccion.Focus();
				return false;
			}

			if ((String.IsNullOrEmpty(txtcedula.Text)))
			{
				MessageBox.Show("Nro de cédula esta vacio");
				txtdireccion.Focus();
				return false;
			}
			if (txtcedula.Text.Length < 4)
			{
				MessageBox.Show("Numero es muy corto");
				txtdireccion.Focus();
				return false;
			}
			if ((String.IsNullOrEmpty(cmbsexo.Text)))
			{
				MessageBox.Show("Escoja sexo");
				cmbsexo.Focus();
				return false;
			}

			if ((String.IsNullOrEmpty(cmbseccion.Text)))
			{
				MessageBox.Show("Escoja Sección");
				cmbseccion.Focus();
				return false;
			}

			if ((String.IsNullOrEmpty(cmbcargos.Text)))
			{
				MessageBox.Show("Escoja Cargo");
				cmbcargos.Focus();
				return false;
			}
			if (Convert.ToDouble(txtsueldo.Text) == 0)
			{
				MessageBox.Show("Sueldo debe ser mayor a cero");
				txtsueldo.Focus();
				return false;
			}
			return true;
		}

        private void btnadd_Click(object sender, EventArgs e)
        {
            appvb.dsTableAdapters.empleadosTableAdapter   ta = new appvb.dsTableAdapters.empleadosTableAdapter();
			int id;
			if (!(validar())){
				return; 
			}
			
			convertir();
			try
			{
				idd=appvb.variosvb.insertar_empleado   ( txtnombre.Text, txtfecha_nac.Value, txtcedula.Text, cmbcargos.Text, cmbestado_civil.Text, sexo, txtdireccion.Text, txttelefonos.Text, txtfecha_contrata.Value, txtcomentario.Text, Estatic.usuario, Microsoft.VisualBasic.Conversion.Val(txtsueldo.Text), sobretiempo, cargas, estado, Microsoft.VisualBasic.Conversion.Val(txtsu_extra.Text), cmbseccion.Text, fondos_r);
				txtid.Text = idd.ToString();
				Estatic.mensaje("", "AGREGADO", 2000);
				//MessageBox.Show(idd.ToString() );
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

            
        }
		void convertir() {

			if (string.Equals(cmbsexo.Text, "MASCULINO"))
			{
				sexo = "M";
			}
			else
			{
				sexo = "S";
			}

			if (optsobSI.Checked)
			{
				sobretiempo = "S";
			}
			else
			{
				sobretiempo = "N";
			}

			if (optCargasSI.Checked)
			{
				cargas = "S";
			}
			else
			{
				cargas = "N";
			}

			if (optEstadoACT.Checked)
			{
				estado = "V";
			}
			else
			{
				estado = "N";
			}

			if (optfondosSI.Checked)
			{
				fondos_r = "S";
			}
			else
			{
				fondos_r = "N";
			}
		}

        private void txtnombre_b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargar_empleado(txtnombre_b.Text, "nom");
            }
        }

        private void txtsueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtsu_extra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            appvb.dsTableAdapters.empleadosTableAdapter taup = new appvb.dsTableAdapters.empleadosTableAdapter();
            string sexo;

			if (!(validar()))
			{
				return;
			}
			convertir();
			sexo = Strings.Mid(cmbsexo.Text, 1, 1);
            try
            {
                taup.Empleados_Update(txtnombre.Text, txtfecha_nac.Value, cmbcargos.Text, cmbestado_civil.Text,
    sexo, txtdireccion.Text, txttelefonos.Text, cmbseccion.Text, txtcedula.Text,txtfecha_contrata.Value, txtcomentario.Text,Estatic.usuario,Convert.ToDouble(txtsueldo.Text ),sobretiempo,cargas ,estado, Convert.ToDouble(txtsu_extra.Text  ),fondos_r,Convert.ToInt32 (txtid.Text )   );
				
                MessageBox.Show("Datos Actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

			if (String.Equals(txtfecha_salida.Text, "  /  /"))
			{
				//esta vacio poner a nulo
				appvb.variosvb.actualizar_fe_sal("NULO", txtid.Text);
				MessageBox.Show("Fecha de salida actualizada en blanco");

			} else {
				if (Microsoft.VisualBasic.Information.IsDate(txtfecha_salida.Text)) {
					//si es fecha valida grabar
					appvb.variosvb.actualizar_fe_sal(txtfecha_salida.Text, txtid.Text);
					MessageBox.Show("Fecha de salida actualizada");
				}
			}
		}


        private void txtidd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargar_empleado(txtidd.Text, "id");
            }
        }

		private void txtnombre_b_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtced_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtidd_TextChanged(object sender, EventArgs e)
		{

		}

		private void bntbuscar_foto_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			try
			{
				txtrutafoto.Text = openFileDialog1.FileName;
				imgfoto.Image = Estatic.LoadBitmapUnlocked(openFileDialog1.FileName);
			}
			catch (Exception ex)
			{
				txtrutafoto.Text = "";
				imgfoto.Image = null;
			}
		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			txthora.Text = DateTime.Now.ToString("HH:mm:ss.fff");
			txtfecha.Value = Convert.ToDateTime ( DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") );
		}

		void nueva_deteccion() {
			if (!chkagregando.Checked)
			{
				dg11.Rows.Add(contador, txthora.Text, "", -1, DateTime.Now.ToString("dd/MM/yyyy"));
				contador++;
			}
			else
			{
				MessageBox.Show("Desactive el chekbox de agregando");
			}
		}

		private void btnreg_hora_Click(object sender, EventArgs e)
		{
			nueva_deteccion();
		}

		void registrar_evento(string cedula_r ) {
			try
			{
				dg11.Rows[contador - 2].Cells[2].Value = txthora.Text;
				dg11.Rows[contador - 2].Cells[3].Value = cedula_r;
				DateTime date1 = Convert.ToDateTime(dg11.Rows[contador - 2].Cells[1].Value);
				DateTime date2 = Convert.ToDateTime(dg11.Rows[contador - 2].Cells[2].Value);
				System.TimeSpan diff1 = date2.Subtract(date1);
				dg11.Rows[contador - 2].Cells[5].Value = diff1.ToString();

				ta.Insert(date1, date2, cedula_r, diff1.ToString(), Convert.ToInt64(diff1.TotalMilliseconds), NumLabels);
			}
			catch (Exception ex) {
				Console.Write(ex.Message); 
			}

		}
		private void btnfin_Click(object sender, EventArgs e)
		{
			registrar_evento("-1");

		}

		private void txtced_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargar_empleado(txtced.Text, "ced");
            }
        }

		

		private void frmDeteccion_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F10)
			{
				grabar_foto_e(result);
				return;
			}
			if (e.KeyCode == Keys.F4 )
			{
				nueva_deteccion();
				return;
			}
			
		}
		
		private void btnfalso_neg_Click(object sender, EventArgs e)
		{

			if (txtcedula.Text.Length > 0) {
				try {
					ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula.Text + "temp.jpg";
					//se graba un archivo temporal para luego recuperarlo y grabarlo en la base de datos sql server
					if (File.Exists(ruta))
					{
						File.Delete(ruta);
					}
					imageBox1.Image.Save(ruta);
					//se recupera 
					byte[] imgBytes = System.IO.File.ReadAllBytes(ruta);
					appvb.dsTableAdapters.asistenciaTableAdapter ta = new appvb.dsTableAdapters.asistenciaTableAdapter();
					ta.Update_asis_image("FALSO NEGATIVO", imgBytes, Convert.ToInt64(id_asis));
				} catch (Exception ex ) {
					Console.Write(ex.Message);
					return;

				}

			}

		}

		private void btnfalso_po_Click(object sender, EventArgs e)
		{
			ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula.Text + "temp.jpg";
			//se graba un archivo temporal para luego recuperarlo y grabarlo en la base de datos sql server
			if (File.Exists(ruta))
			{
				File.Delete(ruta);
			}
			try
			{
				imageBox1.Image.Save(ruta);
				//se recupera 
				byte[] imgBytes = System.IO.File.ReadAllBytes(ruta);

				appvb.dsTableAdapters.asistenciaTableAdapter ta = new appvb.dsTableAdapters.asistenciaTableAdapter();

				ta.Update_asis_image("FALSO POSITIVO", imgBytes, Convert.ToInt64(id_asis));

			}
			catch (Exception ex) {
				Console.Write(ex.Message); 
			}
	
		}

		private void btnsalto_Click(object sender, EventArgs e)
		{
			id_asis = appvb.variosvb.reg_asistencia("SALTO", NumLabels,txtfecha.Value , txtfecha.Value);
			appvb.variosvb.actualizar_asis("SALTO", id_asis);
		}

		private void btnact_reg_asist_Click(object sender, EventArgs e)
		{
			chkreg_asis.Checked = true;
			chkagregando.Checked = false;
		}


		private void btnactivar_Click(object sender, EventArgs e)

		{
			try {
				//Initialize the FrameGraber event
				Application.Idle += new EventHandler(FrameGrabber_Standard);
				btnactivar.Enabled = false;
			}
			catch (Exception ex) {

			}
			try
			{
				grabber = new Capture();
				grabber.QueryFrame();
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
			}
		}

		void desactivar() {
			btnactivar.Enabled = true;
			imageBoxFrameGrabber.Image = null;
			imageBox1.Image = null;
			try {
				grabber.Dispose();
				Application.Idle -= new EventHandler(FrameGrabber_Standard);
			}
			catch (Exception ex) {
				Console.Write(ex.Message);
			}
			
		}
		private void btndesactivar_Click(object sender, EventArgs e)
		{
			desactivar();
		}

		private void btnagregar_rostro_Click(object sender, EventArgs e)
		{
			grabar_foto_e(result);
			//agregar();
			//desactivar();
		}

private void btnsubir_archivo_Click(object sender, EventArgs e)
{
	System.Drawing.Image ima;			 
	if (openFileDialog_detect.ShowDialog() == DialogResult.OK)
	{
		//abre imagen sin bloqueo
		ima= Estatic.LoadBitmapUnlocked (openFileDialog_detect.FileName);
		Bitmap mat = new Bitmap(ima);
		//convierte al tipo image de emgu
		imageBoxFrameGrabber.Image = new Image<Bgr, Byte>(mat);
		currentFrame = (Image<Bgr, Byte>)imageBoxFrameGrabber.Image;
		if (currentFrame != null)
		{
			gray_frame = currentFrame.Convert<Gray, Byte>();
			//Face Detector
			Rectangle[] facesDetected = cara.DetectMultiScale(gray_frame, 1.15, 7, new Size(25, 25), Size.Empty);
			try
			{
				result = currentFrame.Copy(facesDetected[0]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				currentFrame.Draw(facesDetected[0], new Bgr(Color.Red), 2);
				currentFrame.Draw(" ", ref font, new Point(facesDetected[0].X + 2, facesDetected[0].Y + 2), new Bgr(Color.LightGreen));
				imageBox1.Image = result;
			}
			catch (Exception ex) {
				Console.Write (ex.Message);
				MessageBox.Show("No se detecta ningun rostro, la cara debe estar la frente descubierta, ambos ojos se deben ver con claridad, con suficiente luz");
			}
		}
	}
}

		public void cargar_foto() {
            ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula.Text + ".jpg";
            if (txtcedula.Text.Length > 0)
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
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(rutaM);
                        }
                        else {
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(rutaF);
                        }
                    }
					imgmini.Image = imgfoto.Image;   
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

		private void btndetectar_Click(object sender, EventArgs e)
		{
			detectar();
		}

		private void btnver_fotos_e_Click(object sender, EventArgs e)
		{
			frmregistrados ffr = new Detector_facial.frmregistrados();
			ffr.MdiParent = this.MdiParent;
			ffr.Show();
			ffr.txtcedula_b.Text = txtcedula.Text;
			ffr.buscar_origen();    
		}

		private void btnrecargar_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			Eigen_Recog.Retrain();
			Estatic.mensaje("", "Base de Actualizada, lista para Reconocimiento");
			Cursor.Current = Cursors.Default;

		}

		private void btnborrar_Click(object sender, EventArgs e)
		{
			
			if (txtcedula.Text.Length > 0) {
				if (appvb.variosvb.isnumericvb(txtcedula.Text)) {
					DialogResult dialogResult = MessageBox.Show("¿Desea borrar de Perfil SI / NO?", "Confirmación de  Borrado", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.No)
					{
						return;
					}
					string ruta2 = Application.StartupPath.ToString() + "\\foto_ced\\" + txtcedula.Text +".jpg";
					try {
						if (File.Exists(ruta2))
						{
							File.Delete(ruta2);
							imgfoto.Image = null;
							imgmini.Image = null;   
						}
					}
					catch (Exception ex)
					{
						Console.Write(ex.Message); 
					}
				}
			}
		}

		void llenar_asis50()
		{
			DataTable dtt = new DataTable();
			DataRow fil;
			DateTime hh;
			string ced, hora, nombre, fecha;
			dtt = appvb.variosvb.get_asis50();

			Cursor.Current = Cursors.WaitCursor;
			dg11.Rows.Clear();

			for (int kl = 0; kl < dtt.Rows.Count; kl++)
			{

				fil = dtt.Rows[kl];
				ced = fil[1].ToString();
				nombre = fil[0].ToString();
				hh = Convert.ToDateTime(fil[3]);
				fecha = hh.ToShortDateString();
				hh = Convert.ToDateTime(fil[2]);
				hora = hh.ToString("HH:mm:ss.fff");
				try
				{
					dg11.Rows.Add(kl + 1, ced, hora, nombre, fecha);
				}
				catch (Exception ex)
				{
					Console.Write(ex.Message);
				}


			}
			Cursor.Current = Cursors.Default;
		}


		private void grabar_foto_e(Image<Gray, byte> cara_recortada)
		{
			Int32 id_tmp;
			if (cara_recortada == null) {
				MessageBox.Show("No HAY IMAGEN CARGADA");
				return; 
			}
			if (txtcedula.Text.Length <= 0)
			{
				MessageBox.Show("debe cargar datos para poder asignar foto");
			}
			try
			{
				string nombre,ruta3;
				id_tmp = appvb.variosvb.ins_nueva(txtcedula.Text);
				if (id_tmp !=-1)
				{

					Eigen_Recog.trainingImages.Add(cara_recortada);
					Eigen_Recog.Names_List.Add(txtcedula.Text);
					Eigen_Recog.Names_List_ID.Add(id_tmp);
					Image ima;
					ima = cara_recortada.ToBitmap();
					nombre = "face" + id_tmp.ToString() + ".jpg";

					ruta3 = Application.StartupPath + "/TrainedFaces/" + nombre;
					if (Directory.Exists(Application.StartupPath + "/TrainedFaces/"))
					{
						
					}
					else
					{
						Directory.CreateDirectory(Application.StartupPath + "/TrainedFaces/");
						//ima.Save(Application.StartupPath + "/TrainedFaces/" + nombre, ImageFormat.Jpeg);
					}
					if (File.Exists(ruta3))
					{
						try
						{
							File.Delete(ruta3);

						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
					try
					{
						ima.Save(ruta3, ImageFormat.Jpeg);
						imageBoxFrameGrabber.Image = null;
						imageBox1.Image = null;
						Estatic.mensaje("Foto GRABADA:" + id_tmp.ToString(), txtnombre.Text, 3000);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				else {
					MessageBox.Show("Error de conexion con la base de datos");
					return;
				}
				 
			}
			catch (Exception ex) {
				Estatic.mensaje("Error",ex.Message);
			}
		}

		void detectar() {
			//Get the current frame form capture device

				currentFrame = (Image<Bgr, Byte>)imageBoxFrameGrabber.Image;
			//imageBoxFrameGrabber.Image = currentFrame;
			//Convert it to Grayscale
			if (currentFrame != null)
			{
				gray_frame = currentFrame.Convert<Gray, Byte>();

				//Face Detector
				Rectangle[] facesDetected = cara.DetectMultiScale(gray_frame, 1.15, 7, new Size(25, 25), Size.Empty);

					//draw the face detected in the 0th (gray) channel with blue color
					//currentFrame.Draw(facesDetected[0], new Bgr(Color.Red), 2);
					if (chkagregando.Checked != true)
					{
						if (Eigen_Recog.IsTrained)
						{
							string name = Eigen_Recog.Recognise(result);
							if (appvb.variosvb.isnumericvb(name))
							{
								int match_value = (int)Eigen_Recog.Get_Eigen_Distance;
								//Draw the label for each face detected and recognized
								currentFrame.Draw(name + " ", ref font, new Point(facesDetected[0].X + 2, facesDetected[0].Y + 2), new Bgr(Color.LightGreen));
								cargar_empleado(name, "ced");
								Estatic.mensaje("", "Cargado", 350);
							}
							else
							{
								nuevo();
							}
						}
					}
			//	}
				//Show the faces procesed and recognized
				//Image<Gray, Byte> grayImage = currentFrame.Convert<Gray, Byte>();
				//imageBox1.Image = grayImage;
				imageBox1.Image = result;
				//	image_PICBX.Image = currentFrame.ToBitmap();
			}

		}
		//Process Frame
		void FrameGrabber_Standard(object sender, EventArgs e)
		{
			//Get the current frame form capture device
			if (chkarchivo.Checked)
			{
				currentFrame =(Image<Bgr, Byte>) imageBoxFrameGrabber.Image;
			}
			else {
				currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
			}
			
			imageBoxFrameGrabber.Image = currentFrame; 
			//Convert it to Grayscale
			if (currentFrame != null)
			{
				gray_frame = currentFrame.Convert<Gray, Byte>();

				//Face Detector
				Rectangle[] facesDetected = cara.DetectMultiScale(gray_frame, 1.15, 7, new Size(25, 25), Size.Empty);

				//Action for each element detected
				for (int i = 0; i < facesDetected.Length; i++)// (Rectangle face_found in facesDetected)
				{
					//This will focus in on the face from the haar results its not perfect but it will remove a majoriy
					//of the background noise
					//facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
					//facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
					//facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
					//facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.35);
					result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
					//result._EqualizeHist();
					//draw the face detected in the 0th (gray) channel with blue color
					currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);
					if (chkagregando.Checked != true)
					{
						if (Eigen_Recog.IsTrained)
						{
							string name = Eigen_Recog.Recognise(result);
							if (appvb.variosvb.isnumericvb(name))
							{
								int match_value = (int)Eigen_Recog.Get_Eigen_Distance;
								//Draw the label for each face detected and recognized
								currentFrame.Draw(name + " ", ref font, new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2), new Bgr(Color.LightGreen));
								cargar_empleado(name, "ced");
								Estatic.mensaje("", "Cargado", 350);
								desactivar();
							}
							else {
								nuevo();
							}
						}
					}
				}
				//Show the faces procesed and recognized
				//Image<Gray, Byte> grayImage = currentFrame.Convert<Gray, Byte>();
				//imageBox1.Image = grayImage;
				imageBox1.Image = result;
				//	image_PICBX.Image = currentFrame.ToBitmap();
			}
		}

		void FrameGrabber_Parrellel(object sender, EventArgs e)
		{
			//Get the current frame form capture device
			currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

			//Convert it to Grayscale
			//Clear_Faces_Found();

			if (currentFrame != null)
			{
				gray_frame = currentFrame.Convert<Gray, Byte>();
				//Face Detector
				Rectangle[] facesDetected = cara.DetectMultiScale(gray_frame, 1.2, 10, new Size(50, 50), Size.Empty);

				//Action for each element detected
				Parallel.For(0, facesDetected.Length, i =>
				{
					try
					{
						facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
						facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
						facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
						facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.35);

						result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
						result._EqualizeHist();
						//draw the face detected in the 0th (gray) channel with blue color
						currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);

						if (Eigen_Recog.IsTrained)
						{
							//justo aqui reconoce
							Cursor.Current = Cursors.WaitCursor; 

							string name = Eigen_Recog.Recognise(result);
							Cursor.Current = Cursors.Default;

							int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

							//Draw the label for each face detected and recognized
							currentFrame.Draw(name + " ", ref font, new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2), new Bgr(Color.LightGreen));
							//ADD_Face_Found(result, name, match_value);
						}

					}
					catch
					{
						//do nothing as parrellel loop buggy
						//No action as the error is useless, it is simply an error in 
						//no data being there to process and this occurss sporadically 
					}
				});
				//Show the faces procesed and recognized
				Image<Gray, Byte> grayImage = currentFrame.Convert<Gray, Byte>();
				imageBox1.Image = grayImage;
			}
		}


	}
}