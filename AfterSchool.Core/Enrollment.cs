using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchool.Core
{
    public interface iEnrollment
    {

        

         IQueryable<Club> Clubs { get; }
         IQueryable<Student> Students { get; }
         //Season season { get; set; }
    }
}
