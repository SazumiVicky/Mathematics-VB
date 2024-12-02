Namespace Mathematics.Core
    Public Class MathBase
        Protected Function Factorial(n As Integer) As Long
            If n <= 1 Then Return 1
            Return n * Factorial(n - 1)
        End Function

        Protected Function Power(base As Double, exp As Integer) As Double
            Return Math.Pow(base, exp)
        End Function
    End Class
End Namespace 