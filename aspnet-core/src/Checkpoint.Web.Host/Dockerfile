FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Checkpoint.Web.Host/Checkpoint.Web.Host.csproj", "src/Checkpoint.Web.Host/"]
COPY ["src/Checkpoint.Web.Core/Checkpoint.Web.Core.csproj", "src/Checkpoint.Web.Core/"]
COPY ["src/Checkpoint.Application/Checkpoint.Application.csproj", "src/Checkpoint.Application/"]
COPY ["src/Checkpoint.Core/Checkpoint.Core.csproj", "src/Checkpoint.Core/"]
COPY ["src/Checkpoint.EntityFrameworkCore/Checkpoint.EntityFrameworkCore.csproj", "src/Checkpoint.EntityFrameworkCore/"]
WORKDIR "/src/src/Checkpoint.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Checkpoint.Web.Host", "src/Checkpoint.Web.Host"]
COPY ["src/Checkpoint.Web.Core", "src/Checkpoint.Web.Core"]
COPY ["src/Checkpoint.Application", "src/Checkpoint.Application"]
COPY ["src/Checkpoint.Core", "src/Checkpoint.Core"]
COPY ["src/Checkpoint.EntityFrameworkCore", "src/Checkpoint.EntityFrameworkCore"]
WORKDIR "/src/src/Checkpoint.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Checkpoint.Web.Host.dll"]
