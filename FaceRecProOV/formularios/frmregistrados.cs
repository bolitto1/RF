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
using System.IO;
using System.Drawing.Imaging;



namespace Detector_facial
{
	public partial class frmregistrados : Form
	{
		string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";
		string ruta2 = Application.StartupPath;
		int[] lista = new int[100];
		Bitmap inImg;
		string ruta_im;
        appvb.dsTableAdapters.tmp_fotos_filtroTableAdapter taff;
        appvb.ds.tmp_fotos_filtroDataTable dtff;

        public frmregistrados()
		{
			InitializeComponent();
		}
		public void cargar() {

			appvb.dsTableAdapters.tmp_fotosTableAdapter ta = new appvb.dsTableAdapters.tmp_fotosTableAdapter();
			appvb.ds.tmp_fotosDataTable dt = new appvb.ds.tmp_fotosDataTable();
			appvb.ds.tmp_fotosRow fila_i;
			appvb.dsTableAdapters.vw_fotos_registradasTableAdapter tafr = new appvb.dsTableAdapters.vw_fotos_registradasTableAdapter();
			appvb.ds.vw_fotos_registradasDataTable dtfr = new appvb.ds.vw_fotos_registradasDataTable();
			appvb.ds.vw_fotos_registradasRow fila;
			appvb.dsTableAdapters.empleadosTableAdapter tae = new appvb.dsTableAdapters.empleadosTableAdapter();
			appvb.ds.empleadosDataTable dte = new appvb.ds.empleadosDataTable();
		//	ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";
			tae.Fill(dte);
			txttotal_ea.Text = dte.Rows.Count.ToString();

		//	String fileReader, cad2 = "";
		//	Int32 pos, i = 1;

			ta.Fill(dt);
			dgpos_ced.Rows.Clear();
			for (int kl = dt.Rows.Count-1; kl>= 0 ; kl--) {
				fila_i = (appvb.ds.tmp_fotosRow)dt.Rows[kl];
				dgpos_ced.Rows.Add(fila_i.pos, fila_i.ced);

				
			}
			//StreamReader sr = new StreamReader(ruta);
			//fileReader = sr.ReadToEnd();
			//sr.Close();
			
			//fileReader = File.ReadAllText(ruta, System.Text.Encoding.UTF8);
		//	TextBox1.Text = fileReader;
			
		//	pos = Strings.InStr(fileReader, "%");
            /* 
			try {
				cad2 = Microsoft.VisualBasic.Strings.Mid(fileReader, 1, pos - 1);
			}
			catch (Exception ex1) {
				MessageBox.Show(ex1.Message.ToString());
                return;
			}
            try
            {
                ta.DeleteTodos();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
			
			txttotal.Text = cad2;
			txttotalminis.Text = cad2;
			ListBox1.Items.Clear();
		
			fileReader = Microsoft.VisualBasic.Strings.Mid(fileReader, pos + 1, fileReader.Length);
			pos = Microsoft.VisualBasic.Strings.InStr(fileReader, "%");
			while (pos > 1) {
				try {
					cad2 = Strings.Mid(fileReader, 1, pos - 1);
					ListBox1.Items.Add(cad2);
                    textBox2.AppendText ( cad2);
                    textBox2.AppendText  (Environment.NewLine);
                   // if ((i - 1) != 0) {
                        ta.Insert(i , cad2);
                        dg4.Rows.Add(cad2, i );
                   // }
					i++;
					fileReader = Strings.Mid(fileReader, pos + 1, fileReader.Length);
					pos = Strings.InStr(fileReader, "%");
				}
				catch (Exception ex1) {
					MessageBox.Show(ex1.Message.ToString());
				}
			}
			*/
			tafr.Fill(dtfr);
			dg.Rows.Clear();
			txttotal_e.Text = dtfr.Rows.Count.ToString() ; 
			for (int k = 0; k < dtfr.Rows.Count; k++) {
				fila = (appvb.ds.vw_fotos_registradasRow)dtfr.Rows[k];
				dg.Rows.Add( fila.ced,fila.em_nomlar, fila.Cantidad, fila.ID, k+1   );  
			}
			ima.Image = null;

		}

