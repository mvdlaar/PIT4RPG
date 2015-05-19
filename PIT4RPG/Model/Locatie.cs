using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public enum LocatieSoort { Stad, Dorp, Kerker, Grasland, Bos, Berg, Woestijn, Moeras, Zee, Strand, Wolkenveld, Overig, Elders }
    
    public class Locatie
    {
        private string naam;
        private LocatieSoort soort;
        private List<Locatie> gekoppeldeLocaties;
        
        private List<Character> characters;
        private List<Monster> monsters;

        public List<Character> Characters
        {
            get { return characters; }
            set { characters = value; }
        }

        public List<Monster> Monsters
        {
            get { return monsters; }
            set { monsters = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public LocatieSoort Soort
        {
            get { return soort; }
            set { soort = value; }
        }

        public List<Locatie> GekoppeldeLocaties
        {
            get { return gekoppeldeLocaties; }
            set { gekoppeldeLocaties = value; }
        }
    }
}
