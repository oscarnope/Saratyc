﻿using Saratyc._2._Negocio.BL;
using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class AuxiliaresRecomendados : Form
    {
        public AuxiliaresRecomendados(int idPaciente)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textPaciente.Text = idPaciente.ToString();

        }

        private void AsignarAuxiliar_Load(object sender, EventArgs e)
        {
            
            Utilidades utilidades = new Utilidades();
            List<string> lRecomendados = new List<string>();
            int idPacienteTrabajo = Int32.Parse(textPaciente.Text);


            string id = "";
            string idPaciente = "";
            string idAuxiliar1 = "";
            string idAuxiliar2 = "";
            string idAuxiliar3 = "";
            string idAuxiliar4 = ""; 
            string idAuxiliar5 = "";
            string idAuxiliar6 = "";
            string idAuxiliar7 = "";
            string idAuxiliar8 = "";
            string idAuxiliar9 = "";
            string idAuxiliar10 = "";

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewRow row2 = new DataGridViewRow();
            DataGridViewRow row3 = new DataGridViewRow();
            DataGridViewRow row4 = new DataGridViewRow();
            DataGridViewRow row5 = new DataGridViewRow();
            DataGridViewRow row6 = new DataGridViewRow();
            DataGridViewRow row7 = new DataGridViewRow();
            DataGridViewRow row8 = new DataGridViewRow();
            DataGridViewRow row9 = new DataGridViewRow();
            DataGridViewRow row10 = new DataGridViewRow();

            var recomendaciones = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Turnos.csv");

            foreach (var recomendacion in recomendaciones)
            {
                var columns = recomendacion.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                id = columns[0].ToString();
                idPaciente = columns[1].ToString();
                idAuxiliar1 = columns[2].ToString();
                idAuxiliar2 = columns[3].ToString();
                idAuxiliar3 = columns[5].ToString();
                idAuxiliar4 = columns[6].ToString();
                idAuxiliar5 = columns[7].ToString();
                idAuxiliar6 = columns[8].ToString();
                idAuxiliar7 = columns[9].ToString();
                idAuxiliar8 = columns[10].ToString();
                idAuxiliar9 = columns[11].ToString();
                idAuxiliar10 = columns[12].ToString();


                if (idPaciente.Equals(idPacienteTrabajo.ToString()))
                {
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = 1;
                    row.Cells[1].Value = idAuxiliar1;
                    dataGridView1.Rows.Add(row);

                    row2.CreateCells(dataGridView1);
                    row2.Cells[0].Value = 2;
                    row2.Cells[1].Value = idAuxiliar2;
                    dataGridView1.Rows.Add(row2);

                    row3.CreateCells(dataGridView1);
                    row3.Cells[0].Value = 3;
                    row3.Cells[1].Value = idAuxiliar3;
                    dataGridView1.Rows.Add(row3);

                    row4.CreateCells(dataGridView1);
                    row4.Cells[0].Value = 4;
                    row4.Cells[1].Value = idAuxiliar4;
                    dataGridView1.Rows.Add(row4);

                    row5.CreateCells(dataGridView1);
                    row5.Cells[0].Value = 5;
                    row5.Cells[1].Value = idAuxiliar5;
                    dataGridView1.Rows.Add(row5);

                    row6.CreateCells(dataGridView1);
                    row6.Cells[0].Value = 6;
                    row6.Cells[1].Value = idAuxiliar6;
                    dataGridView1.Rows.Add(row6);

                    row7.CreateCells(dataGridView1);
                    row7.Cells[0].Value = 7;
                    row7.Cells[1].Value = idAuxiliar7;
                    dataGridView1.Rows.Add(row7);

                    row8.CreateCells(dataGridView1);
                    row8.Cells[0].Value = 8;
                    row8.Cells[1].Value = idAuxiliar8;
                    dataGridView1.Rows.Add(row8);

                    row9.CreateCells(dataGridView1);
                    row9.Cells[0].Value = 9;
                    row9.Cells[1].Value = idAuxiliar9;
                    dataGridView1.Rows.Add(row9);

                    row10.CreateCells(dataGridView1);
                    row10.Cells[0].Value = 10;
                    row10.Cells[1].Value = idAuxiliar10;
                    dataGridView1.Rows.Add(row10);
                }
                


                
            }

            var Auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares.csv");

            foreach (var auxiliar in Auxiliares)
            {
                var columns = auxiliar.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                id = columns[0].ToString();
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {

            string idpaciente = textPaciente.Text;
            string idAuxiliar = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //this.Hide();
            AuxiliarRecomendado ar = new AuxiliarRecomendado(idpaciente, idAuxiliar);
            ar.Activate();
            ar.Show();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AsignarAuxiliar aa = new AsignarAuxiliar();
            //aa.Activate();
            //aa.Show();
        }
    }
}