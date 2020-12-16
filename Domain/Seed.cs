using System.Collections.Generic;
using System.Linq;
using YukonTest.Models;

namespace YukonTest.Domain
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Teachers.Any())
            {
                var teachers = new List<Teacher>{
                    new Teacher{TeacherID = 1,Name = "Asd",SubjectID = 1,Leave = false},
                    new Teacher{TeacherID = 2,Name = "Qwe",SubjectID = 2,Leave = false},
                };
                context.Teachers.AddRange(teachers);
                context.SaveChanges();
            }
            
        }
    }
}