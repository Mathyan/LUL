Module Module1

    Sub Main()

        While Console.ReadLine() IsNot "Ne"
            Test2()
        End While


    End Sub
    Sub Test2()
        Dim answer As String

        Test(1)
        answer = Console.ReadLine()
        If answer = "Y" Then
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
