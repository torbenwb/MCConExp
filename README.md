# MasteryCodingUnityConferenceDemo

The purpose of this project is to demonstrate some of the important elements of Unity Engine in a fun and engaging way. The scenes included in this demo are taken from projects students build and work on Game Development 1.

## Park Scene

The Park Scene is taken from GD1: Unit 3 - Unity Scripting API. The purpose of this project is to introduce students to the Unity Scripting API and the concepts of APIs in general. During this unit students are tasked with programming scripts to fulfill basic gameplay functions such as moving, jumping, and collecting coins.

### Step 1: Moving Pigeon

Our first goal is to allow the player to move the pigeon using the left/right arrow keys. Luckily we already have a script to do just that. Drag the `InputMover` script from the **Project** section (bottom of the screen) onto the *Pigeon* GameObject. Now when we press play, we should be able to move the pigeon back and forth. Depending on how the physics of our pigeon are setup we might see some comical results. We can change how fast the pigeon moves by adjusting the `Move Speed` variable on the `InputMover` script.

![](https://github.com/torbenwb/MCConExp/blob/main/Pigeon_MoveScript.gif)


### Step 2: Jumping Pigeon

Now that our pigeon can move, he needs some way to get over this trash can in front of him, so we'll give him the ability to jump! Select the `InputJumper` script from the **Project** section and attach it to the pigeon. There are a couple of different settings we can change for this script. The first is the `Jump Strength` setting which controls how high the pigeon jumps. The other is the `Jump Coordinate Space` setting which can either be set to `Self` or `World`. When set to `Self` the pigeon will jump up along its **Local** Y-Axis. When set to `World` the pigeon will jump along the **Global** Y-Axis.

### Local Jumping
![](https://github.com/torbenwb/MCConExp/blob/main/Pigeon_JumpScript.gif)

### Global Jumping
![](https://github.com/torbenwb/MCConExp/blob/main/Pigeon_JumpGlobal.gif)
