using MatrixGPA.Data.Entities;
using static System.Console;
using System.Text.RegularExpressions;

namespace MatrixGPA.Core;

public class StudentService
{
    public void AddCourse(StudentResult result, string input)
    {
        DataStore courseData = new();

        string calculate = string.Empty;
        var validateCourse = new Regex(@"^\w{1,3}\d{1,3}\s{1}[1-5]{1}\s{1}([0-9]|[1-9][0-9]|100)$");
        Course course;
            
        start:
        do
        {
            Write("Course code, course unit and course score: ");
            string[] courseDetails = input.Split(" ");
            course = new Course(courseDetails[0], Convert.ToInt32(courseDetails[1]), Convert.ToInt32(courseDetails[2]));
            courseData.courses.Add(course);
            if (!validateCourse.IsMatch(input))
            {
                WriteLine("Your input was in the wrong format, try again :)");
                WriteLine();
                goto start;
            }
            Write("Calculate? (Y/N): ");
            calculate = ReadLine().ToUpper();
        }
        while(calculate != "Y");

        foreach(Course c in courseData.courses)
        {
            result.totalCourseUnits += c.courseUnit;
            result.totalCourseUnitsPassed += (int)c.studentGrade;
            result.totalWeightPoint += c.weightPoint;
        }
    }
}
