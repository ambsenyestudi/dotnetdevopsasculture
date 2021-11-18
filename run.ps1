docker run `
    -e "ACCEPT_EULA=Y" `
    -e "SA_PASSWORD=Sample123$" `
    -p 1433:1433 `
    --name sqlserver_local `
    -v sql-vol:/var/opt/mssql `
    --network=click_count_network `
    -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04 `
docker run `
    --rm `
    -it `
    --name click_count_api_local `
    -p 5010:5000 `
    -e ConnectionStrings__DefaultConnection='Server=sqlserver_local,1433;Database=CountsDb;uid=SA;Password=Sample123$;' `
    --network=click_count_network `
    -d click_count_api:v0.2