using Saratyc._2._Negocio.BL;
using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saratyc._1._Presentacion_UI.Forms
{
    public partial class AuxiliarRecomendado : Form
    {
        public AuxiliarRecomendado(string idPaciente, string idAuxiliar, string nombres, string apellidos, string porcentajeCompatibilidad, string idTurno, string tipoTurno)
        {
            InitializeComponent();
            this.idPaciente.Text = idPaciente;
            this.idAuxiliar.Text = idAuxiliar;
            this.idTurno.Text = idTurno;
            textNombre.Text = nombres;
            textApellidos.Text = apellidos;
            textPorcentajeCompatibilidad.Text = "El porcentaje de compatibilidad del auxiliar es: " + porcentajeCompatibilidad +"%";
            textPrefTurnoA.Text = ToUpperFirstChar(tipoTurno);
        }

        private string ToUpperFirstChar(string tipoTurno)
        {
            if (string.IsNullOrEmpty(tipoTurno))
                return tipoTurno;

            return char.ToUpper(tipoTurno[0]) + tipoTurno.Substring(1).ToLowerInvariant();
        }

        private void AuxiliarRecomendado_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.AutoScroll = true;

            Utilidades utilidades = new Utilidades();
            int idPaciente = int.Parse(this.idPaciente.Text);
            int idAuxiliar = int.Parse(this.idAuxiliar.Text);
            int idTurno = int.Parse(this.idTurno.Text);

            string rutaActual = AppDomain.CurrentDomain.BaseDirectory;
            string carpetaOrigen = ConfigurationManager.AppSettings["rutaOrigen"];
            string ruta;

            string IDPACIENTE = "";
            string NOMBREPACIENTE = "";
            string APELLIDOPACIENTE = "";
            string CEDULAPACIENTE = "";
            string FECHANACIMIENTOPACIENTE = "";
            string GENEROPACIENTE = "";
            string LOCALIDADPACIENTE = "";
            string BARRIOPACIENTE = "";
            string NIVELCONCIENCIA = "";
            string NIVELAUTONOMIA = "";
            string CONDICIONSALUD = "";
            string CONTEXTURAFISICA = "";
            string TEMPERAMENTO = "";
            string GRUPODIAGNOSTICO = "";
            string PERSONAACOMPANA = "";
            string PREFERENCIAGENERO = "";
            string PREFERENCIAEDAD = "";
            string PREFERENCIANACIONALIDAD = "";
            string PREFERENCIAPERSONALIDAD = "";
            string PREFERENCIAIDIOMA = "";
            string PREFERENCIAMASCOTAS = "";

            //Variable usada para detectar si ya se encontro el paciente
            int pacienteEncontrado = 0;

            ruta = rutaActual + carpetaOrigen + "\\Pacientes.csv";

            //var pacientes = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Pacientes.csv");
            var pacientes = File.ReadAllLines(ruta);

            foreach (var paciente in pacientes)
            {

                if (pacienteEncontrado.Equals(0))
                {
                    var columns = paciente.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                    IDPACIENTE = columns[0].ToString();
                    NOMBREPACIENTE = columns[1].ToString();
                    APELLIDOPACIENTE = columns[2].ToString();
                    CEDULAPACIENTE = columns[3].ToString();
                    FECHANACIMIENTOPACIENTE = columns[4].ToString();
                    GENEROPACIENTE = columns[5].ToString();
                    LOCALIDADPACIENTE = columns[6].ToString();
                    BARRIOPACIENTE = columns[7].ToString();
                    NIVELCONCIENCIA = columns[8].ToString();
                    NIVELAUTONOMIA = columns[9].ToString();
                    CONDICIONSALUD = columns[10].ToString();
                    CONTEXTURAFISICA = columns[11].ToString();
                    TEMPERAMENTO = columns[12].ToString();
                    GRUPODIAGNOSTICO = columns[13].ToString();
                    PERSONAACOMPANA = columns[14].ToString();
                    PREFERENCIAGENERO = columns[15].ToString();
                    PREFERENCIAEDAD = columns[16].ToString();
                    PREFERENCIANACIONALIDAD = columns[17].ToString();
                    PREFERENCIAPERSONALIDAD = columns[18].ToString();
                    PREFERENCIAIDIOMA = columns[19].ToString();
                    PREFERENCIAMASCOTAS = columns[20].ToString();

                    if (IDPACIENTE.Equals(idPaciente.ToString()))
                    {
                        textNombre.Text = NOMBREPACIENTE;
                        textApellidos.Text = APELLIDOPACIENTE;
                        textIdentificacion.Text = CEDULAPACIENTE;

                        textCondicionSalud.Text = CONDICIONSALUD;
                        textDiagnostico.Text = GRUPODIAGNOSTICO;
                        textNivelConciencia.Text = NIVELCONCIENCIA;
                        textTipoCompañia.Text = PERSONAACOMPANA;
                        //textNivelDependencia.Text = NIVELAUTONOMIA;

                        textPrefEdadP.Text = PREFERENCIAEDAD;
                        textPrefNacionalidadP.Text = PREFERENCIANACIONALIDAD;
                        textPrefNPersonalidadP.Text = PREFERENCIAPERSONALIDAD;
                        textPrefNGeneroP.Text = PREFERENCIAGENERO;
                        textPrefIdiomaP.Text = PREFERENCIAIDIOMA;
                        textPrefMascotasP.Text = PREFERENCIAMASCOTAS;

                        textPrefCompA.Text = PERSONAACOMPANA;
                        textPrefEdadA.Text = CalcularEdad(FECHANACIMIENTOPACIENTE,1);
                        textPrefGeneroA.Text = GENEROPACIENTE;
                        textPrefDiagA.Text = GRUPODIAGNOSTICO;
                        textPrefCondA.Text = CONDICIONSALUD;

                        //Como ya se encontro el paciente la variable se vuelve 1
                        pacienteEncontrado = 1;



                    }

                }
            }
            string IDAUX = "";
            string NOMBREAUX = "";
            string APELLIDOAUX = "";
            string CEDULAPAUX = "";
            string FECHANACIMIENTOAUX = "";
            string GENEROPAUX = "";
            string CONDICION1 = "";
            string CONOCIMIENTOC1 = "";
            string EXPERIENCIAC1 = "";
            string CONDICION2 = "";
            string CONOCIMIENTOC2 = "";
            string EXPERIENCIAC2 = "";
            string CONDICION3 = "";
            string CONOCIMIENTOC3 = "";
            string EXPERIENCIAC3 = "";
            string CONDICION4 = "";
            string CONOCIMIENTOC4 = "";
            string EXPERIENCIAC4 = "";
            string CONDICION5 = "";
            string CONOCIMIENTOC5 = "";
            string EXPERIENCIAC5 = "";
            string DIAGNOSTICO1 = "";
            string CONOCIMIENTOD1 = "";
            string EXPERIENCIAD1 = "";
            string DIAGNOSTICO2 = "";
            string CONOCIMIENTOD2 = "";
            string EXPERIENCIAD2 = "";
            string DIAGNOSTICO3 = "";
            string CONOCIMIENTOD3 = "";
            string EXPERIENCIAD3 = "";
            string DIAGNOSTICO4 = "";
            string CONOCIMIENTOD4 = "";
            string EXPERIENCIAD4 = "";
            string DIAGNOSTICO5 = "";
            string CONOCIMIENTOD5 = "";
            string EXPERIENCIAD5 = "";
            string DIAGNOSTICO6 = "";
            string CONOCIMIENTOD6 = "";
            string EXPERIENCIAD6 = "";
            string ACOMPAÑAMIENTO1 = "";
            string CONOCIMIENTOA1 = "";
            string EXPERIENCIAA1 = "";
            string ACOMPAÑAMIENTO2 = "";
            string CONOCIMIENTOA2 = "";
            string EXPERIENCIAA2 = "";
            string ACOMPAÑAMIENTO3 = "";
            string CONOCIMIENTOA3 = "";
            string EXPERIENCIAA3 = "";
            string ACOMPAÑAMIENTO4 = "";
            string CONOCIMIENTOA4 = "";
            string EXPERIENCIAA4 = "";
            string ACOMPAÑAMIENTO5 = "";
            string CONOCIMIENTOA5 = "";
            string EXPERIENCIAA5 = "";
            string LOCALIDAD = "";
            string BARRIO = "";
            string RESTRICCION_DESPLAZAMIENTO = "";
            string RESTRICCION_OBJETOS = "";
            string CONTEXTURA_FISICA = "";
            string NACIONALIDAD = "";
            string DISPONIBILIDAD = "";
            string PERSONALIDAD = "";
            string PREFERENCIA_TURNO1 = "";
            string NIVEL_PREFERENCIA1 = "";
            string PREFERENCIA_TURNO2 = "";
            string NIVEL_PREFERENCIA2 = "";
            string PREFERENCIA_COMPAÑIA1 = "";
            string NIVEL_PREFERENCIA_COMPAÑIA1 = "";
            string PREFERENCIA_COMPAÑIA2 = "";
            string NIVEL_PREFERENCIA_COMPAÑIA2 = "";
            string PREFERENCIA_COMPAÑIA3 = "";
            string NIVEL_PREFERENCIA_COMPAÑIA3 = "";
            string PREFERENCIA_GENERO1 = "";
            string NIVEL_PREFERENCIA_GENERO1 = "";
            string PREFERENCIA_GENERO2 = "";
            string NIVEL_PREFERENCIA_GENERO2 = "";
            string PREFERENCIA_TIPO_SERVICIO1 = "";
            string NIVEL_PREFERENCIA_TIPO_SERVICIO1 = "";
            string PREFERENCIA_TIPO_SERVICIO2 = "";
            string NIVEL_PREFERENCIA_TIPO_SERVICIO2 = "";
            string PREFERENCIA_TIPO_SERVICIO3 = "";
            string NIVEL_PREFERENCIA_TIPO_SERVICIO3 = "";
            string PREFERENCIA_TIPO_SERVICIO4 = "";
            string NIVEL_PREFERENCIA_TIPO_SERVICIO4 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO1 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO1 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO2 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO2 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO3 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO3 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO4 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO4 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO5 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO5 = "";
            string PREFERENCIA_GRUPO_DIAGNOSTICO6 = "";
            string NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO6 = "";
            string PREFERENCIA_CONDICION_SALUD1 = "";
            string NIVEL_PREFERENCIA_CONDICION1 = "";
            string PREFERENCIA_CONDICION_SALUD2 = "";
            string NIVEL_PREFERENCIA_CONDICION2 = "";
            string PREFERENCIA_CONDICION_SALUD3 = "";
            string NIVEL_PREFERENCIA_CONDICION3 = "";
            string PREFERENCIA_CONDICION_SALUD4 = "";
            string NIVEL_PREFERENCIA_CONDICION4 = "";
            string PREFERENCIA_CONDICION_SALUD5 = "";
            string NIVEL_PREFERENCIA_CONDICION5 = "";
            string GUSTOS_PRESENCIA_MASCOTAS = "";
            string INTERES_CAPACITACION1 = "";
            string NIVEL_INTERES1 = "";
            string INTERES_CAPACITACION2 = "";
            string NIVEL_INTERES2 = "";
            string INTERES_CAPACITACION3 = "";
            string NIVEL_INTERES3 = "";
            string INTERES_CAPACITACION4 = "";
            string NIVEL_INTERES4 = "";
            string INTERES_CAPACITACION5 = "";
            string NIVEL_INTERES5 = "";
            string INTERES_CAPACITACION6 = "";
            string NIVEL_INTERES6 = "";
            string INTERES_CAPACITACION7 = "";
            string NIVEL_INTERES7 = "";
            string INTERES_CAPACITACION8 = "";
            string NIVEL_INTERES8 = "";
            string INTERES_CAPACITACION9 = "";
            string NIVEL_INTERES9 = "";
            string INTERES_CAPACITACION10 = "";
            string NIVEL_INTERES10 = "";
            string INTERES_CAPACITACION11 = "";
            string NIVEL_INTERES11 = "";
            string INTERES_CAPACITACION12 = "";
            string NIVEL_INTERES12 = "";
            string INTERES_CAPACITACION13 = "";
            string NIVEL_INTERES13 = "";
            string INTERES_CAPACITACION14 = "";
            string NIVEL_INTERES14 = "";
            string INTERES_CAPACITACION15 = "";
            string NIVEL_INTERES15 = "";
            string INTERES_CAPACITACION16 = "";
            string NIVEL_INTERES16 = "";
            string INTERES_CAPACITACION17 = "";
            string NIVEL_INTERES17 = "";
            string INTERES_CAPACITACION18 = "";
            string NIVEL_INTERES18 = "";
            string INTERES_CAPACITACION19 = "";
            string NIVEL_INTERES19 = "";
            string INTERES_CAPACITACION20 = "";
            string NIVEL_INTERES20 = "";
            string INTERES_CAPACITACION21 = "";
            string NIVEL_INTERES21 = "";
            string PRIORIDAD_PREFERENCIA_TURNO = "";
            string PRIORIDAD_PREFERENCIA_ACOMPAÑA = "";
            string PRIORIDAD_PREFERENCIA_EDAD = "";
            string PRIORIDAD_PREFERENCIA_SERVICIO = "";
            string CONDICION6 = "";
            string CONOCIMIENTOC6 = "";
            string EXPERIENCIAC6 = "";
            string CONDICION7 = "";
            string CONOCIMIENTOC7 = "";
            string EXPERIENCIAC7 = "";
            string CONDICION8 = "";
            string CONOCIMIENTOC8 = "";
            string EXPERIENCIAC8 = "";
            string CONDICION9 = "";
            string CONOCIMIENTOC9 = "";
            string EXPERIENCIAC9 = "";
            string CONDICION10 = "";
            string CONOCIMIENTOC10 = "";
            string EXPERIENCIAC10 = "";
            string CONDICION11 = "";
            string CONOCIMIENTOC11 = "";
            string EXPERIENCIAC11 = "";
            string CONDICION12 = "";
            string CONOCIMIENTOC12 = "";
            string EXPERIENCIAC12 = "";
            string CONDICION13 = "";
            string CONOCIMIENTOC13 = "";
            string EXPERIENCIAC13 = "";
            string CONDICION14 = "";
            string CONOCIMIENTOC14 = "";
            string EXPERIENCIAC14 = "";
            string CONCIENCIA1 = "";
            string CONOCIMIENTOCC1 = "";
            string EXPERIENCIACC1 = "";
            string CONCIENCIA2 = "";
            string CONOCIMIENTOCC2 = "";
            string EXPERIENCIACC2 = "";
            string CONCIENCIA3 = "";
            string CONOCIMIENTOCC3 = "";
            string EXPERIENCIACC3 = "";
            string CONCIENCIA4 = "";
            string CONOCIMIENTOCC4 = "";
            string EXPERIENCIACC4 = "";
            string CONCIENCIA5 = "";
            string CONOCIMIENTOCC5 = "";
            string EXPERIENCIACC5 = "";
            string PRIORIDAD_PREFERENCIA_GENERO = "";
            string PRIORIDAD_PREFERENCIA_DIAGNOSTICO = "";
            string PRIORIDAD_PREFERENCIA_CONDICION = "";


            int auxiliarEncontrado=0;
            ruta = rutaActual + carpetaOrigen + "\\Auxiliares.csv";

            //var auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares.csv");
            var auxiliares = File.ReadAllLines(ruta);

            foreach (var auxiliar in auxiliares)
            {
                if (auxiliarEncontrado.Equals(0))
                {
                    var columns = auxiliar.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                    IDAUX = columns[0].ToString();
                    NOMBREAUX = columns[1].ToString();
                    APELLIDOAUX = columns[2].ToString();
                    CEDULAPAUX = columns[3].ToString();
                    FECHANACIMIENTOAUX = columns[4].ToString();
                    GENEROPAUX = columns[5].ToString();
                    CONDICION1 = columns[6].ToString();
                    CONOCIMIENTOC1 = columns[7].ToString();
                    EXPERIENCIAC1 = columns[8].ToString();
                    CONDICION2 = columns[9].ToString();
                    CONOCIMIENTOC2 = columns[10].ToString();
                    EXPERIENCIAC2 = columns[11].ToString();
                    CONDICION3 = columns[12].ToString();
                    CONOCIMIENTOC3 = columns[13].ToString();
                    EXPERIENCIAC3 = columns[14].ToString();
                    CONDICION4 = columns[15].ToString();
                    CONOCIMIENTOC4 = columns[16].ToString();
                    EXPERIENCIAC4 = columns[17].ToString();
                    CONDICION5 = columns[18].ToString();
                    CONOCIMIENTOC5 = columns[19].ToString();
                    EXPERIENCIAC5 = columns[20].ToString();
                    DIAGNOSTICO1 = columns[21].ToString();
                    CONOCIMIENTOD1 = columns[22].ToString();
                    EXPERIENCIAD1 = columns[23].ToString();
                    DIAGNOSTICO2 = columns[24].ToString();
                    CONOCIMIENTOD2 = columns[25].ToString();
                    EXPERIENCIAD2 = columns[26].ToString();
                    DIAGNOSTICO3 = columns[27].ToString();
                    CONOCIMIENTOD3 = columns[28].ToString();
                    EXPERIENCIAD3 = columns[29].ToString();
                    DIAGNOSTICO4 = columns[30].ToString();
                    CONOCIMIENTOD4 = columns[31].ToString();
                    EXPERIENCIAD4 = columns[32].ToString();
                    DIAGNOSTICO5 = columns[33].ToString();
                    CONOCIMIENTOD5 = columns[34].ToString();
                    EXPERIENCIAD5 = columns[35].ToString();
                    DIAGNOSTICO6 = columns[36].ToString();
                    CONOCIMIENTOD6 = columns[37].ToString();
                    EXPERIENCIAD6 = columns[38].ToString();
                    ACOMPAÑAMIENTO1 = columns[39].ToString();
                    CONOCIMIENTOA1 = columns[40].ToString();
                    EXPERIENCIAA1 = columns[41].ToString();
                    ACOMPAÑAMIENTO2 = columns[42].ToString();
                    CONOCIMIENTOA2 = columns[43].ToString();
                    EXPERIENCIAA2 = columns[44].ToString();
                    ACOMPAÑAMIENTO3 = columns[45].ToString();
                    CONOCIMIENTOA3 = columns[46].ToString();
                    EXPERIENCIAA3 = columns[47].ToString();
                    ACOMPAÑAMIENTO4 = columns[48].ToString();
                    CONOCIMIENTOA4 = columns[49].ToString();
                    EXPERIENCIAA4 = columns[50].ToString();
                    ACOMPAÑAMIENTO5 = columns[51].ToString();
                    CONOCIMIENTOA5 = columns[52].ToString();
                    EXPERIENCIAA5 = columns[53].ToString();
                    LOCALIDAD = columns[54].ToString();
                    BARRIO = columns[55].ToString();
                    RESTRICCION_DESPLAZAMIENTO = columns[56].ToString();
                    RESTRICCION_OBJETOS = columns[57].ToString();
                    CONTEXTURA_FISICA = columns[58].ToString();
                    NACIONALIDAD = columns[59].ToString();
                    DISPONIBILIDAD = columns[60].ToString();
                    PERSONALIDAD = columns[61].ToString();
                    PREFERENCIA_TURNO1 = columns[62].ToString();
                    NIVEL_PREFERENCIA1 = columns[63].ToString();
                    PREFERENCIA_TURNO2 = columns[64].ToString();
                    NIVEL_PREFERENCIA2 = columns[65].ToString();
                    PREFERENCIA_COMPAÑIA1 = columns[66].ToString();
                    NIVEL_PREFERENCIA_COMPAÑIA1 = columns[67].ToString();
                    PREFERENCIA_COMPAÑIA2 = columns[68].ToString();
                    NIVEL_PREFERENCIA_COMPAÑIA2 = columns[69].ToString();
                    PREFERENCIA_COMPAÑIA3 = columns[70].ToString();
                    NIVEL_PREFERENCIA_COMPAÑIA3 = columns[71].ToString();
                    PREFERENCIA_GENERO1 = columns[72].ToString();
                    NIVEL_PREFERENCIA_GENERO1 = columns[73].ToString();
                    PREFERENCIA_GENERO2 = columns[74].ToString();
                    NIVEL_PREFERENCIA_GENERO2 = columns[75].ToString();
                    PREFERENCIA_TIPO_SERVICIO1 = columns[76].ToString();
                    NIVEL_PREFERENCIA_TIPO_SERVICIO1 = columns[77].ToString();
                    PREFERENCIA_TIPO_SERVICIO2 = columns[78].ToString();
                    NIVEL_PREFERENCIA_TIPO_SERVICIO2 = columns[79].ToString();
                    PREFERENCIA_TIPO_SERVICIO3 = columns[80].ToString();
                    NIVEL_PREFERENCIA_TIPO_SERVICIO3 = columns[81].ToString();
                    PREFERENCIA_TIPO_SERVICIO4 = columns[82].ToString();
                    NIVEL_PREFERENCIA_TIPO_SERVICIO4 = columns[83].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO1 = columns[84].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO1 = columns[85].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO2 = columns[86].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO2 = columns[87].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO3 = columns[88].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO3 = columns[89].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO4 = columns[90].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO4 = columns[91].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO5 = columns[92].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO5 = columns[93].ToString();
                    PREFERENCIA_GRUPO_DIAGNOSTICO6 = columns[94].ToString();
                    NIVEL_PREFERENCIA_GRUPO_DIAGNOSTICO6 = columns[95].ToString();
                    PREFERENCIA_CONDICION_SALUD1 = columns[96].ToString();
                    NIVEL_PREFERENCIA_CONDICION1 = columns[97].ToString();
                    PREFERENCIA_CONDICION_SALUD2 = columns[98].ToString();
                    NIVEL_PREFERENCIA_CONDICION2 = columns[99].ToString();
                    PREFERENCIA_CONDICION_SALUD3 = columns[100].ToString();
                    NIVEL_PREFERENCIA_CONDICION3 = columns[101].ToString();
                    PREFERENCIA_CONDICION_SALUD4 = columns[102].ToString();
                    NIVEL_PREFERENCIA_CONDICION4 = columns[103].ToString();
                    PREFERENCIA_CONDICION_SALUD5 = columns[104].ToString();
                    NIVEL_PREFERENCIA_CONDICION5 = columns[105].ToString();
                    GUSTOS_PRESENCIA_MASCOTAS = columns[106].ToString();
                    INTERES_CAPACITACION1 = columns[107].ToString();
                    NIVEL_INTERES1 = columns[108].ToString();
                    INTERES_CAPACITACION2 = columns[109].ToString();
                    NIVEL_INTERES2 = columns[110].ToString();
                    INTERES_CAPACITACION3 = columns[111].ToString();
                    NIVEL_INTERES3 = columns[112].ToString();
                    INTERES_CAPACITACION4 = columns[113].ToString();
                    NIVEL_INTERES4 = columns[114].ToString();
                    INTERES_CAPACITACION5 = columns[115].ToString();
                    NIVEL_INTERES5 = columns[116].ToString();
                    INTERES_CAPACITACION6 = columns[117].ToString();
                    NIVEL_INTERES6 = columns[118].ToString();
                    INTERES_CAPACITACION7 = columns[119].ToString();
                    NIVEL_INTERES7 = columns[120].ToString();
                    INTERES_CAPACITACION8 = columns[121].ToString();
                    NIVEL_INTERES8 = columns[122].ToString();
                    INTERES_CAPACITACION9 = columns[123].ToString();
                    NIVEL_INTERES9 = columns[124].ToString();
                    INTERES_CAPACITACION10 = columns[125].ToString();
                    NIVEL_INTERES10 = columns[126].ToString();
                    INTERES_CAPACITACION11 = columns[127].ToString();
                    NIVEL_INTERES11 = columns[128].ToString();
                    INTERES_CAPACITACION12 = columns[129].ToString();
                    NIVEL_INTERES12 = columns[130].ToString();
                    INTERES_CAPACITACION13 = columns[131].ToString();
                    NIVEL_INTERES13 = columns[132].ToString();
                    INTERES_CAPACITACION14 = columns[133].ToString();
                    NIVEL_INTERES14 = columns[134].ToString();
                    INTERES_CAPACITACION15 = columns[135].ToString();
                    NIVEL_INTERES15 = columns[136].ToString();
                    INTERES_CAPACITACION16 = columns[137].ToString();
                    NIVEL_INTERES16 = columns[138].ToString();
                    INTERES_CAPACITACION17 = columns[139].ToString();
                    NIVEL_INTERES17 = columns[140].ToString();
                    INTERES_CAPACITACION18 = columns[141].ToString();
                    NIVEL_INTERES18 = columns[142].ToString();
                    INTERES_CAPACITACION19 = columns[143].ToString();
                    NIVEL_INTERES19 = columns[144].ToString();
                    INTERES_CAPACITACION20 = columns[145].ToString();
                    NIVEL_INTERES20 = columns[146].ToString();
                    INTERES_CAPACITACION21 = columns[147].ToString();
                    NIVEL_INTERES21 = columns[148].ToString();
                    PRIORIDAD_PREFERENCIA_TURNO = columns[149].ToString();
                    PRIORIDAD_PREFERENCIA_ACOMPAÑA = columns[150].ToString();
                    PRIORIDAD_PREFERENCIA_EDAD = columns[151].ToString();
                    PRIORIDAD_PREFERENCIA_SERVICIO = columns[152].ToString();
                    CONDICION6 = columns[153].ToString();
                    CONOCIMIENTOC6 = columns[154].ToString();
                    EXPERIENCIAC6 = columns[155].ToString();
                    CONDICION7 = columns[156].ToString();
                    CONOCIMIENTOC7 = columns[157].ToString();
                    EXPERIENCIAC7 = columns[158].ToString();
                    CONDICION8 = columns[159].ToString();
                    CONOCIMIENTOC8 = columns[160].ToString();
                    EXPERIENCIAC8 = columns[161].ToString();
                    CONDICION9 = columns[162].ToString();
                    CONOCIMIENTOC9 = columns[163].ToString();
                    EXPERIENCIAC9 = columns[164].ToString();
                    CONDICION10 = columns[165].ToString();
                    CONOCIMIENTOC10 = columns[166].ToString();
                    EXPERIENCIAC10 = columns[167].ToString();
                    CONDICION11 = columns[168].ToString();
                    CONOCIMIENTOC11 = columns[169].ToString();
                    EXPERIENCIAC11 = columns[170].ToString();
                    CONDICION12 = columns[171].ToString();
                    CONOCIMIENTOC12 = columns[172].ToString();
                    EXPERIENCIAC12 = columns[173].ToString();
                    CONDICION13 = columns[174].ToString();
                    CONOCIMIENTOC13 = columns[175].ToString();
                    EXPERIENCIAC13 = columns[176].ToString();
                    CONDICION14 = columns[177].ToString();
                    CONOCIMIENTOC14 = columns[178].ToString();
                    EXPERIENCIAC14 = columns[179].ToString();
                    CONCIENCIA1 = columns[180].ToString();
                    CONOCIMIENTOCC1 = columns[181].ToString();
                    EXPERIENCIACC1 = columns[182].ToString();
                    CONCIENCIA2 = columns[183].ToString();
                    CONOCIMIENTOCC2 = columns[184].ToString();
                    EXPERIENCIACC2 = columns[185].ToString();
                    CONCIENCIA3 = columns[186].ToString();
                    CONOCIMIENTOCC3 = columns[187].ToString();
                    EXPERIENCIACC3 = columns[188].ToString();
                    CONCIENCIA4 = columns[189].ToString();
                    CONOCIMIENTOCC4 = columns[190].ToString();
                    EXPERIENCIACC4 = columns[191].ToString();
                    CONCIENCIA5 = columns[192].ToString();
                    CONOCIMIENTOCC5 = columns[193].ToString();
                    EXPERIENCIACC5 = columns[194].ToString();
                    PRIORIDAD_PREFERENCIA_GENERO = columns[195].ToString();
                    PRIORIDAD_PREFERENCIA_DIAGNOSTICO = columns[196].ToString();
                    PRIORIDAD_PREFERENCIA_CONDICION = columns[197].ToString();


                    if (IDAUX.Equals(idAuxiliar.ToString()))
                    {
                        auxiliarEncontrado = 1;
                        if (CONDICIONSALUD.Trim().Equals(CONDICION1.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC1;
                            textConAuxCond.Text = CONOCIMIENTOC1;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION2.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC2;
                            textConAuxCond.Text = CONOCIMIENTOC2;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION3.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC3;
                            textConAuxCond.Text = CONOCIMIENTOC3;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION4.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC4;
                            textConAuxCond.Text = CONOCIMIENTOC4;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION5.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC5;
                            textConAuxCond.Text = CONOCIMIENTOC5;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION6.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC6;
                            textConAuxCond.Text = CONOCIMIENTOC6;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION7.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC7;
                            textConAuxCond.Text = CONOCIMIENTOC7;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION8.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC8;
                            textConAuxCond.Text = CONOCIMIENTOC8;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION9.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC9;
                            textConAuxCond.Text = CONOCIMIENTOC9;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION10.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC10;
                            textConAuxCond.Text = CONOCIMIENTOC10;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION11.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC11;
                            textConAuxCond.Text = CONOCIMIENTOC11;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION12.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC12;
                            textConAuxCond.Text = CONOCIMIENTOC12;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION13.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC13;
                            textConAuxCond.Text = CONOCIMIENTOC13;
                        }
                        else if (CONDICIONSALUD.Trim().Equals(CONDICION13.Trim()))
                        {
                            textExpAuxCond.Text = EXPERIENCIAC13;
                            textConAuxCond.Text = CONOCIMIENTOC13;
                        }

                        ////////////////////

                        if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO1.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD1;
                            textConAuxDiag.Text = CONOCIMIENTOD1;
                        }
                        else if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO2.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD2;
                            textConAuxDiag.Text = CONOCIMIENTOD2;
                        }
                        else if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO3.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD3;
                            textConAuxDiag.Text = CONOCIMIENTOD3;
                        }
                        else if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO4.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD4;
                            textConAuxDiag.Text = CONOCIMIENTOD4;
                        }
                        else if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO5.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD5;
                            textConAuxDiag.Text = CONOCIMIENTOD5;
                        }
                        else if (GRUPODIAGNOSTICO.Trim().Equals(DIAGNOSTICO6.Trim()))
                        {
                            textExpAuxDiag.Text = EXPERIENCIAD6;
                            textConAuxDiag.Text = CONOCIMIENTOD6;
                        }

                        //////////

                        if (NIVELCONCIENCIA.Trim().Equals(CONCIENCIA1.Trim()))
                        {
                            textExpAuxConci.Text = EXPERIENCIACC1;
                            textConAuxConci.Text = CONOCIMIENTOCC1;
                        }
                        else if (NIVELCONCIENCIA.Trim().Equals(CONCIENCIA2.Trim()))
                        {
                            textExpAuxConci.Text = EXPERIENCIACC2;
                            textConAuxConci.Text = CONOCIMIENTOCC2;
                        }
                        else if (NIVELCONCIENCIA.Trim().Equals(CONCIENCIA3.Trim()))
                        {
                            textExpAuxConci.Text = EXPERIENCIACC3;
                            textConAuxConci.Text = CONOCIMIENTOCC3;
                        }
                        else if (NIVELCONCIENCIA.Trim().Equals(CONCIENCIA4.Trim()))
                        {
                            textExpAuxConci.Text = EXPERIENCIACC4;
                            textConAuxConci.Text = CONOCIMIENTOCC4;
                        }
                        else if (NIVELCONCIENCIA.Trim().Equals(CONCIENCIA5.Trim()))
                        {
                            textExpAuxConci.Text = EXPERIENCIACC5;
                            textConAuxConci.Text = CONOCIMIENTOCC5;
                        }


                        ////////////////


                        if (PERSONAACOMPANA.Trim().Equals(ACOMPAÑAMIENTO1.Trim()))
                        {
                            textExpAuxTipoC.Text = EXPERIENCIAA1;
                            textConAuxComp.Text = CONOCIMIENTOA1;
                        }
                        else if (PERSONAACOMPANA.Trim().Equals(ACOMPAÑAMIENTO2.Trim()))
                        {
                            textExpAuxTipoC.Text = EXPERIENCIAA2;
                            textConAuxComp.Text = CONOCIMIENTOA2;

                        }
                        else if (PERSONAACOMPANA.Trim().Equals(ACOMPAÑAMIENTO3.Trim()))
                        {
                            textExpAuxTipoC.Text = EXPERIENCIAA3;
                            textConAuxComp.Text = CONOCIMIENTOA3;
                        }

                        textPrefEdadAux.Text = CalcularEdad(FECHANACIMIENTOAUX,2);
                        textPrefNacionalidadAux.Text = NACIONALIDAD;
                        textPrefPersonalidadAux.Text = PERSONALIDAD;
                        textPrefGeneroAux.Text = GENEROPAUX;
                        textPrefIdiomaAux.Text = "ESPAÑOL";
                        textPrefMascotasAux.Text = "SI";

                        textNPrefTurnoA.Text = PRIORIDAD_PREFERENCIA_TURNO;
                        textNPrefCompA.Text = PRIORIDAD_PREFERENCIA_ACOMPAÑA;
                        textNPrefEdadA.Text = PRIORIDAD_PREFERENCIA_EDAD;

                        textNPrefGeneroA.Text = PRIORIDAD_PREFERENCIA_GENERO;
                        textNPrefDiagA.Text = PRIORIDAD_PREFERENCIA_DIAGNOSTICO;
                        textNPrefCondA.Text = PRIORIDAD_PREFERENCIA_CONDICION;




                    }
                }

            }
            
        }

        private string obtenerTipoTurno(object tipoTurno)
        {
            throw new NotImplementedException();
        }

        public string CalcularEdad(string fechaNacimiento, int tipo)
        {

            //Tipo es 1 si se esta calculando la fecha de un paciente que esta en formato 23-Oct-93 o 8-Nov-56
            //Tipo es 2 si se esta calculando la fecha de un auxiliar que esta en formato 7/05/2025

            int añoNacimiento=0;
            int mesNacimiento=0;
            int diaNacimiento = 0;


            if (tipo.Equals(1))
            {
                añoNacimiento = Int32.Parse(fechaNacimiento.Substring(fechaNacimiento.Length - 2, 2));

                if (añoNacimiento>=0 && añoNacimiento <= 22)
                {
                    añoNacimiento = añoNacimiento + 2000;
                }

                if (fechaNacimiento.Contains("Jan"))
                {
                    mesNacimiento = 01;
                }
                else if (fechaNacimiento.Contains("Feb"))
                {
                    mesNacimiento = 02;
                }
                else if (fechaNacimiento.Contains("Mar"))
                {
                    mesNacimiento = 03;
                }
                else if (fechaNacimiento.Contains("Apr"))
                {
                    mesNacimiento = 04;
                }
                else if (fechaNacimiento.Contains("May"))
                {
                    mesNacimiento = 05;
                }
                else if (fechaNacimiento.Contains("Jun"))
                {
                    mesNacimiento = 06;
                }
                else if (fechaNacimiento.Contains("Jul"))
                {
                    mesNacimiento = 07;
                }
                else if (fechaNacimiento.Contains("Aug"))
                {
                    mesNacimiento = 08;
                }
                else if (fechaNacimiento.Contains("Sep"))
                {
                    mesNacimiento = 09;
                }
                else if (fechaNacimiento.Contains("Oct"))
                {
                    mesNacimiento = 10;
                }
                else if (fechaNacimiento.Contains("Nov"))
                {
                    mesNacimiento = 11;
                }
                else if (fechaNacimiento.Contains("Dec"))
                {
                    mesNacimiento = 12;
                }



                /*if (fechaNacimiento.Substring(4, 1).Equals("/"))
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(2, 2));
                }
                else if (fechaNacimiento.Substring(3, 1).Equals("/"))
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(2, 1));
                }
                else
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(3, 2));
                }*/

            }
            else if (tipo.Equals(2))
            {
                añoNacimiento = Int32.Parse(fechaNacimiento.Substring(fechaNacimiento.Length - 4, 4));

                if (fechaNacimiento.Substring(1, 1).Equals("/"))
                {
                    mesNacimiento = Int32.Parse(fechaNacimiento.Substring(0, 1));
                }
                else
                {
                    mesNacimiento = Int32.Parse(fechaNacimiento.Substring(0, 2));
                }

                /*
                if (fechaNacimiento.Substring(4, 1).Equals("/"))
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(2, 2));
                }
                else if (fechaNacimiento.Substring(3, 1).Equals("/"))
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(2, 1));
                }
                else
                {
                    diaNacimiento = Int32.Parse(fechaNacimiento.Substring(3, 2));
                }
                */

            }


            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (añoNacimiento * 100 + mesNacimiento) * 100 + diaNacimiento;

            //return (a - b) / 10000;


            //Date edadAuxiliar = DateTimeConverter(fechaNacimientoAux);
            int edad = ((a - b) / 10000);

            string sEdad;
            if (edad<=35)
            {
                sEdad = "Rango de Edad 20-35";
            }
            else if (edad <= 50)
            {
                sEdad = "Rango de Edad 36-50";
            }
            else
            {
                sEdad = "Rango de Edad mayor de 50";
            }
            return sEdad;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //VerTurnos vt = new VerTurnos();
            //vt.Activate();
            //vt.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPac = idPaciente.Text;
            string idAux = idAuxiliar.Text;
            string idTur = idTurno.Text;

            BTurno bTurno = new BTurno();
            bTurno.asignarTurno(idTur, idPac, idAux);

            indicador.ForeColor = Color.Blue;
            indicador.Text = "Se asigno el auxiliar al turno";
        }
    }
}
