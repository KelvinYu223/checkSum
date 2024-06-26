Public Class Form1
    Private Sub checkSum()
        Dim totalInt As Long
        Dim input As String = TextBox1.Text
        For Each oneChar As Char In input
            Dim AscCode As SByte = Asc(oneChar)
            totalInt = totalInt Xor AscCode
        Next
        ListBox1.Items.Add(Hex(totalInt))
    End Sub

    Private Sub ButtonCs_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkSum()
    End Sub
End Class
