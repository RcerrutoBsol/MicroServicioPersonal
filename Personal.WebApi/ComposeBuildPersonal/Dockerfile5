#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Personal.WebApi/Personal.WebApi.csproj", "Personal.WebApi/"]
COPY ["Personal.Application/Personal.Application.csproj", "Personal.Application/"]
COPY ["PersonalDomain/Personal.Domain.csproj", "PersonalDomain/"]
COPY ["ShareKernel/ShareKernel.csproj", "ShareKernel/"]
RUN dotnet restore "Personal.WebApi/Personal.WebApi.csproj"
COPY . .
WORKDIR "/src/Personal.WebApi"
RUN dotnet build "Personal.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Personal.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Personal.WebApi.dll"]