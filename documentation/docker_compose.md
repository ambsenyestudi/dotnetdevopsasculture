# Docker compose
Now we had script with all our docker commands in them, let's have single place for them. You can have a docker-compose.yml that has all your needed infromation
## Word of advise
If you don't have much experience in yml avoid using [-] or [$] in your yaml files. 

Following those instructions I changed:
1. sqlserver password from *Sample123$* to **Sample_123**
2. sqlserver volume name from *sql-vol* to **mssqldata**

> There is no problem with dots you could have nammed your volume ms.sql.data just the same