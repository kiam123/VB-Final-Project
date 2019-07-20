Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.OleDb
Public Class SearchFlights
    Public visitor As New Visitor
    Public myConnection As OleDbConnection

    Private Sub SearchFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        initialData()
        initialView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not (original.Text = "") Then
            visitor.original = original.Text
        Else
            Return
        End If
        If Not (destination.Text = "") Then
            visitor.destination = destination.Text
        Else
            Return
        End If
        If Not (departDate.Text = "") Then
            visitor.departDate = departDate.Text
        Else
            Return
        End If

        If (Not (returnDateText.Text = "")) And returnRadioButton.Checked Then
            visitor.returnDate = returnDateText.Text
            visitor.isReturn = True
        End If

        If oneWayRadioButton.Checked Then
            visitor.returnDate = ""
            visitor.isReturn = False
        End If


        ReDim Preserve visitor.adultName(visitor.numberOfAdultPeople - 1)
        ReDim Preserve visitor.adultSurname(visitor.numberOfAdultPeople - 1)
        ReDim Preserve visitor.adultDateOfBirth(visitor.numberOfAdultPeople - 1)
        ReDim Preserve visitor.adultSex(visitor.numberOfAdultPeople - 1)
        For l As Integer = 0 To visitor.numberOfAdultPeople - 1
            visitor.adultSex(l) = True
        Next

        ReDim Preserve visitor.childName(visitor.numberOfChildPeople - 1)
        ReDim Preserve visitor.childSurname(visitor.numberOfChildPeople - 1)
        ReDim Preserve visitor.childDateOfBirth(visitor.numberOfChildPeople - 1)
        ReDim Preserve visitor.childSex(visitor.numberOfChildPeople - 1)
        For l As Integer = 0 To visitor.numberOfChildPeople - 1
            visitor.childSex(l) = True
        Next

        Dim selectFlights As New SelectFlights
        selectFlights.ShowDialog()
    End Sub

    Private Sub oneWayRadioButton_CheckedChanged_1(sender As Object, e As EventArgs) Handles oneWayRadioButton.CheckedChanged
        returnDateLabel.Visible = False
        returnDateText.Visible = False
        visitor.isReturn = False
    End Sub

    Private Sub returnRadioButton_CheckedChanged_1(sender As Object, e As EventArgs) Handles returnRadioButton.CheckedChanged
        returnDateLabel.Visible = True
        returnDateText.Visible = True
        visitor.isReturn = True
    End Sub

    Private Sub adultNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles adultNumericUpDown.ValueChanged
        visitor.numberOfAdultPeople = adultNumericUpDown.Value
    End Sub

    Private Sub childNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles childNumericUpDown.ValueChanged
        visitor.numberOfChildPeople = childNumericUpDown.Value
    End Sub

    Private Sub initialData()
        visitor.original = ""
        visitor.destination = ""
        'visitor.departDate = Year(Now) & "/" & Month(Now) & "/" & DateAndTime.Day(Now())
        'visitor.returnDate = Year(Now) & "/" & Month(Now) & "/" & (DateAndTime.Day(Now()) + 1)
        visitor.departDate = "2019/7/18"
        visitor.returnDate = "2019/7/19"
        visitor.isReturn = True
        visitor.haveAdult = True
        visitor.haveChild = False
        visitor.numberOfAdultPeople = 1
        visitor.numberOfChildPeople = 0

        visitor.emailAddress = ""
        visitor.phoneNumber = ""
    End Sub

    Private Sub initialView()
        connectDB()

        departDate.Text = visitor.departDate
        returnDateText.Text = visitor.returnDate
        returnRadioButton.Checked = visitor.isReturn
        adultNumericUpDown.Value = visitor.numberOfAdultPeople
        childNumericUpDown.Value = visitor.numberOfChildPeople
    End Sub

    Private Sub connectDB()
        myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb")
        myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT original FROM AirplaneFlight GROUP BY original", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            original.Items.Add(dr(0))
        End While
    End Sub

    Private Sub original_SelectedIndexChanged(sender As Object, e As EventArgs) Handles original.SelectedIndexChanged
        destination.Text = ""
        destination.Items.Clear()
        Dim temp As String = original.Text
        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT destination FROM AirplaneFlight WHERE original = '" & original.Text & "' GROUP BY destination", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            destination.Items.Add(dr(0))
        End While
    End Sub
End Class
