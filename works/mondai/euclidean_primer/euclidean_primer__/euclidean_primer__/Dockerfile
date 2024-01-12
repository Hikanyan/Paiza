FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["euclidean_primer__/euclidean_primer__.csproj", "euclidean_primer__/"]
RUN dotnet restore "euclidean_primer__/euclidean_primer__.csproj"
COPY . .
WORKDIR "/src/euclidean_primer__"
RUN dotnet build "euclidean_primer__.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "euclidean_primer__.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "euclidean_primer__.dll"]
