FROM postgis/postgis:15-3.4
COPY init.sql /docker-entrypoint-initdb.d/init.sql
