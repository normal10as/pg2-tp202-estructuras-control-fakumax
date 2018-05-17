Module Ejercicio_2_12
    '2.12. Utilizando la estructura de repetición más adecuada elaborar Los números de Fibonacci
    'constituyen una secuencia que empieza con 0 y 1; el número que sigue a éstos se calcula
    'sumando los dos anteriores y así sucesivamente. Utilizando la estructura de repetición más
    'adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia.
    Sub main()
        Dim x As Integer = 0
        Dim y As Integer = 1
        Dim resultado As Integer
        For r = 1 To 20
            resultado = x + y
            x = y
            y = resultado
            Console.Write(resultado & " ")
        Next
        Console.ReadKey()
    End Sub
End Module
