# Binding Data from the QueryString

For this activity, please ensure you have completed [Activity 4](5-BindingFromQueryString.md) and have your solution open in Visual Studio 2017.

1. Update the method signature of the Hello method to accept a string parameter called 'name'.

``` csharp
public ActionResult<HelloOutputModel> Hello(string name)
```

2. After the line which creates the HelloOutputModel, add the following code to update the WelcomeMessage...

``` csharp
var model = new HelloOutputModel();

model.WelcomeMessage = $"{model.WelcomeMessage} {name ?? "whoever you are!"}";
```

3. Run the application by pressing F5.
4. Append a query string parameter called 'name' with any value you want to the URL in your address bar.

> ?name=Steve

5. Press Enter to navigate to the updated URL.

## End of Activity

The completed example for this activity can be found in the '/steps/5-Binding-Data-From-Query-String' folder.

[Return to README and activity links](../README.md)