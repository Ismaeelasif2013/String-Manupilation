Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer
        string2 = ""
        string1 = ""
        nextchar = ""
        counter = 0
        Console.Write("Kindly enter your string: ")
        string1 = Console.ReadLine
        For counter = Len(string1) To 1 Step -1
            nextchar = Mid(string1, counter, 1)
            string2 = string2 + nextchar
        Next
        Console.Write("Your final string is: " & string2)
        Console.ReadKey()
    End Sub

End Module
