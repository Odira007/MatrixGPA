using MatrixGPA.Common;


namespace MatrixGPA.Data.Entities;

public class Course
{
    public string courseCode;
    public int courseUnit;
    public int courseScore;
    public Grades studentGrade;
    public int studentGradeUnit;
    public int weightPoint;
    public string gradeRemark;

    public Course() {}

    public Course(string _courseCode, int _courseUnit, int _courseScore)
    {
        this.courseCode = _courseCode;
        this.courseUnit = _courseUnit;
        this.courseScore = _courseScore; 

        
        weightPoint = courseUnit * (int)studentGrade;
    }
}