		private void btncargar_Click(object sender, EventArgs e)
		{
			cargar();
		}
		
		private void frmregistrados_Load(object sender, EventArgs e)
		{
		//	Point tempPoint = new Point(0, 0);
			// Set the location of the form using the Point object.
			//this.DesktopLocation = tempPoint;
			cargar();
		}

		private Bitmap LoadBitmapUnlocked(string file_name)
		{
			FileStream fs = new System.IO.FileStream(file_name , FileMode.Open, FileAccess.Read);
			Bitmap bm ;
			bm = (Bitmap)Image.FromStream(fs);
			fs.Close();
            return bm;
        }


		private Bitmap LoadBitmapUnlocked2(string file_name)
		{
			Bitmap bm = new Bitmap(file_name);
			try
			{
				bm = new Bitmap(file_name);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			return new Bitmap(bm);
		}


		public void cargar_foto(string cedula)
		{
			ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + cedula + ".jpg";
			if (cedula.Length > 0)
			{
				try
				{
					if (File.Exists(ruta))
					{
						imgfoto.Image = Estatic.LoadBitmapUnlocked(ruta);
					}
				}
				catch (Exception ex)
				{
                    Console.WriteLine(ex.Message);
				}
			}
		}

		private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            DataGridViewRow row;
            try
            {
                 row = dg.Rows[e.RowIndex];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return;
            }
            //table adapter
            taff = new appvb.dsTableAdapters.tmp_fotos_filtroTableAdapter();
			//datatable
			dtff = new appvb.ds.tmp_fotos_filtroDataTable();
            taff.Fill(dtff, row.Cells[0].Value.ToString());
            txtcedula1.Text = row.Cells[0].Value.ToString();
            txtnombre1.Text = row.Cells[1].Value.ToString();
                cargar_foto(row.Cells[0].Value.ToString());
			txtborrar.Text = ""; 
            cargar_minis(); 
		}

        void cargar_resto(string cedula) {
            taff = new appvb.dsTableAdapters.tmp_fotos_filtroTableAdapter();
            //datatable
            dtff = new appvb.ds.tmp_fotos_filtroDataTable();
            taff.Fill(dtff,cedula);
            cargar_foto(cedula);
            cargar_minis();

        }

        void cargar_vacio() {
            dgim.Rows.Clear();
        }

        void cargar_minis() {
            dgim.Columns.Clear();
            dgim.Rows.Clear();

            DataGridViewImageColumn img;
            appvb.ds.tmp_fotos_filtroRow fila;
            img = new DataGridViewImageColumn();
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
			try
			{
				fila = (appvb.ds.tmp_fotos_filtroRow)dtff.Rows[0];
				ruta_im = String.Concat(ruta2, "\\TrainedFaces\\face", fila.pos.ToString(), ".jpg");
				try
				{
					inImg = (Bitmap)Estatic.LoadBitmapUnlocked(ruta_im);
				}
				catch
				{
					inImg = (Bitmap)imgnofound.Image;
				}
				lista[0] = fila.pos;
				img.Image = inImg;
				img.Width = 140;
				dgim.Columns.Add(img);
				dgim.Rows.Add(1);
				dgim.Rows[0].Height = 140;

				for (int i = 1; i < dtff.Rows.Count; i++)
				{
					DataGridViewImageColumn img2 = new DataGridViewImageColumn();
					img2.ImageLayout = DataGridViewImageCellLayout.Zoom;

					fila = (appvb.ds.tmp_fotos_filtroRow)dtff.Rows[i];
					lista[i] = fila.pos;
					ruta_im = String.Concat(ruta2, "\\TrainedFaces\\face", fila.pos.ToString(), ".jpg");
					//la lista guarda la posicion, para cuando se haga clic en posicion en la grid de imagenres
					try
					{
						//inImg = (Bitmap)Image.FromFile(ruta_im);
						inImg = (Bitmap)Estatic.LoadBitmapUnlocked(ruta_im);
					}
					catch
					{
						inImg = (Bitmap)imgnofound.Image;
					}
					img2.Image = inImg;
					img2.Width = 140;

					dgim.Columns.Add(img2);
				}
			}
			catch (Exception ex) {
				return; 
			}
           

        }

