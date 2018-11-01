# Creating an Empty Web Project

For this activity, please ensure you have completed [Activity 1](1-InstallTooling.md) to install the required tooling.

1. Open a command prompt from the AspNetCoreDockerWorkshop directory.
2. Create a 'src' folder. This is a common convention.

> md src

3. Change to the 'src' folder.

> cd src

4. Use the dotnet CLI to create an empty web project called SampleApi.

> dotnet new web --name SampleApi --no-https

5. Change boot to the root directory.

> cd ..

6. Use the dotnet CLI to create a new empty solution

> dotnet new sln

7. Add the SampleApi project to the solution.

> dotnet sln add .\src\SampleApi\SampleApi.csproj

8. Use the dotnet CLI to build the solution.

> dotnet build

9. Use the dotnet CLI to run the application

> dotnet run --project src/SampleApi/SampleApi.csproj

*NOTE: By default the application will be hosted on port 5000. If this conflicts with anything you can override the port using the switch  --urls "http://localhost:PORT"*

10. Open a browser to test the application by navigating to http://localhost:5000

## End of Activity

By this point you should be able to double click the solution file to open the SampleApi project in Visual Studio 2017.

The completed example for this activity can be found in the /steps/1-Create-Solution-And-Project folder.

[Return to README and activity links](../README.md)