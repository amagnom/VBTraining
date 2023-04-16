Imports UnitTest

<TestClass()> Public Class UnitTest1

    Dim calculadora As New Calculadora()

    <TestMethod()> Public Sub TestMethodSomar()
        Assert.AreEqual(20, calculadora.Somar(10, 10))
    End Sub

    <TestMethod()> Public Sub TestMethodSubtrair()
        Assert.AreEqual(10, calculadora.Subtrair(10, 10))
    End Sub

End Class