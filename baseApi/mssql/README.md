# MS SQL Express 2020

This is MS SQL lite version in docker container using docker-compose.

MS SQL container is [from this docker hub](https://hub.docker.com/_/microsoft-mssql-server). This is official version for Linux, Ubuntu 16.04

## Connect to container

```bash
# connect to mssql using docker
docker exec -it <container_id|container_name> /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P <your_password>

# using docker compose
docker-compose exec ms-sql /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Sa_Pa55word
```

## SQL queries with

```sql
-- show all tables
SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE';
GO

-- other options
SELECT NAME, CREATE_DATE from sys.Tables;
GO

-- exit sqlcmd
exit
```

### SQL running dql files

```bash
# run sqlcmd tool with setup.sql to create database and tables
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Yukon900 -d master -i setup.sql

```
