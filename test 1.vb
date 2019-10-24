Module Module1

    Sub Main()
        Dim binarystring, denarystring, nextchar As String
        Dim count, value As Integer
        Dim binaryvalidstring As Boolean

        binarystring = ""
        count = 0
        denarystring = ""
        nextchar = ""
        binaryvalidstring = True

        Console.Write("Kindly enter your binary number: ")
        binarystring = Console.ReadLine

        If Len(binarystring) <= "8" Then
            binaryvalidstring = True
        Else
            binaryvalidstring = False
        End If

            For count = 1 To Len(binarystring)
                nextchar = Mid(binarystring, count, 1)
            If nextchar = "1" Or nextchar = "0" Then
                binaryvalidstring = True
            Else
                binaryvalidstring = False
            End If
        Next

        If binaryvalidstring = False Then
            Console.Write("Not a valid binary number...")
        Else
            Console.Write("Valid binary number...")
        End If

        If binaryvalidstring = True Then
            For count = Len(binarystring) To 1 Step -1
                nextchar = Mid(binarystring, count, 1)

            Next
        End If

        Console.ReadKey()
    End Sub

End Module
