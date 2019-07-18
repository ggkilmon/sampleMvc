using SampleMvcCodeSample.Core.Services;
using SampleMvcCodeSample.Core.TransformServices;
using SampleMvcCodeSample.Data.Repositories;
using SampleMvcCodeSample.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvcCodeSample.Core
{
    public class Facade
    {
        public PlayerService PlayerService
        {
            get
            {
                if (playerSvc == null)
                {
                    playerSvc = new PlayerService(PlayerRepository, PlayerTransformService);
                }

                return playerSvc;
            }
        }

        private IPlayerRepository PlayerRepository 
        {
            get
            {
                if (playerRepo == null)
                {
                    playerRepo = new PlayerRepository();
                }
                return playerRepo;
            }
        }

        private PlayerTransformService PlayerTransformService
        {
            get
            {
                if (playerTransSvc == null)
                {
                    playerTransSvc = new PlayerTransformService();
                }
                return playerTransSvc;
            }
        }

        private IPlayerRepository playerRepo;

        private PlayerService playerSvc;

        private PlayerTransformService playerTransSvc;
    }
}
