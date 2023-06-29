Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aux As String
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = Val(TextBox1.Text) + Val(TextBox2.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aux As String
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = Val(TextBox1.Text) - Val(TextBox2.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim aux As String
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = Val(TextBox1.Text) * Val(TextBox2.Text)
            txtResultado.Text = aux
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aux As String
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = Val(TextBox1.Text) / Val(TextBox2.Text)
            txtResultado.Text = aux
        End If
    End Sub
End Class









