Imports biblioteca
Public Class Modificar
    Dim cons As New LlamarConsultas
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmpleados.DataSource = cons.CargarTodo("Todo")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        cons.Modif(Integer.Parse(txtCi.Text),
                   txtPnom.Text, txtPape.Text,
                   txtDir.Text,
    Integer.Parse(txtSalario.Text),
                   cbTipo.Text)
    End Sub
    Private Sub dgEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        Dim i As Integer
        i = dgvEmpleados.CurrentRow.Index

        Try
            With dgvEmpleados
                txtCi.Text = .Item(1, i).Value()
                txtPnom.Text = .Item(2, i).Value()
                txtPape.Text = .Item(3, i).Value()
                txtDir.Text = .Item(4, i).Value()
                txtSalario.Text = .Item(5, i).Value()
                cbTipo.Text = .Item(6, i).Value()
            End With


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub
End Class