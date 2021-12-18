
namespace PS4Payload
{
    partial class descarga
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
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbtipo = new System.Windows.Forms.Label();
            this.lblink = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(37, 221);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(725, 78);
            this.progreso.TabIndex = 0;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(37, 31);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(78, 25);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre";
            // 
            // lbpeso
            // 
            this.lbpeso.AutoSize = true;
            this.lbpeso.Location = new System.Drawing.Point(37, 75);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(49, 25);
            this.lbpeso.TabIndex = 2;
            this.lbpeso.Text = "Peso";
            // 
            // lbtipo
            // 
            this.lbtipo.AutoSize = true;
            this.lbtipo.Location = new System.Drawing.Point(37, 114);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(47, 25);
            this.lbtipo.TabIndex = 3;
            this.lbtipo.Text = "Tipo";
            // 
            // lblink
            // 
            this.lblink.AutoSize = true;
            this.lblink.Location = new System.Drawing.Point(37, 155);
            this.lblink.Name = "lblink";
            this.lblink.Size = new System.Drawing.Size(43, 25);
            this.lblink.TabIndex = 4;
            this.lblink.Text = "Link";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(37, 324);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(312, 72);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(450, 324);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(312, 72);
            this.btnfinalizar.TabIndex = 6;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // descarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblink);
            this.Controls.Add(this.lbtipo);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.progreso);
            this.Name = "descarga";
            this.Text = "descarga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.Label lblink;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfinalizar;
    }
}