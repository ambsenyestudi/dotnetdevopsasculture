FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["src/DefaultWebAPI/DefaultWebAPI/DefaultWebAPI.csproj", "src/DefaultWebAPI/DefaultWebAPI/"]
RUN dotnet restore "src/DefaultWebAPI/DefaultWebAPI/DefaultWebAPI.csproj"
COPY . .
WORKDIR "/src/src/DefaultWebAPI/DefaultWebAPI"
RUN dotnet build "DefaultWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DefaultWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DefaultWebAPI.dll"]
