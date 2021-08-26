namespace Detector_facial
{
    partial class frm_selec_roles
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
			this.dgrolesu = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.btncontinuar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgrolesu)).BeginInit();
			this.SuspendLayout();
			// 
			// dgrolesu
			// 
			this.dgrolesu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgrolesu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dgrolesu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgrolesu.Location = new System.Drawing.Point(14, 62);
			this.dgrolesu.MultiSelect = false;
			this.dgrolesu.Name = "dgrolesu";
			this.dgrolesu.ReadOnly = true;
			this.dgrolesu.RowTemplate.Height = 24;
			this.dgrolesu.Size = new System.Drawing.Size(324, 174);
			this.dgrolesu.TabIndex = 73;
			this.dgrolesu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrolesu_CellContentClick);
			this.dgrolesu.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgrolesu_CellStateChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 35;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "ROL";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 180;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(94, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 20);
			this.label6.TabIndex = 72;
			this.label6.Text = "SELECCIONE ROL";
			// 
			// btncontinuar
			// 
			this.btncontinuar.Location = new System.Drawing.Point(113, 255);
			this.btncontinuar.Name = "btncontinuar";
			this.btncontinuar.Size = new System.Drawing.Size(108, 41);
			this.btncontinuar.TabIndex = 74;
			this.btncontinuar.Text = "Continuar";
			this.btncontinuar.UseVisualStyleBackColor = true;
			this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
			// 
			// frm_selec_roles
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(350, 308);
			this.Controls.Add(this.btncontinuar);
			this.Controls.Add(this.dgrolesu);
			this.Controls.Add(this.label6);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frm_selec_roles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seleccione Rol";
			this.Load += new System.EventHandler(this.frm_selec_roles_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgrolesu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrolesu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncontinuar;
    }
}