Imports System

Module Program
    Sub Main(args As String())

        Dim Sentence As String = "i like this program very much"
        Dim reversed As String = Reverse(Sentence)
        Console.WriteLine(reversed)
    End Sub
    Public Function Reverse(a As String)

        Dim reversedName As String = ""
        Dim tempName As String = ""
        Try
            For i As Integer = 0 To a.Length - 1
                If Not a.Substring(i, 1).Trim.Equals("") Then
                    tempName += a.Substring(i, 1)
                Else
                    reversedName = tempName + " " + reversedName
                    tempName = ""
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("Error caught in for loop")
        End Try

        Return tempName + " " + reversedName
    End Function

End Module
