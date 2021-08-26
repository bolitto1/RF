namespace Detector_facial
{
	partial class frmAsistencia
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtcedula = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbcargos = new System.Windows.Forms.ComboBox();
			this.cmbseccion = new System.Windows.Forms.ComboBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombrearchivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label14 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label21 = new System.Windows.Forms.Label();
			this.txthora_m = new System.Windows.Forms.TextBox();
			this.dg11 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fotos_empTableAdapter1 = new appvb.dsTableAdapters.fotos_empTableAdapter();
			this.txtfecha = new System.Windows.Forms.DateTimePicker();
			this.txtfechalarga = new System.Windows.Forms.TextBox();
			this.txthora = new System.Windows.Forms.DateTimePicker();
			this.imageBox1 = new Emgu.CV.UI.ImageBox();
			this.imgfoto = new System.Windows.Forms.PictureBox();
			this.btnsalir = new System.Windows.Forms.Button();
			this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
			this.fotosempTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 840);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1061, 25);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
			// 
			// txtestado
			// 
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(25, 20);
			this.txtestado.Text = ".  .";
			// 
			// txtestado2
			// 
			this.txtestado2.Name = "txtestado2";
			this.txtestado2.Size = new System.Drawing.Size(21, 20);
			this.txtestado2.Text = ". .";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(480, 194);
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
			this.label4.Location = new System.Drawing.Point(556, 197);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 19);
			this.label4.TabIndex = 16;
			this.label4.Text = ".......";
			// 
			// txtnombre
			// 
			this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(154, 746);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(382, 29);
			this.txtnombre.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 746);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nombres:";
			// 
			// txtcedula
			// 
			this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcedula.Location = new System.Drawing.Point(227, 711);
			this.txtcedula.Name = "txtcedula";
			this.txtcedula.Size = new System.Drawing.Size(125, 29);
			this.txtcedula.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(104, 711);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 24);
			this.label6.TabIndex = 24;
			this.label6.Text = "Cédula";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(43, 794);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 44;
			this.label10.Text = "SECCION";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(292, 794);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 15);
			this.label11.TabIndex = 46;
			this.label11.Text = "CARGO";
			// 
			// cmbcargos
			// 
			this.cmbcargos.FormattingEnabled = true;
			this.cmbcargos.Location = new System.Drawing.Point(352, 791);
			this.cmbcargos.Name = "cmbcargos";
			this.cmbcargos.Size = new System.Drawing.Size(127, 23);
			this.cmbcargos.TabIndex = 11;
			// 
			// cmbseccion
			// 
			this.cmbseccion.FormattingEnabled = true;
			this.cmbseccion.Location = new System.Drawing.Point(116, 791);
			this.cmbseccion.Name = "cmbseccion";
			this.cmbseccion.Size = new System.Drawing.Size(154, 23);
			this.cmbseccion.TabIndex = 10;
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
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(31, 711);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 24);
			this.label14.TabIndex = 86;
			this.label14.Text = "ID";
			// 
			// txtid
			// 
			this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtid.Location = new System.Drawing.Point(59, 708);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(35, 29);
			this.txtid.TabIndex = 98;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(19, 324);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(55, 24);
			this.label21.TabIndex = 105;
			this.label21.Text = "Hora";
			// 
			// txthora_m
			// 
			this.txthora_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txthora_m.Location = new System.Drawing.Point(83, 312);
			this.txthora_m.Name = "txthora_m";
			this.txthora_m.Size = new System.Drawing.Size(362, 49);
			this.txthora_m.TabIndex = 104;
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
			this.dg11.Location = new System.Drawing.Point(426, 390);
			this.dg11.Name = "dg11";
			this.dg11.Size = new System.Drawing.Size(598, 258);
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
			// txtfecha
			// 
			this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfecha.Location = new System.Drawing.Point(475, 151);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(118, 21);
			this.txtfecha.TabIndex = 118;
			// 
			// txtfechalarga
			// 
			this.txtfechalarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfechalarga.Location = new System.Drawing.Point(16, 259);
			this.txtfechalarga.Name = "txtfechalarga";
			this.txtfechalarga.Size = new System.Drawing.Size(618, 49);
			this.txtfechalarga.TabIndex = 119;
			// 
			// txthora
			// 
			this.txthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.txthora.Location = new System.Drawing.Point(620, 151);
			this.txthora.Name = "txthora";
			this.txthora.Size = new System.Drawing.Size(97, 21);
			this.txthora.TabIndex = 120;
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
			// imgfoto
			// 
			this.imgfoto.BackColor = System.Drawing.Color.White;
			this.imgfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.imgfoto.Location = new System.Drawing.Point(16, 364);
			this.imgfoto.Name = "imgfoto";
			this.imgfoto.Size = new System.Drawing.Size(369, 327);
			this.imgfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgfoto.TabIndex = 18;
			this.imgfoto.TabStop = false;
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(634, 11);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(42, 44);
			this.btnsalir.TabIndex = 82;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
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
			this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
			// 
			// fotosempTableAdapterBindingSource
			// 
			this.fotosempTableAdapterBindingSource.DataSource = typeof(appvb.dsTableAdapters.fotos_empTableAdapter);
			// 
			// timer2
			// 
			this.timer2.Interval = 2500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// frmAsistencia
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1061, 865);
			this.Controls.Add(this.txthora);
			this.Controls.Add(this.txtfechalarga);
			this.Controls.Add(this.txtfecha);
			this.Controls.Add(this.dg11);
			this.Controls.Add(this.imageBox1);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.txthora_m);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.imgfoto);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.cmbseccion);
			this.Controls.Add(this.cmbcargos);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtcedula);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.imageBoxFrameGrabber);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmAsistencia";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Detector Facial";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
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
		private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox imgfoto;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtcedula;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbcargos;
		private System.Windows.Forms.ComboBox cmbseccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombrearchivoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource fotosempTableAdapterBindingSource;
		private appvb.dsTableAdapters.fotos_empTableAdapter fotos_empTableAdapter1;
		private System.Windows.Forms.ToolStripStatusLabel txtestado;
		private System.Windows.Forms.ToolStripStatusLabel txtestado2;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txthora_m;
		private Emgu.CV.UI.ImageBox imageBox1;
		private System.Windows.Forms.DataGridView dg11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DateTimePicker txtfecha;
		private System.Windows.Forms.TextBox txtfechalarga;
		private System.Windows.Forms.DateTimePicker txthora;
		private System.Windows.Forms.Timer timer2;
	}
}

