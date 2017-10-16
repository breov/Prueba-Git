Option Strict On
Module Module1

    Sub Main()
        Dim x, y, auxiliar As Integer
        x = 7
        y = 16
        auxiliar = x
        x = y
        y = auxiliar

        Console.WriteLine("El numero x es " & x)
        Console.ReadLine()
        Console.WriteLine("El numero y es " & y)
        Console.ReadLine()

    End Sub

End Module
