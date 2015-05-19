using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PIT4RPG.Model;

namespace PIT4RPG
{
    public partial class MaakCharacter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlKlasse.Items.Add(Klasse.Boogschutter.ToString());
                ddlKlasse.Items.Add(Klasse.Genezer.ToString());
                ddlKlasse.Items.Add(Klasse.Vechter.ToString());
                ddlKlasse.SelectedIndex = 0;
            }
        }

        protected void btMaakCharacter_Click(object sender, EventArgs e)
        {
            Character nieuwCharacter;

            if (Session["mijnCharacter"] == null)
            {
                switch (ddlKlasse.SelectedIndex)
                {
                    case 0: 
                        nieuwCharacter = new Boogschutter();
                        nieuwCharacter.Klasse = Klasse.Boogschutter;
                        break;
                    case 1:
                        nieuwCharacter = new Genezer();
                        nieuwCharacter.Klasse = Klasse.Genezer;
                        break;
                    default:
                        nieuwCharacter = new Vechter();
                        nieuwCharacter.Klasse = Klasse.Vechter;
                        break;
                }
                Session.Add("mijnCharacter", nieuwCharacter);
            }

            nieuwCharacter = (Character)Session["mijnCharacter"];

            nieuwCharacter.Naam = tbNaam.Text;
        }
    }
}