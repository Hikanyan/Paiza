FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["dag_memoization__problems_step0/dag_memoization__problems_step0.csproj", "dag_memoization__problems_step0/"]
RUN dotnet restore "dag_memoization__problems_step0/dag_memoization__problems_step0.csproj"
COPY . .
WORKDIR "/src/dag_memoization__problems_step0"
RUN dotnet build "dag_memoization__problems_step0.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "dag_memoization__problems_step0.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dag_memoization__problems_step0.dll"]
