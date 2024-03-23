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
using course.api.Grade;
using course.api.Subject;

namespace course.api.Utils;
public sealed class IDGenerator
{
    public static string GradeId(GradeLevel grade) => grade.ToString();
    public static string SubjectId(SubjectType subject) => subject.ToString();
    public static string CourseId() => $"Co-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";
    public static string ModuleId() => $"Mo-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";
    public static string UnitId() => $"Un-{DateTime.Now:yyyyMMdd}{Guid.NewGuid().ToString().Substring(0, 5)}";

}

