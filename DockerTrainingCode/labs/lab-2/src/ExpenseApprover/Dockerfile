FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY . /src
RUN dotnet publish /src -o /app
ENTRYPOINT ["dotnet", "/app/ExpenseApprover.dll"]