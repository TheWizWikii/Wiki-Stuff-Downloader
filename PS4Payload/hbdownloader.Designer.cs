
namespace PS4Payload
{
    partial class hbdownloader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.dgvdescargas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescargas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(376, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de archivo";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtbuscar.ForeColor = System.Drawing.Color.Pink;
            this.txtbuscar.Location = new System.Drawing.Point(58, 62);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(287, 31);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // cbtipo
            // 
            this.cbtipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbtipo.ForeColor = System.Drawing.Color.Pink;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Todos",
            "PS3 Hombrew",
            "PS4 Hombrew",
            "PS4 Utility",
            "PS3-PSN",
            "PS3-PSX",
            "PS4-PSX",
            "Port PS3",
            "Emulador PS3",
            "Emulador PS4",
            "PS4 Media",
            "Payload",
            "Rap PS3"});
            this.cbtipo.Location = new System.Drawing.Point(376, 62);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(347, 33);
            this.cbtipo.TabIndex = 3;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre,
            this.coltipo,
            this.colpeso,
            this.collink});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv.Location = new System.Drawing.Point(58, 120);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(1598, 314);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 4;
            // 
            // colnombre
            // 
            this.colnombre.HeaderText = "Nombre";
            this.colnombre.MinimumWidth = 8;
            this.colnombre.Name = "colnombre";
            this.colnombre.Width = 250;
            // 
            // coltipo
            // 
            this.coltipo.HeaderText = "Tipo";
            this.coltipo.MinimumWidth = 8;
            this.coltipo.Name = "coltipo";
            this.coltipo.Width = 150;
            // 
            // colpeso
            // 
            this.colpeso.HeaderText = "Peso";
            this.colpeso.MinimumWidth = 8;
            this.colpeso.Name = "colpeso";
            this.colpeso.Width = 150;
            // 
            // collink
            // 
            this.collink.HeaderText = "Link";
            this.collink.MinimumWidth = 8;
            this.collink.Name = "collink";
            this.collink.Width = 150;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(1792, 31);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(93, 39);
            this.rtb.TabIndex = 5;
            this.rtb.Text = "";
            this.rtb.Visible = false;
            // 
            // dgvdescargas
            // 
            this.dgvdescargas.AllowUserToAddRows = false;
            this.dgvdescargas.AllowUserToDeleteRows = false;
            this.dgvdescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdescargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvdescargas.Location = new System.Drawing.Point(58, 547);
            this.dgvdescargas.Name = "dgvdescargas";
            this.dgvdescargas.ReadOnly = true;
            this.dgvdescargas.RowHeadersWidth = 62;
            this.dgvdescargas.RowTemplate.Height = 33;
            this.dgvdescargas.Size = new System.Drawing.Size(1586, 298);
            this.dgvdescargas.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Link";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Abel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguardar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnguardar.Location = new System.Drawing.Point(1681, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 81);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar \"links.txt\"";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(780, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.ForeColor = System.Drawing.Color.Lime;
            this.count.Location = new System.Drawing.Point(206, 31);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(32, 25);
            this.count.TabIndex = 1;
            this.count.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contenido Disponible:";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(58, 452);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(1586, 77);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Descargar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.iconButton2.IconColor = System.Drawing.Color.Crimson;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(58, 858);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(786, 77);
            this.iconButton2.TabIndex = 15;
            this.iconButton2.Text = "Cancelar Todo";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.iconButton3.IconColor = System.Drawing.Color.Crimson;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(858, 858);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(786, 77);
            this.iconButton3.TabIndex = 16;
            this.iconButton3.Text = "Cancelar Selección";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // hbdownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1927, 972);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvdescargas);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hbdownloader";
            this.Text = "Stuff Downloader";
            this.Load += new System.EventHandler(this.hbdownloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescargas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.DataGridView dgvdescargas;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewProgressColumn colprogreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn collink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}