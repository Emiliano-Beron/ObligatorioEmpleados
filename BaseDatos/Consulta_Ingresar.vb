Imports System.Data.Odbc
Public Class Consulta_Ingresar
    Private con As OdbcConnection
    Public Sub New()
        con = New OdbcConnection("dsn=EmpleadosObligatorio;uid=eberon;pwd=silomontolomeo;")
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
        _consulta = "INSERT INTO empleado(ci,priNom,priApe,salario,idTipo,direccion)"
        _consulta &= " VALUES ( "
        _consulta &= ci.ToString & ","
        _consulta &= "'" & priNom & "',"
        _consulta &= "'" & priApe & "',"
        _consulta &= "'" & sueldo & "',"
        _consulta &= "'" & tipo & "',"
        _consulta &= "'" & dir & "')"

        command = New OdbcCommand(_consulta, con)

        Try
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            _resultado = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        Return _resultado
    End Function
End Class
