Module Ejercicio_2_9
    '2.9. Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros,
    'centímetros, yardas, pies y pulgadas
    '* Presentar un menú y preguntar que unidad de medida desea convertir, el valor a convertir y
    'después mostrar las equivalencias.
    '* Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
    'pulgada = 2.54 cm, 1 metro = 100 cm.
    '* Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
    'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.
    Sub main()
        Dim opcion As Byte
        Dim valor As Double
        Console.WriteLine("     Ingrese una medida que desea convertir  ")
        Console.Write("1 = Pie, 2 = Yarda, 3 = Pulgada, 4 = Centímetro, 5 = Metros : ")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                Console.Write("Ingrese los 'Pies' a convertir : ")
                valor = Console.ReadLine
                Console.WriteLine("La conversion resultante es : ")
                Console.WriteLine(" {0} Pulgadas", valor * 12)
                Console.WriteLine(" {0} Yardas", valor / 3)
                Console.WriteLine(" {0} Centímetros", valor * (12 * 2.54))
                Console.WriteLine(" {0} Metros", (valor * (12 * 2.54) / 100))

            Case 2

                Console.Write("Ingrese las 'Yardas' a convertir : ")
                valor = Console.ReadLine
                Console.WriteLine("La conversion resultante es : ")
                Console.WriteLine(" {0} Pulgadas", valor * 36)
                Console.WriteLine(" {0} Centímetros", (valor * 36) * 2.54)
                Console.WriteLine(" {0} Pies", valor * 3)
                Console.WriteLine(" {0} Metros", ((valor * 36) * 2.54) / 100)

            Case 3
                Console.Write("Ingrese los 'Pulgadas' a convertir : ")
                valor = Console.ReadLine
                Console.WriteLine("La conversion resultante es : ")
                Console.WriteLine(" {0} Yardas", valor / 36)
                Console.WriteLine(" {0} Centímetros", valor * 2.54)
                Console.WriteLine(" {0} Pies", valor / 12)
                Console.WriteLine(" {0} Metros", (valor * 2.54) / 100)

            Case 4
                Console.Write("Ingrese los 'Centímetros' a convertir : ")
                valor = Console.ReadLine
                Console.WriteLine("La conversion resultante es : ")
                Console.WriteLine(" {0} Pulgadas", valor / 2.54)
                Console.WriteLine(" {0} Yardas", (valor / 36) / 2.54)
                Console.WriteLine(" {0} Pies", (valor / 12) / 2.54)
                Console.WriteLine(" {0} Metros", valor / 100)

            Case 5
                Console.Write("Ingrese los 'Metros' a convertir : ")
                valor = Console.ReadLine
                Console.WriteLine("La conversion resultante es : ")
                Console.WriteLine(" {0} Pulgadas", (valor * 100) / 2.54)
                Console.WriteLine(" {0} Yardas", ((valor / 36) / 2.54) * 100)
                Console.WriteLine(" {0} Centímetros", valor * 100)
                Console.WriteLine(" {0} Pies", ((valor * 100) / 12) / 2.54)

            Case Else
                Console.Write("Opción incorrecta")
        End Select
        Console.ReadKey()
    End Sub



End Module
