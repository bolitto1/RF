namespace Detector_facial
{
	partial class frm_asistencia_detales
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
			this.txtfecha = new System.Windows.Forms.DateTimePicker();
			this.btnconsultar = new System.Windows.Forms.Button();
			this.dg = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnC_falsos = new System.Windows.Forms.Button();
			this.btnC_falsos_sin_fe = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// txtfecha
			// 
			this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfecha.Location = new System.Drawing.Point(44, 40);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.ShowUpDown = true;
			this.txtfecha.Size = new System.Drawing.Size(124, 22);
			this.txtfecha.TabIndex = 117;
			// 
			// btnconsultar
			// 
			this.btnconsultar.Location = new System.Drawing.Point(215, 12);
			this.btnconsultar.Name = "btnconsultar";
			this.btnconsultar.Size = new System.Drawing.Size(118, 59);
			this.btnconsultar.TabIndex = 118;
			this.btnconsultar.Text = "Consultar Registro Gen";
			this.btnconsultar.UseVisualStyleBackColor = true;
			this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.dg.Location = new System.Drawing.Point(12, 95);
			this.dg.Name = "dg";
			this.dg.Size = new System.Drawing.Size(1376, 580);
			this.dg.TabIndex = 119;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "MARCACION";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "CEDULA";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "FECHA";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "CANT F";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Comentario";
			this.Column6.Name = "Column6";
			this.Column6.Width = 180;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "IMAGEN";
			this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "NOMBRE";
			this.Column8.Name = "Column8";
			this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column8.Width = 300;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Foto Empleado";
			this.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column9.Name = "Column9";
			this.Column9.Width = 140;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Milisegundos";
			this.Column10.Name = "Column10";
			// 
			// btnC_falsos
			// 
			this.btnC_falsos.Location = new System.Drawing.Point(399, 12);
			this.btnC_falsos.Name = "btnC_falsos";
			this.btnC_falsos.Size = new System.Drawing.Size(98, 59);
			this.btnC_falsos.TabIndex = 120;
			this.btnC_falsos.Text = "Consultar Falsos por Fecha";
			this.btnC_falsos.UseVisualStyleBackColor = true;
			this.btnC_falsos.Click += new System.EventHandler(this.btnC_falsos_Click);
			// 
			// btnC_falsos_sin_fe
			// 
			this.btnC_falsos_sin_fe.Location = new System.Drawing.Point(518, 12);
			this.btnC_falsos_sin_fe.Name = "btnC_falsos_sin_fe";
			this.btnC_falsos_sin_fe.Size = new System.Drawing.Size(98, 59);
			this.btnC_falsos_sin_fe.TabIndex = 121;
			this.btnC_falsos_sin_fe.Text = "Consultar Falsos";
			this.btnC_falsos_sin_fe.UseVisualStyleBackColor = true;
			this.btnC_falsos_sin_fe.Click += new System.EventHandler(this.btnC_falsos_sin_fe_Click);
			// 
			// frm_asistencia_detales
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1400, 711);
			this.Controls.Add(this.btnC_falsos_sin_fe);
			this.Controls.Add(this.btnC_falsos);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.btnconsultar);
			this.Controls.Add(this.txtfecha);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frm_asistencia_detales";
			this.Text = "frm_asistencia_detales";
			this.Load += new System.EventHandler(this.frm_asistencia_detales_Load);
			this.SizeChanged += new System.EventHandler(this.frm_asistencia_detales_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker txtfecha;
		private System.Windows.Forms.Button btnconsultar;
		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.Button btnC_falsos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewImageColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.Button btnC_falsos_sin_fe;
	}
}