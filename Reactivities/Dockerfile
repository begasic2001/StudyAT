FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 9090

# copy .csproj and restore as distinct layers
COPY ["Reactivities.sln", "Reactivities.sln"]
COPY ["Reactivities.API/Reactivities.API.csproj", "Reactivities.API/"]
COPY ["Reactivities.Application/Reactivities.Application.csproj", "Reactivities.Application/"]
COPY ["Reactivities.Domain/Reactivities.Domain.csproj", "Reactivities.Domain/"]
COPY ["Reactivities.Persistence/Reactivities.Persistence.csproj", "Reactivities.Persistence/"]
COPY ["Reactivities.Infrastructure/Reactivities.Infrastructure.csproj", "Reactivities.Infrastructure/"]

RUN dotnet restore "Reactivities.sln"

COPY . .
WORKDIR /app
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Reactivities.API.dll"]