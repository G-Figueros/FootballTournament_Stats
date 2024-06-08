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
        public string visitTeam { get; set; }
        public int visitGoalCount { get; set; }
        public string stadiumGame { get; set; }
        public bool statusFinallyGame { get; set; }

        public clsGame(int idNw, 
            string homeTeamNw, 
            string visitTeamNw,
            string stadiumGameNw)
        {
            this.id = idNw;
            this.homeTeam = homeTeamNw;
            this.homeGoalCount = 0;
            this.visitTeam = visitTeamNw;
            this.visitGoalCount = 0;
            this.stadiumGame = stadiumGameNw;
            this.statusFinallyGame = false;
        }
    }
}
