FROM microsoft/mssql-server-linux:latest

RUN apt-get -y update

# Create app directory
RUN mkdir -p /home/app
WORKDIR /home/app

# copy scripts - LAST arg is DESTINATION
COPY initdb.sh entrypoint.sh /home/app/

RUN chmod +x /home/app/initdb.sh

CMD ["/bin/bash ./entrypoint.sh"]