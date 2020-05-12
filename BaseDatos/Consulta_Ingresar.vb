Imports System.Data.Odbc
Public Class Consulta_Ingresar
    Inherits ConexionODBC

    Public Sub New()
    End Sub
    Public Function Ingresar(ci As Integer,
                    priNom As String,
                    priApe As String,
                    sueldo As Double,
                    tipo As String,
                    dir As String) As Boolean

        Dim _consulta As String
        Dim command As OdbcCommand
        Dim _resultado As Boolean = False
        'Creo la consulta para ingresar un empleado
        _consulta = "INSERT INTO empleado(ci,priNom,priApe,salario,direccion,tipo)"
        _consulta &= " VALUES ( "
        _consulta &= ci.ToString & ","
        _consulta &= "'" & priNom & "',"
        _consulta &= "'" & priApe & "',"
        _consulta &= "'" & sueldo & "',"
        _consulta &= "'" & dir & "',"
        _consulta &= "'" & tipo & "')"

        command = New OdbcCommand(_consulta, _conexion)

        Try
            AbrirConexion()
            command.ExecuteNonQuery()
            CerrarConexion()
            _resultado = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        Return _resultado
    End Function
End Class
