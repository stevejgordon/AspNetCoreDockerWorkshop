
# Adding In Memory Integration Tests

For this activity, please ensure you have completed [Activity 13](12-UnitTests.md).

## What's the plan?

We're going to add an integration test project with a simple test against the 'Hello' endpoint of our API. 

## Activity Steps

1. Create a new Solution Folder called 'Test'.
2. Within your 'Test' solution folder, add a new XUnit based unit test project called 'SampleApi.IntegrationTest', ensuring the location places the new project into the physical 'Test' directory under your solution root directory (the same folder as we used for Step 13).

3. Add a project reference to the SampleApi project from the new SampleApi.IntegrationTest project.

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.IntegrationTest/SampleApi.IntegrationTest.csproj reference src/SampleApi/SampleApi.csproj```

4. Add a NuGet package for the 'Microsoft.AspNetCore.Mvc.Testing' library

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.IntegrationTest/SampleApi.IntegrationTest.csproj package Microsoft.AspNetCore.Mvc.Testing```

5. Add a NuGet package for the 'FluentAssertions' library

*If you prefer to do this via the command line you can run the following command from your solution root directory*

```dotnet add test/SampleApi.IntegrationTest/SampleApi.IntegrationTest.csproj package FluentAssertions```

6. Edit your SampleApi.Test project by right clicking and choosing 'Edit SampleApi.IntegrationTest.csproj'.

7. Change the SDK at the top of the project file from 'Microsoft.NET.Sdk' to 'Microsoft.NET.Sdk.Web'.

8. Add an implicit reference to the aspnetcore metapackages to the PackageReference ItemGroup section.

```<PackageReference Include="Microsoft.AspNetCore.App" />```

At this point your project file should look like this (although your package reference order may differ)...

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Testing" Version="2.1.3" />
    <PackageReference Include="FluentAssertions" Version="5.5.0" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.8.0" />
    <PackageReference Include="xunit" Version="2.3.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.3.1" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\SampleApi\SampleApi.csproj" />
  </ItemGroup>

</Project>
```

9. Rename the default 'UnitTest1' class to 'SampleControllerIntegrationTests' using your preferred refactoring approach (also updating the file name).

10. Update your class to implement 'IClassFixture<WebApplicationFactory<Startup>>'.

```csharp
public class SampleControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
```

11. Add a constructor which accepts a 'WebApplicationFactory<Startup>' and store this to a private read-only field.

```csharp
private readonly WebApplicationFactory<Startup> _factory;

public SampleControllerIntegrationTests(WebApplicationFactory<Startup> factory)
{
    _factory = factory;
}
```

12. Add a private constant string called 'JsonContentType' with a value of "application/json; charset=utf-8" to the top of your class.

```csharp
private const string JsonContentType = "application/json; charset=utf-8";
```

13. Rename the 'Test1' method to 'Hello_ReturnsExpectedContentType'

14. Update your test so that it looks like the block below. This will spin up a host and in-memory test web server before using the client to make a request to the 'Hello' endpoint. We are asserting some quite basic checks here but the tests can be far more involved.

```csharp
[Fact]
public async Task Hello_ReturnsExpectedContentType()
{
    var client = _factory.CreateClient();

    var response = await client.GetAsync("/Steve");

    response.EnsureSuccessStatusCode(); // Status Code 200-299
    response.Content.Headers.ContentType.ToString().Should().Be(JsonContentType);
}
```

15. Include any required Using statements.

16. Run the unit test via your preferred test runner.

17. You can also execute the test via the dotnet CLI. Run the following command from your solution root directory...

```dotnet test test/SampleApi.IntegrationTest/SampleApi.IntegrationTest.csproj```

## End of Activity

The completed example for this activity can be found in the '/steps/14-Integration-Tests' folder.

[Return to README and activity links](../README.md)