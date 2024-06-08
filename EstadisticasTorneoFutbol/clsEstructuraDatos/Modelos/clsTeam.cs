using clsEstructuraDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.Modelos
{
    public class clsTeam : Comparador
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string league { get; set; }
        public string stadium { get; set; }
        public int points { get; set; }
        public int homeMatches { get; set; }
        public int victoryHomeMatches { get; set; }
        public int loseHomeMatches { get; set; }
        public int awayMatches { get; set; }
        public int victoryAwayMatches { get; set; }
        public int loseAwayMatches { get; set; }

        public clsTeam(int id, string nameNw, string countryNw, string leagueNw, string stadium)
        {
            this.id = id;
            this.name = nameNw;
            this.country = countryNw;
            this.league = leagueNw;
            this.stadium = stadium;
            this.points = 0;
            this.homeMatches = 0;
            this.victoryHomeMatches = 0;
            this.loseHomeMatches = 0;
            this.awayMatches = 0;
            this.victoryAwayMatches = 0;
            this.loseAwayMatches = 0;
        }

        public bool igualQue(string q)
        {
            return this.name == q;
        }
        public bool menorQue(string q)
        {
            if (this.name.CompareTo(q) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool mayorQue(string q)
        {
            if (this.name.CompareTo(q) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool igualQue(int q)
        {
            return this.id == q;
        }
        public bool menorQue(int q)
        {
            return this.id < q;
        }
        public bool mayorQue(int q)
        {
            return this.id > q;
        }
        public bool igualQue(object q)
        {
            clsTeam q2 = (clsTeam)q;
            return this.id == q2.id;
        }
        public bool menorQue(object q)
        {
            clsTeam q2 = (clsTeam)q;
            return this.id < q2.id;
        }
        public bool mayorQue(object q)
        {
            clsTeam q2 = (clsTeam)q;
            return this.id > q2.id;
        }
    }
}
