Class MainWindow
    Dim inp As String
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        ' Obtém o texto atual da TextBox
        inp = CType(sender, TextBox).Text
    End Sub


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim textoDaTextBox As String = TextBox1.Text
        MessageBox.Show(textoDaTextBox)
        MessageBox.Show(inp)
    End Sub
End Class
