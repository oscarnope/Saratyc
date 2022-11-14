using WebApiSaratyc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSaratyc.Models;
using WebApiSaratyc.Repository;

namespace WebApiSaratyc.Controllers
{


    public class TurnoAuxiliarController : ApiController
    {
        //List<TurnoAuxiliar> listaTurnoAuxiliar = new List<TurnoAuxiliar>();

        //private readonly ITurnoAuxiliarRepository _turnoAuxiliarRepository;
        private readonly ITurnoAuxiliarRepository repository = new TurnoAuxiliarRepository();

        public TurnoAuxiliarController()
        {
        }
            public TurnoAuxiliar GetTurnoAuxiliar(int id)
        {
            var turnoAuxiliar = repository.GetTurnoAuxiliar(id);
            return turnoAuxiliar;
        }

    }
}
