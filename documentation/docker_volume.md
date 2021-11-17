# Docker volume a way to persit data when our container is restarted

As we seen last, we had a dotnet Web Api that was in a net with a sqlserver, but when we restarted the webapi container all data was lost

## Docker volumes make the statless persist something

As we know docker containers are thoght a statless machines, so the can be killed an respined at will. 
Sometimes it presents a challange, specially if our container is database, so let's try to solve it with docker volumes

A neat way to spin up out sqlserver container with a volume is:
```
docker run -it -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sample123$" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04 -v sqlvolume:/var/opt/ mssql--network=click_count_network
```