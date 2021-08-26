namespace Detector_facial
{
    partial class frmEntrenamiento
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtestado = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtestado2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnactivar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtcedula = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txttelefonos = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.bntbuscar_foto = new System.Windows.Forms.Button();
			this.btngrabar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btnagregar_rostro = new System.Windows.Forms.Button();
			this.chkagregando = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbestado_civil = new System.Windows.Forms.ComboBox();
			this.cmbcargos = new System.Windows.Forms.ComboBox();
			this.cmbseccion = new System.Windows.Forms.ComboBox();
			this.cmbsexo = new System.Windows.Forms.ComboBox();
			this.txtfecha_nac = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.txtceddetect = new System.Windows.Forms.TextBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombrearchivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtestado3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtidd = new System.Windows.Forms.TextBox();
			this.txtnombre_b = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtced = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtfecha_contrata = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.txtcomentario = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtsueldo = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtsu_extra = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.optsobNO = new System.Windows.Forms.RadioButton();
			this.optsobSI = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.optEstadoNO_A = new System.Windows.Forms.RadioButton();
			this.optEstadoACT = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.optCargasNO = new System.Windows.Forms.RadioButton();
			this.optCargasSI = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.optfondosNO = new System.Windows.Forms.RadioButton();
			this.optfondosSI = new System.Windows.Forms.RadioButton();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtfecha_salida = new System.Windows.Forms.MaskedTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtrutafoto = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label21 = new System.Windows.Forms.Label();
			this.txthora = new System.Windows.Forms.TextBox();
			this.chkreg_asis = new System.Windows.Forms.CheckBox();
			this.btnfalso_neg = new System.Windows.Forms.Button();
			this.btnfalso_po = new System.Windows.Forms.Button();
			this.btnsalto = new System.Windows.Forms.Button();
			this.btnact_reg_asist = new System.Windows.Forms.Button();
			this.txtfecha = new System.Windows.Forms.DateTimePicker();
			this.dg11 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fotos_empTableAdapter1 = new appvb.dsTableAdapters.fotos_empTableAdapter();
			this.btndesactivar = new System.Windows.Forms.Button();
			this.openFileDialog_detect = new System.Windows.Forms.OpenFileDialog();
			this.btnsubir_archivo = new System.Windows.Forms.Button();
			this.chkarchivo = new System.Windows.Forms.CheckBox();
			this.btndetectar = new System.Windows.Forms.Button();
			this.chkecualizar = new System.Windows.Forms.CheckBox();
			this.btnver_fotos_e = new System.Windows.Forms.Button();
			this.imgmini = new System.Windows.Forms.PictureBox();
			this.imageBox1 = new Emgu.CV.UI.ImageBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imgfoto = new System.Windows.Forms.PictureBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnrecargar = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btnactualizar = new System.Windows.Forms.Button();
			this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
			this.fotosempTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnborrar = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgmini)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fotosempTableAdapterBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtestado,
            this.txtestado2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 789);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1528, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			this.toolStripStatusLabel1.TextChanged += new System.EventHandler(this.toolStripStatusLabel1_TextChanged);
			// 
			// txtestado
			// 
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(19, 17);
			this.txtestado.Text = ".  .";
			// 
			// txtestado2
			// 
			this.txtestado2.Name = "txtestado2";
			this.txtestado2.Size = new System.Drawing.Size(16, 17);
			this.txtestado2.Text = ". .";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png| All f" +
    "iles (*.*)|*.*";
			this.openFileDialog1.Title = "Seleccione foto";
			// 
			// btnactivar
			// 
			this.btnactivar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnactivar.Location = new System.Drawing.Point(16, 260);
			this.btnactivar.Margin = new System.Windows.Forms.Padding(4);
			this.btnactivar.Name = "btnactivar";
			this.btnactivar.Size = new System.Drawing.Size(162, 22);
			this.btnactivar.TabIndex = 2;
			this.btnactivar.Text = "1. Activar Detección";
			this.btnactivar.UseVisualStyleBackColor = true;
			this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(413, 358);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "0";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(446, 356);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 19);
			this.label4.TabIndex = 16;
			this.label4.Text = ".......";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(623, 67);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(382, 21);
			this.txtnombre.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(627, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 15);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nombres:";
			// 
			// txtcedula
			// 
			this.txtcedula.Location = new System.Drawing.Point(748, 24);
			this.txtcedula.Name = "txtcedula";
			this.txtcedula.Size = new System.Drawing.Size(125, 21);
			this.txtcedula.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(694, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 24;
			this.label6.Text = "Cédula";
			// 
			// txttelefonos
			// 
			this.txttelefonos.Location = new System.Drawing.Point(623, 108);
			this.txttelefonos.Name = "txttelefonos";
			this.txttelefonos.Size = new System.Drawing.Size(382, 21);
			this.txttelefonos.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(621, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 15);
			this.label7.TabIndex = 26;
			this.label7.Text = "Teléfonos:";
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(623, 149);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(382, 21);
			this.txtdireccion.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(621, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 15);
			this.label8.TabIndex = 28;
			this.label8.Text = "Dirección:";
			// 
			// bntbuscar_foto
			// 
			this.bntbuscar_foto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bntbuscar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntbuscar_foto.Location = new System.Drawing.Point(1152, 613);
			this.bntbuscar_foto.Margin = new System.Windows.Forms.Padding(4);
			this.bntbuscar_foto.Name = "bntbuscar_foto";
			this.bntbuscar_foto.Size = new System.Drawing.Size(110, 29);
			this.bntbuscar_foto.TabIndex = 29;
			this.bntbuscar_foto.Text = "Buscar Foto";
			this.bntbuscar_foto.UseVisualStyleBackColor = true;
			this.bntbuscar_foto.Click += new System.EventHandler(this.bntbuscar_foto_Click);
			// 
			// btngrabar
			// 
			this.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btngrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btngrabar.Location = new System.Drawing.Point(1296, 612);
			this.btngrabar.Margin = new System.Windows.Forms.Padding(4);
			this.btngrabar.Name = "btngrabar";
			this.btngrabar.Size = new System.Drawing.Size(89, 30);
			this.btngrabar.TabIndex = 30;
			this.btngrabar.Text = "Grabar";
			this.btngrabar.UseVisualStyleBackColor = true;
			this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(694, 355);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 15);
			this.label9.TabIndex = 33;
			this.label9.Text = "Sexo";
			// 
			// btnagregar_rostro
			// 
			this.btnagregar_rostro.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnagregar_rostro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnagregar_rostro.Location = new System.Drawing.Point(204, 260);
			this.btnagregar_rostro.Margin = new System.Windows.Forms.Padding(4);
			this.btnagregar_rostro.Name = "btnagregar_rostro";
			this.btnagregar_rostro.Size = new System.Drawing.Size(225, 22);
			this.btnagregar_rostro.TabIndex = 36;
			this.btnagregar_rostro.Text = "Agregar Rostro detectado  F10";
			this.btnagregar_rostro.UseVisualStyleBackColor = true;
			this.btnagregar_rostro.Click += new System.EventHandler(this.btnagregar_rostro_Click);
			// 
			// chkagregando
			// 
			this.chkagregando.AutoSize = true;
			this.chkagregando.Checked = true;
			this.chkagregando.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkagregando.Location = new System.Drawing.Point(36, 324);
			this.chkagregando.Name = "chkagregando";
			this.chkagregando.Size = new System.Drawing.Size(148, 19);
			this.chkagregando.TabIndex = 41;
			this.chkagregando.Text = "Agregando Rostros";
			this.chkagregando.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(694, 415);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 44;
			this.label10.Text = "SECCION";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(694, 445);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 15);
			this.label11.TabIndex = 46;
			this.label11.Text = "CARGO";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(694, 324);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 15);
			this.label12.TabIndex = 48;
			this.label12.Text = "ESTADO CIVIL";
			// 
			// cmbestado_civil
			// 
			this.cmbestado_civil.FormattingEnabled = true;
			this.cmbestado_civil.Location = new System.Drawing.Point(853, 319);
			this.cmbestado_civil.Name = "cmbestado_civil";
			this.cmbestado_civil.Size = new System.Drawing.Size(164, 23);
			this.cmbestado_civil.TabIndex = 7;
			// 
			// cmbcargos
			// 
			this.cmbcargos.FormattingEnabled = true;
			this.cmbcargos.Location = new System.Drawing.Point(833, 440);
			this.cmbcargos.Name = "cmbcargos";
			this.cmbcargos.Size = new System.Drawing.Size(184, 23);
			this.cmbcargos.TabIndex = 11;
			// 
			// cmbseccion
			// 
			this.cmbseccion.FormattingEnabled = true;
			this.cmbseccion.Location = new System.Drawing.Point(833, 410);
			this.cmbseccion.Name = "cmbseccion";
			this.cmbseccion.Size = new System.Drawing.Size(184, 23);
			this.cmbseccion.TabIndex = 10;
			// 
			// cmbsexo
			// 
			this.cmbsexo.FormattingEnabled = true;
			this.cmbsexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
			this.cmbsexo.Location = new System.Drawing.Point(853, 350);
			this.cmbsexo.Name = "cmbsexo";
			this.cmbsexo.Size = new System.Drawing.Size(164, 23);
			this.cmbsexo.TabIndex = 8;
			// 
			// txtfecha_nac
			// 
			this.txtfecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfecha_nac.Location = new System.Drawing.Point(815, 187);
			this.txtfecha_nac.Name = "txtfecha_nac";
			this.txtfecha_nac.Size = new System.Drawing.Size(103, 21);
			this.txtfecha_nac.TabIndex = 5;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(626, 192);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(162, 15);
			this.label13.TabIndex = 54;
			this.label13.Text = "FECHA DE NACIMIENTO";
			// 
			// txtceddetect
			// 
			this.txtceddetect.Location = new System.Drawing.Point(943, 535);
			this.txtceddetect.Name = "txtceddetect";
			this.txtceddetect.Size = new System.Drawing.Size(74, 21);
			this.txtceddetect.TabIndex = 55;
			this.txtceddetect.Visible = false;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 30;
			// 
			// cedDataGridViewTextBoxColumn
			// 
			this.cedDataGridViewTextBoxColumn.DataPropertyName = "ced";
			this.cedDataGridViewTextBoxColumn.HeaderText = "ced";
			this.cedDataGridViewTextBoxColumn.Name = "cedDataGridViewTextBoxColumn";
			// 
			// nombrearchivoDataGridViewTextBoxColumn
			// 
			this.nombrearchivoDataGridViewTextBoxColumn.DataPropertyName = "nombre_archivo";
			this.nombrearchivoDataGridViewTextBoxColumn.HeaderText = "nombre_archivo";
			this.nombrearchivoDataGridViewTextBoxColumn.Name = "nombrearchivoDataGridViewTextBoxColumn";
			// 
			// posDataGridViewTextBoxColumn
			// 
			this.posDataGridViewTextBoxColumn.DataPropertyName = "pos";
			this.posDataGridViewTextBoxColumn.HeaderText = "pos";
			this.posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
			// 
			// txtestado3
			// 
			this.txtestado3.Location = new System.Drawing.Point(943, 562);
			this.txtestado3.Name = "txtestado3";
			this.txtestado3.Size = new System.Drawing.Size(77, 21);
			this.txtestado3.TabIndex = 58;
			this.txtestado3.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtidd);
			this.groupBox1.Controls.Add(this.txtnombre_b);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtced);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(1024, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 82);
			this.groupBox1.TabIndex = 85;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// txtidd
			// 
			this.txtidd.Location = new System.Drawing.Point(212, 20);
			this.txtidd.Name = "txtidd";
			this.txtidd.Size = new System.Drawing.Size(35, 21);
			this.txtidd.TabIndex = 47;
			this.txtidd.TextChanged += new System.EventHandler(this.txtidd_TextChanged);
			this.txtidd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidd_KeyDown);
			// 
			// txtnombre_b
			// 
			this.txtnombre_b.Location = new System.Drawing.Point(89, 48);
			this.txtnombre_b.Name = "txtnombre_b";
			this.txtnombre_b.Size = new System.Drawing.Size(173, 21);
			this.txtnombre_b.TabIndex = 44;
			this.txtnombre_b.TextChanged += new System.EventHandler(this.txtnombre_b_TextChanged);
			this.txtnombre_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_b_KeyDown);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(11, 50);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(76, 15);
			this.label19.TabIndex = 45;
			this.label19.Text = "NOMBRES";
			// 
			// txtced
			// 
			this.txtced.Location = new System.Drawing.Point(68, 21);
			this.txtced.Name = "txtced";
			this.txtced.Size = new System.Drawing.Size(103, 21);
			this.txtced.TabIndex = 38;
			this.txtced.TextChanged += new System.EventHandler(this.txtced_TextChanged);
			this.txtced.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtced_KeyDown_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(187, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 15);
			this.label2.TabIndex = 37;
			this.label2.Text = "ID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(10, 23);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 15);
			this.label5.TabIndex = 35;
			this.label5.Text = "Cedula:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(621, 27);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(21, 15);
			this.label14.TabIndex = 86;
			this.label14.Text = "ID";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(694, 384);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(153, 15);
			this.label15.TabIndex = 88;
			this.label15.Text = "Fecha de contratación:";
			// 
			// txtfecha_contrata
			// 
			this.txtfecha_contrata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfecha_contrata.Location = new System.Drawing.Point(914, 382);
			this.txtfecha_contrata.Name = "txtfecha_contrata";
			this.txtfecha_contrata.Size = new System.Drawing.Size(103, 21);
			this.txtfecha_contrata.TabIndex = 9;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(628, 217);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 15);
			this.label16.TabIndex = 90;
			this.label16.Text = "Comentario:";
			// 
			// txtcomentario
			// 
			this.txtcomentario.Location = new System.Drawing.Point(623, 234);
			this.txtcomentario.Multiline = true;
			this.txtcomentario.Name = "txtcomentario";
			this.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtcomentario.Size = new System.Drawing.Size(380, 48);
			this.txtcomentario.TabIndex = 6;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(694, 478);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(93, 15);
			this.label17.TabIndex = 92;
			this.label17.Text = "Salario Base:";
			// 
			// txtsueldo
			// 
			this.txtsueldo.Location = new System.Drawing.Point(835, 473);
			this.txtsueldo.Name = "txtsueldo";
			this.txtsueldo.Size = new System.Drawing.Size(72, 21);
			this.txtsueldo.TabIndex = 12;
			this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsueldo_KeyPress);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(694, 507);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(94, 15);
			this.label18.TabIndex = 94;
			this.label18.Text = "Salario Extra:";
			// 
			// txtsu_extra
			// 
			this.txtsu_extra.Location = new System.Drawing.Point(835, 502);
			this.txtsu_extra.Name = "txtsu_extra";
			this.txtsu_extra.Size = new System.Drawing.Size(72, 21);
			this.txtsu_extra.TabIndex = 13;
			this.txtsu_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsu_extra_KeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.optsobNO);
			this.groupBox2.Controls.Add(this.optsobSI);
			this.groupBox2.Location = new System.Drawing.Point(921, 468);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(109, 56);
			this.groupBox2.TabIndex = 95;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sobretiempo";
			// 
			// optsobNO
			// 
			this.optsobNO.AutoSize = true;
			this.optsobNO.Checked = true;
			this.optsobNO.Location = new System.Drawing.Point(62, 20);
			this.optsobNO.Name = "optsobNO";
			this.optsobNO.Size = new System.Drawing.Size(45, 19);
			this.optsobNO.TabIndex = 15;
			this.optsobNO.TabStop = true;
			this.optsobNO.Text = "NO";
			this.optsobNO.UseVisualStyleBackColor = true;
			// 
			// optsobSI
			// 
			this.optsobSI.AutoSize = true;
			this.optsobSI.Location = new System.Drawing.Point(12, 20);
			this.optsobSI.Name = "optsobSI";
			this.optsobSI.Size = new System.Drawing.Size(38, 19);
			this.optsobSI.TabIndex = 14;
			this.optsobSI.TabStop = true;
			this.optsobSI.Text = "SI";
			this.optsobSI.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.optEstadoNO_A);
			this.groupBox3.Controls.Add(this.optEstadoACT);
			this.groupBox3.Location = new System.Drawing.Point(697, 678);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(276, 47);
			this.groupBox3.TabIndex = 96;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Estado";
			// 
			// optEstadoNO_A
			// 
			this.optEstadoNO_A.AutoSize = true;
			this.optEstadoNO_A.Checked = true;
			this.optEstadoNO_A.Location = new System.Drawing.Point(140, 20);
			this.optEstadoNO_A.Name = "optEstadoNO_A";
			this.optEstadoNO_A.Size = new System.Drawing.Size(84, 19);
			this.optEstadoNO_A.TabIndex = 21;
			this.optEstadoNO_A.TabStop = true;
			this.optEstadoNO_A.Text = "No Activo";
			this.optEstadoNO_A.UseVisualStyleBackColor = true;
			// 
			// optEstadoACT
			// 
			this.optEstadoACT.AutoSize = true;
			this.optEstadoACT.Location = new System.Drawing.Point(34, 20);
			this.optEstadoACT.Name = "optEstadoACT";
			this.optEstadoACT.Size = new System.Drawing.Size(62, 19);
			this.optEstadoACT.TabIndex = 20;
			this.optEstadoACT.TabStop = true;
			this.optEstadoACT.Text = "Activo";
			this.optEstadoACT.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.optCargasNO);
			this.groupBox4.Controls.Add(this.optCargasSI);
			this.groupBox4.Location = new System.Drawing.Point(697, 613);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(147, 56);
			this.groupBox4.TabIndex = 96;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Cargas Familiares";
			// 
			// optCargasNO
			// 
			this.optCargasNO.AutoSize = true;
			this.optCargasNO.Checked = true;
			this.optCargasNO.Location = new System.Drawing.Point(67, 25);
			this.optCargasNO.Name = "optCargasNO";
			this.optCargasNO.Size = new System.Drawing.Size(45, 19);
			this.optCargasNO.TabIndex = 19;
			this.optCargasNO.TabStop = true;
			this.optCargasNO.Text = "NO";
			this.optCargasNO.UseVisualStyleBackColor = true;
			// 
			// optCargasSI
			// 
			this.optCargasSI.AutoSize = true;
			this.optCargasSI.Location = new System.Drawing.Point(14, 25);
			this.optCargasSI.Name = "optCargasSI";
			this.optCargasSI.Size = new System.Drawing.Size(38, 19);
			this.optCargasSI.TabIndex = 18;
			this.optCargasSI.TabStop = true;
			this.optCargasSI.Text = "SI";
			this.optCargasSI.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.optfondosNO);
			this.groupBox5.Controls.Add(this.optfondosSI);
			this.groupBox5.Location = new System.Drawing.Point(697, 535);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(228, 56);
			this.groupBox5.TabIndex = 97;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Se Le paga fondos de Reserva?";
			// 
			// optfondosNO
			// 
			this.optfondosNO.AutoSize = true;
			this.optfondosNO.Checked = true;
			this.optfondosNO.Location = new System.Drawing.Point(104, 24);
			this.optfondosNO.Name = "optfondosNO";
			this.optfondosNO.Size = new System.Drawing.Size(45, 19);
			this.optfondosNO.TabIndex = 17;
			this.optfondosNO.TabStop = true;
			this.optfondosNO.Text = "NO";
			this.optfondosNO.UseVisualStyleBackColor = true;
			// 
			// optfondosSI
			// 
			this.optfondosSI.AutoSize = true;
			this.optfondosSI.Location = new System.Drawing.Point(14, 25);
			this.optfondosSI.Name = "optfondosSI";
			this.optfondosSI.Size = new System.Drawing.Size(38, 19);
			this.optfondosSI.TabIndex = 16;
			this.optfondosSI.TabStop = true;
			this.optfondosSI.Text = "SI";
			this.optfondosSI.UseVisualStyleBackColor = true;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(646, 24);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(35, 21);
			this.txtid.TabIndex = 98;
			// 
			// txtfecha_salida
			// 
			this.txtfecha_salida.Location = new System.Drawing.Point(886, 632);
			this.txtfecha_salida.Mask = "00/00/0000";
			this.txtfecha_salida.Name = "txtfecha_salida";
			this.txtfecha_salida.Size = new System.Drawing.Size(89, 21);
			this.txtfecha_salida.TabIndex = 22;
			this.txtfecha_salida.ValidatingType = typeof(System.DateTime);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(883, 613);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(115, 15);
			this.label20.TabIndex = 101;
			this.label20.Text = "Fecha de Salida:";
			// 
			// txtrutafoto
			// 
			this.txtrutafoto.Location = new System.Drawing.Point(1134, 582);
			this.txtrutafoto.Name = "txtrutafoto";
			this.txtrutafoto.Size = new System.Drawing.Size(312, 21);
			this.txtrutafoto.TabIndex = 102;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(204, 358);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 15);
			this.label21.TabIndex = 105;
			this.label21.Text = "Hora";
			// 
			// txthora
			// 
			this.txthora.Location = new System.Drawing.Point(246, 355);
			this.txthora.Name = "txthora";
			this.txthora.Size = new System.Drawing.Size(136, 21);
			this.txthora.TabIndex = 104;
			// 
			// chkreg_asis
			// 
			this.chkreg_asis.AutoSize = true;
			this.chkreg_asis.Checked = true;
			this.chkreg_asis.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkreg_asis.Location = new System.Drawing.Point(430, 296);
			this.chkreg_asis.Name = "chkreg_asis";
			this.chkreg_asis.Size = new System.Drawing.Size(169, 19);
			this.chkreg_asis.TabIndex = 111;
			this.chkreg_asis.Text = "Registro de Asistencia";
			this.chkreg_asis.UseVisualStyleBackColor = true;
			// 
			// btnfalso_neg
			// 
			this.btnfalso_neg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnfalso_neg.Location = new System.Drawing.Point(468, 388);
			this.btnfalso_neg.Name = "btnfalso_neg";
			this.btnfalso_neg.Size = new System.Drawing.Size(154, 27);
			this.btnfalso_neg.TabIndex = 112;
			this.btnfalso_neg.Text = "fue Falso Negativo";
			this.btnfalso_neg.UseVisualStyleBackColor = false;
			this.btnfalso_neg.Click += new System.EventHandler(this.btnfalso_neg_Click);
			// 
			// btnfalso_po
			// 
			this.btnfalso_po.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnfalso_po.Location = new System.Drawing.Point(321, 382);
			this.btnfalso_po.Name = "btnfalso_po";
			this.btnfalso_po.Size = new System.Drawing.Size(141, 27);
			this.btnfalso_po.TabIndex = 113;
			this.btnfalso_po.Text = "fue Falso Positivo";
			this.btnfalso_po.UseVisualStyleBackColor = false;
			this.btnfalso_po.Click += new System.EventHandler(this.btnfalso_po_Click);
			// 
			// btnsalto
			// 
			this.btnsalto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnsalto.Location = new System.Drawing.Point(192, 381);
			this.btnsalto.Name = "btnsalto";
			this.btnsalto.Size = new System.Drawing.Size(116, 27);
			this.btnsalto.TabIndex = 114;
			this.btnsalto.Text = "SALTO";
			this.btnsalto.UseVisualStyleBackColor = false;
			this.btnsalto.Click += new System.EventHandler(this.btnsalto_Click);
			// 
			// btnact_reg_asist
			// 
			this.btnact_reg_asist.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnact_reg_asist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnact_reg_asist.Location = new System.Drawing.Point(36, 350);
			this.btnact_reg_asist.Margin = new System.Windows.Forms.Padding(4);
			this.btnact_reg_asist.Name = "btnact_reg_asist";
			this.btnact_reg_asist.Size = new System.Drawing.Size(144, 30);
			this.btnact_reg_asist.TabIndex = 115;
			this.btnact_reg_asist.Text = "Registrar Asistencias";
			this.btnact_reg_asist.UseVisualStyleBackColor = true;
			this.btnact_reg_asist.Click += new System.EventHandler(this.btnact_reg_asist_Click);
			// 
			// txtfecha
			// 
			this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfecha.Location = new System.Drawing.Point(83, 388);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(103, 21);
			this.txtfecha.TabIndex = 116;
			// 
			// dg11
			// 
			this.dg11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5});
			this.dg11.Location = new System.Drawing.Point(29, 415);
			this.dg11.Name = "dg11";
			this.dg11.Size = new System.Drawing.Size(623, 350);
			this.dg11.TabIndex = 117;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "nro";
			this.Column1.Name = "Column1";
			this.Column1.Width = 50;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Cèdula";
			this.Column4.Name = "Column4";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "hora";
			this.Column3.Name = "Column3";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.Width = 200;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Fecha";
			this.Column5.Name = "Column5";
			// 
			// fotos_empTableAdapter1
			// 
			this.fotos_empTableAdapter1.ClearBeforeFill = true;
			// 
			// btndesactivar
			// 
			this.btndesactivar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btndesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndesactivar.Location = new System.Drawing.Point(13, 290);
			this.btndesactivar.Margin = new System.Windows.Forms.Padding(4);
			this.btndesactivar.Name = "btndesactivar";
			this.btndesactivar.Size = new System.Drawing.Size(162, 22);
			this.btndesactivar.TabIndex = 118;
			this.btndesactivar.Text = "Desactivar Detección";
			this.btndesactivar.UseVisualStyleBackColor = true;
			this.btndesactivar.Click += new System.EventHandler(this.btndesactivar_Click);
			// 
			// openFileDialog_detect
			// 
			this.openFileDialog_detect.FileName = "openFileDialog1";
			this.openFileDialog_detect.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png| All f" +
    "iles (*.*)|*.*";
			this.openFileDialog_detect.Title = "Seleccione foto";
			// 
			// btnsubir_archivo
			// 
			this.btnsubir_archivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnsubir_archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsubir_archivo.Location = new System.Drawing.Point(216, 290);
			this.btnsubir_archivo.Margin = new System.Windows.Forms.Padding(4);
			this.btnsubir_archivo.Name = "btnsubir_archivo";
			this.btnsubir_archivo.Size = new System.Drawing.Size(198, 22);
			this.btnsubir_archivo.TabIndex = 119;
			this.btnsubir_archivo.Text = "Abrir Archivo";
			this.btnsubir_archivo.UseVisualStyleBackColor = true;
			this.btnsubir_archivo.Click += new System.EventHandler(this.btnsubir_archivo_Click);
			// 
			// chkarchivo
			// 
			this.chkarchivo.AutoSize = true;
			this.chkarchivo.Checked = true;
			this.chkarchivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkarchivo.Location = new System.Drawing.Point(508, 354);
			this.chkarchivo.Name = "chkarchivo";
			this.chkarchivo.Size = new System.Drawing.Size(173, 19);
			this.chkarchivo.TabIndex = 120;
			this.chkarchivo.Text = "Detectar desde Archivo";
			this.chkarchivo.UseVisualStyleBackColor = true;
			// 
			// btndetectar
			// 
			this.btndetectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btndetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndetectar.Location = new System.Drawing.Point(216, 317);
			this.btndetectar.Margin = new System.Windows.Forms.Padding(4);
			this.btndetectar.Name = "btndetectar";
			this.btndetectar.Size = new System.Drawing.Size(198, 22);
			this.btndetectar.TabIndex = 121;
			this.btndetectar.Text = "Detectar Archivo";
			this.btndetectar.UseVisualStyleBackColor = true;
			this.btndetectar.Click += new System.EventHandler(this.btndetectar_Click);
			// 
			// chkecualizar
			// 
			this.chkecualizar.AutoSize = true;
			this.chkecualizar.Location = new System.Drawing.Point(430, 323);
			this.chkecualizar.Name = "chkecualizar";
			this.chkecualizar.Size = new System.Drawing.Size(86, 19);
			this.chkecualizar.TabIndex = 122;
			this.chkecualizar.Text = "Ecualizar";
			this.chkecualizar.UseVisualStyleBackColor = true;
			// 
			// btnver_fotos_e
			// 
			this.btnver_fotos_e.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnver_fotos_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnver_fotos_e.Location = new System.Drawing.Point(1152, 710);
			this.btnver_fotos_e.Margin = new System.Windows.Forms.Padding(4);
			this.btnver_fotos_e.Name = "btnver_fotos_e";
			this.btnver_fotos_e.Size = new System.Drawing.Size(188, 29);
			this.btnver_fotos_e.TabIndex = 123;
			this.btnver_fotos_e.Text = "Ver fotos de entrenamiento";
			this.btnver_fotos_e.UseVisualStyleBackColor = true;
			this.btnver_fotos_e.Click += new System.EventHandler(this.btnver_fotos_e_Click);
			// 
			// imgmini
			// 
			this.imgmini.BackColor = System.Drawing.Color.White;
			this.imgmini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.imgmini.Location = new System.Drawing.Point(436, 151);
			this.imgmini.Name = "imgmini";
			this.imgmini.Size = new System.Drawing.Size(163, 131);
			this.imgmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgmini.TabIndex = 110;
			this.imgmini.TabStop = false;
			// 
			// imageBox1
			// 
			this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageBox1.Location = new System.Drawing.Point(436, 11);
			this.imageBox1.Name = "imageBox1";
			this.imageBox1.Size = new System.Drawing.Size(163, 134);
			this.imageBox1.TabIndex = 109;
			this.imageBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(1466, 593);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 52);
			this.pictureBox1.TabIndex = 103;
			this.pictureBox1.TabStop = false;
			// 
			// imgfoto
			// 
			this.imgfoto.BackColor = System.Drawing.Color.White;
			this.imgfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.imgfoto.Location = new System.Drawing.Point(1115, 121);
			this.imgfoto.Name = "imgfoto";
			this.imgfoto.Size = new System.Drawing.Size(386, 441);
			this.imgfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgfoto.TabIndex = 18;
			this.imgfoto.TabStop = false;
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(1347, 12);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(54, 44);
			this.btnadd.TabIndex = 84;
			this.btnadd.Text = "ADD";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnrecargar
			// 
			this.btnrecargar.Image = global::Detector_facial.Properties.Resources.reload_psd;
			this.btnrecargar.Location = new System.Drawing.Point(1316, 62);
			this.btnrecargar.Name = "btnrecargar";
			this.btnrecargar.Size = new System.Drawing.Size(42, 44);
			this.btnrecargar.TabIndex = 83;
			this.btnrecargar.UseVisualStyleBackColor = true;
			this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Image = global::Detector_facial.Properties.Resources.@__borradoR2;
			this.btnlimpiar.Location = new System.Drawing.Point(1299, 12);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(42, 44);
			this.btnlimpiar.TabIndex = 83;
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(1474, 12);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(42, 44);
			this.btnsalir.TabIndex = 82;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btnactualizar
			// 
			this.btnactualizar.Location = new System.Drawing.Point(1407, 12);
			this.btnactualizar.Name = "btnactualizar";
			this.btnactualizar.Size = new System.Drawing.Size(52, 44);
			this.btnactualizar.TabIndex = 81;
			this.btnactualizar.Text = "UPD";
			this.btnactualizar.UseVisualStyleBackColor = true;
			this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click_1);
			// 
			// imageBoxFrameGrabber
			// 
			this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageBoxFrameGrabber.Location = new System.Drawing.Point(16, 11);
			this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4);
			this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
			this.imageBoxFrameGrabber.Size = new System.Drawing.Size(413, 241);
			this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imageBoxFrameGrabber.TabIndex = 4;
			this.imageBoxFrameGrabber.TabStop = false;
			// 
			// fotosempTableAdapterBindingSource
			// 
			this.fotosempTableAdapterBindingSource.DataSource = typeof(appvb.dsTableAdapters.fotos_empTableAdapter);
			// 
			// btnborrar
			// 
			this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnborrar.Location = new System.Drawing.Point(1296, 661);
			this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnborrar.Name = "btnborrar";
			this.btnborrar.Size = new System.Drawing.Size(110, 29);
			this.btnborrar.TabIndex = 124;
			this.btnborrar.Text = "borrar Foto";
			this.btnborrar.UseVisualStyleBackColor = true;
			this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
			// 
			// frmEntrenamiento
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1528, 811);
			this.Controls.Add(this.btnborrar);
			this.Controls.Add(this.btnver_fotos_e);
			this.Controls.Add(this.chkecualizar);
			this.Controls.Add(this.btndetectar);
			this.Controls.Add(this.chkarchivo);
			this.Controls.Add(this.btnsubir_archivo);
			this.Controls.Add(this.btndesactivar);
			this.Controls.Add(this.dg11);
			this.Controls.Add(this.txtfecha);
			this.Controls.Add(this.btnact_reg_asist);
			this.Controls.Add(this.btnsalto);
			this.Controls.Add(this.btnfalso_po);
			this.Controls.Add(this.btnfalso_neg);
			this.Controls.Add(this.chkreg_asis);
			this.Controls.Add(this.imgmini);
			this.Controls.Add(this.imageBox1);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.txthora);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtrutafoto);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.txtfecha_salida);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtsu_extra);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtsueldo);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txtcomentario);
			this.Controls.Add(this.imgfoto);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtfecha_contrata);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.btnrecargar);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnactualizar);
			this.Controls.Add(this.txtestado3);
			this.Controls.Add(this.txtceddetect);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtfecha_nac);
			this.Controls.Add(this.cmbsexo);
			this.Controls.Add(this.cmbseccion);
			this.Controls.Add(this.cmbcargos);
			this.Controls.Add(this.cmbestado_civil);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.chkagregando);
			this.Controls.Add(this.btnagregar_rostro);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btngrabar);
			this.Controls.Add(this.bntbuscar_foto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txttelefonos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtcedula);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.imageBoxFrameGrabber);
			this.Controls.Add(this.btnactivar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmEntrenamiento";
			this.Text = "Detector Facial";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeteccion_KeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgmini)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fotosempTableAdapterBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnactivar;
		private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox imgfoto;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtcedula;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txttelefonos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button bntbuscar_foto;
		private System.Windows.Forms.Button btngrabar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnagregar_rostro;
		private System.Windows.Forms.CheckBox chkagregando;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbestado_civil;
        private System.Windows.Forms.ComboBox cmbcargos;
        private System.Windows.Forms.ComboBox cmbseccion;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.DateTimePicker txtfecha_nac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtceddetect;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrearchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fotosempTableAdapterBindingSource;
        private appvb.dsTableAdapters.fotos_empTableAdapter fotos_empTableAdapter1;
        private System.Windows.Forms.ToolStripStatusLabel txtestado;
        private System.Windows.Forms.ToolStripStatusLabel txtestado2;
        private System.Windows.Forms.TextBox txtestado3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker txtfecha_contrata;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtsu_extra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optsobNO;
        private System.Windows.Forms.RadioButton optsobSI;
        private System.Windows.Forms.TextBox txtnombre_b;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optEstadoNO_A;
        private System.Windows.Forms.RadioButton optEstadoACT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton optCargasNO;
        private System.Windows.Forms.RadioButton optCargasSI;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton optfondosNO;
        private System.Windows.Forms.RadioButton optfondosSI;
        private System.Windows.Forms.TextBox txtidd;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox txtfecha_salida;
        private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtrutafoto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txthora;
		private Emgu.CV.UI.ImageBox imageBox1;
		private System.Windows.Forms.PictureBox imgmini;
		private System.Windows.Forms.CheckBox chkreg_asis;
		private System.Windows.Forms.Button btnfalso_neg;
		private System.Windows.Forms.Button btnfalso_po;
		private System.Windows.Forms.Button btnsalto;
		private System.Windows.Forms.Button btnact_reg_asist;
		private System.Windows.Forms.DateTimePicker txtfecha;
		private System.Windows.Forms.DataGridView dg11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Button btndesactivar;
		private System.Windows.Forms.OpenFileDialog openFileDialog_detect;
		private System.Windows.Forms.Button btnsubir_archivo;
		private System.Windows.Forms.CheckBox chkarchivo;
		private System.Windows.Forms.Button btndetectar;
		private System.Windows.Forms.CheckBox chkecualizar;
		private System.Windows.Forms.Button btnver_fotos_e;
		private System.Windows.Forms.Button btnrecargar;
		private System.Windows.Forms.Button btnborrar;
	}
}

