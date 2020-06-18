#wait for the SQL Server to come up
sleep 10s

#run the setup script to create the DB and the schema in the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Sa_Pa55word -d master -i /home/app/setup.sql