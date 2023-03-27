Basic Visual Basic Calculator
===============================================

This code creates a basic calculator application using Visual Basic. The calculator can do basic calculator things like adding, subtracting, multiplying and dividing, and it can also clear the display, add decimal point, and remove the last entered digit. Below I have listed some brief instructions on how I might change the appearance of the calculator using Visual Studio. 

Features
--------

-   Handles button clicks for numbers, clear, add, subtract, multiply, divide, and equals.
-   When a number button is clicked, it adds the corresponding number to the display.
-   When the clear button is clicked, it clears the display.
-   When an operation button is clicked, it stores the first number and the operation to be performed.
-   When the equals button is clicked, it performs the operation on the two numbers and displays the result.
-   The code uses a Select Case statement to determine which operation to perform based on the operation variable.

Author
------

This code was written by Will Woods in an effort to further familiarize himself with the basic (no pun intended) of Visual Basic.

Instructions
------------

To use the calculator, simply run the program and click the number buttons and operators to perform calculations.

Customizations
--------------

The code can be customized further by following these instructions:

### Change font of display

1.  Select the display control
2.  Locate the Font property in the Properties window
3.  Open the Font dialog
4.  Choose a sans-serif font like Helvetica or Arial

### Change background color of form

1.  Select the form control
2.  Locate the BackColor property in the Properties window
3.  Choose black as the background color

### Change foreground color of buttons

1.  Select each button control
2.  Locate the ForeColor property in the Properties window
3.  Choose white as the foreground color

### Change size and position of buttons

1.  Select each button control
2.  Locate the Size property in the Properties window
3.  Adjust the width and height to match the iPhone calculator
4.  Locate the Location property in the Properties window
5.  Adjust the X and Y coordinates to match the iPhone calculator

### Add rounded corners to buttons

1.  Select each button control
2.  Locate the FlatStyle property in the Properties window
3.  Choose System as the flat style
4.  Locate the BorderRadius property in the Properties window
5.  Choose a value to add rounded corners

### Add gradient effect to buttons

1.  Select each button control
2.  Locate the FlatStyle property in the Properties window
3.  Choose Flat as the flat style
4.  Locate the BackColor property in the Properties window
5.  Choose a gradient color to add a glossy effect

### Add shadow effect to buttons

1.  Select each button control
2.  Locate the FlatStyle property in the Properties window
3.  Choose Flat as the flat style
4.  Locate the FlatAppearance property in the Properties window
5.  Choose a value for the BorderSize property to add a shadow effect

### Add clear button

1.  Add a new button control to the form
2.  Locate the Text property in the Properties window
3.  Change the text to "C"
4.  Locate the BackgroundImage property in the Properties window
5.  Choose an image of a white X on a black background

### Add decimal point button

1.  Add a new button control to the form
2.  Locate the Text property in the Properties window
3.  Change the text to "."
4.  Locate the BackgroundImage property in the Properties window
5.  Choose an image of a white dot on a black background

### Add backspace button

1.  Add a new button control to the form
2.  Locate the Text property in the Properties window
3.  Change the text to "←"
4.  Locate the BackgroundImage property in the Properties window
5.  Choose an image of a white arrow on a black background
