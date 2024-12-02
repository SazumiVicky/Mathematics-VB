Imports Mathematics.Core

Namespace Mathematics.Algebra
    Public Class Matrix
        Private _data(,) As Double
        
        Public Sub New(rows As Integer, cols As Integer)
            _data = New Double(rows - 1, cols - 1) {}
        End Sub

        Public Function Determinant() As Double
            If _data.GetLength(0) = 2 Then
                Return _data(0, 0) * _data(1, 1) - _data(0, 1) * _data(1, 0)
            End If
            Return 0
        End Function

        Public Function Transpose() As Matrix
            Dim rows As Integer = _data.GetLength(1)
            Dim cols As Integer = _data.GetLength(0)
            Dim result As New Matrix(rows, cols)
            
            For i As Integer = 0 To rows - 1
                For j As Integer = 0 To cols - 1
                    result._data(i, j) = _data(j, i)
                Next
            Next
            
            Return result
        End Function
    End Class
End Namespace 