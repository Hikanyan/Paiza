FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["euclidean_advanced__gcd/euclidean_advanced__gcd.csproj", "euclidean_advanced__gcd/"]
RUN dotnet restore "euclidean_advanced__gcd/euclidean_advanced__gcd.csproj"
COPY . .
WORKDIR "/src/euclidean_advanced__gcd"
RUN dotnet build "euclidean_advanced__gcd.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "euclidean_advanced__gcd.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "euclidean_advanced__gcd.dll"]
