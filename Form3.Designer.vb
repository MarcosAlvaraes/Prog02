﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumTurquoise
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(20, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(758, 418)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(299, 317)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 9
        Label5.Text = "Volume"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(133, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 8
        Label4.Text = "Altura :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(135, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 7
        Label3.Text = "Largura :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 6
        Label2.Text = "Comprimento :"' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.Location = New Point(62, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 57)
        Button1.TabIndex = 5
        Button1.Text = "Calcular Volume"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.GradientActiveCaption
        TextBox4.Location = New Point(194, 335)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(282, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.GradientActiveCaption
        TextBox3.Location = New Point(194, 236)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(282, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientActiveCaption
        TextBox2.Location = New Point(194, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(282, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.Location = New Point(194, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(282, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 15)
        Label1.TabIndex = 0
        Label1.Text = "Calcular Volume de um tanque"' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
