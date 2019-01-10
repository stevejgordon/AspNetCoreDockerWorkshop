
# Production Dockerfile

For this activity, please ensure you have completed [Activity 10](10-InitialDockerfile.md).

## What's the plan?

We're going to improve our dockerfile, using a multistage build to produce a runtime based production image.

## Activity Steps

1. Edit the 'dockerfile' in VS Code or Notepad (or your text editor of choice) and add the following...

```
# Build image

FROM microsoft/dotnet:2.1-sdk as publish

WORKDIR /publish

COPY src/SampleApi/*.csproj ./src/SampleApi/

RUN dotnet restore src/SampleApi/SampleApi.csproj --verbosity quiet 

COPY ./src ./src

RUN dotnet publish src/SampleApi/SampleApi.csproj --output ../../out -c Release --no-restore --verbosity quiet /clp:ErrorsOnly

# Optimised final image

FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine

ENTRYPOINT ["dotnet", "SampleApi.dll"]

WORKDIR /app

EXPOSE 80

COPY --from=publish /publish/out .
```

2. Save the file.
3. Open a command prompt window in the same directory as the dockerfile.
4. Build a docker image using the 'docker build' command...


```
docker build -t aspnetcore-workshop-prod .
```

5. Once the build completes, run a docker container from the image using the 'docker run' command...


```
docker run -p 7001:80 aspnetcore-workshop-prod
```
*NOTE: If the above fails because the port 7001 is use on your PC, try another port number.*

6. At this point, you should see some output from the ASP.NET Core logging after the application starts.
7. Open a browser window and navigate to [http://localhost:7001](http://localhost:7001/).
8. In the command prompt, press CTRL + C to detach from the container.
9. View the running containers with the 'docker container ps' command.


```
docker container ps
```

10. A single entry should exist for the container we have just been running. The first column will be the container ID.
11. Kill the container using the 'docker stop' command. It accepts a container ID. You only need to provide the first 2 or 3 characters.

```
docker stop <XYZ>
```

12. View the size of the image we created using the 'docker images' command.

```
docker images aspnetcore-workshop-prod
```

## End of Activity

The completed example for this activity can be found in the '/steps/11-Production-Dockerfile' folder.

Continue to [Activity 12](12-DockerCompose.md).

[Return to README and activity links](../README.md)
