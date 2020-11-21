using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmongUsRoulette.Models.MapInfos
{
    public class Map
    {
        public Map()
        {
            Utilities = new List<InfoListModel>();
        }

        public string Name { get; set; }
        public InfoModel TheMap { get; set; }
        public InfoListModel VisualTasks { get; set; }
        public InfoModel TheVents { get; set; }
        public InfoListModel Sabotage { get; set; }
        public List<InfoListModel> Utilities { get; set; }

    }
}
