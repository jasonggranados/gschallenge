# Installation
* Clone the project
* Open the database solution and publish it. Said solution is located under the directory `/Database`. There's a local, SQLEXPRESS, windows-authenticated xml profile named `publish.local.xml`, intended for quick local deployments.
* Open the app solution, located under the folder `GProject`
* Restore the nuget dependencies for the solution
* Update the connection strings in the file `web.config` _if_ necessary.
* You can now run the application

# Demo
There's a [video demoing](https://drive.google.com/open?id=1QhjM8sTVMXS07dEkWH9rVzitp9DNQhrD) the application running. The names, dates, and credits where generated using Random.org, and it shows the basic functionality, as well as some UI hints added to the app plus the local storage manager that prevents further api requests if the data is already contained.

### Client Bundles (_Optional_)
All javascript and SASS files of this project are transpiled and bundled using Webpack and Babel. Even though they're not necessary to run the application, you may want to edit and develop changes to our js files. In order to do so you need to install NodeJS, preferably, the latest version. Below I'm listing the necessary steps to development, transpilation, and bundling:
* Install nodejs
* Open any console/command-line and look for the folder `\GProject.Api` (located at `~\gschallenge\GProject\GProject.Api`)
* Run `npm install` to download and install the client-side dependencies
* Run `npm run dev` to run webpack and watch the files. With this running, everytime you save a change to a _.js_ or _.scss_ file Webpack will transpile it, bundle it, and refresh your browser

### Troubleshoot
Because of my version of Visual Studio, I encountered and exception with the description «_Could not find a part of the path 'GProject.Api\bin\roslyn\csc.exe'_».
This very well may be an environment issue given my current setup; however, if you encounter this same problem, you can fix it following the next steps:
* Unload the project `GProject.Api` from the solution (right clickk over it and select the option «_Unload Project_»)
* Reload that very same project  (right clickk over it and select the option «_Reload Project_»)
* From the main menu bar, select _Build_ → _Clean Solution_
* From the main menu bar, select _Build_ → _Rebuild Solution_
* Run the application

