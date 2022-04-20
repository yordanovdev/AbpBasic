#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 44311

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Something.Web.Host/Something.Web.Host.csproj", "src/Something.Web.Host/"]
COPY ["src/Something.Web.Core/Something.Web.Core.csproj", "src/Something.Web.Core/"]
COPY ["src/Something.EntityFrameworkCore/Something.EntityFrameworkCore.csproj", "src/Something.EntityFrameworkCore/"]
COPY ["src/Something.Core/Something.Core.csproj", "src/Something.Core/"]
COPY ["src/Something.Application/Something.Application.csproj", "src/Something.Application/"]
RUN dotnet restore "src/Something.Web.Host/Something.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Something.Web.Host"
RUN dotnet build "Something.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Something.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["/src/Something.Web.Host/cert/aspnetapp.pfx", "/https/aspnetapp.pfx"]
COPY ["/src/Something.Web.Host/cert/aspnetapp.crt", "/https/aspnetapp.crt"]
COPY ["/src/Something.Web.Host/cert/aspnetapp.key", "/https/aspnetapp.key"]
RUN update-ca-certificates

ENTRYPOINT ["dotnet", "Something.Web.Host.dll"]
