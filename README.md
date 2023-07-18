# README.md

## semantic-kernel-demo01

Input some words to make sentences.

**Semantic-Kernel Simple Example**

### such as
<img width="592" alt="image" src="https://github.com/ccq1/semantic-kernel-demo01/assets/78813459/b8191e84-0818-4eb4-8138-4c0a4c9303c8">

To run:

1. You must set dotnet user-secrets. First, execute the command:

   ```
   dotnet user-secrets init
   ```

2. Then, set the following secrets:

   ```
   dotnet user-secrets set "AoaiDeploymentName" "[Your Deployment Name]"
   dotnet user-secrets set "AoaiEndPoint" "[Your Azure OpenAi EndPoint]"
   dotnet user-secrets set "AoaiKey" "[Your AzureOpenAi API]"
   ```

Now you can execute the command:

```
dotnet run
```
