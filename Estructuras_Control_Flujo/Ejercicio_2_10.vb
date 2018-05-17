Module Ejercicio_2_10
    '2.10. For y Do Loop. Crear un módulo para resolver el siguiente problema: con dos valores
    'numéricos enteros cualquiera, el primero menor al segundo, calcular cuantos números múltiplos
    'de cinco hay entre ellos e informar. Repetir esta solución en el mismo módulo con las diferentes
    'alternativas las estructuras de repetición “do while … loop”, “do until … loop”, “do … loop
    ' While ”, “do … loop until y “for”
    Sub main()
        Dim valorMenor As Integer
        Dim valorMayor As Integer
        Console.WriteLine("Ingrese un valor menor al segundo.")
        valorMenor = Console.ReadLine
        Console.WriteLine("Ingrese un valor menor al primero.")
        valorMayor = Console.ReadLine
        valorMenor = (valorMayor - valorMenor) / 5
        Console.WriteLine(valorMenor)

        Console.ReadKey()
    End Sub
End Module
