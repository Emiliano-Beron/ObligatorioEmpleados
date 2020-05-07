Public Class Empleado

    Private ci As Integer
    Private name As String
    Private phone As Integer
    Private adress As String
    Private grossPay As Double
    Private tipo As String
    Public Sub New()
    End Sub
    Public Sub New(ci As Integer, name As String, phone As Integer, adress As String, grossPay As Double, tipo As String)
        Me.ci = ci
        Me.name = name
        Me.phone = phone
        Me.adress = adress
        Me.grossPay = grossPay
        Me.tipo = tipo
    End Sub

    Public Property Ci1 As Integer
        Get
            Return ci
        End Get
        Set(value As Integer)
            ci = value
        End Set
    End Property

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property


    Public Property Adress1 As String
        Get
            Return adress
        End Get
        Set(value As String)
            adress = value
        End Set
    End Property

    Public Property GrossPay1 As Double
        Get
            Return grossPay
        End Get
        Set(value As Double)
            grossPay = value
        End Set
    End Property
    Public Property Phone1 As Integer
        Get
            Return phone
        End Get
        Set(value As Integer)
            phone = value
        End Set
    End Property

    Public Property Tipo1 As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format(ci & ";" & name & ";" & phone & ";" & adress & ";" & tipo & ";")
    End Function

    Public Overridable Function Plus(salario As Double) As Double
        Return 0
    End Function

End Class
