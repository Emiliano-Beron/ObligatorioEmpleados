Imports biblioteca
Public Class Registrar

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            Dim cedula As Integer = Integer.Parse(txtCedula.Text)
            Dim nombre As String = txtNombre.Text
            Dim direccion As String = txtDireccion.Text
            Dim telefono As Integer = Integer.Parse(txtTelefono.Text)
            Dim especializacion As String = ComoboBoxEspecialidad.Text
            Dim salario As Double = Double.Parse(txtSueldo.Text)

            If cedula <> 0 And nombre <> "" And telefono <> 0 And direccion <> "" And salario <> 0.0 Then
                Select Case especializacion
                    Case "Operario"
                        Dim oper As Operario = New Operario(cedula, nombre, telefono, direccion, salario, "Operario")
                        Inicio.empleados.SetTotal(oper.plus(salario))
                        Inicio.empleados.Insert(oper)
                    Case "Gerente"
                        Dim ger As Gerente = New Gerente(cedula, nombre, telefono, direccion, salario, "Gerente")
                        Inicio.empleados.SetTotal(ger.plus(salario))
                        Inicio.empleados.Insert(ger)
                    Case "Administrativo"
                        Dim adm As Administrativo = New Administrativo(cedula, nombre, telefono, direccion, salario, "Administrativo")
                        Inicio.empleados.SetTotal(adm.plus(salario))
                        Inicio.empleados.Insert(adm)
                    Case Else
                        MsgBox("seleccione una especializacion")
                End Select
            Else
                MsgBox("Debe rellenar los campos de nombre o direccion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("se ingreso con exito")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub
End Class