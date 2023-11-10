FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["a_rank_camp_step2/a_rank_camp_step2.csproj", "a_rank_camp_step2/"]
RUN dotnet restore "a_rank_camp_step2/a_rank_camp_step2.csproj"
COPY . .
WORKDIR "/src/a_rank_camp_step2"
RUN dotnet build "a_rank_camp_step2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "a_rank_camp_step2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "a_rank_camp_step2.dll"]
