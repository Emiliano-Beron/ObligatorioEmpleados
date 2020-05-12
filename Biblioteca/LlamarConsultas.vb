﻿Imports BaseDatos
Public Class LlamarConsultas
    Private con As New Consulta_Devolver

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
    Public Function CargarTodo(tipo As String)
        Return con.GetPersonasActivas(tipo)
    End Function

    Public Function modif(ci As String, pnom As String, pape As String, dir As String, salario As Integer, tipo As String)
        Dim cons As New Consulta_Modificar()
        If cons.Modificar(ci, pnom, pape, dir, salario, tipo) Then
            MsgBox("Se modifico")
        Else
            MsgBox("no se modifico")
        End If
    End Function
    Public Function Indi(row As String, ci As Integer, dato As String) As String
        Return con.HacerConsulta("SELECT " & row & " FROM empleado WHERE ci=" & ci.ToString, dato)
    End Function
End Class
