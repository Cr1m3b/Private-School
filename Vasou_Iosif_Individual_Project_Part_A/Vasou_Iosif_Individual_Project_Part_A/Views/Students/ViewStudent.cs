using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Views.Students
{
    class ViewStudent
    {
        public static void PrintStudents(List<Student> StudentsList)
        {
            foreach (Student student in StudentsList)
            {

                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "First Name: " + student.FirstName
                    + "\n" + "Last Name: " + student.LastName + "\n"
                    + "Date of Birth: " + student.DateOfBirth + "\n"
                    + "Tuition Fees: " + student.TuitionFees);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static Student CreateStudent()
        {
            Student obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter Student first Name: ");
                var firstNameInput = Console.ReadLine();
                Console.Write("Enter Student last Name: ");
                var lastNameInput = Console.ReadLine();
                DateTime birthDateInput;
                Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
                birthDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Enter tuition fees: ");
                var tuitionFeesInput = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + $"The Student with Firstname: {firstNameInput} and Lastname: {lastNameInput} has been created succesfully !!");

                obj = new Student(firstNameInput, lastNameInput, birthDateInput, tuitionFeesInput);
                return obj;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Parameter");
            }
            return obj;
        }
        public static Student GetStudentInfo(List<Student> StudentList)
        {
            Student obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                foreach (Student student in StudentList)
                {
                    Console.WriteLine((StudentList.IndexOf(student) + 1) + ")" + $" {student.FirstName}" + $" {student.LastName}");
                }
                Console.Write("\n" + "Choose a number from the Student's above: ");
                var studentNr = (Convert.ToInt16(Console.ReadLine()) - 1);
                obj = StudentList[studentNr];
                return obj;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number entered");
                Console.ReadKey();
            }
            return obj;
        }

        public static Course PrintStudentsInCourse(List<Course> CoursesList)
        {
            Course obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (Course course in CoursesList)
                {
                    Console.WriteLine((CoursesList.IndexOf(course) + 1) + ")" + $" {course.Title}");
                }
                Console.Write("\n" + "Choose a number from the Courses above: ");
                var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                obj = CoursesList[courseNr];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number entered");
                Console.ReadKey();
            }
            return obj;

        }

        public static void printStudentsBelongingInMoreThanOneCourses(List<Course> courseList)
        {
            var newList = courseList[0].StudentsList.Intersect(courseList[courseList.Count - 1].StudentsList);
            foreach (Student student in newList)
            {
                Console.WriteLine("\n" + student.FirstName + " " + student.LastName + " is a student in more than one Course");

            }
        }
    }
}
