namespace Saratyc._1._Presentacion_UI.Forms
{
    partial class VerTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGinstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGrestriccionAuxPreferido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGrestriccionAuxRechazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGtipoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGfechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGfechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGidPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGasignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(129, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 325);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "VER TURNOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGinstitucion,
            this.DGrestriccionAuxPreferido,
            this.DGrestriccionAuxRechazado,
            this.DGtipoTurno,
            this.DGfechaInicio,
            this.DGfechaFin,
            this.DGidPaciente,
            this.DGasignado});
            this.dataGridView1.Location = new System.Drawing.Point(7, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(628, 165);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DGinstitucion
            // 
            this.DGinstitucion.HeaderText = "Institucion ";
            this.DGinstitucion.MinimumWidth = 6;
            this.DGinstitucion.Name = "DGinstitucion";
            this.DGinstitucion.Width = 125;
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
            // DGtipoTurno
            // 
            this.DGtipoTurno.HeaderText = "Tipo Turno";
            this.DGtipoTurno.MinimumWidth = 6;
            this.DGtipoTurno.Name = "DGtipoTurno";
            this.DGtipoTurno.Width = 125;
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
            // DGasignado
            // 
            this.DGasignado.HeaderText = "Asignado";
            this.DGasignado.MinimumWidth = 6;
            this.DGasignado.Name = "DGasignado";
            this.DGasignado.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Revisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la fecha a revisar ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ver turnos sin asignar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ver turnos asignados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ver todos los turnos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(382, 449);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(94, 29);
            this.regresar.TabIndex = 6;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // VerTurnos
            // 
            this.ClientSize = new System.Drawing.Size(830, 490);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VerTurnos";
            this.Load += new System.EventHandler(this.AsignarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGinstitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGrestriccionAuxPreferido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGrestriccionAuxRechazado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGtipoTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGfechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGfechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGidPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGasignado;
        private System.Windows.Forms.Button regresar;
    }
}