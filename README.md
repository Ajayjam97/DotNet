# DotNet Projects

Use git clone https://github.com/Ajayjam97/DotNet.git to clone the project anywhere on your system.

## Setting up dotnet & C#

1. Install dotnet core. Go to https://dotnet.microsoft.com/en-us/download
2. Confirm installation by running "dotnet --version" command on command prompt.
3. Install VS Code if you don't have. Go to https://code.visualstudio.com/download
4. Now install C# extension in VS Code. This will help with .Net Core SDK & intellisense for C#.
5. Now create a solution inside your current solution folder using "dotnet new sln" command.

## Creating Projects in the solution

<details>
<summary>Adding a Lib project</summary>
<br>
  <ol>
    <li>Use "dotnet new classlib -o Library" command to add classlib type of project.</li>
    <li>Use "dotnet sln add .\Library\Library.csproj" command to add the project to solution.</li>
    <li>Use "dotnet add .\Library\ package Newtonsoft.Json" to add package to the Library project.</li>
    <li>Use "dotnet restore" to grab the packages specified as package reference in your project.</li>
    <li>Add working code using Newtonsoft package & execute "dotnet build" command. This will give you library.dll</li>
  </ol>
</details>
  
<details>
<summary>Adding XUnit Test project</summary>
<br>
  <ol>
 <li>Use "dotnet new xunit -o TestLibrary" command to add xunit type of project for testing purpose.</li>
 <li>Use "dotnet sln add .\TestLibrary\TestLibrary.csproj" command to add the project to solution.</li>
 <li>Now to test functionality of Library.dll add refernece to the library in TestLibrary project.</li>
 <li>Use "dotnet add .\TestLibrary\TestLibrary.csproj reference .\Library\Library.csproj" command.</li>
 <li>After adding code int TestLibrary use "dotnet test .\TestLibrary\TestLibrary.csproj" to perform testing.</li>
  </ol>
</details>

<details>
<summary>Adding Console project</summary>
<br>
  <ol>
 <li>Use "dotnet new console -o ConsoleApp" command to add console application type of project.</li>
 <li>Use "dotnet sln add .\ConsoleApp\ConsoleApp.csproj" command to add the project to solution.</li>
 <li>Now to use the functionality of Library.dll add refernece of the library in ConsoleApp project.</li>
 <li>Use "dotnet add .\ConsoleApp\ConsoleApp.csproj reference .\Library\Library.csproj" command.</li>
 <li>Use "dotnet run -p .\ConsoleApp\ConsoleApp.csproj" command to build & run the project.</li>
  </ol>
</details>




