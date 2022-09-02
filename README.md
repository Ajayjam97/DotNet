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

In the above 3 projects now, we can perform tests & run application using just below dotnet cli commands:
1. **"dotnet test .\TestLibrary\TestLibrary.csproj"**  for performing tests.
2. **"dotnet run -p .\ConsoleApp\ConsoleApp.csproj"**  for running the main Console application.

## Make VS Code look like Visual studio.

This really helps to make it feel & look like Visual studio for the DotNet developers. All you have to do is to install vscode-solution-explorer package.
![image](https://user-images.githubusercontent.com/21179880/187766474-fdc88099-3a1c-42a0-9ac6-c84935bb9787.png)

## Baseline requirement of any Solution/Application

1. Fast
2. Secure
3. Reliable
4. Easy to maintain

(Other than the techinal aspect of the application you also need to make sure you know the weakness, strengths, competition & growth startegy of the business for which you are planning to solution.)

## System Architecture process

<details>
<summary>1. Understand System's requirements.</summary>
<br>
  Understand the requirements and goal of the application.  
  Discuss functional requirements & Business Flows (Login, Store data, Create Data).
</details>

<details>
<summary>2. Understand Non-Functional requirements.</summary>
<br>
  Define technical & service level attributes.(# of Users, Loads, Volume, Performance, Concurrent Users, SLA etc.)
  Techincal requirements are not always known to the client or business & its your job to help them formulate these requirements.
    <br>
  Discuss Non-functional requirements:<br><br>
1. <b>Performance:</b>    In performance we look for the latency & throughtput of the system. By latency we mean that how much time an operation takes 
   in the application (Example: Storing new user data takes 30ms). By throughput we mean that how many operations can be completed in a given
   time (Example: Storing data of 40 users can take 1s)<br><br>
2. <b>Load:</b>     By load we mean to what extreme can the system handle the load without crashing (Example: In a WebAPI how many concurrent requests
   can the system handle.)    If company A recieves 100 requests/sec daily, what if on a Black Friday Sale it recieves 1000 requests/sec. <br><br>
3. <b>Data volume:</b>    How much data system will acquire over time. This helps is deciding the Database, planning Query design & Storage.<br><br>
4. <b>Concurrent Users:</b>     How many users will be using the system concurrently. (Here not every user is making requests/performing operations) <br><br>
5. <b>SLA:</b>    Be practical about the SLA. 99.999% should not be the straight away answer. <br>
</details>

<details>
<summary>3. Map the components.</summary>
<br>
  Helps understand the system functionality and communicate the basic working idea to client. Decide application type after requirements are set. (Web Apps, Web APIs, Mobile, Console, Service, Desktop). <br>Serverless computing applications like Azure functions, firebase functions, AWS lambda are type of methods that execute on trigger and are free of load, throughtput & performance constraints.
</details>

<details>
<summary>4. Select technology stack.</summary>
<br>
  Usually involves technologies for Backend, Fornt-end & Database. The choices need to be very rational as a wrong combination of tech stack 
  can lead to integration problems and errors in future. It needs to be a team decision for each backend, frontend & database technologies. The technology stack selected should have an active community, popular/trending as compared to its peers.
          <br><br>
Backend (Nodejs, .Net Core, Java, Python)
          <br><br>
Frontend (React, Angular)
          <br><br>
Databse SQL(SQL Server, Postgre) & NoSQL(MongoDB)
  <br><br>
  Make sure to check quality attributes (Scalability, Manageability, Modularity, Extensibility, Testability)
</details>

<details>
<summary>5. Design the system architecture.</summary>
<br>
  Using data & requirement gathering in previous four steps design the architecture of your solution. Make sure the system is fast, secure, 
  reliable & easy to maintain.
  Some quailites of a good system design are: (Loose Coupling, Stateless, Scaling, Caching, Messaging, Logging, Monitoring etc)
</details>

<details>
<summary>6. Write architecture document.</summary>
<br>
  Combine all the efforts into a document that expalins the working, functionalities & technical dependencies of the system.
</details>

<details>
<summary>7. Develop & support your team.</summary>
<br>
  Finally, develop along and duide your team. Make changes & other decisions if required. 
</details>

<br><br>
<ul>
  
  <li>
Discuss functional requirements like (User login, User roles, User operations, Application functionalities etc)
    </li>
<br>
    <li>
Discuss Non-functional requirements:<br>
1. <b>Performance:</b>    In performance we look for the latency & throughtput of the system. By latency we mean that how much time an operation takes 
   in the application (Example: Storing new user data takes 30ms). By throughput we mean that how many operations can be completed in a given
   time (Example: Storing data of 40 users can take 1s)<br>
2. <b>Load:</b>     By load we mean to what extreme can the system handle the load without crashing (Example: In a WebAPI how many concurrent requests
   can the system handle.)    If company A recieves 100 requests/sec daily, what if on a Black Friday Sale it recieves 1000 requests/sec. <br>
3. <b>Data volume:</b>    How much data system will acquire over time. This helps is deciding the Database, planning Query design & Storage.<br>
4. <b>Concurrent Users:</b>     How many users will be using the system concurrently. (Here not every user is making requests/performing operations) <br>
5. <b>SLA:</b>    Be practical about the SLA. 99.999% should not be the straight away answer. 
      </li>
  <br>
      <li>
Decide application type after requirements are set. (Web Apps, Web APIs, Mobile, Console, Service, Desktop). Serverless computing applications
like Azure functions, firebase functions, AWS lambda are type of methods that execute on trigger and are free of load, throughtput & performance constraints.
        </li>
<br>
        <li>
Selecting technology stack needs to be a rational decision based on the requirements. It needs to be a team decision for each backend, frontend & database technologies. The technology stack selected should have an active community, popular/trending as compared to its peers.
          <br>
Backend (Nodejs, .Net Core, Java, Python)
          <br>
Frontend (React, Angular)
          <br>
Databse SQL(SQL Server, Postgre) & NoSQL(MongoDB)
          </li>
<br>
        <li>
Make sure to check quality attributes (Scalability, Manageability, Modularity, Extensibility, Testability)
          </li>
<br>
          
  </ul>

  


## If you are planning to develop your solution on cloud follow the below flowchart
<img src="https://user-images.githubusercontent.com/21179880/188014963-ff8a952e-534d-41c8-a7fd-a204cc0cc709.png" width="700" height="500" />