        private void dgim_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
    		txtborrar.Text = lista[e.ColumnIndex].ToString();
            txtpos.Text = lista[e.ColumnIndex].ToString();
            MemoryStream ms = new MemoryStream();
            Bitmap img33 = (Bitmap)dgim.CurrentRow.Cells[e.ColumnIndex].Value;
            //img33.Save(ms, ImageFormat.Jpeg);
            ima.Image = img33;
        }

        private void cmdborrar_Click(object sender, EventArgs e)
        {
            borrar();
			txtborrar.Text="";  
			string ced1 = txtcedula1.Text;
			cargar();
			txtcedula_b.Text = ced1;
			buscar_origen();   

		}

        void borrar()
        {
			if (string.Equals ( txtborrar.Text,"")) {
				MessageBox.Show("Por favor señale la foto a borrar");
				return;

			}
			DialogResult dialogResult = MessageBox.Show("¿Desea borrar el archivo de entrenamiento SI / NO?", "Confirmación de  Borrado", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No )
			{
				return;
			}

			string archivo, archivo_nuevo, archivo_viejo, cad;
            int nueva_pos, pos_borrar;
            appvb.dsTableAdapters.tmp_fotosTableAdapter ta = new appvb.dsTableAdapters.tmp_fotosTableAdapter();
            appvb.ds.tmp_fotosDataTable dt = new appvb.ds.tmp_fotosDataTable();
            appvb.ds.tmp_fotosRow fila;
            pos_borrar = Convert.ToInt32(txtborrar.Text); 
            ta.Fill(dt); 
            if (dt.Rows.Count==0) {
                //si hay cero filas, no hay nada que borrar, entonces se sale
                return; 
            }

		
          //  string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";

            //ahora borrar
            ta.Delete(Convert.ToInt32(txtborrar.Text));
            dt = new appvb.ds.tmp_fotosDataTable();
            ta.Fill(dt);

			for (int kl = 0;kl< dt.Rows.Count; kl++) {
				fila = (appvb.ds.tmp_fotosRow)dt.Rows[kl];
				appvb.variosvb.actualizar_pos  ( kl + 1,fila.id) ;  
			}
			txttotalminis.Text  = dt.Rows.Count.ToString() ; 
			/*
			string text1 = Convert.ToString(dt.Rows.Count);

			File.WriteAllText(ruta, Convert.ToString(dt.Rows.Count));
			// hasta aqui se declaro un item menos
			File.AppendAllText(ruta, "%");

			// total++; //total vuelve a su valor original
			////luego insertar una cedula por que asi lo requiere
			//fila = (appvb.ds.tmp_fotosRow)dt.Rows[dt.Rows.Count - 1];
			//text1 = Convert.ToString(fila.ced);
			//File.AppendAllText(ruta, text1);
			//File.AppendAllText(ruta, "%");
			//y luego llenar las cedulas en el archivo texto
			for (nueva_pos = 0; nueva_pos < dt.Rows.Count; nueva_pos++)
            {//este for llena el archivo sin incluir el eliminado
                fila = (appvb.ds.tmp_fotosRow)dt.Rows[nueva_pos];
                text1 = Convert.ToString(fila.ced);
                File.AppendAllText(ruta, text1);
                File.AppendAllText(ruta, "%");
            }
			*/
            //ahora borrar el archivo fisicamente

            archivo_nuevo = String.Concat(ruta2, "\\TrainedFaces\\face", txtborrar.Text, ".jpg");
            if (File.Exists(archivo_nuevo)){
                try {
                    File.Delete(archivo_nuevo);
                }
                catch (Exception ex) {
                    Console.Write(ex.Message);
                    string ddd = DateAndTime.Now.ToString("dd-MM-yyy--hh-mm-ss.ff");
                    archivo_viejo = String.Concat(ruta2, "\\TrainedFaces\\face", ddd, ".jpg");
                    cad = String.Concat("Archivo a ser renombrado:", archivo_viejo, "\r\n", "Nuevo nombre", archivo_nuevo);
					//MessageBox.Show(cad);
					try {
						File.Move(archivo_nuevo, archivo_viejo);
						File.Delete(archivo_viejo);
					}
					catch (Exception exx) {
						MessageBox.Show(exx.Message);

					}

                    //MessageBox.Show("No se pudo borrar archivo");
                }
				
            }

            for (nueva_pos = pos_borrar+1 ; nueva_pos <= dt.Rows.Count +1 ; nueva_pos++)
            {
                archivo_nuevo = String.Concat(ruta2, "\\TrainedFaces\\face", Convert.ToString (nueva_pos-1), ".jpg");

                archivo  = String.Concat(ruta2, "\\TrainedFaces\\face", Convert.ToString(nueva_pos ), ".jpg");
                cad = String.Concat("Archivo a ser renombrado:", archivo,"\r\n","Nuevo nombre", archivo_nuevo);
                    try
                    {
                        File.Move(archivo, archivo_nuevo);
                    }
                    catch (Exception ex)
                    {
                        Estatic.logger(ex.Message);
                        Console.WriteLine ( ex.Message.ToString());
                    }

                }
			//cargar();
		//	MessageBox.Show("Archivo de entrenamiento borrado");
		}

