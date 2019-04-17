# Controlling Hardware #

## Step 5 - Move the Servo ##

- From the Basic Toolbox, drag a "Pause (100)" below the "Servo Write Pin" block and change the Pause Time to "1 Second";

<p align="center">
    <img src="images/5-pause-block-placed.jpg" width="250px" >
</p>

- Click the Advanced Toolbox Section again to reveal the Advanced Toolbox Sections.
- Click the Pins Toolbox Section again, drag another "Servo Write Pin" block beneath the "Pause" block and change the angle to 0;

<p align="center">
    <img src="images/5-servo-write-pin-block-placed.jpg" width="250px" >
</p>

- Finally, drag another "Pause" block below our second "Servo Write Pin" block and again change the time to "1 Second.
- You should now have a program similair to below;

<p align="center">
    <img src="images/5-servo-program.jpg" width="500px" >
</p>

- You should see that the Simulated servo is moving from right to left and back again once a second;

<p align="center">
    <img src="images/5-servo-move.gif" width="250px" >
</p>

| Previous | Next |
| -------- | ---- |
| [< Step 4 - Add a Servo](4-add-servo.md) | [Step 6 - Sonar Extension >](6-sonar-extension.md) |