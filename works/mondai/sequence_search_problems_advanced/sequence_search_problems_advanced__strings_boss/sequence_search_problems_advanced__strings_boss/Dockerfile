FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["sequence_search_problems_advanced__strings_boss/sequence_search_problems_advanced__strings_boss.csproj", "sequence_search_problems_advanced__strings_boss/"]
RUN dotnet restore "sequence_search_problems_advanced__strings_boss/sequence_search_problems_advanced__strings_boss.csproj"
COPY . .
WORKDIR "/src/sequence_search_problems_advanced__strings_boss"
RUN dotnet build "sequence_search_problems_advanced__strings_boss.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sequence_search_problems_advanced__strings_boss.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sequence_search_problems_advanced__strings_boss.dll"]
