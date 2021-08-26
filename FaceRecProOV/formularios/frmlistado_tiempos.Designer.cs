namespace Detector_facial
{
	partial class frmlistado_tiempos
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
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnsalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dg.Location = new System.Drawing.Point(13, 73);
			this.dg.Margin = new System.Windows.Forms.Padding(4);
			this.dg.Name = "dg";
			this.dg.Size = new System.Drawing.Size(1163, 372);
			this.dg.TabIndex = 0;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Inicio";
			this.Column1.Name = "Column1";
			this.Column1.Width = 140;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Fin";
			this.Column2.Name = "Column2";
			this.Column2.Width = 140;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Tiempo";
			this.Column3.Name = "Column3";
			this.Column3.Width = 140;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Milisegundos";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Nombre";
			this.Column5.Name = "Column5";
			this.Column5.Width = 250;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Cédula";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Cantidad de fotos";
			this.Column7.Name = "Column7";
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(781, 12);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(42, 44);
			this.btnsalir.TabIndex = 84;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// frmlistado_tiempos
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1218, 458);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.dg);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmlistado_tiempos";
			this.Text = "Listado tiempos de deteccion";
			this.Load += new System.EventHandler(this.frmlistado_tiempos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Button btnsalir;
	}
}