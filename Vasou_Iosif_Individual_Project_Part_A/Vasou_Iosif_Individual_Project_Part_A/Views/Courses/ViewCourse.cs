using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Views.Courses
{
    class ViewCourse
    {
        static public void PrintCourses(List<Course> CourseList)
        {
            foreach (Course course in CourseList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("Course Title: " + course.Title
                    + "\n" + "Stream: " + course.Stream + "\n"
                    + "Type: " + course.Type + "\n"
                    + "Start Date: " + course.StartDate + "\n"
                    + "End Date: " + course.EndDate);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static Course CreateCourse()
        {
            Course obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter Course Title: ");
                var titleInput = Console.ReadLine();
                Console.Write("Enter Stream (C# or Java): ");
                var streamInput = Console.ReadLine();
                Console.Write("Enter Course Type (Full, Part): ");
                var typeInput = Console.ReadLine();
                Console.Write("Enter Course Start Date (dd/MM/yyyy): ");
                var startDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Enter Course End Date (dd/MM/yyyy): ");
                var endDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + $"The Course with Title: {titleInput} and Stream: {streamInput} has been created succesfully !!");

                obj = new Course(titleInput, streamInput, typeInput, startDateInput, endDateInput);
                return obj;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Parameter");
            }
            return obj;
        }
        public static Course GetCourseInfo(List<Course> courseList)
        {
            Course obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                foreach (Course course in courseList)
                {
                    Console.WriteLine((courseList.IndexOf(course) + 1) + ")" + $" {course.Title}.");
                }
                Console.Write("\n" + "Choose a number from the Course's list above: ");
                var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                obj = courseList[courseNr];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number entered");
                Console.ReadKey();
            }
            return obj;
        }
    }
}
