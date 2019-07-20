<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.phoneNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.emailAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.expirationCVV = New System.Windows.Forms.TextBox()
        Me.expirationYear = New System.Windows.Forms.TextBox()
        Me.expirationMon = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nameOfCard = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cardNumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.processingFee = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.phoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.emailAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nameLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact details"
        '
        'phoneNumber
        '
        Me.phoneNumber.Location = New System.Drawing.Point(114, 66)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.Size = New System.Drawing.Size(100, 22)
        Me.phoneNumber.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone Number : "
        '
        'emailAddress
        '
        Me.emailAddress.Location = New System.Drawing.Point(114, 38)
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.Size = New System.Drawing.Size(100, 22)
        Me.emailAddress.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email address :"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(57, 18)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 12)
        Me.nameLabel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(379, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 12)
        Me.Label12.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(359, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 12)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "to"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 12)
        Me.Label14.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(115, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 12)
        Me.Label11.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 12)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "to"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 12)
        Me.Label9.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 12)
        Me.Label8.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 12)
        Me.Label7.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Return date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Depart date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.expirationCVV)
        Me.GroupBox3.Controls.Add(Me.expirationYear)
        Me.GroupBox3.Controls.Add(Me.expirationMon)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.nameOfCard)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cardNumber)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 139)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(321, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 12)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "CVV"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(246, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 12)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "YY"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(164, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 12)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "MM"
        '
        'expirationCVV
        '
        Me.expirationCVV.Location = New System.Drawing.Point(350, 65)
        Me.expirationCVV.Name = "expirationCVV"
        Me.expirationCVV.Size = New System.Drawing.Size(49, 22)
        Me.expirationCVV.TabIndex = 15
        '
        'expirationYear
        '
        Me.expirationYear.Location = New System.Drawing.Point(270, 65)
        Me.expirationYear.Name = "expirationYear"
        Me.expirationYear.Size = New System.Drawing.Size(49, 22)
        Me.expirationYear.TabIndex = 14
        '
        'expirationMon
        '
        Me.expirationMon.Location = New System.Drawing.Point(192, 65)
        Me.expirationMon.Name = "expirationMon"
        Me.expirationMon.Size = New System.Drawing.Size(49, 22)
        Me.expirationMon.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(161, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 12)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Expiration Date"
        '
        'nameOfCard
        '
        Me.nameOfCard.Location = New System.Drawing.Point(18, 105)
        Me.nameOfCard.Name = "nameOfCard"
        Me.nameOfCard.Size = New System.Drawing.Size(100, 22)
        Me.nameOfCard.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 12)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Name on card"
        '
        'cardNumber
        '
        Me.cardNumber.Location = New System.Drawing.Point(18, 65)
        Me.cardNumber.Name = "cardNumber"
        Me.cardNumber.Size = New System.Drawing.Size(100, 22)
        Me.cardNumber.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 12)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Card number"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 12)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Credit / debit card"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.processingFee)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.subtotal)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.totalPrice)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(476, 103)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(111, 78)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 12)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "MYR"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(111, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 12)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "MYR"
        '
        'processingFee
        '
        Me.processingFee.AutoSize = True
        Me.processingFee.Location = New System.Drawing.Point(145, 78)
        Me.processingFee.Name = "processingFee"
        Me.processingFee.Size = New System.Drawing.Size(26, 12)
        Me.processingFee.TabIndex = 5
        Me.processingFee.Text = "0.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(20, 78)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 12)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Processing fee"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(145, 59)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(38, 12)
        Me.subtotal.TabIndex = 3
        Me.subtotal.Text = "813.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 59)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 12)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Subtotal"
        '
        'totalPrice
        '
        Me.totalPrice.AutoSize = True
        Me.totalPrice.Location = New System.Drawing.Point(76, 22)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(38, 12)
        Me.totalPrice.TabIndex = 1
        Me.totalPrice.Text = "813.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Total MYR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Purchase"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 597)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents phoneNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emailAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents expirationCVV As TextBox
    Friend WithEvents expirationYear As TextBox
    Friend WithEvents expirationMon As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents nameOfCard As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cardNumber As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents processingFee As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents totalPrice As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button1 As Button
End Class
