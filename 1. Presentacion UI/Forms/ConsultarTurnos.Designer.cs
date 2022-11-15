namespace Saratyc._1._Presentacion_UI.Forms
{
    partial class ConsultarTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTurnos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGinstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGtipoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGfechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGfechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGidPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxiliarEnferdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxiliarSaratyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGrestriccionAuxPreferido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGrestriccionAuxRechazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.Indicador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Saratyc.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(117, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 244);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Turnos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGinstitucion,
            this.DGtipoTurno,
            this.DGfechaInicio,
            this.DGfechaFin,
            this.DGidPaciente,
            this.AuxiliarEnferdata,
            this.AuxiliarSaratyc,
            this.DGrestriccionAuxPreferido,
            this.DGrestriccionAuxRechazado,
            this.Turno});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 244);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DGinstitucion
            // 
            this.DGinstitucion.HeaderText = "Institucion ";
            this.DGinstitucion.MinimumWidth = 6;
            this.DGinstitucion.Name = "DGinstitucion";
            this.DGinstitucion.Width = 200;
            // 
            // DGtipoTurno
            // 
            this.DGtipoTurno.HeaderText = "Tipo Turno";
            this.DGtipoTurno.MinimumWidth = 6;
            this.DGtipoTurno.Name = "DGtipoTurno";
            this.DGtipoTurno.Width = 200;
            // 
            // DGfechaInicio
            // 
            this.DGfechaInicio.HeaderText = "Fecha Inicio";
            this.DGfechaInicio.MinimumWidth = 6;
            this.DGfechaInicio.Name = "DGfechaInicio";
            this.DGfechaInicio.Width = 125;
            // 
            // DGfechaFin
            // 
            this.DGfechaFin.HeaderText = "Fecha Fin";
            this.DGfechaFin.MinimumWidth = 6;
            this.DGfechaFin.Name = "DGfechaFin";
            this.DGfechaFin.Width = 125;
            // 
            // DGidPaciente
            // 
            this.DGidPaciente.HeaderText = "IdPaciente";
            this.DGidPaciente.MinimumWidth = 6;
            this.DGidPaciente.Name = "DGidPaciente";
            this.DGidPaciente.Width = 125;
            // 
            // AuxiliarEnferdata
            // 
            this.AuxiliarEnferdata.HeaderText = "Auxiliar Enferdata";
            this.AuxiliarEnferdata.MinimumWidth = 6;
            this.AuxiliarEnferdata.Name = "AuxiliarEnferdata";
            this.AuxiliarEnferdata.Width = 125;
            // 
            // AuxiliarSaratyc
            // 
            this.AuxiliarSaratyc.HeaderText = "Auxiliar Saratyc";
            this.AuxiliarSaratyc.MinimumWidth = 6;
            this.AuxiliarSaratyc.Name = "AuxiliarSaratyc";
            this.AuxiliarSaratyc.Width = 125;
            // 
            // DGrestriccionAuxPreferido
            // 
            this.DGrestriccionAuxPreferido.HeaderText = "Auxiliar Preferido ";
            this.DGrestriccionAuxPreferido.MinimumWidth = 6;
            this.DGrestriccionAuxPreferido.Name = "DGrestriccionAuxPreferido";
            this.DGrestriccionAuxPreferido.Width = 125;
            // 
            // DGrestriccionAuxRechazado
            // 
            this.DGrestriccionAuxRechazado.HeaderText = "Auxiliar Rechazado";
            this.DGrestriccionAuxRechazado.MinimumWidth = 6;
            this.DGrestriccionAuxRechazado.Name = "DGrestriccionAuxRechazado";
            this.DGrestriccionAuxRechazado.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "idTurno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(594, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Turnos del día";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la fecha a revisar ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(353, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reasignar Turnos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.LightGray;
            this.regresar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regresar.Location = new System.Drawing.Point(387, 449);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(94, 29);
            this.regresar.TabIndex = 6;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Indicador
            // 
            this.Indicador.AutoSize = true;
            this.Indicador.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Indicador.Location = new System.Drawing.Point(9, 476);
            this.Indicador.Name = "Indicador";
            this.Indicador.Size = new System.Drawing.Size(0, 24);
            this.Indicador.TabIndex = 7;
            // 
            // ConsultarTurnos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(830, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Indicador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarTurnos";
            this.Text = "Consultar Turnos";
            this.Load += new System.EventHandler(this.AsignarTurno_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button regresar;
        private Label Indicador;
        private DataGridViewTextBoxColumn DGinstitucion;
        private DataGridViewTextBoxColumn DGtipoTurno;
        private DataGridViewTextBoxColumn DGfechaInicio;
        private DataGridViewTextBoxColumn DGfechaFin;
        private DataGridViewTextBoxColumn DGidPaciente;
        private DataGridViewTextBoxColumn AuxiliarEnferdata;
        private DataGridViewTextBoxColumn AuxiliarSaratyc;
        private DataGridViewTextBoxColumn DGrestriccionAuxPreferido;
        private DataGridViewTextBoxColumn DGrestriccionAuxRechazado;
        private DataGridViewTextBoxColumn Turno;
    }
}