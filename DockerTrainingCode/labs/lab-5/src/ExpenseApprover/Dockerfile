FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
COPY . /src
RUN dotnet publish /src -o /app

FROM mcr.microsoft.com/dotnet/core/runtime:3.1
COPY --from=build /app /app
ENTRYPOINT ["dotnet", "/app/ExpenseApprover.dll"]