# Mastery Coding Unity Conference Demo

The purpose of this project is to demonstrate some of the important elements of Unity Engine in a fun and engaging way. The scenes included in this demo are taken from projects students build and work on Game Development 1.

## Installation Instructions 

To run this demo, you'll need to install the following software:

* Unity Hub
* A version of the Unity Editor

First, install Unity Hub [here](https://unity.com/download). Once Unity Hub is installed, you need to install a version of the Unity editor in order to run this project. 

![](https://github.com/torbenwb/MCConExp/blob/main/Hub1.png)

This project runs using version 2021.3.16.f1 so any version after that should be able to run it. I would recommend simply installing the latest version release marked LTS - Long Term Support.

![](https://github.com/torbenwb/MCConExp/blob/main/Hub2.png)

## Cloning the Project

Once you have Unity and Unity Hub installed, you're ready to clone this project to your local machine and open it in Unity. To do this, start by selecting Code from the repository and then select **Open with GitHub Desktop**. If you don't have GitHub Desktop installed on your computer this will require you to install it and set up a GitHub account.

![](https://github.com/torbenwb/MCConExp/blob/main/GitHub.png)

Once the project has been downloaded to your computer, it's time to make that project accessible via Unity Hub. To do this select **Add Project From Disk** and navigate to the main project folder. The project should then show up in a list of projects in Unity Hub where you can open it.

![](https://github.com/torbenwb/MCConExp/blob/main/AddProject.png)

## Reseting the Project 

To reset the project to its original state, go to GitHub Desktop, and from the Branch menu select **Discard All Change**. This will revert all changes made since the last time you updated the project.

![](https://github.com/torbenwb/MCConExp/blob/main/Discard%20All%20Changes.png)

## Toy Box Scene 

![](https://github.com/torbenwb/MCConExp/blob/main/ToyBox_Demo.gif)

The "Toy Box Scene" is a project taken from GD1: Unit 1 which introduces students to the Unity Interface and tasks them with setting up a physics simulation. Students work with different objects, changing their mass, drag/angular drag, friction, and bounciness. 

The scene can be navigated using the right mouse button and WASD, and objects can be selected, moved, rotated, and scaled using the Move, Rotate, and Scale tools respectively. New objects can be added to the scene by dragging them from the Assets folder into the scene view. The materials of an object can also be changed by dragging a new material from the project view onto the object.

[Toy Box Instructions](https://github.com/torbenwb/MCConExp/blob/main/ToyBox.md)

## Park Scene

![](https://github.com/torbenwb/MCConExp/blob/main/Pigeon_CollectCoin.gif)

The "Park Scene" is a project taken from GD1: Unit 3 - Unity Scripting API, which focuses on introducing students to Unity Scripting API and APIs in general. The goal of the project is to program scripts for basic gameplay functions such as moving, jumping and collecting coins.

In step 1, we will be able to move the pigeon using the left/right arrow keys by dragging the InputMover script from the Project section onto the Pigeon GameObject.

In step 2, we will add the ability for the pigeon to jump over obstacles by selecting the InputJumper script from the Project section and attaching it to the pigeon. They can adjust the Jump Strength variable to control how high the pigeon jumps, and Jump Coordinate Space variable to change the direction of jump.

In step 3, we will be able to collect the coin by adding the Collectible script to the Coin GameObject, and setting the CollectFX property to the CollectFX prefab in the Park Scene Assets folder. This will cause the coin to burst into smaller coins when collected.

[Park Instructions](https://github.com/torbenwb/MCConExp/blob/main/ParkScene.md)

