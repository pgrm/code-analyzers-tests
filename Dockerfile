FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS restore
WORKDIR /app
COPY . .
RUN dotnet build Test.sln
