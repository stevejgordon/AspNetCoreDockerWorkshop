# Returning JSON Data

For this activity, please ensure you have completed [Activity 3](03-CreateControllerAndAction.md) and have your solution open in Visual Studio 2017.

## What's the plan?

We're going to update our action to return a JSON result.

## Activity Steps

1. Create a new folder call 'OutputModels' inside the SampleApi project.
2. Create a class called 'HelloOutputModel' in the OutputModels folder.
3. Add the following Property declaration to the class...

``` csharp
public string WelcomeMessage { get; set; } = "Hello";
```

4. Update the 'Hello' method in the 'SampleController' so that the method returns `ActionResult<HelloOutputModel>`

``` csharp
public ActionResult<HelloOutputModel> Hello()
```

5. Update the 'Hello' method to instantiate an instance of the HelloOutputModel before the return statement.

``` csharp
var model = new HelloOutputModel();
```
*NOTE: You'll need to include a using statement for 'SampleApi.OutputModels'*

6. Update the return statement to return the object.

``` csharp
return Ok(model);
```

7. Run the application by pressing F5.

## End of Activity

By the end of this activity your completed action method should now look like this...
``` csharp
[Route("")]
public ActionResult<HelloOutputModel> Hello()
{
    var model = new HelloOutputModel();
    return Ok(model);
}
```

The completed example for this activity can be found in the '/steps/04-Returning-JSON-Data' folder.

[Return to README and activity links](../README.md)