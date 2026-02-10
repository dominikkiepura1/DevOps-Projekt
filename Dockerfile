# Stage 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY DevOpsProjekt.sln .
COPY DevOpsProjekt.Api/DevOpsProjekt.Api.csproj DevOpsProjekt.Api/
COPY DevOpsProjekt.Tests/DevOpsProjekt.Tests.csproj DevOpsProjekt.Tests/

RUN dotnet restore

COPY . .
RUN dotnet publish DevOpsProjekt.Api/DevOpsProjekt.Api.csproj -c Release -o /app/publish

# Stage 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "DevOpsProjekt.Api.dll"]
