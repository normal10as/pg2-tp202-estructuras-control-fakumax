Module Ejercicio_2_10
    '2.10. For y Do Loop. Crear un módulo para resolver el siguiente problema: con dos valores
    'numéricos enteros cualquiera, el primero menor al segundo, calcular cuantos números múltiplos
    'de cinco hay entre ellos e informar. Repetir esta solución en el mismo módulo con las diferentes
    'alternativas las estructuras de repetición “do while … loop”, “do until … loop”, “do … loop
    ' While ”, “do … loop until y “for”
    Sub main()
        Dim valorMenor As Integer
        Dim valorMayor As Integer
        Dim acumulador As Integer

        Console.WriteLine("Ingrese un valor menor al segundo.")
        valorMenor = Console.ReadLine
        Console.WriteLine("Ingrese un valor menor al primero.")
        valorMayor = Console.ReadLine

        ' While End While
        While valorMenor <= valorMayor
            If valorMenor Mod 5 = 0 Then
                acumulador += 1

            End If
            valorMenor += 1
        End While

        'Do While Loop
        Do While valorMenor <= valorMayor
            If valorMenor Mod 5 = 0 Then
                acumulador += 1

            End If
            valorMenor += 1
        Loop

        'Do Until Loop
        Do Until valorMayor < valorMenor
            If valorMenor Mod 5 = 0 Then
                acumulador += 1

            End If
            valorMenor += 1
        Loop

        'Don Loop Until
        Do
            If valorMenor Mod 5 = 0 Then
                acumulador += 1

            End If
            valorMenor += 1
        Loop Until valorMayor < valorMenor

        'Don Loop While
        Do
            If valorMenor Mod 5 = 0 Then
                acumulador += 1

            End If
            valorMenor += 1
        Loop While valorMenor <= valorMayor

        'For
        For x = valorMenor To valorMayor
            If x Mod 5 = 0 Then
                acumulador += 1
            End If
        Next

        Console.WriteLine(acumulador)

        Console.ReadKey()
    End Sub
End Module