        public void cargar_foto(string cedula, string tipo)
        {
            ruta = Application.StartupPath.ToString() + "\\foto_ced\\" + cedula + ".jpg";
                try
                {
                    if (File.Exists(ruta))
                    {
                        if (string.Equals(tipo, "o"))
                        {
                            imgfoto.Image = Estatic.LoadBitmapUnlocked(ruta);
                        }
                        else
                        {
                            imgd.Image = Estatic.LoadBitmapUnlocked(ruta);
                        }
                    }
                    else {
                        if (string.Equals(tipo, "o"))
                        {
                                imgfoto.Image = imgnofound.Image; 
                        }
                        else
                        {
                            imgd.Image = imgnofound.Image; 
                        }
                }
  
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }

        }

		public void buscar_origen() {
			appvb.dsTableAdapters.vw_fotos_registradasTableAdapter tafr = new appvb.dsTableAdapters.vw_fotos_registradasTableAdapter();
			appvb.ds.vw_fotos_registradasDataTable dtfr = new appvb.ds.vw_fotos_registradasDataTable();
			appvb.ds.vw_fotos_registradasRow fila;

			string cad = Microsoft.VisualBasic.Strings.Trim(txtnombre_b.Text);
			string ced = Microsoft.VisualBasic.Strings.Trim(txtcedula_b.Text);
			txtnombre_b.Text = "";
			txtcedula_b.Text = "";
			if (!(String.IsNullOrEmpty(cad)))
			{
				tafr.FillBynombre(dtfr, cad);
				if (dtfr.Rows.Count > 0)
				{
					fila = (appvb.ds.vw_fotos_registradasRow)dtfr.Rows[0];
					txtnombre1.Text = fila.em_nomlar;
					txtcedula1.Text = fila.ced;
					cargar_foto(fila.ced, "o");
					cargar_resto(fila.ced);
				}
				else
				{
					txtnombre1.Text = "";
					txtcedula1.Text = "";
					imgfoto.Image = imgnofound.Image;
					cargar_vacio();
				}
			}
			else
			{
				//MessageBox.Show("No hay nombre a consultar");
				if (Microsoft.VisualBasic.Information.IsNumeric(ced))
				{
					tafr.FillByCedula(dtfr, ced);
					if (dtfr.Rows.Count > 0)
					{
						fila = (appvb.ds.vw_fotos_registradasRow)dtfr.Rows[0];
						txtnombre1.Text = fila.em_nomlar;
						txtcedula1.Text = fila.ced;
						cargar_foto(fila.ced, "o");
						cargar_resto(fila.ced);
					}
					else
					{
						txtnombre1.Text = "";
						txtcedula1.Text = "";
						imgfoto.Image = imgnofound.Image;
						cargar_vacio();
					}
				}
				else
				{
					MessageBox.Show("No hay nombre o cedula para consultar");
				}
			}
		}

