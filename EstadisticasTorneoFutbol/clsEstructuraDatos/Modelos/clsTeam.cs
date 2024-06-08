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
        public string tournament { get; set; }
        public string stadium { get; set; }
        public int points { get; set; }
        public int matches { get; set; }
        public int victoryMatches { get; set; }
        public int loseMatches { get; set; }
        public int drawMatches { get; set; }

        public clsTeam(int id, string nameNw, string countryNw, string tournamentNw, string stadium)
        {
            this.id = id;
            this.name = nameNw;
            this.country = countryNw;
            this.tournament = tournamentNw;
            this.stadium = stadium;
            this.points = 0;
            this.matches = 0;
            this.victoryMatches = 0;
            this.loseMatches = 0;
            this.drawMatches = 0;
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
