using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizStreamCodeSample.Model
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public int JerseyNumber { get; set; }
        public List<StatsModel> Stats { get; set; }
    }
}
