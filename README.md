# DotNet Projects

Use git clone https://github.com/Ajayjam97/DotNet.git to clone the project anywhere on your system.

## Setting up dotnet & C#

1. Install dotnet core. Go to https://dotnet.microsoft.com/en-us/download
2. Confirm installation by running "dotnet --version" command on command prompt.
3. Install VS Code if you don't have. Go to https://code.visualstudio.com/download
4. Now install C# extension in VS Code. This will help with .Net Core SDK & intellisense for C#.
5. Now create a solution inside your current solution folder using "dotnet new sln" command.

## Creating Projects in the solution

1. Use "dotnet new classlib -o Library" command to add classlib type of project. 
2. Use "dotnet new xunit -o TestLibrary" command to add xunit type of project for testing purpose.
3. Use "dotnet sln add .\Library\Library.csproj" command to add the project to solution. 
4. Use "dotnet sln add .\TestLibrary\TestLibrary.csproj" command to add the project to solution.
5. "dotnet add .\Library\ package Newtonsoft.Json" add package to the Library project.
6. "dotnet restore" helps grab the packages specified as package reference in your projects.
7. Add working code using Newtonsoft package & execute "dotnet build" command. This will give you library.dll
8. Now to test functionality pf Library.dll add refernece to the library in TestLibrary project.
9. Use "dotnet add .\TestLibrary\TestLibrary.csproj reference .\Library\Library.csproj" command.
10. After adding code int TestLibrary use "dotnet test .\TestLibrary\TestLibrary.csproj" to perform testing.
