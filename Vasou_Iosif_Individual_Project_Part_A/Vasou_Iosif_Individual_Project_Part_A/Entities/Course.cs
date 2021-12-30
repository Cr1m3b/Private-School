using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_Individual_Project_Part_A.Entities
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> StudentsList = new List<Student>();
        public List<Trainer> TrainersList = new List<Trainer>();
        public List<Assignment> AssignmentsList = new List<Assignment>();

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            this.Title = title;
            this.Stream = stream;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
            
        }
    }
}
