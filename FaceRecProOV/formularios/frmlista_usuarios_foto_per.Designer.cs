namespace Detector_facial
{
    partial class frmlista_usuarios_foto_per
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dg = new System.Windows.Forms.DataGridView();
			this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FOTO_PERFIL = new System.Windows.Forms.DataGridViewImageColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.es = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.es_usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnrecargar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// dg
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.ID,
            this.CEDULA,
            this.NOMBRES,
            this.FOTO_PERFIL,
            this.Estado,
            this.es,
            this.es_usu});
			this.dg.Location = new System.Drawing.Point(0, 71);
			this.dg.Margin = new System.Windows.Forms.Padding(2);
			this.dg.Name = "dg";
			this.dg.RowTemplate.Height = 24;
			this.dg.Size = new System.Drawing.Size(1127, 391);
			this.dg.TabIndex = 0;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			// 
			// NRO
			// 
			this.NRO.HeaderText = "NRO";
			this.NRO.Name = "NRO";
			this.NRO.Width = 61;
			// 
			// ID
			// 
			this.ID.HeaderText = "id";
			this.ID.Name = "ID";
			this.ID.Width = 45;
			// 
			// CEDULA
			// 
			this.CEDULA.HeaderText = "CEDULA";
			this.CEDULA.Name = "CEDULA";
			this.CEDULA.Width = 82;
			// 
			// NOMBRES
			// 
			this.NOMBRES.HeaderText = "APELLIDOS Y NOMBRES";
			this.NOMBRES.Name = "NOMBRES";
			this.NOMBRES.Width = 160;
			// 
			// FOTO_PERFIL
			// 
			this.FOTO_PERFIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.FOTO_PERFIL.Description = "...";
			this.FOTO_PERFIL.HeaderText = "FOTO DE PERFIL";
			this.FOTO_PERFIL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.FOTO_PERFIL.Name = "FOTO_PERFIL";
			this.FOTO_PERFIL.Width = 250;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Empleado Activo / no Activo";
			this.Estado.Name = "Estado";
			this.Estado.Width = 153;
			// 
			// es
			// 
			this.es.HeaderText = "Es usuario del sistema";
			this.es.Name = "es";
			this.es.Width = 111;
			// 
			// es_usu
			// 
			this.es_usu.HeaderText = "Es usuario activo";
			this.es_usu.Name = "es_usu";
			this.es_usu.Width = 123;
			// 
			// btnrecargar
			// 
			this.btnrecargar.Location = new System.Drawing.Point(22, 20);
			this.btnrecargar.Margin = new System.Windows.Forms.Padding(2);
			this.btnrecargar.Name = "btnrecargar";
			this.btnrecargar.Size = new System.Drawing.Size(88, 32);
			this.btnrecargar.TabIndex = 1;
			this.btnrecargar.Text = "RECARGAR";
			this.btnrecargar.UseVisualStyleBackColor = true;
			this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(922, 14);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(42, 44);
			this.btnsalir.TabIndex = 84;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// frmlista_usuarios_foto_per
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1215, 512);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnrecargar);
			this.Controls.Add(this.dg);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmlista_usuarios_foto_per";
			this.Text = "Listado de Usuarios";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmlista_usuarios_foto_per_Activated);
			this.Load += new System.EventHandler(this.frmlista_usuarios_foto_per_Load);
			this.Resize += new System.EventHandler(this.frmlista_usuarios_foto_per_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnrecargar;
		private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
		private System.Windows.Forms.DataGridViewImageColumn FOTO_PERFIL;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn es;
		private System.Windows.Forms.DataGridViewTextBoxColumn es_usu;
		private System.Windows.Forms.Button btnsalir;
	}
}