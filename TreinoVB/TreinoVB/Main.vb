Module Main

    Sub Main()

        Dim pessoa As New Pessoa("Joao", 10)
        pessoa.Aniversario()
        Console.WriteLine(pessoa.Idade.ToString())

        Dim resultado As Double = Logical.Somar(10, 20)
        Console.WriteLine(resultado.ToString())

        Console.ReadLine()
    End Sub

End Module
