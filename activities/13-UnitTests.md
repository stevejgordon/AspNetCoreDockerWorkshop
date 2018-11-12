
# Adding Unit Test Project

For this activity, please ensure you have completed [Activity 12](12-DockerCompose.md).

## What's the plan?

We're going to add a unit test project with a simple test against the 'Hello' action of our 'SampleController'. We'll run the tests via the UI and/or the command line via the dotnet CLI. Finally we'll update the dockerfile so that tests are run during the Docker image build process.

## Activity Steps

1. Create a new Solution Folder called 'Test'.
2. Add a new XUnit based unit test project called 'SampleApi.Test', ensuring the location places the new project into a physical directory called 'Test' under your solution root directory.
 
![Add Test Project](../images/3-AddTestProject.png "Add Test Project")

3. Add a project reference to the SampleApi project from the new SampleApi.Test project.

![Add Project Reference](../images/4-TestProjectReferenceViaUi.png "Add Project Reference")

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.Test/SampleApi.Test.csproj reference src/SampleApi/SampleApi.csproj```

4. Add a NuGet package for the 'Moq' mocking library

![Add Moq Package](../images/5-TestProjectMoq.png "Add Moq Package")

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.Test/SampleApi.Test.csproj package Moq```

5. Add a NuGet package for the 'FluentAssertions' library

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.Test/SampleApi.Test.csproj package FluentAssertions```

6. Edit your SampleApi.Test project
 
![Edit Test Project](../images/6-EditTestProject.png "Edit Test Project")

7. Change the SDK at the top of the project file from 'Microsoft.NET.Sdk' to 'Microsoft.NET.Sdk.Web'.

8. Add an implicit reference to the aspnetcore metapackages to the PackageReference ItemGroup section 

```<PackageReference Include="Microsoft.AspNetCore.App" />```

At this point your project file should look like this...

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="FluentAssertions" Version="5.5.0" />
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.8.0" />
    <PackageReference Include="Moq" Version="4.10.0" />
    <PackageReference Include="xunit" Version="2.3.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.3.1" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\SampleApi\SampleApi.csproj" />
  </ItemGroup>

</Project>
```

9. Rename the default 'UnitTest1' class to 'SampleControllerTests' using your preferred refactoring approach (also updating the file name).

10. Rename the 'Test1' method to 'Hello_Should_ReturnExpectedWelcomeMessage'

11. Add the following body to the method which will excercise the Hello method...

```csharp
[Fact]
public void Hello_Should_ReturnExpectedWelcomeMessage()
{
    const string welcomeMessage = "TEST";
    const string name = "Bob";

    var expectedWelcome = $"{welcomeMessage} {name}";

    var mockOptions = new Mock<IOptions<MessagesConfiguration>>();
    mockOptions.Setup(x => x.Value).Returns(new MessagesConfiguration { WelcomeMessage = welcomeMessage });

    var sut = new SampleController(mockOptions.Object, new NullLogger<SampleController>());

    var actionResult = sut.Hello(name);

    var okResult = actionResult.Result.Should().BeAssignableTo<OkObjectResult>()
        .Which.Value.Should().BeAssignableTo<HelloOutputModel>()
            .Which.WelcomeMessage.Should().Be(expectedWelcome);
}
```

12. Include any required Using statements.

13. Run the unit test via your preferred test runner.

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet test test/SampleApi.Test/SampleApi.Test.csproj```

## End of Activity

The completed example for this activity can be found in the '/steps/13-Unit-Tests' folder.

[Return to README and activity links](../README.md)