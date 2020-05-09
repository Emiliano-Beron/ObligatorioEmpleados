Imports biblioteca
Module Principal
    Private dtEmpleados As New DataTable
    Private fila As DataRow
    Public Sub inicializarTabla()
        ' Agrego una columna al Datatable
        ' donde voy a guardar el Objeto que 
        ' traigo por parámetro
        dtEmpleados.Columns.Add("Cedula")
        dtEmpleados.Columns.Add("PrimerNombre")
        dtEmpleados.Columns.Add("PrimerApellido")
        dtEmpleados.Columns.Add("direccion")
        dtEmpleados.Columns.Add("Tipo")
        dtEmpleados.Columns.Add("Sueldo")
    End Sub
End Module
