Public Class Empleados
    Property list As List(Of Empleado)
    Property total As Double
    Property contacto As String
    Property phone As String
    Property contactos As List(Of String)
    Property motivoDespido As ArrayList
    ''Constructor
    Public Sub New()
        list = New List(Of Empleado)
        contactos = New List(Of String)
        motivoDespido = New ArrayList()
    End Sub

    'sub metodos y funciones
    Public Sub SetTotal(salario As Double)
        total += salario
    End Sub
    Public Function GetTotal() As Double
        Return total
    End Function
    Public Function Size() As Integer
        Return list.Count
    End Function

    Public Sub Insert(empleado As Empleado)
        list.Add(empleado)
    End Sub
    Public Sub GiveBackAll() 'funciona
        For Each i In list
            Console.WriteLine("{0}", i)
        Next i
    End Sub
    Public Function FindByCi(ci As Integer) As Integer
        Dim encontrado As Boolean = False
        Dim index As Integer = 0

        While (encontrado = False And index < list.Count)
            If list(index).Ci1.CompareTo(ci) = 0 Then
                encontrado = True
            Else
                index += 1
            End If
        End While

        If (encontrado) Then
            Console.WriteLine(list(index))
            'Console.WriteLine(contactos(index))
            Console.WriteLine("=======================")
        Else
            Console.WriteLine("No existe el empleado con cedula: " & ci)
            Console.WriteLine("=======================")
        End If

        Return index
    End Function
    Public Function CambiarDato(ci As Integer) As Boolean

        Dim encontrado As Boolean = False
        Dim index As Integer = 0

        While (encontrado = False And index < list.Count)
            If list(index).Ci1.CompareTo(ci) = 0 Then
                encontrado = True
            Else
                index += 1
            End If
        End While

        If (encontrado) Then
            Console.WriteLine("Que desea modificar?")
            Console.WriteLine("1.Nombre")
            Console.WriteLine("2.Telefono")
            Console.WriteLine("3.direccion")
            'Console.WriteLine("4.Agregar Contactos")
            Console.WriteLine("0.Salir")
            Console.Write("Opcion: ")
            Dim op As Integer = Console.ReadLine()

            Select Case op
                Case 1
                    Console.Clear()
                    Console.Write("Ingrese el nuevo Nombre: ")
                    list(index).Name1 = Console.ReadLine()
                    Console.WriteLine("=======================")
                Case 2
                    Console.Clear()
                    Console.Write("Ingrese el nuevo telefono: ")
                    list(index).Phone1 = Console.ReadLine()
                    Console.WriteLine("=======================")
                Case 3
                    Console.Clear()
                    Console.Write("Ingrese el nueva direccion: ")
                    list(index).Adress1 = Console.ReadLine()
                    Console.WriteLine("=======================")
                'case 4
                Case 0
                Case Else
                    Console.Write("Ingrese una opcio correcta (1,2,3,0)")
                    Console.WriteLine("=======================")

            End Select

        Else
            Console.WriteLine("No existe el empleado con cedula: " & ci)
            Console.WriteLine("=======================")
        End If
        Return encontrado
    End Function
    Public Function VerContactos(ci As Integer) As Integer
        Dim encontrado As Boolean = False
        Dim index As Integer = 0
        While (encontrado = False And index < list.Count)
            If list(index).Ci1.CompareTo(ci) = 0 Then
                encontrado = True
            Else
                index += 1
            End If
        End While

        If (encontrado) Then
            Console.WriteLine("contactos: " & contactos(index))
            Console.WriteLine("=======================")
        Else
            Console.WriteLine("No existe nada relacionado a ci: " & ci)
            Console.WriteLine("=======================")
        End If

        Return index
    End Function
    Public Function RemoveByCi(ci As Integer) As Boolean
        Dim encontrado As Boolean = False
        Dim index As Integer = 0

        While (encontrado = False And index < list.Count)

            If list(index).Ci1.CompareTo(ci) = 0 Then
                encontrado = True
            Else
                index += 1
            End If

        End While

        If (encontrado) Then
            Console.WriteLine("Ingrese la palabra, 'confirmar' sin comillas o 'cancelar' para:")
            If Console.ReadLine() = "confirmar" Then
                Console.WriteLine("Ingrese el motivo del despido: ")
                motivoDespido.Add(Console.ReadLine())
                list.RemoveAt(index)
                contactos.Remove(index)
                Console.WriteLine("Se eliminaron los registros con exito")
                Console.WriteLine("=======================")
            ElseIf Console.ReadLine = "cancelar" Then
                Console.WriteLine("se a cancelado la accion")
            End If
        Else
            Console.WriteLine("No existe el empleado con cedula: " & ci)
        End If
        Return encontrado
    End Function

    Public Sub InsertarPhone(cedu As Integer, tel As ArrayList, cant As Integer)

        For cont As Integer = 0 To cant
            phone &= "; " & tel(cont)
        Next
        'Console.WriteLine("phone: " & phone)
        contacto = "ci:" & cedu
        contacto &= phone
        'Console.WriteLine("list: " & list)

        contactos.Add(contacto)
        'Console.WriteLine("contactos: " & contactos(0))
        contacto = ""
        phone = ""
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format(list.ToString())
    End Function

End Class