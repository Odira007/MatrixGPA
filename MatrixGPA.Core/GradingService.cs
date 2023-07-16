using MatrixGPA.Data.Entities;
using MatrixGPA.Helper;

namespace MatrixGPA.Core;

public class GradingService
{
    public static void CalculateGPA(StudentResult student)
    {
        decimal gpa = (decimal)student.totalWeightPoint / (decimal)student.totalCourseUnits;
        
        PrintTable.getTable(student, gpa);
    }
}