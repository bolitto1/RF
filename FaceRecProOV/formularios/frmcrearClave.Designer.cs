namespace Detector_facial
{
    partial class frmcrearClave
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
			this.txtconfirmarclave = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnombre1 = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btngrabar = new System.Windows.Forms.Button();
			this.chkpassview = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtconfirmarclave
			// 
			this.txtconfirmarclave.Location = new System.Drawing.Point(179, 165);
			this.txtconfirmarclave.Name = "txtconfirmarclave";
			this.txtconfirmarclave.PasswordChar = '*';
			this.txtconfirmarclave.Size = new System.Drawing.Size(139, 22);
			this.txtconfirmarclave.TabIndex = 93;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(27, 171);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(122, 16);
			this.label17.TabIndex = 94;
			this.label17.Text = "Confirmar Clave:";
			// 
			// txtclave
			// 
			this.txtclave.Location = new System.Drawing.Point(179, 133);
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '*';
			this.txtclave.Size = new System.Drawing.Size(139, 22);
			this.txtclave.TabIndex = 91;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(27, 139);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 16);
			this.label16.TabIndex = 92;
			this.label16.Text = "Clave:";
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(105, 40);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(124, 22);
			this.txtusuario.TabIndex = 101;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(27, 40);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(62, 16);
			this.label15.TabIndex = 102;
			this.label15.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 16);
			this.label2.TabIndex = 100;
			this.label2.Text = "Apellidos y nombres:";
			// 
			// txtnombre1
			// 
			this.txtnombre1.Location = new System.Drawing.Point(198, 88);
			this.txtnombre1.Name = "txtnombre1";
			this.txtnombre1.Size = new System.Drawing.Size(292, 22);
			this.txtnombre1.TabIndex = 99;
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(309, 40);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(38, 22);
			this.txtid.TabIndex = 103;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(280, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 16);
			this.label1.TabIndex = 104;
			this.label1.Text = "ID";
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(442, 18);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(48, 47);
			this.btnsalir.TabIndex = 97;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btngrabar
			// 
			this.btngrabar.Image = global::Detector_facial.Properties.Resources.diskette01;
			this.btngrabar.Location = new System.Drawing.Point(369, 18);
			this.btngrabar.Name = "btngrabar";
			this.btngrabar.Size = new System.Drawing.Size(48, 47);
			this.btngrabar.TabIndex = 96;
			this.btngrabar.UseVisualStyleBackColor = true;
			this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
			// 
			// chkpassview
			// 
			this.chkpassview.AutoSize = true;
			this.chkpassview.Image = global::Detector_facial.Properties.Resources.ver_si;
			this.chkpassview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.chkpassview.Location = new System.Drawing.Point(388, 133);
			this.chkpassview.Name = "chkpassview";
			this.chkpassview.Size = new System.Drawing.Size(95, 45);
			this.chkpassview.TabIndex = 95;
			this.chkpassview.Text = "Ver Clave";
			this.chkpassview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.chkpassview.UseVisualStyleBackColor = true;
			this.chkpassview.CheckedChanged += new System.EventHandler(this.chkpassview_CheckedChanged);
			// 
			// frmcrearClave
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(534, 238);
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
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmcrearClave";
			this.Text = "Crear / Establecer Clave";
			this.Load += new System.EventHandler(this.frmcrearClave_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkpassview;
        private System.Windows.Forms.TextBox txtconfirmarclave;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtnombre1;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
    }
}