
namespace Detector_facial
{
    partial class frmlistado_fotos1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistado_fotos1));
            this.dg = new System.Windows.Forms.DataGridView();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDEFOTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwcantfotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgim = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.dgf = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.txtcedula2 = new System.Windows.Forms.TextBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdborrar = new System.Windows.Forms.Button();
            this.cmdcambia_prop = new System.Windows.Forms.Button();
            this.cmdgenerar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcantfotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEDULADataGridViewTextBoxColumn,
            this.cANTIDADDEFOTOSDataGridViewTextBoxColumn,
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn});
            this.dg.DataSource = this.vwcantfotosBindingSource;
            this.dg.Location = new System.Drawing.Point(12, 63);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(551, 249);
            this.dg.TabIndex = 0;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick_1);
            // 
            // cEDULADataGridViewTextBoxColumn
            // 
            this.cEDULADataGridViewTextBoxColumn.DataPropertyName = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.Name = "cEDULADataGridViewTextBoxColumn";
            // 
            // cANTIDADDEFOTOSDataGridViewTextBoxColumn
            // 
            this.cANTIDADDEFOTOSDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_DE_FOTOS";
            this.cANTIDADDEFOTOSDataGridViewTextBoxColumn.HeaderText = "CANTIDAD DE FOTOS";
            this.cANTIDADDEFOTOSDataGridViewTextBoxColumn.Name = "cANTIDADDEFOTOSDataGridViewTextBoxColumn";
            // 
            // nOMBRESYAPELLIDOSDataGridViewTextBoxColumn
            // 
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES_Y_APELLIDOS";
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn.HeaderText = "NOMBRES Y APELLIDOS";
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn.Name = "nOMBRESYAPELLIDOSDataGridViewTextBoxColumn";
            this.nOMBRESYAPELLIDOSDataGridViewTextBoxColumn.Width = 290;
            // 
            // vwcantfotosBindingSource
            // 
            this.vwcantfotosBindingSource.DataMember = "vw_cant_fotos";
            this.vwcantfotosBindingSource.DataSource = typeof(appvb.ds);
            // 
            // dgim
            // 
            this.dgim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgim.Location = new System.Drawing.Point(12, 341);
            this.dgim.Name = "dgim";
            this.dgim.RowHeadersWidth = 51;
            this.dgim.RowTemplate.Height = 24;
            this.dgim.Size = new System.Drawing.Size(566, 252);
            this.dgim.TabIndex = 11;
            this.dgim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgim_CellContentClick);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(582, 365);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(180, 228);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 12;
            this.img.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = global::Detector_facial.Properties.Resources.face2;
            this.img1.Location = new System.Drawing.Point(883, 12);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(288, 300);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 16;
            this.img1.TabStop = false;
            // 
            // dgf
            // 
            this.dgf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgf.Location = new System.Drawing.Point(593, 63);
            this.dgf.Name = "dgf";
            this.dgf.RowTemplate.Height = 24;
            this.dgf.Size = new System.Drawing.Size(254, 249);
            this.dgf.TabIndex = 17;
            this.dgf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgf_CellContentClick);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(315, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(356, 22);
            this.txtnombre.TabIndex = 18;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(104, 20);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(123, 22);
            this.txtcedula.TabIndex = 19;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(582, 337);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(100, 22);
            this.txtpos.TabIndex = 20;
            // 
            // txtcedula2
            // 
            this.txtcedula2.Location = new System.Drawing.Point(102, 19);
            this.txtcedula2.Name = "txtcedula2";
            this.txtcedula2.Size = new System.Drawing.Size(123, 22);
            this.txtcedula2.TabIndex = 21;
            this.txtcedula2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcedula2_KeyDown);
            // 
            // img2
            // 
            this.img2.Image = global::Detector_facial.Properties.Resources.face2;
            this.img2.Location = new System.Drawing.Point(64, 75);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(282, 296);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 22;
            this.img2.TabStop = false;
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(102, 47);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(268, 22);
            this.txtnombre2.TabIndex = 23;
            this.txtnombre2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre2_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imgg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnombre2);
            this.groupBox1.Controls.Add(this.img2);
            this.groupBox1.Controls.Add(this.txtcedula2);
            this.groupBox1.Location = new System.Drawing.Point(845, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 377);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLEADO 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "NOMBRES";
            // 
            // imgg
            // 
            this.imgg.Image = global::Detector_facial.Properties.Resources.face2;
            this.imgg.Location = new System.Drawing.Point(-8, 115);
            this.imgg.Name = "imgg";
            this.imgg.Size = new System.Drawing.Size(77, 71);
            this.imgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgg.TabIndex = 26;
            this.imgg.TabStop = false;
            this.imgg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "CEDULA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "NOMBRES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmdborrar
            // 
            this.cmdborrar.Location = new System.Drawing.Point(706, 337);
            this.cmdborrar.Name = "cmdborrar";
            this.cmdborrar.Size = new System.Drawing.Size(75, 23);
            this.cmdborrar.TabIndex = 29;
            this.cmdborrar.Text = "BORRAR";
            this.cmdborrar.UseVisualStyleBackColor = true;
            this.cmdborrar.Click += new System.EventHandler(this.cmdborrar_Click);
            // 
            // cmdcambia_prop
            // 
            this.cmdcambia_prop.Location = new System.Drawing.Point(627, 599);
            this.cmdcambia_prop.Name = "cmdcambia_prop";
            this.cmdcambia_prop.Size = new System.Drawing.Size(220, 23);
            this.cmdcambia_prop.TabIndex = 30;
            this.cmdcambia_prop.Text = "CAMBIAR DE PROPIETARIO ==>";
            this.cmdcambia_prop.UseVisualStyleBackColor = true;
            // 
            // cmdgenerar
            // 
            this.cmdgenerar.Location = new System.Drawing.Point(748, 12);
            this.cmdgenerar.Name = "cmdgenerar";
            this.cmdgenerar.Size = new System.Drawing.Size(107, 32);
            this.cmdgenerar.TabIndex = 31;
            this.cmdgenerar.Text = "Generar";
            this.cmdgenerar.UseVisualStyleBackColor = true;
            this.cmdgenerar.Click += new System.EventHandler(this.cmdgenerar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmlistado_fotos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdgenerar);
            this.Controls.Add(this.cmdcambia_prop);
            this.Controls.Add(this.cmdborrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.dgf);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.dgim);
            this.Controls.Add(this.dg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlistado_fotos1";
            this.Text = "Edicion de Base de Datos";
            this.Load += new System.EventHandler(this.frmlistado_fotos1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcantfotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridView dgim;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.DataGridView dgf;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDEFOTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESYAPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwcantfotosBindingSource;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.TextBox txtcedula2;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox imgg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdborrar;
        private System.Windows.Forms.Button cmdcambia_prop;
        private System.Windows.Forms.Button cmdgenerar;
        private System.Windows.Forms.Button button1;
    }
}

