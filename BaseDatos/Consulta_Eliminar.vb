Imports System.Data.Odbc
Public Class Consulta_Eliminar
    Inherits ConexionODBC
    Public Sub New()
    End Sub
    Public Sub eliminar(ci As Integer)
        Dim comandoSQL As OdbcCommand
        comandoSQL = New OdbcCommand("DELETE FROM empleado WHERE ci=" & ci.ToString, _conexion)
        Try
            AbrirConexion()
            comandoSQL.ExecuteNonQuery()
            CerrarConexion()
            MsgBox("se elimino")
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
End Class
