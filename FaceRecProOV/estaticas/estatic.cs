using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.IO;
using Microsoft.VisualBasic.Logging;
using System.Drawing;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using NotificationWindow;  


namespace Detector_facial
{
    public static class Estatic
    {
        static string key = "has";
        public static string usuario;
        public static string nombres;
        public static string rol="";
        public static int id_usuario;
        public static int id_rol=0;
		static PopupNotifier    popup;


		public static void mensaje(string titulo, string sms) {
			popup = new PopupNotifier();
			popup.TitleText = titulo ;
			popup.TitleColor = Color.Blue;  
			popup.HeaderColor = Color.Coral ;
			popup.ShowCloseButton = true;
			popup.Size = new Size(350, 100);
			popup.ContentText = sms;
			popup.ContentFont  = new System.Drawing.Font("Arial", 12);
			popup.ContentColor = Color.Black ; 
			popup.Delay = 2000;
			popup.AnimationDuration = 300; 
			popup.TitleFont = new System.Drawing.Font("Arial", 12);
			popup.BodyColor = Color.Beige  ;
			popup.Popup();
		}

		public static void mensaje(string titulo, string sms,string estado)
		{
			popup = new PopupNotifier();
			popup.TitleText = titulo;
			popup.ShowCloseButton = true;
			popup.TitleColor = Color.Blue;
			popup.HeaderColor = Color.Coral;

			popup.Size = new Size(350, 100);
			popup.ContentText = sms;
			popup.ContentFont = new System.Drawing.Font("Arial", 12);
			popup.ContentColor = Color.Black;
			popup.Delay = 2000;
			popup.AnimationDuration = 300;
			popup.TitleFont = new System.Drawing.Font("Arial", 12);
			popup.BodyColor = Color.Beige;
			switch (estado){
				case "ok":
					popup.Image = Properties.Resources.ok1;
					popup.Delay = 2000;
					popup.AnimationDuration = 100;
					break;
				case "asistencia":
					popup.Image = Properties.Resources.nube_grabar; 
					break;
				default :
					popup.Image = null;
					break;
			}

			popup.Popup();
		}

		public static void mensaje(string titulo, string sms,Int32  duracion )
		{
			popup = new PopupNotifier();
			popup.TitleText = titulo;
			popup.TitleColor = Color.Blue;
			popup.HeaderColor = Color.Coral;
			popup.ShowCloseButton = true;
			popup.Size = new Size(350, 100);
			popup.ContentText = sms;
			popup.ContentFont = new System.Drawing.Font("Arial", 12);
			popup.ContentColor = Color.Black;
			popup.Delay = duracion;
			popup.AnimationDuration = 300;
			popup.TitleFont = new System.Drawing.Font("Arial", 12);
			popup.BodyColor = Color.Beige;
			popup.Popup();
		}


		public static string desencriptar(string encrypt)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Convert.FromBase64String(encrypt);
                    return Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }

        public static string encriptar(string source)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Encoding.UTF8.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }


		public static Image ResizeImage
		(Image srcImage, int newWidth, int newHeight)
		{
			using (Bitmap imagenBitmap =
			   new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
			{
				imagenBitmap.SetResolution(
				   Convert.ToInt32(srcImage.HorizontalResolution),
				   Convert.ToInt32(srcImage.HorizontalResolution));

				using (Graphics imagenGraphics =
						Graphics.FromImage(imagenBitmap))
				{
					imagenGraphics.SmoothingMode =
					   SmoothingMode.AntiAlias;
					imagenGraphics.InterpolationMode =
					   InterpolationMode.HighQualityBicubic;
					imagenGraphics.PixelOffsetMode =
					   PixelOffsetMode.HighQuality;
					imagenGraphics.DrawImage(srcImage,
					   new Rectangle(0, 0, newWidth, newHeight),
					   new Rectangle(0, 0, srcImage.Width, srcImage.Height),
					   GraphicsUnit.Pixel);
					MemoryStream imagenMemoryStream = new MemoryStream();
					imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
					srcImage = Image.FromStream(imagenMemoryStream);
				}
			}
			return srcImage;
		}

		// Load a bitmap without locking it.
		public static Bitmap LoadBitmapUnlocked(string file_name)
        {
			FileStream fs = new System.IO.FileStream(file_name, FileMode.Open, FileAccess.Read);
			Bitmap bm;

				bm = (Bitmap)Image.FromStream(fs);

			fs.Close();
			return bm;
		}


        public static string rutaM() {
            return  Application.StartupPath.ToString() + "\\foto_ced\\generico.jpg";
        }

        public static string rutaF()
        {
            return Application.StartupPath.ToString() + "\\foto_ced\\generica.jpg";
        }

        public static bool IsNumeric(this string input) {
            int test;
            return int.TryParse(input, out test);
        }

        public static void logger(string cadena) {
            string miarch;
            miarch = String.Concat(Application.ExecutablePath, "\\logger.txt");
            if (File.Exists(miarch))
            {
                File.AppendAllText(miarch, cadena);
            }
            else {
               // File.WriteAllText(miarch, cadena);
            }
        }
    }
}
