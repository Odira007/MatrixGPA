using MatrixGPA.Core;
using Figgle;
using static System.Console;
using System.Threading;
using System;
using MatrixGPA.Data.Entities;

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

            Write("Course code, course unit and course score: ");
            Course userEntry = (Course)ReadLine();
            courseDetails.courses.Add(userEntry);









            // Write("Please wait while we calculate your GPA ");
            // do
            // {
            //     for(int i = 0; i < 3; i++)
            //     {
            //         Write(".");
            //         Thread.Sleep(1000);
            //     }
            // }
            // while(DateTime.Now.Millisecond < 6);
        }
    }
}