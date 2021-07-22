# Game_of_life

Game of life is a simulation of cells, living on a 2D grid. It is broken down into states in time as the time progresses where each state is dependant on the previous. At the begginig, there is an initial state of cells on the grid and each position on the grid can represent a cell that is either dead or alive. Once the simulation starts, each next state is calculated based on the previous, following a simple set of rules.

The rules for grid cells are the following. If a living cell has less than two cells around it on 8 grid squares that surround it, then it dies of lonelyness. If it has more than 4 neighboring cells alive, it dies from overpopulation in the area. If a cell is dead and has exactly 3 living cells nearby, then it becomes alive.

In this manner, the simulation forms interesting patterns over time.


This aplication is done with graphical user interface and user can press the buttons in order to manipulate the simulation. It is possible to set the grid dimensions, start a new, blank state or with a random one, set the time interval for the speed of the simulation, start and stop the simulation, save and load the simulation state from hard drive and even customly selecting which cells are dead or alive by clicking on the grid.



The goal of this project was to have more practice with GUI programming using Windows forms by using timers to run the simulation. Another challenge was to store the state in two forms in order to properly calculate the next state. Apart from using several other new types of GUI elemens, the project also required storing and loading data from the application to the hard drive and vice versa and also using image resources to display custom buttons while changing them in time to present the proper state of the program (such as play / pause toggling).

USAGE:

The application was made on and for Windows 10 platform using Visual Studio 2019. The project contains the executable for running the application (EXE folder), Visual Studio 2019 solution and the source code. 

When testing on another Windows machine apart from the one on which it was developed, it was found that running the .exe files sometimes doesn't work on the first try so the user needs to try again until the game can be played. The source code is also present so the user can also manually rebuild the program.
