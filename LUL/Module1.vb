Module Module1

    Sub Main()

        ' While Console.ReadLine() IsNot "Ne"
        'Test2()
        'End While

        Do While Console.ReadLine() IsNot "Ne"
            Test2()

        Loop


    End Sub
    Sub Test2()

        Test(1)

        If Console.ReadLine = "Y" Then
            Test(2)
        Else
            Test(3)
        End If
    End Sub

    Private Sub Test(v As Integer)
        If v = 1 Then
            Console.WriteLine("Dali želite pozdrav?")
            Console.WriteLine("Pritisnite Y za DA, N za ne")
        ElseIf v = 2 Then
            Console.WriteLine("Hello")
        ElseIf v = 3 Then
            Console.WriteLine("BYE")
        End If
    End Sub




End Module
