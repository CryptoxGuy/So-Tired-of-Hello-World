'Hello World in Visual Basic 
Public Class Form1
    'Displays message
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lblMessage.Text = "Hello World"
    End Sub
    'Clears Message
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = String.Empty
    End Sub
    'Closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
