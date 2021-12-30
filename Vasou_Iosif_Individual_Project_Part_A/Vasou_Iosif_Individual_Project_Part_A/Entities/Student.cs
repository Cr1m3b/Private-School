using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_Individual_Project_Part_A.Entities
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        public List<Assignment> AssignmentsList = new List<Assignment>();

        public Student(string firstName, string lastName, DateTime dateOfBirth, double tuitionFees)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.TuitionFees = tuitionFees;
        }
    }
}
