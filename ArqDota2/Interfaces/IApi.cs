using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArqDota2.Interfaces
{
    public interface IApi
    {
        Task<IList<Campeonato>> BuscarCampeonatosAtivos();
    }
}
