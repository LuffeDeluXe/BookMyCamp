FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 25002

ENV ASPNETCORE_URLS=http://+:25002

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["UserBlazor/UserBlazor.csproj", "UserBlazor/"]
RUN dotnet restore "UserBlazor/UserBlazor.csproj"
COPY . .
WORKDIR "/src/UserBlazor"
RUN dotnet build "UserBlazor.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "UserBlazor.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserBlazor.dll"]
