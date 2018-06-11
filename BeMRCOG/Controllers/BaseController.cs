using BeMRCOG.Code;
using BeMRCOG.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeMRCOG.Controllers
{
    public class BaseController : Controller
    {
        public ContextUser ContextUser
        {
            get
            {
                return (this.User as ContextUser);
            }
        }
    }
}