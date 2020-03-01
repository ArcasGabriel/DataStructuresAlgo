#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-nanoserver-1903 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["DataStructuresAlgo/DataStructuresAlgo.csproj", "DataStructuresAlgo/"]
RUN dotnet restore "DataStructuresAlgo/DataStructuresAlgo.csproj"
COPY . .
WORKDIR "/src/DataStructuresAlgo"
RUN dotnet build "DataStructuresAlgo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataStructuresAlgo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataStructuresAlgo.dll"]
