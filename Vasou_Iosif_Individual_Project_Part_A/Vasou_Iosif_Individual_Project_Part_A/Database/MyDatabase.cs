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
            var Assignment1 = new Assignment("Assignment1", "1st Assignment", new DateTime(2022, 02, 15), 50, 100);
            var Assignment2 = new Assignment("Assignment2", "2nd Assignment", new DateTime(2022, 03, 11), 60, 95);
            var Assignment3 = new Assignment("Assignment3", "3rd Assignment", new DateTime(2022, 02, 20), 55, 90);
            var Assignment4 = new Assignment("Assignment3", "3rd Assignment", new DateTime(2022, 03, 20), 62, 95);
            var Assignment5 = new Assignment("Assignment3", "3rd Assignment", new DateTime(2022, 02, 20), 57, 100);

            //Add Assignments to lists
            Assignments.Add(Assignment1);
            Assignments.Add(Assignment2);
            Assignments.Add(Assignment3);
            Assignments.Add(Assignment4);
            Assignments.Add(Assignment5);

            //Creating Courses
            var Course1 = new Course("CB10", "C#", "Full", new DateTime(2022, 04, 15), new DateTime(2021, 08, 28) );
            var Course2 = new Course("CB11", "Java", "Part", new DateTime(2022, 05, 15), new DateTime(2021, 08, 30) );
            var Course3 = new Course("CB12", "JavaScript", "Full", new DateTime(2022, 04, 15), new DateTime(2021, 08, 25) );
            var Course4 = new Course("CB13", "C++", "Part", new DateTime(2022, 05, 15), new DateTime(2021, 08, 25) );
            var Course5 = new Course("CB14", "C", "Full", new DateTime(2022, 04, 15), new DateTime(2021, 08, 25) );

            //Add Courses to lists
            Courses.Add(Course1);
            Courses.Add(Course2);
            Courses.Add(Course3);
            Courses.Add(Course4);
            Courses.Add(Course5);

            //Creating Students
            Student Student1 = new Student("Marios", "Filiou", new DateTime(1989, 11, 15), 2200);
            Student Student2 = new Student("Georgia", "Kostoglou", new DateTime(1990, 03, 24), 2000);
            Student Student3 = new Student("Giorgos", "Georgiou", new DateTime(1975, 12, 07), 2000);
            Student Student4 = new Student("Kostas", "Eustathiou", new DateTime(1992, 10, 07), 2100);
            Student Student5 = new Student("Maria", "Kirkou", new DateTime(1992, 05, 07), 2000);
            Student Student6 = new Student("Irini", "Markou", new DateTime(1985, 01, 10), 2300);
            Student Student7 = new Student("Iosif", "Vasou", new DateTime(1984, 03, 14), 2100);
            Student Student8 = new Student("Evi", "Dimosthenous", new DateTime(1991, 04, 07), 2150);
            Student Student9 = new Student("Marios", "Filiou", new DateTime(1992, 07, 21), 2050);
            Student Student10 = new Student("Traiana", "komninou", new DateTime(1990, 10, 25), 2250);
            Student Student11 = new Student("Foivos", "Komninos", new DateTime(1977, 11, 19), 2100);

            //Add Students to lists
            Students.Add(Student1);
            Students.Add(Student2);
            Students.Add(Student3);
            Students.Add(Student4);
            Students.Add(Student5);
            Students.Add(Student6);
            Students.Add(Student7);
            Students.Add(Student8);
            Students.Add(Student9);
            Students.Add(Student10);
            Students.Add(Student11);

            //Creating Trainers
            var Trainer1 = new Trainer("Ektoras", "Gatsos", "Introduction to Programming");
            var Trainer2 = new Trainer("Maria", "Georgiou", "Introduction to Data Bases");
            var Trainer3 = new Trainer("Kostas", "Kostoglou", "Introduction to Data Bases");
            var Trainer4 = new Trainer("Marios", "Athineou", "Introduction to Data Bases");
            var Trainer5 = new Trainer("Evi", "Kostou", "Introduction to Data Bases");

            //Add Trainers to lists
            Trainers.Add(Trainer1);
            Trainers.Add(Trainer2);
            Trainers.Add(Trainer3);
            Trainers.Add(Trainer4);
            Trainers.Add(Trainer4);
            Trainers.Add(Trainer5);

            //Add Assignments to students
            Student1.AssignmentsList.Add(Assignment1);
            Student1.AssignmentsList.Add(Assignment2);
            Student2.AssignmentsList.Add(Assignment1);
            Student2.AssignmentsList.Add(Assignment2);
            Student2.AssignmentsList.Add(Assignment3);
            Student3.AssignmentsList.Add(Assignment3);
            Student3.AssignmentsList.Add(Assignment4);
            Student3.AssignmentsList.Add(Assignment5);
            Student4.AssignmentsList.Add(Assignment1);
            Student4.AssignmentsList.Add(Assignment4);
            Student4.AssignmentsList.Add(Assignment5);
            Student5.AssignmentsList.Add(Assignment2);
            Student5.AssignmentsList.Add(Assignment4);
            Student5.AssignmentsList.Add(Assignment5);
            Student6.AssignmentsList.Add(Assignment1);
            Student6.AssignmentsList.Add(Assignment3);
            Student7.AssignmentsList.Add(Assignment1);
            Student7.AssignmentsList.Add(Assignment2);
            Student7.AssignmentsList.Add(Assignment4);
            Student7.AssignmentsList.Add(Assignment5);
            Student8.AssignmentsList.Add(Assignment2);
            Student8.AssignmentsList.Add(Assignment4);
            Student9.AssignmentsList.Add(Assignment1);
            Student9.AssignmentsList.Add(Assignment4);
            Student9.AssignmentsList.Add(Assignment5);
            Student10.AssignmentsList.Add(Assignment1);
            Student10.AssignmentsList.Add(Assignment4);
            Student11.AssignmentsList.Add(Assignment1);
            Student11.AssignmentsList.Add(Assignment3);
            Student11.AssignmentsList.Add(Assignment4);
            Student11.AssignmentsList.Add(Assignment5);

            //Add Assignments to course
            Course1.AssignmentsList.Add(Assignment1);
            Course1.AssignmentsList.Add(Assignment2);
            Course1.AssignmentsList.Add(Assignment3);
            Course1.AssignmentsList.Add(Assignment4);
            Course1.AssignmentsList.Add(Assignment5);
            Course2.AssignmentsList.Add(Assignment1);
            Course2.AssignmentsList.Add(Assignment2);
            Course2.AssignmentsList.Add(Assignment3);
            Course2.AssignmentsList.Add(Assignment4);
            Course2.AssignmentsList.Add(Assignment5);
            Course3.AssignmentsList.Add(Assignment1);
            Course3.AssignmentsList.Add(Assignment2);
            Course3.AssignmentsList.Add(Assignment3);
            Course3.AssignmentsList.Add(Assignment4);
            Course3.AssignmentsList.Add(Assignment5);
            Course4.AssignmentsList.Add(Assignment1);
            Course4.AssignmentsList.Add(Assignment2);
            Course4.AssignmentsList.Add(Assignment3);
            Course4.AssignmentsList.Add(Assignment4);
            Course4.AssignmentsList.Add(Assignment5);
            Course5.AssignmentsList.Add(Assignment1);
            Course5.AssignmentsList.Add(Assignment2);
            Course5.AssignmentsList.Add(Assignment4);
            Course5.AssignmentsList.Add(Assignment4);
            Course5.AssignmentsList.Add(Assignment5);

            //Add Students to course
            Course1.StudentsList.Add(Student1);
            Course1.StudentsList.Add(Student2);
            Course1.StudentsList.Add(Student4);
            Course1.StudentsList.Add(Student5);
            Course1.StudentsList.Add(Student6);
            Course1.StudentsList.Add(Student7);
            Course1.StudentsList.Add(Student8);
            Course1.StudentsList.Add(Student9);
            Course1.StudentsList.Add(Student11);

            Course2.StudentsList.Add(Student1);
            Course2.StudentsList.Add(Student2);
            Course2.StudentsList.Add(Student3);
            Course2.StudentsList.Add(Student4);
            Course2.StudentsList.Add(Student5);
            Course2.StudentsList.Add(Student7);
            Course2.StudentsList.Add(Student8);
            Course2.StudentsList.Add(Student9);
            Course2.StudentsList.Add(Student10);

            Course3.StudentsList.Add(Student2);
            Course3.StudentsList.Add(Student4);
            Course3.StudentsList.Add(Student6);
            Course3.StudentsList.Add(Student8);
            Course3.StudentsList.Add(Student10);
            Course3.StudentsList.Add(Student11);

            Course3.StudentsList.Add(Student1);
            Course3.StudentsList.Add(Student3);
            Course3.StudentsList.Add(Student5);
            Course3.StudentsList.Add(Student6);
            Course3.StudentsList.Add(Student7);
            Course3.StudentsList.Add(Student9);
            Course3.StudentsList.Add(Student11);

            //Add Trainers to course
            Course1.TrainersList.Add(Trainer1);
            Course2.TrainersList.Add(Trainer2);
            Course3.TrainersList.Add(Trainer3);
            Course4.TrainersList.Add(Trainer4);
            Course5.TrainersList.Add(Trainer5);

            //Add Student to Assignment
            Assignment1.StudentsList.Add(Student1);
            Assignment2.StudentsList.Add(Student1);
            Assignment1.StudentsList.Add(Student2);
            Assignment2.StudentsList.Add(Student2);
            Assignment3.StudentsList.Add(Student2);
            Assignment3.StudentsList.Add(Student3);
            Assignment4.StudentsList.Add(Student3);
            Assignment5.StudentsList.Add(Student3);
            Assignment1.StudentsList.Add(Student4);
            Assignment4.StudentsList.Add(Student4);
            Assignment5.StudentsList.Add(Student4);
            Assignment2.StudentsList.Add(Student5);
            Assignment4.StudentsList.Add(Student5);
            Assignment5.StudentsList.Add(Student5);
            Assignment1.StudentsList.Add(Student6);
            Assignment3.StudentsList.Add(Student6);
            Assignment1.StudentsList.Add(Student7);
            Assignment2.StudentsList.Add(Student7);
            Assignment4.StudentsList.Add(Student7);
            Assignment5.StudentsList.Add(Student7);
            Assignment2.StudentsList.Add(Student8);
            Assignment4.StudentsList.Add(Student8);
            Assignment1.StudentsList.Add(Student9);
            Assignment4.StudentsList.Add(Student9);
            Assignment5.StudentsList.Add(Student9);
            Assignment1.StudentsList.Add(Student10);
            Assignment4.StudentsList.Add(Student10);
            Assignment1.StudentsList.Add(Student11);
            Assignment3.StudentsList.Add(Student11);
            Assignment4.StudentsList.Add(Student11);
            Assignment5.StudentsList.Add(Student11);
        }



    }
}
