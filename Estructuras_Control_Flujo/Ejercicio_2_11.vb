Module Ejercicio_2_11
    '2.11. Utilizando la estructura de repetición más adecuada elaborar un programa que se ingresen
    'valores enteros hasta que se ingrese cero (descartar negativos). Luego informar cuantos son
    'pares y cuantos impares. Si todos son pares o todos son impares informar esta situación
    'particular en lugar de la consigna anterior.
    Sub main()
        Dim valores As Integer
        Dim pares As Integer
        Dim impares As Integer
        Do
            Console.WriteLine("Ingrese un valor")
            valores = Console.ReadLine
            If valores > 0 Then
                If valores Mod 2 = 0 Then
                    pares += 1
                Else
                    impares += 1
                End If
            End If
        Loop Until valores = 0
        If pares = 0 And impares > 0 Then
            Console.WriteLine("Los valores son todos impares")
        ElseIf impares = 0 And pares > 0 Then
            Console.WriteLine("Los valores son todos pares")
        ElseIf pares > 0 And impares > 0 Then
            Console.WriteLine("Los pares son : {0} y los impares son : {1}", pares, impares)
        End If
        Console.ReadKey()
    End Sub
End Module
