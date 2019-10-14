Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer
        Dim anagram As Boolean
        string1 = ""
        string2 = ""
        nextchar = ""
        counter = 0
        anagram = True

        Console.Write("Kindly input your first string: ")
        string1 = Console.ReadLine
        string1 = LCase(string1)

        Console.Write("Kindly input your second string: ")
        string2 = Console.ReadLine
        string2 = LCase(string2)

            For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If InStr(string2, nextchar) = 0 Then
                anagram = False
            End If
        Next
        If anagram = True Then
            Console.WriteLine("The two strings are anagram")
        Else

            Console.WriteLine("The two strings are not anagram")
        End If


        Console.ReadKey()
    End Sub

End Module
