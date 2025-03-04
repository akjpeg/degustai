FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

COPY . .

RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "DegustAi.dll"]
