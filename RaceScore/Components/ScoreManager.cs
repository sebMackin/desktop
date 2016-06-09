using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purplecs.Modules.RaceScore.Components
{
    public class ScoreManager
    {
        public Score GetAllScores(int moduleid)
        {
            var RacersCtrl = new RacersItemController();
            var RacesCtrl = new RacesItemController();
            var ScoreCtrl = new RaceScoreController();

            var Racers = RacersCtrl.GetItems(moduleid);
            var Races = RacesCtrl.GetItems(moduleid);
            var Score = ScoreCtrl.GetItems(moduleid);
          

            var scoreobj = new Score() { Racers = Racers.ToList(), Races = Races.ToList(), ScoreList = Score.ToList() };
            return scoreobj;
        }
    }
}