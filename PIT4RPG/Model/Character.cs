using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT4RPG.Model
{
    public enum Geslacht { Vrouw, Man }
    public enum Klasse { Boogschutter = 0, Genezer = 1, Vechter = 2 }

    public abstract class Character
    {
        private Geslacht geslacht;
        private int leeftijd;
        private string naam;
        private int aanval;
        private int verdediging;
        private int levens;
        private List<Uitrusting> uitrustingen;
        private Klasse klasse;

        public Geslacht Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }

        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
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

        public int Levens
        {
            get { return levens; }
            set { levens = value; }
        }

        public List<Uitrusting> Uitrustingen
        {
            get { return uitrustingen; }
            set { uitrustingen = value; }
        }

        public Klasse Klasse
        {
            get { return klasse; }
            set { klasse = value; }
        }

        protected Character()
        {
            uitrustingen = new List<Uitrusting>();
        }

        public void Aanvallen(Monster slachtoffer)
        {
            slachtoffer.StelHPBij(this, BattleCalc(slachtoffer));
        }

        public int GewoonBattleCalc(Monster slachtoffer)
        {
            if (aanval > slachtoffer.Verdediging)
            {
                return aanval - slachtoffer.Verdediging;
            }
            else
            {
                return 0;
            }
        }

        public void StelHPBij(int schade)
        {
            levens -= schade;
        }
    }
}
