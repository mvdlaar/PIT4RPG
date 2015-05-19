using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public class Uitrusting
    {
        private string naam;

        private Character character;
        private Monster monster;

        public Character Character
        {
            get { return Character; }
            set { Character = value; }
        }

        public Monster Monster
        {
            get { return monster; }
            set { monster = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    }
}