# Super-Lizard

 An isometric adventure game based on the gameplay of Frogger, with a couple levels, a traditional limited life and retry system, as well as potential expansions upon the formula in the form of power ups or otherwise  
 
# How to RUN

 Begin by downloading the zip file. This is the project file for Unity which can be accesssed by opening the Unity Hub and opening a new project. Once imported and opened you can navigate to the scenes folder from within the assets folder. From there open the MainLevelOne scene and you shall now see the main game with sprites and objects all in place. Hitting the play button in the game window will allow you to move the lizard and play the game.
 
# Current Iteration

In its current form, Super Lizard is a fully functional Frogger base game with no roguelike functions yet. There is an existing main level that is repeated and points that are tracked for completion or for game overs. Cars currently effectively delete themselves while still producing more cars, this bug was fixed by making the clones a seperate game object which was deleted after a yielded time.
 
 Video of current iteration demo:
 https://youtu.be/eW11Zualfqk
 
 RD Document:
 https://docs.google.com/document/d/1MLYxarpdqqK_vwq42xlkPOLmo4R-tOXyvw_jEhovtmU/edit?usp=sharing
 
 IT Document:
 https://docs.google.com/document/d/1mZwAhAylChtPs5T9Hmt-AtUWU-BaiuxTc_lfrhx-aDs/edit?usp=sharing
 
 Progress Report:
 https://docs.google.com/document/d/18YftfYR7xwwkZ3izzd2szTDVYK68-XJKwO0t7S_47wk/edit?usp=sharing
 
 
 # Documentation:
 
 Most of the code and work is located in the /assets folder of SuperLizard. Within the assets folder are a couple of scripts associated with in game sprites written in C# (ex. CarScript.cs, LizardScript.cs...). Inside the /assets you can find the Scenes folder which contains the levels that are gonna be implemented and you can also find the .png of the sprites used.
 
 # Current Bugs?
 
  At the moment cars are spawning on top of each other when being randomly generated. This was fixed in the bugScript implementation that was pulled recently and can be used for the carScript to fix the same issue.
 
 # Team Members:  
 Modibo Traore, mt16g 
 
 David Lee, dyl20b 
 
 Alejandro Osuna, ao18f 
 
 Daniel Kovacs, djk19f 
 
 Matthew Papageorge, mp20gu
