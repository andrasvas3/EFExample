FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/runtime:10.0
WORKDIR /app
COPY --from=build /app/src/EFExample/bin/Release/net10.0/publish/ .
ENTRYPOINT ["dotnet", "EFExample.dll"]
