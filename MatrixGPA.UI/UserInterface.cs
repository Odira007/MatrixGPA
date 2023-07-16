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
        public static void Start()
        {
            Clear();
            WriteLine(FiggleFonts.Ogre.Render("MatrixGPA"));

            WriteLine($"Welcome to MatrixGPA. Our app provides a user-friendly interface for you to{Environment.NewLine}calculate your GPA");
            WriteLine("Enter your course code, course unit and course score in the following format: BLA101 5 50");
            WriteLine();

            var student = new StudentResult();
            var grading = new GradingService();

            string input;
            string calculate = string.Empty;
            var validateCourse = new Regex(@"^\w{1,3}\d{1,3}\s{1}[1-5]{1}\s{1}([0-9]|[1-9][0-9]|100)$");

            start:
            do
            {
                Write("Course code, course unit and course score: ");
                input = ReadLine().ToUpper();
                string[] courseArray = input.Split(" ");
                var course = new Course(courseArray[0], int.Parse(courseArray[1]), int.Parse(courseArray[2]));
                student.courses.Add(course);
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

            foreach(Course course in student.courses)
            {
                student.totalCourseUnits += course.courseUnit;
                student.totalCourseUnitsPassed += (int)course.studentGrade;
                student.totalWeightPoint += course.weightPoint;
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

            WriteLine();
            GradingService.CalculateGPA(student);
        }
    }
}