using Purplecs.Modules.RaceScore.Components;
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
            if(!IsPostBack)
            { 
            int Requestid = 0;
            var requestID= Request.QueryString["RaceID"];
            RaceScoreController ctrl = new RaceScoreController();

                //   rptScores.DataSource = ctrl.GetItems(ModuleId);
                //   rptScores.DataBind();

                if (int.TryParse(requestID, out Requestid))
                {

                    var Items = ctrl.GetScores(Requestid).ToList();
                    RacersItemController racers = new RacersItemController();

                    RacesItemController races = new RacesItemController();
                    var Race = races.GetItem(Requestid, ModuleId);

                    var Racers = racers.GetItems(ModuleId);

                    foreach (var item in Racers)
                    {
                        if (!Items.Any(x => x.Racer_ID == item.ID))
                        {
                            Items.Add(new RaceScoreItemSelect()
                            {
                                Racer_ID = item.ID,
                                Racer_Name = item.Name,
                                Race_ID = Race.ID,
                                Race_Name = Race.Name,
                                Score = 0
                            });
                        }
                    }

                    //add to data scource
                    rptScores.DataSource = Items;
                    rptScores.DataBind();
                }

            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            int Requestid = 0;
            var requestID = Request.QueryString["RaceID"];
            if (int.TryParse(requestID, out Requestid))
            {
                foreach (RepeaterItem item in rptScores.Items)
                {

                    var score = int.Parse(( item.FindControl("txtScore") as TextBox).Text);
                    var scoreid = int.Parse((item.FindControl("hfScoreID") as HiddenField).Value);
                    var racerid = int.Parse((item.FindControl("hfRacerID") as HiddenField).Value);
                    var tc = new RaceScoreController();
                    var t = new RaceScoresItem()
                    {
                        Racer_ID = racerid,
                        Race_ID = Requestid,
                        Score = score

                    };
                    if (scoreid > 0)
                    {
                        t.ID = scoreid;

                        tc.UpdateItem(t);
                    }
                    else
                    {
                        tc.CreateItem(t);
                    }
                }
            }
        }
    }
}