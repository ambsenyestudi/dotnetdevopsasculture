# Docker volumes

Currently our app has 2 problems, we need to know too much stuff by hard and if we restart our container, we lose our click count. The latter my not seem like much at first sight since docker containers were designed as stateless. 

You would ask yourself why not use a database?
Well, there are configuration things that are way to small for a database, but we don’t want to lose if a container restarts, that is where volumes kick in.

## To avoid having to rember so many commands an flags: Powershell scripts

We are going to create a two files to store what we discussed previously:
* build.ps1 [Build a docker image](dockerize_front_end.md/Dockerize_your_app)
* run.ps1 [Run a container from your docker image](dockerize_front_end.md/Run_a_container_from_your_docker_image)