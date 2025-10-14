\# MathGame



A simple C# CLI math game.





\## Containerizing and Running with Docker



This project includes a Dockerfile for building and running the CLI app in a container.



\### Build the Docker Image



```sh

docker build -t mathgame .

```

This command builds a Docker image named `mathgame` using the Dockerfile in the current directory.



\### Run the CLI App Interactively



```sh

docker run -it mathgame

```

\- `-it` attaches your terminal so you can interact with the app.



\### (Optional) Expose Ports



If your app uses networking, you can expose ports (not needed for a basic CLI app):



```sh

docker run -it -p 8080:80 mathgame

```

\- `-p 8080:80` maps port 80 in the container to port 8080 on your host.



---



\## Notes



\- Make sure you use `-it` for interactive CLI apps.

\- The Dockerfile uses the official .NET SDK and runtime images.

