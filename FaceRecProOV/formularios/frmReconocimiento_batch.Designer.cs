namespace Detector_facial
{
	partial class frmReconocimiento_batch
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
            this.components = new System.ComponentModel.Container();
            this.btnselec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnprosesar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.picOrigen = new System.Windows.Forms.PictureBox();
            this.picDetectada = new System.Windows.Forms.PictureBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmetodo = new System.Windows.Forms.Label();
            this.txtumbral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetectada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselec
            // 
            this.btnselec.Location = new System.Drawing.Point(17, 137);
            this.btnselec.Name = "btnselec";
            this.btnselec.Size = new System.Drawing.Size(218, 38);
            this.btnselec.TabIndex = 4;
            this.btnselec.Text = "Seleccionar Carpeta";
            this.btnselec.UseVisualStyleBackColor = true;
            this.btnselec.Click += new System.EventHandler(this.btnselec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "RECONOCIMIENTO FACIAL POR LOTE";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(17, 181);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(396, 22);
            this.txtruta.TabIndex = 6;
            // 
            // btnprosesar
            // 
            this.btnprosesar.Location = new System.Drawing.Point(17, 284);
            this.btnprosesar.Name = "btnprosesar";
            this.btnprosesar.Size = new System.Drawing.Size(218, 38);
            this.btnprosesar.TabIndex = 7;
            this.btnprosesar.Text = "Procesar Lote";
            this.btnprosesar.UseVisualStyleBackColor = true;
            this.btnprosesar.Click += new System.EventHandler(this.btnprosesar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(461, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 228);
            this.listBox1.TabIndex = 8;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(250, 335);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(133, 134);
            this.imageBox1.TabIndex = 110;
            this.imageBox1.TabStop = false;
            // 
            // picOrigen
            // 
            this.picOrigen.BackColor = System.Drawing.Color.Gray;
            this.picOrigen.Location = new System.Drawing.Point(17, 335);
            this.picOrigen.Name = "picOrigen";
            this.picOrigen.Size = new System.Drawing.Size(214, 228);
            this.picOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrigen.TabIndex = 113;
            this.picOrigen.TabStop = false;
            // 
            // picDetectada
            // 
            this.picDetectada.BackColor = System.Drawing.Color.Gray;
            this.picDetectada.Location = new System.Drawing.Point(390, 335);
            this.picDetectada.Name = "picDetectada";
            this.picDetectada.Size = new System.Drawing.Size(214, 228);
            this.picDetectada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetectada.TabIndex = 114;
            this.picDetectada.TabStop = false;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(250, 511);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(133, 79);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxFrameGrabber.TabIndex = 115;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dg.Location = new System.Drawing.Point(623, 35);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(660, 540);
            this.dg.TabIndex = 116;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Foto";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "archivo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "foto_detectada";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "distancia";
            this.Column4.Name = "Column4";
            // 
            // txtdistancia
            // 
            this.txtdistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistancia.Location = new System.Drawing.Point(256, 475);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 29);
            this.txtdistancia.TabIndex = 117;
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(348, 145);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(35, 22);
            this.txtgrupo.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 120;
            this.label3.Text = "METODO:";
            // 
            // txtmetodo
            // 
            this.txtmetodo.AutoSize = true;
            this.txtmetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetodo.ForeColor = System.Drawing.Color.Red;
            this.txtmetodo.Location = new System.Drawing.Point(129, 110);
            this.txtmetodo.Name = "txtmetodo";
            this.txtmetodo.Size = new System.Drawing.Size(0, 24);
            this.txtmetodo.TabIndex = 121;
            // 
            // txtumbral
            // 
            this.txtumbral.Location = new System.Drawing.Point(94, 224);
            this.txtumbral.Name = "txtumbral";
            this.txtumbral.Size = new System.Drawing.Size(83, 22);
            this.txtumbral.TabIndex = 122;
            this.txtumbral.Text = "3000";
            this.txtumbral.Visible = false;
            this.txtumbral.TextChanged += new System.EventHandler(this.txtumbral_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 123;
            this.label4.Text = "Umbral";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(619, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 124;
            this.label5.Text = "Listado de fotos no reocnocidas";
            // 
            // frmReconocimiento_batch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1308, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtumbral);
            this.Controls.Add(this.txtmetodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.picDetectada);
            this.Controls.Add(this.picOrigen);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnprosesar);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnselec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReconocimiento_batch";
            this.Text = "frmReconocimiento_batch";
            this.Load += new System.EventHandler(this.frmReconocimiento_batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetectada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnselec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtruta;
		private System.Windows.Forms.Button btnprosesar;
		private System.Windows.Forms.ListBox listBox1;
		private Emgu.CV.UI.ImageBox imageBox1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.PictureBox picOrigen;
		private System.Windows.Forms.PictureBox picDetectada;
		private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.TextBox txtdistancia;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewImageColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.TextBox txtgrupo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtmetodo;
		private System.Windows.Forms.TextBox txtumbral;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}