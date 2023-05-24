<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        txtResultado = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button1.Location = New Point(45, 140)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 61)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.Location = New Point(198, 140)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 61)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button3.Location = New Point(43, 228)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 61)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button4.Location = New Point(198, 228)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 61)
        Button4.TabIndex = 3
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Yellow
        TextBox1.Location = New Point(43, 81)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Yellow
        TextBox2.Location = New Point(198, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' txtResultado
        ' 
        txtResultado.BackColor = Color.Yellow
        txtResultado.Location = New Point(110, 320)
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(188, 23)
        txtResultado.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtResultado)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(14, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(353, 368)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 9
        Label3.Text = "Primeiro Numero:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 323)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 8
        Label2.Text = "Resultado"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 7
        Label1.Text = "Calculadora"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(194, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 10
        Label4.Text = "Segundo Numero:"' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 383)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
