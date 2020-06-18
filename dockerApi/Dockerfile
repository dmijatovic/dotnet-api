# Get base dotnet image for build section
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build-env

# set workdirectory
WORKDIR /api

# copy C# project file to /api
COPY *.csproj ./
RUN dotnet restore

# copy all other files (except .dockerignore)
COPY . ./
RUN dotnet publish -c Release -o build


# create runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
WORKDIR /api
EXPOSE 80
COPY --from=build-env /api/build .
ENTRYPOINT [ "dotnet", "dockerApi.dll"]