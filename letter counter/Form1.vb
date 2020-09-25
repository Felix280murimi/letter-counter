Public Class Form1
    Private Sub btnCountStringLetters_Click(sender As Object, e As EventArgs) Handles btnCountStringLetters.Click
        MsgBox(TextBox1.Text.Count(Function(x) Char.IsLetter(x) = True))
    End Sub

    Private Sub btnNumberOf_Click(sender As Object, e As EventArgs) Handles btnNumberOf.Click
        MsgBox(TextBox1.Text.Count(Function(x) x = TextBox2.Text$))
    End Sub

    Private Sub btnCounNumbersInString_Click(sender As Object, e As EventArgs) Handles btnCounNumbersInString.Click
        MsgBox(TextBox1.Text.Count(Function(x) Char.IsNumber(x) = True))
    End Sub
End Class
