using MatrixGPA.Core;
using Figgle;
using static System.Console;
using System.Threading;
using System;
using MatrixGPA.Data.Entities;
using System.Text.RegularExpressions;

namespace MatrixGPA.UI
{
    public class UserInterface
    {
        public void Start()
        {
            DataStore courseDetails = new();
            Clear();
            WriteLine(FiggleFonts.Ogre.Render("MatrixGPA"));

            WriteLine($"Welcome to MatrixGPA. Our app provides a user-friendly interface for you to{Environment.NewLine}calculate your GPA");
            WriteLine("Enter your course code, course unit and course score in the following format: BLA101 5 50");
            WriteLine();

            StudentResult result = new();
            StudentService student = new();
            Course course;
            var grading = new GradingService();

            DataStore courseData = new();

            string calculate = string.Empty;
            var validateCourse = new Regex(@"^\w{1,3}\d{1,3}\s{1}[1-5]{1}\s{1}([0-9]|[1-9][0-9]|100)$");

            string input;
            start:
            do
            {
                Write("Course code, course unit and course score: ");
                input = ReadLine().ToUpper();
                string[] courseArray = input.Split(" ");
                course = new Course(courseArray[0], Convert.ToInt32(courseArray[1]), Convert.ToInt32(courseArray[2]));
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

            Write("Please wait while we calculate your GPA ");
            do
            {
                for(int i = 0; i < 3; i++)
                {
                    Write(".");
                    Thread.Sleep(1000);
                }
            }
            while(DateTime.Now.Millisecond < 6);
            grading.CalculateGPA(result);
        }
    }
}