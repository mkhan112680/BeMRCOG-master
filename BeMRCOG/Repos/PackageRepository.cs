using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Repos
{
    public class PackageRepository : BaseRepository
    {
        public void AddDefaultPackage(int courseID)
        {
            //var defaultPckgID =
            //    Entites.tblPackages.Where(p => p.PACKAGE_NAME == "Full Package").SingleOrDefault().PACKAGE_ID;

            var fullPackageName = "Full Package";

            var dnewPackage = new tblPackage();
            dnewPackage.PACKAGE_NAME = fullPackageName;
            Entites.tblPackages.Add(dnewPackage);
            Entites.SaveChanges();

            Entites.tblCoursePackages.Add(new tblCoursePackage()
            {
                PACKAGE_ID = dnewPackage.PACKAGE_ID,
                COURSE_ID = courseID
            });
            Entites.SaveChanges();
        }
        public int AddNewPackage(Models.Package package)
        {
            var newpackage = Entites.tblPackages.Add(new tblPackage()
            {
                PACKAGE_NAME = package.Name,
                PACKAGE_PRICE = package.Price,
            });
            Entites.SaveChanges();

            Entites.tblPackageModuleCounts.Add(new tblPackageModuleCount()
            {
                 PACKAGE_ID = newpackage.PACKAGE_ID,
                 MODULE_COUNT = package.ModuleCount
            });
            Entites.SaveChanges();

            return newpackage.PACKAGE_ID;
        }

          public void AddPackagesToCourse(int courseID, List<int> packageIDs)
        {
            //delete first
            //var lstToDelete = Entites.tblCoursePackages.Where(c => c.COURSE_ID == courseID).ToList();
            //Entites.tblCoursePackages.RemoveRange(lstToDelete);
            //Entites.SaveChanges();
            //adding
            foreach (var packageID in packageIDs)
            {
                Entites.tblCoursePackages.Add(new  tblCoursePackage()
                {
                     COURSE_ID = courseID,
                     PACKAGE_ID = packageID
                });
            }
            Entites.SaveChanges();
        }
    }
}