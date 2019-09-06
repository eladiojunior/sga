#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["SGA.WebApiGestaoNormas/SGA.WebApiGestaoNormas.csproj", "SGA.WebApiGestaoNormas/"]
RUN dotnet restore "SGA.WebApiGestaoNormas/SGA.WebApiGestaoNormas.csproj"
COPY . .
WORKDIR "/src/SGA.WebApiGestaoNormas"
RUN dotnet build "SGA.WebApiGestaoNormas.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SGA.WebApiGestaoNormas.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SGA.WebApiGestaoNormas.dll"]