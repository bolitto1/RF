namespace Detector_facial
{
	partial class frm_cambiar_clave
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
			this.txtid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnombre1 = new System.Windows.Forms.TextBox();
			this.txtconfirmarclave = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btngrabar = new System.Windows.Forms.Button();
			this.chkpassview = new System.Windows.Forms.CheckBox();
			this.txtanteriorclave = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(324, 43);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(38, 27);
			this.txtid.TabIndex = 116;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(295, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 19);
			this.label1.TabIndex = 117;
			this.label1.Text = "ID";
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(120, 43);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(124, 27);
			this.txtusuario.TabIndex = 114;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(38, 45);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(61, 19);
			this.label15.TabIndex = 115;
			this.label15.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 19);
			this.label2.TabIndex = 113;
			this.label2.Text = "Apellidos y nombres:";
			// 
			// txtnombre1
			// 
			this.txtnombre1.Location = new System.Drawing.Point(196, 92);
			this.txtnombre1.Name = "txtnombre1";
			this.txtnombre1.Size = new System.Drawing.Size(309, 27);
			this.txtnombre1.TabIndex = 112;
			// 
			// txtconfirmarclave
			// 
			this.txtconfirmarclave.Location = new System.Drawing.Point(194, 219);
			this.txtconfirmarclave.Name = "txtconfirmarclave";
			this.txtconfirmarclave.PasswordChar = '*';
			this.txtconfirmarclave.Size = new System.Drawing.Size(139, 27);
			this.txtconfirmarclave.TabIndex = 107;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(38, 223);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(121, 19);
			this.label17.TabIndex = 108;
			this.label17.Text = "Confirmar Clave:";
			// 
			// txtclave
			// 
			this.txtclave.Location = new System.Drawing.Point(194, 186);
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '*';
			this.txtclave.Size = new System.Drawing.Size(139, 27);
			this.txtclave.TabIndex = 105;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(38, 190);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(97, 19);
			this.label16.TabIndex = 106;
			this.label16.Text = "Nueva Clave:";
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(482, 23);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(48, 47);
			this.btnsalir.TabIndex = 111;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btngrabar
			// 
			this.btngrabar.Image = global::Detector_facial.Properties.Resources.diskette01;
			this.btngrabar.Location = new System.Drawing.Point(428, 23);
			this.btngrabar.Name = "btngrabar";
			this.btngrabar.Size = new System.Drawing.Size(48, 47);
			this.btngrabar.TabIndex = 110;
			this.btngrabar.UseVisualStyleBackColor = true;
			this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
			// 
			// chkpassview
			// 
			this.chkpassview.AutoSize = true;
			this.chkpassview.Image = global::Detector_facial.Properties.Resources.ver_si;
			this.chkpassview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.chkpassview.Location = new System.Drawing.Point(400, 175);
			this.chkpassview.Name = "chkpassview";
			this.chkpassview.Size = new System.Drawing.Size(90, 48);
			this.chkpassview.TabIndex = 109;
			this.chkpassview.Text = "Ver Clave";
			this.chkpassview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.chkpassview.UseVisualStyleBackColor = true;
			this.chkpassview.CheckedChanged += new System.EventHandler(this.chkpassview_CheckedChanged);
			// 
			// txtanteriorclave
			// 
			this.txtanteriorclave.Location = new System.Drawing.Point(194, 149);
			this.txtanteriorclave.Name = "txtanteriorclave";
			this.txtanteriorclave.PasswordChar = '*';
			this.txtanteriorclave.Size = new System.Drawing.Size(139, 27);
			this.txtanteriorclave.TabIndex = 118;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 19);
			this.label3.TabIndex = 119;
			this.label3.Text = "Anterior Clave:";
			// 
			// frm_cambiar_clave
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(555, 287);
			this.Controls.Add(this.txtanteriorclave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtnombre1);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btngrabar);
			this.Controls.Add(this.chkpassview);
			this.Controls.Add(this.txtconfirmarclave);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtclave);
			this.Controls.Add(this.label16);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frm_cambiar_clave";
			this.Text = "Cambiar Clave";
			this.Load += new System.EventHandler(this.frm_cambiar_clave_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtnombre1;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btngrabar;
		private System.Windows.Forms.CheckBox chkpassview;
		private System.Windows.Forms.TextBox txtconfirmarclave;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtclave;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtanteriorclave;
		private System.Windows.Forms.Label label3;
	}
}