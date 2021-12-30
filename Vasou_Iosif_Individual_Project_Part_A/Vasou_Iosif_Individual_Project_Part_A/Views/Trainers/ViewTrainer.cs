using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Views.Trainers
{
    class ViewTrainer
    {
        static public void PrintTrainers(List<Trainer> TrainersList)
        {
            foreach (Trainer trainer in TrainersList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine("\n" + "Trainer NR: " + (TrainersList.IndexOf(trainer) + 1) + ")");
                Console.WriteLine("First Name: " + trainer.FirstName
                    + "\n" + "Last Name: " + trainer.LastName + "\n"
                    + "subject: " + trainer.Subject);
                Console.WriteLine("------------------------------------------");
            }
        }
        public static Trainer  CreateTrainer()
        {
            Trainer obj = null;
            try
            {
                Console.Clear();
                Console.Write("Enter Trainer's first Name: ");
                var firstNameInput = Console.ReadLine();
                Console.Write("Enter Trainer's last Name: ");
                var lastNameInput = Console.ReadLine();
                Console.Write("Enter subject: ");
                var subjectInput = Console.ReadLine();

                obj = new Trainer(firstNameInput, lastNameInput, subjectInput);
                return obj;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Parameter");
            }
            return obj;
        }
        public static Trainer GetTrainerInfo(List<Trainer> TrainerList)
        {
            Trainer obj = null;
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                foreach (Trainer trainer in TrainerList)
                {
                    Console.WriteLine((TrainerList.IndexOf(trainer) + 1) + ")" +$" {trainer.FirstName}" + $" {trainer.LastName}");
                }
                Console.Write("\n" + "Choose a number from the Trainer's list above: ");
                var trainertNr = (Convert.ToInt32(Console.ReadLine()) - 1);
                obj = TrainerList[trainertNr];
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number entered");
                Console.ReadKey();
            }
            return obj;
        }
        public static void PrintTrainersInCourse(List<Course> coursesList)
        {
            foreach (Course course in coursesList)
            {
                Console.WriteLine("\n" + "------------------------------------------");
                Console.WriteLine($"{course.Title} Assignments: "+"\n");
                foreach (Trainer trainer in course.TrainersList)
                {
                    Console.WriteLine("\n" + "First Name: " + trainer.FirstName
                        + "\n" + "Last Name: " + trainer.LastName + "\n"
                        + "Subject: " + trainer.Subject);
                    Console.WriteLine("------------------------------------------");
                }

            }
        }
    }
}
