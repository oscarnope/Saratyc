using Saratyc._2._Negocio.BL;
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
    public partial class AsignarTurno : Form
    {
        public AsignarTurno(string institucion, string restriccionAuxPreferido, string restriccionAuxRechazado, string tipoTurno, string fechaInicio, string fechaFin, string idPaciente, string asignado, string? idAuxiliarSaratyc, string idTurno)
        {
            InitializeComponent();
            textInstitucion.Text = institucion;
            textAuxPreferido.Text = restriccionAuxPreferido;
            textTipoTurno.Text = tipoTurno;
            textFechaInicio.Text = fechaInicio;
            textFechaFin.Text = fechaFin;
            textIdAuxEnferdata.Text = asignado;
            textAuxRechazado.Text = restriccionAuxRechazado;
            textIdPaciente.Text = idPaciente;
            textIdTurno.Text = idTurno;
        }

        private void AsignarTurno_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            //this.tbl_alunosBindingSource.Filter = string.Format("Nome LIKE '{0}%'", Variables.RecordName);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se leen los valores
            string institucion = textInstitucion.Text;
            string tipoTurno = textTipoTurno.Text;
            string fechaInicio = textFechaInicio.Text;
            string fechaFin = textFechaFin.Text;

            
            int idPaciente = Int32.Parse(textIdPaciente.Text);
            int idAuxPreferido = 0;
            int idAuxRechazado = 0;
            int idTurno = Int32.Parse(textIdTurno.Text);

            //Se normalizan los posibles valores nulos
            if (!textAuxPreferido.Text.Equals(""))
            {
                idAuxPreferido = Int32.Parse(textAuxPreferido.Text);
            }

            if (!textAuxPreferido.Text.Equals(""))
            {
                idAuxRechazado = Int32.Parse(textAuxRechazado.Text);
            }

            int idauxAsignado = Int32.Parse(textIdAuxEnferdata.Text);

            this.Hide();
            //Se invoca el algoritmo que calcula la recomendacion de auxiliares, este se alimenta del archivo de phyton y a esos resultados les realiza procesamiento adicional
            BRecomendarAuxiliares bRecomendarAuxiliares = new BRecomendarAuxiliares(institucion,tipoTurno,fechaInicio,fechaFin,idPaciente,idauxAsignado,idAuxPreferido,idAuxRechazado);

            AuxiliaresRecomendados au = new AuxiliaresRecomendados(idPaciente, idTurno);
            au.Activate();
            au.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //VerTurnos vt = new VerTurnos();
            //vt.Activate();
            //vt.Show();
        }
    }
    
}
