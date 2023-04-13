Public Class Pessoa
    Public Property Nome As String
    Public Property Idade As Integer

    Public Sub New(ByVal nome As String, ByVal idade As Integer)
        Me.Nome = nome
        Me.Idade = idade
    End Sub

    Public Sub Aniversario()
        Me.Idade += 1
    End Sub

End Class
