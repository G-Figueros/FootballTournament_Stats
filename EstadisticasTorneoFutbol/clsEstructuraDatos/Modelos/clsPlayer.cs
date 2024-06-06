using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.Modelos
{
    public class clsPlayer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int dorsal { get; set; }
        public string position { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }
        public int goals { get; set; }
        public int yellowCards { get; set; }
        public int redCards { get; set; }
        public int minutesPlayedHome { get; set; }
        public int minutesPlayedAlone { get; set; }


        public clsPlayer(int idNw, 
            string nameNw, 
            string lastnameNw,
            int dorsalNw,
            string positionNw,
            string nationalityNw,
            int ageNw)
        {
            this.id = idNw;
            this.name = nameNw;
            this.lastname = lastnameNw;
            this.dorsal = dorsalNw;
            this.position = positionNw;
            this.nationality = nationalityNw;
            this.age = ageNw;
            this.goals = 0;
            this.yellowCards = 0;
            this.redCards = 0;
            this.minutesPlayedHome = 0;
            this.minutesPlayedAlone = 0;
        }
    }
}