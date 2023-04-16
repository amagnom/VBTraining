Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Module Module1
    Dim cliente As TcpClient
    Dim ns As NetworkStream
    Dim k As Integer = 0
    Dim ArrayClear As New ArrayList
    Sub FecharConexao()
        'ENCERRA A CONEXÃO
        cliente.Close()
        ns.Close()
        Console.BackgroundColor = ConsoleColor.Red
        'ENVIA UMA NOTIFICAÇÃO AO CLIENTE, PORÉM PODE SER REMOVIDO
        Console.WriteLine("Conexão encerrada!")
        Console.ReadKey()
        End
    End Sub
    Sub MusicaBeep()
        Console.WriteLine("Fonte original da música: https://gist.github.com/XeeX/6220318")
        Console.WriteLine("Créditos: XeeX")
        Console.Beep(659, 125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(523, 125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(375)
        Console.Beep(392, 125)
        Thread.Sleep(375)
        Console.Beep(523, 125)
        Thread.Sleep(250)
        Console.Beep(392, 125)
        Thread.Sleep(250)
        Console.Beep(330, 125)
        Thread.Sleep(250)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(466, 125)
        Thread.Sleep(42)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(392, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(880, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(587, 125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(250)
        Console.Beep(392, 125)
        Thread.Sleep(250)
        Console.Beep(330, 125)
        Thread.Sleep(250)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(494, 125)
        Thread.Sleep(125)
        Console.Beep(466, 125)
        Thread.Sleep(42)
        Console.Beep(440, 125)
        Thread.Sleep(125)
        Console.Beep(392, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(880, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(784, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(587, 125)
        Console.Beep(494, 125)
        Thread.Sleep(375)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(698, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(698, 125)
        Thread.Sleep(625)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(622, 125)
        Thread.Sleep(250)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(523, 125)
        Thread.Sleep(1125)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(698, 125)
        Thread.Sleep(125)
        Console.Beep(698, 125)
        Console.Beep(698, 125)
        Thread.Sleep(625)
        Console.Beep(784, 125)
        Console.Beep(740, 125)
        Console.Beep(698, 125)
        Thread.Sleep(42)
        Console.Beep(622, 125)
        Thread.Sleep(125)
        Console.Beep(659, 125)
        Thread.Sleep(167)
        Console.Beep(415, 125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Thread.Sleep(125)
        Console.Beep(440, 125)
        Console.Beep(523, 125)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(622, 125)
        Thread.Sleep(250)
        Console.Beep(587, 125)
        Thread.Sleep(250)
        Console.Beep(523, 125)
    End Sub
    Sub Main()
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("*** Receptor TCP/IP ****")
        Console.WriteLine("")
        'DEFINE O IP DE CONEXÃO, PODE SER ALTERADO
        Dim IP As String = "192.168.2.101"
        'DEFINE A PORTA DE CONEXÃO
        Const porta As Integer = 8081
        Console.BackgroundColor = ConsoleColor.Black
        Console.WriteLine("Tentativa de conexão [" & k & "]")
        Try
            'TENTA A CONEXÃO
            cliente = New TcpClient(IP, porta)
        Catch
            'O SERVIDOR NÃO ESTÁ DISPONIVEL, A SUB MAIN É REINICIADA
            k = k + 1
            Console.Clear()
            Main()
        End Try
        'CONEXÃO ESTABELECIDA
        ns = cliente.GetStream
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("Conexão estabelecida pela porta 8080")
        Do
            Try
                'CICLO FOR QUE REALIZAR A LEITURA DOS BYTES RECEBIDOS
                Console.BackgroundColor = ConsoleColor.Black
                Dim data As Byte() = New Byte(20124) {}
                Dim dataread As Integer = ns.Read(data, 0, data.Length)
                'CONVETE BYTES EM STRING (TEXTO)
                Dim linha As String = Encoding.ASCII.GetString(data, 0, dataread)
                If linha <> Nothing Then
                    'VERIFICA SE A STRING POSSUI ALGUM TEXTO
                    If InStr(linha.ToLower, "@music01") > 0 Then
                        MusicaBeep()
                    Else
                        Console.WriteLine(linha)
                    End If
                Else
                    'CASO A STRING ESTEJA VAZIA, ADICIONA + 1 ITEM A ARRAY.
                    'ATENÇÃO: SE O CONTROLADOR ENCERRAR A CONEXÃO, A VARIAVEL cliente MANTÉM O STATUS DE ATIVA, POR ESTE MOTIVO É NESCESSÁRIO VERIFICAR
                    'SE NÃO ESTAMOS RECEBENDO MUITOS PACOTES EM BRANCO, SE SIM, A CONEXÃO FOI FECHADA PELO CONTROLADOR
                    ArrayClear.Add(linha)
                    If ArrayClear.Count > 4 Then
                        'CONTROLADOR FECHOU A CONEXÃO, ENCERRA A CONEXÃO
                        Console.BackgroundColor = ConsoleColor.Red
                        Console.WriteLine("Servidor encerrou a conexão")
                        FecharConexao()
                    End If
                End If
            Catch
                'ERRO, A CONEXÃO NÃO ESTÁ DISPONIVEL, O CONTROLADOR FECHOU O CONSOLE SEM ENCERRAR A CONEXÃO
                Console.BackgroundColor = ConsoleColor.Red
                Console.WriteLine("Perda de conexão com o controlador remoto!")
                FecharConexao()
                Exit Do
            End Try
        Loop
    End Sub
End Module
