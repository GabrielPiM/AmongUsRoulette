using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmongUsRoulette.Models.IndexInfos
{

    public class IndexInfos
    {
        public IndexInfos()
        {
            Modo = new ModoInfo();
            Footer = new FooterInfo();
        }

        public string Title { get; set; }
        public string ButtonText { get; set; }
        public string ScrollText { get; set; }
        public string ModeSelect { get; set; }
        public ModoInfo Modo { get; set; }
        public FooterInfo Footer { get; set; }

    }

    public class ModoInfo
    {
        public string RecommendConfig { get; set; }
        public string HowToPlay { get; set; }
        public string Impostor { get; set; }
        public string Crewmate { get; set; }

    }

    public class FooterInfo
    {
        public string MadeWith { get; set; }
        public string Disclaimer { get; set; }
        public string Privacy { get; set; }
        public string Contact { get; set; }

    }
}
