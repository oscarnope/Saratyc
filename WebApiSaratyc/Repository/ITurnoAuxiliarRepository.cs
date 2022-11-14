using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSaratyc.Models;

namespace WebApiSaratyc.Repository
{
    public interface ITurnoAuxiliarRepository
    {
        TurnoAuxiliar GetTurnoAuxiliar(int id);
    }
}
