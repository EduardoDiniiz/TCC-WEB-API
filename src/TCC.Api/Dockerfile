#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY src/TCC.Api/TCC.Api.csproj src/TCC.Api/
COPY src/TCC.Business/TCC.Business.csproj src/TCC.Business/
COPY src/TCC.Data/TCC.Data.csproj src/TCC.Data/
RUN dotnet restore "src/TCC.Api/TCC.Api.csproj"
COPY . .
WORKDIR "/src/src/TCC.Api"
RUN dotnet build "TCC.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TCC.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TCC.Api.dll"]
