using Google.Protobuf.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using Saratyc._4._Datos.DL;
using Saratyc.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class BRecomendarAuxiliares
    {
        Utilidades utilidades = new Utilidades();

        //Se declara la lista de auxiliares que llevara el ranking
        public List<string> rankingAuxiliares = new List<string>();

        //int idPaciente = Int32.Parse(textPaciente.Text);

        //Se declaran las variables que se usaran para ponderar en el match
        int pesoCondicionExperiencia = 10;
        int pesoDiagnosticoExperiencia = 10;
        int pesoConcienciaExperiencia = 10;
        int pesoCompañiaExperiencia = 10;
        int pesoRestricciones = 0;
        int pesoCondicionConocimiento = 9;
        int pesoDiagnosticoConocimiento = 9;
        int pesoConcienciaConocimiento = 9;
        int pesoTemperamento = 7;
        int pesoLugar = 7;
        int pesoGeneroPrefPaciente = 7;
        int pesoEdadPrefPaciente = 7;

        //Pesos de preferencias
        int pesoDatosSolicitud = 0;

        /*
        //Se declaran las variables que se usaran para ponderar el % de coincidencia
        double porcCondicionExperiencia = 16.39;
        double porcDiagnosticoExperiencia = 14.75;
        double porcConcienciaExperiencia = 13.11;
        double porcCompañiaExperiencia = 11.48;
        double porcRestricciones = 9.84;
        double porcCondicionConocimiento = 8.20;
        double porcDiagnosticoConocimiento = 6.56;
        double porcConcienciaConocimiento = 0;
        double porcTemperamento = 4.92;
        double porcLugar = 3.28;
        double porcGeneroPrefPaciente = 0;
        */
        

        double porcCondicionExperiencia = 10;
        double porcDiagnosticoExperiencia = 10;
        double porcConcienciaExperiencia = 9;
        double porcCompañiaExperiencia = 9;
        double porcRestricciones = 7;
        double porcCondicionConocimiento = 6;
        double porcDiagnosticoConocimiento = 6;
        double porcConcienciaConocimiento = 6;
        double porcTemperamento = 5;
        double porcLugar = 0;//Esto no se usara en esta version
        double porcGeneroPrefPaciente = 4;
        double porcEdadPrefPaciente = 3;

        /*
        double porcCondicionExperiencia = 16.39;
        double porcDiagnosticoExperiencia = 14.75;
        double porcConcienciaExperiencia = 13.11;
        double porcCompañiaExperiencia = 11.48;
        double porcRestricciones = 9.84;
        double porcCondicionConocimiento = 8.20;
        double porcDiagnosticoConocimiento = 6.56;
        double porcConcienciaConocimiento = 0;
        double porcTemperamento = 4.92;
        double porcLugar = 3.28;
        */
        


        //Variable que indica el porcentaje de coincidencias
        double porcentajeCoincidencia = 0;

        int[] arrayAuxiliares;
        string auxOrdenados;

        //Se declaran variables para guardar datos del paciente
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

        //se declaran variables para guardar datos del auxiliar
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
        string TIPOCONTRATO = "";

        //Variable usada para detectar si ya se encontro el paciente
        int pacienteEncontrado = 0;


        public BRecomendarAuxiliares(string institucion, string tipoTurno, string fechaInicio, string fechaFin, int idPaciente, int idauxAsignado, int idAuxPreferido, int idAuxRechazado)
        {
            
            //Se calcula el ranking del turno
            int rankingTurno = RankingTurno(institucion, tipoTurno, fechaInicio, fechaFin);

            //Se cargan los datos de los pacientes
            var pacientes = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Pacientes.csv");

            

            double porcentajeCoincidenciaMax = 0;

            //Se busca el paciente entre los datos cargados
            foreach (var paciente in pacientes)
            {

                //Se lee cada uno de los pacientes
                if (pacienteEncontrado.Equals(0))
                {
                    var columnsP = paciente.Split(';').Where(c => c.Trim() != string.Empty).ToList();
                    IDPACIENTE = columnsP[0].ToString();
                    NOMBREPACIENTE = columnsP[1].ToString();
                    APELLIDOPACIENTE = columnsP[2].ToString();
                    CEDULAPACIENTE = columnsP[3].ToString();
                    FECHANACIMIENTOPACIENTE = columnsP[4].ToString();
                    GENEROPACIENTE = columnsP[5].ToString();
                    LOCALIDADPACIENTE = columnsP[6].ToString();
                    BARRIOPACIENTE = columnsP[7].ToString();
                    NIVELCONCIENCIA = columnsP[8].ToString();
                    NIVELAUTONOMIA = columnsP[9].ToString();
                    CONDICIONSALUD = columnsP[10].ToString();
                    CONTEXTURAFISICA = columnsP[11].ToString();
                    TEMPERAMENTO = columnsP[12].ToString();
                    GRUPODIAGNOSTICO = columnsP[13].ToString();
                    PERSONAACOMPANA = columnsP[14].ToString();
                    PREFERENCIAGENERO = columnsP[15].ToString();
                    PREFERENCIAEDAD = columnsP[16].ToString();
                    PREFERENCIANACIONALIDAD = columnsP[17].ToString();
                    PREFERENCIAPERSONALIDAD = columnsP[18].ToString();
                    PREFERENCIAIDIOMA = columnsP[19].ToString();
                    PREFERENCIAMASCOTAS = columnsP[20].ToString();

                    //Si se encuentra el paciente se procede a calcular vs los datos de los auxiliares
                    if (IDPACIENTE.Equals(idPaciente.ToString()))
                    {
                        //Como ya se encontro el paciente la variable se vuelve 1
                        pacienteEncontrado = 1;

                        //Se leen los datos de los auxiliares
                        var auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares.csv");

                        foreach (var auxiliar in auxiliares)
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
                            TIPOCONTRATO = columns[198].ToString();

                            //Se calcula el ranking del tipo de contrato
                            int rankingTipoContrato = RankingTipoContrato(TIPOCONTRATO);

                            //Se hace cero la variable
                            porcentajeCoincidencia = 0;

                            //Aqui se cargan los resultados obtenidos en phyton
                            //cargarResultadosPhyton();

                            //Esta es una recreacion de lo que hace Phyton para efectos de pruebas 
                            matchCondicion(CONDICIONSALUD);
                            matchDiagnostico(GRUPODIAGNOSTICO);
                            matchConciencia(NIVELCONCIENCIA);
                            matchRestricciones(NIVELAUTONOMIA,RESTRICCION_DESPLAZAMIENTO, RESTRICCION_OBJETOS);
                            matchTemperamento(TEMPERAMENTO,PERSONALIDAD);
                            //matchTipoServicio
                            //matchLugar(LOCALIDADPACIENTE, LOCALIDAD);
                            matchGenero(PREFERENCIAGENERO, GENEROPAUX);
                            matchEdad(FECHANACIMIENTOAUX,PREFERENCIAEDAD);
                            
                            /*
                            if(IDAUX.Equals("43"))
                            {
                                porcentajeCoincidencia = 71.998;
                            }
                            else if (IDAUX.Equals("430"))
                            {
                                porcentajeCoincidencia = 40.998;
                            }
                            */

                            if (!IDAUX.Equals("ID"))
                            {
                                int intIDAUX = Int32.Parse(IDAUX);
                                rankingAuxiliares.Add(string.Format("{0:D2}", intIDAUX) + "," + porcentajeCoincidencia.ToString("00.00"));
                            }

                        }

                    }
                }
            }

            //Se ordena por el porcentaje de coincidencia la lista
            rankingAuxiliares.Sort((n1, n2) => n1.Split(",")[1].CompareTo(n2.Split(",")[1]));

            //Se guarda el numero de auxiliares procesado
            int numeroAuxiliares = rankingAuxiliares.Count;

            //Se crean los arrays que se usaran para imprimir los archivos
            string[] arrayAuxiliares = new string[numeroAuxiliares];
            string[] arrayPorcentajes = new string[numeroAuxiliares]; 

            //Se recorre el listado de ranking a la inversa
            for (int k = rankingAuxiliares.Count;k >= 1; k--)
            {
                var columns = rankingAuxiliares[k-1].Split(',').Where(c => c.Trim() != string.Empty).ToList();
                string IDAUX = columns[0].ToString();
                string porcentajeCoincidencia = columns[1].ToString();
                
                //Se almacenan los valores en los arrays en orden ascendente, pues asi se almacenan con el sort
                arrayAuxiliares[k-1] = IDAUX;
                arrayPorcentajes[k-1] = porcentajeCoincidencia;

            }

            //Se invierten, para que queden en orden ascendente 
            Array.Reverse(arrayAuxiliares);
            Array.Reverse(arrayPorcentajes);

            //string[] arrayAuxiliaresOK = new string[numeroAuxiliares];

            //Solo si viene informacion en el archivo de recomendaciones se añaden el id del paciente
            if (!arrayAuxiliares.Count().Equals(0))
            {

                // Translate your splitted string (array) in a list:
                var rankingAuxiliares2 = arrayAuxiliares.ToList<string>();

                // Se inserta el id del paciente 2 veces, solo por compatibilidad con Phyton, para que las primeras 2 posiciones lo contengan
                rankingAuxiliares2.Insert(0, IDPACIENTE);
                rankingAuxiliares2.Insert(0, IDPACIENTE);

                // Back to array:
                string[] arrayAuxiliares2 = rankingAuxiliares2.ToArray<string>();

                crearArchivosRanking(arrayAuxiliares2, "Turnos.csv", "C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\");
                crearArchivosRanking(arrayPorcentajes, "Rankings.csv", "C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\");
            }



        }

        private void crearArchivosRanking(string[] arrayDatos,string nombreArchivo, string ruta)
        {
            utilidades.escribirArchivoTurnos(arrayDatos, nombreArchivo, ruta);
        }

        private void matchCondicion(string condiciónSalud)
        {
            //Calcula el match de la condición de salud del paciente con los conocimientos y experiencia del auxiliar
            string expAuxCondicion = "NO";
            string conAuxCondicion = "NO";

            if (condiciónSalud.Trim().Equals(CONDICION1.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC1;
                conAuxCondicion = CONOCIMIENTOC1;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION2.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC2;
                conAuxCondicion = CONOCIMIENTOC2;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION3.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC3;
                conAuxCondicion = CONOCIMIENTOC3;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION4.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC4;
                conAuxCondicion = CONOCIMIENTOC4;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION5.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC5;
                conAuxCondicion = CONOCIMIENTOC5;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION6.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC6;
                conAuxCondicion = CONOCIMIENTOC6;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION7.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC7;
                conAuxCondicion = CONOCIMIENTOC7;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION8.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC8;
                conAuxCondicion = CONOCIMIENTOC8;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION9.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC9;
                conAuxCondicion = CONOCIMIENTOC9;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION10.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC10;
                conAuxCondicion = CONOCIMIENTOC10;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION11.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC11;
                conAuxCondicion = CONOCIMIENTOC11;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION12.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC12;
                conAuxCondicion = CONOCIMIENTOC12;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION13.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC13;
                conAuxCondicion = CONOCIMIENTOC13;
            }
            else if (condiciónSalud.Trim().Equals(CONDICION14.Trim()))
            {
                expAuxCondicion = EXPERIENCIAC14;
                conAuxCondicion = CONOCIMIENTOC14;
            }

            //Si coincide la condicion
            if (expAuxCondicion.Equals("SI"))
            {
                pesoDatosSolicitud+= pesoCondicionExperiencia * 1;
                porcentajeCoincidencia += porcCondicionExperiencia;

            }
            if (conAuxCondicion.Equals("SI"))
            {
                pesoDatosSolicitud+= pesoCondicionConocimiento * 1;
                porcentajeCoincidencia += porcCondicionConocimiento;
            }

        }

        private void matchDiagnostico(string grupoDiagnostico)
        {
            //Calcula el match del grupo diagnostico del paciente con los conocimientos y experiencia del auxiliar
            string expAuxDiagnostico = "NO";
            string conAuxDiagnostico = "NO";

            if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO1.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD1;
                conAuxDiagnostico = CONOCIMIENTOD1;
            }
            else if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO2.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD2;
                conAuxDiagnostico = CONOCIMIENTOD2;
            }
            else if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO3.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD3;
                conAuxDiagnostico = CONOCIMIENTOD3;
            }
            else if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO4.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD4;
                conAuxDiagnostico = CONOCIMIENTOD4;
            }
            else if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO5.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD5;
                conAuxDiagnostico = CONOCIMIENTOD5;
            }
            else if (grupoDiagnostico.Trim().Equals(DIAGNOSTICO6.Trim()))
            {
                expAuxDiagnostico = EXPERIENCIAD6;
                conAuxDiagnostico = CONOCIMIENTOD6;
            }

            //Si coincide el diagnostico
            if (expAuxDiagnostico.Equals("SI"))
            {
                pesoDatosSolicitud += pesoDiagnosticoExperiencia * 1;
                porcentajeCoincidencia += porcDiagnosticoExperiencia;

            }
            if (conAuxDiagnostico.Equals("SI"))
            {
                pesoDatosSolicitud += pesoDiagnosticoConocimiento * 1;
                porcentajeCoincidencia += porcDiagnosticoConocimiento;
            }
        }

        private void matchConciencia(string nivelConciencia)
        {
            //Calcula el match del nivel de conciencia del paciente con los conocimientos y experiencia del auxiliar
            string expAuxConciencia= "NO";
            string conAuxConciencia = "NO";

            if (nivelConciencia.Trim().Equals(CONCIENCIA1.Trim()))
            {
                expAuxConciencia = EXPERIENCIACC1;
                conAuxConciencia = CONOCIMIENTOCC1;
            }
            else if (nivelConciencia.Trim().Equals(CONCIENCIA2.Trim()))
            {
                expAuxConciencia = EXPERIENCIACC2;
                conAuxConciencia = CONOCIMIENTOCC2;
            }
            else if (nivelConciencia.Trim().Equals(CONCIENCIA3.Trim()))
            {
                expAuxConciencia = EXPERIENCIACC3;
                conAuxConciencia = CONOCIMIENTOCC3;
            }
            else if (nivelConciencia.Trim().Equals(CONCIENCIA4.Trim()))
            {
                expAuxConciencia = EXPERIENCIACC4;
                conAuxConciencia = CONOCIMIENTOCC4;
            }
            else if (nivelConciencia.Trim().Equals(CONCIENCIA5.Trim()))
            {
                expAuxConciencia = EXPERIENCIACC5;
                conAuxConciencia = CONOCIMIENTOCC5;
            }


            //Si coincide el nivel de conciencia 
            if (expAuxConciencia.Equals("SI"))
            {
                pesoDatosSolicitud += pesoConcienciaExperiencia;
                porcentajeCoincidencia += porcConcienciaExperiencia;

            }
            if (conAuxConciencia.Equals("SI"))
            {
                pesoDatosSolicitud += pesoConcienciaConocimiento;
                porcentajeCoincidencia += porcConcienciaConocimiento;
            }
        }

        private void matchRestricciones(string nivelAutonomia, string restriccionDesplazamiento, string restriccionObjetos)
        {
            //Los auxiliares con restricciones no se asignan a pacientes con dependencia moderada o severa
            if(nivelAutonomia.Trim().Equals("Dependiente Moderado") && nivelAutonomia.Trim().Equals("Dependiente Severo/a"))
            {
                if(restriccionDesplazamiento.Equals("NO") && restriccionObjetos.Equals("NO"))
                {
                    pesoDatosSolicitud += pesoRestricciones;
                    porcentajeCoincidencia += porcRestricciones;
                }
            }
        }

        private void matchTemperamento(string temperamento, string personalidad)
        {
            int matchOK = 0;
            
            //Match de los temperamentos de auxiliar y paciente
            if(temperamento.Trim().Equals("Ansioso (a)") && personalidad.Trim().Equals("Tranquilo (a)"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Tranquilo (a)") && personalidad.Trim().Equals("Tranquilo (a)"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Demandante") && personalidad.Trim().Equals("Tranquilo (a)"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Demandante") && personalidad.Trim().Equals("Hablador (a)"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Callado-Reservado(a)") && personalidad.Trim().Equals("Demandante"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Hablador (a)") && personalidad.Trim().Equals("Demandante"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Multifacético") && personalidad.Trim().Equals("Tranquilo (a)"))
            {
                matchOK = 1;
            }
            else if (temperamento.Trim().Equals("Tranquilo (a)") && personalidad.Trim().Equals("Ansioso (a)"))
            {
                matchOK = 1;
            }

            if (matchOK == 1)
            {
                pesoDatosSolicitud += pesoTemperamento;
                porcentajeCoincidencia += porcTemperamento;
            }
        }


        private void matchLugar(string localidadPaciente, string localidad)
        {
            //Como la mayoria de pacientes estan en 3 localidades se saca la distancia de localidades
            int distancia=5;
            
            if (localidadPaciente.ToUpper().Equals("CHAPINERO"))
            {
                switch (localidad.Trim())
                {
                    case "Antonio Nariño":
                        distancia = 2;
                        break;
                    case "Barrios Unidos":
                        distancia = 1;
                        break;
                    case "Bosa":
                        distancia = 4;
                        break;
                    case "Candelaria":
                        distancia = 2;
                        break;
                    case "Ciudad Bolivar":
                        distancia = 4;
                        break;
                    case "Engativa":
                        distancia = 2;
                        break;
                    case "Fontibón":
                        distancia = 2;
                        break;
                    case "Kennedy":
                        distancia = 3 ;
                        break;
                    case "Mártires":
                        distancia = 2 ;
                        break;
                    case "Rafael Uribe":
                        distancia = 2;
                        break;
                    case "Puente Aranda":
                        distancia = 2;
                        break;
                    case "San Cristóbal":
                        distancia = 2;
                        break;
                    case "Santa Fe":
                        distancia = 1;
                        break;
                    case "Suba":
                        distancia = 2;
                        break;
                    case "Teusaquillo":
                        distancia = 1;
                        break;
                    case "Tunjuelito":
                        distancia = 3;
                        break;
                    case "Usaquén":
                        distancia = 1;
                        break;
                    case "Usme":
                        distancia = 3;
                        break;
                }
            }

            else if (localidadPaciente.ToUpper().Equals("TEUSAQUILLO"))
            {
                switch (localidad.Trim())
                {
                    case "Antonio Nariño":
                        distancia = 2;
                        break;
                    case "Barrios Unidos":
                        distancia = 1;
                        break;
                    case "Bosa":
                        distancia = 3;
                        break;
                    case "Candelaria":
                        distancia = 2;
                        break;
                    case "Chapinero":
                        distancia = 1;
                        break;
                    case "Ciudad Bolivar":
                        distancia = 3;
                        break;
                    case "Engativa":
                        distancia = 1;
                        break;
                    case "Fontibón":
                        distancia = 1;
                        break;
                    case "Kennedy":
                        distancia = 2;
                        break;
                    case "Mártires":
                        distancia = 1;
                        break;
                    case "Rafael Uribe":
                        distancia = 1;
                        break;
                    case "San Cristóbal":
                        distancia = 2;
                        break;
                    case "Santa Fe":
                        distancia = 2;
                        break;
                    case "Suba":
                        distancia = 2;
                        break;
                    case "Tunjuelito":
                        distancia = 2;
                        break;
                    case "Usaquén":
                        distancia = 2;
                        break;
                    case "Usme":
                        distancia = 3;
                        break;
                }
            }

            else if (localidadPaciente.ToUpper().Equals("USAQUÉN"))
            {
                switch (localidad.Trim())
                {
                    case "Antonio Nariño":
                        distancia = 4;
                        break;
                    case "Barrios Unidos":
                        distancia = 1;
                        break;
                    case "Bosa":
                        distancia = 5;
                        break;
                    case "Candelaria":
                        distancia = 3;
                        break;
                    case "Chapinero":
                        distancia = 1;
                        break;
                    case "Ciudad Bolivar":
                        distancia = 5;
                        break;
                    case "Engativa":
                        distancia = 2;
                        break;
                    case "Fontibón":
                        distancia = 3;
                        break;
                    case "Kennedy":
                        distancia = 4;
                        break;
                    case "Mártires":
                        distancia = 1;
                        break;
                    case "Rafael Uribe":
                        distancia = 1;
                        break;
                    case "San Cristóbal":
                        distancia = 3;
                        break;
                    case "Santa Fe":
                        distancia = 2;
                        break;
                    case "Suba":
                        distancia = 1;
                        break;
                    case "Teusaquillo":
                        distancia = 2;
                        break;
                    case "Tunjuelito":
                        distancia = 4;
                        break;
                    case "Usme":
                        distancia = 4;
                        break;
                }
            }

            //Se divide el pesoLugar entre la distancia encontrada, a mayor distancia menos sera el peso
            int pesoLugarCalculadp = pesoLugar / distancia;

            pesoDatosSolicitud += pesoLugarCalculadp;
            porcentajeCoincidencia += porcLugar;
        }

        private void matchGenero(string preferenciaGenero, string generoAux)
        {
            //Se busca el match del genero preferido por el paciente y el genero del auxiliar
            if(preferenciaGenero.Equals(generoAux))
            {
                pesoDatosSolicitud += pesoGeneroPrefPaciente;
                porcentajeCoincidencia += porcGeneroPrefPaciente;
            }
        }

        private void matchEdad(string fechaNacimientoAux, string preferenciaEdad)
        {

            //Se busca el match del genero preferido por el paciente y el genero del auxiliar

            string rangoEdad = CalcularEdad(fechaNacimientoAux);
            if (preferenciaEdad.Equals(rangoEdad))
            {
                pesoDatosSolicitud += pesoEdadPrefPaciente;
                porcentajeCoincidencia += porcEdadPrefPaciente;
            }
        }

        public string CalcularEdad(string fechaNacimientoAux)
        {

            if (fechaNacimientoAux.Equals("FECHA NACIMIENTO"))
            {
                fechaNacimientoAux = "1/1/1990";
            }
            
            int añoNacimiento = Int32.Parse(fechaNacimientoAux.Substring(fechaNacimientoAux.Length - 4, 4));
            int mesNacimiento;

            if (fechaNacimientoAux.Substring(1, 1).Equals("/"))
            {
                mesNacimiento = Int32.Parse(fechaNacimientoAux.Substring(0, 1));
            }
            else
            {
                mesNacimiento = Int32.Parse(fechaNacimientoAux.Substring(0, 2));
            }

            int diaNacimiento=0;
            /*if (fechaNacimientoAux.Substring(4, 1).Equals("/") && fechaNacimientoAux.Substring(2, 1).Equals("/"))
            {
                diaNacimiento = Int32.Parse(fechaNacimientoAux.Substring(3, 1));
            }
            else if (fechaNacimientoAux.Substring(2, 1).Equals("/") && fechaNacimientoAux.Substring(5, 1).Equals("/"))
            {
                diaNacimiento = Int32.Parse(fechaNacimientoAux.Substring(2, 2));
            }
            else if(fechaNacimientoAux.Substring(2, 1).Equals("/") && fechaNacimientoAux.Substring(4, 1).Equals("/"))
            {
                diaNacimiento = Int32.Parse(fechaNacimientoAux.Substring(3, 2));
            }
            else if(fechaNacimientoAux.Substring(1, 1).Equals("/") && fechaNacimientoAux.Substring(3, 1).Equals("/"))
            {
                diaNacimiento = Int32.Parse(fechaNacimientoAux.Substring(2, 1));
            }*/

            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (añoNacimiento * 100 + mesNacimiento) * 100 + diaNacimiento;

            //return (a - b) / 10000;


            //Date edadAuxiliar = DateTimeConverter(fechaNacimientoAux);
            int edad = ((a - b) / 10000);

            string sEdad;
            if (edad <= 35)
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
        private int RankingTurno(string institucion, string tipoTurno, string fechaInicio, string fechaFin)
        {
            int rankInstitucion = 0;
            int rankTipoTurno = 0;
            int rankProcedimiento = 0;


            //Se inicia calculando el ranking de la institucion
            switch (institucion.Trim().ToUpper())
            {
                case "DOMICILIO":
                    rankInstitucion = 9;
                    break;
                case "CLINICA NOGALES":
                    rankInstitucion = 8;
                    break;
                case "CLINICA COUNTRY":
                    rankInstitucion = 7;
                    break;
                case "CLINICA AZUL":
                    rankInstitucion = 6;
                    break;
                case "CLNICA DE LA MUJER":
                    rankInstitucion = 5;
                    break;
                case "CLINICA CAROLINA":
                    rankInstitucion = 4;
                    break;
                case "ORTOPEDIA Y CIRUGÍA ESTÉTICA":
                    rankInstitucion = 3;
                    break;
                case "PREPAGADAS":
                    rankInstitucion = 2;
                    break;
                case "HOSPITAL MEDERY":
                    rankInstitucion = 1;
                    break;
            }

            //Se calcula el ranking del tipo de turno
            switch (tipoTurno.Trim().ToUpper())
            {
                case "TURNO 14 HORAS":
                    rankTipoTurno = 28;
                    break;
                case "24 HORAS PAR":
                    rankTipoTurno = 27;
                    break;
                case "DIURNO MEDERI":
                    rankTipoTurno = 26;
                    break;
                case "ESPEC MAMA DIUR":
                    rankTipoTurno = 25;
                    break;
                case "ESPEC MAMA NOC":
                    rankTipoTurno = 24;
                    break;
                case "24 HORAS IMPAR":
                    rankTipoTurno = 23;
                    break;
                case "VIVENZA DIA":
                    rankTipoTurno = 22;
                    break;
                case "VIVENZA NOCHE":
                    rankTipoTurno = 21;
                    break;
                case "VIVENZA COMPLEMENTO":
                    rankTipoTurno = 20;
                    break;
                case "MEDIO TURNO DIURNO  AM":
                    rankTipoTurno = 19;
                    break;
                case "TURNO 10 HORAS.RANCHO":
                    rankTipoTurno = 18;
                    break;
                case "TURNO 4 HORAS.RANCHO":
                    rankTipoTurno = 17;
                    break;
                case "10 HORAS":
                    rankTipoTurno = 16;
                    break;
                case "MEDIO TURNO DIURNO PM":
                    rankTipoTurno = 15;
                    break;
                case "NOCTURNO ADICIONAL":
                    rankTipoTurno = 14;
                    break;
                case "TURNO INDUCCION 2 HORAS":
                    rankTipoTurno = 13;
                    break;
                case "8 HORAS":
                    rankTipoTurno = 12;
                    break;
                case "DESCANSO REMUNERADO":
                    rankTipoTurno = 11;
                    break;
                case "DIURNO":
                    rankTipoTurno = 10;
                    break;
                case "NOCTURNO":
                    rankTipoTurno = 9;
                    break;
                case "MEDIO TURNO NOCTURNO":
                    rankTipoTurno = 8;
                    break;
                case "TURNO 6 HORAS":
                    rankTipoTurno = 7;
                    break;
                case "2 HORAS INDUCCION":
                    rankTipoTurno = 6;
                    break;
                case "4 HORAS":
                    rankTipoTurno = 5;
                    break;
                case "3 HORAS":
                    rankTipoTurno = 4;
                    break;
                case "2 HORAS":
                    rankTipoTurno = 3;
                    break;
            }

            int rankingTurno = rankInstitucion + rankTipoTurno + rankProcedimiento;

            return rankingTurno;
        }

        private int RankingTipoContrato(string tipoContrato)
        {
            int rankingTipoContrato = 0;
            switch (tipoContrato.Trim())
            {
                case "Directo":
                    rankingTipoContrato = 2;
                    break;
                case "Servicios":
                    rankingTipoContrato = 1;
                    break;
            }

            return rankingTipoContrato;
        }
    }
}
