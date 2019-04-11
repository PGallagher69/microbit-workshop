# Sensors and Logic - Light Level #

Here we are going to add a block to read the Micro:Bit Light Sensor and give us a reading on the screen if the amount read is over a given threshold.

The Light Level Sensor actually works by sensing the light hitting the LED's which make up the devices display.

You can find more information here;

https://lancaster-university.github.io/microbit-docs/extras/light-sensing/

----

## Step 8 - Add Light Level Value ##

- You should currently have a "Forever" Block similair to the following;

<p align="center">
    <img src="images/7-acceleration-block-icon-placed.jpg" width="250px" >
</p>

- We want to add an "if else" section to this block to let us test the Light Sensor Level value. We can do this by clicking the small plus "+" at the bottom of the "If Else" Block as circled below;

<p align="center">
    <img src="images/8-add-extra-if.jpg" width="250px" >
</p>

- Our "Forever" Block will then have an extra "If Else" section below the original "If" section we're using to measure the Acceleration;

<p align="center">
    <img src="images/8-add-extra-if-added.jpg" width="250px" >
</p>

- Click the "Logic" Toolbox Section;

<p align="center">
    <img src="images/8-logic-toolbox.jpg" width="500px" >
</p>

- Drag a "Comparison" block onto the "Forever" block on the designer;

<p align="center">
    <img src="images/6-acc-comparison.jpg" width="250px" >
</p>

- Which will show the following;

<p align="center">
    <img src="images/8-light-comparison-else-if.jpg" width="250px" >
</p>

- Click the "Equals" or "=" operator and choose the "Greater Than" or ">" operator;

<p align="center">
    <img src="images/8-light-comparison-else-if-options.jpg" width="250px" >
</p>

- Click the "Input" Toolbox Section;

<p align="center">
    <img src="images/8-input-toolbox.jpg" width="500px" >
</p>

- Drag a "Light Level" block onto the first "0" section of the Comparison Logic Block you added in the previous section;

<p align="center">
    <img src="images/8-light-level-block.jpg" width="250px" >
</p>

- You should have a forever block like the following;

<p align="center">
    <img src="images/8-light-level-block-placed.jpg" width="250px" >
</p>

- Change the second "0" in the Comparison Logic Block to 200;

<p align="center">
    <img src="images/8-light-level-block-200.jpg" width="250px" >
</p>

- Open the "Basic" Toolbox Section;

<p align="center">
    <img src="images/8-basic-toolbox.jpg" width="500px" >
</p>

- Drag an "Icon" block into the new "Else If" Block;

<p align="center">
    <img src="images/7-acceleration-block-icon.jpg" width="250px" >
</p>

- Click the Heart Icon in the new "Icon" block and select a new icon image;

<p align="center">
    <img src="images/8-light-level-icon-choice.jpg" width="250px" >
</p>

- You should now have a Forever block resembling the following;

<p align="center">
    <img src="images/8-light-level-icon-chosen.jpg" width="250px" >
</p>

| Previous | Next |
| -------- | ---- |
| [< Step 7 - Add Acceleration Value](7-add-acceleration-value.md) | [Step 9 - Add Acceleration Value >](9-add-compass-value.md) |