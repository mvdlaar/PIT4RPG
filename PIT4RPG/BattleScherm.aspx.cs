using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PIT4RPG.Model;

namespace PIT4RPG
{
    public partial class BattleScherm : System.Web.UI.Page
    {
        private Character mijnCharacter;
        private Monster mijnMonster;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mijnCharacter"] != null)
            {
                mijnCharacter = (Character)Session["mijnCharacter"];
            }
            else
            {
                throw new NullReferenceException();
            }
            if (Session["mijnMonster"] == null)
            {
                mijnMonster = new Hamster();
                Session["mijnMonster"] = mijnMonster;
            }
            else
            {
                mijnMonster = (Monster) Session["mijnMonster"];
            }
        }

        protected void btAanvallen_Click(object sender, EventArgs e)
        {
            mijnCharacter.Aanvallen(mijnMonster);
        }
    }
}