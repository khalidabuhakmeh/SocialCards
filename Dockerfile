FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SocialCards.csproj", "./"]
RUN dotnet restore "SocialCards.csproj"
COPY . .
WORKDIR "/src/SocialCards"
RUN dotnet build "SocialCards.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SocialCards.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SocialCards.dll"]
