using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.Modelos
{
    public class clsGame
    {
        public int id { get; set; }
        public string homeTeam { get; set; }
        public int homeGoalCount { get; set; }
        public string awayTeam { get; set; }
        public int awayGoalCount { get; set; }
        public string stadiumGame { get; set; }
        public bool statusGame { get; set; }

        public clsGame(int idNw, 
            string homeTeamNw, 
            string awayTeamNw,
            string stadiumGameNw)
        {
            this.id = idNw;
            this.homeTeam = homeTeamNw;
            this.homeGoalCount = 0;
            this.awayTeam = awayTeamNw;
            this.awayGoalCount = 0;
            this.stadiumGame = stadiumGameNw;
            this.statusGame = true;
        }
    }
}
