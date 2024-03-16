using System.ComponentModel.DataAnnotations;

namespace course.api;

public class Grade(int id, int level)
{
    public int Id { get; set; } = id;
    public int Level { get; set; } = level;
    public List<Course> Courses { get; set; } = [];


}
