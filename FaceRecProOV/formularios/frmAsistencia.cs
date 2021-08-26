
//Multiple face detection and recognition in real time
//Using EmguCV cross platform .Net wrapper to the Intel OpenCV image processing library for C#.Net
//Writed by Sergio Andrés Guitérrez Rojas
//"Serg3ant" for the delveloper comunity
// Sergiogut1805@hotmail.com
//Regards from Bucaramanga-Colombia ;)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.Data;

namespace Detector_facial
{
    public partial class frmAsistencia : Form
    {
		string id_asis = "5";
		string id_asis_ant = "5";
		DateTime diferencia_tiempo;
		DateTime hora1, hora2, hora_t1, hora_t2;
		Double tiempo_detect=0;
		Boolean activado = true;
		string ruta, rutaM, rutaF, cedula_anterior;
        appvb.ds.empleadosDataTable ds_emp;
		appvb.dsTableAdapters.asis_ima_fechaTableAdapter ta_asi = new appvb.dsTableAdapters.asis_ima_fechaTableAdapter();
		appvb.ds.asis_ima_fechaDataTable dt_asi = new appvb.ds.asis_ima_fechaDataTable();
		appvb.ds.asis_ima_fechaRow fila_asi;  
		int contador;
		string estado_emp;

		appvb.dsTableAdapters.evento_deteccionTableAdapter ta = new appvb.dsTableAdapters.evento_deteccionTableAdapter();
		appvb.dsTableAdapters.tmp_fotosTableAdapter ta_tmp = new appvb.dsTableAdapters.tmp_fotosTableAdapter();
		appvb.ds.tmp_fotosDataTable dt_tmp = new appvb.ds.tmp_fotosDataTable();
		appvb.ds.tmp_fotosRow fila_fotos;
		int? idd = 0;

		//Declararation of all variables, vectors and haarcascades
		Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
		string  entrada="NORMAL";//archivo txt sin novedades
		string[] Labels;

