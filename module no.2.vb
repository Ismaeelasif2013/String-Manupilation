Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim p1, p2 As Integer
        string1 = ""
        string2 = ""
        p1 = 0
        p2 = 0
        nextchar = ""

        Console.Write(" Enter the your string: ")
        string1 = Console.ReadLine
        p1 = InStr(string1, " ")
        nextchar = Mid(string1, p1 + 1, Len(string1))
        p2 = InStr(nextchar, " ")
        string2 = Mid(nextchar, 1, p2 - 1)

        Console.WriteLine("tHE MIDDLE WORD OF YOUR STRING IS: ")
        Console.ReadKey()




    End Sub

End Module
