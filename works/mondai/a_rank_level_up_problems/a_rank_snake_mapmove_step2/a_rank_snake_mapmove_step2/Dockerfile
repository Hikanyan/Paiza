FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["a_rank_snake_mapmove_step2/a_rank_snake_mapmove_step2.csproj", "a_rank_snake_mapmove_step2/"]
RUN dotnet restore "a_rank_snake_mapmove_step2/a_rank_snake_mapmove_step2.csproj"
COPY . .
WORKDIR "/src/a_rank_snake_mapmove_step2"
RUN dotnet build "a_rank_snake_mapmove_step2.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "a_rank_snake_mapmove_step2.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "a_rank_snake_mapmove_step2.dll"]
