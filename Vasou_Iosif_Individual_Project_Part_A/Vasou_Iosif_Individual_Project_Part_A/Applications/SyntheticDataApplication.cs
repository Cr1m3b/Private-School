using System;
using System.Collections.Generic;
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
                                + "\n" + "3)Create Assignment."
                                + "\n" + "4)Create Course."
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
                                + "\n" + "16)Print Student per Assignment."
                                + "\n" + "17)Print List of Students that belong to more than one courses."
                                + "\n" + "18)Enter an Assignment Date to check which Students need to submit."
                                + "\n" + "19)Exit.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n" + "Choose an action from above: ");

                var menuSelection = Console.ReadLine();
                if (menuSelection == "1")
                {
                    controller.CreateStudent();
                }

                if (menuSelection == "2")
                {
                    controller.CreateTrainer();
                }

                if (menuSelection == "3")
                {
                    controller.CreateAssignment();
                }

                if (menuSelection == "4")
                {
                    controller.CreateCourse();
                }

                if (menuSelection == "5")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PRINTING THE STUDENTS");
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
                    Console.WriteLine("PRINTING THE TRAINERS");
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
                    Console.WriteLine("PRINTING THE ASSIGNMENTS");
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
                    Console.WriteLine("\n" + "PRINTING THE COURSES");
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
                    controller.
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
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ADD STUDENT TO ASSIGNMENT" + "\n");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Student student in StudentList)
                        {
                            Console.WriteLine((StudentList.IndexOf(student) + 1) + ")" + $" {student.FirstName}" + $" {student.LastName}");
                        }
                        Console.Write("\n" + "Choose a number from the Students list above: ");
                        var studentNr = (Convert.ToInt32(Console.ReadLine()) - 1);

                        Console.WriteLine("");
                        foreach (Assignment assignment in AssignmentList)
                        {
                            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                        }
                        Console.Write("Choose a number from the Assignment list above: ");
                        var assNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Assignment.AddStudentToAssignment(StudentList[studentNr], AssignmentList[assNr]);

                        Console.WriteLine("\n" + StudentList[studentNr].FirstName + " " + StudentList[studentNr].LastName + " " + "has been added to" + AssignmentList[assNr].Title);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "16")
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRINTING STUDENTS IN ASSIGNMENT" + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Assignment assignment in AssignmentList)
                        {
                            Console.WriteLine((AssignmentList.IndexOf(assignment) + 1) + ")" + $" {assignment.Title}");
                        }
                        Console.Write("\n" + "Choose a number from the Assignment list above: ");
                        var AssNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("");
                        Assignment.PrintStudentsInAssignment(AssignmentList[AssNr].StudentList);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n" + "Press any key to exit.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid number entered!");
                        Console.ReadKey();
                    }
                }

                if (menuSelection == "17")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var newList = CourseList[0].StudentList.Intersect(CourseList[2].StudentList);

                    foreach (Student student in newList)
                    {
                        Console.WriteLine("\n" + student.FirstName + " " + student.LastName + " is a student in more than one Course");
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n" + "Press any key to exit.");
                    Console.ReadKey();
                }

                if (menuSelection == "18")
                {
                    Console.Clear();
                    Console.Write("Enter date (dd/MM/yyyy): ");
                    DateTime myDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine("\n" + $"You have entered: {myDate}");

                    //Method to convert DateTime to Day of Week
                    int GetWeekOfYear(DateTime time)
                    {
                        DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
                        if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                        {
                            time = time.AddDays(3);
                        }
                        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                    }

                    int myWeek = GetWeekOfYear(myDate);
                    Console.WriteLine("\n" + $"Week number of the date that you have entered: {myWeek}");

                    foreach (Assignment assignment in AssignmentList)
                    {
                        int deadlineWeek = GetWeekOfYear(assignment.SubmissionDate);
                        Console.WriteLine("\n" + $"Week number of the {assignment.Title} assignment is: {deadlineWeek}");

                        if (myWeek == deadlineWeek)
                        {
                            foreach (Student student in assignment.StudentList)
                            {
                                Console.WriteLine("\n" + student.FirstName + " " + student.LastName + $" needs to deliver an {assignment.Title} assignment");
                                Console.Write("\n" + "Press any key to show next.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No student needs to submit in the given week");
                            Console.Write("\n" + "Press any key to show next.");
                            Console.ReadKey();
                        }
                    }
                }
                if (menuSelection == "19")
                {
                    hasEntered = true;
                }
            }
        }
    }
}
