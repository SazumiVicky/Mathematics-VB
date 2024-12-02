Namespace Mathematics.Statistics
    Public Class BasicStats
        Public Function Mean(data As Double()) As Double
            Return data.Average()
        End Function

        Public Function Variance(data As Double()) As Double
            Dim avg = Mean(data)
            Return data.Select(Function(x) Math.Pow(x - avg, 2)).Average()
        End Function

        Public Function StandardDeviation(data As Double()) As Double
            Return Math.Sqrt(Variance(data))
        End Function
    End Class
End Namespace 