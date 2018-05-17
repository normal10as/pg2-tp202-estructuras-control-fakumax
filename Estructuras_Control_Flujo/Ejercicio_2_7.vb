Module Ejercicio_2_7
    '2.7. CASE: Elaborar un algoritmo que lea el tamaño de un ángulo en grados e imprimir el mensaje
    'correspondiente según la siguiente tabla:
    'Agudo   | si es menor a 90°
    'Recto   | si es igual a 90°
    'Obtuso  | si es mayor que 90° pero menor que 180°
    'Llano   | si es igual a 180°
    'Cóncavo | si es mayor que 180° pero menor que 360°
    'Error   | Si el valor es menor a 0º o mayor de 360º
    Sub main()
        Dim angulo As Integer
        Console.WriteLine("Ingrese un angulo")
        angulo = Console.ReadLine()
        Select Case angulo
            Case = 90
                Console.WriteLine("Es un angulo recto")
            Case 1 To 89
                Console.WriteLine("Es un angulo Agudo")
            Case 91 To 179
                Console.WriteLine("Es un angulo Obtuso")
            Case = 180
                Console.WriteLine("Es un angulo Llano")
            Case 181 To 359
                Console.WriteLine("Es un angulo Cóncavo")
            Case = 360
                Console.WriteLine("Es un angulo Completo")
            Case Else
                Console.WriteLine("Error de angulo")
        End Select
        Console.ReadKey()
    End Sub
End Module
