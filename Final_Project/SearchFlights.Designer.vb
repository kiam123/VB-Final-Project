<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchFlights
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.returnDateLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.returnRadioButton = New System.Windows.Forms.RadioButton()
        Me.oneWayRadioButton = New System.Windows.Forms.RadioButton()
        Me.adultNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.childNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.original = New System.Windows.Forms.ComboBox()
        Me.destination = New System.Windows.Forms.ComboBox()
        Me.departDate = New System.Windows.Forms.ComboBox()
        Me.returnDateText = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.adultNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Original"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Destination"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Depart date"
        '
        'returnDateLabel
        '
        Me.returnDateLabel.AutoSize = True
        Me.returnDateLabel.Location = New System.Drawing.Point(234, 89)
        Me.returnDateLabel.Name = "returnDateLabel"
        Me.returnDateLabel.Size = New System.Drawing.Size(59, 12)
        Me.returnDateLabel.TabIndex = 5
        Me.returnDateLabel.Text = "Return date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'returnRadioButton
        '
        Me.returnRadioButton.AutoSize = True
        Me.returnRadioButton.Checked = True
        Me.returnRadioButton.Location = New System.Drawing.Point(41, 162)
        Me.returnRadioButton.Name = "returnRadioButton"
        Me.returnRadioButton.Size = New System.Drawing.Size(55, 16)
        Me.returnRadioButton.TabIndex = 17
        Me.returnRadioButton.TabStop = True
        Me.returnRadioButton.Text = "Return"
        Me.returnRadioButton.UseVisualStyleBackColor = True
        '
        'oneWayRadioButton
        '
        Me.oneWayRadioButton.AutoSize = True
        Me.oneWayRadioButton.Location = New System.Drawing.Point(160, 162)
        Me.oneWayRadioButton.Name = "oneWayRadioButton"
        Me.oneWayRadioButton.Size = New System.Drawing.Size(64, 16)
        Me.oneWayRadioButton.TabIndex = 18
        Me.oneWayRadioButton.Text = "One way"
        Me.oneWayRadioButton.UseVisualStyleBackColor = True
        '
        'adultNumericUpDown
        '
        Me.adultNumericUpDown.Location = New System.Drawing.Point(76, 189)
        Me.adultNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.adultNumericUpDown.Name = "adultNumericUpDown"
        Me.adultNumericUpDown.Size = New System.Drawing.Size(62, 22)
        Me.adultNumericUpDown.TabIndex = 20
        Me.adultNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'childNumericUpDown
        '
        Me.childNumericUpDown.Location = New System.Drawing.Point(198, 189)
        Me.childNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.childNumericUpDown.Name = "childNumericUpDown"
        Me.childNumericUpDown.Size = New System.Drawing.Size(63, 22)
        Me.childNumericUpDown.TabIndex = 19
        '
        'original
        '
        Me.original.FormattingEnabled = True
        Me.original.Location = New System.Drawing.Point(38, 44)
        Me.original.Name = "original"
        Me.original.Size = New System.Drawing.Size(100, 20)
        Me.original.TabIndex = 23
        '
        'destination
        '
        Me.destination.FormattingEnabled = True
        Me.destination.Location = New System.Drawing.Point(232, 44)
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(100, 20)
        Me.destination.TabIndex = 24
        '
        'departDate
        '
        Me.departDate.FormattingEnabled = True
        Me.departDate.Location = New System.Drawing.Point(38, 111)
        Me.departDate.Name = "departDate"
        Me.departDate.Size = New System.Drawing.Size(100, 20)
        Me.departDate.TabIndex = 25
        '
        'returnDateText
        '
        Me.returnDateText.FormattingEnabled = True
        Me.returnDateText.Location = New System.Drawing.Point(232, 111)
        Me.returnDateText.Name = "returnDateText"
        Me.returnDateText.Size = New System.Drawing.Size(100, 20)
        Me.returnDateText.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Child"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Adult"
        '
        'SearchFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 269)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.returnDateText)
        Me.Controls.Add(Me.departDate)
        Me.Controls.Add(Me.destination)
        Me.Controls.Add(Me.original)
        Me.Controls.Add(Me.adultNumericUpDown)
        Me.Controls.Add(Me.childNumericUpDown)
        Me.Controls.Add(Me.returnRadioButton)
        Me.Controls.Add(Me.oneWayRadioButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.returnDateLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchFlights"
        Me.Text = "Search flights"
        CType(Me.adultNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents returnDateLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents returnRadioButton As RadioButton
    Friend WithEvents oneWayRadioButton As RadioButton
    Friend WithEvents adultNumericUpDown As NumericUpDown
    Friend WithEvents childNumericUpDown As NumericUpDown
    Friend WithEvents original As ComboBox
    Friend WithEvents destination As ComboBox
    Friend WithEvents departDate As ComboBox
    Friend WithEvents returnDateText As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
