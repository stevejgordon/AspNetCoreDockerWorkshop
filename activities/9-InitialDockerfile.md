
# Initial Dockerfile

For this activity, please ensure you have completed [Activity 8](8-Logging.md).

## Activity Steps

1. Copy the '.dockerignore' file from the 'resources' folder of this workshop repository and paste it into the root of your solution. *The same folder where your .sln file exists*
2. Create a new text document in the your root directory called 'dockerfile'. **It is important that you do not include an extension for this file**
3. Edit the 'dockerfile' in VS Code or Notepad (or your text editor of choice) and add the following...

```
FROM microsoft/dotnet:2.1-sdk

WORKDIR /app

COPY src/SampleApi .

RUN dotnet build

EXPOSE 80

ENTRYPOINT ["dotnet", "run"]
```

4. Save the file.
5. Open a command prompt window in the same directory as the dockerfile.
6. Build a docker image using the 'docker build' command...


```
docker build -t aspnetcore-workshop .
```

7. Once the build completes, run a docker container from the image using the 'docker run' command...


```
docker run -p 7001:80 aspnetcore-workshop
```
*NOTE: If the above fails because the port 7001 is use on your PC, try another port number.*

8. At this point, you should see some output from the ASP.NET Core logging after the application starts.
9. Open a browser window and navigate to [http://localhost:7001](http://localhost:7001/).
10. In the command prompt, press CTRL + C to detach from the container.
11. View the running containers with the 'docker container ps' command.


```
docker container ps
```

12. A single entry should exist for the container we have just been running. The first column will be the container ID.
13. Kill the container using the 'docker stop' command. It accepts a container ID. You only need to provide the first 2 or 3 characters.

```
docker stop <XYZ>
```

14. View the size of the image we created using the 'docker images' command.

```
docker images aspnetcore-workshop
```

## End of Activity

The completed example for this activity can be found in the '/steps/9-InitialDockerfile' folder.

[Return to README and activity links](../README.md)