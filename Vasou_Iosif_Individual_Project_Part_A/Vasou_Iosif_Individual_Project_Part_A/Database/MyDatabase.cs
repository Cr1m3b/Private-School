using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Database
{
    class MyDatabase
    {
        //Creating Lists
        public List<Assignment> Assignments = new List<Assignment>();
        public List<Course> Courses = new List<Course>();
        public List<Student> Students = new List<Student>();
        public List<Trainer> Trainers = new List<Trainer>();
        
        public MyDatabase()
        {
            //Creating Assignments
            var Assignment1 = new Assignment("Assignment1", "1st Assignment", new DateTime(2021, 07, 15), 50, 100);
            var Assignment2 = new Assignment("Assignment2", "2nd Assignment", new DateTime(2021, 05, 11), 60, 110);
            var Assignment3 = new Assignment("Assignment3", "3rd Assignment", new DateTime(2021, 06, 20), 55, 90);

            //Add Assignments to lists
            Assignments.Add(Assignment1);
            Assignments.Add(Assignment2);
            Assignments.Add(Assignment3);

            //Creating Courses
            var Course1 = new Course("Course1", "C#", "Full", new DateTime(2021, 03, 15), new DateTime(2021, 08, 28) );
            var Course2 = new Course("Course2", "Java", "Part", new DateTime(2021, 03, 01), new DateTime(2021, 08, 30) );
            var Course3 = new Course("Course3", "JavaScript", "Full", new DateTime(2021, 02, 26), new DateTime(2021, 08, 25) );

            //Add Courses to lists
            Courses.Add(Course1);
            Courses.Add(Course2);
            Courses.Add(Course3);

            //Creating Students
            Student Student1 = new Student("Marios", "Filiou", new DateTime(1989, 11, 15), 300);
            Student Student2 = new Student("Georgia", "Kostoglou", new DateTime(1990, 03, 24), 300);
            Student Student3 = new Student("Giorgos", "Georgiou", new DateTime(1992, 05, 07), 300);

            //Add Students to lists
            Students.Add(Student1);
            Students.Add(Student2);
            Students.Add(Student3);

            //Creating Trainers
            var Trainer1 = new Trainer("Kostas", "Kostoglou", "Introduction to Programming");
            var Trainer2 = new Trainer("Maria", "Georgiou", "Introduction to Data Bases");

            //Add Trainers to lists
            Trainers.Add(Trainer1);
            Trainers.Add(Trainer2);
        }
        


    }
}
