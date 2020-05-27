FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["CsvParser/CsvParser.csproj", "CsvParser/"]
RUN dotnet restore "CsvParser/CsvParser.csproj"
COPY . .
WORKDIR "/src/CsvParser"
RUN dotnet build "CsvParser.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CsvParser.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CsvParser.dll"]
