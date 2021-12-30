using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Controllers;

namespace Vasou_Iosif_Individual_Project_Part_A.Applications
{
    class SyntheticDataApplication
    {
        public static void Run()
        {
            Controller controller = new Controller();

            Console.ForegroundColor = ConsoleColor.Yellow;
            var hasEntered = false;
            while (hasEntered == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("PRIVATE SCHOOL SYSTEM");
                Console.WriteLine("\n" + "What would you like to do?");
                Console.WriteLine("\n" + "1)Create a Student."
                                + "\n" + "2)Create a Trainer."
                                + "\n" + "3)Create an Assignment."
                                + "\n" + "4)Create a Course."
                                + "\n" + "5)Print All Students."
                                + "\n" + "6)Print All Trainers."
                                + "\n" + "7)Print All Assignments."
                                + "\n" + "8)Print All Courses."
                                + "\n" + "9)Add Student to Course."
                                + "\n" + "10)Print Students in Course."
                                + "\n" + "11)Add Trainers to Course."
                                + "\n" + "12)Print Trainers in Course."
                                + "\n" + "13)Add Assignments to Course."
                                + "\n" + "14)Print Assignments per Student."
                                + "\n" + "15)Add Assignment to Student."
                                + "\n" + "16))Print List of Students that belong to more than one courses."
                                + "\n" + "17)Enter an Assignment Date to check which Students need to submit."
                                + "\n" + "18)Exit.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n" + "Choose an action from above: ");

                var menuSelection = Console.ReadLine();
                if (menuSelection == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CREATING A STUDENT" + "\n");
                    controller.CreateStudent();
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CREATING A TRAINER" + "\n");
                    controller.CreateTrainer();
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CREATING AN ASSIGNMENT" + "\n");
                    controller.CreateAssignment();
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "4")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CREATING A COURSE" + "\n");
                    controller.CreateCourse();
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "5")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE STUDENTS" + "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    controller.ReadAllStudents();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "6")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE TRAINERS" + "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    controller.ReadAllTrainers();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "7")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE ASSIGNMENTS"+ "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    controller.ReadAllAssignments();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "8")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + "PRINTING THE COURSES" + "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    controller.ReadAllCourses();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "9")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ADDING STUDENT TO COURSE" + "\n");
                    controller.AddStudentToCourse();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "10")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING STUDENTS IN COURSE" + "\n");
                    controller.PrintStudentsInCourse();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "11")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ADDING A TRAINER TO A COURSE" + "\n");
                    controller.AddTrainerToCourse();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "12")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING TRAINERS PER COURSE" + "\n");
                    controller.PrintTrainersPerCourse();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "13")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ADDING ASSIGNMENT TO COURSE" + "\n");
                    controller.AddAssignmentToCourse();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "14")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING ASSIGNMENTS PER STUDENT" + "\n");
                    controller.PrintAssignmentsPerStudent();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "15")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ADD ASSIGNMENT TO STUDENT " + "\n");
                    controller.AddAssignmentToStudent();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "16")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PRINTING A LIST OF STUDENTS THAT BELONG TO MORE THAN ONE COURSE " + "\n");
                    controller.printStudentsBelongingInMoreThanOneCourses();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "17")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PRINTING THE STUDENTS NEEDED TO SUBMIT ASSIGNMENTS IN YOUR WEEK OF CHOISE " + "\n");
                    controller.PrintStudentsWithAssignmentDeadline();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }
                if (menuSelection == "18")
                {
                    hasEntered = true;
                }
            }
        }
    }
}
