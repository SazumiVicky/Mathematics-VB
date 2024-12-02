Imports Mathematics.Algebra
Imports Mathematics.Calculus
Imports Mathematics.Statistics

Module TestRunner
    Sub Main()
        Dim mat As New Matrix(2, 2)
        Console.WriteLine("Matrix Operations Test")
        
        Dim deriv As New Derivative()
        Dim result = deriv.NumericalDerivative(Function(x) x * x, 2.0)
        Console.WriteLine($"Derivative of x^2 at x=2: {result}")
        
        Dim stats As New BasicStats()
        Dim data = New Double() {1, 2, 3, 4, 5}
        Console.WriteLine($"Mean: {stats.Mean(data)}")
        Console.WriteLine($"Standard Deviation: {stats.StandardDeviation(data)}")
    End Sub
End Module 