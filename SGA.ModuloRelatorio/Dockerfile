#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["SGA.ModuloRelatorio/SGA.ModuloRelatorio.csproj", "SGA.ModuloRelatorio/"]
RUN dotnet restore "SGA.ModuloRelatorio/SGA.ModuloRelatorio.csproj"
COPY . .
WORKDIR "/src/SGA.ModuloRelatorio"
RUN dotnet build "SGA.ModuloRelatorio.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SGA.ModuloRelatorio.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SGA.ModuloRelatorio.dll"]