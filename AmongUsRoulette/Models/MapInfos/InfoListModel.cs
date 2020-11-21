using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmongUsRoulette.Models.MapInfos
{
    public class InfoListModel
    {

        public InfoListModel()
        {
            Infos = new List<string>();
        }
        public string Title { get; set; }
        public List<String> Infos { get; set; }
        public string Img { get; set; }

    }
}
