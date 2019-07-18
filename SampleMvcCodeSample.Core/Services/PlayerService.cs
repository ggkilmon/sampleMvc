using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMvcCodeSample.Data.Repositories.Interfaces;
using SampleMvcCodeSample.Model;
using SampleMvcCodeSample.Data.Models;
using SampleMvcCodeSample.Data.Repositories;
using SampleMvcCodeSample.Core.TransformServices;
using NLog;

namespace SampleMvcCodeSample.Core.Services
{
    public class PlayerService
    {
        private Logger _logger = LogManager.GetLogger("SampleMvc");

        public PlayerService(IPlayerRepository playerRepo, PlayerTransformService playerTransSvc)
        {
            Repository = playerRepo;
            TransformService = playerTransSvc;
        }

        public List<PlayerModel> GetAllPlayers()
        {
            try
            {
                List<Player> players = Repository.GetAllPlayers();
                if (players != null && players.Count > 0)
                {
                    _logger.Debug($"Got {players.Count} players");
                    return TransformService.Transform(players);
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Couldn't get all players; {ex}");
            }

            _logger.Warn($"Returning an empty set of players");
            return new List<PlayerModel>();
        }

        public PlayerModel GetPlayer(int id)
        {
            try
            {
                Player player = Repository.GetPlayer(id);
                if (player != null)
                {
                    return TransformService.Transform(player);
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Couldn't get player; id: {id}; {ex}");
            }

            _logger.Warn($"Returning an empty player");
            return new PlayerModel();
        }

        private IPlayerRepository Repository { get; set; }
        private PlayerTransformService TransformService { get; set; }
    }
}
