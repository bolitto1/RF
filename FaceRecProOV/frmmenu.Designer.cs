namespace Detector_facial
{
    partial class frmmenu
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
            this.btndeteccion = new System.Windows.Forms.Button();
            this.btnnuevos = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnlistado = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Detector_facial.app_data.ds();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeteccion
            // 
            this.btndeteccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeteccion.Location = new System.Drawing.Point(29, 37);
            this.btndeteccion.Name = "btndeteccion";
            this.btndeteccion.Size = new System.Drawing.Size(121, 42);
            this.btndeteccion.TabIndex = 0;
            this.btndeteccion.Text = "Registrar fotos";
            this.btndeteccion.UseVisualStyleBackColor = true;
            this.btndeteccion.Click += new System.EventHandler(this.btndeteccion_Click);
            // 
            // btnnuevos
            // 
            this.btnnuevos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevos.Location = new System.Drawing.Point(29, 162);
            this.btnnuevos.Name = "btnnuevos";
            this.btnnuevos.Size = new System.Drawing.Size(121, 43);
            this.btnnuevos.TabIndex = 1;
            this.btnnuevos.Text = "Grabar Nuevos Rostros";
            this.btnnuevos.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(29, 232);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(121, 36);
            this.btneditar.TabIndex = 2;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnlistado
            // 
            this.btnlistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistado.Location = new System.Drawing.Point(29, 289);
            this.btnlistado.Name = "btnlistado";
            this.btnlistado.Size = new System.Drawing.Size(121, 34);
            this.btnlistado.TabIndex = 3;
            this.btnlistado.Text = "Listado";
            this.btnlistado.UseVisualStyleBackColor = true;
            this.btnlistado.Click += new System.EventHandler(this.brnruta_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(29, 340);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(121, 37);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.dsBindingSource;
            // 
            // dsBindingSource
            // 
            this.dsBindingSource.DataSource = this.ds;
            this.dsBindingSource.Position = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlistado);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevos);
            this.Controls.Add(this.btndeteccion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmmenu";
            this.Text = "frmmenu";
            this.Load += new System.EventHandler(this.frmmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btndeteccion;
		private System.Windows.Forms.Button btnnuevos;
		private System.Windows.Forms.Button btneditar;
		private System.Windows.Forms.Button btnlistado;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dsBindingSource;
        private app_data.ds ds;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
    }
}