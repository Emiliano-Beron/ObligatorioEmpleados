Imports System.Data.Odbc
Public Class Consulta_Ingresar
    Inherits ConexionODBC

    Public Sub New()
    End Sub
    Public Function Ingresar(ci As Integer, priNom As String, priApe As String, sueldo As Double, tipo As String, dir As String) As Boolean

        Dim _consulta As String
        Dim command As OdbcCommand
        Dim resultadoSQL As OdbcDataReader
        Dim _resultado As Boolean = False

        Try
            'Consulta para verificar si un empleado existe
            'si existe retorna true, sino false
            command = New OdbcCommand("SELECT * 
                                        FROM empleado 
                                        WHERE EXISTS (SELECT ci FROM empleado WHERE ci=" & ci & ")", _conexion)
            AbrirConexion()
            command.ExecuteNonQuery()
            resultadoSQL = command.ExecuteReader

            If resultadoSQL.Read Then
                MsgBox("Ya existe un empleado con esa cedula")
                CerrarConexion()
                Return _resultado
            Else
                Try
                    CerrarConexion()
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

                    AbrirConexion()
                    command.ExecuteNonQuery()
                    CerrarConexion()
                    _resultado = True
                Catch ex As Exception
                    MsgBox("Error : " & ex.Message)
                End Try
                Return _resultado
            End If
        Catch ex As Exception
            Return _resultado
            MsgBox("ERROR:" & ex.Message)
        End Try
    End Function
End Class
