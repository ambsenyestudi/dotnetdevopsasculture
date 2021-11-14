# Dotnet command line

First things first are you familiar with dotnet command line?
When starting with devops it is really difficult to know why a pipeline fails. 
A smart way to speed things up is to try and publish it on your local machine to ensure 
that your project can build a release version.


Let's create a web api from the default template publish and run it through the command line.
Steps I followed:
1 - Created a src folder
2 - Inside the src folder create a webAPI with Visual Studio (yes the default weather app from the dotnet new template)
3 - Opened powershell (from the src folder) and execute the dotnet publish command
4 - dotnet publish .\DefaultWebApi\DefaultWebApi.sln -c Release -o app
5 - executed to the executed the newly published application (remember lives in the app folder)
6 - dotnet .\app\DefaultWebApi.dll
7 - You cannot access it through your browser, for that you need docker for windows.

[Back](../README.md)