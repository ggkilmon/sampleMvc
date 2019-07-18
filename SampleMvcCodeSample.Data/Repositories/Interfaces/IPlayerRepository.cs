using SampleMvcCodeSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvcCodeSample.Data.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        List<Player> GetAllPlayers();
        Player GetPlayer(int id);
    }
}
