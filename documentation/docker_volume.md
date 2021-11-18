# Docker volume a way to persit data when our container is restarted

As we seen last, we had a dotnet Web Api that was in a net with a sqlserver, but when we restarted the webapi container all data was lost

## Docker volumes make the statless persist something

As we know docker containers are thought a statless machines, so that they can be killed an respined at will. 
This very fact, sometimes presents a challange, specially if our container is database. Luckyly for us ther is a special part in docker called volumes, those are what we want to attach our db containers to, so when they are respawned that is all there.

A neat way to spin up out sqlserver container with a volume is:
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver_local -v sql-vol:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
```
Great video on that at [Ahsan youtube channel](https://www.youtube.com/watch?v=2Hs8AeP6gmA)


Of course, keeping up with the last example, you can also spin it inside the same net as you spawn your dotnet click counter api from previous examples with
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver_local -v sql-vol:/var/opt/mssql --network=click_count_network -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
```

