#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY MBKC.API/. ./MBKC.API/
COPY MBKC.Service/. ./MBKC.Service/
COPY MBKC.Repository/. ./MBKC.Repository/
RUN dotnet restore ./MBKC.API/./MBKC.API.csproj

WORKDIR /src/MBKC.API
RUN dotnet build ./MBKC.API.csproj -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish ./MBKC.API.csproj -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:5000
ENV TZ="Asia/Ho_Chi_Minh"
ENTRYPOINT ["dotnet", "MBKC.API.dll"]