        private void btnbuscar_origen_Click(object sender, EventArgs e)
        {
			buscar_origen();

		}

        private void btnBuscar_destinatario_Click(object sender, EventArgs e)
        {

            appvb.dsTableAdapters.vw_fotos_registradasTableAdapter tafr = new appvb.dsTableAdapters.vw_fotos_registradasTableAdapter();
            appvb.ds.vw_fotos_registradasDataTable dtfr = new appvb.ds.vw_fotos_registradasDataTable();
            appvb.ds.vw_fotos_registradasRow fila;

            string cad = Microsoft.VisualBasic.Strings.Trim(txtnombre_b.Text);
            string ced = Microsoft.VisualBasic.Strings.Trim(txtcedula_b.Text);
            txtnombre_b.Text = "";
            txtcedula_b.Text = "";
            if (!(String.IsNullOrEmpty(cad)))
            {
                tafr.FillBynombre(dtfr, cad);
                if (dtfr.Rows.Count > 0)
                {
                    fila = (appvb.ds.vw_fotos_registradasRow)dtfr.Rows[0];
                    txtnombre2.Text = fila.em_nomlar;
                    txtcedula2.Text = fila.ced;
                    cargar_foto(fila.ced, "d");
                  //  cargar_resto(fila.ced);
                }
                else
                {
                    txtnombre2.Text = "";
                    txtcedula2.Text = "";
                    imgd.Image = imgnofound.Image;
                    cargar_vacio();
                }
            }
            else
            {
                //MessageBox.Show("No hay nombre a consultar");
                if (Microsoft.VisualBasic.Information.IsNumeric(ced))
                {
                    tafr.FillByCedula(dtfr, ced);
                    if (dtfr.Rows.Count > 0)
                    {
                        fila = (appvb.ds.vw_fotos_registradasRow)dtfr.Rows[0];
                        txtnombre2.Text = fila.em_nomlar;
                        txtcedula2.Text = fila.ced;
                        cargar_foto(fila.ced, "d");
                      //  cargar_resto(fila.ced);
                    }
                    else
                    {
                        txtnombre2.Text = "";
                        txtcedula2.Text = "";
                        imgd.Image = imgnofound.Image;
                        cargar_vacio();
                    }
                }
                else
                {
                    MessageBox.Show("No hay nombre o cedula para consultar");
                }
            }
        }

        private void cmdcambia_prop_Click(object sender, EventArgs e)
        {
            string ced;
            int pos;
            if ((String.IsNullOrEmpty(txtcedula2.Text)))
            {
                MessageBox.Show("No hay cedula del nuevo propietario");
                return;
            }

            ced = txtcedula2.Text;
            if ((String.IsNullOrEmpty(txtborrar.Text)) ){
                MessageBox.Show("No hay imagen selecionada para cambiar");
                return;
            }
            pos = Convert.ToInt32 ( txtborrar.Text);
             
            appvb.dsTableAdapters.tmp_fotosTableAdapter ta = new appvb.dsTableAdapters.tmp_fotosTableAdapter();

            ta.UpdateCed_pos (ced,pos);
            int nueva_pos,  total;
            appvb.ds.tmp_fotosDataTable dt = new appvb.ds.tmp_fotosDataTable();
            appvb.ds.tmp_fotosRow fila;

            ta.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                //si hay cero filas, no hay nada que borrar, entonces se sale
                return;
            }
            total = dt.Rows.Count;

            string ruta = Application.StartupPath + "\\TrainedFaces\\TrainedLabels.txt";
            string text1 = Convert.ToString(total);
            File.WriteAllText(ruta, Convert.ToString(total));
            // hasta aqui se declaro un item menos
            File.AppendAllText(ruta, "%");
            //dt = new appvb.ds.tmp_fotosDataTable();
            //ta.Fill(dt);

