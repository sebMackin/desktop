using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purplecs.Modules.RaceScore.Components
{
    public class Score
    {
        public List<RacersItem> Racers { get; set; }
        public List<RacesItem> Races { get; set; }
        public List<RaceScoresItem>ScoreList { get; set; }
        public int GetScore(int racerid,int raceid)
        {
            var item = ScoreList.FirstOrDefault(x => x.Racer_ID == racerid && x.Race_ID == raceid);
            return item == null ? 0 : item.Score;
        }
    }
}