using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchool.Core
{
    public class Club
    {

        public enum Season
        {
            Fall = 1,
            Winter = 2,
            Spring = 3
        };

        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Descrption { get; set; }
        public virtual double Tuition { get; set; }
        public virtual string DayOfWeekOffered { get; set; }
        public virtual int MinEnrollment { get; set; }
        public virtual int MaxEnrollment { get; set; }
        public virtual grade MinGrade { get; set; }
        public virtual grade MaxGrade { get; set; }
        public virtual int CurrentEnrollment { get; set; }
        public virtual DateTime StartDate { get; set; }
        public Season season { get; set; }
               
        public virtual ICollection<Student> Enrolled { get; set; }
    }
}
