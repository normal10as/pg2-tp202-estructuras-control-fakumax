Module Ejercicio_2_5
    '2.5. CASE. Crear un programa con una enumeración para los meses del año. Ingresar un valor
    'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
    'correspondiente.
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum

    Sub main()
        Dim mes As Integer
        Console.WriteLine("Ingrese un mes")
        mes = Console.ReadLine
        Select Case mes
            Case meses.enero
                Console.WriteLine("El mes es enero")
            Case meses.febrero
                Console.WriteLine("El mes es Febrero")
            Case meses.marzo
                Console.WriteLine("El mes es Marzo")
            Case meses.abril
                Console.WriteLine("El mes es Abril")
            Case meses.mayo
                Console.WriteLine("El mes es Mayo")
            Case meses.junio
                Console.WriteLine("El mes es Junio")
            Case meses.julio
                Console.WriteLine("El mes es Julio")
            Case meses.agosto
                Console.WriteLine("El mes es Agosto")
            Case meses.septiembre
                Console.WriteLine("El mes es Septiembre")
            Case meses.octubre
                Console.WriteLine("El mes es Octubre")
            Case meses.noviembre
                Console.WriteLine("El mes es Noviembre")
            Case meses.diciembre
                Console.WriteLine("El mes es Diciembre")
            Case Else
                Console.WriteLine("Valor ingresado incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module
