#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Something.Migrator/Something.Migrator.csproj", "src/Something.Migrator/"]
COPY ["src/Something.Core/Something.Core.csproj", "src/Something.Core/"]
COPY ["src/Something.EntityFrameworkCore/Something.EntityFrameworkCore.csproj", "src/Something.EntityFrameworkCore/"]
RUN dotnet restore "src/Something.Migrator/Something.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Something.Migrator"
RUN dotnet build "Something.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Something.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Something.Migrator.dll", "-q"]
