Imports System.Data.Odbc
Public Class ConexionODBC
    Const _user As String = "eberon"
    Const _pass As String = "silomontolomeo"
    Property _conexion As OdbcConnection
    Public Sub New()
        _conexion = New OdbcConnection("dsn=EmpleadosObligatorio;uid=" & _user & ";pwd=" & _pass & ";")
    End Sub
    Public Sub AbrirConexion()
        Try
            _conexion.Open()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            _conexion.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub
End Class
