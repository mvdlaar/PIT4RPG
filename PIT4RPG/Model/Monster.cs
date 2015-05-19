using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public class Monster
    {
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
    }
}
