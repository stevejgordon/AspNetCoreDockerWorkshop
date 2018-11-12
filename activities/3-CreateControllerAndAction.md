# Creating a Controller and Action

For this activity, please ensure you have completed [Activity 2](2-CreateEmptyWebProject.md) and have your solution open in Visual Studio 2017.

## What's the plan?

We're going to create our first ASP.NET Core MVC controller and an action to handle requests to the root path for the API.

## Activity Steps

1. Create a new folder call 'Controllers' inside the SampleApi project.
2. Create a class called 'SampleController' in the Controllers folder.
3. Update the class to inherit from the Controller abstract class.

``` csharp
public class SampleController : Controller
```

4. Add the  [ApiController] attribute to the class.

``` csharp
[ApiController]
public class SampleController : Controller
```

5. Create a method as follows...

``` csharp
[Route("")]
public IActionResult Hello()
{
    return "Hello";
}
```

6. Run the application by pressing F5.

## End of Activity

The completed example for this activity can be found in the '/steps/3-Create-Controller-And-Action' folder.

[Return to README and activity links](../README.md)