Public Class Gerente
    Inherits Empleado

    Private totalPay As Integer
    Private Const increse As Double = 0.97

    Public Sub New()
    End Sub

    Public Sub New(ci As Integer, name As String, ape As String, phone As Integer, adress As String, grossPay As Integer, tipo As String)
        MyBase.New(ci, name, ape, phone, adress, grossPay, tipo)
    End Sub

    Public Overrides Function plus(salario As Double) As Double
        totalPay = salario + (salario * increse)
        Return totalPay
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & totalPay
    End Function
End Class
