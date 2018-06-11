using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class TopicRepository : BaseRepository
    {
        public List<Models.Topic> GetAll()
        {
            return Entites
                     .tblTopics
                     .Select(m => new Models.Topic()
                     {
                         ID = m.TOPIC_ID,
                         Name = m.TOPIC_NAME
                     }).ToList();

        }

        public string AddTopic(string name)
        {
            string error = string.Empty;
            try
            {
                Entites.tblTopics.Add(new  tblTopic()
                {
                     TOPIC_NAME = name
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