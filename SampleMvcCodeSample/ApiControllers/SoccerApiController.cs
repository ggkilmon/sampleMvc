using BizStreamCodeSample.Core;
using BizStreamCodeSample.Core.Services;
using BizStreamCodeSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BizStreamCodeSample.ApiControllers
{
    public class SoccerApiController : ApiController
    {
        public List<PlayerModel> GetAllPlayers()
        {
            Facade f = new Facade();
            return f.PlayerService.GetAllPlayers();
        }

        public PlayerModel GetPlayer(int? id)
        {
            if (!id.HasValue)
            {
                id = 1;
            }

            Facade f = new Facade();
            return f.PlayerService.GetPlayer(id.Value);
        }
    }
}
