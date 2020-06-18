# Dotnet CORE

This repo is created to learn dotnet core and C# for api.

## Installation on Ubuntu 18.04

I choose to install dotnet core for [Ubuntu 18.04](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#1804-) on my Linuxt Mint machine.

```bash
# set package source
wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

# install dotnet-core
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-3.1
```

## Create new project

To create new project use command line and keywoard new. For help type `dotnet new --help`.

Projects created:

- api-demo: to create dotnet api demo
- react-demo-1: this is monolith, backend and frontend in one.
- baseApi: basic api in C# and dotnet core
- hello-world: basic C# console app
- jwt-api: applying jwt and Azure AD demo from youtube
- react-demo-1: default dotnet core scaffolding of react app

## IDE Visual Studio Code

I used Visual Studio Code as IDE during development. VSC works quite well and I do not see any need of using fullblown Visual Studio .NET IDE. I preffer VSC because is much lighter. In addition I am using VSC for quite some time and I get used to it. My final conclusion is that anno 2020 you can develop dotnet C# api's using Linux and Visual Studio Code.

## Docker containers

I did basic implementation of MSSQL as Docker container and run it on Linux machines. In general this worked OK. The image file of MSSQL is significantly larger than the one of Postgres (1.5GB vs 312MB)

On the other side dotnet container is smaller than python/flask api container.

Looking at the container sizes I believe that Node api is the smallest in the alpine version.

This comparison in the container sizes indicates that looking at optimal approach is to look at the complete solution which consists of: front-end, backend api and db. Working with containers enables us to look at the footprint of the complete solution.
