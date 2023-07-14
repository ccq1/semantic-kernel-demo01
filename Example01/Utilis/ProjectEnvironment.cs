
using System.Dynamic;
using Microsoft.Extensions.Configuration;
namespace Utilis;
public class ProjectEnvironment
{
   
   public const string AoaiEndPoint = nameof(AoaiEndPoint);
   public const string AoaiKey = nameof(AoaiKey);
   public const string AoaiDeploymentName = nameof(AoaiDeploymentName);


   public static readonly IConfigurationRoot _configuration = new ConfigurationBuilder()
                .AddUserSecrets<ProjectEnvironment>().Build();

    public static string Get(string name)
    {
        var value = _configuration[name];
        if(!string.IsNullOrEmpty(value))
        {
            return value;
        }
        value = Environment.GetEnvironmentVariable(name);
        if(string.IsNullOrEmpty(value))
        {
            throw new Exception($"The (Secrets)environment variable {name} is not set");
        }
         return value;
    }
}


