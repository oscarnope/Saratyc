﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    public class BRecomendarAuxiliares
    {
        Utilidades utilidades = new Utilidades();
        //int idPaciente = Int32.Parse(textPaciente.Text);

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
        string TIPOCONTRATO = ""

        //Variable usada para detectar si ya se encontro el paciente
        int pacienteEncontrado = 0;


        public BRecomendarAuxiliares(string institucion, string tipoTurno, string fechaInicio, string fechaFin, int idPaciente, int idauxAsignado, int idAuxPreferido, int idAuxRechazado)
        {
            //Se calcula el ranking del turno
            int rankingTurno = RankingTurno(institucion, tipoTurno, fechaInicio, fechaFin);

            //Se cargan los datos de los pacientes
            var pacientes = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Pacientes.csv");

            //Se busca el paciente entre los datos cargados
            foreach (var paciente in pacientes)
            {

                //Se lee cada uno de los pacientes
                if (pacienteEncontrado.Equals(0))
                {
                    var columnsP = paciente.Split(',').Where(c => c.Trim() != string.Empty).ToList();
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
                        var auxiliares = File.ReadAllLines("C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources\\Auxiliares4.2.csv");

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
                        }

                    }
                }
            }
        }

        private int RankingTurno(string institucion, string tipoTurno, string fechaInicio, string fechaFin)
        {
            int rankInstitucion = 0;

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

            return rankInstitucion;
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