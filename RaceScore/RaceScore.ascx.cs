using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Purplecs.Modules.RaceScore
{
    public partial class RaceScore :  RaceScoreModuleBase 
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMainPage_Click(object sender, EventArgs e)
        {
            Response.Redirect(DotNetNuke.Common.Globals.NavigateURL(TabId));
        }
    }
}