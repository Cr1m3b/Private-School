using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Entities;
using Vasou_Iosif_Individual_Project_Part_A.Repository_Service;
using Vasou_Iosif_Individual_Project_Part_A.Views.Assignments;
using Vasou_Iosif_Individual_Project_Part_A.Views.Courses;
using Vasou_Iosif_Individual_Project_Part_A.Views.Students;
using Vasou_Iosif_Individual_Project_Part_A.Views.Trainers;

namespace Vasou_Iosif_Individual_Project_Part_A.Controllers
{
    class Controller
    {
        AssignmentService AssignmentService = new AssignmentService();
        CourseService CourseService = new CourseService();
        StudentService StudentService = new StudentService();
        TrainerService TrainerService = new TrainerService();

        public void ReadAllAssignments()
        {
            var allAssignmets = AssignmentService.GetAssignments();
            ViewAssignmet.PrintAssignments(allAssignmets);
        }
        public void CreateAssignment()
        {
            Assignment assignment = ViewAssignmet.CreateAssignment();
            AssignmentService.CreateAssignment(assignment);
        }
        public void AddAssignmentToCourse()
        {
            var allAssignmets = AssignmentService.GetAssignments();
            var allCourses = CourseService.GetCourses();
            var assignment = ViewAssignmet.GetAssignmentInfo(allAssignmets);
            var course = ViewCourse.GetCourseInfo(allCourses);
            AssignmentService.AddAssignmentToCourse(assignment, course);
            Console.WriteLine($"\n {assignment.Title} has been added to {course.Title}.");
        }
        public void ReadAllCourses()
        {
            var allCourses = CourseService.GetCourses();
            ViewCourse.PrintCourses(allCourses);
        }
        public void CreateCourse()
        {
            Course course = ViewCourse.CreateCourse();
            CourseService.CreateCourse(course);
        }
        public void ReadAllStudents()
        {
            var allStudents = StudentService.GetStudents();
            ViewStudent.PrintStudents(allStudents);
        }
        public void PrintStudentsInCourse()
        {
            var allCourses = CourseService.GetCourses();
            var course = ViewStudent.PrintStudentsInCourse(allCourses);
            var studentList = StudentService.PrintStudentsInCourse(course);
            ViewStudent.PrintStudents(studentList);
        }
        public void CreateStudent()
        {
            Student student = ViewStudent.CreateStudent();
            StudentService.CreateStudent(student);
        }
        public void AddStudentToCourse()
        {
            var allStudents = StudentService.GetStudents();
            var allCourses = CourseService.GetCourses();
            var student = ViewStudent.GetStudentInfo(allStudents);
            var course = ViewCourse.GetCourseInfo(allCourses);
            StudentService.AddStudentToCourse(student, course);
            Console.WriteLine($"{student.FirstName} {student.LastName} has been added to {course.Title}.");
        }
        public void AddAssignmentToStudent()
        {
            var allStudents = StudentService.GetStudents();
            var allAssignmets = AssignmentService.GetAssignments();
            var student = ViewStudent.GetStudentInfo(allStudents);
            var assignment = ViewAssignmet.GetAssignmentInfo(allAssignmets);
            AssignmentService.AddAssignmentToStudent(assignment, student);
            StudentService.AddStudentToAssignment(student, assignment);
            Console.WriteLine($"{assignment.Title} has been added to {student.FirstName} {student.LastName}.");
        }
        public void PrintAssignmentsPerStudent()
        {
            var allStudents = StudentService.GetStudents();
            ViewAssignmet.PrintAssignmentsPerStudent(allStudents);
        }
        public void ReadAllTrainers()
        {
            var allTrainers = TrainerService.GetTrainers();
            ViewTrainer.PrintTrainers(allTrainers);
        }
        public void CreateTrainer()
        {
            Trainer trainer = ViewTrainer.CreateTrainer();
            TrainerService.CreateTrainer(trainer);
        }
        public void AddTrainerToCourse()
        {
            var allTrainers = TrainerService.GetTrainers();
            var allCourses = CourseService.GetCourses();
            var trainer = ViewTrainer.GetTrainerInfo(allTrainers);
            var course = ViewCourse.GetCourseInfo(allCourses);
            TrainerService.AddTrainerToCourse(trainer, course);
            Console.WriteLine($"{trainer.FirstName} {trainer.LastName} has been added to {course.Title}.");
        }
        public void PrintTrainersPerCourse()
        {
            var allCourses = CourseService.GetCourses();
            ViewTrainer.PrintTrainersInCourse(allCourses);
        }
        public void printStudentsBelongingInMoreThanOneCourses()
        {
            var allCourses = CourseService.GetCourses();
            ViewStudent.printStudentsBelongingInMoreThanOneCourses(allCourses);
        }
        public void PrintStudentsWithAssignmentDeadline()
        {
            var allAssignmets = AssignmentService.GetAssignments();
            var allStudents = StudentService.GetStudents();
            ViewAssignmet.PrintStudentsWithAssignmentDeadline(allAssignmets, allStudents);
        }
    }
}
