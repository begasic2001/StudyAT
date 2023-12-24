#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Reactivities.API/Reactivities.API.csproj", "Reactivities.API/"]
COPY ["Reactivities.Application/Reactivities.Application.csproj", "Reactivities.Application/"]
COPY ["Reactivities.Domain/Reactivities.Domain.csproj", "Reactivities.Domain/"]
COPY ["Reactivities.Persistence/Reactivities.Persistence.csproj", "Reactivities.Persistence/"]
COPY ["Reactivities.Infrastructure/Reactivities.Infrastructure.csproj", "Reactivities.Infrastructure/"]
RUN dotnet restore "Reactivities.API/Reactivities.API.csproj"
COPY . .
WORKDIR "/src/Reactivities.API"
RUN dotnet build "Reactivities.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reactivities.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reactivities.API.dll"]