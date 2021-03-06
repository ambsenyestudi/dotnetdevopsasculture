# Docker network

Right now everything lives inside our dotnet API, but to make it more real let's add a database to the mix.

## SQL server
To have table on sql server lets install it from [docker hub](https://hub.docker.com/_/microsoft-mssql-server)
then create our container
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
```
then let's jump start our database with:
```
docker exec -it sqlserver /bin/bash/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Sample123$
```
We just connected to the sql command line inside our container, let's create our db and our table:
```
CREATE DATABASE CountsDb;
GO
USE CountsDb;
GO
CREATE TABLE Counts (Id int NOT NULl IDENTITY, Name varchar(255) NOT NULL)
GO
INSERT INTO Counts (Name) values ("Click")
GO
```
Now to check that there is a record inserted
```
SELECT * FROM Counts
```

## How containers see each other

Before this make sure that your sqlserver has information inside like we created before

First thing that we can do is link them togheter
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver_local -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
docker run --rm -it --name click_count_api_local -p 5010:5000 --link sqlserver_local -e ConnectionStrings__DefaultConnection='Server=sqlserver_local,1433;Database=CountsDb;uid=SA;Password=Sample123$;' click_count_api:v0.1
```

For docker, there is no such thing as localhost, so to make to containers see each other  we need a docker network:
```
docker network create your_network_name
```
Let's ensure we don have sqlserver running
```
docker stop sqlserver
docker rm sqlserver
```
Before running the docker server again remember that you need to have data on it or else entityframework won't work
then run
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver_local -h sqlserver_local --network=click_count_network -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
docker run --rm -it --name click_count_api_local -p 5010:5000 -e ConnectionStrings__DefaultConnection='Server=sqlserver_local,1433;Database=CountsDb;uid=SA;Password=Sample123$;' --network=click_count_network -d click_count_api:v0.1
```
* not working at the moment is it net, investigate
As soon as I add --network the container exists
great article on [entity framework with docker sql server](https://dzone.com/articles/net-core-and-sql-server-in-docker-part-1-building)

The only problem is that when we restart our web api container, the counter restarts to zero
