using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class CourseRepository : BaseRepository
    {
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