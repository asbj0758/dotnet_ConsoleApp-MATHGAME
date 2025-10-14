FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /MathGame

# Copy everything
COPY /. ./
# Restore as distinct layers
RUN dotnet restore MathGame.csproj
# Build and publish a release
RUN dotnet publish MathGame.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:9.0
COPY --from=build /MathGame/out .
ENTRYPOINT ["dotnet", "MathGame.dll"]