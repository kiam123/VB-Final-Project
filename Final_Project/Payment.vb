Imports System.Data.OleDb
Public Class Payment
    Dim mon() As String = {"", "Jan"， "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (checkDataInputFinish()) Then
            updateData()
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalPrice.Text = SearchFlights.visitor.totalPrice
        subtotal.Text = SearchFlights.visitor.totalPrice
        If SearchFlights.visitor.adultName.Length > 0 Then
            nameLabel.Text = SearchFlights.visitor.adultName(0) & " " & SearchFlights.visitor.adultSurname(0)
        Else
            nameLabel.Text = SearchFlights.visitor.childName(0) & " " & SearchFlights.visitor.childSurname(0)
        End If

        If SearchFlights.visitor.isReturn = False Then
            Label6.Visible = False
            Label8.Visible = False
            Label14.Visible = False
            Label13.Visible = False
            Label12.Visible = False
        Else
            setDate(Label7, SearchFlights.visitor.departDate)
            setDate(Label8, SearchFlights.visitor.returnDate)
            setTarget(Label9, Label11, SearchFlights.visitor.original, SearchFlights.visitor.destination)
            setTarget(Label14, Label12, SearchFlights.visitor.destination, SearchFlights.visitor.original)
        End If
    End Sub

    Private Sub setDate(label As Label, dateDay As String)
        Dim length As Integer
        length = dateDay.Split("/").Length - 1
        For i As Integer = length To 0 Step -1
            If i = 1 Then
                label.Text = label.Text & " " & mon(dateDay.Split("/")(i))
            Else
                label.Text = label.Text & " " & dateDay.Split("/")(i)
            End If
        Next
    End Sub

    Private Sub setTarget(label As Label, label2 As Label, original As String, destination As String)
        label.Text = original
        label2.Text = destination
    End Sub

    Private Function checkDataInputFinish() As Boolean
        If emailAddress.Text.Equals("") Or phoneNumber.Text.Equals("") Or cardNumber.Text.Equals("") Or expirationMon.Text.Equals("") Or
           expirationYear.Text.Equals("") Or expirationCVV.Text.Equals("") Or nameOfCard.Text.Equals("") Then
            Return False
        End If

        Return True
    End Function

    Private Sub updateData()
        Dim name = New String(SearchFlights.visitor.adultName.Length + SearchFlights.visitor.childName.Length - 1) {}
        Dim surname = New String(SearchFlights.visitor.adultSurname.Length + SearchFlights.visitor.childSurname.Length - 1) {}
        Dim dateOfBirth = New String(SearchFlights.visitor.adultDateOfBirth.Length + SearchFlights.visitor.childDateOfBirth.Length - 1) {}
        Dim sex = New Boolean(SearchFlights.visitor.adultSex.Length + SearchFlights.visitor.childSex.Length - 1) {}
        Dim tempSex As String = ""

        If Not SearchFlights.visitor.adultName.Length = 0 Then
            Array.Copy(SearchFlights.visitor.adultName, name, SearchFlights.visitor.adultName.Length)
            Array.Copy(SearchFlights.visitor.childName, 0, name, SearchFlights.visitor.childName.Length, SearchFlights.visitor.childName.Length)

            Array.Copy(SearchFlights.visitor.adultSurname, surname, SearchFlights.visitor.adultSurname.Length)
            Array.Copy(SearchFlights.visitor.childSurname, 0, surname, SearchFlights.visitor.childSurname.Length, SearchFlights.visitor.childSurname.Length)

            Array.Copy(SearchFlights.visitor.adultDateOfBirth, dateOfBirth, SearchFlights.visitor.adultDateOfBirth.Length)
            Array.Copy(SearchFlights.visitor.childDateOfBirth, 0, dateOfBirth, SearchFlights.visitor.childDateOfBirth.Length, SearchFlights.visitor.childDateOfBirth.Length)

            Array.Copy(SearchFlights.visitor.adultSex, sex, SearchFlights.visitor.adultSex.Length)
            Array.Copy(SearchFlights.visitor.childSex, 0, sex, SearchFlights.visitor.childSex.Length, SearchFlights.visitor.childSex.Length)
        Else
            Array.Copy(SearchFlights.visitor.childName, name, SearchFlights.visitor.childName.Length)

            Array.Copy(SearchFlights.visitor.childSurname, surname, SearchFlights.visitor.childSurname.Length)

            Array.Copy(SearchFlights.visitor.childDateOfBirth, dateOfBirth, SearchFlights.visitor.childDateOfBirth.Length)

            Array.Copy(SearchFlights.visitor.childSex, sex, SearchFlights.visitor.childSex.Length)
        End If

        Dim sqlCountcommand As String = "SELECT COUNT(visitorId) FROM VisitorData;"
        Dim sqlcommand As String



        SearchFlights.visitor.emailAddress = emailAddress.Text
        SearchFlights.visitor.phoneNumber = phoneNumber.Text

        Dim time As String = DateTime.Now.ToString("HH:mm")
        For i As Integer = 0 To name.Length - 1
            Dim cmd As OleDbCommand = New OleDbCommand(sqlCountcommand, SearchFlights.myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim count As Integer = 0
            While dr.Read
                count = dr(0) + 1
            End While

            Dim childOrAdult As String = ""
            If i < SearchFlights.visitor.adultName.Length Then
                childOrAdult = "Adult"
            Else
                childOrAdult = "Child"
            End If
            If sex(i) = True Then
                tempSex = "male"
            Else
                tempSex = "female"
            End If

            sqlcommand = "INSERT INTO VisitorData (visitorId, ticketId, name, surname, dateOfBirth, sex, childOrAdult, contactEmailAddress, 
                                                      contactPhoneNumber, price, buyTime, flightTiketDate)
                          VALUES ('V" & count & "'," & "'T" & count & "','" & name(i) & "','" & surname(i) & "','" & dateOfBirth(i) & "', 
                                  '" & tempSex & "','" & childOrAdult & "','" & SearchFlights.visitor.emailAddress & "',
                                  '" & SearchFlights.visitor.phoneNumber & "','" & SearchFlights.visitor.price(0) & "','" & time & "',
                                  '" & SearchFlights.visitor.departDate & "');"

            cmd = New OleDbCommand(sqlcommand, SearchFlights.myConnection)
            cmd.ExecuteNonQuery()

            sqlcommand = "INSERT INTO Ticket (ticketId, visitorId, airplaneId, flightTiketDate, flightTime)
                          VALUES ('T" & count & "'," & "'V" & count & "','" & SearchFlights.visitor.airplaneId(0) & "',
                                  '" & SearchFlights.visitor.departDate & "','" & SearchFlights.visitor.departTime(0) & "');"


            cmd = New OleDbCommand(sqlcommand, SearchFlights.myConnection)
            cmd.ExecuteNonQuery()
        Next

        If SearchFlights.visitor.isReturn = True Then
            For i As Integer = 0 To name.Length - 1
                Dim cmd As OleDbCommand = New OleDbCommand(sqlCountcommand, SearchFlights.myConnection)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                Dim count As Integer = 0
                While dr.Read
                    count = dr(0) + 1
                    'TextBox1.Text = count
                End While

                Dim childOrAdult As String = ""
                If i < SearchFlights.visitor.adultName.Length Then
                    childOrAdult = "Adult"
                Else
                    childOrAdult = "Child"
                End If
                If sex(i) = True Then
                    tempSex = "male"
                Else
                    tempSex = "female"
                End If
                'TextBox1.Text = surname(i)
                sqlcommand = "INSERT INTO VisitorData (visitorId, ticketId, name, surname, dateOfBirth, sex, childOrAdult, contactEmailAddress, 
                                                      contactPhoneNumber, price, buyTime, flightTiketDate)
                          VALUES ('V" & count & "'," & "'T" & count & "','" & name(i) & "','" & surname(i) & "','" & dateOfBirth(i) & "', 
                                  '" & tempSex & "','" & childOrAdult & "','" & SearchFlights.visitor.emailAddress & "',
                                  '" & SearchFlights.visitor.phoneNumber & "','" & SearchFlights.visitor.price(1) & "','" & time & "',
                                  '" & SearchFlights.visitor.returnDate & "');"

                cmd = New OleDbCommand(sqlcommand, SearchFlights.myConnection)
                cmd.ExecuteNonQuery()
                sqlcommand = "INSERT INTO Ticket (ticketId, visitorId, airplaneId, flightTiketDate, flightTime)
                          VALUES ('T" & count & "'," & "'V" & count & "','" & SearchFlights.visitor.airplaneId(1) & "',
                                  '" & SearchFlights.visitor.returnDate & "','" & SearchFlights.visitor.returnTime(0) & "');"


                cmd = New OleDbCommand(sqlcommand, SearchFlights.myConnection)
                cmd.ExecuteNonQuery()
            Next
        End If
    End Sub
End Class