FROM postgres
ENV POSTGRES_DB my_database
EXPOSE 5432
COPY init.sql /docker-entrypoint-initdb.d/


#docker exec -it example_postgres_1 psql -U docker 
