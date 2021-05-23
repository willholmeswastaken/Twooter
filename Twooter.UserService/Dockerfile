#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Twooter.UserService/Twooter.UserService.csproj", "Twooter.UserService/"]
RUN dotnet restore "Twooter.UserService/Twooter.UserService.csproj"
COPY . .
WORKDIR "/src/Twooter.UserService"
RUN dotnet build "Twooter.UserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Twooter.UserService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Twooter.UserService.dll"]
