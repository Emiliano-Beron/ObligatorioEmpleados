Imports BaseDatos
Public Class LlamarConsultas
    Public Sub New()
    End Sub
    Public Function Ingresar(ci As Integer,
                    priNom As String,
                    priApe As String,
                    sueldo As Double,
                    tipo As String,
                    dir As String) As Boolean
        Dim cons As New Consulta_Ingresar
        If cons.Ingresar(ci, priNom, priApe, sueldo, tipo, dir) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Cargar()
        Dim con As New ConexionODBC
        Return con.getPersonasActivas()
    End Function
End Class
