#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["SGA.WebApiGestaoMineracao/SGA.WebApiGestaoMineracao.csproj", "SGA.WebApiGestaoMineracao/"]
RUN dotnet restore "SGA.WebApiGestaoMineracao/SGA.WebApiGestaoMineracao.csproj"
COPY . .
WORKDIR "/src/SGA.WebApiGestaoMineracao"
RUN dotnet build "SGA.WebApiGestaoMineracao.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SGA.WebApiGestaoMineracao.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SGA.WebApiGestaoMineracao.dll"]