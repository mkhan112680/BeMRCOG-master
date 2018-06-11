using BeMRCOG.Code;
using System.Web;
using System.Web.Mvc;

namespace BeMRCOG
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UserAuthorizeAttribute());
        }
    }
}
