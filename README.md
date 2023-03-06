# MutexBetweenDockerContainers
Test console application to test the operation of the mutex between docker containers

Command for run docker containers:
```
docker run --name mutexContainer1 --pid=host --ipc=host --volume=C:/mutex:/tmp/.dotnet/shm/ mutexImage
```
