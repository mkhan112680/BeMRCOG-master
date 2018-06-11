using BeMRCOG.Models;
using BeMRCOG.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeMRCOG.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #region Courses
        public ActionResult Courses()
        {
            CourseRepository repo = new CourseRepository();
            List<Course> lstReturn = repo.GetAll();
            return Json(lstReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddCourse(string name, string description,  List<int> modules, List<int> packages)
        {
            string message = string.Empty;
            bool errored = false;
            CourseRepository repo = new CourseRepository();
            PackageRepository pckgRepo = new PackageRepository();

            if (string.IsNullOrEmpty(name))
            {
                errored = true;
                message = "Missing value";
            }
            else
            {
                try
                {
                    int newCourseID = repo.AddCourse(name );
                    if (modules != null && modules.Count > 0)
                    {
                        repo.AddModulesToCourse(newCourseID, modules);
                    }
                    pckgRepo.AddDefaultPackage(newCourseID);
                    if (packages != null && packages.Count > 0)
                    {
                        pckgRepo.AddPackagesToCourse(newCourseID, packages);
                    }
                }
                catch (Exception exc)
                {
                    errored = true;
                    message = exc.ToString();
                }
            }

            if (!errored)
                message = "Changes Saved";

            return Json(new {  Errored = errored, Message = message }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CourseDetail(int courseID)
        {
            CourseRepository repo = new CourseRepository();
            return Json(repo.GetModules(courseID), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AutoCompleteModule(string searchTerm)
        {
            List<AutoCompleteEntry> lstReturn = new List<AutoCompleteEntry>();
            List<Models.Module> lstModules = (new ModuleRepository()).GetAll();
            lstModules.Where(m => m.Name.ToLower().Contains(searchTerm.ToLower() )).ToList().ForEach(x => 
            {
                lstReturn.Add(new AutoCompleteEntry()
                {
                     ID = x.ID,
                     Name = x.Name
                });
            });
            return Json(lstReturn, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PreviewCourse(int courseID)
        {
            return PartialView("_PreviewCourse");
        }

        public ActionResult _NewPackage()
        {
            return PartialView("_NewPackage");
        }

        public ActionResult CreatePackage(Package pckg)
        {
            PackageRepository repo = new PackageRepository();
            string message = string.Empty;
            int newPackegID = 0;
            try
            {
                newPackegID =  repo.AddNewPackage(pckg);
            }
            catch (Exception exc)
            {
                message = exc.ToString();
            }
            return Json( new { Message=message, ID= newPackegID }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Modules
        public ActionResult ModuleDetail(int moduleID)
        {
            ModuleRepository repo = new ModuleRepository();
            return Json(repo.GetTopics(moduleID), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modules()
        {
            ModuleRepository repo = new ModuleRepository();
            List<Models.Module> lstReturn = repo.GetAll();
            return Json(lstReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddModule(string name)
        {
            ModuleRepository repo = new ModuleRepository();
            string message = string.Empty;
            bool errored = false;

            if (string.IsNullOrEmpty(name))
            {
                errored = true;
                message = "Missing value";
            }
            else
            {
                try
                {
                    repo.AddModule(name);
                }
                catch (Exception exc)
                {
                    errored = true;
                    message = exc.ToString();
                }
            }

            if (!errored)
                message = "Changes Saved";

            return Json(new { Errored = errored, Message = message }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Topics
        public ActionResult Topics()
        {
            TopicRepository repo = new TopicRepository();
            List<Models.Topic> lstReturn = repo.GetAll();
            return Json(lstReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddTopic(string name)
        {
            TopicRepository repo = new TopicRepository();
            string message = string.Empty;
            bool errored = false;

            if (string.IsNullOrEmpty(name))
            {
                errored = true;
                message = "Missing value";
            }
            else
            {
                try
                {
                    repo.AddTopic(name);
                }
                catch (Exception exc)
                {
                    errored = true;
                    message = exc.ToString();
                }
            }

            if (!errored)
                message = "Changes Saved";

            return Json(new { Errored = errored, Message = message }, JsonRequestBehavior.AllowGet);
        }
        #endregion 
    }
}