Imports System
Imports System.Numerics
Module Program
    Sub Main(args As String())
        Console.WriteLine("200th Fibonacci number:")
        Dim fib1 As BigInteger = 0
        Dim fib2 As BigInteger = 1
        Dim fib As BigInteger
        Dim fibcount As Integer
        fibcount = 0

        Do

            Console.WriteLine(fib1)
            Try
                fib = fib1 + fib2

                fib1 = fib2
                fib2 = fib
                fibcount = fibcount + 1
            Catch e As ArithmeticException
                Console.WriteLine("Exception caught: {0}", e)
            End Try
        Loop While fibcount <= 200
    End Sub
End Module
