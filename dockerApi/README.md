# Docker API

How to use dotnet core API with docker container.

## Build

```bash

docker build . -t dotnet.api:v0.1

```

## Run

```bash
docker run -p 8080:80 -d dotnet.api:v0.1
```
