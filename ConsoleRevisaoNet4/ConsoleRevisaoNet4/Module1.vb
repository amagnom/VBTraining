'como se faz um import: Imports, e adiciona a referencia ao projeto
Imports System.Windows.Forms

Module Module1

    Sub Main()

        Outros()
        Console.WriteLine(FuncaoRetornaVal(20))

        TratamentoExececao()
        EstruturasDados()
        Condicionais()
        EstruturaRepeticao()


        Console.Read()
        Console.Read()

    End Sub

    Sub TratamentoExececao()
        Try
            ' Código que pode gerar uma exceção
        Catch ex As Exception
            ' Tratamento da exceção
            Console.WriteLine("O erro é: " & ex.ToString())
        End Try

    End Sub

    Sub EstruturasDados()
        ' Exemplo de Array Unidimensional
        Dim arr1(4) As Integer ' array com 5 elementos
        arr1(0) = 10
        arr1(1) = 20
        arr1(2) = 30
        arr1(3) = 40
        arr1(4) = 50

        ' Exemplo de Array Multidimensional
        Dim arr2(2, 2) As Integer ' array 3x3
        arr2(0, 0) = 1
        arr2(0, 1) = 2
        arr2(0, 2) = 3
        arr2(1, 0) = 4
        arr2(1, 1) = 5
        arr2(1, 2) = 6
        arr2(2, 0) = 7
        arr2(2, 1) = 8
        arr2(2, 2) = 9

        ' Exemplo de Lista
        Dim lista As New List(Of Integer)
        lista.Add(10)
        lista.Add(20)
        lista.Add(30)

        ' Exemplo de Dicionário
        Dim dicionario As New Dictionary(Of String, Integer)
        dicionario.Add("Maçã", 50)
        dicionario.Add("Banana", 30)
        dicionario.Add("Laranja", 40)

        For Each item In lista
            Console.WriteLine(item)
        Next



        'mt melhor usar lista ou dict
    End Sub

    Sub Outros()

        Dim x As Integer = 10
        Dim y As Integer = 20
        Dim z As Integer = x + y
        Dim teste As String
        Dim number1 As String

        teste = "um conteudo"
        Console.WriteLine("A soma é :" + z.ToString())
        Console.WriteLine(teste)


        number1 = Console.ReadLine()


        Console.WriteLine("concatenando strings " & number1)

        Console.WriteLine("O numero digitado foi : {0} pelo usuario {1}", "2", "zeca")

        Console.WriteLine("O numero digitado foi : {0} pelo usuario {1}", x, teste)


        Dim palavra As String = "teste"
        Dim tam As Integer = Len(palavra)

        Console.WriteLine("palavra: " & palavra & " tem tamanho " & CStr(tam) & " ou da para falar pelo atributo de uma string
        como " & palavra.Length)

        Console.WriteLine("Em maiusculo : " & palavra.ToUpper())


        Dim texto As String = "Olá, mundo!"

        If texto.StartsWith("Olá") Then
            Console.WriteLine("A string começa com 'Olá'")
        Else
            Console.WriteLine("A string não começa com 'Olá'")
        End If


        Dim texto2 As String = "   Olá, mundo!    "

        'O método Trim remove os espaços em branco do início e do fim da string:

        Dim textoTrimmed As String = texto2.Trim()
        Console.WriteLine(textoTrimmed)


        'Para obter uma substring que comece na posição 4 e tenha 5 caracteres, você pode usar a função Substring desta forma:

        Dim subTexto As String = texto.Substring(4, 5)
        Console.WriteLine(subTexto) ' ", mun"





        'Usando o import:  messabox
        MessageBox.Show("minha caixa", "teste", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        ' Operador de atribuição simples (=)

        ' Operador de atribuição e acumulação (+=)
        ' equivalente a x = x + 3

        ' Operador de atribuição e acumulação (*=)
        ' equivalente a x = x * 3

        ' Operador de atribuição e acumulação (&=)
        ' equivalente a str1 = str1 & "mundo!"


        ExibeResultado("cec")




    End Sub

    Sub EstruturaRepeticao()

        'ESTRUTURAS DE REPETIÇÃO
        ' Estrutura de repetição While
        Dim i As Integer = 1
        While i <= 10
            Console.WriteLine(i)
            i += 1
        End While

        ' Estrutura de repetição Do While
        Dim j As Integer = 1
        Do While j <= 10
            Console.WriteLine(j)
            j += 1
        Loop

        ' Estrutura de repetição For
        For k As Integer = 1 To 10
            Console.WriteLine(k)
        Next

        ' Estrutura de repetição For Each
        Dim arr() As Integer = {1, 2, 3, 4, 5}
        For Each num As Integer In arr
            Console.WriteLine(num)
        Next


        For e As Integer = 10 To 1 Step -1
            Console.WriteLine(e)
        Next


    End Sub

    Sub Condicionais()


        'CONDICIONAL IF:
        Dim idade As Integer = 18
        Dim nasc As Integer = 1900

        If idade >= 18 Then
            Console.WriteLine("Você já pode votar.")
        End If

        If idade >= 18 Then
            Console.WriteLine("é de maior")
        Else
            Console.WriteLine("É de menor")
        End If


        If idade >= 18 And nasc <= 2000 Then
            Console.WriteLine("Ta quais na hora")
        End If




        Dim nota As Integer = 8

        If nota >= 9 Then
            Console.WriteLine("Você tirou uma nota excelente!")
        ElseIf nota >= 7 Then
            Console.WriteLine("Você tirou uma nota boa.")
        ElseIf nota >= 5 Then
            Console.WriteLine("Você tirou uma nota razoável.")
        Else
            Console.WriteLine("Você precisa estudar mais para melhorar sua nota.")
        End If


        'entra no ultimo else se nao passar em nenhuma dos elseif anterior
        Dim idade2 As Integer = 25

        If idade2 < 18 Then
            Console.WriteLine("Você é menor de idade.")
        ElseIf idade2 >= 18 And idade2 <= 64 Then
            Console.WriteLine("Você é adulto.")
        Else
            Console.WriteLine("Você é idoso.")
        End If


        'O operador Not faz a negação
        Dim idade3 As Integer = 25
        Dim altura As Double = 1.8
        Dim possuiCarro As Boolean = False

        If idade3 > 18 And altura > 1.7 Then
            Console.WriteLine("Você tem mais de 18 anos e é alto o suficiente.")
        Else
            Console.WriteLine("Você não atende aos requisitos.")
        End If

        If idade3 > 18 Or altura > 1.7 Then
            Console.WriteLine("Você atende aos requisitos.")
        Else
            Console.WriteLine("Você não atende aos requisitos.")
        End If

        If Not possuiCarro Then
            Console.WriteLine("Você não possui um carro.")
        Else
            Console.WriteLine("Você possui um carro.")
        End If



        Dim diaDaSemana As Integer = 4
        Dim nomeDoDia As String

        Select Case diaDaSemana
            Case 1
                nomeDoDia = "Domingo"
            Case 2
                nomeDoDia = "Segunda"
            Case 3
                nomeDoDia = "Terça"
            Case 4
                nomeDoDia = "Quarta"
            Case 5
                nomeDoDia = "Quinta"
            Case 6
                nomeDoDia = "Sexta"
            Case 7
                nomeDoDia = "Sábado"
            Case Else
                nomeDoDia = "Dia inválido"
        End Select

        Console.WriteLine("Hoje é " & nomeDoDia)

    End Sub

    'Declara a função e o tipo de retorno dela como As Integer
    Function FuncaoRetornaVal(ByVal number As Integer) As Integer
        Return number * 100
    End Function


    'Tem que passar o parametro como byval por copia ou ByRef por referencia
    Sub ExibeResultado(ByVal a As String)
        Console.WriteLine("Resultado " & a)
    End Sub

    ' Procedimento Sub
    Sub ExemploSub()
        ' Código a ser executado
    End Sub

    ' Procedimento Function
    Function ExemploFunction(ByVal argumento1 As Integer, ByVal argumento2 As Integer) As Integer
        ' Código a ser executado
        Return argumento1 + argumento2
    End Function

    ' Procedimento Property
    Private _propriedade As String

    Public Property Propriedade As String
        Get
            Return _propriedade
        End Get
        Set(ByVal value As String)
            _propriedade = value
        End Set
    End Property

    ' Procedimento Event
    'Private WithEvents Bact As Button
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bact.Click
    '    ' Código a ser executado quando o botão é clicado
    'End Sub


End Module





'VARIAVEIS E TIPOS DELAS  DIN(Declare In Memory)

' Lista de tipos de dados em Visual Basic:
' 
' Boolean: Valores lógicos verdadeiro ou falso
'   Exemplo: 
'   Dim isTrue As Boolean = True
'   Dim isFalse As Boolean = False
' 
' Byte: Valores numéricos inteiros sem sinal de 0 a 255
'   Exemplo:
'   Dim myByte As Byte = 255
' 
' Char: Caracteres individuais representados por um código Unicode
'   Exemplo:
'   Dim myChar As Char = "A"c ' O sufixo "c" indica que é um caractere, não uma string
' 
' Date: Data e hora
'   Exemplo:
'   Dim myDate As Date = #04/11/2023 3:14:15 PM#
' 
' Decimal: Valores numéricos decimais de alta precisão
'   Exemplo:
'   Dim myDecimal As Decimal = 3.14159265358979D
' 
' Double: Valores numéricos de ponto flutuante de dupla precisão
'   Exemplo:
'   Dim myDouble As Double = 3.14159265358979
' 
' Integer: Valores numéricos inteiros de -2.147.483.648 a 2.147.483.647
'   Exemplo:
'   Dim myInteger As Integer = 42
' 
' Long: Valores numéricos inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
'   Exemplo:
'   Dim myLong As Long = 1234567890L ' O sufixo "L" indica que é um long
' 
' Object: Qualquer tipo de objeto
'   Exemplo:
'   Dim myObject As Object = "Hello World"
' 
' Short: Valores numéricos inteiros de -32.768 a 32.767
'   Exemplo:
'   Dim myShort As Short = 32767S ' O sufixo "S" indica que é um short
' 
' Single: Valores numéricos de ponto flutuante de precisão simples
'   Exemplo:
'   Dim mySingle As Single = 3.14F ' O sufixo "F" indica que é um single
' 
' String: Sequências de caracteres
'   Exemplo:
'   Dim myString As String = "Hello World"
' 
' UInteger: Valores numéricos inteiros sem sinal de 0 a 4.294.967.295
'   Exemplo:
'   Dim myUInteger As UInteger = 4294967295UI ' O sufixo "UI" indica que é um uinteger
' 
' ULong: Valores numéricos inteiros sem sinal de 0 a 18.446.744.073.709.551.615
'   Exemplo:
'   Dim myULong As ULong = 18446744073709551615UL ' O sufixo "UL" indica que é um ulong
' 
' UShort: Valores numéricos inteiros sem sinal de 0 a 65.535
'   Exemplo:
'   Dim myUShort As UShort = 65535






' Lista de funções de conversão em Visual Basic:
'
' CBool - Converte uma expressão em um valor Boolean
' Exemplo:
' Dim boolValue As Boolean = CBool("True")

' CByte - Converte uma expressão em um valor Byte
' Exemplo:
' Dim byteValue As Byte = CByte("255")

' CChar - Converte uma expressão em um valor Char
' Exemplo:
' Dim charValue As Char = CChar("A")

' CDate - Converte uma expressão em um valor Date
' Exemplo:
' Dim dateValue As Date = CDate("2022-05-01")

' CDbl - Converte uma expressão em um valor Double
' Exemplo:
' Dim doubleValue As Double = CDbl("3.14159")

' CInt - Converte uma expressão em um valor Integer
' Exemplo:
' Dim intValue As Integer = CInt("12345")

' CLng - Converte uma expressão em um valor Long
' Exemplo:
' Dim longValue As Long = CLng("9876543210")

' CObj - Converte uma expressão em um valor Object
' Exemplo:
' Dim objValue As Object = CObj("Hello, World!")

' CShort - Converte uma expressão em um valor Short
' Exemplo:
' Dim shortValue As Short = CShort("1234")

' CSng - Converte uma expressão em um valor Single
' Exemplo:
' Dim singleValue As Single = CSng("1.2345")

' CStr - Converte uma expressão em uma String
' Exemplo:
'Dim strValue As String = CStr(2)

' CUInt - Converte uma expressão em um valor UInteger
' Exemplo:
' Dim uintValue As UInteger = CUInt("123456")

' CULng - Converte uma expressão em um valor ULong
' Exemplo:
' Dim ulongValue As ULong = CULng("9876543210")

' CUShort - Converte uma expressão em um valor UShort
' Exemplo:
' Dim ushortValue As UShort = CUShort("1234")






' Lista de operadores aritméticos em Visual Basic:
'
' +  - Adição
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 5
' Dim result As Integer = a + b

' -  - Subtração
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 5
' Dim result As Integer = a - b

' *  - Multiplicação
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 5
' Dim result As Integer = a * b

' /  - Divisão
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 5
' Dim result As Integer = a / b

' \  - Divisão inteira (retorna a parte inteira do resultado)
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 3
' Dim result As Integer = a \ b

' Mod  - Resto da divisão inteira
' Exemplo:
' Dim a As Integer = 10
' Dim b As Integer = 3
' Dim result As Integer = a Mod b

' ^  - Exponenciação
' Exemplo:
' Dim a As Integer = 2
' Dim b As Integer = 3
' Dim result As Integer = a ^ b



