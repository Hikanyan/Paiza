FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["bfs_dfs_problems__grid_dfs_three_times/bfs_dfs_problems__grid_dfs_three_times.csproj", "bfs_dfs_problems__grid_dfs_three_times/"]
RUN dotnet restore "bfs_dfs_problems__grid_dfs_three_times/bfs_dfs_problems__grid_dfs_three_times.csproj"
COPY . .
WORKDIR "/src/bfs_dfs_problems__grid_dfs_three_times"
RUN dotnet build "bfs_dfs_problems__grid_dfs_three_times.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bfs_dfs_problems__grid_dfs_three_times.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bfs_dfs_problems__grid_dfs_three_times.dll"]
