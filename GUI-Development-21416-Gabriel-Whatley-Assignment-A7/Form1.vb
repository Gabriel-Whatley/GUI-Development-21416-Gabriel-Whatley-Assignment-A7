'Name: Gabriel Whatley
'Date: 4/9/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that reads savings information from a file and displays the information to the user based on their choice of month.
Public Class Form1

    Dim month_array(11) As String
    Dim cost_array(11) As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim file_contents As Array
        Dim file_contents_index As Int16 = 0

        If IO.File.Exists("savings.txt") = True Then
            file_contents = My.Computer.FileSystem.ReadAllText("savings.txt").Split(Environment.NewLine.ToArray) ' Read the entire file into an array split by newline characters.
        Else
            MsgBox("Make sure the savings.txt file is in the program directory")
            Close()
        End If

        For index As Int16 = 0 To 11
            month_array(index) = file_contents(file_contents_index)
            cost_array(index) = file_contents(file_contents_index + 1)
            file_contents_index += 2
        Next

        cb_month.Items.AddRange(month_array)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_month.SelectedIndexChanged
        lbl_selected_month_savings.Text = "The electric savings for " + month_array(cb_month.SelectedIndex) + " is : " + FormatCurrency(cost_array(cb_month.SelectedIndex), 2)
        lbl_selected_month_savings.Visible = True
    End Sub

    Private Sub btn_display_stats_Click(sender As Object, e As EventArgs) Handles btn_display_stats.Click
        lbl_average_savings.Visible = True
        lbl_largest_savings.Visible = True
    End Sub
End Class
