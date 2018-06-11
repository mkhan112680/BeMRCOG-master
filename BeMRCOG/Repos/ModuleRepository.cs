using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class ModuleRepository : BaseRepository
    {
        


        public List<Models.Module> GetAll()
        {
            return Entites
                     .tblModules
                     .Select(m => new Models.Module()
                     {
                         ID = m.MODULE_ID,
                         Name = m.MODULE_NAME,
                         TopicCount = Entites.tblModuleTopics.Where(mt => mt.MODULE_ID == m.MODULE_ID).ToList().Count
                     }).ToList();

        }

        public List<Models.Topic> GetTopics(int moduleID)
        {
            var lst = (from mt in Entites.tblModuleTopics
                       join t in Entites.tblTopics on mt.TOPIC_ID equals t.TOPIC_ID
                       where
                       mt.MODULE_ID == moduleID
                       select new Models.Topic()
                       {
                           ID = t.TOPIC_ID,
                           Name = t.TOPIC_NAME,
                       }).ToList();

            return lst;
        }

        public string AddModule(string name)
        {
            string error = string.Empty;
            try
            {
                Entites.tblModules.Add(new  tblModule()
                {
                     MODULE_NAME = name
                });
                Entites.SaveChanges();
            }
            catch (Exception exc)
            {
                error = exc.ToString();
            }
            return error;
        }
    }
}