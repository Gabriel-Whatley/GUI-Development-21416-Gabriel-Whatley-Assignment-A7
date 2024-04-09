'Name: Gabriel Whatley
'Date: 4/9/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that reads savings information from a file and displays the information to the user based on their choice of month.
Public Class Form1

    Dim month_array(11) As String
    Dim savings_array(11) As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim file_contents As Array
        Dim file_contents_index As Int16 = 0

        If IO.File.Exists("savings.txt") = True Then ' Check to make sure the savings.txt file exists.
            file_contents = My.Computer.FileSystem.ReadAllText("savings.txt").Split(Environment.NewLine.ToArray) ' Read the entire file into an array split by newline characters.
        Else
            MsgBox("Make sure the savings.txt file is in the program directory") ' Warn the user if the savings.txt file is not found.
            Close()
        End If

        ' Loop through the array of text gathered from the file and put the month names and costs into their own respective arrays.
        For index As Int16 = 0 To 11
            month_array(index) = file_contents(file_contents_index)
            savings_array(index) = file_contents(file_contents_index + 1)
            file_contents_index += 2
        Next

        cb_month.Items.AddRange(month_array) ' Set the list of months pulled from the text file as the months for the combobox.

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_month.SelectedIndexChanged
        ' Update the output label based on the selection in the combobox.
        lbl_selected_month_savings.Text = "The electric savings for " + month_array(cb_month.SelectedIndex) + " is : " + FormatCurrency(savings_array(cb_month.SelectedIndex), 2)
        lbl_selected_month_savings.Visible = True ' Make the output label visible 
        btn_display_stats.Visible = True ' Make the display stats button visible
    End Sub

    Private Sub btn_display_stats_Click(sender As Object, e As EventArgs) Handles btn_display_stats.Click
        ' -- Find the month with the highest savings and calculate the average savings of the values pulled from the file --
        Dim savings_average As Decimal = 0
        Dim highest_savings_index As Int16 = Array.IndexOf(savings_array, savings_array.Max) ' Get the index of the highest savings.

        For Each cost In savings_array 'Add up all of the monhtly costs from the file.
            savings_average += cost
        Next
        savings_average /= savings_array.Length 'Calculate the average savings using the number of months from the file.
        lbl_average_savings.Text = "The average monthly savings: " + FormatCurrency(savings_average, 2) ' Set the output label based on the result of the calculation.

        lbl_largest_savings.Text = month_array(highest_savings_index) + " had the most significant monthly savings" ' Set the output label based on the index of the month with the highest savings.

        '-- Set the output labels to visible --
        lbl_average_savings.Visible = True ' Make the output label visible 
        lbl_largest_savings.Visible = True ' Make the output label visible 
    End Sub
End Class
