FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["sequence_search_problems_advanced__strings_step4/sequence_search_problems_advanced__strings_step4.csproj", "sequence_search_problems_advanced__strings_step4/"]
RUN dotnet restore "sequence_search_problems_advanced__strings_step4/sequence_search_problems_advanced__strings_step4.csproj"
COPY . .
WORKDIR "/src/sequence_search_problems_advanced__strings_step4"
RUN dotnet build "sequence_search_problems_advanced__strings_step4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sequence_search_problems_advanced__strings_step4.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sequence_search_problems_advanced__strings_step4.dll"]
