#!/bin/bash

echo -e "\e[34m *****Starting Build*****\e[39m "
echo -e "\n \e[34m Restoring packages...\e[39m "
dotnet restore ../app
if [ $? != 0 ]; then
    echo "FAILED"
    exit 0
fi
echo -e "\n \e[34m Publishing...\e[39m "
dotnet publish ../app
if [ $? != 0 ]; then
    echo "FAILED"
    exit 0
fi
echo -e "\n \e[34m Building Containers...\e[39m "
docker-compose build
if [ $? != 0 ]; then
    echo "FAILED"
    exit 0
fi
echo -e "\n \e[34m Starting Containers\e[39m "
docker-compose up
