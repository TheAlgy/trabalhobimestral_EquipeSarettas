using ArqDota2.Interfaces;
using ArqDota2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArqDota2.Services
{
    public class Repositorio : IApiCampeonato
    {
        public Task<IList<Campeonato>> BuscarCampeonatosAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Player>> BuscarPlayers()
        {
            throw new NotImplementedException();
        }

        public Task<Campeonato> VisualizarCampeonato()
        {
            throw new NotImplementedException();
        }
    }
}
