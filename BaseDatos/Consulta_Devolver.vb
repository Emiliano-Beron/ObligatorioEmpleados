Imports System.Data.Odbc
Public Class Consulta_Devolver
    Inherits ConexionODBC
    Public Sub New()
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
            MsgBox("Error : " & ex.Message)
        End Try
        Return dt
    End Function
    Public Function GetPersonasActivas(tipo As String) As DataTable
        Dim dt As New DataTable
        Dim consulta As String
        Try
            Select Case tipo
                Case "Todo"
                    consulta = "SELECT * FROM empleado"
                Case "Operario"
                    consulta = "SELECT * FROM empleado WHERE tipo='Operario'"

                Case "Gerente"
                    consulta = "SELECT * FROM empleado tipo='Gerente'"

                Case "Administrativo"
                    consulta = "SELECT * FROM empleado tipo='Administrativo'"
            End Select
            dt = EjecutarConulta(consulta)
            Return dt
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Function
    Public Function nombre(dato As String, ci As Integer) As DataTable
        Dim nom As String
        nom = "SELECT" & dato & " FROM empleado WHERE ci=" & ci
        Return EjecutarConulta(nom)
    End Function
    Public Function HacerConsulta(consulta As String, dato As String) As String
        Dim comandoSQL As OdbcCommand
        Dim resultadoSQL As OdbcDataReader
        Try
            comandoSQL = New OdbcCommand(consulta, _conexion)
            AbrirConexion()
            comandoSQL.ExecuteNonQuery()
            resultadoSQL = comandoSQL.ExecuteReader()
            While (resultadoSQL.Read)
                Dim res As String = resultadoSQL(dato)
                CerrarConexion()
                Return res
            End While
        Catch ex As OdbcException
            MsgBox("Error : " & ex.Message)
        End Try
    End Function
End Class
