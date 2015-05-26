using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public abstract class Monster
    {
        private int levens;
        private int aanval;
        private int verdediging;

        private List<Uitrusting> uitrustingen;
        private Locatie locatie;


        public Locatie Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public List<Uitrusting> Uitrustingen
        {
            get { return uitrustingen; }
            set { uitrustingen = value; }
        }

        public int Levens
        {
            get { return levens; }
            set { levens = value; }
        }

        public int Aanval
        {
            get { return aanval; }
            set { aanval = value; }
        }

        public int Verdediging
        {
            get { return verdediging; }
            set { verdediging = value; }
        }
    }
}
