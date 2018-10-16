using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessor
    {
        public DataAccessor()
        {
        }

        public Dictionary<int, string> GetStudents()
        {
            return new Dictionary<int, string>
            {
                {1, "Bob" },
                {2, "Carl" },
                {3, "David" },
                {4, "Toby" },
                {5, "Lily" },
                {6, "Jacob" }
            };
        }

        public List<Grade> GetGrades()
        {
            return new List<Grade>
            {
                new Grade(1,1,"A"),
                new Grade(2,1,"A"),
                new Grade(3,1,"B+"),
                new Grade(4,1,"C"),
                new Grade(5,1,"A+"),
                new Grade(6,1,"B"),
                new Grade(1,2,"A"),
                new Grade(2,2,"B"),
                new Grade(3,2,"C"),
                new Grade(4,2,"C"),
                new Grade(1,3,"A"),
                new Grade(2,3,"A"),
                new Grade(3,4,"D"),
                new Grade(4,4,"C+"),
                new Grade(5,4,"B+"),
            };
        }

        public List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course(1, "Programming"),
                new Course(2, "Physics"),
                new Course(3, "Chemistry"),
                new Course(4, "Mathematics")
            };
        }
    }
}
