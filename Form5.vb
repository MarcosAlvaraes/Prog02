Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        textoEditavel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        textoEditavel.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prim As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim seg As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim ter As Integer = CInt(Int((250 * Rnd()) + 1))
        textoEditavel.BackColor = Color.FromArgb(prim, seg, ter)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim prim As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim seg As Integer = CInt(Int((250 * Rnd()) + 1))
        Dim ter As Integer = CInt(Int((250 * Rnd()) + 1))
        Me.BackColor = Color.FromArgb(prim, seg, ter)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aux As Integer = CInt(Int((100 * Rnd()) + 1))
        textoEditavel.Text = aux
    End Sub
End Class

