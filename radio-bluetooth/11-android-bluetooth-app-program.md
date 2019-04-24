# Radio and Bluetooth #

In this section we'll try out a the Samsung Micro:Bit app for Android. This app allows you to connect your Micro:Bit to your mobile phone and control both your Micro:Bit from your phone and visa-versa. 

First, we'll create an app to use with the app.

## Step 11 - Samsung Micro:Bit App for Android - Test Program ##

- Hit the Home Button in the top left of the screen;

<p align="center">
    <img src="images/7-home.jpg" width="150px" >
</p>

- Click the "New Project" button.

- Click the Settings "Cog" icon in the top right of the screen; 

<p align="center">
    <img src="images/7-settings.jpg" width="150px" >
</p>

- You should now see the MakeCode Settings Menu;

<p align="center">
    <img src="images/7-settings-open.jpg" width="250px" >
</p>

- Click the "Extensions" menu item, which will show the MakeCode Extensions Library;

<p align="center">
    <img src="images/7-extensions.jpg" width="500px" >
</p>

- Click the "Bluetooth" Extension;

<p align="center">
    <img src="images/11-devices-extension.jpg" width="250px" >
</p>

- You'll receive a prompt that MakeCode needs to remove the Radio Extension in order to add the Devices Extension. This is because the Bluetooth Software uses the same hardware as the Radio Software, and they can't both be used at the same time;

<p align="center">
    <img src="images/11-remove-extensions.jpg" width="500px" >
</p>

- Press the "Remove extension(s) and add devices" button.
- You will return to the MakeCode Editor, and instead of a Radio Toolbox Section, you'll now have a Bluetooth Toolbox Section and a Devices Toolbox Section;

<p align="center">
    <img src="images/7-bluetooth-section.jpg" width="250px" >
</p>

<p align="center">
    <img src="images/11-devices-extension-toolbox.jpg" width="250px" >
</p>

- Expand the Bluetooth Toolbox Section;

<p align="center">
    <img src="images/11-bluetooth-extension-toolbox-expanded.jpg" width="500px" >
</p>

- Drag on an "On Bluetooth Connected" block;

<p align="center">
    <img src="images/11-bluetooth-connected.jpg" width="250px" >
</p>

- Add a smiley face icon from the Basic Toolbox to the "On BlueTooth Connected" Block;

<p align="center">
    <img src="images/11-bluetooth-connected-placed.jpg" width="250px" >
</p>

- Expand the Bluetooth Toolbox Section Again.
- Drag on an "On Bluetooth Disconnected" block;

<p align="center">
    <img src="images/11-bluetooth-disconnected.jpg" width="250px" >
</p>

- Add a smiley face icon from the Basic Toolbox to the "On BlueTooth Connected" Block;

<p align="center">
    <img src="images/11-bluetooth-disconnected-placed.jpg" width="250px" >
</p>

- Name your project and save the HEX file to a location on your computer;

<p align="center">
    <img src="images/11-android-bluetooth-program.jpg" width="500px" >
</p>

- Program your Micro:Bit with the demo program we've just created.

- You can download an example HEX file here;

<a href="hex/microbit-Bluetooth.hex">Bluetooth</a>

| Previous | Next |
| -------- | ---- |
| [< Step 10 - PC Bluetooth Demo](10-pc-bluetooth-demo.md) |[ Step 12 - Android Micro:Bit App >](12-android-bluetooth-app.md) |