            ////luego insertar una cedula por que asi lo requiere
            //fila = (appvb.ds.tmp_fotosRow)dt.Rows[dt.Rows.Count - 1];
            //text1 = Convert.ToString(fila.ced);
            //File.AppendAllText(ruta, text1);
            //File.AppendAllText(ruta, "%");
            //y luego llenar las cedulas en el archivo texto
            for (nueva_pos = 0; nueva_pos < dt.Rows.Count; nueva_pos++)
            {//este for llena el archivo sin incluir el eliminado
                fila = (appvb.ds.tmp_fotosRow)dt.Rows[nueva_pos];
                text1 = Convert.ToString(fila.ced);
                File.AppendAllText(ruta, text1);
                File.AppendAllText(ruta, "%");
            }
            txtborrar.Text = "";
            MessageBox.Show("Foto Cambiada de propietario exitosamente");

			cargar();

		}

        private void dg_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dg.Rows[e.Cell.RowIndex];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            //table adapter
            taff = new appvb.dsTableAdapters.tmp_fotos_filtroTableAdapter();
            //datatable
            dtff = new appvb.ds.tmp_fotos_filtroDataTable();
			try {
				if (String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
				{
					return;
				}
			}
			catch (Exception ex) {
				dgim.Columns.Clear();
				dgim.Rows.Clear();
				return;
			}

            taff.Fill(dtff, row.Cells[0].Value.ToString());
            txtcedula1.Text = row.Cells[0].Value.ToString();
            txtnombre1.Text = row.Cells[1].Value.ToString();
            cargar_foto(row.Cells[0].Value.ToString());
            cargar_minis();
        }

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void imgfoto_DoubleClick(object sender, EventArgs e)
		{
			if (txtcedula1.Text.Length > 1) {
				frmEntrenamiento frd = new frmEntrenamiento();
				frd.MdiParent = this.MdiParent; 
				
				frd.Show();
				frd.cargar_empleado(txtcedula1.Text, "ced");
				this.Dispose();
			}
		}

		private void dgpos_ced_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row;
			try
			{
				row = dgpos_ced.Rows[e.RowIndex];
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}


			int num;
			string archivo, nomb;
			string tempPath = System.IO.Path.GetTempPath();
			DateTime date = DateTime.Now;
			string s = date.ToString("dd-MM-yyyy--hh-mm-ss-fff");
			num = Convert.ToInt32 (  row.Cells[0].Value);
			txtpos.Text = num.ToString();
			txtborrar.Text = txtpos.Text;
			try
			{
				nomb = "face" + txtpos.Text + s;
				archivo = ruta2 + "\\TrainedFaces\\face" + txtpos.Text + ".jpg";
				// Clipboard.SetText(archivo);
				if (File.Exists(archivo))
				{
					ima.Image = Estatic.LoadBitmapUnlocked (archivo);
					txtcedula_b.Text = row.Cells[1].Value.ToString();
					buscar_origen();
				}
				else
				{
					// MessageBox.Show("no");
					ima.Image = imgg.Image;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}

		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void dgpos_ced_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
		{
			DataGridViewRow row;
			try
			{
				row = dgpos_ced.Rows[e.Cell.RowIndex];
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}


			int num;
			string archivo;
			num = Convert.ToInt32(row.Cells[0].Value);
			txtpos.Text = num.ToString();
			txtborrar.Text = txtpos.Text;
			try
			{
				archivo = ruta2 + "\\TrainedFaces\\face" + txtpos.Text + ".jpg";
				// Clipboard.SetText(archivo);
				if (File.Exists(archivo))
				{
					ima.Image = Estatic.LoadBitmapUnlocked(archivo);
					txtcedula_b.Text = row.Cells[1].Value.ToString();
					if (!(string.Equals(txtcedula1.Text, txtcedula_b.Text))) {
						buscar_origen();
					}
				}
				else
				{
					// MessageBox.Show("no");
					ima.Image = imgg.Image;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}
	}
}
