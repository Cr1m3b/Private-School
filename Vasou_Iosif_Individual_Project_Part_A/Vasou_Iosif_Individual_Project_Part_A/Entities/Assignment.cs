using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasou_Iosif_Individual_Project_Part_A.Entities
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }

        public List<Student> StudentsList = new List<Student>();
        public Assignment(string title, string description, DateTime submissionDate, float oralMark, float totalMark)
        {
            this.Title = title;
            this.Description = description;
            this.SubmissionDate = submissionDate;
            this.OralMark = oralMark;
            this.TotalMark = totalMark;
        }
    }
}
