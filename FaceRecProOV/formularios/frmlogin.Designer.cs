namespace Detector_facial
{
    partial class frmlogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
			this.cmdsalir = new System.Windows.Forms.Button();
			this.cmdEntrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdsalir
			// 
			this.cmdsalir.Location = new System.Drawing.Point(72, 314);
			this.cmdsalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cmdsalir.Name = "cmdsalir";
			this.cmdsalir.Size = new System.Drawing.Size(82, 32);
			this.cmdsalir.TabIndex = 4;
			this.cmdsalir.Text = "&Salir";
			this.cmdsalir.UseVisualStyleBackColor = true;
			this.cmdsalir.Click += new System.EventHandler(this.cmdsalir_Click);
			// 
			// cmdEntrar
			// 
			this.cmdEntrar.Location = new System.Drawing.Point(187, 314);
			this.cmdEntrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cmdEntrar.Name = "cmdEntrar";
			this.cmdEntrar.Size = new System.Drawing.Size(77, 32);
			this.cmdEntrar.TabIndex = 3;
			this.cmdEntrar.Text = "&Entrar";
			this.cmdEntrar.UseVisualStyleBackColor = true;
			this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 145);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 221);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// txtclave
			// 
			this.txtclave.Location = new System.Drawing.Point(44, 242);
			this.txtclave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '*';
			this.txtclave.Size = new System.Drawing.Size(234, 26);
			this.txtclave.TabIndex = 2;
			this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclave_KeyDown);
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(44, 166);
			this.txtusuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(234, 26);
			this.txtusuario.TabIndex = 1;
			this.txtusuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Detector_facial.Properties.Resources.candado;
			this.pictureBox1.Location = new System.Drawing.Point(107, 22);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(115, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "bmmendoza";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(124, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "hola";
			// 
			// frmlogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(318, 378);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.txtclave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdEntrar);
			this.Controls.Add(this.cmdsalir);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmlogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso de Usuario";
			this.Activated += new System.EventHandler(this.frmlogin_Activated);
			this.Load += new System.EventHandler(this.frmlogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdsalir;
        private System.Windows.Forms.Button cmdEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}