using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Database;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Repository_Service
{
    class StudentService
    {
        private MyDatabase db = new MyDatabase();

        public List<Student> GetStudents()
        {
            return db.Students;
        }
        public void CreateStudent(Student student)
        {
            db.Students.Add(student);
        }
        public static void AddStudentToCourse(Student student, Course course)
        {
            course.StudentsList.Add(student);
        }

        public List<Student> PrintStudentsInCourse(Course course)
        {
            return course.StudentsList;
        }
        public static void AddStudentToAssignment(Student student, Assignment assignment)
        {
            assignment.StudentsList.Add(student);
        }
    }
}
