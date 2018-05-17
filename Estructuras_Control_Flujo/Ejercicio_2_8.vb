Module Ejercicio_2_8
    '2.8. Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    '* El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    '* En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
    'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12

    End Enum

    Sub main()
        Dim mes As Byte
        Dim anio As Integer
        Console.Write("Ingrese el mes a consultar los dias : ")
        mes = Console.ReadLine
        Select Case mes

            Case meses.enero
                Console.Write("El mes de Enero tiene 31 dias")
            Case meses.febrero
                Console.Write("Ingrese el año a consultar : ")
                anio = Console.ReadLine
                If (anio Mod 4 = 0 And Not anio Mod 100 = 0) Or anio Mod 400 = 0 Then
                    Console.Write("El mes de Febrero es bisiesto y tiene 29 dias")
                Else
                    Console.Write("El mes de Febrero no es bisiesto y tiene 28 dias")
                End If
            Case meses.marzo
                Console.Write("El mes de Marzo tiene 31 dias")
            Case meses.abril
                Console.Write("El mes de Abril tiene 30 dias")
            Case meses.mayo
                Console.Write("El mes de Mayo tiene 31 dias")
            Case meses.junio
                Console.Write("El mes de Junio tiene 30 dias")
            Case meses.julio
                Console.Write("El mes de Julio tiene 31 dias")
            Case meses.agosto
                Console.Write("El mes de Agosto tiene 31 dias")
            Case meses.septiembre
                Console.Write("El mes de Septiembre tiene 30 dias")
            Case meses.octubre
                Console.Write("El mes de Octubre tiene 31 dias")
            Case meses.noviembre
                Console.Write("El mes de Noviembre tiene 30 dias")
            Case meses.diciembre
                Console.Write("El mes de Diciembre tiene 31 dias")
            Case Else
                Console.Write("El mes que eligio es de otro planeta")
        End Select
        Console.ReadKey()
    End Sub
End Module
