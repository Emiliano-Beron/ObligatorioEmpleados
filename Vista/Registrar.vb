Imports biblioteca
Public Class Registrar

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            Dim cedula As Integer = Integer.Parse(txtCedula.Text)
            Dim nombre As String = txtPriNom.Text
            Dim ape As String = txtPriApe.Text
            Dim direccion As String = txtDireccion.Text
            'Dim telefono As Integer = Integer.Parse(txtTelefono.Text)
            Dim especializacion As String = ComoboBoxEspecialidad.Text
            Dim salario As Integer = Double.Parse(txtSueldo.Text)

            Dim cons As New LlamarConsultas

            If cedula <> 0 And nombre <> "" And ape <> "" And direccion <> "" And salario <> 0 Then 'And telefono <> 0
                Select Case especializacion
                    Case "Operario"
                        Dim oper As Operario = New Operario(cedula, nombre, ape, 0, direccion, salario, "Operario")
                        salario = oper.plus(salario)
                        'Inicio.empleados.Insert(oper

                        cons.Ingresar(cedula, nombre, ape, salario, especializacion, direccion) 'Llamo consulta para ingresar empleado, 1 = tipo Operario
                    Case "Gerente"
                        Dim ger As Gerente = New Gerente(cedula, nombre, ape, 0, direccion, salario, "Gerente")
                        salario = ger.plus(salario)
                        'Inicio.empleados.Insert(ger)

                        cons.Ingresar(cedula, nombre, ape, salario, especializacion, direccion) 'Llamo consulta para ingresar empleado, 2 = tipo Gerente
                    Case "Administrativo"
                        Dim adm As Administrativo = New Administrativo(cedula, nombre, ape, 0, direccion, salario, "Administrativo")
                        salario = adm.plus(salario)
                        'Inicio.empleados.Insert(adm)

                        cons.Ingresar(cedula, nombre, ape, salario, especializacion, direccion) 'Llamo consulta para ingresar empleado, 3 = tipo Administrativo
                    Case Else
                        MsgBox("seleccione una especializacion")
                End Select
            Else
                MsgBox("Debe rellenar los campos de nombre o direccion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCedula.Text = ""
        txtDireccion.Text = ""
        txtPriApe.Text = ""
        txtPriNom.Text = ""
        txtSueldo.Text = ""
        txtTelefono.Text = ""
    End Sub
End Class