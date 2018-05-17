Module Ejercicio_2_3
    '2.3. IF: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”
    Sub main()
        Dim valor(4) As Integer
        Dim mayor As Integer
        Dim indice As Integer
        For i As Integer = 0 To valor.Length - 1
            Console.WriteLine("Ingrese un valor : ")
            valor(i) = Console.ReadLine
            If i = 0 Then
                mayor = valor(i)
            ElseIf mayor < valor(i) Then
                mayor = valor(i)
                indice = i
            End If
        Next
        Select Case indice
            Case 0
                Console.WriteLine("El primer número es el de mayor valor, valor : " & mayor)
            Case 1
                Console.WriteLine("El segundo número es el de mayor valor, valor : " & mayor)
            Case 2
                Console.WriteLine("El tercer número es el de mayor valor, valor : " & mayor)
            Case 3
                Console.WriteLine("El cuarto número es el de mayor valor, valor : " & mayor)
            Case 4
                Console.WriteLine("El quinto número es el de mayor valor, valor : " & mayor)
        End Select
        Console.ReadKey()

    End Sub

End Module
