Module Ejercicio_2_14

    '2.14. Se ingresan repetitivamente dos valores relativos a un producto en venta: cantidad y
    'precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es
    'entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. Informar por
    'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
    'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
    'cero, informar el total de pesos descontados y el total a cobrar.
    Sub main()
        Dim Cantidad As Integer
        Dim pUnitario As Single
        Dim porcentaje As Byte
        Dim descuento As Single
        Dim subtotal As Single
        Dim resultado As Single
        Dim TotalDescuento As Single
        Dim TotalCobrar As Single
        Do While True
            Console.WriteLine()
            Console.Write("Ingrese la cantidad : ")
            Cantidad = Console.ReadLine
            If Cantidad = 0 Then
                Exit Do
            Else
                Console.Write("Ingrese el precio unitario : ")
                pUnitario = Console.ReadLine
                subtotal = pUnitario * Cantidad
                If Cantidad >= 10 And Cantidad <= 50 Then
                    porcentaje = 5
                ElseIf Cantidad >= 51 And Cantidad <= 250 Then
                    porcentaje = 10
                ElseIf Cantidad >= 251 Then
                    porcentaje = 20
                End If
            End If
            descuento = (Cantidad * pUnitario) * porcentaje / 100
            resultado = (Cantidad * pUnitario) - descuento
            TotalDescuento += descuento
            TotalCobrar += resultado
            Console.WriteLine("Informe de Subtotal  : " & Cantidad * pUnitario)
            Console.WriteLine("-----------------------")
            Console.WriteLine("Porcentaje de Descuento : " & "% " & porcentaje)
            Console.WriteLine("Monto Descontado : " & descuento)
            Console.WriteLine("-----------------------")
            Console.WriteLine("Total : " & resultado)

        Loop
        Console.WriteLine("TOTAL DE PESOS DESCONTADOS : " & TotalDescuento)
        Console.WriteLine("TOTAL DE PESOS A COBRAR : " & TotalCobrar)
        Console.ReadKey()

    End Sub
End Module


