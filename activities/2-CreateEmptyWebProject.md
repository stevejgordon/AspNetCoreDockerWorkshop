## Creating an Empty Web Project

1. Open a command prompt from the AspNetCoreDockerWorkshop directory.
2. Create a 'src' folder. This is a common convention.

> md src

3. Change to the 'src' folder.

> cd src

4. Use the dotnet CLI to create an empty web project called SampleApi.

> dotnet new web --name SampleApi --no-https

5. Change boot to the root directory.

> cd ../

6. Use the dotnet CLI to create a new empty solution

> dotnet new sln

7. Add the SampleApi project to the solution.

> dotnet sln add .\src\SampleApi\SampleApi.csproj