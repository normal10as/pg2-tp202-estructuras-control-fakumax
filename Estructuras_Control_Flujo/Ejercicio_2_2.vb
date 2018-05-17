Module Ejercicio_2_2
    '2.2. IF: ingresar tres valores y mostrar el menor.
    Sub main()
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer
        Console.WriteLine("Ingrese un valor :")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese otro valor :")
        valor2 = Console.ReadLine
        Console.WriteLine("Ingrese otro valor :")
        valor3 = Console.ReadLine
        If valor1 < valor2 Then
            If valor1 < valor3 Then
                Console.WriteLine("El valor mas chico es : " & valor1)
            Else
                Console.WriteLine("El valor mas chico es : " & valor3)
            End If

        ElseIf valor2 < valor3 Then

            Console.WriteLine("El valor mas chico es : " & valor2)
        Else
            Console.WriteLine("El valor mas chico es : " & valor3)
        End If


        Console.ReadKey()
    End Sub

End Module
