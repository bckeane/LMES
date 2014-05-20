using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AfterSchool.Core
{
    public enum grade
    {
        Kindergarten = 0,
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5
    };
    
    public class Student
    {

        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual grade Grade { get; set; }
        public virtual string Teacher { get; set; }
        public virtual string ParentName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public virtual object HomePhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public virtual object CellPhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public virtual object email { get; set; }


    }
}
