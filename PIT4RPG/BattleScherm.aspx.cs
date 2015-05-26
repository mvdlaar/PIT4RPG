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
            mijnMonster = new Monster();
        }
    }
}