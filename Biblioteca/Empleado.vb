Public Class Empleado

    Property _ci As Integer
    Property _priNom As String
    Property _priApe As String
    Property _phone As Integer
    Property _adress As String
    Property _salario As Integer
    Property _tipo As String
    Public Sub New()
    End Sub
    Public Sub New(ci As Integer, name As String, ape As String, phone As Integer, adress As String, grossPay As Integer, tipo As String)
        _ci = ci
        _priNom = name
        _priApe = ape
        _phone = phone
        _adress = adress
        _salario = grossPay
        _tipo = tipo
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format(_ci & ";" & _priNom & ";" & _priApe & ";" & _phone & ";" & _adress & ";" & _tipo & ";")
    End Function

    Public Overridable Function Plus(salario As Double) As Double
        Return 0
    End Function

End Class
