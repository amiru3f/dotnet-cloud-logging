FROM mcr.microsoft.com/dotnet/sdk:7.0.100-preview.4-bullseye-slim-amd64 as build
WORKDIR /app
COPY . .
WORKDIR /app/ReceiverWorker

RUN dotnet restore -v diag
RUN dotnet build

FROM mcr.microsoft.com/dotnet/sdk:7.0.100-preview.4-bullseye-slim-amd64
WORKDIR /app
COPY --from=build /app/ReceiverWorker/bin/Debug/net7.0 .

ENTRYPOINT [ "dotnet", "ReceiverWorker.dll" ]