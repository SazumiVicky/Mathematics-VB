Namespace Mathematics.Utils
    Public Class MathHelper
        Public Shared Function GenerateRandomMatrix(rows As Integer, cols As Integer) As Double(,)
            Dim rnd As New Random()
            Dim result(rows - 1, cols - 1) As Double
            
            For i As Integer = 0 To rows - 1
                For j As Integer = 0 To cols - 1
                    result(i, j) = rnd.NextDouble() * 10
                Next
            Next
            
            Return result
        End Function
    End Class
End Namespace 