# cesp-database

### Run docker postgres docker container
```
docker run --name cesp-postgres -p 5432:5432 -e POSTGRES_PASSWORD=espanol123 -e POSTGRES_DB=cesp-db -d postgres
```

### Run dotnet migrations
```
dotnet ef database update
```
    