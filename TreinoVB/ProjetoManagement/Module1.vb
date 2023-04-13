Class Program

    Shared Sub Main(args As String())

        ' Cria uma instância da classe MinhaClasse
        Dim minhaClasse As New MinhaClasse()

        ' Chama o método Saudacao() da classe MinhaClasse
        minhaClasse.Saudacao()

        ' Espera por uma entrada do usuário antes de sair
        Console.ReadLine()

    End Sub

End Class

Class MinhaClasse

    ' Define um método que exibe uma mensagem de saudação
    Public Sub Saudacao()
        Console.WriteLine("Olá, mundo!")
    End Sub

End Class
