# ASP.NET Core and Docker Workshop

## Pre-requisite Setup

1. Clone this repository locally
1. Install Postman for Windows - [Download Postman](https://www.getpostman.com/apps)

## What You'll Be Building

In this workshop you will build a simple ASP.NET Core API from scratch, initially using the .NET SDK CLI. The finished API will have two endpoints, one returning data via HTTP GET and the other accepting data via HTTP POST. It will make use of ASP.NET Core configuration.

You'll then create a Docker image for your API and run it as a Docker container.

## Activities

| Activity | Topics |
| ----- | ---- |
| [Activity #1](/activities/01-InstallTooling.md) | Install the .NET Core SDK and Docker tooling |
| [Activity #2](/activities/02-CreateEmptyWebProject.md) | Create an empty web project via the command line |
| [Activity #3](/activities/03-CreateControllerAndAction.md) | Create a controller and action |
| [Activity #4](/activities/04-ReturningJsonData.md) | Returning JSON Data |
| [Activity #5](/activities/05-BindingFromQueryString.md) | Binding data from the query string |
| [Activity #6](/activities/06-BindingFromRouteParameters.md) | Binding data from route parameters |
| [Activity #7](/activities/07-AcceptingPostedData.md) | Accepting posted data |
| [Activity #8](/activities/08-Configuration.md) | Application configuration |
| [Activity #9](/activities/09-Logging.md) | Working with logging |
| [Activity #10](/activities/10-InitialDockerfile.md) | Initial Dockerfile |
| [Activity #11](/activities/11-ProductionDockerfile.md) | Production Dockerfile |
| [Activity #12](/activities/12-DockerCompose.md) | Working with Docker Compose |
| [Activity #13](/activities/13-UnitTests.md) | Adding some unit tests |
| [Activity #14](/activities/13-IntegrationTests.md) | Adding an integration test |