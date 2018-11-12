
# Docker Compose

For this activity, please ensure you have completed [Activity 10](10-ProductionDockerfile.md).

## Activity Steps

1. Create a new text document in the your root directory called 'docker-compose.yml'.
2. Edit the 'docker-compose.yml' in VS Code or Notepad (or your text editor of choice) and add the following...

```
version: '3'

services:

  api-service:
    build:
      context: .
    ports:
     - "10001:80"
    environment:
      - "Messages__WelcomeMessage=Hello from Docker"
    container_name: sample-api-service
```

3. Save the file.
4. Open a command prompt window in the same directory as the Docker compose file.
5. Run the compose file using the docker-compose command...


```
docker-compose up -d
```
*The -d switch starts in detached mode*

6. Open a browser window and navigate to [http://localhost:10001](http://localhost:10001/).

*Note that the welcome message has been loaded from the environment variable set in the compose file*

7. In the command prompt, view the running containers

```
docker-compose ps
```

8. Stop the container...

```
docker-compose stop
```

## End of Activity

The completed example for this activity can be found in the '/steps/11-Docker-Compose' folder.

[Return to README and activity links](../README.md)