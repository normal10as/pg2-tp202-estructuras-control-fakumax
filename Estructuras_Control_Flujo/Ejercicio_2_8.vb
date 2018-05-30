Module Ejercicio_2_8
    '2.8. Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    '* El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    '* En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
    'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12

    End Enum

    Sub main()
        Dim mes As meses
        Dim anio As UShort
        Console.Write("Ingrese el mes a consultar los dias : ")
        mes = Console.ReadLine
        Select Case mes
            Case meses.Enero, meses.Marzo, meses.Mayo, meses.Julio, meses.Agosto, meses.Octubre, meses.Diciembre
                Console.Write("El mes de " & mes.ToString & " tiene 31 dias")

            Case meses.Abril, meses.Junio, meses.Septiembre, meses.Noviembre
                Console.Write("El mes de " & mes.ToString & " tiene 30 dias")

            Case meses.Febrero
                Console.Write("Ingrese el año a consultar : ")
                anio = Console.ReadLine
                If (anio Mod 4 = 0 And Not anio Mod 100 = 0) Or anio Mod 400 = 0 Then
                    Console.Write("El mes de Febrero es bisiesto y tiene 29 dias")
                Else
                    Console.Write("El mes de Febrero no es bisiesto y tiene 28 dias")
                End If

            Case Else
                Console.Write("El mes que eligio es de otro planeta")
        End Select
        Console.ReadKey()
    End Sub
End Module
