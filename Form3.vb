Public Class Form3

    Dim aux As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 And TextBox3.TextLength <> 0 Then
            aux = TextBox1.Text * TextBox2.Text * TextBox3.Text
            TextBox4.Text = aux
        End If
    End Sub
End Class