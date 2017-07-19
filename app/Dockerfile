FROM microsoft/aspnetcore:1.1

RUN apt-get update

RUN apt-get install curl unzip -y

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l ~/vsdbg

WORKDIR /app
COPY bin/Debug/netcoreapp1.1/publish .
 
ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

 
ENTRYPOINT ["dotnet", "app.dll"]