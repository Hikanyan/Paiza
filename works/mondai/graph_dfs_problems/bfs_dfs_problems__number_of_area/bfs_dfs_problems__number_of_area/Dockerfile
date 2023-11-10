FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["bfs_dfs_problems__number_of_area/bfs_dfs_problems__number_of_area.csproj", "bfs_dfs_problems__number_of_area/"]
RUN dotnet restore "bfs_dfs_problems__number_of_area/bfs_dfs_problems__number_of_area.csproj"
COPY . .
WORKDIR "/src/bfs_dfs_problems__number_of_area"
RUN dotnet build "bfs_dfs_problems__number_of_area.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bfs_dfs_problems__number_of_area.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bfs_dfs_problems__number_of_area.dll"]
