FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 25001

ENV ASPNETCORE_URLS=http://+:25001

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["AdminBlazor/AdminBlazor.csproj", "AdminBlazor/"]
RUN dotnet restore "AdminBlazor/AdminBlazor.csproj"
COPY . .
WORKDIR "/src/AdminBlazor"
RUN dotnet build "AdminBlazor.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "AdminBlazor.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdminBlazor.dll"]
