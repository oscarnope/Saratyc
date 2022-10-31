using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._4._Datos.DL
{
    public class DAuxiliar
    {
        private int id;
        private int idEnferdata;
        private string nombre;
        private string apellido;
        private string identificacion;
        private string fechaNacimiento;
        private string genero;
        /*private string CondicionSalud;
        private string ConCondicionSalud;
        private string ExpCondicionSalud;
        private string Diagnostico;
        private string ConDiagnostico;
        private string ExpDiagnostico;
        private string Acompañamiento;
        private string ConAcompañamiento;
        private string ExpAcompañamiento;
        */
        private string ciudad;
        private string localidad;
        private string barrio;
        //private string restriccionDesplazamiento;
        //private string restriccionObjetos;
        private string contextura;
        private string nacionalidad;
        private string disponibilidad;
        private string personalidad;
        /*private string prefTipoTurno;
        private string prefTipoTurnoValor;
        private string prefAcompañamiento;
        private int prefAcompañamientoValor;
        private string prefEdad;
        private int prefEdadValor;
        private string prefGenero;
        private int prefGeneroValor;
        private string prefTipoServicio;
        private int prefTipoServicioValor;
        private string prefGrupoDiagnostico;
        private int prefGrupoDiagnosticoValor;
        private string prefCondicionSalud;
        private int prefCondicionSaludValor;
        private string gustoMascotas;
        private string interesCapacitacion;
        private int interesCapacitacionValor;
        */

        public DAuxiliar()
        {

        }

        public List<string> buscarAuxiliarEnferdata(string identificacion)
        {
            string query;
            List<string> lAuxiliares = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Consulta los datos de un auxiliar dada su identificacion
            //query = "SELECT \r\n    Enfermera.id idEnferdata,\r\n    Enfermera.nombre nombre,\r\n    Enfermera.apellido apellido,\r\n    Enfermera.identificacion identificacion,\r\n    Enfermera.fechaNacimiento fechaNacimiento,\r\n    Genero.nombre genero,\r\n    Ciudad.nombre ciudad,\r\n    CiudadLocalidad.nombre localidad,\r\n    Enfermera.barrio barrio,\r\n    '' contextura,\r\n    (SELECT \r\n            CASE id\r\n                    WHEN 1 THEN 'Colombiano'\r\n                    WHEN 2 THEN 'Colombiano'\r\n                    WHEN 4 THEN 'Extranjero'\r\n                    WHEN 5 THEN 'Colombiano'\r\n                    WHEN 6 THEN 'Colombiano'\r\n                    WHEN 7 THEN 'Colombiano'\r\n                    WHEN 8 THEN 'Extranjero'\r\n                    WHEN 9 THEN 'Extranjero'\r\n                    ELSE 'Colombiano'\r\n                END AS nacionalidad\r\n        FROM\r\n            `enferdata-web`.`TipoIdentificacion` TipoIdentificacion\r\n        WHERE\r\n            Enfermera.tipoIdentificacionId = TipoIdentificacion.id) AS nacionalidad,\r\n    'SI' disponibilidad,\r\n    'Pendiente' personalidad,\r\n    'SI' restriccionDesplazamiento,\r\n    'NO' restriccionObjetos\r\nFROM\r\n    `enferdata-web`.`Enfermera` Enfermera,\r\n    `enferdata-web`.`Genero` Genero,\r\n    `enferdata-web`.`Ciudad` Ciudad,\r\n    `enferdata-web`.`CiudadLocalidad` CiudadLocalidad\r\nWHERE\r\n    Enfermera.generoId = Genero.id\r\n        AND Enfermera.ciudadId = Ciudad.id\r\n        AND Enfermera.ciudadLocalidadId = CiudadLocalidad.id\r\n        AND Enfermera.activo = 1\r\n        AND Enfermera.identificacion = '1015396096'\r\nORDER BY identificacion\r\n";
            query = "SELECT \r\n    Enfermera.id idEnferdata,\r\n    Enfermera.nombre nombre,\r\n    Enfermera.apellido apellido,\r\n    Enfermera.identificacion identificacion,\r\n    Enfermera.fechaNacimiento fechaNacimiento,\r\n    Genero.nombre genero,\r\n    Ciudad.nombre ciudad,\r\n    CiudadLocalidad.nombre localidad,\r\n    Enfermera.barrio barrio,\r\n   (SELECT \r\n            CASE id\r\n                    WHEN 1 THEN 'Colombiano'\r\n                    WHEN 2 THEN 'Colombiano'\r\n                    WHEN 4 THEN 'Extranjero'\r\n                    WHEN 5 THEN 'Colombiano'\r\n                    WHEN 6 THEN 'Colombiano'\r\n                    WHEN 7 THEN 'Colombiano'\r\n                    WHEN 8 THEN 'Extranjero'\r\n                    WHEN 9 THEN 'Extranjero'\r\n                    ELSE 'Colombiano'\r\n                END AS nacionalidad\r\n        FROM\r\n            `enferdata-web`.`TipoIdentificacion` TipoIdentificacion\r\n        WHERE\r\n            Enfermera.tipoIdentificacionId = TipoIdentificacion.id) AS nacionalidad,\r\n    'SI' disponibilidad,\r\n    'Pendiente' personalidad,\r\n    'SI' restriccionDesplazamiento,\r\n    'NO' restriccionObjetos\r\nFROM\r\n    `enferdata-web`.`Enfermera` Enfermera,\r\n    `enferdata-web`.`Genero` Genero,\r\n    `enferdata-web`.`Ciudad` Ciudad,\r\n    `enferdata-web`.`CiudadLocalidad` CiudadLocalidad\r\nWHERE\r\n    Enfermera.generoId = Genero.id\r\n        AND Enfermera.ciudadId = Ciudad.id\r\n        AND Enfermera.ciudadLocalidadId = CiudadLocalidad.id\r\n        AND Enfermera.activo = 1\r\n        AND Enfermera.identificacion = '"+identificacion + "'";

            lAuxiliares = conexionMySQL.consultarEnferdata(query);

            return lAuxiliares;
        }

        internal List<string> buscarAuxiliaSaratyc(string identificacionAuxiliar)
        {
            string query;
            List<string> lAuxiliares = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Consulta los datos de un auxiliar dada su identificacion
            query = "SELECT \r\n    Enfermera.id idEnferdata,\r\n    Enfermera.nombre nombre,\r\n    Enfermera.apellido apellido,\r\n    Enfermera.identificacion identificacion,\r\n    Enfermera.fechaNacimiento fechaNacimiento,\r\n    Genero.nombre genero,\r\n    Ciudad.nombre ciudad,\r\n    CiudadLocalidad.nombre localidad,\r\n    Enfermera.barrio barrio,\r\n   (SELECT \r\n            CASE id\r\n                    WHEN 1 THEN 'Colombiano'\r\n                    WHEN 2 THEN 'Colombiano'\r\n                    WHEN 4 THEN 'Extranjero'\r\n                    WHEN 5 THEN 'Colombiano'\r\n                    WHEN 6 THEN 'Colombiano'\r\n                    WHEN 7 THEN 'Colombiano'\r\n                    WHEN 8 THEN 'Extranjero'\r\n                    WHEN 9 THEN 'Extranjero'\r\n                    ELSE 'Colombiano'\r\n                END AS nacionalidad\r\n        FROM\r\n            `enferdata-web`.`TipoIdentificacion` TipoIdentificacion\r\n        WHERE\r\n            Enfermera.tipoIdentificacionId = TipoIdentificacion.id) AS nacionalidad,\r\n    'SI' disponibilidad,\r\n    'Pendiente' personalidad,\r\n    'SI' restriccionDesplazamiento,\r\n    'NO' restriccionObjetos\r\nFROM\r\n    `enferdata-web`.`Enfermera` Enfermera,\r\n    `enferdata-web`.`Genero` Genero,\r\n    `enferdata-web`.`Ciudad` Ciudad,\r\n    `enferdata-web`.`CiudadLocalidad` CiudadLocalidad\r\nWHERE\r\n    Enfermera.generoId = Genero.id\r\n        AND Enfermera.ciudadId = Ciudad.id\r\n        AND Enfermera.ciudadLocalidadId = CiudadLocalidad.id\r\n        AND Enfermera.activo = 1\r\n        AND Enfermera.identificacion = '" + identificacion + "'";

            lAuxiliares = conexionMySQL.consultarSaratyc(query);

            return lAuxiliares;
        }

        private int obteneridPreferencia(string preferencia)
        {
            string tipoPreferencia="";
            string query = "";
            string preferenciaSeleccionada="";
            int idPreferencia;

            //Se identifica la preferencia
            if (preferencia.Contains("prefTipoDiurno"))
            {
                tipoPreferencia = "TURNO";
                preferenciaSeleccionada = "DIURNO";


            }
            else if (preferencia.Contains("prefTipoNocturno"))
            {
                tipoPreferencia = "TURNO";
                preferenciaSeleccionada = "NOCTURNO";
            }

            else if (preferencia.Contains("prefCompFam"))
            {
                tipoPreferencia = "COMPANIA";
                preferenciaSeleccionada = "FAMILIA";
            }

            else if (preferencia.Contains("prefCompEmp"))
            {
                tipoPreferencia = "COMPANIA";
                preferenciaSeleccionada = "EMPLEADA";
            }

            else if (preferencia.Contains("prefCompSin"))
            {
                tipoPreferencia = "COMPANIA";
                preferenciaSeleccionada = "SIN";
            }

            else if (preferencia.Contains("prefEdadBinomio"))
            {
                tipoPreferencia = "EDAD";
                preferenciaSeleccionada = "BINOMIO";
            }

            else if (preferencia.Contains("prefEdadAdultos"))
            {
                tipoPreferencia = "EDAD";
                preferenciaSeleccionada = "ADULTO";
            }

            else if (preferencia.Contains("prefEdadNiños"))
            {
                tipoPreferencia = "EDAD";
                preferenciaSeleccionada = "NINOS";
            }

            else if (preferencia.Contains("prefTipoDomicilio"))
            {
                tipoPreferencia = "SERVICIO";
                preferenciaSeleccionada = "DOMICILIO";
            }

            else if (preferencia.Contains("prefTipoClinica"))
            {
                tipoPreferencia = "SERVICIO";
                preferenciaSeleccionada = "CLINICA";
            }

            else if (preferencia.Contains("prefTipoEmpresarial"))
            {
                tipoPreferencia = "SERVICIO";
                preferenciaSeleccionada = "EMPRESARIAL";
            }

            else if (preferencia.Contains("prefTipoIPS"))
            {
                tipoPreferencia = "SERVICIO";
                preferenciaSeleccionada = "IPS";
            }



            else if (preferencia.Contains("prefGeneroFemenino"))
            {
                tipoPreferencia = "GENERO";
                preferenciaSeleccionada = "FEMENINO";
            }

            else if (preferencia.Contains("prefGeneroMasculino"))
            {
                tipoPreferencia = "GENERO";
                preferenciaSeleccionada = "MASCULINO";
            }



            else if (preferencia.Contains("prefDiagMedicina"))
            {
                tipoPreferencia = "DIAGNOSTICO";
                preferenciaSeleccionada = "MEDICINA";
            }

            else if (preferencia.Contains("prefDiagMadre"))
            {
                tipoPreferencia = "DIAGNOSTICO";
                preferenciaSeleccionada = "MADRE";
            }

            else if (preferencia.Contains("prefDiagNeuro"))
            {
                tipoPreferencia = "DIAGNOSTICO";
                preferenciaSeleccionada = "NEURO";
            }

            else if (preferencia.Contains("prefDiagOncologico"))
            {
                tipoPreferencia = "DIAGNOSTICO";
                preferenciaSeleccionada = "ONCOLOGICO";
            }
            else if (preferencia.Contains("prefDiagPsiquiatrico"))
            {
                tipoPreferencia = "DIAGNOSTICO";
                preferenciaSeleccionada = "PSIQUIATRIA";
            }

            else if (preferencia.Contains("prefDiagQuirurgico"))
            {
                tipoPreferencia = "GENERO";
                preferenciaSeleccionada = "QUIRURGICO";
            }



            else if (preferencia.Contains("prefMascostas"))
            {
                tipoPreferencia = "MASCOTAS";
                preferenciaSeleccionada = "MASCOTAS";
            }



            else if (preferencia.Contains("prefCondCateter"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "CATETER";
            }
            else if (preferencia.Contains("prefCondColostomia"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "COLOSTOMIA";
            }
            else if (preferencia.Contains("pCondDisVisual"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "DISCAPACIDAD VISUAL";
            }
            else if (preferencia.Contains("prefCondDisAuditiva"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "DISCAPACIDAD AUDITIVA";
            }
            else if (preferencia.Contains("prefCondDrenes"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "DRENES";
            }
            else if (preferencia.Contains("prefCondGluco"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "GLUCOMETRÍA";
            }
            else if (preferencia.Contains("prefCondMedica"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "MEDICACIÓN APLICACIÓN ENDOVENOSA";
            }
            else if (preferencia.Contains("prefCondNefro"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "NEFROSTOMIA";
            }
            else if (preferencia.Contains("prefCondOxigeno"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "OXIGENO";
            }
            else if (preferencia.Contains("prefCondSonGastro"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "SONDA GASTROSTOMÍA";
            }
            else if (preferencia.Contains("prefCondSonNaso"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "SONDA NASO GÁSTRICA";
            }
            else if (preferencia.Contains("prefCondSonVesical"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "SONDA VESICAL";
            }
            else if (preferencia.Contains("prefCondSonTraqueo"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "TRAQUEOSTOMÍA";
            }
            else if (preferencia.Contains("Sonda Orogástrica"))
            {
                tipoPreferencia = "CONDICION";
                preferenciaSeleccionada = "SONDA OROGASTRICA";
            }


            List<string> lidPreferencia = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Se busca el id de la preferencia
            query = "SELECT idpreferencia FROM saratyc.preferencias WHERE tipopreferencia = '" + tipoPreferencia + "'" + " AND preferencia = '" + preferenciaSeleccionada + "'";

            lidPreferencia = conexionMySQL.consultarSaratyc(query);

            if (!lidPreferencia.Count().Equals(0))
            {
                idPreferencia = Int32.Parse(lidPreferencia.ElementAt(0));
            }
            else
            {
                idPreferencia = 0;
            }

            return idPreferencia;
        }

        private int obteneridTema(string tema)
        {
            string query;
            int idTipoTema = 0;
            int idTema = 0;
            string tipoTema = "";

            //Se valida si el penultimo caracter es un numero
            bool a = Char.IsDigit(tema, tema.Length-2);

            //Si es un numero los 2 ultimos caracteres son numero, o sea es un numero de 2 cifras
            if (a)
            {
                //O sea el id son los ultimos 2 numeros
                idTipoTema = Int32.Parse(tema.Substring(tema.Length - 2,2));
            }
            else
            {
                //caso contrario el id es solo el ultimo numero
                idTipoTema = Int32.Parse(tema.Substring(tema.Length - 1, 1));
            }

            //---------------------------//
            //Se obtiene el tipo de tema si es condicion        
            if (tema.ToUpper().Contains("OC1") || tema.ToUpper().Contains("AC1"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC2") || tema.ToUpper().Contains("AC2"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC3") || tema.ToUpper().Contains("AC3"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC4") || tema.ToUpper().Contains("AC4"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC5") || tema.ToUpper().Contains("AC5"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC6") || tema.ToUpper().Contains("AC6"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC7") || tema.ToUpper().Contains("AC7"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC8") || tema.ToUpper().Contains("AC8"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC9") || tema.ToUpper().Contains("AC9"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC10") || tema.ToUpper().Contains("AC10"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC11") || tema.ToUpper().Contains("AC11"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC12") || tema.ToUpper().Contains("AC12"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC13") || tema.ToUpper().Contains("AC13"))
            {
                tipoTema = "Condicion";
            }
            else if (tema.ToUpper().Contains("OC14") || tema.ToUpper().Contains("AC4"))
            {
                tipoTema = "Condicion";
            }

            //---------------------------//
            //Se obtiene el tipo de tema si es diagnostico        
            if (tema.ToUpper().Contains("OD1") || tema.ToUpper().Contains("AD1"))
            {
                tipoTema = "Diagnostico";
            }
            else if (tema.ToUpper().Contains("OD2") || tema.ToUpper().Contains("AD2"))
            {
                tipoTema = "Diagnostico";
            }
            else if (tema.ToUpper().Contains("OD3") || tema.ToUpper().Contains("AD3"))
            {
                tipoTema = "Diagnostico";
            }
            else if (tema.ToUpper().Contains("OD4") || tema.ToUpper().Contains("AD4"))
            {
                tipoTema = "Diagnostico";
            }
            else if (tema.ToUpper().Contains("OD5") || tema.ToUpper().Contains("AD5"))
            {
                tipoTema = "Diagnostico";
            }
            else if (tema.ToUpper().Contains("OD6") || tema.ToUpper().Contains("AD6"))
            {
                tipoTema = "Diagnostico";
            }

            //---------------------------//
            //Se obtiene el tipo de tema si es acompañamiento        
            if (tema.ToUpper().Contains("OA1") || tema.ToUpper().Contains("AA1"))
            {
                tipoTema = "Acompañamiento";
            }
            else if (tema.ToUpper().Contains("OA2") || tema.ToUpper().Contains("AA2"))
            {
                tipoTema = "Acompañamiento";
            }
            else if (tema.ToUpper().Contains("OA3") || tema.ToUpper().Contains("AA3"))
            {
                tipoTema = "Acompañamiento";
            }
            else if (tema.ToUpper().Contains("OA4") || tema.ToUpper().Contains("AA4"))
            {
                tipoTema = "Acompañamiento";
            }
            else if (tema.ToUpper().Contains("OA5") || tema.ToUpper().Contains("AA5"))
            {
                tipoTema = "Acompañamiento";
            }

            //---------------------------//
            //Se obtiene el tipo de tema si es conciencia        
            if (tema.ToUpper().Contains("OCC1") || tema.ToUpper().Contains("ACC1"))
            {
                tipoTema = "Conciencia";
            }
            else if (tema.ToUpper().Contains("OCC2") || tema.ToUpper().Contains("ACC2"))
            {
                tipoTema = "Conciencia";
            }
            else if (tema.ToUpper().Contains("OCC3") || tema.ToUpper().Contains("ACC3"))
            {
                tipoTema = "Conciencia";
            }
            else if (tema.ToUpper().Contains("OCC4") || tema.ToUpper().Contains("ACC4"))
            {
                tipoTema = "Conciencia";
            }
            else if (tema.ToUpper().Contains("OCC5") || tema.ToUpper().Contains("ACC5"))
            {
                tipoTema = "Conciencia";
            }



            List<string> lidTema = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Se busca el id del tema
            query = "SELECT idtema FROM  saratyc.tema WHERE tipotema = '" + tipoTema + "' AND idTipoTema = '" + idTipoTema + "'";

            lidTema = conexionMySQL.consultarSaratyc(query);
            
            if (!lidTema.Count().Equals(0))
            {
                idTema = Int32.Parse(lidTema.ElementAt(0));
            }
            else
            {
                idTema = 0;
            }            

            return idTema;
        }


        internal string obtenerIdEnferdata(string cedula)
        {
            string query;
            List<string> LidEnferdata = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Obtiene el id del auxiliar en Enferdata 
            query = "SELECT \r\n    id\r\nFROM\r\n    `enferdata-web`.`Enfermera`\r\nWHERE\r\n    id = '\"+cedula+\"'";

            LidEnferdata= conexionMySQL.consultarSaratyc(query);

            string idEnferdata = LidEnferdata.ElementAt(0);
            return idEnferdata;

        }

        internal string guardarDatosAuxiliar(string idEnferdata, string contextura, string personalidad, string desplazamiento, string levantarObjetos, string conocimientoC1, string conocimientoC2, string conocimientoC3, string conocimientoC4, string conocimientoC5, string conocimientoC6, string conocimientoC7, string conocimientoC8, string conocimientoC9, string conocimientoC10, string conocimientoC11, string conocimientoC12, string conocimientoC13, string conocimientoC14, string conocimientoD1, string conocimientoD2, string conocimientoD3, string conocimientoD4, string conocimientoD5, string conocimientoD6, string conocimientoA1, string conocimientoA2, string conocimientoA3, string conocimientoA4, string conocimientoA5, string conocimientoCC1, string conocimientoCC2, string conocimientoCC3, string conocimientoCC4, string conocimientoCC5, string experienciaC1, string experienciaC2, string experienciaC3, string experienciaC4, string experienciaC5, string experienciaC6, string experienciaC7, string experienciaC8, string experienciaC9, string experienciaC10, string experienciaC11, string experienciaC12, string experienciaC13, string experienciaC14, string experienciaD1, string experienciaD2, string experienciaD3, string experienciaD4, string experienciaD5, string experienciaD6, string experienciaA1, string experienciaA2, string experienciaA3, string experienciaA4, string experienciaA5, string experienciaCC1, string experienciaCC2, string experienciaCC3, string experienciaCC4, string experienciaCC5, string prefTipoDiurno, string prefTipoNocturno, string prefCompFam, string prefCompEmp, string prefCompSin, string prefEdadBinomio, string prefEdadAdultos, string prefEdadNiños, string prefTipoDomicilio, string prefTipoClinica, string prefTipoEmpresarial, string prefTipoIPS, string prefGeneroFemenino, string prefGeneroMasculino, string prefDiagMedicina, string prefDiagQuirurgico, string prefDiagOncologico, string prefDiagPsiquiatrico, string prefDiagMadre, string prefDiagNeuro, string prefConcAlerta, string prefConcComa, string prefConConfusion, string prefConcEstuporoso, string prefConcVegeta, string prefMascostas, string prefCondCateter, string prefCondColostomia, string prefCondDisVisual,string prefCondDisVAuditiva, string prefCondDrenes, string prefCondGluco, string prefCondMedica, string prefCondNefro, string prefCondOxigeno, string prefCondSonGastro, string prefCondSonNaso, string prefCondSonOro, string prefCondSonVesical, string prefCondSonTraqueo)
        {
            string OK = "";

            string query;
            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Se borran primero los datos del auxiliar
            query = "DELETE FROM `saratyc`.`preferenciasauxiliar` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`conocimiento` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`experiencia` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`contexturaauxiliar` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`personalidadauxiliar` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`desplazamientoauxiliar` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "DELETE FROM `saratyc`.`levantarobjetosauxiliar` WHERE (`idauxiliar` = '" + idEnferdata + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            /////

            query = "INSERT INTO `saratyc`.`contexturaauxiliar` (`idauxiliar`, `contextura`) VALUES ('" + idEnferdata + "','" + contextura + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`personalidadauxiliar` (`idauxiliar`, `personalidad`) VALUES ('" + idEnferdata + "','" + personalidad + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`desplazamientoauxiliar` (`idauxiliar`, `desplazamiento`) VALUES ('" + idEnferdata + "','" + desplazamiento + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`levantarobjetosauxiliar` (`idauxiliar`, `levantarobjetos`) VALUES ('" + idEnferdata + "','" + levantarObjetos + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC1)) + "','" + conocimientoC1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC2)) + "','" + conocimientoC2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC3)) + "','" + conocimientoC3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC4)) + "','" + conocimientoC4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC5)) + "','" + conocimientoC5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC6)) + "','" + conocimientoC6 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC7)) + "','" + conocimientoC7 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC8)) + "','" + conocimientoC8 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC9)) + "','" + conocimientoC9 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC10)) + "','" + conocimientoC10 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC11)) + "','" + conocimientoC11 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC12)) + "','" + conocimientoC12 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC13)) + "','" + conocimientoC13 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoC14)) + "','" + conocimientoC14 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD1)) + "','" + conocimientoD1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD2)) + "','" + conocimientoD2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD3)) + "','" + conocimientoD3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD4)) + "','" + conocimientoD4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD5)) + "','" + conocimientoD5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoD6)) + "','" + conocimientoD6 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoA1)) + "','" + conocimientoA1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoA2)) + "','" + conocimientoA2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoA3)) + "','" + conocimientoA3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoA4)) + "','" + conocimientoA4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoA5)) + "','" + conocimientoA5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoCC1)) + "','" + conocimientoCC1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoCC2)) + "','" + conocimientoCC2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoCC3)) + "','" + conocimientoCC3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoCC4)) + "','" + conocimientoCC4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`conocimiento` (`idauxiliar`, `idtema`,`conocimiento`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(conocimientoCC5)) + "','" + conocimientoCC5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            //inserta experiencias

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC1)) + "','" + experienciaC1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC2)) + "','" + experienciaC2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC3)) + "','" + experienciaC3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC4)) + "','" + experienciaC4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC5)) + "','" + experienciaC5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC6)) + "','" + experienciaC6 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC7)) + "','" + experienciaC7 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC8)) + "','" + experienciaC8 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC9)) + "','" + experienciaC9 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC10)) + "','" + experienciaC10 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC11)) + "','" + experienciaC11 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC12)) + "','" + experienciaC12 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC13)) + "','" + experienciaC13 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaC14)) + "','" + experienciaC14 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD1)) + "','" + experienciaD1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD2)) + "','" + experienciaD2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD3)) + "','" + experienciaD3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD4)) + "','" + experienciaD4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD5)) + "','" + experienciaD5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaD6)) + "','" + experienciaD6 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaA1)) + "','" + experienciaA1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaA2)) + "','" + experienciaA2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaA3)) + "','" + experienciaA3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaA4)) + "','" + experienciaA4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaA5)) + "','" + experienciaA5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaCC1)) + "','" + experienciaCC1 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaCC2)) + "','" + experienciaCC2 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaCC3)) + "','" + experienciaCC3 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaCC4)) + "','" + experienciaCC4 + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`experiencia` (`idauxiliar`, `idtema`,`experiencia`) VALUES ('" + idEnferdata + "','" + obteneridTema(nameof(experienciaCC5)) + "','" + experienciaCC5 + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            //Guarda las preferencias

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoDiurno)) + "','" + prefTipoDiurno + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoNocturno)) + "','" + prefTipoNocturno + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCompFam)) + "','" + prefCompFam + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCompEmp)) + "','" + prefCompEmp + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCompSin)) + "','" + prefCompSin + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefEdadBinomio)) + "','" + prefEdadBinomio + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefEdadAdultos)) + "','" + prefEdadAdultos + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefEdadNiños)) + "','" + prefEdadNiños + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoDomicilio)) + "','" + prefTipoDomicilio + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoClinica)) + "','" + prefTipoClinica + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoEmpresarial)) + "','" + prefTipoEmpresarial + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefTipoIPS)) + "','" + prefTipoIPS + "')";
            OK = conexionMySQL.insertarSaratyc(query);


            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefGeneroFemenino)) + "','" + prefGeneroFemenino + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefGeneroMasculino)) + "','" + prefGeneroMasculino + "')";
            OK = conexionMySQL.insertarSaratyc(query);


            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagMedicina)) + "','" + prefDiagMedicina + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagMadre)) + "','" + prefDiagMadre + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagNeuro)) + "','" + prefDiagNeuro + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagOncologico)) + "','" + prefDiagOncologico + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagPsiquiatrico)) + "','" + prefDiagPsiquiatrico + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefDiagQuirurgico)) + "','" + prefDiagQuirurgico + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefMascostas)) + "','" + prefMascostas + "')";
            OK = conexionMySQL.insertarSaratyc(query);



            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondCateter)) + "','" + prefCondCateter + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondColostomia)) + "','" + prefCondColostomia + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondDisVisual)) + "','" + prefCondDisVisual + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondDisVAuditiva)) + "','" + prefCondDisVAuditiva + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondDrenes)) + "','" + prefCondDrenes + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondGluco)) + "','" + prefCondGluco + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondMedica)) + "','" + prefCondMedica + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondNefro)) + "','" + prefCondNefro + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondOxigeno)) + "','" + prefCondOxigeno + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondSonGastro)) + "','" + prefCondSonGastro + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondSonNaso)) + "','" + prefCondSonNaso + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondSonOro)) + "','" + prefCondSonOro + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondSonTraqueo)) + "','" + prefCondSonTraqueo + "')";
            OK = conexionMySQL.insertarSaratyc(query);

            query = "INSERT INTO `saratyc`.`preferenciasauxiliar` (`idauxiliar`, `idpreferencia`,`preferencia`) VALUES ('" + idEnferdata + "','" + obteneridPreferencia(nameof(prefCondSonVesical)) + "','" + prefCondSonVesical + "')";
            OK = conexionMySQL.insertarSaratyc(query);


            return OK;
        }
    }
}
