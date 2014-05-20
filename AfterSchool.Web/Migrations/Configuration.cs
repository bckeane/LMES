namespace AfterSchool.Web.Migrations
{
    using AfterSchool.Core;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AfterSchool.Web.Infrastructure.ClubDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AfterSchool.Web.Infrastructure.ClubDb context)
        {
            context.Clubs.AddOrUpdate(c => c.Name,
                        new Club() { Name = "Science Discovery", 
                                     Tuition = 75,
                                     Descrption = "Join Mad Science for some hands on Science Discovery! Explore the wonders of earth, try to defy gravity with a pendulum and forcast some walloping weather.  You’ll examine chemistry in your kitchen (no food), make a model ecosystem and see how bugs can defend themselves. Cool take homes in every class.   Taught by staff of Mad Science",
                                     DayOfWeekOffered = "Wednesday",
                                     MinGrade=grade.Kindergarten,
                                     MaxGrade=grade.Second,
                                     MinEnrollment=12,
                                     MaxEnrollment = 15,
                                     season = Club.Season.Winter,
                                     StartDate=new DateTime(2014,2,19)
                                    },
                        new Club() { Name = "The Game of Chess",
                                     Tuition = 45,
                                     Descrption = "Students of all chess levels are welcome, from the beginner with no experience to those who wish to improve their game, this class will offer you challenges.  Beginners will be instructed on piece movement and chess rules.  All students will learn through playing matches against similarly skilled opponents, with instructor advice given after matches.  Each week a new chess tip will be discussed and a challenge question will be given.  Taught by Jeff O’Sullivan", 
                                     DayOfWeekOffered = "Tuesday",
                                     MinGrade = grade.Third,
                                     MaxGrade = grade.Fifth,
                                     MinEnrollment = 8,
                                     MaxEnrollment = 20,
                                     season = Club.Season.Winter,
                                     StartDate=new DateTime(2014,2,18) },
                        new Club() { Name = "Happy Hoopers", 
                                     Tuition = 35,
                                     Descrption = "bringtheHoopla brings the FUN back into fitness!! During this 5 week program, we discuss the importance of health and nutrition while teaching students to use the hoop as a form of play and exercise. This is a high energy hoop class where we practice a variety of hoop games that build stamina and focus, foster team-building, leadership and cooperative play. We teach on and off body hoop tricks and techniques while creating a welcoming environment where creativity and self expression are encouraged. We build self-confidence through hooping and craft projects and learn to love ourselves for exactly who WE are.  Taught by staff of bringthehoopla", 
                                     DayOfWeekOffered = "Wednesday",
                                     MinGrade = grade.Second,
                                     MaxGrade = grade.Fifth,
                                     MinEnrollment = 6,
                                     MaxEnrollment = 18,
                                     season = Club.Season.Winter,
                                     StartDate = new DateTime(2014, 2, 19)
                        }

                );
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
