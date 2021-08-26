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
    public partial class fprin : Form
    {
        private int childFormNumber = 0;
		DialogResult dialogResult;


		public fprin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }



        private void entrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntrenamiento1 fe = new FrmEntrenamiento1 ();
            fe.Show();
        }


        private void deteccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
			    frmEntrenamiento frd = new frmEntrenamiento();

            frd.MdiParent = this;
            frd.Show();
        }



        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actiivarDesUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivar_usuarios ff = new frmActivar_usuarios();
            ff.MdiParent = this;
            ff.Show();

            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("¿Desea salir del sistema S/N?", "Confirme",MessageBoxButtons.YesNo );
            if (resp == DialogResult.Yes) {
                Application.Exit();
            }

            
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles ff = new frmRoles();
            ff.MdiParent = this;
            ff.Show();
        }


        private void fprin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pruebasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editarArchviosDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entrenamientoDeteccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
			frmEntrenamiento frd = new frmEntrenamiento();
			frd.MdiParent = this;
            frd.Show();
        }

        private void editarFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistrados ff = new frmregistrados();
            ff.MdiParent = this;
            ff.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmacerca_de ff = new Detector_facial.frmacerca_de();
            ff.MdiParent = this;
            ff.Show();

        }

        private void fprin_Load(object sender, EventArgs e)
        {
            administradorToolStripMenuItem.Enabled = false;
            DigitadorToolStripMenuItem.Enabled = false;
            if ((Estatic.id_rol == 7) || (Estatic.id_rol == 2))
            {
                editarFotosToolStripMenuItem.Enabled = true;
            }

            if (Estatic.id_rol ==7)
            { // , "Administrador"
                administradorToolStripMenuItem.Enabled = true;
                DigitadorToolStripMenuItem.Enabled = true;
                return;
            }
            if (Estatic.id_rol == 2) {
                //Digitador
                administradorToolStripMenuItem.Enabled = false;
                DigitadorToolStripMenuItem.Enabled = true;
                return;
            }

        }

        private void verLogeadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdatos_login ff = new Detector_facial.frmdatos_login();
            ff.MdiParent = this;
            ff.Show();
              
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

		private void cambiarMiClaveDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_cambiar_clave ff = new Detector_facial.frm_cambiar_clave();
			ff.MdiParent = this;
			ff.txtid.Text = Estatic.id_usuario.ToString();
			ff.txtnombre1.Text = Estatic.nombres;
			ff.txtusuario.Text = Estatic.usuario;    
			   
			ff.Show();
		}

		private void lIstadosDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmlistado_usuariosf ff = new Detector_facial.frmlistado_usuariosf();
			ff.MdiParent = this;
			ff.Show();
		}

		private void listadoDeTiemposDeDetecciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmlistado_tiempos   ff = new Detector_facial.frmlistado_tiempos();
			ff.MdiParent = this;
			ff.Show();
		}

		private void registrarAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAsistencia ff = new Detector_facial.frmAsistencia();
			ff.MdiParent = this;
			ff.Show();
		}

		private void listadoDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_asistencia_detales   ff = new Detector_facial.frm_asistencia_detales();
			ff.MdiParent = this;
			ff.Show();
		}

		private void cambiarMiClaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_cambiar_clave  ff = new Detector_facial.frm_cambiar_clave();
			ff.MdiParent = this;
			ff.Show();
		}

		private void lIstadosDeUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			frmlistado_usuariosf ff = new Detector_facial.frmlistado_usuariosf();
			ff.MdiParent = this;
			ff.Show();
			
		}

		private void editarFotosToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			frmregistrados ff = new frmregistrados();
			ff.MdiParent = this;
			ff.Show();
		}

		private void eigenToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void reconocimientoEnLoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSetMetodo   ff = new frmSetMetodo();
			ff.MdiParent = this;
			ff.Show();
		}

		private void reporteDeProcesosDeReconocimientoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_rep_recon ff = new frm_rep_recon();
			ff.MdiParent = this;
			ff.Show();
		}

		private void fprin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (dialogResult == DialogResult.None)
			{
				dialogResult = MessageBox.Show("¿Desea salir del sistema SI / NO?", "Confirmación", MessageBoxButtons.YesNo);
			}
				
			if (dialogResult == DialogResult.No)
			{
				e.Cancel = true;
				dialogResult = DialogResult.None;
				return;
			}
			if (dialogResult == DialogResult.Yes )
			{
				Application.Exit();
				return;
			}
			
		}

		private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
