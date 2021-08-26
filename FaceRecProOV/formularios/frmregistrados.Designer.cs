namespace Detector_facial
{
	partial class frmregistrados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txttotal = new System.Windows.Forms.TextBox();
			this.btncargar = new System.Windows.Forms.Button();
			this.txtpos = new System.Windows.Forms.TextBox();
			this.dg = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgim = new System.Windows.Forms.DataGridView();
			this.cmdborrar = new System.Windows.Forms.Button();
			this.txtborrar = new System.Windows.Forms.TextBox();
			this.cmdcambia_prop = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre2 = new System.Windows.Forms.TextBox();
			this.imgd = new System.Windows.Forms.PictureBox();
			this.txtcedula2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtcedula_b = new System.Windows.Forms.TextBox();
			this.txtnombre_b = new System.Windows.Forms.TextBox();
			this.btnbuscar_origen = new System.Windows.Forms.Button();
			this.btnBuscar_destinatario = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtnombre1 = new System.Windows.Forms.TextBox();
			this.txtcedula1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imgg = new System.Windows.Forms.PictureBox();
			this.ima = new System.Windows.Forms.PictureBox();
			this.imgnofound = new System.Windows.Forms.PictureBox();
			this.imgfoto = new System.Windows.Forms.PictureBox();
			this.txttotal_ea = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txttotal_e = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txttotalminis = new System.Windows.Forms.TextBox();
			this.dgpos_ced = new System.Windows.Forms.DataGridView();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnsalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgim)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ima)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgnofound)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgpos_ced)).BeginInit();
			this.SuspendLayout();
			// 
			// txttotal
			// 
			this.txttotal.Location = new System.Drawing.Point(1099, 484);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(50, 26);
			this.txttotal.TabIndex = 7;
			// 
			// btncargar
			// 
			this.btncargar.Location = new System.Drawing.Point(957, 71);
			this.btncargar.Name = "btncargar";
			this.btncargar.Size = new System.Drawing.Size(97, 26);
			this.btncargar.TabIndex = 4;
			this.btncargar.Text = "Recargar";
			this.btncargar.UseVisualStyleBackColor = true;
			this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
			// 
			// txtpos
			// 
			this.txtpos.Location = new System.Drawing.Point(1104, 513);
			this.txtpos.Name = "txtpos";
			this.txtpos.Size = new System.Drawing.Size(45, 26);
			this.txtpos.TabIndex = 8;
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dg.Location = new System.Drawing.Point(12, 54);
			this.dg.Name = "dg";
			this.dg.RowHeadersWidth = 51;
			this.dg.RowTemplate.Height = 24;
			this.dg.Size = new System.Drawing.Size(532, 362);
			this.dg.TabIndex = 9;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			this.dg.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dg_CellStateChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Cédula";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Apellidos y Nombres";
			this.Column2.Name = "Column2";
			this.Column2.Width = 220;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Cantidad de fotos";
			this.Column3.Name = "Column3";
			this.Column3.Width = 45;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "ID";
			this.Column4.Name = "Column4";
			this.Column4.Width = 35;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Nro";
			this.Column5.Name = "Column5";
			this.Column5.Width = 35;
			// 
			// dgim
			// 
			this.dgim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgim.Location = new System.Drawing.Point(12, 456);
			this.dgim.Name = "dgim";
			this.dgim.RowHeadersWidth = 51;
			this.dgim.RowTemplate.Height = 24;
			this.dgim.Size = new System.Drawing.Size(997, 277);
			this.dgim.TabIndex = 10;
			this.dgim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgim_CellContentClick);
			// 
			// cmdborrar
			// 
			this.cmdborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cmdborrar.Image = global::Detector_facial.Properties.Resources.@__borradoR2;
			this.cmdborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdborrar.Location = new System.Drawing.Point(878, 111);
			this.cmdborrar.Name = "cmdborrar";
			this.cmdborrar.Size = new System.Drawing.Size(205, 47);
			this.cmdborrar.TabIndex = 13;
			this.cmdborrar.Text = "Borrar Foto de Entrenamiento";
			this.cmdborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdborrar.UseVisualStyleBackColor = false;
			this.cmdborrar.Click += new System.EventHandler(this.cmdborrar_Click);
			// 
			// txtborrar
			// 
			this.txtborrar.Enabled = false;
			this.txtborrar.Location = new System.Drawing.Point(1174, 484);
			this.txtborrar.Name = "txtborrar";
			this.txtborrar.Size = new System.Drawing.Size(48, 26);
			this.txtborrar.TabIndex = 14;
			// 
			// cmdcambia_prop
			// 
			this.cmdcambia_prop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmdcambia_prop.Location = new System.Drawing.Point(876, 372);
			this.cmdcambia_prop.Name = "cmdcambia_prop";
			this.cmdcambia_prop.Size = new System.Drawing.Size(207, 33);
			this.cmdcambia_prop.TabIndex = 32;
			this.cmdcambia_prop.Text = "Cambiar Foto de Dueño";
			this.cmdcambia_prop.UseVisualStyleBackColor = false;
			this.cmdcambia_prop.Click += new System.EventHandler(this.cmdcambia_prop_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtnombre2);
			this.groupBox1.Controls.Add(this.imgd);
			this.groupBox1.Controls.Add(this.txtcedula2);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(1094, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 376);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Para este propietario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 18);
			this.label2.TabIndex = 25;
			this.label2.Text = "NOMBRES";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "CEDULA";
			// 
			// txtnombre2
			// 
			this.txtnombre2.Location = new System.Drawing.Point(89, 50);
			this.txtnombre2.Name = "txtnombre2";
			this.txtnombre2.Size = new System.Drawing.Size(268, 26);
			this.txtnombre2.TabIndex = 23;
			// 
			// imgd
			// 
			this.imgd.Image = global::Detector_facial.Properties.Resources.face2;
			this.imgd.Location = new System.Drawing.Point(10, 82);
			this.imgd.Name = "imgd";
			this.imgd.Size = new System.Drawing.Size(282, 296);
			this.imgd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgd.TabIndex = 22;
			this.imgd.TabStop = false;
			// 
			// txtcedula2
			// 
			this.txtcedula2.Enabled = false;
			this.txtcedula2.Location = new System.Drawing.Point(89, 22);
			this.txtcedula2.Name = "txtcedula2";
			this.txtcedula2.Size = new System.Drawing.Size(123, 26);
			this.txtcedula2.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(220, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 18);
			this.label4.TabIndex = 36;
			this.label4.Text = "NOMBRES";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 18);
			this.label3.TabIndex = 35;
			this.label3.Text = "CEDULA";
			// 
			// txtcedula_b
			// 
			this.txtcedula_b.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcedula_b.Location = new System.Drawing.Point(68, 9);
			this.txtcedula_b.Name = "txtcedula_b";
			this.txtcedula_b.Size = new System.Drawing.Size(123, 26);
			this.txtcedula_b.TabIndex = 34;
			// 
			// txtnombre_b
			// 
			this.txtnombre_b.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre_b.Location = new System.Drawing.Point(288, 11);
			this.txtnombre_b.Name = "txtnombre_b";
			this.txtnombre_b.Size = new System.Drawing.Size(322, 26);
			this.txtnombre_b.TabIndex = 33;
			// 
			// btnbuscar_origen
			// 
			this.btnbuscar_origen.Location = new System.Drawing.Point(639, 8);
			this.btnbuscar_origen.Name = "btnbuscar_origen";
			this.btnbuscar_origen.Size = new System.Drawing.Size(145, 28);
			this.btnbuscar_origen.TabIndex = 37;
			this.btnbuscar_origen.Text = "Buscar Empleado";
			this.btnbuscar_origen.UseVisualStyleBackColor = true;
			this.btnbuscar_origen.Click += new System.EventHandler(this.btnbuscar_origen_Click);
			// 
			// btnBuscar_destinatario
			// 
			this.btnBuscar_destinatario.Location = new System.Drawing.Point(790, 6);
			this.btnBuscar_destinatario.Name = "btnBuscar_destinatario";
			this.btnBuscar_destinatario.Size = new System.Drawing.Size(181, 29);
			this.btnBuscar_destinatario.TabIndex = 38;
			this.btnBuscar_destinatario.Text = "Buscar Nuevo Propietario";
			this.btnBuscar_destinatario.UseVisualStyleBackColor = true;
			this.btnBuscar_destinatario.Click += new System.EventHandler(this.btnBuscar_destinatario_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(569, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 15);
			this.label5.TabIndex = 42;
			this.label5.Text = "NOMBRES";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(569, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 15);
			this.label6.TabIndex = 41;
			this.label6.Text = "CEDULA";
			// 
			// txtnombre1
			// 
			this.txtnombre1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre1.Location = new System.Drawing.Point(634, 82);
			this.txtnombre1.Name = "txtnombre1";
			this.txtnombre1.Size = new System.Drawing.Size(268, 23);
			this.txtnombre1.TabIndex = 40;
			// 
			// txtcedula1
			// 
			this.txtcedula1.Enabled = false;
			this.txtcedula1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcedula1.Location = new System.Drawing.Point(634, 54);
			this.txtcedula1.Name = "txtcedula1";
			this.txtcedula1.Size = new System.Drawing.Size(123, 23);
			this.txtcedula1.TabIndex = 39;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Detector_facial.Properties.Resources.face2;
			this.pictureBox1.Location = new System.Drawing.Point(1171, 670);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 63);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// imgg
			// 
			this.imgg.Image = global::Detector_facial.Properties.Resources.face2;
			this.imgg.Location = new System.Drawing.Point(1104, 657);
			this.imgg.Name = "imgg";
			this.imgg.Size = new System.Drawing.Size(45, 66);
			this.imgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgg.TabIndex = 18;
			this.imgg.TabStop = false;
			this.imgg.Visible = false;
			// 
			// ima
			// 
			this.ima.Location = new System.Drawing.Point(878, 164);
			this.ima.Name = "ima";
			this.ima.Size = new System.Drawing.Size(205, 198);
			this.ima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ima.TabIndex = 17;
			this.ima.TabStop = false;
			// 
			// imgnofound
			// 
			this.imgnofound.Image = global::Detector_facial.Properties.Resources.user_generic;
			this.imgnofound.Location = new System.Drawing.Point(1024, 667);
			this.imgnofound.Name = "imgnofound";
			this.imgnofound.Size = new System.Drawing.Size(59, 56);
			this.imgnofound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgnofound.TabIndex = 15;
			this.imgnofound.TabStop = false;
			this.imgnofound.Visible = false;
			// 
			// imgfoto
			// 
			this.imgfoto.Image = global::Detector_facial.Properties.Resources.face2;
			this.imgfoto.Location = new System.Drawing.Point(570, 111);
			this.imgfoto.Name = "imgfoto";
			this.imgfoto.Size = new System.Drawing.Size(281, 300);
			this.imgfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgfoto.TabIndex = 12;
			this.imgfoto.TabStop = false;
			this.imgfoto.DoubleClick += new System.EventHandler(this.imgfoto_DoubleClick);
			// 
			// txttotal_ea
			// 
			this.txttotal_ea.Location = new System.Drawing.Point(184, 428);
			this.txttotal_ea.Name = "txttotal_ea";
			this.txttotal_ea.Size = new System.Drawing.Size(56, 26);
			this.txttotal_ea.TabIndex = 43;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 428);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 18);
			this.label7.TabIndex = 44;
			this.label7.Text = "Total empleados activos";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(308, 428);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(174, 18);
			this.label8.TabIndex = 46;
			this.label8.Text = "Total empleados con fotos:";
			// 
			// txttotal_e
			// 
			this.txttotal_e.Location = new System.Drawing.Point(482, 424);
			this.txttotal_e.Name = "txttotal_e";
			this.txttotal_e.Size = new System.Drawing.Size(56, 26);
			this.txttotal_e.TabIndex = 45;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(572, 428);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(212, 18);
			this.label9.TabIndex = 48;
			this.label9.Text = "Total de fotos de entrenamiento:";
			// 
			// txttotalminis
			// 
			this.txttotalminis.Location = new System.Drawing.Point(795, 420);
			this.txttotalminis.Name = "txttotalminis";
			this.txttotalminis.Size = new System.Drawing.Size(56, 26);
			this.txttotalminis.TabIndex = 47;
			// 
			// dgpos_ced
			// 
			this.dgpos_ced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgpos_ced.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
			this.dgpos_ced.Location = new System.Drawing.Point(1278, 428);
			this.dgpos_ced.Name = "dgpos_ced";
			this.dgpos_ced.RowHeadersWidth = 51;
			this.dgpos_ced.RowTemplate.Height = 24;
			this.dgpos_ced.Size = new System.Drawing.Size(266, 284);
			this.dgpos_ced.TabIndex = 49;
			this.dgpos_ced.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpos_ced_CellContentClick);
			this.dgpos_ced.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgpos_ced_CellStateChanged);
			// 
			// Column6
			// 
			this.Column6.HeaderText = "pos";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 55;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "cedula";
			this.Column7.Name = "Column7";
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(1512, 15);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(48, 47);
			this.btnsalir.TabIndex = 77;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// frmregistrados
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(1596, 762);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.dgpos_ced);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txttotalminis);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txttotal_e);
			this.Controls.Add(this.txtpos);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.txtborrar);
			this.Controls.Add(this.txttotal_ea);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtnombre1);
			this.Controls.Add(this.txtcedula1);
			this.Controls.Add(this.btnBuscar_destinatario);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnbuscar_origen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtcedula_b);
			this.Controls.Add(this.txtnombre_b);
			this.Controls.Add(this.cmdcambia_prop);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.imgg);
			this.Controls.Add(this.ima);
			this.Controls.Add(this.imgnofound);
			this.Controls.Add(this.cmdborrar);
			this.Controls.Add(this.imgfoto);
			this.Controls.Add(this.dgim);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.btncargar);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmregistrados";
			this.Text = "Registrados";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmregistrados_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgim)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ima)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgnofound)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgpos_ced)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Button btncargar;
		internal System.Windows.Forms.TextBox txtpos;
		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.DataGridView dgim;
		private System.Windows.Forms.PictureBox imgfoto;
		private System.Windows.Forms.Button cmdborrar;
        private System.Windows.Forms.TextBox txtborrar;
        private System.Windows.Forms.PictureBox imgnofound;
        private System.Windows.Forms.PictureBox ima;
        private System.Windows.Forms.PictureBox imgg;
        private System.Windows.Forms.Button cmdcambia_prop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.PictureBox imgd;
        private System.Windows.Forms.TextBox txtcedula2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre_b;
        internal System.Windows.Forms.Button btnbuscar_origen;
        internal System.Windows.Forms.Button btnBuscar_destinatario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtcedula1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.TextBox txttotal_ea;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txttotal_e;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txttotalminis;
		private System.Windows.Forms.DataGridView dgpos_ced;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Button btnsalir;
		public System.Windows.Forms.TextBox txtcedula_b;
	}
}