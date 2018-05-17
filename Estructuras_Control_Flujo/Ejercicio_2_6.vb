Module Ejercicio_2_6
    '2.6. Resolver el problema 2.4 con CASE.
    Sub main()
        Dim Cantidad As Integer
        Dim pUnitario As Double
        Dim porcentaje As Byte
        Dim descuento As Double
        Dim resultado As Double
        Console.WriteLine("Ingrese la cantidad")
        Cantidad = Console.ReadLine
        Console.WriteLine("Ingrese el precio unitario")
        pUnitario = Console.ReadLine
        Select Case Cantidad
            Case 10 To 50
                porcentaje = 5
                descuento = (Cantidad * pUnitario) * 0.05
                resultado = (Cantidad * pUnitario) - descuento
            Case 51 To 250
                porcentaje = 10
                descuento = (Cantidad * pUnitario) * 0.1
                resultado = (Cantidad * pUnitario) - descuento
            Case >= 251
                porcentaje = 20
                descuento = (Cantidad * pUnitario) * 0.2
                resultado = (Cantidad * pUnitario) - descuento
        End Select
        Console.WriteLine("Informe de Subtotal  : " & Cantidad * pUnitario)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Porcentaje de Descuento : " & "% " & porcentaje)
        Console.WriteLine("Monto Descontado : " & descuento)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Total : " & resultado)
        Console.ReadKey()

    End Sub
End Module
