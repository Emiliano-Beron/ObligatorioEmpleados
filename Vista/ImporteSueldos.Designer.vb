﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImporteSueldos
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
        Me.lboxListado = New System.Windows.Forms.ListBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ChbBuscarEmpleado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImporteSueldos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lboxListado
        '
        Me.lboxListado.BackColor = System.Drawing.SystemColors.Window
        Me.lboxListado.Enabled = False
        Me.lboxListado.FormattingEnabled = True
        Me.lboxListado.HorizontalScrollbar = True
        Me.lboxListado.Items.AddRange(New Object() {"Cedula ; Nombre ; Direccion ; Telefono ; Sueldo"})
        Me.lboxListado.Location = New System.Drawing.Point(3, 230)
        Me.lboxListado.Name = "lboxListado"
        Me.lboxListado.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lboxListado.Size = New System.Drawing.Size(526, 199)
        Me.lboxListado.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMostrar.FlatAppearance.BorderSize = 2
        Me.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.ForeColor = System.Drawing.Color.Silver
        Me.btnMostrar.Location = New System.Drawing.Point(12, 168)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(100, 40)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Buscar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ChbBuscarEmpleado
        '
        Me.ChbBuscarEmpleado.AutoSize = True
        Me.ChbBuscarEmpleado.ForeColor = System.Drawing.Color.Silver
        Me.ChbBuscarEmpleado.Location = New System.Drawing.Point(156, 87)
        Me.ChbBuscarEmpleado.Name = "ChbBuscarEmpleado"
        Me.ChbBuscarEmpleado.Size = New System.Drawing.Size(136, 17)
        Me.ChbBuscarEmpleado.TabIndex = 2
        Me.ChbBuscarEmpleado.Text = "buscar unico empleado"
        Me.ChbBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cedula"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(13, 85)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(137, 20)
        Me.txtCedula.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(381, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Importe de sueldos"
        '
        'txtImporteSueldos
        '
        Me.txtImporteSueldos.Location = New System.Drawing.Point(384, 204)
        Me.txtImporteSueldos.Name = "txtImporteSueldos"
        Me.txtImporteSueldos.ReadOnly = True
        Me.txtImporteSueldos.Size = New System.Drawing.Size(138, 20)
        Me.txtImporteSueldos.TabIndex = 7
        '
        'ImporteSueldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 441)
        Me.Controls.Add(Me.txtImporteSueldos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChbBuscarEmpleado)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lboxListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImporteSueldos"
        Me.Text = "ImporteSueldos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboxListado As ListBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents ChbBuscarEmpleado As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImporteSueldos As TextBox
End Class
