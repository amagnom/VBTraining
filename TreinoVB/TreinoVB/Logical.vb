Module Logical
    Public Function Somar(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Public Function Subtrair(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Public Function Multiplicar(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Public Function Dividir(ByVal num1 As Double, ByVal num2 As Double) As Double
        If num2 = 0 Then
            Throw New ArgumentException("Não é possível dividir por zero.")
        End If
        Return num1 / num2
    End Function

End Module
