<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        textoEditavel = New Label()
        Button5 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Highlight
        GroupBox1.Controls.Add(textoEditavel)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Location = New Point(21, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 357)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Editor de Legenda"' 
        ' textoEditavel
        ' 
        textoEditavel.AutoSize = True
        textoEditavel.Location = New Point(33, 56)
        textoEditavel.Name = "textoEditavel"
        textoEditavel.Size = New Size(140, 15)
        textoEditavel.TabIndex = 6
        textoEditavel.Text = "LEGENDA A SER EDITADA"' 
        ' Button5
        ' 
        Button5.BackColor = Color.Fuchsia
        Button5.Location = New Point(33, 283)
        Button5.Name = "Button5"
        Button5.Size = New Size(140, 37)
        Button5.TabIndex = 5
        Button5.Text = "Escrever numero"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Fuchsia
        Button1.Location = New Point(33, 108)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 38)
        Button1.TabIndex = 1
        Button1.Text = "Esconder Legenda"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Fuchsia
        Button4.Location = New Point(33, 238)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 39)
        Button4.TabIndex = 4
        Button4.Text = "Mudar cor do Formulario"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Fuchsia
        Button2.Location = New Point(33, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 36)
        Button2.TabIndex = 2
        Button2.Text = "Mostrar a Legenda"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Fuchsia
        Button3.Location = New Point(33, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 38)
        Button3.TabIndex = 3
        Button3.Text = "Mudar cor da Legenda"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(245, 450)
        Controls.Add(GroupBox1)
        Name = "Form5"
        Text = "Form5"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents textoEditavel As Label
End Class
