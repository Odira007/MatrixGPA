using MatrixGPA.Data.Entities;
using MatrixGPA.Common;

namespace MatrixGPA.Core;

public class CourseService
{
    Course student = new();
    public void CourseGrades(int courseScore)
    {
        if(student.courseScore >= 70 && student.courseScore <= 100)
        {
            student.gradeRemark = "Excellent";
            student.studentGrade = Grades.A;
            student.studentGradeUnit = (int)Grades.A;
        }
        else if (student.courseScore >= 60 && student.courseScore <= 69)
        {
            student.gradeRemark = "Very Good";
            student.studentGrade = Grades.B;
            student.studentGradeUnit = (int)Grades.B;
        }
        else if (student.courseScore >= 50 && student.courseScore <= 59)
        {
            student.gradeRemark = "Good";
            student.studentGrade = Grades.C;
            student.studentGradeUnit = (int)Grades.C;
        }
        else if (student.courseScore >= 45 && student.courseScore <= 49)
        {
            student.gradeRemark = "Fair";
            student.studentGrade = Grades.D;
            student.studentGradeUnit = (int)Grades.D;
        }
        else if (student.courseScore >= 40 && student.courseScore <= 44)
        {
            student.gradeRemark = "Pass";
            student.studentGrade = Grades.E;
            student.studentGradeUnit = (int)Grades.E;
        }
        else
        {
            student.gradeRemark = "Fail";
            student.studentGrade = Grades.F;
            student.studentGradeUnit = (int)Grades.F;
        }
    }
}