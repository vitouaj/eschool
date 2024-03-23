/*

the following class is used to generate string unique id based on current time 

providing predefined prefix string.

for example:

    Co-20240323151133 = course id

    Er-20240323151133 = enrollment id

    St-20240323151133 = student id

    Tc-20240323151133 = teacher id

*/

using System.Security.Cryptography;
using System.Text.RegularExpressions;
using course.api.Models;

namespace course.api.Utils;
public sealed class IDGenerator
{
    public static string GradeId(GradeLevel grade) => grade switch
    {
        GradeLevel.G7 => "G07",
        GradeLevel.G8 => "G08",
        GradeLevel.G9 => "G09",
        GradeLevel.G10 => "G10",
        GradeLevel.G11 => "G11",
        GradeLevel.G12 => "G12",
        _ => throw new ArgumentException("Invalid enum value for command", nameof(grade)),
    };
    public static string CourseId() => $"Co-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";
    public static string ModuleId() => $"Mo-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";
    public static string UnitId() => $"Un-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";
    public static string SubjectId() => $"Su-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";

}

