# Creating a Controller and Action

For this activity, please ensure you have completed [Activity 2](02-CreateEmptyWebProject.md).

## What's the plan?

We're going to create our first ASP.NET Core MVC controller and an action to handle requests to the root path for the API.

## Activity Steps

1. Open your SampleApi.sln in Visual Studio 2017.
1. Create a new folder call 'Controllers' under the SampleApi project.
1. Create a class called 'SampleController' in the Controllers folder.
1. Update the class to inherit from the ControllerBase abstract class.

``` csharp
public class SampleController : ControllerBase
```

*NOTE: This will require the a using statement for 'Microsoft.AspNetCore.Mvc'.*

5. Add the  [ApiController] attribute to the class.

``` csharp
[ApiController]
public class SampleController : ControllerBase
```

6. Create a method as follows...

``` csharp
[Route("")]
public string Hello()
{
    return "Hello";
}
```

7. Open the Startup class.
8. Add the following line to the ConfigureServices method to register the MVC services with DI.

```csharp
 services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
```

*NOTE: A using statement will be required for 'Microsoft.AspNetCore.Mvc'.*

9. Replace the app.Run call in the 'Configure' method with the following...

```csharp
app.UseMvc();
```

7. Run the application by pressing F5.

## End of Activity

The completed example for this activity can be found in the '/steps/03-Create-Controller-And-Action' folder.

[Return to README and activity links](../README.md)