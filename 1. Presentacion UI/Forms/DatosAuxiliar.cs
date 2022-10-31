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
using System.Xml.Linq;

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

            if (!identificacionAuxiliar.Equals(""))
            {
                //Se traen los datos de enferdata
                lAuxiliar = bAuxiliar.buscarAuxiliarEnferdata(identificacionAuxiliar);


                int registros = lAuxiliar.Count();
                if (!registros.Equals(0))
                {
                    Indicador.ForeColor = Color.Blue;
                    Indicador.Text = "Búsqueda Finalizada";
                }
                else
                {
                    Indicador.ForeColor = Color.Red;
                    Indicador.Text = "No se encontraron datos relacionados";
                }

                foreach (string auxiliar in lAuxiliar)
                {
                    var columns = auxiliar.Split(',').ToList();
                    //idEnferdata = obtenerIdEnferdata(columns[0].ToString());
                    idEnferdata = columns[0].ToString();
                    nombre = columns[1].ToString();
                    apellido = columns[2].ToString();
                    identificacion = columns[3].ToString();
                    fechaNacimiento = columns[4].ToString();
                    genero = columns[5].ToString();
                    ciudad = columns[6].ToString();
                    localidad = columns[7].ToString();
                    barrio = columns[8].ToString();
                    nacionalidad = columns[9].ToString();
                    disponibilidad = columns[10].ToString();

                    textNombre.Text = nombre.ToUpper();
                    textApellido.Text = apellido.ToUpper();
                    textFechaNacimiento.Text = fechaNacimiento.ToUpper();
                    textGenero.Text = genero.ToUpper();
                    textLocalidad.Text = localidad.ToUpper();
                    textBarrio.Text = barrio.ToUpper();
                    textNacionalidad.Text = nacionalidad.ToUpper();
                    textDisponibilidad.Text = disponibilidad.ToUpper();


                    List<string> listaTemas = new List<string> { "Colostomía", "Discapacidad visual", "Drenes", "Glucometría", "Medicación aplicación endovenosa", "Nefrostomia", "Oxigeno", "Sonda Gastrostomía", "Sonda Naso gástrica", "Sonda Orogástrica", "Sonda Vesical", "Traqueostomía", "Medicina Interna", "Quirúrgico", "Oncológico", "Psiquiátrico", "Madre recién nacido", "Neurológico", "Paciente acompañado de empleada", "Paciente acompañado de familiar", "Paciente sin compañía" };
                    //List<string> listaValoresPref = new List<string> { "1", "2", "3", "4", "5" };
                    poblarConocimiento();
                    poblarExperiencia();
                    //poblarPreferencias(listaValoresPref);
                }


            }
            else
            {
                Indicador.ForeColor = Color.Red;
                Indicador.Text = "No se diligencio cedula del auxiliar";
            }

            Indicador.Invalidate();
            Indicador.Refresh();

        }

        private string obtenerIdEnferdata(string cedula)
        {
            idEnferdata = bAuxiliar.obtenerIdEnferdata(cedula);
            return idEnferdata;
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

        private void poblarConocimiento()
        {
            dataGridView1.Rows.Add("Alerta/orientado", false);
            dataGridView1.Rows.Add("Catéter Periférico", false);
            dataGridView1.Rows.Add("Colostomía", false);
            dataGridView1.Rows.Add("Comatoso", false);
            dataGridView1.Rows.Add("Confusión/desorientado", false);
            dataGridView1.Rows.Add("Directo", false);
            dataGridView1.Rows.Add("Discapacidad auditiva", false);
            dataGridView1.Rows.Add("Discapacidad visual", false);
            dataGridView1.Rows.Add("Drenes", false);
            dataGridView1.Rows.Add("Estuporoso", false);
            dataGridView1.Rows.Add("Glucometría", false);
            dataGridView1.Rows.Add("Madre recién nacido", false);
            dataGridView1.Rows.Add("Medicación aplicación endovenosa", false);
            dataGridView1.Rows.Add("Medicina Interna", false);
            dataGridView1.Rows.Add("Nefrostomia", false);
            dataGridView1.Rows.Add("Neurológico", false);
            dataGridView1.Rows.Add("Oncológico ", false);
            dataGridView1.Rows.Add("Oxigeno", false);
            dataGridView1.Rows.Add("Paciente acompañado de empleada", false);
            dataGridView1.Rows.Add("Paciente acompañado de familiar", false);
            dataGridView1.Rows.Add("Paciente sin compañía", false);
            dataGridView1.Rows.Add("Psiquiátrico ", false);
            dataGridView1.Rows.Add("Quirúrgico ", false);
            dataGridView1.Rows.Add("Seguridad del paciente", false);
            dataGridView1.Rows.Add("Sonda Gastrostomía", false);
            dataGridView1.Rows.Add("Sonda Naso gástrica", false);
            dataGridView1.Rows.Add("Sonda Orogástrica", false);
            dataGridView1.Rows.Add("Sonda Vesical", false);
            dataGridView1.Rows.Add("Toma de signos vitales", false);
            dataGridView1.Rows.Add("Traqueostomía", false);
            dataGridView1.Rows.Add("Vegetativo", false);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void poblarExperiencia()   
        {

            dataGridView2.Rows.Add("Alerta/orientado", false);
            dataGridView2.Rows.Add("Catéter Periférico", false);
            dataGridView2.Rows.Add("Colostomía", false);
            dataGridView2.Rows.Add("Comatoso", false);
            dataGridView2.Rows.Add("Confusión/desorientado", false);
            dataGridView2.Rows.Add("Directo", false);
            dataGridView2.Rows.Add("Discapacidad auditiva", false);
            dataGridView2.Rows.Add("Discapacidad visual", false);
            dataGridView2.Rows.Add("Drenes", false);
            dataGridView2.Rows.Add("Estuporoso", false);
            dataGridView2.Rows.Add("Glucometría", false);
            dataGridView2.Rows.Add("Madre recién nacido", false);
            dataGridView2.Rows.Add("Medicación aplicación endovenosa", false);
            dataGridView2.Rows.Add("Medicina Interna", false);
            dataGridView2.Rows.Add("Nefrostomia", false);
            dataGridView2.Rows.Add("Neurológico", false);
            dataGridView2.Rows.Add("Oncológico ", false);
            dataGridView2.Rows.Add("Oxigeno", false);
            dataGridView2.Rows.Add("Paciente acompañado de empleada", false);
            dataGridView2.Rows.Add("Paciente acompañado de familiar", false);
            dataGridView2.Rows.Add("Paciente sin compañía", false);
            dataGridView2.Rows.Add("Psiquiátrico ", false);
            dataGridView2.Rows.Add("Quirúrgico ", false);
            dataGridView2.Rows.Add("Seguridad del paciente", false);
            dataGridView2.Rows.Add("Sonda Gastrostomía", false);
            dataGridView2.Rows.Add("Sonda Naso gástrica", false);
            dataGridView2.Rows.Add("Sonda Orogástrica", false);
            dataGridView2.Rows.Add("Sonda Vesical", false);
            dataGridView2.Rows.Add("Toma de signos vitales", false);
            dataGridView2.Rows.Add("Traqueostomía", false);
            dataGridView2.Rows.Add("Vegetativo", false);

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AllowUserToAddRows = false;
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
            disponibilidad = textDisponibilidad.Text.ToUpper();
            contextura = comboContextura.Text.ToUpper();
            personalidad = comboPersonalidad.Text.ToUpper();
            desplazamiento = comboDesplazamiento.Text.ToUpper();
            levantarObjetos = comboObjetos.Text.ToUpper();

            string ConocimientoC1="";
            string ConocimientoC2 = "";
            string ConocimientoC3 = "";
            string ConocimientoC4 = "";
            string ConocimientoC5 = "";
            string ConocimientoC6 = "";
            string ConocimientoC7 = "";
            string ConocimientoC8 = "";
            string ConocimientoC9 = "";
            string ConocimientoC10 = "";
            string ConocimientoC11 = "";
            string ConocimientoC12 = "";
            string ConocimientoC13 = "";
            string ConocimientoC14 = "";
            string ConocimientoD1 = "";
            string ConocimientoD2 = "";
            string ConocimientoD3 = "";
            string ConocimientoD4 = "";
            string ConocimientoD5 = "";
            string ConocimientoD6 = "";
            string ConocimientoA1 = "";
            string ConocimientoA2 = "";
            string ConocimientoA3 = "";
            string ConocimientoA4 = "";
            string ConocimientoA5 = "";
            string ConocimientoCC1 = "";
            string ConocimientoCC2 = "";
            string ConocimientoCC3 = "";
            string ConocimientoCC4 = "";
            string ConocimientoCC5 = "";

            string ExperienciaC1 = "";
            string ExperienciaC2 = "";
            string ExperienciaC3 = "";
            string ExperienciaC4 = "";
            string ExperienciaC5 = "";
            string ExperienciaC6 = "";
            string ExperienciaC7 = "";
            string ExperienciaC8 = "";
            string ExperienciaC9 = "";
            string ExperienciaC10 = "";
            string ExperienciaC11 = "";
            string ExperienciaC12 = "";
            string ExperienciaC13 = "";
            string ExperienciaC14 = "";
            string ExperienciaD1 = "";
            string ExperienciaD2 = "";
            string ExperienciaD3 = "";
            string ExperienciaD4 = "";
            string ExperienciaD5 = "";
            string ExperienciaD6 = "";
            string ExperienciaA1 = "";
            string ExperienciaA2 = "";
            string ExperienciaA3 = "";
            string ExperienciaA4 = "";
            string ExperienciaA5 = "";
            string ExperienciaCC1 = "";
            string ExperienciaCC2 = "";
            string ExperienciaCC3 = "";
            string ExperienciaCC4 = "";
            string ExperienciaCC5 = "";




            //Guarda la informacion de los conocimientos
            List<string> lConocimientos = new List<string>();
            int filasMostradas = dataGridView1.RowCount;
            bool seleccion = false;
            string temaSeleccionado = "";
            int currentRow = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                currentRow = row.Index;
                if (currentRow <= filasMostradas - 1)
                {
                    temaSeleccionado = row.Cells[0].Value.ToString();

                    if (!temaSeleccionado.Equals(null))
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Conocimiento"];
                        if (Convert.ToBoolean(cell.Value))
                        {
                            //esta seleccionada
                            seleccion = true;
                            lConocimientos.Add(temaSeleccionado + "," + seleccion);                            

                        }
                        else
                        {
                            //no esta seleccionada
                            seleccion = false;
                        }

                        if (temaSeleccionado.Trim().Equals("Catéter Periférico"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC1 = "SI";
                            }
                            else
                            {
                                ConocimientoC1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Colostomía"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC2 = "SI";
                            }
                            else
                            {
                                ConocimientoC2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Discapacidad auditiva"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC3 = "SI";
                            }
                            else
                            {
                                ConocimientoC3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Discapacidad visual"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC4 = "SI";
                            }
                            else
                            {
                                ConocimientoC4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Drenes"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC5 = "SI";
                            }
                            else
                            {
                                ConocimientoC5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Glucometría"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC6 = "SI";
                            }
                            else
                            {
                                ConocimientoC6 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Medicación aplicación endovenosa"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC7 = "SI";
                            }
                            else
                            {
                                ConocimientoC7 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Nefrostomia"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC8 = "SI";
                            }
                            else
                            {
                                ConocimientoC8 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Oxigeno"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC9 = "SI";
                            }
                            else
                            {
                                ConocimientoC9 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Gastrostomía"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC10 = "SI";
                            }
                            else
                            {
                                ConocimientoC10 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Naso gástrica"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC11 = "SI";
                            }
                            else
                            {
                                ConocimientoC11 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Orogástrica"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC12 = "SI";
                            }
                            else
                            {
                                ConocimientoC12 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Vesical"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC13 = "SI";
                            }
                            else
                            {
                                ConocimientoC13 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Traqueostomía"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoC14 = "SI";
                            }
                            else
                            {
                                ConocimientoC14 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Medicina Interna"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD1 = "SI";
                            }
                            else
                            {
                                ConocimientoD1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Quirúrgico"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD2 = "SI";
                            }
                            else
                            {
                                ConocimientoD2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Oncológico"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD3 = "SI";
                            }
                            else
                            {
                                ConocimientoD3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Psiquiátrico"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD4 = "SI";
                            }
                            else
                            {
                                ConocimientoD4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Madre recién nacido"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD5 = "SI";
                            }
                            else
                            {
                                ConocimientoD5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Neurológico"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoD6 = "SI";
                            }
                            else
                            {
                                ConocimientoD6 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Paciente acompañado de familiar"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoA1 = "SI";
                            }
                            else
                            {
                                ConocimientoA1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Paciente sin compañía"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoA2 = "SI";
                            }
                            else
                            {
                                ConocimientoA2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Paciente acompañado de empleada"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoA3 = "SI";
                            }
                            else
                            {
                                ConocimientoA3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Toma de signos vitales"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoA4 = "SI";
                            }
                            else
                            {
                                ConocimientoA4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Seguridad del paciente"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoA5 = "SI";
                            }
                            else
                            {
                                ConocimientoA5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Alerta/orientado"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoCC1 = "SI";
                            }
                            else
                            {
                                ConocimientoCC1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Comatoso"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoCC2 = "SI";
                            }
                            else
                            {
                                ConocimientoCC2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Confusión/desorientado"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoCC3 = "SI";
                            }
                            else
                            {
                                ConocimientoCC3 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Estuporoso"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoCC4 = "SI";
                            }
                            else
                            {
                                ConocimientoCC4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Vegetativo"))
                        {
                            if (seleccion == true)
                            {
                                ConocimientoCC5 = "SI";
                            }
                            else
                            {
                                ConocimientoCC5 = "NO";
                            }
                        }


                    }
                }

            }

            //Guarda la informacion de los experiencias
            List<string> lexperiencias = new List<string>();
            filasMostradas = dataGridView2.RowCount;
            seleccion = false;
            temaSeleccionado = "";
            currentRow = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                currentRow = row.Index;
                if (currentRow <= filasMostradas - 1)
                {
                    temaSeleccionado = row.Cells[0].Value.ToString();

                    if (!temaSeleccionado.Equals(null))
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["ExperienciaAux"];
                        if (Convert.ToBoolean(cell.Value))
                        {
                            //esta seleccionada
                            seleccion = true;
                            lexperiencias.Add(temaSeleccionado + "," + seleccion);

                        }
                        else
                        {
                            //no esta seleccionada
                            seleccion = false;
                        }

                        if (temaSeleccionado.Trim().Equals("Catéter Periférico"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC1 = "SI";
                            }
                            else
                            {
                                ExperienciaC1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Colostomía"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC2 = "SI";
                            }
                            else
                            {
                                ExperienciaC2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Discapacidad auditiva"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC3 = "SI";
                            }
                            else
                            {
                                ExperienciaC3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Discapacidad visual"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC4 = "SI";
                            }
                            else
                            {
                                ExperienciaC4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Drenes"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC5 = "SI";
                            }
                            else
                            {
                                ExperienciaC5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Glucometría"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC6 = "SI";
                            }
                            else
                            {
                                ExperienciaC6 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Medicación aplicación endovenosa"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC7 = "SI";
                            }
                            else
                            {
                                ExperienciaC7 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Nefrostomia"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC8 = "SI";
                            }
                            else
                            {
                                ExperienciaC8 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Oxigeno"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC9 = "SI";
                            }
                            else
                            {
                                ExperienciaC9 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Gastrostomía"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC10 = "SI";
                            }
                            else
                            {
                                ExperienciaC10 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Naso gástrica"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC11 = "SI";
                            }
                            else
                            {
                                ExperienciaC11 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Orogástrica"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC12 = "SI";
                            }
                            else
                            {
                                ExperienciaC12 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Sonda Vesical"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC13 = "SI";
                            }
                            else
                            {
                                ExperienciaC13 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Traqueostomía"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaC14 = "SI";
                            }
                            else
                            {
                                ExperienciaC14 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Medicina Interna"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD1 = "SI";
                            }
                            else
                            {
                                ExperienciaD1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Quirúrgico"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD2 = "SI";
                            }
                            else
                            {
                                ExperienciaD2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Oncológico"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD3 = "SI";
                            }
                            else
                            {
                                ExperienciaD3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Psiquiátrico"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD4 = "SI";
                            }
                            else
                            {
                                ExperienciaD4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Madre recién nacido"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD5 = "SI";
                            }
                            else
                            {
                                ExperienciaD5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Neurológico"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaD6 = "SI";
                            }
                            else
                            {
                                ExperienciaD6 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Paciente acompañado de familiar"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaA1 = "SI";
                            }
                            else
                            {
                                ExperienciaA1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Paciente sin compañía"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaA2 = "SI";
                            }
                            else
                            {
                                ExperienciaA2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Paciente acompañado de empleada"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaA3 = "SI";
                            }
                            else
                            {
                                ExperienciaA3 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Toma de signos vitales"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaA4 = "SI";
                            }
                            else
                            {
                                ExperienciaA4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Seguridad del paciente"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaA5 = "SI";
                            }
                            else
                            {
                                ExperienciaA5 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Alerta/orientado"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaCC1 = "SI";
                            }
                            else
                            {
                                ExperienciaCC1 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Comatoso"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaCC2 = "SI";
                            }
                            else
                            {
                                ExperienciaCC2 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Confusión/desorientado"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaCC3 = "SI";
                            }
                            else
                            {
                                ExperienciaCC3 = "NO";
                            }
                        }


                        else if (temaSeleccionado.Trim().Equals("Estuporoso"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaCC4 = "SI";
                            }
                            else
                            {
                                ExperienciaCC4 = "NO";
                            }
                        }

                        else if (temaSeleccionado.Trim().Equals("Vegetativo"))
                        {
                            if (seleccion == true)
                            {
                                ExperienciaCC5 = "SI";
                            }
                            else
                            {
                                ExperienciaCC5 = "NO";
                            }
                        }


                    }
                }

            }

            //Guarda la informacion de las preferencias

            string prefTipoDiurno = pTipoDiurno.Text;
            string prefTipoNocturno = pTipoNocturno.Text;

            string prefCompFam = pCompaniaFamiliar.Text;
            string prefCompEmp = pCompaniaEmpleada.Text;
            string prefCompSin = pCompaniaSin.Text;

            string prefEdadBinomio = pEdadBinomio.Text;
            string prefEdadNiños = pEdadNinos.Text;
            string prefEdadAdultos = pEdadAdultos.Text;

            string prefTipoDomicilio = pTipoDomicilio.Text;
            string prefTipoIPS = pTipoIPS.Text;
            string prefTipoClinica = pTipoClinica.Text;
            string prefTipoEmpresarial = pTipoEmpresarial.Text;

            string prefGeneroMasculino = pGeneroMasculino.Text;
            string prefGeneroFemenino = pGeneroFemenino.Text;

            string prefDiagMedicina = pDiagMedicina.Text;
            string prefDiagQuirurgico = pDiagQuirurgico.Text;
            string prefDiagOncologico = pDiagOncologico.Text;
            string prefDiagPsiquiatrico = pDiagPsiqui.Text;
            string prefDiagMadre = pDiagMadre.Text;
            string prefDiagNeuro = pDiagNeuro.Text;

            string prefConcAlerta = pConcAlerta.Text;
            string prefConcComa = pConcComa.Text;
            string prefConConfusion = pConcConfusion.Text;
            string prefConcEstuporoso = pConcEstuporoso.Text;
            string prefConcVegeta = pConcVegeta.Text;

            string prefMascostas = pMascotas.Text;

            string prefCondCateter = pCondCateter.Text;
            string prefCondColostomia = pCondColostomia.Text;
            string prefCondDisVisual = pCondDisVisual.Text;
            string prefCondDisAuditiva = pCondDisAuditiva.Text;
            string prefCondDrenes = pCondDrenes.Text;
            string prefCondGluco = pCondGluco.Text;
            string prefCondMedica = pCondMedica.Text;
            string prefCondNefro = pCondNefro.Text;
            string prefCondOxigeno = pCondOxigeno.Text;
            string prefCondSonGastro = pCondSonGastro.Text;
            string prefCondSonNaso = pCondSonNaso.Text;
            string prefCondSonOro = pCondSonOro.Text;
            string prefCondSonVesical = pCondSonVesical.Text;
            string prefCondSonTraqueo = pCondSonTraqueo.Text;


            string estado = "";
            if(contextura.Equals(""))
            {
                Indicador.Text = "Por favor ingrese la contextura";
            }
            else if(personalidad.Equals(""))
            {
                Indicador.Text = "Por favor ingrese la personalidad";
            }
            else if (desplazamiento.Equals(""))
            {
                Indicador.Text = "Por favor ingrese el desplazamiento";
            }
            else if (levantarObjetos.Equals(""))
            {
                Indicador.Text = "Por favor ingrese el levantamiento de objetos";
            }


            else if (prefTipoDiurno.Equals("") || prefTipoNocturno.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de tipo de turno";
            }
            else if (prefCompFam.Equals("") || prefCompFam.Equals("") || prefCompFam.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de acompañamiento";
            }
            else if (prefEdadBinomio.Equals("") || prefEdadNiños.Equals("") || prefEdadAdultos.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de edad";
            }
            else if (prefTipoDomicilio.Equals("") || prefTipoIPS.Equals("") || prefTipoClinica.Equals("") || prefTipoEmpresarial.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de tipo de servicio";
            }
            else if (prefDiagMedicina.Equals("") || prefDiagQuirurgico.Equals("") || prefDiagOncologico.Equals("") || prefDiagPsiquiatrico.Equals("") || prefDiagMadre.Equals("") || prefDiagNeuro.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de tipo de diagnóstico";
            }
            else if (prefConcAlerta.Equals("") || prefConcComa.Equals("") || prefConConfusion.Equals("") || prefConcEstuporoso.Equals("") || prefCondSonVesical.Equals("") || prefCondSonTraqueo.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de conciencia";
            }
            else if (prefMascostas.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de mascotas";
            }
            else if (prefCondCateter.Equals("") || prefCondColostomia.Equals("") || prefCondDisVisual.Equals("") || prefCondDisAuditiva.Equals("") || prefCondDrenes.Equals("") || prefCondGluco.Equals("") || prefCondMedica.Equals("") || prefCondNefro.Equals("") || prefCondOxigeno.Equals("") || prefCondSonGastro.Equals("") || prefCondSonNaso.Equals("") || prefCondSonOro.Equals("") || prefCondSonVesical.Equals("") || prefCondSonTraqueo.Equals(""))
            {
                Indicador.Text = "Por favor digite las preferencias de condición de salud";
            }
            else
            {
                estado = bAuxiliar.guardarDatosAuxiliar(idEnferdata, contextura, personalidad, desplazamiento, levantarObjetos, ConocimientoC1, ConocimientoC2, ConocimientoC3, ConocimientoC4, ConocimientoC5, ConocimientoC6, ConocimientoC7, ConocimientoC8, ConocimientoC9, ConocimientoC10, ConocimientoC11, ConocimientoC12, ConocimientoC13, ConocimientoC14, ConocimientoD1, ConocimientoD2, ConocimientoD3, ConocimientoD4, ConocimientoD5, ConocimientoD6, ConocimientoA1, ConocimientoA2, ConocimientoA3, ConocimientoA4, ConocimientoA5, ConocimientoCC1, ConocimientoCC2, ConocimientoCC3, ConocimientoCC4, ConocimientoCC5, ExperienciaC1, ExperienciaC2, ExperienciaC3, ExperienciaC4, ExperienciaC5, ExperienciaC6, ExperienciaC7, ExperienciaC8, ExperienciaC9, ExperienciaC10, ExperienciaC11, ExperienciaC12, ExperienciaC13, ExperienciaC14, ExperienciaD1, ExperienciaD2, ExperienciaD3, ExperienciaD4, ExperienciaD5, ExperienciaD6, ExperienciaA1, ExperienciaA2, ExperienciaA3, ExperienciaA4, ExperienciaA5, ExperienciaCC1, ExperienciaCC2, ExperienciaCC3, ExperienciaCC4, ExperienciaCC5, prefTipoDiurno, prefTipoNocturno, prefCompFam, prefCompEmp, prefCompSin, prefEdadBinomio, prefEdadAdultos, prefEdadNiños, prefTipoDomicilio, prefTipoClinica, prefTipoEmpresarial, prefTipoIPS, prefGeneroFemenino,prefGeneroMasculino, prefDiagMedicina, prefDiagQuirurgico, prefDiagOncologico, prefDiagPsiquiatrico, prefDiagMadre,  prefDiagNeuro, prefConcAlerta, prefConcComa, prefConConfusion, prefConcEstuporoso, prefConcVegeta, prefMascostas, prefCondCateter, prefCondColostomia, prefCondDisVisual, prefCondDisAuditiva, prefCondDrenes, prefCondGluco, prefCondMedica, prefCondNefro, prefCondOxigeno, prefCondSonGastro, prefCondSonNaso, prefCondSonOro, prefCondSonVesical, prefCondSonTraqueo);

                if (estado.Equals("OK"))
                {
                    Indicador.Text = "Se han guardado los datos correctamente";
                    Indicador.ForeColor = Color.Blue;

                    Guardar.Enabled = false;
                    Editar.Enabled = true;

                    //Se inhabilitan las opciones para ingresar datos
                    comboContextura.Enabled = false;
                    comboDesplazamiento.Enabled = false;
                    comboObjetos.Enabled = false;
                    comboPersonalidad.Enabled = false;
                    tabControl1.Enabled = false;
                    tabControl2.Enabled = false;


                }
                else
                {
                    MessageBox.Show(estado, "Error");
                    Indicador.Text = "Se produjo un error";
                    Indicador.ForeColor = Color.Red;
                }
            }


            Indicador.Update();
        }

        private void textContextura_TextChanged(object sender, EventArgs e)
        {

        }

        private void pTipoDiurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //Se habilitan las opciones para ingresar datos
            comboContextura.Enabled = true;
            comboDesplazamiento.Enabled = true;
            comboObjetos.Enabled = true;
            comboPersonalidad.Enabled = true;

            foreach (Control c in tabControl1.Controls)
            {
                c.Enabled = false;
            }

            foreach (Control m in tabControl2.Controls)
            {
                m.Enabled = false;
            }

            //tabControl1.Enabled = true;
            //tabControl2.Enabled = true;
        }
    }
}
