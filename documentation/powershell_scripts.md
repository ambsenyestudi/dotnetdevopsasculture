# Automate Docker commands with Powershell

Right now, we need to remember each and every command and flag to be able to run our container, this is a lot. Therefore, the most efficient way to automate this tedious task is to have a couple of scripts to do it for us.

Since I'm a windows user, my scripting of choice is power shell.

## Build and run automation

At the root folder of this project I have create two script:
* build.ps1
* run.ps1

## Click counting API

The project now has evolved in to a DDD layered project that count clicks. There are two methods:
* Get: http://localhost:5010/count that returns total count
* Update: http://localhost:5010/count that increments by 1 and returns total count

This works fine, but since containers can restart, we might lose all our data.
Try updating a couple of times the count though postman and then running the following command:
```
docker restart your_container_name
```

What happens here is that since we restarted the container the count is back to zero
[Back](../README.md)
