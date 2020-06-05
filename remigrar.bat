dotnet ef database drop
rmdir /q /s Migrations
dotnet ef migrations add Inicio001
dotnet ef database update 
dotnet run  