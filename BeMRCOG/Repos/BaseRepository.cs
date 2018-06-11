using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class BaseRepository
    {
        public BaseRepository()
        {
        }

        private DBBemrcogEntities ent = null;

        public DBBemrcogEntities Entites
        {
            get
            {
                if (ent == null)
                    ent = new DBBemrcogEntities();

                return ent;
            }
        }
    }
}