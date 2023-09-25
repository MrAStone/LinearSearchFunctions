Module Module1

    Sub Main()
        Dim nums() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        printNumberArray(nums)
        Dim words() As String = {"I", "Can", "use", "arrays", "as", "Parameters"}
        printStringArray(words)
        Console.WriteLine(doThing)
        Console.Write("Enter a number to find: ")
        Dim numToFind As Integer = Console.ReadLine
        Dim pos As Integer = linearSearch(nums, numToFind)
        If pos = -1 Then
            Console.WriteLine($"{numToFind} Not Found")
        Else
            Console.WriteLine($"{numToFind} found in position {pos}")
        End If

        Console.Write("Enter word to find: ")
        Dim word As String = Console.ReadLine
        pos = linearSearchForStrings(words, word)
        If pos = -1 Then
            Console.WriteLine($"{word} Not Found")
        Else
            Console.WriteLine($"{word} found in position {pos}")
        End If

    End Sub
    Sub printNumberArray(numberArray() As Integer)
        For i = 0 To numberArray.Length - 1
            Console.WriteLine(numberArray(i))
        Next
    End Sub
    Sub printStringArray(StringArray() As String)
        For i = 0 To StringArray.Length - 1
            Console.WriteLine(StringArray(i))
        Next
    End Sub
    Function doThing()
        For i = 1 To 10
            Console.WriteLine(i)
            If i = 7 Then
                Return -1
            End If
        Next
        Return 100
    End Function
    Function linearSearch(nums() As Integer, numToFind As Integer)
        For i = 0 To nums.Length - 1
            If nums(i) = numToFind Then
                Return i
            End If
        Next

        Return -1
    End Function
    Function linearSearchForStrings(words() As String, wordToFind As String)
        For i = 0 To words.Length - 1
            If words(i) = wordToFind Then
                Return i
            End If
        Next
        Return -1

    End Function
End Module
