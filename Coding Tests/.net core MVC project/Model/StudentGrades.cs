using System;
using System.ComponentModel;
using System.Collections.Generic;
using DataAccess;
using Entities;
using System.Linq;

namespace Model
{
    public class StudentGrades
    {
        // Set up the model with the CourseGrade and HasPassed needing to be worked out I have made the  properties get and set
        // I have created the model in its own project so if it is extened it is independent from the rest of the project.  
        public int StudentId { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Course and Grades")]
        public string CourseAndGrade { get; set; }
        [DisplayName("Has Passed this Year?")]
        public bool HasPassed { get; set; }
    }

    public class StudentsWthGrades
    {

        //StudentGrades(){}
        // I need to populate a list of student grades after I have worked out how to concatenate to gardes into a single string CourseAndGrades
        // i need to populate the HasPassed sting after I have worked out if we have a pass or not

        public static List<StudentGrades> GetStudentsWithGrades()
        {
            List<StudentGrades> result = new List<StudentGrades>();

            // because time is running out and I am having to think hard how to get at the lists in the DataAccessor. I will concentrate 
            // on getting the logic for the string building and score working out now

            // the list is not sorted by student I need Linq 
            var student = new DataAccessor().GetStudents();
            var grades = new DataAccessor().GetGrades();
            //  var listOfStudentCourses =  Grade.Select.where(i => i.StudentId == item.Id);
            foreach (var item in student)
            {
                // this is not a list of string at this point it needs to
                // join with Course 
                var listOfStudentCourses =  grades.Where(i => i.StudentId == item.Key).ToList();
                var studentsExams = ConcatenateStudentExams(listOfStudentCourses);
                var hasPassed = HasPassed(listOfStudentCourses);
                var studentGarde = new StudentGrades();
                studentGarde.Name = item.Value;
                studentGarde.CourseAndGrade = studentsExams;
                studentGarde.HasPassed = hasPassed;
                result.Add(studentGarde);
                // a nice little function to return the calulated Has passed
                // place all the calculated vaues in the List of StudentGrades
            }
            return result;
        }

        private static string ConcatenateStudentExams(List<Grade> StudentsExams)
        {
            string result ="";
            foreach (var item in StudentsExams)
            {
                // out of time use stringbuilder
                var courseNames = new DataAccessor().GetCourses();
                var courseName = courseNames.FirstOrDefault(x => x.CourseId == item.CourseId).ToString();
                result += courseName + "||";
            }
            return result;
        }

        private static bool HasPassed(List<Grade> studentsGrades)
        {
            bool result;
            int resultMoreThanC = 0;
            foreach (var item in studentsGrades)
            {
                // we are looking for the B and A results 
                if (item.GradeValue[0] > 'C' && item.GradeValue[0]<= 'A')
                {
                    resultMoreThanC += 1;
                }
            }
            // having got a count of all the results that are consided
            // a pass test we have the requied number and return a decision
            result = resultMoreThanC > 2 ? true : false; 
            return result;
        }
    }
}
