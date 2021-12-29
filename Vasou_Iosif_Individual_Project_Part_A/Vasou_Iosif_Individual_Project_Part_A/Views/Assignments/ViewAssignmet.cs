using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Views.Assignments
{
    class ViewAssignmet
    {
        static public void PrintAssignments(List<Assignment> AssignmentList)
        {
            foreach (Assignment assignment in AssignmentList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "Title: " + assignment.Title
                    + "\n" + "Description: " + assignment.Description + "\n"
                    + "Submission Date: " + assignment.SubmissionDate + "\n"
                    + "Oral Mark: " + assignment.OralMark + "\n"
                    + "Total Mark: " + assignment.TotalMark);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static Assignment CreateAssignment()
        {
            Assignment obj = null;
            try
            {
                Console.Clear();
                Console.Write("Enter title of the Assignment: ");
                var titleInput = Console.ReadLine();
                Console.Write("Enter description of the Assignment: ");
                var descriptionInput = Console.ReadLine();
                Console.Write("Enter submission date (dd/MM/yyyy): ");
                var subDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Oral Mark: ");
                var oralInput = float.Parse(Console.ReadLine());
                Console.Write("Total Mark: ");
                var totalInput = float.Parse(Console.ReadLine());

                obj = new Assignment(titleInput, descriptionInput, subDateInput, oralInput, totalInput);
                return obj;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Parameter");
            }
            return obj;
        }
        //public static void AddAssignmentToCourse(List<Course> CourseList, List<Assignment> AssignmentList)
        //{
        //    try
        //    {
        //        Console.Clear();
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("ADDING ASSIGNMENT TO COURSE" + "\n");

        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        foreach (Course course in CourseList)
        //        {
        //            Console.WriteLine((CourseList.IndexOf(course) + 1) + ")" + $" {course.Title}");
        //        }
        //        Console.Write("\n" + "Choose a number from the Course list above: ");
        //        var courseNr = (Convert.ToInt32(Console.ReadLine()) - 1);

        //        Console.WriteLine("");
        //        foreach (Assignment assignment in AssignmentList)
        //        {
        //            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
        //        }
        //        Console.Write("\n" + "Choose a number from the Assignment list above: ");
        //        var assNr = (Convert.ToInt32(Console.ReadLine()) - 1);

        //        CourseList[courseNr].AssignmentsList.Add(AssignmentList[assNr]);

        //        Console.WriteLine("\n" + AssignmentList[assNr].Title + " " + "has been added to" + CourseList[courseNr].Title);

        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.Write("\n" + "Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Invalid number entered");
        //        Console.ReadKey();
        //    }
        //}
        public static Assignment GetAssignmentInfo(List<Assignment> AssignmentList)
        {
            Assignment obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                foreach (Assignment assignment in AssignmentList)
                {
                    Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                }
                Console.Write("\n" + "Choose a number from the Assignment's list above: ");
                var assNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                obj = AssignmentList[assNr];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number entered");
                Console.ReadKey();
            }
            return obj;
        }
        public static void PrintAssignmentsPerStudent(List<Student> studentsList)
        {
            foreach (Student student in studentsList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine($"{student.FirstName} {student.LastName} Assignments: ");
                foreach (Assignment assignment in student.AssignmentsList)
                {
                    Console.WriteLine("\n" + "Title: " + assignment.Title
                        + "\n" + "Description: " + assignment.Description + "\n"
                        + "Submission Date: " + assignment.SubmissionDate + "\n"
                        + "Oral Mark: " + assignment.OralMark + "\n"
                        + "Total Mark: " + assignment.TotalMark);
                    Console.WriteLine("------------------------------------------");
                }
                
            }
        }
    }
}