		void llenar_labels()
		{
			Labels = new string[dt_tmp.Rows.Count + 1];
			Labels[0] = dt_tmp.Rows.Count.ToString();

			try
			{
				for (int kl = 1; kl < dt_tmp.Rows.Count; kl++)
				{
					fila_fotos = (appvb.ds.tmp_fotosRow)dt_tmp.Rows[kl - 1];
					Labels[kl] = fila_fotos.ced;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		public frmAsistencia()
        {
			InitializeComponent();
			//Load haarcascades for face detection
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

				for (int tf = 1; tf < NumLabels + 1; tf++)
				{
					LoadFaces = "face" + tf + ".bmp";
					trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
					labels.Add(Labels[tf]);
				}
				entrada = "NORMAL";
			}
			catch (Exception e)
            {
				//MessageBox.Show(e.ToString());
				entrada = "MAL";
                MessageBox.Show("La base de datos de archivo texto esta vacia, Intente regenerar el archivo desde la  opcion fotos usuario, o agregue nuevos rostros ", "Carga de fotos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Estatic.logger(e.Message); 
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
			cedula_anterior = "";
			contador = 1;
            appvb.dsTableAdapters.estado_civilTableAdapter taest = new appvb.dsTableAdapters.estado_civilTableAdapter();
            appvb.dsTableAdapters.cargosTableAdapter tacar = new appvb.dsTableAdapters.cargosTableAdapter();
            appvb.dsTableAdapters.seccionesTableAdapter tasec = new appvb.dsTableAdapters.seccionesTableAdapter();
           // dgf.DataSource = fotos_empTableAdapter1.GetData();

            rutaM = Application.StartupPath.ToString() + "\\foto_ced\\generico.jpg";
            rutaF = Application.StartupPath.ToString() + "\\foto_ced\\generica.jpg";


            cmbcargos.DataSource = tacar.GetData();
            cmbcargos.DisplayMember = "em_cargo";
            cmbcargos.ValueMember = "em_cargo";


            cmbseccion.DataSource = tasec.GetData();
            cmbseccion.DisplayMember = "em_des_seccion";
            cmbseccion.ValueMember = "em_des_seccion";
            //Point tempPoint = new Point(0, 0);
            //// Set the location of the form using the Point object.
            //this.DesktopLocation = tempPoint;
			llenar_asis50();
			iniciar_camara();
		}

        bool isnumber(string tracking) {
            if (Convert.ToInt64(tracking.Trim()) > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        void nuevo() {

            txtnombre.Text = "";
            txtcedula.Text = "";

            cmbseccion.Text = "";
            cmbcargos.Text = "";

			imgfoto.Image = null;

		}

		private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
		{

		}

		public void cargar_empleado(string cod,string tipo) {

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
                    cmbcargos.Text = ds_emp[0].em_cargo.ToString();
                    cmbseccion.Text = ds_emp[0].em_des_seccion.ToString();

					if (ds_emp[0].em_estado.ToString() == "V")
					{
						estado_emp = "V";
					}
					else
					{
						estado_emp = "N";
					}

					cargar_foto();

                }
                catch (Exception ex)
                {
                    txtestado.Text = ex.Message.ToString();

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
        }

		
		private void timer2_Tick(object sender, EventArgs e)
		{
			activar();
			timer2.Enabled = false; 
		}

		void activar()
		{
			try
			{
				grabber = new Capture();
				activado = true;
				hora_t1 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
				//Initialize the FrameGraber event
				Application.Idle += new EventHandler(FrameGrabber);
				grabber.QueryFrame();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		void desactivar()
		{
			imageBoxFrameGrabber.Image = null;
			activado = false;
			imageBox1.Image = null;
			try
			{
				//Initialize the FrameGraber event
				Application.Idle -= new EventHandler(FrameGrabber);

				grabber.Dispose();
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
			}
		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			txthora_m.Text = DateTime.Now.ToString("HH:mm:ss.fff");
			txtfecha.Value = DateTime.Now;
			txthora.Value = DateTime.Now;
			txtfechalarga.Text = DateTime.Now.ToLongDateString() ;
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
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(rutaM);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

		void iniciar_camara() {
			//Initialize the capture device
			try
			{
				grabber = new Capture();
				grabber.QueryFrame();
				hora_t1 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
				activado = true;
				//Initialize the FrameGraber event
				Application.Idle += new EventHandler(FrameGrabber);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		} 


		void llenar_asis50() {
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
				catch (Exception ex) {
					Console.Write(ex.Message);
				}
			}
			Cursor.Current = Cursors.Default;
		}

        void FrameGrabber(object sender, EventArgs e)
        {
			if (!activado) {
				return; 
			}
            label3.Text = "0";
			string nombre="";
            NamePersons.Add("");
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    //Convert it to ESCALA DE GRISES
                    gray = currentFrame.Convert<Gray, Byte>();

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                  face,
                  1.15,
                  7,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  new Size(20, 20));

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        t = t + 1;
                        result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                        if (trainingImages.ToArray().Length != 0)
                        {

						// TermCriteria para el reconocimiento facial con un número de imágenes entrenadas como maxIteration
						MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

					// Reconocimiento facial Eigen
					//codigo que funciona en  2.2
					//EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(
					//		   trainingImages.ToArray(),
     //                      labels.ToArray(),
     //                      2000,
     //                      ref termCrit);

     //                   name = reconocedor.Recognize(result);
					
					// Dibuja la etiqueta para cada rostro detectado y reconocido
					try
					{
						currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 40), new Bgr(Color.LightGreen));
					}
					catch (Exception ex) {
						Console.Write(ex.Message);
					}
						
                      }
					toolStripStatusLabel1.Text = name;
					hora1 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));

				//' MessageBox.Show(name); 
				if (appvb.variosvb.isnumericvb(name)) {
					//	imageBox1.Image = result;
					TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
					imageBox1.Image = TrainedFace;

					hora1 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
						cargar_empleado(name, "ced");
					if (string.Equals(estado_emp, "V"))
					{
						if (String.Equals(cedula_anterior, name))
						{
							//si la cedula anterior y la actual son iguales
							System.TimeSpan diff1 = hora1.Subtract(hora2);
							Double milisegundos = diff1.TotalMilliseconds;
							if (milisegundos < 90000)
							{
								imgfoto.Image = null;
								txtnombre.Text = "";
								txtcedula.Text = "";
								txtid.Text = "";
								desactivar();
								timer2.Enabled = true;
								Estatic.mensaje( nombre, "Su Registra fue previamente Grabado \n No se puede Repetir", "ok");
								return;
							}
						}

						nombre = txtnombre.Text;  
						
						hora_t2 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
						System.TimeSpan diffp = hora_t2.Subtract(hora_t1);
						tiempo_detect = diffp.TotalMilliseconds;
						id_asis = appvb.variosvb.reg_asistencia(name, NumLabels, txtfecha.Value, txthora.Value);
						Estatic.mensaje( "Registro Grabado",txtnombre.Text +" "+ tiempo_detect.ToString()  , "asistencia");  
						llenar_asis50();
						cedula_anterior = name;
						hora2 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
						/*
						ContTrain = ContTrain + 1;
						//Obtener un marco gris del dispositivo de captura
						gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
						//Face Detector
						facesDetected = gray.DetectHaarCascade(
					   face,
					   1.2,
					   10,
					   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
					   new Size(20, 20));

						//Acción por cada elemento detectado
						foreach (MCvAvgComp ff in facesDetected[0])
						{
							TrainedFace = currentFrame.Copy(ff.rect).Convert<Gray, byte>();
							break;
						}
						*/
						TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
						imageBox1.Image = TrainedFace;

					}
					else {	

					}
				}
					

					NamePersons[t-1] = name;
                     NamePersons.Add("");
                        //Set the number of faces detected on the scene
                        label3.Text = facesDetected[0].Length.ToString();

                    }
                        t = 0;
                        //Names concatenation of persons recognized
                    for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                    {
                        names = names + NamePersons[nnn] + ", ";
                    }
                    //Show the faces procesed and recognized
                    imageBoxFrameGrabber.Image = currentFrame;
                    label4.Text = names;
                 //   txtced.Text = names;

			      names = "";
                    //Clear the list(vector) of names
                    NamePersons.Clear();

                }
    }
}