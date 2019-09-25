# cesp-database

## run docker container on remote machine
```
docker run --name cesp-database --restart always -p 5432:5432 -e POSTGRES_PASSWORD=mSxqFn4x -e POSTGRES_DB=cesp-database -e POSTGRES_USER=cesp-user -d postgres 
```

### Set ASPNETCORE_ENVIRONMENT=Release per session
```
$Env:ASPNETCORE_ENVIRONMENT = "Release"
```

### Run dotnet migrations
```
dotnet ef database update
```