using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmongUsRoulette.Models.MapInfos;

namespace AmongUsRoulette.Models
{
    public class Map
    {
        public Map()
        {
            Infos = new List<MapInfo>();
        }

        public string Title { get; set; }
        public List<MapInfo> Infos { get; set; }

    }
}
