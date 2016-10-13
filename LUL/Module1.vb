Module Module1

    Sub Main()
        Dim answer As String
        Console.WriteLine("Dali želite pozdrav?")
        Console.WriteLine("Pritisnite Y za DA, N za ne")
        'Test()
        answer = Console.ReadLine()
        If answer = "Y" Then
            Console.WriteLine("Hello")
        Else
            Console.WriteLine("BYE")
        End If


    End Sub



End Module
