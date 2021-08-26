namespace Detector_facial
{
    partial class frmRoles
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
			this.txtrol = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dg = new System.Windows.Forms.DataGridView();
			this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.esta2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btngrabar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// txtrol
			// 
			this.txtrol.Location = new System.Drawing.Point(31, 84);
			this.txtrol.Name = "txtrol";
			this.txtrol.Size = new System.Drawing.Size(212, 24);
			this.txtrol.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rol";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "ID";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(69, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(56, 24);
			this.textBox1.TabIndex = 2;
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.rol,
            this.id,
            this.esta2});
			this.dg.Location = new System.Drawing.Point(44, 138);
			this.dg.Name = "dg";
			this.dg.RowTemplate.Height = 24;
			this.dg.Size = new System.Drawing.Size(376, 246);
			this.dg.TabIndex = 4;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.Width = 50;
			// 
			// rol
			// 
			this.rol.HeaderText = "Rol";
			this.rol.Name = "rol";
			this.rol.Width = 150;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 20;
			// 
			// esta2
			// 
			this.esta2.HeaderText = "esta2";
			this.esta2.Name = "esta2";
			this.esta2.ReadOnly = true;
			this.esta2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.esta2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.esta2.Width = 80;
			// 
			// btnadd
			// 
			this.btnadd.Image = global::Detector_facial.Properties.Resources.NUEV;
			this.btnadd.Location = new System.Drawing.Point(267, 5);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(47, 47);
			this.btnadd.TabIndex = 80;
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Image = global::Detector_facial.Properties.Resources.@__borradoR2;
			this.btnlimpiar.Location = new System.Drawing.Point(211, 5);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(47, 47);
			this.btnlimpiar.TabIndex = 79;
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
			// 
			// btnsalir
			// 
			this.btnsalir.Image = global::Detector_facial.Properties.Resources.salir_copiar;
			this.btnsalir.Location = new System.Drawing.Point(373, 5);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(47, 47);
			this.btnsalir.TabIndex = 78;
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btngrabar
			// 
			this.btngrabar.Image = global::Detector_facial.Properties.Resources.diskette01;
			this.btngrabar.Location = new System.Drawing.Point(320, 5);
			this.btngrabar.Name = "btngrabar";
			this.btngrabar.Size = new System.Drawing.Size(47, 47);
			this.btngrabar.TabIndex = 77;
			this.btngrabar.UseVisualStyleBackColor = true;
			this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
			// 
			// frmRoles
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(458, 417);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btngrabar);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtrol);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmRoles";
			this.Text = "Roles";
			this.Load += new System.EventHandler(this.frmRoles_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esta2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnadd;
    }
}