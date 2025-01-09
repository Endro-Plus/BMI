' Program:  BMI_Index
' Author:   Bernard Ryan
' Date:     October 11, 2023 
' Purpose:  Get the BMI index of the user
Option Strict On

Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class frmBMI
    Private Sub frmBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make the splash screen 5 seconds long
        Thread.Sleep(5000)


    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        'If everything has a value, activate the button, otherwise, deactivate the button
        If AllInputed() Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub lstSystem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSystem.SelectedIndexChanged
        'If everything has a value, activate the button, otherwise, deactivate the button
        If AllInputed() Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If

        'Based on the selection, change lblMeter to say either (in.) or (M)
        If lstSystem.SelectedIndex = 0 Then
            'Inches
            lblMeasure.Text = "(in.)"
        ElseIf lstSystem.SelectedIndex = 1 Then
            'Meters
            lblMeasure.Text = "(M)"
        Else
            'they didn't select anything
            lblMeasure.Text = ""
        End If
    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        'If everything has a value, activate the button, otherwise, deactivate the button
        If AllInputed() Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'unselect the listbox
        lstSystem.SetSelected(0, False)

        'clear everything from the textboxes
        txtHeight.Clear()
        txtWeight.Clear()

        'Set the answer label to simply, "BMI"
        lblAnswer.Text = "BMI"
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Try to calculate the data, as if it is correct (after checking for negative numbers).

        Try
            'This single if statement will catch any errors
            If Convert.toDecimal(txtWeight.text) < 0 Or Convert.toDecimal(txtHeight.text) < 0 Then
                'If this ran, there is a negative number


                'Throw a format exception
                Throw New System.FormatException("Negative!")

            End If
            'If we got here, there is no negative numbers, or strings, the input is valid
            If lstSystem.SelectedIndex = 0 Then
                'Imperial
                lblAnswer.Text = BMI_Imperial(
                    Convert.ToDecimal(txtHeight.Text),
                    Convert.ToDecimal(txtWeight.Text)).ToString("N2")
            Else
                'Metric
                lblAnswer.Text = BMI_Metric(
                    Convert.ToDecimal(txtHeight.Text),
                    Convert.ToDecimal(txtWeight.Text)).ToString("N2")




            End If
        Catch ex As FormatException
            'There is a problem with the input

            'First, chech txtHeight
            Try


                If (Convert.ToDecimal(txtHeight.Text) < 0) Then

                    'It's a negative number
                    MsgBox(txtHeight.Text + " is a negative number! try again!",
                       MsgBoxStyle.Critical,
                       "User Error")
                    txtHeight.SelectAll()
                    txtHeight.Focus()
                    Return
                End If

            Catch exc As FormatException
                'It's a string
                MsgBox(txtHeight.Text + " is not a number! try again!",
                   MsgBoxStyle.Critical,
                   "User Error")
                txtHeight.SelectAll()
                txtHeight.Focus()
                Return
            End Try

            Try

                'Check weight
                If (Convert.ToDecimal(txtWeight.Text) < 0) Then

                    'It's a negative number
                    MsgBox(txtWeight.Text + " is a negative number! try again!",
                       MsgBoxStyle.Critical,
                       "User Error")
                    txtWeight.SelectAll()
                    txtWeight.Focus()
                End If

            Catch exc As FormatException
                'It's a string
                MsgBox(txtWeight.Text + " is not a number! try again!",
                   MsgBoxStyle.Critical,
                   "User Error")
                txtWeight.SelectAll()
                txtWeight.Focus()
            End Try


        End Try
    End Sub

    '
    'Menu Bar
    '
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'Simulate a click on the btnClear button (clear the program)
        btnClear.PerformClick()
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'close the program
        Close()
    End Sub
    Private Sub mnuFI_Click(sender As Object, e As EventArgs) Handles mnuFI.Click
        'Convert feet to inches
        Dim strNum As String
        Dim intAns As Integer
        Do While True
            Try
                strNum = InputBox("How many feet are you? (type a whole number)")


                If Convert.ToInt32(strNum) < 0 Then
                    'It's a negative number
                    MsgBox(strNum & " is a negative number! try again!",
                       MsgBoxStyle.Critical,
                       "User Error")
                Else
                    'this is valid
                    intAns = Convert.ToInt32(strNum) * 12

                    If MsgBox(strNum + " feet is equal to " & intAns & " inches." &
                              vbNewLine &
                              "Would you like to put that in the height box?",
                              MsgBoxStyle.YesNo,
                              "Feet to inches") = vbYes Then
                        'Replace the current height
                        txtHeight.Text = intAns.ToString("N0")

                        'Set the measurement system to imperial
                        lstSystem.SetSelected(0, True)
                    End If
                    Return
                End If
            Catch ex As FormatException
                'It's not a number
                MsgBox(strNum & " isn't a number! Try again!",
                   MsgBoxStyle.Critical,
                   "User Error")
            End Try
        Loop
    End Sub
    Private Sub picBMI1_Click(sender As Object, e As EventArgs) Handles picBMI1.Click
        'Toggles to another view
        ToggleView()
    End Sub
    Private Sub btnRevert_Click(sender As Object, e As EventArgs) Handles btnRevert.Click
        'Toggles to another view
        ToggleView()
    End Sub
    Private Sub mnuCalculator_Click(sender As Object, e As EventArgs) Handles mnuCalculator.Click
        'Toggles to another view
        ToggleView()
    End Sub
    Private Sub mnuBMI_Click(sender As Object, e As EventArgs) Handles mnuBMI.Click
        'Toggles to another view
        ToggleView()
    End Sub
    Private Sub lblClick_Click(sender As Object, e As EventArgs) Handles lblClick.Click
        'Toggles to another view
        ToggleView()
    End Sub

    '
    'Functions
    '
    Function AllInputed() As Boolean
        'If there is at least something in each textbox, and something is selected in the listbox,
        'return true, otherwise, return false
        If lstSystem.SelectedIndex <> -1 And txtHeight.Text <> "" And txtWeight.Text <> "" Then
            Return True
        End If
        Return False
    End Function

    Function ToggleView() As Boolean
        'Switches from calculator and the chart.

        If picBMI1.Visible = True Then
            'Activate chart view

            'First, go to the menubar, and enable the calcutor button
            mnuCalculator.Enabled = True

            'Disable the BMI chart button
            mnuBMI.Enabled = False

            'hide every control in the calculator view

            lblAnswer.Visible = False
            lblHeight.Visible = False
            lblSystem.Visible = False
            lblWeight.Visible = False
            lblMeasure.Visible = False
            lblClick.Visible = False
            picBMI1.Visible = False
            picCalc.Visible = False
            btnSubmit.Visible = False
            btnClear.Visible = False
            txtHeight.Visible = False
            txtWeight.Visible = False
            lstSystem.Visible = False

            'Show the larger BMI graph image, and revert button
            picBMI2.Visible = True
            btnRevert.Visible = True

            'Change the title to BMI Chart
            lblTitle.Text = "BMI Chart"
            Me.Text = "BMI Chart"
        Else
            'Activate calculator view

            'First, go to the menubar, and enable the chart button
            mnuBMI.Enabled = True

            'Disable the calculator button
            mnuCalculator.Enabled = False

            'Show every control in the calculator view
            lblAnswer.Visible = True
            lblHeight.Visible = True
            lblSystem.Visible = True
            lblWeight.Visible = True
            lblMeasure.Visible = True
            lblClick.Visible = True
            picBMI1.Visible = True
            picCalc.Visible = True
            btnClear.Visible = True
            btnSubmit.Visible = True
            txtHeight.Visible = True
            txtWeight.Visible = True
            lstSystem.Visible = True

            'hide the larger BMI graph image, and revert button
            picBMI2.Visible = False
            btnRevert.Visible = False

            'Change the title back to "BMI Calculator
            lblTitle.Text = "BMI Calculator"
            Me.Text = "BMI Calculator"
        End If
        Return Nothing

    End Function


    Function BMI_Imperial(ByVal dech As Decimal, ByVal decw As Decimal) As Decimal
        'Calculate the BMI using the Imperial system
        Return (decw / (dech * dech)) * 703

    End Function
    Function BMI_Metric(ByVal dech As Decimal, ByVal decw As Decimal) As Decimal
        'Calculate the BMI using the Metric system
        Return decw / (dech * dech)


    End Function


End Class
