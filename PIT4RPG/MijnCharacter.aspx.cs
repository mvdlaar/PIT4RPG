using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PIT4RPG.Model;

namespace PIT4RPG
{
    public partial class MijnCharacter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbxUitrusting.Items.Clear();

            if (Session["mijnCharacter"] != null)
            {
                Character mijnCharacter = (Character)Session["mijnCharacter"];
                lbNaam.Text = mijnCharacter.Naam;
                lbLeeftijd.Text = mijnCharacter.Leeftijd.ToString();
                foreach (Uitrusting u in mijnCharacter.Uitrustingen)
                {
                    lbxUitrusting.Items.Add(u.Naam);
                }
            }
            else
            {
                lbNaam.Text = "";
                lbLeeftijd.Text = "";
            }
        }
    }
}