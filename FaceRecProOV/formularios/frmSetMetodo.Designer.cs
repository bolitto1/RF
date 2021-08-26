namespace Detector_facial
{
	partial class frmSetMetodo
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
            this.OptFisher = new System.Windows.Forms.RadioButton();
            this.OptLBPH = new System.Windows.Forms.RadioButton();
            this.btnestablecer = new System.Windows.Forms.Button();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.OPTEigen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OptFisher
            // 
            this.OptFisher.AutoSize = true;
            this.OptFisher.Location = new System.Drawing.Point(87, 90);
            this.OptFisher.Margin = new System.Windows.Forms.Padding(5);
            this.OptFisher.Name = "OptFisher";
            this.OptFisher.Size = new System.Drawing.Size(77, 24);
            this.OptFisher.TabIndex = 5;
            this.OptFisher.Text = "Fisher";
            this.OptFisher.UseVisualStyleBackColor = true;
            // 
            // OptLBPH
            // 
            this.OptLBPH.AutoSize = true;
            this.OptLBPH.Location = new System.Drawing.Point(87, 133);
            this.OptLBPH.Margin = new System.Windows.Forms.Padding(5);
            this.OptLBPH.Name = "OptLBPH";
            this.OptLBPH.Size = new System.Drawing.Size(73, 24);
            this.OptLBPH.TabIndex = 113;
            this.OptLBPH.Text = "LBPH";
            this.OptLBPH.UseVisualStyleBackColor = true;
            // 
            // btnestablecer
            // 
            this.btnestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestablecer.Location = new System.Drawing.Point(161, 200);
            this.btnestablecer.Name = "btnestablecer";
            this.btnestablecer.Size = new System.Drawing.Size(97, 36);
            this.btnestablecer.TabIndex = 114;
            this.btnestablecer.Text = "Establecer";
            this.btnestablecer.UseVisualStyleBackColor = true;
            this.btnestablecer.Click += new System.EventHandler(this.btnestablecer_Click);
            // 
            // btncontinuar
            // 
            this.btncontinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.Location = new System.Drawing.Point(39, 200);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(97, 36);
            this.btncontinuar.TabIndex = 115;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // OPTEigen
            // 
            this.OPTEigen.AutoSize = true;
            this.OPTEigen.Checked = true;
            this.OPTEigen.Location = new System.Drawing.Point(87, 45);
            this.OPTEigen.Margin = new System.Windows.Forms.Padding(5);
            this.OPTEigen.Name = "OPTEigen";
            this.OPTEigen.Size = new System.Drawing.Size(162, 24);
            this.OPTEigen.TabIndex = 116;
            this.OPTEigen.Text = "PCA EigenFaces";
            this.OPTEigen.UseVisualStyleBackColor = true;
            // 
            // frmSetMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 270);
            this.Controls.Add(this.OPTEigen);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.btnestablecer);
            this.Controls.Add(this.OptFisher);
            this.Controls.Add(this.OptLBPH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSetMetodo";
            this.Text = "Elija Metodo de Deteccion";
            this.Load += new System.EventHandler(this.frmSetMetodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton OptFisher;
		private System.Windows.Forms.RadioButton OptLBPH;
		private System.Windows.Forms.Button btnestablecer;
		private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.RadioButton OPTEigen;
    }
}