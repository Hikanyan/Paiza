FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["topological_sort_problems__directed_graph_input/topological_sort_problems__directed_graph_input.csproj", "topological_sort_problems__directed_graph_input/"]
RUN dotnet restore "topological_sort_problems__directed_graph_input/topological_sort_problems__directed_graph_input.csproj"
COPY . .
WORKDIR "/src/topological_sort_problems__directed_graph_input"
RUN dotnet build "topological_sort_problems__directed_graph_input.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "topological_sort_problems__directed_graph_input.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "topological_sort_problems__directed_graph_input.dll"]
