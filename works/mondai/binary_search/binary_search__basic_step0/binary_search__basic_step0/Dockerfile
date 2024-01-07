FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["binary_search__basic_step0/binary_search__basic_step0.csproj", "binary_search__basic_step0/"]
RUN dotnet restore "binary_search__basic_step0/binary_search__basic_step0.csproj"
COPY . .
WORKDIR "/src/binary_search__basic_step0"
RUN dotnet build "binary_search__basic_step0.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "binary_search__basic_step0.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "binary_search__basic_step0.dll"]
