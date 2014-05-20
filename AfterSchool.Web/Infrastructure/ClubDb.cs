using AfterSchool.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfterSchool.Web.Infrastructure
{
    public class ClubDb : DbContext, iEnrollment
    {
        public ClubDb()  : base("DefaultConnection")
        { 
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Student> Students { get; set; }

        IQueryable<Club> iEnrollment.Clubs
        {
            get
            {
                return Clubs;
            }
           
        }

        IQueryable<Student> iEnrollment.Students
        {
            get
            {
                return Students;
            }
            
        }
    }
}