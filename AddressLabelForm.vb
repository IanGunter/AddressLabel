'Ian Gunter
'RCET 0265
'Fall 2020
'AddressLabelForm
'https://github.com/IanGunter/AddressLabel.git

Option Explicit On
Option Strict On
Option Compare Text
Public Class AddressLabelForm

    'Display button click creates a list and inserts the items in that list into a Label
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim addressLabelString As New List(Of String)

        addressLabelString.Add(FirstNameTextbox.Text & " ")
        addressLabelString.Add(LastNameTextbox.Text)
        addressLabelString.Add(StreetAddressTextbox.Text & " ")
        addressLabelString.Add(CityTextbox.Text & ",")
        addressLabelString.Add(StateTextbox.Text & " ")
        addressLabelString.Add(ZipCodeTextBox.Text)
        DisplayLabel.Text = (addressLabelString(0) & addressLabelString(1) & vbNewLine & addressLabelString(2) &
            vbNewLine & addressLabelString(3) & addressLabelString(4) & addressLabelString(5))
    End Sub

    'Clear button clears the list and the label 
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        FirstNameTextbox.Text = ""
        LastNameTextbox.Text = ""
        StreetAddressTextbox.Text = ""
        CityTextbox.Text = ""
        StateTextbox.Text = ""
        ZipCodeTextBox.Text = ""
        DisplayLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
