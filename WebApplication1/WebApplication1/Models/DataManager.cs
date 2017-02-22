using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class DataManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band{ Id = 1, Name = "Pink Floyd", Description = "Awesome stuff.. "},
            new Band{ Id = 2, Name = "Led Zeppelin", Description = "Ambient stuff"},
            new Band{ Id = 3, Name = "Iron Maiden", Description = "Hard Stuff"}

        };

        public static Band GetBand(string name)
        {
            return bands.SingleOrDefault(b => b.Name == name);
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
