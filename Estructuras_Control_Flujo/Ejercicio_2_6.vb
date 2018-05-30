Module Ejercicio_2_6
    '2.6. Resolver el problema 2.4 con CASE.
    Sub main()
        Dim Cantidad As Integer
        Dim pUnitario As Single
        Dim porcentaje As Byte
        Dim subtotal As Single
        Dim descuento As Single
        Console.WriteLine("Ingrese la cantidad")
        Cantidad = Console.ReadLine
        Console.WriteLine("Ingrese el precio unitario")
        pUnitario = Console.ReadLine
        subtotal = Cantidad * pUnitario
        Select Case Cantidad
            Case 10 To 50
                porcentaje = 5
            Case 51 To 250
                porcentaje = 10
            Case >= 251
                porcentaje = 20
            Case Else
                porcentaje = 0
        End Select
        descuento = subtotal * porcentaje / 100
        Console.WriteLine("Informe de Subtotal  : " & subtotal)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Porcentaje de Descuento : " & "% " & porcentaje)
        Console.WriteLine("Monto Descontado : " & descuento)
        Console.WriteLine("-----------------------")
        Console.WriteLine("Total : " & subtotal - descuento)
        Console.ReadKey()

    End Sub
End Module
