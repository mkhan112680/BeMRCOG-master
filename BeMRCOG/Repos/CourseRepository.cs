using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class CourseRepository : BaseRepository
    {
        public Models.Course GetCourseDetails(int courseID)
        {
            Models.Course returnCourse = new Models.Course();

            returnCourse = Entites
                     .tblCourses
                     .Select(c => new Models.Course()
                     {
                         ID = c.COURSE_ID,
                         Name = c.COURSE_NAME,
                         //ModuleCount = Entites.tblCourseModules.Where(m => m.COURSE_ID == c.COURSE_ID).ToList().Count
                     })
                     .Where(c => c.ID == courseID)
                     .SingleOrDefault();

            returnCourse.Modules.AddRange(GetModules(courseID));
            returnCourse.Packages.AddRange(GetPackages(courseID));

            return returnCourse;

        }
        public List<Models.Course> GetAll()
        {
            return Entites
                     .tblCourses
                     .Select(c => new Models.Course()
                     {
                         ID = c.COURSE_ID,
                         Name = c.COURSE_NAME,
                         ModuleCount  = Entites.tblCourseModules.Where(m => m.COURSE_ID == c.COURSE_ID).ToList().Count

                     }).ToList();
        }

        public List<Models.Module> GetModules(int courseID)
        {
            var lst = (from cm in Entites.tblCourseModules
                       join m in Entites.tblModules on cm.MODULE_ID equals m.MODULE_ID
                       where
                       cm.COURSE_ID == courseID
                       select new Models.Module()
                       {
                           ID = m.MODULE_ID,
                           Name = m.MODULE_NAME,
                       }).ToList();

            return lst;
        }

        public List<Models.Package> GetPackages(int courseID)
        {
            var lst = (from cp in Entites.tblCoursePackages
                       join p in Entites.tblPackages on cp.PACKAGE_ID equals p.PACKAGE_ID
                       where
                       cp.COURSE_ID == courseID
                       select new Models.Package()
                       {
                           ID = p.PACKAGE_ID,
                           Name = p.PACKAGE_NAME,
                           Price = p.PACKAGE_PRICE,
                           ModuleCount = Entites
                                            .tblPackageModuleCounts
                                            .Where(x => x.PACKAGE_ID == p.PACKAGE_ID)
                                            .FirstOrDefault() == null ? 0 :
                                            
                                            Entites
                                            .tblPackageModuleCounts
                                            .Where(x => x.PACKAGE_ID == p.PACKAGE_ID)
                                            .FirstOrDefault().MODULE_COUNT

                       }).ToList();

            return lst;
        }

        public int AddCourse(string name)
        {
            int newCourseID = 0;
            string error = string.Empty;
            try
            {
                var newCourse = Entites.tblCourses.Add(new tblCourse()
                {
                    COURSE_NAME = name,
                     
                });
                Entites.SaveChanges();

                newCourseID = newCourse.COURSE_ID;
            }
            catch (Exception exc)
            {
                error = exc.ToString();
            }
            return newCourseID;
        }

        public void AddModulesToCourse(int courseID, List<int> moduleIDs)
        {
            //delete first
            var lstToDelete = Entites.tblCourseModules.Where(c => c.COURSE_ID == courseID).ToList();
            Entites.tblCourseModules.RemoveRange(lstToDelete);
            Entites.SaveChanges();
            //adding
            foreach (var moduleID in moduleIDs)
            {
                Entites.tblCourseModules.Add(new tblCourseModule()
                {
                     COURSE_ID = courseID,
                     MODULE_ID = moduleID
                });
            }
            Entites.SaveChanges();
        }
    }
}