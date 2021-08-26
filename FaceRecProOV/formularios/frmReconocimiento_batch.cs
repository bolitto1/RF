using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO ;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Imaging;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace Detector_facial
{
	public partial class frmReconocimiento_batch : Form
	{
		string ruta;


		Image<Bgr, Byte> currentFrame;
		DateTime hora1, hora2, hora_reco;
		Double distancia;
		Double milisegundos, mili_seg_r;
		System.TimeSpan diff1;
		Image<Gray, byte> gray_frame = null; //grayscale current image aquired from webcam for processing
		Classifier_Train Eigen_Recog = new Classifier_Train();
		CascadeClassifier cara = new CascadeClassifier("haarcascade_frontalface_default.xml");//Our face detection method 
		MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
		Image<Gray, byte> result, TrainedFace = null;
		Image<Gray, byte> gray = null;


		public frmReconocimiento_batch()
		{
			InitializeComponent();
		}

		private void btnselec_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txtruta.Text  = folderBrowserDialog1.SelectedPath;
				ruta =  folderBrowserDialog1.SelectedPath;
				string[] filePaths = Directory.GetFiles(ruta);
				//var filenames = Directory.GetFiles(ruta);
				//listBox1.DataSource = filenames;
				List<string> files = new List<string>();
				files = Directory.GetFiles(ruta, "*.jpg").ToList();
				//var shortFilenames = filenames.Select(x => Path.GetFileName(x)).ToList();
				//var filtrados = shortFilenames.Select(x => x.EndsWith(".jpg") ).ToList();
				listBox1.DataSource = files;
			}
		}

		void detectar(string archivo)
		{
			
		}

		void procesar() {
			string archivo, num;
			string anterior,nuevo, name="";

	
			DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy 00:00:00"));
			Int32  id_p;
			id_p = appvb.variosvb.ins_nueva_rec_lotr(Eigen_Recog.Recognizer_Type, fecha);

			System.Drawing.Image ima;
			for (int kl=0; kl< listBox1.Items.Count ; kl++)
			{
				num = kl.ToString() + " de " + listBox1.Items.Count.ToString(); 
				archivo = listBox1.Items[kl].ToString();
				this.Text = kl.ToString()+" de " + listBox1.Items.Count.ToString() ;
				ima = Estatic.LoadBitmapUnlocked(archivo);
				picOrigen.Image = ima;
				picOrigen.Refresh(); 
				Bitmap mat = new Bitmap(ima);
				//imageBoxFrameGrabber.Image =(Emgu.CV.IImage  ) ima;
				imageBoxFrameGrabber.Image = new Image<Bgr, Byte>(mat);
				
				Bitmap inImg, inImg2;
				//Get the current frame form capture device
				currentFrame = (Image<Bgr, Byte>)imageBoxFrameGrabber.Image;
				//imageBoxFrameGrabber.Image = currentFrame;
				//Convert it to Grayscale
				if (currentFrame != null)
				{
					hora1 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff"));
					gray_frame = currentFrame.Convert<Gray, Byte>();
					//Face Detector
					Rectangle[] facesDetected = cara.DetectMultiScale(gray_frame, 1.15, 7, new Size(25, 25), Size.Empty);
					Int32 num1 = facesDetected.Length;
					///si la cantidad de caras detectadas es mayor que cero
					if (num1 > 0)
					{
						result = currentFrame.Copy(facesDetected[0]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
						imageBox1.Image = result;
						imageBox1.Refresh();

						if (Eigen_Recog.IsTrained)
						{
							anterior = name;
							//devuelve el numero de cedula
							hora_reco = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff"));
							name = Eigen_Recog.Recognise(result,Convert.ToInt32(txtumbral.Text  )  );
							nuevo = name;
							hora2 = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff"));

                            //desde la detección hasta el reconocimiento
							diff1 = hora2.Subtract(hora1);
                            //desde la detección hasta el reconocimiento
                            milisegundos = diff1.TotalMilliseconds;

                            //solo reconocimiento
							diff1 = hora2.Subtract(hora_reco);
                            //solo reconocimiento
                            mili_seg_r = diff1.TotalMilliseconds;

							distancia = Eigen_Recog.Eigen_Distance;
							txtdistancia.Text = distancia.ToString();
							txtdistancia.Refresh();
							if (appvb.variosvb.isnumericvb(name))
							{
								appvb.variosvb.ins_rec_lote(hora1, hora2, archivo, name, fecha, "ok", Estatic.usuario, Eigen_Recog.Recognizer_Type, distancia, milisegundos, num, id_p, mili_seg_r);
								ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + name + ".jpg";
								// 'MessageBox.Show(ruta);
								if (!(string.Equals(anterior, nuevo)))
								{
									if (name.Length > 0)
									{
										if (File.Exists(ruta))
										{
											inImg = Estatic.LoadBitmapUnlocked(ruta);
											picDetectada.Image = inImg;
											picDetectada.Refresh();
										}
									}
								}
								//		picDetectada.Image = Estatic.LoadBitmapUnlocked(archivo); 
							}
							else
							{
								try
								{
									inImg = imageBoxFrameGrabber.Image.Bitmap;
									inImg.SetResolution(inImg.HorizontalResolution * 0.05F, inImg.VerticalResolution * 0.05F);
									inImg2 = result.Bitmap;
									dg.Rows.Add(inImg, archivo, inImg2, distancia);
									dg.Rows[dg.Rows.Count - 2].Height = 150;
									//dg.Refresh();
									appvb.variosvb.ins_rec_lote(hora1, hora2, archivo, name, fecha, "NO", Estatic.usuario, Eigen_Recog.Recognizer_Type, distancia, milisegundos, num, id_p, mili_seg_r);

								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message);
									return;
								}

							}
						}
					}
					else {
						//no detectada
						appvb.variosvb.ins_rec_lote(hora1, hora2, archivo, "", fecha, "no existe cara", Estatic.usuario, Eigen_Recog.Recognizer_Type, 0, 0, num, id_p, 0);
					}


				}
			}
			MessageBox.Show("Procesadas " + listBox1.Items.Count.ToString() + " imagenes");
			
		}

		private void txtumbral_TextChanged(object sender, EventArgs e)
		{
			Eigen_Recog.Set_Eigen_Threshold = Math.Abs(Convert.ToInt32(txtumbral.Text));
		}

		private void btnprosesar_Click(object sender, EventArgs e)
		{
			procesar();
		}

		//Process Frame
		private void frmReconocimiento_batch_Load(object sender, EventArgs e)
		{
			string metodo;
			appvb.dsTableAdapters.parametrosTableAdapter ta = new appvb.dsTableAdapters.parametrosTableAdapter();
			appvb.ds.parametrosDataTable dt = new appvb.ds.parametrosDataTable();
			appvb.ds.parametrosRow fila;
			ta.Fill(dt);
			fila = (appvb.ds.parametrosRow)dt.Rows[0];

			txtmetodo.Text = fila.metodo;


		}
	}
}
