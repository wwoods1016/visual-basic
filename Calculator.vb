' This code creates a basic calculator application using Visual Basic. 

' It declares variables for two numbers, the result, and the operation to be performed. 
' It handles button clicks for numbers, clear, add, subtract, multiply, divide, and equals. 
' When a number button is clicked, it adds the corresponding number to the display. 
' When the clear button is clicked, it clears the display. When an operation button is clicked, 
' it stores the first number and the operation to be performed. When the equals button is clicked, 
' it performs the operation on the two numbers and displays the result. 

' The code uses a Select Case statement to determine which operation to perform based on the operation variable.

' Will Woods
' 2023



Public Class CalculatorForm
    ' Variables
    Dim firstNumber As Double
    Dim secondNumber As Double
    Dim calculationResult As Double
    Dim currentOperator As String

    ' Number button clicks
    Private Sub HandleNumberButtonClick(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btn As Button = sender
        txtDisplay.Text += btn.Text
    End Sub

    ' Clear button click
    Private Sub HandleClearButtonClick(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub

    ' Operator button clicks
    Private Sub HandleOperatorButtonClick(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        Dim btn As Button = sender
        Double.TryParse(txtDisplay.Text, firstNumber)
        currentOperator = btn.Text
        txtDisplay.Clear()
    End Sub

    ' Equals button click
    Private Sub HandleEqualsButtonClick(sender As Object, e As EventArgs) Handles btnEquals.Click
        If Double.TryParse(txtDisplay.Text, secondNumber) Then
            Select Case currentOperator
                Case "+"
                    calculationResult = firstNumber + secondNumber
                Case "-"
                    calculationResult = firstNumber - secondNumber
                Case "*"
                    calculationResult = firstNumber * secondNumber
                Case "/"
                    If secondNumber <> 0 Then
                        calculationResult = firstNumber / secondNumber
                    Else
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select
            txtDisplay.Text = calculationResult.ToString()
        Else
            MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class


' Change font of display: Select display control. Locate Font property in Properties window. Open Font dialog. Choose sans-serif font like Helvetica or Arial.

' Change background color of form: Select form control. Locate BackColor property in Properties window. Choose black as the background color.

' Change foreground color of buttons: Select each button control. Locate ForeColor property in Properties window. Choose white as the foreground color.

' Change size and position of buttons: Select each button control. Locate Size property in Properties window. Adjust width and height to match iPhone calculator. Locate Location property in Properties window. Adjust X and Y coordinates to match iPhone calculator.

' Add rounded corners to buttons: Select each button control. Locate FlatStyle property in Properties window. Choose System as the flat style. Locate BorderRadius property in Properties window. Choose a value to add rounded corners.

' Add gradient effect to buttons: Select each button control. Locate FlatStyle property in Properties window. Choose Flat as the flat style. Locate BackColor property in Properties window. Choose a gradient color to add a glossy effect.

' Add shadow effect to buttons: Select each button control. Locate FlatStyle property in Properties window. Choose Flat as the flat style. Locate FlatAppearance property in Properties window. Choose a value for BorderSize property to add a shadow effect.

' Add clear button: Add new button control to the form. Locate Text property in Properties window. Change text to "C". Locate BackgroundImage property in Properties window. Choose image of white X on black background.

' Add decimal point button: Add new button control to the form. Locate Text property in Properties window. Change text to ".". Locate BackgroundImage property in Properties window. Choose image of white dot on black background.

' Add backspace button: Add new button control to the form. Locate Text property in Properties window. Change text to "←". Locate BackgroundImage property in Properties window. Choose image of white arrow on black background.
