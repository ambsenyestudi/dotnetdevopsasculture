# Docker compose
Up until now we have seen how to build and run our docker containers, every new container meant new commands to learn, having to update one or more power shell scripts and things kept growing.

Now we had have everything in one place with docker compose. The default file is docker-compose.yml and it can contain your needed infromation

## Word of advise
If you don't have much experience in yml avoid using [-] or [$] in your yaml files. 

Following those instructions I changed:
1. sqlserver password from *Sample123$* to **Sample_123**
2. sqlserver volume name from *sql-vol* to **mssqldata**

> There is no problem with dots you could have nammed your volume ms.sql.data just the same

## Simpler with docker compose

As you can see, no need for linking or creating a network, with docker compose you only need depens on and you are set.