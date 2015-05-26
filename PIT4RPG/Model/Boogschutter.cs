using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public class Boogschutter: Character
    {
        public Boogschutter() : base()
        {
            Uitrusting boog = new Uitrusting();
            boog.Naam = "Basale boog";
            Uitrustingen.Add(boog);

            Levens = 30;
            Aanval = 7;
            Verdediging = 1;
        }
    }
}
