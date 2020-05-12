Imports System.Data.Odbc
Public Class ConexionODBC
    Const _user As String = "eberon"
    Const _pass As String = "silomontolomeo"
    Property _conexion As OdbcConnection
    Public Sub New()
<<<<<<< HEAD
        _conexion = New OdbcConnection("dsn=EmpleadosObligatorio;uid=" & _user & ";pwd=" & _pass & ";")
=======
        _conexion = New OdbcConnection("dsn=EmpleadosObligatorio;uid=;pwd=;")
>>>>>>> 5d853bb97095ce94c93c7ec18afee60e4e8b0b0d
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
