# Creating an Empty Web Project

For this activity, please ensure you have completed [Activity 1](01-InstallTooling.md) to install the required tooling.

## What's the plan?

We're going to use the command line and dotnet CLI to create the structure for our API project amd solution.

We could use the Visual Studio UI and tooling for this also, but let's see how easily the cross platform CLI supports working with projects and templates.

## Activity Steps

1. Open a command prompt from your preferred project directory e.g. 'C:\Projects\'.
2. Create a 'SampleApi' folder.

```md SampleApi```

3. Change to the 'SampleApi' folder.

```cd SampleApi```

4. Pin the SDK version for these activies to 2.1.403 

```dotnet new globaljson --sdk-version 2.1.403```

5. Use the dotnet CLI to create an empty web project called SampleApi under a directory called 'src'.

```dotnet new web --name SampleApi --no-https -o src/SampleApi```

6. Use the dotnet CLI to create a new empty solution

```dotnet new sln```

7. Add the SampleApi project to the solution.

```dotnet sln add .\src\SampleApi\SampleApi.csproj```

8. Use the dotnet CLI to build the solution.

```dotnet build```

9. Use the dotnet CLI to run the application

```dotnet run --project src/SampleApi/SampleApi.csproj```

*NOTE: By default the application will be hosted on port 5000. If this conflicts with anything you can override the port using the switch  --urls "http://localhost:PORT"*

10. Open a browser to test the application by navigating to http://localhost:5000

To finish, we'll clean up some items added by the default web project template which we do not need. This is not absolutely required but keeps everything clean.

11. Explore to the 'src/SampleApi' directory from Windows Explorer. 
12. Open the src/SampleApi/SampleApi.csproj file in the text editor of your choosing.

13. Remove the entire ItemGroup which specified the folder include for the wwwroot folder.
14. Remove the package reference to 'Microsoft.AspNetCore.Razor.Design' which is not needed for an API project.

The csproj file for SampleApi should look like this once you have finished...

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App" />
  </ItemGroup>

</Project>
```

15. In Windows Explorer, delete the 'wwwroot' folder. This is not needed for an API project since we will not serve any static files.

## End of Activity

By this point you should be able to double click the solution file to open the SampleApi project in Visual Studio 2017.

The completed example for this activity can be found in the '/steps/02-Create-Solution-And-Project' folder.

Continue to [Activity 3](03-CreateControllerAndAction.md).

[Return to README and activity links](../README.md)