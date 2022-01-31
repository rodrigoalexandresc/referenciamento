#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["referenciamento.api/referenciamento.api.csproj", "referenciamento.api/"]
RUN dotnet restore "referenciamento.api/referenciamento.api.csproj"
COPY . .
WORKDIR "/src/referenciamento.api"
RUN dotnet build "referenciamento.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "referenciamento.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "referenciamento.api.dll"]