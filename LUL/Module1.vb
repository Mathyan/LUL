Module Module1

    Sub Main()

        ' While Console.ReadLine() IsNot "Ne"
        'Test2()
        'End While
        Try
            Do While Console.ReadLine() IsNot "Ne"
                Test2()

            Loop
        Catch

        End Try

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
        Select Case v
            Case 1
                Console.WriteLine("Dali želite pozdrav?")
                Console.WriteLine("Pritisnite Y za DA, N za ne")
            Case 2
                Console.WriteLine("Hello")
            Case 3
                Console.WriteLine("BYE")
        End Select
    End Sub




End Module
