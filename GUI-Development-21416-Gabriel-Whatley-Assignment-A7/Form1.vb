Public Class Form1

    Dim file_reader As IO.StreamReader
    Dim month_data As Array

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IO.File.Exists("savings.txt") = True Then
            file_reader = IO.File.OpenText("savings.txt")
        Else
            MsgBox("Make sure the savings.txt file is in the program directory")
            Close()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


End Class
