using BizStreamCodeSample.Data.Models;
using BizStreamCodeSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizStreamCodeSample.Core.TransformServices
{
    public class PlayerTransformService
    {
        internal PlayerModel Transform(Player entity)
        {
            PlayerModel model = new PlayerModel()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Age = entity.Age,
                Position = ConvertPostionToString(entity.Position),
                Height = ConvertHeightToString(entity.Height),
                Weight = entity.Weight,
                JerseyNumber = entity.JerseyNumber,
                Stats = new List<StatsModel>(),
            };

            if (entity.Stats != null && entity.Stats.Count > 0)
            {
                foreach (var s in entity.Stats)
                {
                    model.Stats.Add(new StatsModel()
                    {
                        Year = s.Year,
                        Club = s.Club,
                        GamesPlayed = s.GamesPlayed,
                        Goals = s.GoalsScored,
                        Minutes = s.Minutes,
                        Shots = s.Shots,
                    });
                }
            }

            return model;
        }

        internal List<PlayerModel> Transform(List<Player> entities)
        {
            List<PlayerModel> models = new List<PlayerModel>();
            foreach (var e in entities)
            {
                models.Add(Transform(e));
            }

            return models;
        }

        private string ConvertPostionToString(PlayerPosition position)
        {
            if (position == null)
            {
                return string.Empty;
            }

            return position.ToString();
        }

        private string ConvertHeightToString(PlayerHeight height)
        {
            if (height == null)
            {
                return string.Empty;
            }

            return string.Format("{0}' {1}\"", height.Feet, height.Inches);
        }
    }
}
