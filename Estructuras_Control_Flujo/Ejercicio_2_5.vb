Module Ejercicio_2_5
    '2.5. CASE. Crear un programa con una enumeración para los meses del año. Ingresar un valor
    'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
    'correspondiente.
    Sub main()
        Dim mes As Integer
        Console.WriteLine("Ingrese un mes")
        mes = Console.ReadLine
        Select Case mes
            Case 1
                Console.WriteLine("El mes es enero")
            Case 2
                Console.WriteLine("El mes es Febrero")
            Case 3
                Console.WriteLine("El mes es Marzo")
            Case 4
                Console.WriteLine("El mes es Abril")
            Case 5
                Console.WriteLine("El mes es Mayo")
            Case 6
                Console.WriteLine("El mes es Junio")
            Case 7
                Console.WriteLine("El mes es Julio")
            Case 8
                Console.WriteLine("El mes es Agosto")
            Case 9
                Console.WriteLine("El mes es Septiembre")
            Case 10
                Console.WriteLine("El mes es Octubre")
            Case 11
                Console.WriteLine("El mes es Noviembre")
            Case 12
                Console.WriteLine("El mes es Diciembre")
            Case Else
                Console.WriteLine("Valor ingresado incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module
