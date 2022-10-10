using System;
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

        public List<string> buscarAuxiliar(string identificacion)
        {
            string query;
            List<string> lAuxiliares = new List<string>();

            ConexionMySQL conexionMySQL = new ConexionMySQL();

            //Consulta los datos de un auxiliar dada su identificacion
            query = "SELECT \r\n    Enfermera.id idEnferdata,\r\n    Enfermera.nombre nombre,\r\n    Enfermera.apellido apellido,\r\n    Enfermera.identificacion identificacion,\r\n    Enfermera.fechaNacimiento fechaNacimiento,\r\n    Genero.nombre genero,\r\n    Ciudad.nombre ciudad,\r\n    CiudadLocalidad.nombre localidad,\r\n    Enfermera.barrio barrio,\r\n    Enfermera.fechaNacimiento fechaNacimiento,\r\n    '' contextura,\r\n    (SELECT \r\n            CASE id\r\n                    WHEN 1 THEN 'Colombiano'\r\n                    WHEN 2 THEN 'Colombiano'\r\n                    WHEN 4 THEN 'Extranjero'\r\n                    WHEN 5 THEN 'Colombiano'\r\n                    WHEN 6 THEN 'Colombiano'\r\n                    WHEN 7 THEN 'Colombiano'\r\n                    WHEN 8 THEN 'Extranjero'\r\n                    WHEN 9 THEN 'Extranjero'\r\n                    ELSE 'Colombiano'\r\n                END AS nacionalidad\r\n        FROM\r\n            `enferdata-web`.`TipoIdentificacion` TipoIdentificacion\r\n        WHERE\r\n            Enfermera.tipoIdentificacionId = TipoIdentificacion.id) AS nacionalidad,\r\n    'SI' disponibilidad,\r\n    'Pendiente' personalidad\r\nFROM\r\n    `enferdata-web`.`Enfermera` Enfermera,\r\n    `enferdata-web`.`Genero` Genero,\r\n    `enferdata-web`.`Ciudad` Ciudad,\r\n    `enferdata-web`.`CiudadLocalidad` CiudadLocalidad\r\nWHERE\r\n    Enfermera.generoId = Genero.id\r\n        AND Enfermera.ciudadId = Ciudad.id\r\n        AND Enfermera.ciudadLocalidadId = CiudadLocalidad.id\r\n        AND Enfermera.activo = 1\r\n        AND Enfermera.identificacion = '1015396096'\r\nORDER BY identificacion\r\n\r\n";

            lAuxiliares = conexionMySQL.consultarEnferdata(query);

            return lAuxiliares;
        }

        /*
        public List<string> listaAuxiliares(string rutaArchivo, List<string> listaAuxiliares)
        {
            var auxiliares = File.ReadAllLines(rutaArchivo);

            foreach (var auxiliar in auxiliares)
            {
                var columns = auxiliar.Split(',').Where(c => c.Trim() != string.Empty).ToList();
                DAuxiliar A = new();
                A.nombres = columns[0].ToString();
                A.apellidos = columns[1].ToString();
                A.identificacion = columns[2].ToString();
                A.fechaNacimiento = columns[3].ToString();
                A.genero = columns[4].ToString();
                A.CondicionSalud = columns[5].ToString();
                A.ConCondicionSalud = columns[6].ToString();
                A.ExpCondicionSalud = columns[7].ToString();
                A.Diagnostico = columns[8].ToString();
                A.ConDiagnostico = columns[9].ToString();
                A.ExpDiagnostico = columns[10].ToString();
                A.Acompañamiento = columns[11].ToString();
                A.ConAcompañamiento = columns[12].ToString();
                A.ExpAcompañamiento = columns[13].ToString();
                A.localidad = columns[14].ToString();
                A.barrio = columns[15].ToString();
                A.restriccionDesplazamiento = columns[16].ToString();
                A.restriccionObjetos = columns[17].ToString();
                A.contextura = columns[18].ToString();
                A.nacionalidad = columns[19].ToString();
                A.disponibilidad = columns[20].ToString();
                A.personalidad = columns[21].ToString();
                A.prefTipoTurno = columns[22].ToString();
                A.prefTipoTurnoValor = columns[23].ToString();
                A.prefAcompañamiento = columns[24].ToString();
                A.prefAcompañamientoValor = int.Parse(columns[25]);
                A.prefEdad = columns[26].ToString();
                A.prefEdadValor = int.Parse(columns[27]);
                A.prefGenero = columns[28].ToString();
                A.prefGeneroValor = int.Parse(columns[29]);
                A.prefTipoServicio = columns[30].ToString();
                A.prefTipoServicioValor = int.Parse(columns[31]);
                A.prefGrupoDiagnostico = columns[32].ToString();
                A.prefGrupoDiagnosticoValor = int.Parse(columns[33]);
                A.prefCondicionSalud = columns[34].ToString();
                A.prefCondicionSaludValor = int.Parse(columns[35]);
                A.gustoMascotas = columns[36].ToString();
                A.interesCapacitacion = columns[37].ToString();
                A.interesCapacitacionValor = int.Parse(columns[38]);



                listaAuxiliares.Add(A.nombres + "," + A.apellidos + "," + A.identificacion + "," + A.fechaNacimiento + ","
                + A.genero + "," + A.CondicionSalud + "," + A.ConCondicionSalud + "," + A.ExpCondicionSalud + "," + A.Diagnostico + ","
                + A.ConDiagnostico + "," + A.ExpDiagnostico + "," + A.Acompañamiento + "," + A.ConAcompañamiento + "," + A.ExpAcompañamiento + "," + A.localidad + "," + A.barrio + "," + A.restriccionDesplazamiento + "," + A.restriccionObjetos + ","
                + A.contextura + "," + A.nacionalidad + "," + A.disponibilidad + "," + A.personalidad + "," + A.prefTipoTurno + "," + A.prefTipoTurnoValor + "," + A.prefTipoTurnoValor + "," + A.prefAcompañamiento + "," + "," + A.prefEdad + "," + A.prefEdadValor + "," 
                + A.prefGenero + "," + A.prefGeneroValor + "," + A.prefTipoServicio + "," + A.prefTipoServicioValor + "," + A.prefGrupoDiagnostico + "," + A.prefGrupoDiagnosticoValor + "," + A.prefCondicionSalud + "," + A.prefCondicionSaludValor + "," 
                + A.gustoMascotas + "," +  A.interesCapacitacion + "," + A.interesCapacitacionValor);
            }
            return listaAuxiliares;
        }
        */
    }
}
