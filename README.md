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

<b>The solution provided should be fast, secure, reliable & easy to maintain at the least.</b>
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
    <br><br>
  Discuss Non-functional requirements:<br>
1. <b>Performance:</b>    In performance we look for the latency & throughtput of the system. By latency we mean that how much time an operation takes 
   in the application (Example: Storing new user data takes 30ms). By throughput we mean that how many operations can be completed in a given
   time (Example: Storing data of 40 users can take 1s)<br><br>
2. <b>Load:</b>     By load we mean to what extreme can the system handle the load without crashing (Example: In a WebAPI how many concurrent requests
   can the system handle.)    If company A recieves 100 requests/sec daily, what if on a Black Friday Sale it recieves 1000 requests/sec. <br><br>
3. <b>Data volume:</b>    How much data system will acquire over time. This helps is deciding the Database, planning Query design & Storage.<br><br>
4. <b>Concurrent Users:</b>     How many users will be using the system concurrently. (Here not every user is making requests/performing operations) <br><br>
5. <b>SLA:</b>    Be practical about the SLA. 99.999% should not be the straight away answer. <br><br>
</details>

<details>
<summary>3. Map the components.</summary>
<br>
  Helps understand the system functionality and communicate the basic working idea to client. Decide application type after requirements are set. (Web Apps, Web APIs, Mobile, Console, Service, Desktop). Serverless computing applications like Azure functions, firebase functions, AWS lambda are type of methods that execute on trigger and are free of load, throughtput & performance constraints.
</details>

<details>
<summary>4. Select technology stack.</summary>
<br>
  Usually involves technologies for Backend, Fornt-end & Database. The choices need to be very rational as a wrong combination of tech stack 
  can lead to integration problems and errors in future. It needs to be a team decision for each backend, frontend & database technologies. The technology stack selected should have an active community, popular/trending as compared to its peers.
<br>
Backend (Nodejs, .Net Core, Java, Python)
          <br>
Frontend (React, Angular)
          <br>
Databse SQL(SQL Server, Postgre) & NoSQL(MongoDB)
  <br><br>
  Make sure to check quality attributes (Scalability, Manageability, Modularity, Extensibility, Testability)<br><br>
  <ul>
    <li>
  Scalability: There should be no change in code when scaling is required. Scaling is of 2 types (Scale up-Vertical  & Scale out-Horizontal). Scale out is preffered due to no SPOF, no limit to increase in compute.
    </li>
    <li>Manageability: A manageable system constantly monitors the application and takes actions accordingly. If the user is reproting the issue/error encountered instead of the application keeping log and handeling the error, then that application is not maneageable.</li>
    <li>Modularity: The written code should be modular so that it is easy to understand, modify & reuse in future.</li>
    <li>Extensibility: If a new functionality is required, the whole implemented code should not be affected. The code should have been writen in a manner that it is extensible. Eg: An API contains switch statement to reutrn JSON/XML data based on the format type value passed in query string, now if in future CSV needs to be passed as a value in the query string no switch case has been written for CSV. But it could have been made extensible if Dependecy Injection was used instead.</li>
    <li>Testability: The codeshould be Unit & Integrated testable. There should be implementations to perform unit & integration testing on the solution. This helps in POC & prevention of error-prone implementations.</li>
</details>

