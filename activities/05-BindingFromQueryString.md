# Binding Data from the QueryString

For this activity, please ensure you have completed [Activity 4](04-ReturningJsonData.md) and have your solution open in Visual Studio 2017.

## What's the plan?

We're going to explore binding data from the query string.

## Activity Steps

1. Update the method signature of the Hello method to accept a string argument called 'name'.

``` csharp
public ActionResult<HelloOutputModel> Hello(string name)
```

2. After the line which creates the HelloOutputModel, before the return statement, add the following line to update the WelcomeMessage on the model...

``` csharp
model.WelcomeMessage = $"{model.WelcomeMessage} {name ?? "whoever you are!"}";
```

3. Run the application by pressing F5.
4. Append a query string parameter called 'name' with any value you want to the URL in your address bar.

> ?name=Steve

5. Press Enter to navigate to the updated URL.

## End of Activity

By the end of this activity your completed action method should now look like this...
``` csharp
[Route("")]
public ActionResult<HelloOutputModel> Hello(string name)
{
    var model = new HelloOutputModel();
    model.WelcomeMessage = $"{model.WelcomeMessage} {name ?? "whoever you are!"}";
    return Ok(model);
}
```

The completed example for this activity can be found in the '/steps/05-Binding-Data-From-Query-String' folder.

Continue to [Activity 6](06-BindingFromRouteParameters.md).

[Return to README and activity links](../README.md)