using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace BeMRCOG.Code
{
    public class ContextUser : ClaimsPrincipal
    {
        public ContextUser(IPrincipal principal) : base(principal)
        {
        }

        //public int LanguageID
        //{
        //    get
        //    {
        //        var user = (new SessionStore()).RetreiveFromSession();
        //        if (user == null)
        //        {
        //            user = new Models.User() { LanguageID = 1 };
        //        }
        //        return user.LanguageID;
        //    }
        //    set
        //    {
        //        var userToEdit = (new SessionStore()).RetreiveFromSession();
        //        if (userToEdit == null)
        //        {
        //            userToEdit = new Models.User() { LanguageID = value };
        //        }
        //        else
        //        {
        //            userToEdit.LanguageID = value;
        //        }
        //        (new SessionStore()).AddToSession(userToEdit);
        //    }
        //}

        public string UserName
        {
            get
            {
                string returnType = "";
                var envID = Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                if (envID != null)
                {
                    returnType = envID.Value;
                }
                return returnType;

            }
        }

        //public string PartyID
        //{
        //    get
        //    {
        //        string returnType = "";
        //        var envID = Claims.FirstOrDefault(x => x.Type == ClaimTypes.SerialNumber);
        //        if (envID != null)
        //        {
        //            returnType = envID.Value;
        //        }
        //        return returnType;

        //    }
        //}

        //public int EnvironmentID
        //{
        //    get
        //    {
        //        int returnType = 0;
        //        var envID = Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName);
        //        if (envID != null)
        //        {
        //            returnType = Int32.Parse(envID.Value);
        //        }
        //        return returnType;

        //    }
        //}

        public void Load()
        {
            
        }
    }
}