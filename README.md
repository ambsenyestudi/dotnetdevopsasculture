# DevOps is a culture
Looking out there I've realized that there is a lack of good DevOps tutorials focused for dotnet developers. This is my honest attempt to fill this gap.

In my professional experience there is still a misunderstanding about what DevOps means. Just in case you don't know DevOps is a word that unites Development and Operations, so if you have a DevOps department... you guessed it! you have a good old operations department.

Another thing that is out there is that a lot of developers claim that they don't like this "ops part", but since we are at the final stretch of 2021 I'm stating that this is outdated view and in the current world everybody should join the DevOps culture.

## How to become proficient at DevOps in dot net

First things first are you familiar with dotnet command line?

Let's create a web api from the default template publish and run it through the command line.
Steps I followed:ç
1 - Created a src folder
2 - Inside the src folder create a webAPI with Visual Studio (yes the default weather app from the dotnet new template)
3 - Opened powershell (from the src folder) and execute the dotnet publish command
4 - dotnet publish .\DefaultWebApi\DefaultWebApi.sln -c Release -o app
5 - executed to the executed the newly published application (remember lives in the app folder)
6 - dotnet .\app\DefaultWebApi.dll
7 - You cannot access it through your browser, for that you need docker for windows.