<details>
<summary>5. Design the system architecture.</summary>
<br>
  Using data & requirement gathering in previous four steps design the architecture of your solution. Make sure the system is fast, secure, 
  reliable & easy to maintain. Some quailites of a good system design are: (Loose Coupling, Stateless, Scaling, Caching, Messaging, Logging, Monitoring etc)
  <br><br>
  Software architecture has 2 levels of architecture (LLD & HLD) <br>
  
  [LLD(Low Level Design)](#lldlow-level-design) : It deals with the components of the code and how they interact with each other.
  <br>
  [HLD(High Level Design)](#hldhigh-level-design): It deals with the whole system architecture.
  
  <br>
</details>

<details>
<summary>6. Write architecture document.</summary>
<br>
  Combine all the efforts into a document that expalins the working, functionalities & technical dependencies of the system.
</details>

<details>
<summary>7. Develop & support your team.</summary>
<br>
  Finally, develop along and guide your team. Make changes & other decisions if required. 
</details>

<ul>
<br>

  
## LLD(Low Level Design)
 
  ### Most commonly the architecture of an application is divided in 3 layers. 
  
  <ul>
        <li>
  UI Layer(User Interface/ API)
        </li>
        <li>
  Business Logic Layer(BLL)
        </li>
        <li>
  Data Access Layer(DAL)
        </li>
  </ul>
  <br> 
  As per the code flow the layer above should consume the layer below. That means BLL consumes the objects of DAL to connect with Database and execute logics on the data. But if you are using Concrete classes to access DAL than there might be an issue of tight coupling. If you want to change the whole DAL layer, then you might have to change modify the calls made to DAL object in BLL as well.<br>
  To resolve this we use DI(Dependency injection) to refernece DAL layer in BLL code. This introduces Loose coupling.
  <br><br>
  
  ```
  DAL dal = new DAL();  //Tight coupling
  var entity=dal.GetData(100);
 
  IDAL dal = new DAL(); //Loose coupling
  var entity=dal.GetData(100);
  ```
  <br>
Also there should be proper exception handeling at every layer that does not allows exceptions of the lower layer to be visible to the one above it. That means Exception related to SQL should not be thrown from DAL to BLL, instead they should be logged in some place and only a minimal message should be passed to BLL, like "Data exception encountered".
  <br>
  
  ### There are 2 methods of using DI (Factory method & Consructor)
  
  Factory method<br>
  
  ```
  ICalculator calc=GetInstance(); 
  //Returns new Calculator() instance.
  
  ICalculator calc=GetInstance("Advanced"); 
  //Here instance depends on a value that can be provided as a parameter / through connection string.
  ```
  
  Constructor
  
  ```
  
  public class HomeController: Controller
  {
  
    ILogger logging;
  
    public HomeController(ILogger logging)
    {
        this.logging=logging;
    }
  }
  ```
  
  ### SOLID Principles
  
  <details>
    <summary>Single Responsibility http://www.blackwasp.co.uk/SRP.aspx </summary>
    Each class, module/method should have one and only one, responsibility. 
  </details>
  
  <details>
    <summary>Open/Closed http://www.blackwasp.co.uk/OCP.aspx </summary>
    A software entity should be open for extension but closed for modification. It can be implemented using class inheritance & Plugin methods.
  </details>
  
  <details>
    <summary>Liskov Substitution http://www.blackwasp.co.uk/LSP.aspx </summary>
    If S is a subtype of T, then objects of type T may be replaced with objects of type S, without altering any of the desired properties of the program.
    Liskov Substitution does not talks about the run time polymorphism, but it deals with Behavioral subtyping.
    The methods in parent T should not be hidden from S, if that happens then while substituting exceptions & unwanted results can be encountered.
  </details>
  
  <details>
    <summary>Interface Segregation http://www.blackwasp.co.uk/ISP.aspx </summary>
    Many client-specific interfaces are better than one general-purpose interface.
  </details>
  
  <details>
    <summary>Dependency Inversion http://www.blackwasp.co.uk/DIP.aspx </summary>
    Where ever possible perform dependency injection to make classes loosely coupled from their implementations.
  </details>
 
  Logging should be the major system to be integrated into your application. It not only helps to catch errors & exceptions but also to gather data such as 
  Most visited modules, Performance, User flow's etc. This data is rich and extremely valuable for any organization.
  <br>
  
  ### Design Patterns https://refactoring.guru/design-patterns/csharp
  
  Design patterns refer to the patterns of implementation that are ideal to be followed in some common situation/scenarios. These scenarios can be :
  How to communicate between classes, 
  How to initialize interface implementations, 
  How to access datastores, 
  etc....
  <br><br>
  Design patterns can be of following types:  
  <details>
    <summary> Creational patterns</summary>
    https://refactoring.guru/design-patterns/factory-method
  </details>
  
  <details>
    <summary> Structural patterns</summary>
    https://refactoring.guru/design-patterns/facade
  </details>
  
  <details>
    <summary> Behavioral patterns</summary>
    https://refactoring.guru/design-patterns/command
  </details>
   
 <br>
  
## HLD(High Level Design)
  
  <br>
  High level design of the system architecture is not about the low leve details, but about the bigger picture.
  It asks questions like:<br>
  1. How will the system perform under heavy load.<br>
  2. WHat will happen if the system crashes at this exact moment.<br>
  3. How complicated can be the update process for system.<br><br>
  
  It includes defining the software components(services), defining the way these components communicate, designing the system capabilities (scalability, redundancy,     performance, etc).
  <br><br>
  
  Metrics to consider for HLD:  
  <details>
    <summary> Loose Coupling</summary>
   There should be loose coupling between the services. If there are multiple services communicating with eachother, any change in the ip/connection of a single service would disturb the flow of other services and the tightly coupled linkages have to be modified. This tighly coupling can be removed using Yellow pages or a Mediator service.
  </details>
  
  <details>
    <summary> Stateless</summary>
  Always try to store state or session data at UI/Database. Never store Satate/Session data in the running code. If scaling has to take place or new servers are introduced with another instance, the load balancer would switch to the instance with less load. This would be a blunder as the state of the user is in another instance and he might get, re-login/No-access or other issues with the state that he was in.
  </details>
  
  <details>
    <summary> Caching</summary>
  Caching helps to retirve frequently used data faster and improves UX for the users. But choosing the right cache is important. If the data is realtime and you are using In Memory cahce then it would not contain the latest synced data from the Datasource. Although In Memory cache is easy to implement & much more faster, but it will fail as compared to a Distributed cache in this case.
  </details>
  
  <details>
    <summary> Messaging</summary>
    REST API (ASP.NET Web API, Flask, Spring), 
    HTTP Push Notifications: Pub Sub model (SignalR, Socket.io), 
    Queue (RabbitMQ, MQ Series), 
    File / Database based
  </details>
  
  <details>
    <summary> Logging & monitoring</summary>
    Logs of the entire system with multiple services must be centrally stored & should follow a single format.
  </details>
   
 <br>
  
 ## Advance system architecture
  
  A typical Microservice architecture contains Frontend clients(Web app, Mobile app etc), API Gateway, Cache, Authentication service, Multiple services running in a container host (Docker host etc), Message Broker/Event Bus.
  ![image](https://user-images.githubusercontent.com/21179880/188401353-1f62f5d6-528e-4aeb-bd93-eaecf4f29926.png)
  
  <br>
  Data management between multiple microservices is maintained using CQRS(Command Query Responsibility Segregation) design pattern and a Message Broker/Event Bus that performs Event sourcing. In CQRS the services that perform <b>Command</b> i.e. Create, Update, Delete operations are seperated & write data to a proper Relational Database. After every write operation the event is published to an Event Bus. This Event Bus is subscribed by multiple NOSQL Databases which gets updated & the sevices that perform <b>Query</b> i.e. Retrieve operations can read from those Databases.
  <br>

  
  

<br><br>
## If you are planning to develop your solution on cloud follow the below flowchart
  <br><br>
<img src="https://user-images.githubusercontent.com/21179880/188014963-ff8a952e-534d-41c8-a7fd-a204cc0cc709.png" width="700" height="500" />




