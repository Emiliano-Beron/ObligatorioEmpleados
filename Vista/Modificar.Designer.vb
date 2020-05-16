<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPape = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPnom
        '
        Me.txtPnom.Location = New System.Drawing.Point(12, 329)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(167, 20)
        Me.txtPnom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(9, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtPape
        '
        Me.txtPape.Location = New System.Drawing.Point(185, 329)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.Size = New System.Drawing.Size(167, 20)
        Me.txtPape.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(182, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(358, 329)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(167, 20)
        Me.txtDir.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(355, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(12, 395)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(167, 20)
        Me.txtSalario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(9, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Salario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(182, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(358, 386)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 37)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Operario", "Administrativo", "Gerente"})
        Me.cbTipo.Location = New System.Drawing.Point(185, 394)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(167, 21)
        Me.cbTipo.TabIndex = 14
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 21)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(510, 204)
        Me.dgvEmpleados.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(216, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula del empleado"
        '
        'txtCi
        '
        Me.txtCi.Enabled = False
        Me.txtCi.Location = New System.Drawing.Point(185, 250)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(167, 20)
        Me.txtCi.TabIndex = 1
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 441)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modificar"
        Me.Text = "Modificar"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPnom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPape As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCi As TextBox
End Class
