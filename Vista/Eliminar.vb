Imports biblioteca
Public Class Eliminar
    Dim cons As New LlamarConsultas
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        dgvEmpleado.DataSource = cons.UnEmpleado(Integer.Parse(txtCi.Text))
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        cons.Eliminar(Integer.Parse(txtCi.Text))
    End Sub
End Class