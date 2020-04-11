FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WebApplicationInDocker/WebApplicationInDocker.csproj", "WebApplicationInDocker/"]
RUN dotnet restore "WebApplicationInDocker/WebApplicationInDocker.csproj"
COPY . .
WORKDIR "/src/WebApplicationInDocker"
RUN dotnet build "WebApplicationInDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplicationInDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplicationInDocker.dll"]