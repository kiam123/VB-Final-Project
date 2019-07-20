Imports System.Data.OleDb
Public Class SelectFlights
    Dim departDetail() As FlightDetail
    Dim returnDetail() As FlightDetail
    Dim totalView As Integer
    Dim totalView2 As Integer
    Dim totalPrice As Double = 0.0
    Dim tempPrice(1) As String

    Dim mon() As String = {"", "Jan"， "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SearchFlights.visitor.totalPrice = totalPrice
        'TextBox1.Text = tempPrice(0)
        If SearchFlights.visitor.isReturn = True Then
            SearchFlights.visitor.price(0) = tempPrice(0)
            SearchFlights.visitor.price(1) = tempPrice(1)
        Else
            SearchFlights.visitor.price(0) = tempPrice(0)
        End If
        'TextBox1.Text = SearchFlights.visitor.airplaneId(0) & " " & SearchFlights.visitor.airplaneId(1)
        Dim guestDetails2 As New GuestDetails
        guestDetails2.ShowDialog()
        Me.Close()
    End Sub

    Private Sub SelectFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalView = 0
        totalView2 = 0
        getDataFlight()
        initialDepartView()

        If SearchFlights.visitor.isReturn = True Then
            getDataReturn()
            initialReturnView()
        End If
        totalPriceLabel.Text = totalPrice

    End Sub

    Private Sub radioListener(sender As Object, e As EventArgs)
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        setTotalPrice()
        totalPriceLabel.Text = totalPrice
    End Sub

    Public Sub getDataFlight()
        'SearchFlights.myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb")
        'SearchFlights.myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM AirplaneFlight WHERE original = '" & SearchFlights.visitor.original & "' and flightDate='" & SearchFlights.visitor.departDate & "'", SearchFlights.myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim flightTime As New List(Of String)
        Dim arialTime As New List(Of String)
        Dim totalFlightTime As New List(Of String)
        Dim directOrTransfer As New List(Of String)
        Dim price As New List(Of String)
        Dim sellingState As New List(Of String)
        Dim airplaneId As New List(Of String)
        While dr.Read
            'TextBox1.Text = dr(9)
            airplaneId.Add(dr(2))
            flightTime.Add(dr(5))
            arialTime.Add(dr(6))
            totalFlightTime.Add(dr(7))
            directOrTransfer.Add("Direct")
            price.Add(dr(9))
            sellingState.Add(dr(10))
        End While

        ReDim departDetail(flightTime.Count - 1)
        For i As Integer = 0 To flightTime.Count - 1
            departDetail(i) = New FlightDetail
            departDetail(i).airplaneId = airplaneId(i)
            departDetail(i).flightTime = flightTime(i)
            departDetail(i).arialTime = arialTime(i)
            departDetail(i).totalFlightTime = totalFlightTime(i)
            departDetail(i).directOrTransfer = directOrTransfer(i)
            departDetail(i).price = price(i)
            departDetail(i).sellingState = sellingState(i)
        Next
        'TextBox1.Text = airplaneId(1)
        SearchFlights.visitor.airplaneId(0) = airplaneId(0)
        'TextBox1.Text = SearchFlights.visitor.airplaneId(0)
    End Sub

    Private Sub initialDepartView()
        Dim Panel2 As New Panel
        Panel2.Name = "Panel2"

        Dim departLabel As New Label
        departLabel.Text = "Depart"
        departLabel.Font = New Font("PMingLiU", 11)
        departLabel.ForeColor = SystemColors.ControlText
        departLabel.BackColor = SystemColors.Control
        departLabel.AutoSize = True
        departLabel.Location = New Point(20, 11)
        departLabel.Visible = True
        Panel2.Controls.Add(departLabel)

        'TextBox1.Text = departLabel.Location.X

        Dim original As New Label
        original.Text = SearchFlights.visitor.original
        original.AutoSize = True
        original.Location = New Point(departLabel.Location.X + departLabel.Width + 10, 13)
        original.Visible = True
        Panel2.Controls.Add(original)

        Dim label As New Label
        label.Text = "to"
        label.AutoSize = True
        label.Location = New Point(original.Location.X + original.Width + 5, 13)
        label.Visible = True
        Panel2.Controls.Add(label)

        Dim destination As New Label
        destination.Text = SearchFlights.visitor.destination
        destination.AutoSize = True
        destination.Location = New Point(label.Location.X + label.Width + 5, 13)
        destination.Visible = True
        Panel2.Controls.Add(destination)


        Dim i As Integer
        Dim xFlightTime As Integer : Dim yFlightTime As Integer
        xFlightTime = 26 : yFlightTime = 57

        For i = 0 To departDetail.Length - 1
            Dim flightTimelabel As New Label
            flightTimelabel.Name = "flightTimelabel" & i
            flightTimelabel.Text = departDetail(i).flightTime
            flightTimelabel.AutoSize = True
            flightTimelabel.Location = New Point(xFlightTime, yFlightTime)
            flightTimelabel.Visible = True

            Dim reachTimelabel As New Label
            reachTimelabel.Text = departDetail(i).totalFlightTime
            reachTimelabel.AutoSize = True
            reachTimelabel.Location = New Point(xFlightTime, yFlightTime + 12)
            reachTimelabel.Visible = True

            Dim pic As New PictureBox
            pic.Size = New Size(25, 32)
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Image = My.Resources.aircraft
            pic.Location = New Point(xFlightTime + 53, yFlightTime - 4)
            pic.Visible = True

            Dim label1 As New Label
            label1.Text = "-----------------------------------------"
            label1.AutoSize = True
            label1.Location = New Point(xFlightTime + 80, yFlightTime + 3)
            label1.Visible = True

            Dim arialTime As New Label
            arialTime.Name = "arialTimeLabel" & i
            arialTime.Text = departDetail(i).arialTime
            arialTime.AutoSize = True
            arialTime.Location = New Point(xFlightTime + 262, yFlightTime)
            arialTime.Visible = True

            Dim label2 As New Label
            label2.Text = departDetail(i).directOrTransfer
            label2.AutoSize = True
            label2.Location = New Point(xFlightTime + 262, yFlightTime + 12)
            label2.Visible = True

            Dim price As New Label
            price.Name = "priceLabel" & i
            price.Text = departDetail(i).price
            price.AutoSize = True
            price.Location = New Point(xFlightTime + 310, yFlightTime)
            price.Visible = True

            Dim label3 As New Label
            label3.Text = "MYR"
            label3.AutoSize = True
            label3.Location = New Point(xFlightTime + 348, yFlightTime)
            label3.Visible = True

            Dim label4 As New Label
            label4.Text = departDetail(i).sellingState
            label4.AutoSize = True
            label4.Location = New Point(xFlightTime + 310, yFlightTime + 12)
            label4.Visible = True

            Dim priceRadioButton As New RadioButton
            priceRadioButton.Text = ""
            If i = 0 Then
                priceRadioButton.Checked = True
                totalPrice += departDetail(i).price
                tempPrice(0) = departDetail(i).price
                SearchFlights.visitor.departTime(0) = flightTimelabel.Text
                SearchFlights.visitor.departTime(1) = arialTime.Text
            End If
            priceRadioButton.Name = "priceRadioButton" & i
            priceRadioButton.AutoSize = True
            priceRadioButton.Location = New Point(xFlightTime + 393, yFlightTime)
            priceRadioButton.Visible = True
            AddHandler priceRadioButton.CheckedChanged, AddressOf radioListener

            yFlightTime += 47

            Panel2.Controls.Add(flightTimelabel)
            Panel2.Controls.Add(reachTimelabel)
            Panel2.Controls.Add(pic)
            Panel2.Controls.Add(label1)
            Panel2.Controls.Add(arialTime)
            Panel2.Controls.Add(label2)
            Panel2.Controls.Add(price)
            Panel2.Controls.Add(label3)
            Panel2.Controls.Add(label4)
            Panel2.Controls.Add(priceRadioButton)

            totalView = Math.Max(flightTimelabel.Location.Y, totalView)
            totalView = Math.Max(reachTimelabel.Location.Y, totalView)
            totalView = Math.Max(pic.Location.Y, totalView)
            totalView = Math.Max(label1.Location.Y, totalView)
            totalView = Math.Max(arialTime.Location.Y, totalView)
            totalView = Math.Max(label2.Location.Y, totalView)
            totalView = Math.Max(price.Location.Y, totalView)
            totalView = Math.Max(label3.Location.Y, totalView)
            totalView = Math.Max(label4.Location.Y, totalView)
            totalView = Math.Max(priceRadioButton.Location.Y, totalView)
        Next
        Panel2.Dock = DockStyle.Top
        Panel2.Size = New Size(Me.Size.Width, totalView + 40)
        Panel2.Visible = True
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.SetChildIndex(Panel2, 0)
    End Sub

    Public Sub getDataReturn()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM AirplaneFlight WHERE original = '" & SearchFlights.visitor.destination & "' and flightDate='" & SearchFlights.visitor.returnDate & "'", SearchFlights.myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim flightTime As New List(Of String)
        Dim arialTime As New List(Of String)
        Dim totalFlightTime As New List(Of String)
        Dim directOrTransfer As New List(Of String)
        Dim price As New List(Of String)
        Dim sellingState As New List(Of String)
        Dim airplaneId As New List(Of String)

        While dr.Read
            'airplaneId.Add(dr(2))
            'flightTime.Add(dr(3))
            'arialTime.Add(dr(4))
            'totalFlightTime.Add(dr(5))
            'directOrTransfer.Add("Direct")
            'price.Add(dr(6))
            'sellingState.Add(dr(7))
            airplaneId.Add(dr(2))
            flightTime.Add(dr(5))
            arialTime.Add(dr(6))
            totalFlightTime.Add(dr(7))
            directOrTransfer.Add("Direct")
            price.Add(dr(9))
            sellingState.Add(dr(10))
        End While

        ReDim returnDetail(flightTime.Count - 1)
        For i As Integer = 0 To flightTime.Count - 1
            returnDetail(i) = New FlightDetail
            returnDetail(i).airplaneId = airplaneId(i)
            returnDetail(i).flightTime = flightTime(i)
            returnDetail(i).arialTime = arialTime(i)
            returnDetail(i).totalFlightTime = totalFlightTime(i)
            returnDetail(i).directOrTransfer = directOrTransfer(i)
            returnDetail(i).price = price(i)
            returnDetail(i).sellingState = sellingState(i)
        Next
        SearchFlights.visitor.airplaneId(1) = airplaneId(0)
    End Sub

    Private Sub initialReturnView()
        Dim Panel3 As New Panel
        Panel3.Name = "panel3"

        Dim departLabel As New Label
        departLabel.Text = "Return"
        departLabel.Font = New Font("PMingLiU", 11)
        departLabel.ForeColor = SystemColors.ControlText
        departLabel.BackColor = SystemColors.Control
        departLabel.AutoSize = True
        departLabel.Location = New Point(20, 11)
        departLabel.Visible = True
        Panel3.Controls.Add(departLabel)

        'TextBox1.Text = departLabel.Location.X

        Dim original As New Label
        original.Text = SearchFlights.visitor.destination
        original.AutoSize = True
        original.Location = New Point(departLabel.Location.X + departLabel.Width + 10, 13)
        original.Visible = True
        Panel3.Controls.Add(original)

        Dim label As New Label
        label.Text = "to"
        label.AutoSize = True
        label.Location = New Point(original.Location.X + original.Width + 5, 13)
        label.Visible = True
        Panel3.Controls.Add(label)

        Dim destination As New Label
        destination.Text = SearchFlights.visitor.original
        destination.AutoSize = True
        destination.Location = New Point(label.Location.X + label.Width + 5, 13)
        destination.Visible = True
        Panel3.Controls.Add(destination)


        Dim i As Integer
        Dim xFlightTime As Integer : Dim yFlightTime As Integer
        xFlightTime = 26 : yFlightTime = 57

        For i = 0 To returnDetail.Length - 1
            Dim flightTimelabel As New Label
            flightTimelabel.Name = "flightTimelabel" & i
            flightTimelabel.Text = returnDetail(i).flightTime
            flightTimelabel.AutoSize = True
            flightTimelabel.Location = New Point(xFlightTime, yFlightTime)
            flightTimelabel.Visible = True

            Dim reachTimelabel As New Label
            reachTimelabel.Text = returnDetail(i).totalFlightTime
            reachTimelabel.AutoSize = True
            reachTimelabel.Location = New Point(xFlightTime, yFlightTime + 12)
            reachTimelabel.Visible = True

            Dim pic As New PictureBox
            pic.Size = New Size(25, 32)
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Image = My.Resources.aircraft
            pic.Location = New Point(xFlightTime + 53, yFlightTime - 4)
            pic.Visible = True

            Dim label1 As New Label
            label1.Text = "-----------------------------------------"
            label1.AutoSize = True
            label1.Location = New Point(xFlightTime + 80, yFlightTime + 3)
            label1.Visible = True

            Dim arialTime As New Label
            arialTime.Name = "arialTimeLabel" & i
            arialTime.Text = returnDetail(i).arialTime
            arialTime.AutoSize = True
            arialTime.Location = New Point(xFlightTime + 262, yFlightTime)
            arialTime.Visible = True

            Dim label2 As New Label
            label2.Text = returnDetail(i).directOrTransfer
            label2.AutoSize = True
            label2.Location = New Point(xFlightTime + 262, yFlightTime + 12)
            label2.Visible = True

            Dim price As New Label
            price.Name = "priceLabel" & i
            price.Text = returnDetail(i).price
            price.AutoSize = True
            price.Location = New Point(xFlightTime + 310, yFlightTime)
            price.Visible = True

            Dim label3 As New Label
            label3.Text = "MYR"
            label3.AutoSize = True
            label3.Location = New Point(xFlightTime + 348, yFlightTime)
            label3.Visible = True

            Dim label4 As New Label
            label4.Text = returnDetail(i).sellingState
            label4.AutoSize = True
            label4.Location = New Point(xFlightTime + 310, yFlightTime + 12)
            label4.Visible = True

            Dim priceRadioButton As New RadioButton
            priceRadioButton.Name = "priceRadioButton" & i
            priceRadioButton.Text = ""
            If i = 0 Then
                priceRadioButton.Checked = True
                totalPrice += returnDetail(i).price
                tempPrice(1) = returnDetail(i).price
                SearchFlights.visitor.returnTime(0) = flightTimelabel.Text
                SearchFlights.visitor.returnTime(1) = arialTime.Text
            End If
            priceRadioButton.AutoSize = True
            priceRadioButton.Location = New Point(xFlightTime + 393, yFlightTime)
            priceRadioButton.Visible = True
            AddHandler priceRadioButton.CheckedChanged, AddressOf radioListener

            yFlightTime += 47

            Panel3.Controls.Add(flightTimelabel)
            Panel3.Controls.Add(reachTimelabel)
            Panel3.Controls.Add(pic)
            Panel3.Controls.Add(label1)
            Panel3.Controls.Add(arialTime)
            Panel3.Controls.Add(label2)
            Panel3.Controls.Add(price)
            Panel3.Controls.Add(label3)
            Panel3.Controls.Add(label4)
            Panel3.Controls.Add(priceRadioButton)

            totalView2 = Math.Max(flightTimelabel.Location.Y, totalView2)
            totalView2 = Math.Max(reachTimelabel.Location.Y, totalView2)
            totalView2 = Math.Max(pic.Location.Y, totalView2)
            totalView2 = Math.Max(label1.Location.Y, totalView2)
            totalView2 = Math.Max(arialTime.Location.Y, totalView2)
            totalView2 = Math.Max(label2.Location.Y, totalView2)
            totalView2 = Math.Max(price.Location.Y, totalView2)
            totalView2 = Math.Max(label3.Location.Y, totalView2)
            totalView2 = Math.Max(label4.Location.Y, totalView2)
            totalView2 = Math.Max(priceRadioButton.Location.Y, totalView2)
        Next
        Panel3.Dock = DockStyle.Top
        Panel3.Size = New Size(Me.Size.Width, totalView2 + 40)
        Panel3.Visible = True
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.SetChildIndex(Panel3, 0)
    End Sub

    Private Sub setTotalPrice()
        Dim panel2 As Panel = Panel1.Controls.Item("panel2")
        Dim panel3 As Panel = Panel1.Controls.Item("panel3")
        totalPrice = 0
        For i = 0 To departDetail.Length - 1
            Dim priceLabel As Label = panel2.Controls.Item("priceLabel" & i)
            Dim priceRadioButton As RadioButton = panel2.Controls.Item("priceRadioButton" & i)
            Dim flightTimelabel As Label = panel2.Controls.Item("flightTimelabel" & i)
            Dim arialTimelabel As Label = panel2.Controls.Item("arialTimeLabel" & i)
            If priceRadioButton.Checked = True Then
                totalPrice += CInt(priceLabel.Text)
                tempPrice(0) = priceLabel.Text
                SearchFlights.visitor.departTime(0) = flightTimelabel.Text
                SearchFlights.visitor.departTime(1) = arialTimelabel.Text
                SearchFlights.visitor.airplaneId(0) = departDetail(i).airplaneId
            End If
        Next

        For i = 0 To returnDetail.Length - 1
            Dim priceLabel As Label = panel3.Controls.Item("priceLabel" & i)
            Dim priceRadioButton As RadioButton = panel3.Controls.Item("priceRadioButton" & i)
            Dim flightTimelabel As Label = panel3.Controls.Item("flightTimelabel" & i)
            Dim arialTimelabel As Label = panel3.Controls.Item("arialTimeLabel" & i)
            If priceRadioButton.Checked = True Then
                totalPrice += CInt(priceLabel.Text)
                tempPrice(1) = priceLabel.Text
                SearchFlights.visitor.returnTime(0) = flightTimelabel.Text
                SearchFlights.visitor.returnTime(1) = arialTimelabel.Text

                SearchFlights.visitor.airplaneId(1) = returnDetail(i).airplaneId
            End If
        Next


    End Sub
End Class