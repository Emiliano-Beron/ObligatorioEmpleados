Imports biblioteca
Public Class Modificar
    Dim cons As New LlamarConsultas
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        cons.modif(Integer.Parse(txtCi.Text),
                   txtPnom.Text, txtPape.Text,
                   txtDir.Text,
                   Integer.Parse(txtSalario.Text),
                   cbTipo.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtPnom.Text = cons.Indi("priNom", Integer.Parse(txtCi.Text), "priNom")
        txtPape.Text = cons.Indi("priApe", Integer.Parse(txtCi.Text), "priApe")
        txtDir.Text = cons.Indi("Direccion", Integer.Parse(txtCi.Text), "Direccion")
        txtSalario.Text = cons.Indi("Salario", Integer.Parse(txtCi.Text), "salario")
        cbTipo.Text = cons.Indi("Tipo", Integer.Parse(txtCi.Text), "tipo")

    End Sub
End Class