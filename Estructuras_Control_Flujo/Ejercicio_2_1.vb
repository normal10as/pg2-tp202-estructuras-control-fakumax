Module Ejercicio_2_1
    '2.1. IF: Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
    'la relación entre ambos: mayor, menor o igual.
    Sub Main()
        Dim valor1 As Integer
        Dim valor2 As Integer
        Console.WriteLine("Ingrese un valor : ")
        valor1 = Console.ReadLine
        Console.WriteLine("Ingrese otro valor : ")
        valor2 = Console.ReadLine
        If valor1 > valor2 Then
            Console.WriteLine("El valor mas grande es :" & valor1)
        ElseIf valor1 < valor2 Then
            Console.WriteLine("El valor mas grande es :" & valor2)
        End If
        If valor1 = valor2 Then
            Console.WriteLine("Los valores son iguales ")
        End If
        Console.ReadKey()

    End Sub

End Module
