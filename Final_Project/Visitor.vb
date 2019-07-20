Public Class Visitor
    'search flights
    Public original As String
    Public destination As String
    Public departDate As String
    Public returnDate As String
    Public isReturn As Boolean
    Public haveAdult As Boolean
    Public haveChild As Boolean
    Public numberOfAdultPeople As Integer
    Public numberOfChildPeople As Integer

    Public airplaneId(1) As String
    Public departTime(1) As String
    Public returnTime(1) As String

    'guest details
    Public adultName(0) As String
    Public adultSurname(0) As String
    Public adultDateOfBirth(0) As String
    Public adultSex(0) As Boolean

    Public childName(0) As String
    Public childSurname(0) As String
    Public childDateOfBirth(0) As String
    Public childSex(0) As Boolean

    'contact details
    Public name As String
    Public surname As String
    Public dateOfBirth As String
    Public sex As String
    Public childOrAdult As String
    Public emailAddress As String
    Public phoneNumber As String
    Public price(1) As String
    Public buyTime As String
    Public totalPrice As Double

End Class
