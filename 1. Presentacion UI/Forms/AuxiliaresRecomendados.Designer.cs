namespace Saratyc._1._Presentacion_UI.Forms
{
    partial class AuxiliaresRecomendados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeCompatibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPaciente = new System.Windows.Forms.TextBox();
            this.paciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            this.textTipoTurno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textInst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Saratyc.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(32, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 317);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ranking,
            this.Identificacion,
            this.Nombres,
            this.Apellidos,
            this.PorcentajeCompatibilidad});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(799, 317);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ranking
            // 
            this.ranking.HeaderText = "Ranking";
            this.ranking.MinimumWidth = 6;
            this.ranking.Name = "ranking";
            this.ranking.Width = 125;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 125;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 125;
            // 
            // PorcentajeCompatibilidad
            // 
            this.PorcentajeCompatibilidad.HeaderText = "%Compatibilidad";
            this.PorcentajeCompatibilidad.MinimumWidth = 6;
            this.PorcentajeCompatibilidad.Name = "PorcentajeCompatibilidad";
            this.PorcentajeCompatibilidad.Width = 125;
            // 
            // textTurno
            // 
            this.textTurno.Enabled = false;
            this.textTurno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTurno.Location = new System.Drawing.Point(539, 54);
            this.textTurno.Name = "textTurno";
            this.textTurno.Size = new System.Drawing.Size(100, 26);
            this.textTurno.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(451, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turno";
            // 
            // textPaciente
            // 
            this.textPaciente.Enabled = false;
            this.textPaciente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textPaciente.Location = new System.Drawing.Point(290, 54);
            this.textPaciente.Name = "textPaciente";
            this.textPaciente.Size = new System.Drawing.Size(100, 26);
            this.textPaciente.TabIndex = 9;
            // 
            // paciente
            // 
            this.paciente.AutoSize = true;
            this.paciente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paciente.Location = new System.Drawing.Point(204, 58);
            this.paciente.Name = "paciente";
            this.paciente.Size = new System.Drawing.Size(73, 18);
            this.paciente.TabIndex = 8;
            this.paciente.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auxiliares Recomendados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.LightGray;
            this.regresar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regresar.Location = new System.Drawing.Point(397, 479);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(94, 29);
            this.regresar.TabIndex = 7;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // textTipoTurno
            // 
            this.textTipoTurno.Enabled = false;
            this.textTipoTurno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTipoTurno.Location = new System.Drawing.Point(539, 97);
            this.textTipoTurno.Name = "textTipoTurno";
            this.textTipoTurno.Size = new System.Drawing.Size(100, 26);
            this.textTipoTurno.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(424, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Turno";
            // 
            // textInst
            // 
            this.textInst.Enabled = false;
            this.textInst.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textInst.Location = new System.Drawing.Point(290, 97);
            this.textInst.Name = "textInst";
            this.textInst.Size = new System.Drawing.Size(100, 26);
            this.textInst.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(188, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Institución";
            // 
            // AuxiliaresRecomendados
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(851, 533);
            this.Controls.Add(this.textTipoTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTurno);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textPaciente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paciente);
            this.Controls.Add(this.label1);
            this.Name = "AuxiliaresRecomendados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auxiliares Recomendados";
            this.Load += new System.EventHandler(this.AsignarAuxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button regresar;
        private Label paciente;
        private TextBox textPaciente;
        private DataGridViewTextBoxColumn ranking;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn PorcentajeCompatibilidad;
        private TextBox textTurno;
        private Label label2;
        private TextBox textTipoTurno;
        private Label label3;
        private TextBox textInst;
        private Label label4;
    }
}