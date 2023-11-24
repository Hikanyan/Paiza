FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["grid_dijkstra__d0/grid_dijkstra__d0.csproj", "grid_dijkstra__d0/"]
RUN dotnet restore "grid_dijkstra__d0/grid_dijkstra__d0.csproj"
COPY . .
WORKDIR "/src/grid_dijkstra__d0"
RUN dotnet build "grid_dijkstra__d0.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "grid_dijkstra__d0.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "grid_dijkstra__d0.dll"]
