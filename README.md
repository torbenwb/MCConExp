# Mastery Coding Unity Conference Demo

The purpose of this project is to demonstrate some of the important elements of Unity Engine in a fun and engaging way. The scenes included in this demo are taken from projects students build and work on Game Development 1.

## Toy Box Scene 

![](https://github.com/torbenwb/MCConExp/blob/main/ToyBox_Demo.gif)

The "Toy Box Scene" is a project taken from GD1: Unit 1 which introduces students to the Unity Interface and tasks them with setting up a physics simulation. Students work with different objects, changing their mass, drag/angular drag, friction, and bounciness. 

The scene can be navigated using the right mouse button and WASD, and objects can be selected, moved, rotated, and scaled using the Move, Rotate, and Scale tools respectively. New objects can be added to the scene by dragging them from the Assets folder into the scene view. The materials of an object can also be changed by dragging a new material from the project view onto the object.

[Toy Box Instructions](https://github.com/torbenwb/MCConExp/blob/main/ToyBox.md)

## Park Scene

![](https://github.com/torbenwb/MCConExp/blob/main/Pigeon_CollectCoin.gif)

The "Park Scene" is a project taken from GD1: Unit 3 - Unity Scripting API, which focuses on introducing students to Unity Scripting API and APIs in general. The goal of the project is to program scripts for basic gameplay functions such as moving, jumping and collecting coins.

In step 1, we'll will be able to move the pigeon using the left/right arrow keys by dragging the InputMover script from the Project section onto the Pigeon GameObject.

In step 2, we'll will add the ability for the pigeon to jump over obstacles by selecting the InputJumper script from the Project section and attaching it to the pigeon. They can adjust the Jump Strength variable to control how high the pigeon jumps, and Jump Coordinate Space variable to change the direction of jump.

In step 3, we'll will be able to collect the coin by adding the Collectible script to the Coin GameObject, and setting the CollectFX property to the CollectFX prefab in the Park Scene Assets folder. This will cause the coin to burst into smaller coins when collected.

[Park Instructions](https://github.com/torbenwb/MCConExp/blob/main/ParkScene.md)
