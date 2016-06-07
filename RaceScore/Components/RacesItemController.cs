using System.Collections.Generic;
using DotNetNuke.Data;


namespace Purplecs.Modules.RaceScore.Components
{
    public class RacesItemController
    {

        public void CreateItem(RacesItem t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RacesItem>();
                rep.Insert(t);
            }
        }

        public void DeleteItem(int itemId, int moduleId)
        {
            var t = GetItem(itemId, moduleId);
            DeleteItem(t);
        }

        public void DeleteItem(RacesItem t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RacesItem>();
                rep.Delete(t);
            }
        }

        public IEnumerable<RacesItem> GetItems(int moduleId)
        {
            IEnumerable<RacesItem> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RacesItem>();
                t = rep.Get(moduleId);
            }
            return t;
        }

        public RacesItem GetItem(int itemId, int moduleId)
        {
            RacesItem t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RacesItem>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }

        public void UpdateItem(RacesItem t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<RacesItem>();
                rep.Update(t);
            }
        }
    }
}