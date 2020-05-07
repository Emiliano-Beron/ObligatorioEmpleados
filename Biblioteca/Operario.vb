Public Class Operario
    Inherits Empleado

    Private totalPay As Double
    Private Const increse As Double = 0.38

    Public Sub New()
    End Sub

    Public Sub New(ci As Integer, name As String, phone As Integer, adress As String, grossPay As Double, tipo As String)
        MyBase.New(ci, name, phone, adress, grossPay, tipo)
    End Sub

    Public Overrides Function plus(salario As Double) As Double
        totalPay = salario + (salario * increse)
        Return totalPay
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & totalPay
    End Function
End Class
