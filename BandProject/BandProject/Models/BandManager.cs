using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandProject.Models
{
    public static class BandManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band{ Id = 1, Name = "Rolling stones", Description = "Classic rock"},
            new Band{ Id = 2, Name = "N.W.A", Description = "Classic rap"},
            new Band{ Id = 3, Name = "Wham", Description = "Classic Pop"}
        };

        public static Band GetBand(int id)
        {
            return bands.SingleOrDefault(b => b.Id == id);
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
