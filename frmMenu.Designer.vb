<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCad
        '
        Me.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCad.Location = New System.Drawing.Point(245, 301)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(292, 105)
        Me.btnCad.TabIndex = 0
        Me.btnCad.Text = "CADASTRAR"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Location = New System.Drawing.Point(543, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(308, 105)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "CADASTRAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSair.Location = New System.Drawing.Point(857, 301)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(308, 105)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "SAIR"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 754)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMenu"
        Me.ShowIcon = False
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCad As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSair As Button
End Class
