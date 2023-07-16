using MatrixGPA.Common;

namespace MatrixGPA.Data.Entities;

public class Course
{
    public string courseCode {get; set;}
    public int courseUnit {get; set;}
    public int courseScore {get; set;}
    public Grades studentGrade {get; set;}
    public int studentGradeUnit {get; set;}
    public int weightPoint {get; set;}
    public string gradeRemark {get; set;}

    public Course(string _courseCode, int _courseUnit, int _courseScore)
    {
        this.courseCode = _courseCode;
        this.courseUnit = _courseUnit;
        this.courseScore = _courseScore; 

        CourseGrades(courseScore);
        
        weightPoint = courseUnit * (int)studentGrade;
    }
    public void CourseGrades(int courseScore)
    {
        if(courseScore >= 70 && courseScore <= 100)
        {
            gradeRemark = "Excellent";
            studentGrade = Grades.A;
            studentGradeUnit = (int)Grades.A;
        }
        else if (courseScore >= 60 && courseScore <= 69)
        {
            gradeRemark = "Very Good";
            studentGrade = Grades.B;
            studentGradeUnit = (int)Grades.B;
        }
        else if (courseScore >= 50 && courseScore <= 59)
        {
            gradeRemark = "Good";
            studentGrade = Grades.C;
            studentGradeUnit = (int)Grades.C;
        }
        else if (courseScore >= 45 && courseScore <= 49)
        {
            gradeRemark = "Fair";
            studentGrade = Grades.D;
            studentGradeUnit = (int)Grades.D;
        }
        else if (courseScore >= 40 && courseScore <= 44)
        {
            gradeRemark = "Pass";
            studentGrade = Grades.E;
            studentGradeUnit = (int)Grades.E;
        }
        else
        {
            gradeRemark = "Fail";
            studentGrade = Grades.F;
            studentGradeUnit = (int)Grades.F;
        }
    }
}