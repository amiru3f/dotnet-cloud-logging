FROM mcr.microsoft.com/dotnet/sdk:7.0.100-preview.4-bullseye-slim-amd64 as build
WORKDIR /app
COPY . .
WORKDIR /app/SenderWorker

RUN dotnet restore
RUN dotnet build

FROM mcr.microsoft.com/dotnet/sdk:7.0.100-preview.4-bullseye-slim-amd64
WORKDIR /app
COPY --from=build /app/SenderWorker/bin/Debug/net7.0 .

ENTRYPOINT [ "dotnet", "SenderWorker.dll" ]