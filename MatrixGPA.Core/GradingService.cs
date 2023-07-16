using MatrixGPA.Data.Entities;
using MatrixGPA.Helper;

namespace MatrixGPA.Core;

public class GradingService
{
    public void CalculateGPA(StudentResult student)
    {
        decimal gpa = student.totalWeightPoint / student.totalCourseUnitsPassed;

        PrintTable table = new();
        DataStore coursedata = new();
        table.getTable(coursedata, student, gpa);
    }
}