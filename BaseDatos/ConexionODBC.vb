Imports System.Data.Odbc
Public Class ConexionODBC
    Property _conexion As OdbcConnection
    Public Sub New()
        _conexion = New OdbcConnection("dsn=odbcMySQLEmpresa;uid=eberon;pwd=silomontolomeo;")
    End Sub
    Public Sub AbrirConexion()
        Try
            _conexion.Open()
        Catch ex As Exception
            Throw New Exception("ERROR en AbrirConexion() :: " + ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            _conexion.Close()
        Catch ex As Exception
            Throw New Exception("ERROR en CerrarConexion() :: " + ex.Message)
        End Try
    End Sub
    Private Function EjecutarConulta(consulta As String) As DataTable
        Dim dt As New DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet

        Try
            da = New OdbcDataAdapter(consulta, _conexion)
            AbrirConexion()
            da.Fill(ds)
            dt = ds.Tables(0)
            CerrarConexion()
        Catch ex As Exception
            Throw New Exception("ERROR en EjecutarConulta() :: " + ex.Message)
        End Try
        Return dt
    End Function

    Public Function getPersonasActivas() As DataTable
        Dim dt As New DataTable
        Dim consulta As String = "SELECT * FROM personas"
        dt = EjecutarConulta(consulta)
        Return dt
    End Function
End Class
