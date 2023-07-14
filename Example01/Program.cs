using Microsoft.SemanticKernel;
using static System.Console;
using Utilis;
ForegroundColor = ConsoleColor.DarkRed;
var kernel = new KernelBuilder().Configure(p => {
     p.AddAzureChatCompletionService(
            ProjectEnvironment.Get(ProjectEnvironment.AoaiDeploymentName),
            ProjectEnvironment.Get(ProjectEnvironment.AoaiEndPoint),
            ProjectEnvironment.Get(ProjectEnvironment.AoaiKey)
            );
}).Build();
var learningSkill = kernel.ImportSemanticSkillFromDirectory(
    ProjectFile.GetSkillFolder(),"LearningSkill");
Write("Enter your words: ");
var words =ReadLine();
words = words.Check();
if(words == null){    throw new Exception("The number of words cannot be empty");}
var result = await kernel.RunAsync(words, learningSkill["WordsToSentence"]);
WriteLine(result.Result);
//ReadKey();


