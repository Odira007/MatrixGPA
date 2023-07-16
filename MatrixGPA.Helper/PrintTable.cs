using MatrixGPA.Data.Entities;
using static System.Console;

namespace MatrixGPA.Helper;

public class PrintTable
{
    public void getTable(DataStore student, StudentResult result, decimal gpa)
    {
        Dash("-");
        WriteLine();
        WriteLine(format: "{0, -15} | {1, -13} | {2, -7} | {3, -12} | {4, -12} | {5, -15}", "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
        Dash("-");
        WriteLine();
        foreach(Course course in student.courses)
        {
            WriteLine(format: "{0, -15} | {1, -13} | {2, -7} | {3, -12} | {4, -12} | {5, -15}", course.courseCode, course.courseUnit, course.studentGrade, (int)course.studentGrade, "WEIGHTPOINTS", course.gradeRemark);
        }
        Dash("-");
        WriteLine();
        WriteLine($"Total Course Unit Registered is {result.totalCourseUnits}\nTotal Unit Passed is {result.totalCourseUnitsPassed}\nTotal Weight Point is {result.totalWeightPoint}");
        WriteLine(format: "Your GPA is = {0:N2} to 2 decimal places.", gpa);
    }
    public void Dash(string dash)
    {
        for(int i = 0; i < 83; i++)
        {
            Write(dash);
        }
    }
}
