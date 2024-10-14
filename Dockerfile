# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5063

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CarApp.csproj", "./"]
RUN dotnet restore "CarApp.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "CarApp.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "CarApp.csproj" -c Release -o /app/publish

# Final stage to run the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarApp.dll"]
