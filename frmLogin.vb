Public Class frmLogin

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If txtUsuario.Text = "renato" And txtSenha.Text = "mix0311" Then
            frmMenu.Show()
            Me.Close()

        ElseIf txtUsuario.Text = "renato" And Not txtSenha.Text = "mix0311" Then
            MessageBox.Show("Campo Senha preenchido com erro. Favor preencher corretamente.", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSenha.Clear()
            txtSenha.Focus()

        ElseIf txtSenha.Text = "mix0311" And Not txtUsuario.Text = "renato" Then
            MessageBox.Show("Campo Usuário preenchido com erro. Favor preencher corretamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Clear()
            txtUsuario.Focus()

        ElseIf txtUsuario.Text = "" And txtSenha.Text = "" Then
            MessageBox.Show("Campos Usuário e Senha obrigatórios. Favor preencher.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Focus()

        ElseIf txtUsuario.Text = "" Then
            MessageBox.Show("Campo Usuário obrigatório. Favor preencher.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Focus()

        ElseIf txtSenha.Text = "" Then
            MessageBox.Show("Campo Senha obrigatório. Favor preencher.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSenha.Focus()

        Else
            MessageBox.Show("Usuário ou Senha inválido.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Text = ""
            txtSenha.Text = ""
            txtUsuario.Focus()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub
End Class