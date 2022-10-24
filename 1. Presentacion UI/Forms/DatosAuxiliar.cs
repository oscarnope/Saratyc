using Saratyc._2._Negocio.BL;
using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class DatosAuxiliar : Form
    {
        string idEnferdata;
        string nombre ;
        string apellido;
        string identificacion ;
        string fechaNacimiento ;
        string genero ;
        string ciudad ;
        string localidad ;
        string barrio ;
        string nacionalidad ;
        string disponibilidad ;
        string personalidad ;
        string contextura;
        string desplazamiento;
        string levantarObjetos;

        BAuxiliar bAuxiliar = new BAuxiliar();
        List<string> lAuxiliar = new List<string>();

        public DatosAuxiliar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuxiliarEnfermeria_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Hide();
            MenuServicios ms = new MenuServicios();
            ms.Activate();
            ms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identificacionAuxiliar = textIdentificacion.Text;
            lAuxiliar=bAuxiliar.buscarAuxiliar(identificacionAuxiliar);

            foreach (string auxiliar in lAuxiliar)
            {
                var columns = auxiliar.Split(',').ToList();
                idEnferdata = columns[0].ToString();
                nombre = columns[1].ToString();
                apellido = columns[2].ToString();
                identificacion = columns[3].ToString();
                fechaNacimiento = columns[4].ToString();
                genero = columns[5].ToString();
                ciudad = columns[6].ToString();
                localidad = columns[7].ToString();
                barrio = columns[8].ToString();
                contextura = columns[9].ToString();
                nacionalidad = columns[10].ToString();                   
                disponibilidad = columns[11].ToString();
                personalidad = columns[12].ToString();
                desplazamiento = columns[13].ToString();
                levantarObjetos = columns[14].ToString();

                textNombre.Text = nombre.ToUpper();
                textApellido.Text = apellido.ToUpper();
                textFechaNacimiento.Text = fechaNacimiento.ToUpper(); 
                textGenero.Text = genero.ToUpper();
                textLocalidad.Text = localidad.ToUpper();
                textBarrio.Text = barrio.ToUpper(); 
                textNacionalidad.Text = nacionalidad.ToUpper();
                textContextura.Text = contextura.ToUpper();
                textDisponibilidad.Text = disponibilidad.ToUpper();
                textPersonalidad.Text = personalidad.ToUpper();
                textdesplazamiento.Text = desplazamiento.ToUpper();
                textLevantarObjetos.Text = levantarObjetos.ToUpper();

                List <string> listaTemas = new List<string> { "Colostomía", "Discapacidad visual", "Drenes", "Glucometría", "Medicación aplicación endovenosa", "Nefrostomia", "Oxigeno", "Sonda Gastrostomía", "Sonda Naso gástrica", "Sonda Orogástrica", "Sonda Vesical", "Traqueostomía", "Medicina Interna", "Quirúrgico", "Oncológico", "Psiquiátrico", "Madre recién nacido", "Neurológico", "Paciente acompañado de empleada", "Paciente acompañado de familiar", "Paciente sin compañía" };
                List<string> listaValoresPref = new List<string> { "1", "2", "3", "4", "5" };
                poblarConocimiento(listaTemas);
                poblarExperiencia(listaTemas);
                poblarPreferencias(listaValoresPref);

            }
        }

        private void poblarPreferencias(List<string> listaValoresPref)
        {
            pTipoDiurno.DataSource = listaValoresPref;
            pTipoNocturno.DataSource = listaValoresPref;

            pCompaniaFamiliar.DataSource = listaValoresPref;
            pCompaniaEmpleada.DataSource = listaValoresPref;
            pCompaniaSin.DataSource = listaValoresPref;

            pEdadBinomio.DataSource = listaValoresPref;
            pEdadAdultos.DataSource = listaValoresPref;
            pEdadNinos.DataSource = listaValoresPref;

            pTipoDomicilio.DataSource = listaValoresPref;
            pTipoClinica.DataSource = listaValoresPref;
            pTipoEmpresarial.DataSource = listaValoresPref;
            pTipoIPS.DataSource = listaValoresPref;

            pGeneroFemenino.DataSource = listaValoresPref;
            pGeneroMasculino.DataSource = listaValoresPref;

            pDiagMedicina.DataSource = listaValoresPref;
            pDiagMadre.DataSource = listaValoresPref;
            pDiagNeuro.DataSource = listaValoresPref;
            pDiagOncologico.DataSource = listaValoresPref;
            pDiagPsiqui.DataSource = listaValoresPref;
            pDiagQuirurgico.DataSource = listaValoresPref;

            pConcAlerta.DataSource = listaValoresPref;
            pConcComa.DataSource= listaValoresPref;
            pConcConfusion.DataSource = listaValoresPref;
            pConcEstuporoso.DataSource = listaValoresPref; 
            pConcVegeta.DataSource = listaValoresPref;
            
            pMascotas.DataSource = listaValoresPref;

            pCondColostomia.DataSource = listaValoresPref;
            pCondDisVisual.DataSource = listaValoresPref;
            pCondDrenes.DataSource = listaValoresPref;
            pCondGluco.DataSource = listaValoresPref;
            pCondMedica.DataSource = listaValoresPref;
            pCondNefro.DataSource = listaValoresPref;
            pCondOxigeno.DataSource = listaValoresPref;
            pCondSonGastro.DataSource = listaValoresPref;
            pCondSonNaso.DataSource = listaValoresPref;
            pCondSonOro.DataSource = listaValoresPref;
            pCondSonTraqueo.DataSource = listaValoresPref; 
            pCondSonVesical.DataSource = listaValoresPref;

            priAcompaña.DataSource = listaValoresPref;
            priCondicion.DataSource = listaValoresPref;
            priDiagnostico.DataSource = listaValoresPref;
            priEdad.DataSource = listaValoresPref;
            priGenero.DataSource = listaValoresPref;
            priTipoServicio.DataSource = listaValoresPref;
            priTipoTurno.DataSource = listaValoresPref;


        }

        private void poblarConocimiento(List<string> listaTemas)
        {
            (dataGridView1.Columns[0] as DataGridViewComboBoxColumn).DataSource = listaTemas;
        }

        private void poblarExperiencia(List<string> listaTemas)   
        {

           (dataGridView2.Columns[0] as DataGridViewComboBoxColumn).DataSource = listaTemas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombre = textNombre.Text.ToUpper();
            apellido = textApellido.Text.ToUpper();
            fechaNacimiento = textFechaNacimiento.Text.ToUpper();
            genero= textGenero.Text.ToUpper();
            localidad = textLocalidad.Text.ToUpper();
            barrio = textBarrio.Text.ToUpper();
            nacionalidad=textNacionalidad.Text.ToUpper();
            contextura = textContextura.Text.ToUpper();
            disponibilidad = textDisponibilidad.Text.ToUpper();
            personalidad = textPersonalidad.Text.ToUpper();
            desplazamiento = textdesplazamiento.Text.ToUpper();
            levantarObjetos = textLevantarObjetos.Text.ToUpper();
        }
    }
}
