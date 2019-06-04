using ArqDota2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArqDota2.Interfaces
{
    public interface IApiCampeonato
    {
        Task<IList<Campeonato>> BuscarCampeonatosAtivos();
        Task<IList<Player>> BuscarPlayers();
        Task<Campeonato> VisualizarCampeonato();
    }
}
