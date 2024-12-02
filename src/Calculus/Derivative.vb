Namespace Mathematics.Calculus
    Public Class Derivative
        Public Function NumericalDerivative(ByVal f As Func(Of Double, Double), ByVal x As Double) As Double
            Dim h As Double = 0.0001
            Return (f(x + h) - f(x)) / h
        End Function

        Public Function SimpleIntegration(ByVal f As Func(Of Double, Double), ByVal a As Double, ByVal b As Double) As Double
            Dim n As Integer = 1000
            Dim h As Double = (b - a) / n
            Dim sum As Double = 0

            For i As Integer = 0 To n - 1
                sum += f(a + i * h) * h
            Next

            Return sum
        End Function
    End Class
End Namespace 