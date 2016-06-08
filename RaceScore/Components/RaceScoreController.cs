using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purplecs.Modules.RaceScore.Components
{
    public class RaceScoreController
    {
        //select scores.*, racer.Name, race1.Name from RaceScores_Race_Scores as scores join RaceScores_Racers as racer on scores.Racer_ID= racer.ID

 // join RaceScores_Races as race1 on race1.ID= scores.Race_ID where scores.Race_ID= 5
        public IEnumerable<RaceScoreItemSelect> GetScores(int RaceID)
        {
            IEnumerable<RaceScoreItemSelect> t = null;
            using (IDataContext ctx = DataContext.Instance())
            {
               
                var query = "select scores.*, racer.Name as Racer_Name, race1.Name as Race_Name from RaceScores_Race_Scores as scores join RaceScores_Racers as racer on scores.Racer_ID = racer.ID" +
                    $" join RaceScores_Races as race1 on race1.ID = scores.Race_ID where scores.Race_ID ={RaceID} ";
               t= ctx.ExecuteQuery<RaceScoreItemSelect> (System.Data.CommandType.Text, query, "");
            }
            return t;
        }

        public void UpdateItem(RaceScoresItem t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                t.CreatedDate = DateTime.Now;
                var rep = ctx.GetRepository<RaceScoresItem>();
                rep.Update(t);
            }
        }

        public IEnumerable<RaceScoresItem> GetItems(int moduleId)
        {
            IEnumerable<RaceScoresItem> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RaceScoresItem>();
                t = rep.Get(moduleId);
            }
            return t;
        }

        public RaceScoresItem GetItem(int itemId, int moduleId)
        {
            RaceScoresItem t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RaceScoresItem>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }

        internal void CreateItem(RaceScoresItem t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                t.CreatedDate = DateTime.Now;
                var rep = ctx.GetRepository<RaceScoresItem>();
                rep.Insert(t);
            }
        }
    }
}