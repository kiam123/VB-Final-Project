Public Class GuestDetails
    Dim xFlightTime As Integer : Dim yFlightTime As Integer
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 1 To SearchFlights.visitor.numberOfAdultPeople
            Dim panel As Panel = Panel1.Controls.Item("Adultpanel2" & i)
            Dim nameTextBox As TextBox = panel.Controls.Item("AdultnameTextBox" & i)
            Dim dateOfBirthTextBox As TextBox = panel.Controls.Item("AdultdateOfBirthTextBox" & i)
            Dim surnameTextBox As TextBox = panel.Controls.Item("AdultsurnameTextBox" & i)
            Dim male As RadioButton = panel.Controls.Item("Adultsex0")
            Dim female As RadioButton = panel.Controls.Item("Adultsex1")
            If IsNothing(nameTextBox) Or IsNothing(dateOfBirthTextBox) Or IsNothing(surnameTextBox) Then
                'TextBox1.Text = "null"
            Else
                SearchFlights.visitor.adultName(i - 1) = nameTextBox.Text
                SearchFlights.visitor.adultSurname(i - 1) = surnameTextBox.Text
                SearchFlights.visitor.adultDateOfBirth(i - 1) = dateOfBirthTextBox.Text
            End If

            If female.Checked = True Then
                SearchFlights.visitor.adultSex(i - 1) = False
            Else
                SearchFlights.visitor.adultSex(i - 1) = True
            End If
        Next

        For i = 1 To SearchFlights.visitor.numberOfChildPeople
            Dim panel As Panel = Panel1.Controls.Item("Childpanel2" & i)
            Dim nameTextBox As TextBox = panel.Controls.Item("ChildnameTextBox" & i)
            Dim dateOfBirthTextBox As TextBox = panel.Controls.Item("ChilddateOfBirthTextBox" & i)
            Dim surnameTextBox As TextBox = panel.Controls.Item("ChildsurnameTextBox" & i)
            Dim male As RadioButton = panel.Controls.Item("Childsex0")
            Dim female As RadioButton = panel.Controls.Item("Childsex1")
            'Dim sex As RadioButton = panel.Controls.Item("ChildSexRadioButton" & i)
            If IsNothing(nameTextBox) Or IsNothing(dateOfBirthTextBox) Or IsNothing(surnameTextBox) Then
                'TextBox1.Text = "null"
            Else
                SearchFlights.visitor.childName(i - 1) = nameTextBox.Text
                SearchFlights.visitor.childSurname(i - 1) = surnameTextBox.Text
                SearchFlights.visitor.childDateOfBirth(i - 1) = dateOfBirthTextBox.Text
                'TextBox1.Text = SearchFlights.visitor.childSurname(i - 1)
            End If

            If female.Checked = True Then
                SearchFlights.visitor.childSex(i - 1) = False
            Else
                SearchFlights.visitor.childSex(i - 1) = True
            End If
        Next

        If Not SearchFlights.visitor.numberOfAdultPeople = 0 Then
            SearchFlights.visitor.name = SearchFlights.visitor.adultName(0)
            SearchFlights.visitor.surname = SearchFlights.visitor.adultSurname(0)
            SearchFlights.visitor.dateOfBirth = SearchFlights.visitor.adultDateOfBirth(0)
            SearchFlights.visitor.sex = SearchFlights.visitor.adultSex(0)
            SearchFlights.visitor.childOrAdult = "Adult"
        Else
            SearchFlights.visitor.name = SearchFlights.visitor.childName(0)
            SearchFlights.visitor.surname = SearchFlights.visitor.childSurname(0)
            SearchFlights.visitor.dateOfBirth = SearchFlights.visitor.childDateOfBirth(0)
            SearchFlights.visitor.sex = SearchFlights.visitor.childSex(0)
            SearchFlights.visitor.childOrAdult = "Child"
        End If
        'TextBox1.Text = SearchFlights.visitor.adultName.Length
        Dim payment As New Payment
        payment.ShowDialog()
        Me.Close()
    End Sub

    Private Sub GuesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xFlightTime = 16 : yFlightTime = 20

        Dim i As Integer
        For i = 1 To SearchFlights.visitor.numberOfAdultPeople
            initialView2("Adult", i)
        Next
        For i = 1 To SearchFlights.visitor.numberOfChildPeople
            initialView2("Child", i)
        Next
    End Sub

    Private Sub initialView2(childOrAdult As String, i As Integer)
        Dim panel2 As New Panel
        panel2.Name = childOrAdult & "panel2" & i
        panel2.Dock = DockStyle.Top
        panel2.Size = New Size(Me.Size.Width, 140)
        panel2.Visible = True
        Panel1.Controls.Add(panel2)
        Panel1.Controls.SetChildIndex(panel2, 0)

        Dim adultOrChild As New Label
        adultOrChild.Text = childOrAdult & i
        adultOrChild.AutoSize = True
        adultOrChild.Font = New Font("PMingLiU", 11)
        adultOrChild.ForeColor = SystemColors.ControlText
        adultOrChild.BackColor = SystemColors.Control
        adultOrChild.Location = New Point(xFlightTime, yFlightTime)
        adultOrChild.Visible = True

        Dim label As New Label
        label.Text = "Name"
        label.AutoSize = True
        label.ForeColor = SystemColors.ControlText
        label.BackColor = SystemColors.Control
        label.Location = New Point(xFlightTime + 5, yFlightTime + 29)
        label.Visible = True

        Dim nameTextBox As New TextBox
        nameTextBox.Name = childOrAdult & "nameTextBox" & i
        nameTextBox.Size = New Size(167, 25)
        nameTextBox.AutoSize = True
        nameTextBox.Location = New Point(xFlightTime + 3, yFlightTime + 48)
        nameTextBox.Visible = True


        Dim label1 As New Label
        label1.Text = "Date of birth"
        label1.AutoSize = True
        label1.ForeColor = SystemColors.ControlText
        label1.BackColor = SystemColors.Control
        label1.Location = New Point(xFlightTime + 5, yFlightTime + 76)
        label1.Visible = True

        Dim dateOfBirthTextBox As New TextBox
        dateOfBirthTextBox.Name = childOrAdult & "dateOfBirthTextBox" & i
        dateOfBirthTextBox.Size = New Size(167, 25)
        dateOfBirthTextBox.AutoSize = True
        dateOfBirthTextBox.Location = New Point(xFlightTime + 3, yFlightTime + 95)
        dateOfBirthTextBox.Visible = True


        Dim label2 As New Label
        label2.Text = "Family name / Surname"
        label2.AutoSize = True
        label2.ForeColor = SystemColors.ControlText
        label2.BackColor = SystemColors.Control
        label2.Location = New Point(xFlightTime + 212, yFlightTime + 29)
        label2.Visible = True

        Dim surnameTextBox As New TextBox
        surnameTextBox.Name = childOrAdult & "surnameTextBox" & i
        surnameTextBox.Size = New Size(167, 25)
        surnameTextBox.AutoSize = True
        surnameTextBox.Location = New Point(xFlightTime + 210, yFlightTime + 48)
        surnameTextBox.Visible = True


        Dim maleRadioButton As New RadioButton
        maleRadioButton.Name = childOrAdult & "sex0"
        maleRadioButton.Text = "Male"
        maleRadioButton.AutoSize = True
        maleRadioButton.Checked = True
        maleRadioButton.ForeColor = SystemColors.ControlText
        maleRadioButton.BackColor = SystemColors.Control
        maleRadioButton.Location = New Point(xFlightTime + 212, yFlightTime + 95)
        maleRadioButton.Visible = True

        Dim femaleRadioButton As New RadioButton
        femaleRadioButton.Name = childOrAdult & "sex1"
        femaleRadioButton.Text = "Female"
        femaleRadioButton.AutoSize = True
        femaleRadioButton.ForeColor = SystemColors.ControlText
        femaleRadioButton.BackColor = SystemColors.Control
        femaleRadioButton.Location = New Point(xFlightTime + 260, yFlightTime + 95)
        femaleRadioButton.Visible = True

        panel2.Controls.Add(adultOrChild)
        panel2.Controls.SetChildIndex(adultOrChild, 0)

        panel2.Controls.Add(label)
        panel2.Controls.SetChildIndex(label, 0)
        panel2.Controls.Add(nameTextBox)
        panel2.Controls.SetChildIndex(nameTextBox, 0)

        panel2.Controls.Add(label1)
        panel2.Controls.SetChildIndex(label1, 0)
        panel2.Controls.Add(dateOfBirthTextBox)
        panel2.Controls.SetChildIndex(dateOfBirthTextBox, 0)

        panel2.Controls.Add(label2)
        panel2.Controls.SetChildIndex(label2, 0)
        panel2.Controls.Add(surnameTextBox)
        panel2.Controls.SetChildIndex(surnameTextBox, 0)

        panel2.Controls.Add(maleRadioButton)
        panel2.Controls.SetChildIndex(maleRadioButton, 0)
        panel2.Controls.Add(femaleRadioButton)
        panel2.Controls.SetChildIndex(femaleRadioButton, 0)
    End Sub
End Class