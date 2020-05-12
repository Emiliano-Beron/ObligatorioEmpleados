Imports System.Data.Odbc
Public Class Consulta_Modificar
    Inherits ConexionODBC

    Public Sub New()
    End Sub

    Public Function Modificar(ci As String, pnom As String, pape As String, dir As String, salario As Integer, tipo As String) As Boolean
        Dim consulta As String
        Dim command As OdbcCommand
        consulta = "UPDATE empleado SET "
        consulta &= "priNom = '" & pnom & "',"
        consulta &= "priApe = '" & pape & "',"
        consulta &= "direccion = '" & dir & "',"
        consulta &= "salario = " & salario.ToString & ","
        consulta &= "tipo = '" & tipo & "' "
        consulta &= "where ci= " & ci.ToString
        Try
            command = New OdbcCommand(consulta, _conexion)
            AbrirConexion()
            command.ExecuteNonQuery()
            CerrarConexion()
            Return True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Function

End Class
