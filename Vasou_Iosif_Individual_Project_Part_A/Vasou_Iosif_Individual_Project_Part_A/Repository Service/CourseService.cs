using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Database;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Repository_Service
{
    class CourseService
    {
        private MyDatabase db = new MyDatabase();

        public List<Course> GetCourses()
        {
            return db.Courses;
        }
        public void CreateCourse(Course course)
        {
            db.Courses.Add(course);
        }
        
    }
}
