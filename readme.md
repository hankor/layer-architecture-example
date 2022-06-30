# Initializing the database
- dotnet tool install --global dotnet-ef

- dotnet ef migrations add initial -p DAL -s UI
- dotnet ef database update -p DAL -s UI