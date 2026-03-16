FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# copia o csproj
COPY *.csproj ./   
RUN dotnet restore

# copia todo o código da API
COPY . ./          
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "IssueFlowApi.dll"]