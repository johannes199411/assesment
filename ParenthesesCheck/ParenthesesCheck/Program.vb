Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Please Input parentheses characters: [,{,(,],},)")
        Dim parentheses As String = Console.ReadLine()

        Console.WriteLine(isBalanced(parentheses))
    End Sub



    Public Function isBalanced(input As String)
        Dim pairs = New Dictionary(Of Char, Char)
        pairs.Add("(", ")")
        pairs.Add("[", "]")
        pairs.Add("{", "}")

        Dim brackets As New Stack(Of Char)


        Try
            'Loop through characters to compare and balance'
            For Each c In input
                If pairs.Keys.Contains(c) Then
                    brackets.Push(c)
                Else
                    If pairs.Values.Contains(c) Then
                        If c = pairs(brackets.First) Then
                            brackets.Pop()
                        Else
                            Return "unbalanced"
                        End If
                    Else
                        Continue For
                    End If
                End If

            Next
        Catch ex As Exception
            'catch any error as unbalanced'
            Return "unbalanced"
        End Try
        'ensure that brackets are balanced''
        If brackets.Count() = 0 Then
            Return "balanced"
        Else
            Return "unbalanced"
        End If

    End Function

End Module
