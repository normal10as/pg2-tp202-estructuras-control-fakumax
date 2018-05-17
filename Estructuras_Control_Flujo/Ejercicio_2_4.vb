Module Ejercicio_2_4
    '2.4. IF: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).
    Sub main()
        Dim Cantidad As Integer
        Dim pUnitario As Single
        Dim porcentaje As Byte
        Dim descuento As Single
        Dim resultado As Single
        Console.WriteLine("Ingrese la cantidad")
        Cantidad = Console.ReadLine
        Console.WriteLine("Ingrese el precio unitario")
        pUnitario = Console.ReadLine
        If Cantidad >= 10 And Cantidad <= 50 Then
            porcentaje = 5
            descuento = (Cantidad * pUnitario) * 0.05
            resultado = (Cantidad * pUnitario) - descuento
        End If
        If Cantidad >= 51 And Cantidad <= 250 Then
            porcentaje = 10
            descuento = (Cantidad * pUnitario) * 0.1
            resultado = (Cantidad * pUnitario) - descuento
        End If
        If Cantidad >= 251 Then
            porcentaje = 20
            descuento = (Cantidad * pUnitario) * 0.2
            resultado = (Cantidad * pUnitario) - descuento
        End If
        Console.WriteLine("Informe de Subtotal  : " & Cantidad * pUnitario)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Porcentaje de Descuento : " & "% " & porcentaje)
        Console.WriteLine("Monto Descontado : " & descuento)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Total : " & resultado)
        Console.ReadKey()

    End Sub
End Module
