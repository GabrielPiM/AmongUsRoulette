using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmongUsRoulette.Models
{
    public class Modo
    {
        public Modo()
        {
            HowToPlayImpostor = new List<string>();
            HowToPlayCrewmate = new List<string>();
            HowToPlayBoth = new List<string>();
        }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Map { get; set; }
        public string Imposter { get; set; }
        public string ConfirmEjects { get; set; }
        public string NumberOfEmergencyMeetings { get; set; }
        public string EmergencyCooldown { get; set; }
        public string PlayerSpeed { get; set; }
        public string DiscussionTime { get; set; }
        public string VotingTime { get; set; }
        public string CrewmateVision { get; set; }
        public string ImposterVision { get; set; }
        public string KillCooldown { get; set; }
        public string KillDistance { get; set; }
        public string VisualTasks { get; set; }
        public string CommonTasks { get; set; }
        public string LongTasks { get; set; }
        public string ShortTasks { get; set; }
        public List<string> HowToPlayImpostor { get; set; }
        public List<string> HowToPlayCrewmate { get; set; }

        public List<string> HowToPlayBoth { get; set; }
    }
}
