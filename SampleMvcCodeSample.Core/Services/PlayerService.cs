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

namespace SampleMvcCodeSample.Core.Services
{
    public class PlayerService
    {
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
                    return TransformService.Transform(players);
                }
            }
            catch (Exception ex)
            {
                //log error
            }

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
                //log error
            }

            return new PlayerModel();
        }

        private IPlayerRepository Repository { get; set; }
        private PlayerTransformService TransformService { get; set; }
    }
}
