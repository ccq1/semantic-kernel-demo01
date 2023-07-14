using System.Reflection;

namespace Utilis;

public class ProjectFile
{
    public static string GetSkillFolder() =>
        Path.Join(
            Path.GetDirectoryName(
                Path.GetFullPath(Assembly.GetExecutingAssembly().Location)
            ),"SemanticSkills"
        );
}
