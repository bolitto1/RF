namespace Detector_facial
{
	partial class frm_rep_recon
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
			this.dgp = new System.Windows.Forms.DataGridView();
			this.dgd = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtid = new System.Windows.Forms.TextBox();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnexportar = new System.Windows.Forms.Button();
			this.txtmetodo = new System.Windows.Forms.TextBox();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgd)).BeginInit();
			this.SuspendLayout();
			// 
			// dgp
			// 
			this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgp.Location = new System.Drawing.Point(12, 46);
			this.dgp.Name = "dgp";
			this.dgp.RowTemplate.Height = 24;
			this.dgp.Size = new System.Drawing.Size(688, 150);
			this.dgp.TabIndex = 0;
			this.dgp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgp_CellContentClick);
			this.dgp.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgp_CellStateChanged);
			// 
			// dgd
			// 
			this.dgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.dgd.Location = new System.Drawing.Point(12, 224);
			this.dgd.Name = "dgd";
			this.dgd.RowTemplate.Height = 24;
			this.dgd.Size = new System.Drawing.Size(1279, 421);
			this.dgd.TabIndex = 1;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "FECHA";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Metodo";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 450;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(751, 71);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(60, 22);
			this.txtid.TabIndex = 2;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "id";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 70;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "num";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 60;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "milisegundos";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Ruta de Archivo";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 250;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "cedula";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "distancia";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "comentario";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "Tiempo de Reconocimiento";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// btnexportar
			// 
			this.btnexportar.Location = new System.Drawing.Point(958, 31);
			this.btnexportar.Name = "btnexportar";
			this.btnexportar.Size = new System.Drawing.Size(164, 52);
			this.btnexportar.TabIndex = 3;
			this.btnexportar.Text = "Exportar hacia CSV";
			this.btnexportar.UseVisualStyleBackColor = true;
			this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
			// 
			// txtmetodo
			// 
			this.txtmetodo.Location = new System.Drawing.Point(751, 184);
			this.txtmetodo.Name = "txtmetodo";
			this.txtmetodo.Size = new System.Drawing.Size(232, 22);
			this.txtmetodo.TabIndex = 4;
			// 
			// txtfecha
			// 
			this.txtfecha.Location = new System.Drawing.Point(751, 120);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(178, 22);
			this.txtfecha.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(751, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(751, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "FECHA";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(748, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "METODO";
			// 
			// frm_rep_recon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1303, 657);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtfecha);
			this.Controls.Add(this.txtmetodo);
			this.Controls.Add(this.btnexportar);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.dgd);
			this.Controls.Add(this.dgp);
			this.Name = "frm_rep_recon";
			this.Text = "Reporte de Procesos de reconocimiento";
			this.Load += new System.EventHandler(this.frm_rep_recon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgp;
		private System.Windows.Forms.DataGridView dgd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.Button btnexportar;
		private System.Windows.Forms.TextBox txtmetodo;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}