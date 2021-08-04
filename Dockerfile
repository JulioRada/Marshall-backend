#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Marshall.Api/Marshall.Api.csproj", "src/Marshall.Api/"]
RUN dotnet restore "src/Marshall.Api/Marshall.Api.csproj"
COPY . .
WORKDIR "/src/src/Marshall.Api"
RUN dotnet build "Marshall.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Marshall.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Marshall.Api.dll"]