using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Database;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Repository_Service
{
    class AssignmentService
    {
        private MyDatabase db = new MyDatabase();

        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }
        public void CreateAssignment(Assignment assignment)
        {
            db.Assignments.Add(assignment);
        }
        public static void AddAssignmentToStudent(Assignment assignment, Student student )
        {
            student.AssignmentsList.Add(assignment);
        }
        public static void AddAssignmentToCourse(Assignment assignment,Course course)
        {
            course.AssignmentsList.Add(assignment);
        }
    }
}
