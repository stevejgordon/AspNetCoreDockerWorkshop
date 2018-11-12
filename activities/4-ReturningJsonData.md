# Returning JSON Data

For this activity, please ensure you have completed [Activity 3](3-CreateControllerAndAction.md) and have your solution open in Visual Studio 2017.

## Activity Steps

1. Create a new folder call 'OutputModels' inside the SampleApi project.
2. Create a class called 'HelloOutputModel' in the OutputModels folder.
3. Add the following Property declaration to the class...

``` csharp
public string WelcomeMessage { get; set; } = "Hello";
```

4. Update the Hello method in the SampleController to instantiate an instance of the HelloOutputModel before the return statement.

``` csharp
var model = new HelloOutputModel();
return "Hello";
```

5. Update the return statement to return the object.

``` csharp
var model = new HelloOutputModel();
return Ok(model);
```

6. Update the method signature to return `ActionResult<HelloOutputModel>`

``` csharp
public ActionResult<HelloOutputModel> Hello()
```

6. Run the application by pressing F5.

## End of Activity

The completed example for this activity can be found in the '/steps/4-Returning-JSON-Data' folder.

[Return to README and activity links](../README.md)