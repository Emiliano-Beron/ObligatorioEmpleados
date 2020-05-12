Imports biblioteca
Public Class VerEmpleados
    Private Sub ImporteSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inicializarTabla()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cons As New LlamarConsultas
        Dim tipo As String = cbVer.Text
        dgvEmpleados.DataSource = cons.CargarTodo(tipo)
        txtImporteSueldos.Text = cons.PagoTotal
    End Sub

    Private Sub ChbBuscarEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBuscarEmpleado.CheckedChanged
        txtCedula.ReadOnly = False
    End Sub

End Class