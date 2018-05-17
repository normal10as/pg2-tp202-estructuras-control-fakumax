Module Ejercicio_2_13
    '2.13. Obtener los números primos menores a mil. En matemáticas, un número primo es un
    'número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.
    Sub main()
        Dim primos As Integer
        For x = 2 To 1000
            For n = 1 To x
                If x Mod n = 0 Then
                    primos += 1
                End If
            Next
            If primos = 2 Then
                Console.WriteLine("Los numeros primos son {0}", x)
            End If
            primos = 0


        Next
        Console.ReadKey()
    End Sub

End Module
