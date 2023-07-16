namespace MatrixGPA.Data.Entities;

public class StudentResult
{
    public List<Course> courses {get; set;} = new();
    public int totalCourseUnits {get; set;} = 0;
    public int totalCourseUnitsPassed {get; set;} = 0;
    public int totalWeightPoint {get; set;} = 0;
}