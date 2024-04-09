﻿'Name: Gabriel Whatley
'Date : 4/9/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that reads savings information from a file and displays the information to the user based on their choice of month.
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
