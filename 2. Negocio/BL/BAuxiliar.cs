using Saratyc._4._Datos.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._2._Negocio.BL
{
    class BAuxiliar
    {
        public List<string> cargarAuxiliares()
        {
            Utilidades ut = new Utilidades();
            DAuxiliar dAuxiliar = new();

            string rutaArchivos = "C:\\Users\\Julian\\source\\repos\\Saratyc\\Saratyc\\Resources";
            string archivoAuxiliares = "Auxiliares.txt";
            string ruta = rutaArchivos + "\\" + archivoAuxiliares;

            List<string> lAuxiliares = new List<string>();
            //dAuxiliar.listaAuxiliares(ruta, lAuxiliares);
            return lAuxiliares;

        }

        public void mostrarPacientes()
        {

        }

        public List<string> buscarAuxiliarEnferdata(string identificacionAuxiliar)
        {
            DAuxiliar dAuxiliar = new();
            List<string> lAuxiliar = new List<string>();
            lAuxiliar=dAuxiliar.buscarAuxiliarEnferdata(identificacionAuxiliar);
            return lAuxiliar;
        }

        public List<string> buscarAuxiliarSaratyc(string identificacionAuxiliar)
        {
            DAuxiliar dAuxiliar = new();
            List<string> lAuxiliar = new List<string>();
            lAuxiliar = dAuxiliar.buscarAuxiliaSaratyc(identificacionAuxiliar);
            return lAuxiliar;
        }

        internal string obtenerIdEnferdata(string cedula)
        {
            DAuxiliar dAuxiliar = new();
            string idEnferdata = dAuxiliar.obtenerIdEnferdata(cedula);
            return idEnferdata;
        }

        internal string guardarDatosAuxiliar(string idEnferdata, string contextura, string personalidad, string desplazamiento, string levantarObjetos, string conocimientoC1, string conocimientoC2, string conocimientoC3, string conocimientoC4, string conocimientoC5, string conocimientoC6, string conocimientoC7, string conocimientoC8, string conocimientoC9, string conocimientoC10, string conocimientoC11, string conocimientoC12, string conocimientoC13, string conocimientoC14, string conocimientoD1, string conocimientoD2, string conocimientoD3, string conocimientoD4, string conocimientoD5, string conocimientoD6, string conocimientoA1, string conocimientoA2, string conocimientoA3, string conocimientoA4, string conocimientoA5, string conocimientoCC1, string conocimientoCC2, string conocimientoCC3, string conocimientoCC4, string conocimientoCC5, string experienciaC1, string experienciaC2, string experienciaC3, string experienciaC4, string experienciaC5, string experienciaC6, string experienciaC7, string experienciaC8, string experienciaC9, string experienciaC10, string experienciaC11, string experienciaC12, string experienciaC13, string experienciaC14, string experienciaD1, string experienciaD2, string experienciaD3, string experienciaD4, string experienciaD5, string experienciaD6, string experienciaA1, string experienciaA2, string experienciaA3, string experienciaA4, string experienciaA5, string experienciaCC1, string experienciaCC2, string experienciaCC3, string experienciaCC4, string experienciaCC5, string prefTipoDiurno, string prefTipoNocturno, string prefCompFam, string prefCompEmp, string prefCompSin, string prefEdadBinomio, string prefEdadAdultos, string prefEdadNiños, string prefTipoDomicilio, string prefTipoClinica, string prefTipoEmpresarial, string prefTipoIPS, string prefGeneroFemenino, string prefGeneroMasculino, string prefDiagMedicina, string prefDiagQuirurgico, string prefDiagOncologico, string prefDiagPsiquiatrico, string prefDiagMadre, string prefDiagNeuro, string prefConcAlerta, string prefConcComa, string prefConConfusion, string prefConcEstuporoso, string prefConcVegeta, string prefMascostas, string prefCondCateter, string prefCondColostomia, string prefCondDisVisual, string prefCondDisVAuditiva,string prefCondDrenes, string prefCondGluco, string prefCondMedica, string prefCondNefro, string prefCondOxigeno, string prefCondSonGastro, string prefCondSonNaso, string prefCondSonOro, string prefCondSonVesical, string prefCondSonTraqueo)
        {
            DAuxiliar dAuxiliar = new();
            string OK = dAuxiliar.guardarDatosAuxiliar(idEnferdata, contextura, personalidad, desplazamiento, levantarObjetos, conocimientoC1, conocimientoC2, conocimientoC3, conocimientoC4, conocimientoC5, conocimientoC6, conocimientoC7, conocimientoC8, conocimientoC9, conocimientoC10, conocimientoC11, conocimientoC12, conocimientoC13, conocimientoC14, conocimientoD1, conocimientoD2, conocimientoD3, conocimientoD4, conocimientoD5, conocimientoD6, conocimientoA1, conocimientoA2, conocimientoA3, conocimientoA4, conocimientoA5, conocimientoCC1, conocimientoCC2, conocimientoCC3, conocimientoCC4, conocimientoCC5, experienciaC1, experienciaC2, experienciaC3, experienciaC4, experienciaC5, experienciaC6, experienciaC7, experienciaC8, experienciaC9, experienciaC10, experienciaC11, experienciaC12, experienciaC13, experienciaC14, experienciaD1, experienciaD2, experienciaD3, experienciaD4, experienciaD5, experienciaD6, experienciaA1, experienciaA2, experienciaA3, experienciaA4, experienciaA5, experienciaCC1, experienciaCC2, experienciaCC3, experienciaCC4, experienciaCC5, prefTipoDiurno, prefTipoNocturno, prefCompFam, prefCompEmp, prefCompSin, prefEdadBinomio, prefEdadAdultos, prefEdadNiños, prefTipoDomicilio, prefTipoClinica, prefTipoEmpresarial, prefTipoIPS, prefGeneroFemenino, prefGeneroMasculino, prefDiagMedicina, prefDiagQuirurgico, prefDiagOncologico, prefDiagPsiquiatrico, prefDiagMadre, prefDiagNeuro, prefConcAlerta, prefConcComa, prefConConfusion, prefConcEstuporoso, prefConcVegeta, prefMascostas, prefCondCateter, prefCondColostomia, prefCondDisVisual, prefCondDisVAuditiva, prefCondDrenes, prefCondGluco, prefCondMedica, prefCondNefro, prefCondOxigeno, prefCondSonGastro, prefCondSonNaso, prefCondSonOro, prefCondSonVesical, prefCondSonTraqueo);
            return OK;
        }
    }
}
