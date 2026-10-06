Module Module1
    '   Title:          tryFizzBuzz
    '   Author:         Abdullah Bhutta
    '   Version:        0.1
    '   Date:           06/10/2026
    '   Description     Creating a simple FizzBuzz simulator
    Sub Main()
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim divisor As Integer = 0

        '   Output all of the multiples of 7 from num1 to num2
        '   Ask the user for the value for num1 and num2

        Console.WriteLine("Please enter a number")
        num1 = Console.ReadLine()
        Console.WriteLine("Please enter another number")
        num2 = Console.ReadLine()
        Console.WriteLine("Please enter a divisor")
        divisor = Console.ReadLine()
        '   List all values of num1 and num2 inclusive and if the values divided by the divisor = 0 then list those values

        For counter = num1 To num2
            If counter Mod divisor = 0 Then
                Console.WriteLine(counter)

            End If
        Next




    End Sub

End Module
