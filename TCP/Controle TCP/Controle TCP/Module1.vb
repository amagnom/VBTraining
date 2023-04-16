Imports System.Net.Sockets
Imports System.Text
Module Module1
    Dim listener As TcpListener
    Dim cliente As TcpClient
    Dim ns As NetworkStream
    Sub FecharConexao()
        'ENCERRA A CONEXÃO
        ns.Close()
        cliente.Close()
        listener.Stop()
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("Conexão fechada!")
        Console.ReadKey()
        End
    End Sub
    Sub Main()
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("***Controle TCP/IP***")
        Console.WriteLine("")
        'DEFINE A PORTA DE CONEXÃO
        Const porta As Integer = 8081
        listener = New TcpListener(porta)
        Console.BackgroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Aguardando conexão na porta {0}...", porta)
        'INICIA A ESCUTA NA PORTA SOLICITADA
        listener.Start()
        'ACEITA O PEDIDO DE CONEXÃO
        cliente = listener.AcceptTcpClient
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("Aguardando conexão na porta {0}...", porta)
        ns = cliente.GetStream
        Console.WriteLine("")
        Console.WriteLine("Precione enter para enviar, ou exit para encerrar!")
        Console.BackgroundColor = ConsoleColor.Black
        Do
            Dim texto As String = Console.ReadLine
            If texto.ToLower = "exit" Then
                'CASO A PALAVRA EXIT SEJA DIGITADA NO CONSOLE, ENCERRA A CONEXÃO
                'ATENÇÃO: MANTER EM TOLOWER, ESSE MÉTODO REDUZ TODAS AS LETRAS PARA MINUSCULO, ASSIM EVITA CONFLITOS
                FecharConexao()
            Else
                Try
                    'TENTA ENVIAR A MENSAGEM DIGITADA
                    Dim data As Byte() = Encoding.ASCII.GetBytes(My.Computer.Name & ": " & texto)
                    ns.Write(data, 0, data.Length)
                Catch
                    'CLIENTE REMOTO FECHOU O CONSOLE (CONEXÃO PERDIDA)
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.WriteLine("Receptor remoto fechado!")
                    FecharConexao()
                    Exit Do
                End Try
            End If
        Loop
        Console.ReadKey()
    End Sub
End Module
