Public Class ImporteSueldos
    Private Sub ImporteSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        lboxListado.Items.Clear()
        txtImporteSueldos.Text = ""

        If ChbBuscarEmpleado.Checked = False Then
            For Each empl In Inicio.empleados.list()
                lboxListado.Items.Add(empl)
            Next
        ElseIf txtcedula.Text = "" Then
            Try
                Dim cedula As Integer = Integer.Parse(txtCedula.Text)
                lboxListado.Items.Add(Inicio.empleados.list(Inicio.empleados.FindByCi(cedula)))
            Catch ex As Exception
                MsgBox("Usted marco la casilla para buscar un unico empleado, es necesario que introdusca una cedula")
            End Try

        End If



    End Sub

    Private Sub ChbBuscarEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBuscarEmpleado.CheckedChanged
        txtCedula.ReadOnly = False
    End Sub
End Class