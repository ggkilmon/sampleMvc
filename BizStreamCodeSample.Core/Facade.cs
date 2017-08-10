using BizStreamCodeSample.Core.Services;
using BizStreamCodeSample.Core.TransformServices;
using BizStreamCodeSample.Data.Repositories;
using BizStreamCodeSample.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizStreamCodeSample.Core
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
