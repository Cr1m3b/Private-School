using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vasou_Iosif_Individual_Project_Part_A.Database;
using Vasou_Iosif_Individual_Project_Part_A.Entities;

namespace Vasou_Iosif_Individual_Project_Part_A.Repository_Service
{
    class TrainerService
    {
        private MyDatabase db = new MyDatabase();

        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }
        public void CreateTrainer(Trainer trainer)
        {
            db.Trainers.Add(trainer);
        }
        public void AddTrainerToCourse(Trainer trainer, Course course)
        {
            course.TrainersList.Add(trainer);
        }
        public List<Trainer> PrintTrainersInCourse(Course course)
        {
            return course.TrainersList;
        }
    }
}
