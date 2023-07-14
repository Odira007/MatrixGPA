using MatrixGPA.Common;

namespace MatrixGPA.Data.Entities;

public class Course
{
    public string courseCode { get; set; }
    public int courseUnit {get; set;}
    public int courseScore {get; set;}
    public Grades studentGrade {get; set;}
    public int weightPoint;
    public string gradeRemark {get; set;}

    public Course() {}

    public Course(string _courseCode, int _courseUnit, int _courseScore)
    {
        this.courseCode = _courseCode;
        this.courseUnit = _courseUnit;
        this.courseScore = _courseScore; 
    }

    public static explicit operator Course(string v)
    {
        throw new NotImplementedException();
    }
}