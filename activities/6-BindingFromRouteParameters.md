# Binding Data from the QueryString

For this activity, please ensure you have completed [Activity 5](5-BindingFromQueryString.md) and have your solution open in Visual Studio 2017.

## What's the plan?

We're going to explore binding data from route parameters.

## Activity Steps

1. Update the route attribute to include an optional route parameter.

``` csharp
[Route("{name?}")]
```

2. Run the application by pressing F5.
3. Add a suffix to the path of the URL to pass your name which will be bound to the action argument. e.g. '/Steve'.
4. Press Enter to navigate to the updated URL.

## End of Activity

The completed example for this activity can be found in the '/steps/6-Binding-From-Route-Parameters' folder.

[Return to README and activity links](../README.md)