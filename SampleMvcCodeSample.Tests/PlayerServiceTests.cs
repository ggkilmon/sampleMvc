using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMvcCodeSample.Core.Services;
using SampleMvcCodeSample.Core.TransformServices;
using SampleMvcCodeSample.Data.Repositories.Interfaces;
using SampleMvcCodeSample.Model;

namespace SampleMvcCodeSample.Tests
{
    [TestClass]
    public class PlayerServiceTests
    {
        private PlayerService _playerService;

        [TestInitialize]
        public void TestInit()
        {
            IPlayerRepository testRepo = new TestPlayerRepository();
            _playerService = new PlayerService(testRepo, new PlayerTransformService());
        }

        [TestMethod]
        public void TestGetAllPlayers()
        {
            List<PlayerModel> players = _playerService.GetAllPlayers();

            Assert.IsTrue(players.Count > 0);
        }

        [TestMethod]
        public void TestGetPlayer_Exist()
        {
            int id = 1;
            PlayerModel player = _playerService.GetPlayer(id);

            Assert.IsTrue(player.Id == id);
        }

        [TestMethod]
        public void TestGetPlayer_DoesntExist()
        {
            int id = 2;
            PlayerModel player = _playerService.GetPlayer(id);

            Assert.IsFalse(player.Id == id);
        }
    }
}