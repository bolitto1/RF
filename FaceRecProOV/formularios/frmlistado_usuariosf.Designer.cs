namespace Detector_facial
{
	partial class frmlistado_usuariosf
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
			this.dg = new System.Windows.Forms.DataGridView();
			this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnsalir = new System.Windows.Forms.Button();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lIstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listadoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listadoDeEmpleadosNoActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.nom,
            this.ID,
            this.CEDULA,
            this.Column1,
            this.sexo,
            this.estado,
            this.Column2,
            this.c2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dg.Location = new System.Drawing.Point(11, 64);
			this.dg.Margin = new System.Windows.Forms.Padding(2);
			this.dg.Name = "dg";
			this.dg.RowTemplate.Height = 24;
			this.dg.Size = new System.Drawing.Size(1516, 574);
			this.dg.TabIndex = 2;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			this.dg.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentDoubleClick);
			// 
			// nro
			// 
			this.nro.HeaderText = "nro";
			this.nro.Name = "nro";
			this.nro.Width = 50;
			// 
			// nom
			// 
			this.nom.HeaderText = "Apellidos y Nombres";
			this.nom.Name = "nom";
			this.nom.Width = 350;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// CEDULA
			// 
			this.CEDULA.HeaderText = "CEDULA";
			this.CEDULA.Name = "CEDULA";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Fecha de Contratación";
			this.Column1.Name = "Column1";
			// 
			// sexo
			// 
			this.sexo.HeaderText = "Sexo";
			this.sexo.Name = "sexo";
			// 
			// estado
			// 
			this.estado.HeaderText = "Estado";
			this.estado.Name = "estado";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "¿Es usuario del Sistema?";
			this.Column2.Name = "Column2";
			// 
			// c2
			// 
			this.c2.HeaderText = "Estado de Usuario para el Sistema";
			this.c2.Name = "c2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Estado Civil";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Nombre de Usuario";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "FOTO";
			this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "SEXO";
			this.Column6.Name = "Column6";
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(1094, 13);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(42, 44);
			this.btnsalir.TabIndex = 83;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// txttotal
			// 
			this.txttotal.Location = new System.Drawing.Point(1000, 20);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(53, 23);
			this.txttotal.TabIndex = 84;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(938, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 19);
			this.label1.TabIndex = 85;
			this.label1.Text = "TOTAL:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIstadosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1556, 28);
			this.menuStrip1.TabIndex = 87;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lIstadosToolStripMenuItem
			// 
			this.lIstadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem,
            this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem,
            this.listadoDeToolStripMenuItem,
            this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem,
            this.listadoDeEmpleadosNoActivosToolStripMenuItem});
			this.lIstadosToolStripMenuItem.Name = "lIstadosToolStripMenuItem";
			this.lIstadosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
			this.lIstadosToolStripMenuItem.Text = "LIstados";
			// 
			// listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem
			// 
			this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem.Name = "listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem";
			this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(478, 24);
			this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem.Text = "Listado de empleados Activos sin foto de entrenamiento";
			this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem_Click);
			// 
			// listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem
			// 
			this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem.Name = "listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem";
			this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(478, 24);
			this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem.Text = "Listado de Empleados Activos con foto de entrenamiento";
			this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem_Click);
			// 
			// listadoDeToolStripMenuItem
			// 
			this.listadoDeToolStripMenuItem.Name = "listadoDeToolStripMenuItem";
			this.listadoDeToolStripMenuItem.Size = new System.Drawing.Size(478, 24);
			this.listadoDeToolStripMenuItem.Text = "Listado de Empleados Activos ";
			this.listadoDeToolStripMenuItem.Click += new System.EventHandler(this.listadoDeToolStripMenuItem_Click);
			// 
			// listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem
			// 
			this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem.Name = "listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem";
			this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(478, 24);
			this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem.Text = "Listado de empleados con usuario del sistema";
			this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem_Click);
			// 
			// listadoDeEmpleadosNoActivosToolStripMenuItem
			// 
			this.listadoDeEmpleadosNoActivosToolStripMenuItem.Name = "listadoDeEmpleadosNoActivosToolStripMenuItem";
			this.listadoDeEmpleadosNoActivosToolStripMenuItem.Size = new System.Drawing.Size(478, 24);
			this.listadoDeEmpleadosNoActivosToolStripMenuItem.Text = "Listado de empleados no Activos";
			this.listadoDeEmpleadosNoActivosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosNoActivosToolStripMenuItem_Click);
			// 
			// frmlistado_usuariosf
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1556, 633);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmlistado_usuariosf";
			this.Text = "Listado de empleados";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmlistado_usuariosf_Load);
			this.SizeChanged += new System.EventHandler(this.frmlistado_usuariosf_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.DataGridViewTextBoxColumn nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
		private System.Windows.Forms.DataGridViewTextBoxColumn estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn c2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewImageColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.TextBox txttotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem lIstadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosSinFotoDeEntrenamientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosConFotoDeEntrenamientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosConUsuarioDelSistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosNoActivosToolStripMenuItem;
	}
}