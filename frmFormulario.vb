Imports System.IO

Public Class frmFormulario 'Declaração de variáveis com 10 posições.

    Dim aNome(0) As String
    Dim aCodigo(0) As String
    Dim aEnd(0) As String
    Dim aComp(0) As String
    Dim aBairro(0) As String
    Dim aCEP(0) As String
    Dim aCidade(0) As String
    Dim aUF(0) As String
    Dim aCPF(0) As String
    Dim aCelular(0) As String
    Dim aComercial(0) As String
    Dim aContato(0) As String
    Dim aNascimento(0) As String
    Dim aEmail(0) As String
    Dim aSexo(0) As String
    Dim aEscolaridade(0) As String
    Dim aInst(0) As String
    Dim aObs(0) As String
    Dim aCadastro(0) As String
    Dim aData(0) As String

    Dim vModo As String = "X"

    Private Sub frmFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Ao carregar o Formulário, o sistema faz busca no arquivo .txt

        lblStatus.Text = "[Carregado com sucesso]"

        If Not My.Computer.FileSystem.FileExists("D:\RENATO\Projetos\Sistemas\VisualBasic\Sistema_Cadastro\contatos.txt") Then
            MessageBox.Show("Arquivo vazio!", "Arquivo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ReDim aNome(0)

        Else
            Ler_arquivo()
            Ordenacao()

        End If

    End Sub

    Private Sub Ler_arquivo() 'Ler arquivo de texto responsável por salvar os dados gravados.
        Dim Leitor As StreamReader

        Leitor = My.Computer.FileSystem.OpenTextFileReader("D:\RENATO\Projetos\Sistemas\VisualBasic\Sistema_Cadastro\contatos.txt")

        Dim cont As Integer = 0

        While Not Leitor.EndOfStream
            Dim vstrlinha As String = Leitor.ReadLine() 'Vai trazer as informações tudo numa linha só

            Dim vNome As String = vstrlinha.Substring(1, 30) 'Organiza as informações no Grid que serão armazenadas no arquivo .txt
            Dim vCodigo As String = vstrlinha.Substring(31, 5)
            Dim vEnd As String = vstrlinha.Substring(36, 70)
            Dim vComp As String = vstrlinha.Substring(107, 50)
            Dim vBairro As String = vstrlinha.Substring(158, 50)
            Dim vCEP As String = vstrlinha.Substring(209, 15)
            Dim vCidade As String = vstrlinha.Substring(225, 50)
            Dim vUF As String = vstrlinha.Substring(276, 2)
            Dim vCPF As String = vstrlinha.Substring(279, 14)
            Dim vCelular As String = vstrlinha.Substring(294, 15)
            Dim vComercial As String = vstrlinha.Substring(310, 15)
            Dim vContato As String = vstrlinha.Substring(325, 14)
            Dim vNascimento As String = vstrlinha.Substring(340, 10)
            Dim vEmail As String = vstrlinha.Substring(351, 30)
            Dim vSexo As String = vstrlinha.Substring(382, 10)
            Dim vEscolaridade As String = vstrlinha.Substring(393, 20)
            Dim vInst As String = vstrlinha.Substring(414, 30)
            Dim vObs As String = vstrlinha.Substring(445, 1000)
            Dim vCadastro As String = vstrlinha.Substring(1446, 20)
            Dim vData As String = vstrlinha.Substring(1467, 10)

            '--------------------------------- CARREGA VETORES

            cont = cont + 1

            ReDim Preserve aNome(cont)
            ReDim Preserve aCodigo(cont)
            ReDim Preserve aEnd(cont)
            ReDim Preserve aComp(cont)
            ReDim Preserve aCEP(cont)
            ReDim Preserve aCidade(cont)
            ReDim Preserve aUF(cont)
            ReDim Preserve aCPF(cont)
            ReDim Preserve aCelular(cont)
            ReDim Preserve aComercial(cont)
            ReDim Preserve aContato(cont)
            ReDim Preserve aNascimento(cont)
            ReDim Preserve aEmail(cont)
            ReDim Preserve aSexo(cont)
            ReDim Preserve aEscolaridade(cont)
            ReDim Preserve aInst(cont)
            ReDim Preserve aObs(cont)
            ReDim Preserve aCadastro(cont)
            ReDim Preserve aData(cont)

            aNome(cont) = vNome
            aCodigo(cont) = vCodigo
            aEnd(cont) = vEnd
            aComp(cont) = vComp
            aCEP(cont) = vCEP
            aCidade(cont) = vCidade
            aUF(cont) = vUF
            aCPF(cont) = vCPF
            aCelular(cont) = vCelular
            aComercial(cont) = vComercial
            aContato(cont) = vContato
            aNascimento(cont) = vNascimento
            aEmail(cont) = vEmail
            aSexo(cont) = vSexo
            aEscolaridade(cont) = vEscolaridade
            aInst(cont) = vInst
            aObs(cont) = vObs
            aCadastro(cont) = vCadastro
            aData(cont) = vData

            '------------------ CARREGA GRID

            dgvContatos.Rows.Add(vCodigo, vNome, vEnd, vComp, vCEP, vCidade, vUF, vCPF, vCelular, vComercial, vContato, vNascimento, vEmail, vSexo, vEscolaridade, vInst, vObs, vCadastro, vData)

        End While

        Leitor.Close()  'Fecha o leitor doarquivo .txt
        CarregaCampos() 'CarregaCampos (Criada na linha 208), substitui os códigos abaixo para receber os valores dos Arrays na posição (1).

        'Recebe o valor no Array na posição (1).

        'txtNome.Text = aNome(1)
        'txtCodigo.Text = aCodigo(1)
        'txtEnd.Text = aEnd(1)
        'txtComp.Text = aComp(1)
        'mtbCEP.Text = aCEP(1)
        'txtCidade.Text = aCidade(1)
        'txtUF.Text = aUF(1)
        'mtbCPF.Text = aCPF(1)
        'mtbCelular.Text = aCelular(1)
        'mtbComercial.Text = aComercial(1)
        'mtbContato.Text = aContato(1)
        'dtpNascimento.Text = aNascimento(1)
        'txtEmail.Text = aEmail(1)
        'cbSexo.Text = aSexo(1)
        'cbEscolaridade.Text = aEscolaridade(1)
        'txtInst.Text = aInst(1)
        'txtObs.Text = aObs(1)
        'cbCadastro.Text = aCadastro(1)
        'dtpData.Text = aData(1)

    End Sub

    Private Function CriticaCampos() 'Trata os campos de texto ao clicar Salvar.

        If txtNome.Text = "" Then
            MessageBox.Show("Nome não informado. Favor preencher.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNome.Focus()
            Return False

        End If

        If txtEnd.Text = "" Then
            MessageBox.Show("Endereço não informado. Favor preencher.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEnd.Focus()
            Return False

        End If

        If txtCidade.Text = "" Then
            MessageBox.Show("Cidade não informada. Favor preencher.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCidade.Focus()
            Return False

        End If

        If cbUF.Text = "" Then
            MessageBox.Show("UF não informada. Favor preencher.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUF.Focus()
            Return False

        End If

        If mtbCEP.Text = "" Then
            MessageBox.Show("CEP não informado. Favor preencher.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbCEP.Focus()
            Return False

        End If

        If cbSexo.Text = "" Then
            MessageBox.Show("Campo Sexo vazio. Favor preencher.", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSexo.Focus()
            Return False

        ElseIf cbSexo.Text <> "Masculino" And cbSexo.Text <> "Feminino" Then
            MessageBox.Show("Dado inválido. Favor escolher Masculino ou Feminino.", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbSexo.Focus()
            Return False

        End If

        If txtEmail.Text <> "" And Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("E-mail inválido. Favor preencher corretamente.", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False

        End If

        If cbCadastro.Text = "" Then
            MessageBox.Show("Campo Cadastro vazio. Favor preencher.", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCadastro.Focus()
            Return False

        ElseIf cbCadastro.Text <> "Médico" And cbCadastro.Text <> "Paciente" And cbCadastro.Text <> "Fornecedor" And cbCadastro.Text <> "Outros" Then
            MessageBox.Show("Dado inválido. Favor escolher opção correta.", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbCadastro.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub CarregaGrid()
        dgvContatos.Rows.Clear()

        For t = 1 To aNome.Length - 1

            If aNome(t).ToUpper.Contains(txtNomePesquisa.Text.ToUpper) Then
                dgvContatos.Rows.Add(aCodigo(t), aNome(t), aEnd(t), aComp(t), aCEP(t), aCidade(t), aUF(t), aCPF(t), aCelular(t), aComercial(t), aContato(t), aNascimento(t), aEmail(t), aSexo(t), aEscolaridade(t), aInst(t), aObs(t), aCadastro(t), aData(t))

            End If

        Next

        lblQtdRegistros.Text = "Registros encontrados  [" & aNome.Length - 1 & "]"

    End Sub

    'Private Sub CarregaGridCodigo()
    '    dgvContatos.Rows.Clear()

    '    For t = 1 To aNome.Length - 1

    '        If aNome(t).ToUpper.Contains(txtCodigoPesquisa.Text.ToUpper) Then
    '            dgvContatos.Rows.Add(aCodigo(t), aNome(t), aEnd(t), aComp(t), aCEP(t), aCidade(t), aUF(t), aCPF(t), aCelular(t), aComercial(t), aContato(t), aNascimento(t), aEmail(t), aSexo(t), aEscolaridade(t), aInst(t), aObs(t), aCadastro(t), aData(t))

    '        End If

    '    Next

    '    lblQtdRegistros.Text = "Registros encontrados : " & aNome.Length - 1

    'End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        lblStatus.Text = "[Registro salvo]"

        Dim RetornoCritica As Boolean = CriticaCampos()

        If RetornoCritica Then

            If vModo = "I" Then ' "I" do Botão Incluir.

                Dim Index As Integer = aNome.Length

                ReDim Preserve aNome(Index) 'Redimensiona todos os vetores.
                ReDim Preserve aCodigo(Index)
                ReDim Preserve aEnd(Index)
                ReDim Preserve aComp(Index)
                ReDim Preserve aBairro(Index)
                ReDim Preserve aCEP(Index)
                ReDim Preserve aCidade(Index)
                ReDim Preserve aUF(Index)
                ReDim Preserve aCPF(Index)
                ReDim Preserve aCelular(Index)
                ReDim Preserve aComercial(Index)
                ReDim Preserve aContato(Index)
                ReDim Preserve aNascimento(Index)
                ReDim Preserve aEmail(Index)
                ReDim Preserve aSexo(Index)
                ReDim Preserve aEscolaridade(Index)
                ReDim Preserve aInst(Index)
                ReDim Preserve aObs(Index)
                ReDim Preserve aCadastro(Index)
                ReDim Preserve aData(Index)

                aNome(Index) = txtNome.Text
                aCodigo(Index) = txtCodigo.Text
                aEnd(Index) = txtEnd.Text
                aComp(Index) = txtComp.Text
                aBairro(Index) = txtBairro.Text
                aCEP(Index) = mtbCEP.Text
                aCidade(Index) = txtCidade.Text
                aUF(Index) = cbUF.Text
                aCPF(Index) = mtbCPF.Text
                aCelular(Index) = mtbCelular.Text
                aComercial(Index) = mtbComercial.Text
                aContato(Index) = mtbContato.Text
                aNascimento(Index) = dtpNascimento.Text
                aEmail(Index) = txtEmail.Text
                aSexo(Index) = cbSexo.Text
                aEscolaridade(Index) = cbEscolaridade.Text
                aInst(Index) = txtInst.Text
                aObs(Index) = txtObs.Text
                aCadastro(Index) = cbCadastro.Text
                aData(Index) = dtpData.Text

                Ordenacao()

                MessageBox.Show("Registro incluído com sucesso.", "Incluir registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            If vModo = "A" Then ' "A" do Botão Alterar.

                Dim Index As Integer = dgvContatos.CurrentRow.Index + 1

                aNome(Index) = txtNome.Text
                aCodigo(Index) = txtCodigo.Text
                aEnd(Index) = txtEnd.Text
                aComp(Index) = txtComp.Text
                aBairro(Index) = txtBairro.Text
                aCEP(Index) = mtbCEP.Text
                aCidade(Index) = txtCidade.Text
                aUF(Index) = cbUF.Text
                aCPF(Index) = mtbCPF.Text
                aCelular(Index) = mtbCelular.Text
                aComercial(Index) = mtbComercial.Text
                aContato(Index) = mtbContato.Text
                aNascimento(Index) = dtpNascimento.Text
                aEmail(Index) = txtEmail.Text
                aSexo(Index) = cbSexo.Text
                aEscolaridade(Index) = cbEscolaridade.Text
                aInst(Index) = txtInst.Text
                aObs(Index) = txtObs.Text
                aCadastro(Index) = cbCadastro.Text
                aData(Index) = dtpData.Text

                dgvContatos.Item(0, Index - 1).Value = txtNome.Text 'Redimensiona a Grid.
                dgvContatos.Item(1, Index - 1).Value = txtCodigo.Text
                dgvContatos.Item(2, Index - 1).Value = txtEnd.Text
                dgvContatos.Item(3, Index - 1).Value = txtComp.Text
                dgvContatos.Item(4, Index - 1).Value = txtBairro.Text
                dgvContatos.Item(5, Index - 1).Value = mtbCEP.Text
                dgvContatos.Item(6, Index - 1).Value = txtCidade.Text
                dgvContatos.Item(7, Index - 1).Value = cbUF.Text
                dgvContatos.Item(8, Index - 1).Value = mtbCPF.Text
                dgvContatos.Item(9, Index - 1).Value = mtbCelular.Text
                dgvContatos.Item(10, Index - 1).Value = mtbComercial.Text
                dgvContatos.Item(11, Index - 1).Value = mtbContato.Text
                dgvContatos.Item(12, Index - 1).Value = dtpNascimento.Text
                dgvContatos.Item(13, Index - 1).Value = txtEmail.Text
                dgvContatos.Item(14, Index - 1).Value = cbSexo.Text
                dgvContatos.Item(15, Index - 1).Value = cbEscolaridade.Text
                dgvContatos.Item(16, Index - 1).Value = txtInst.Text
                dgvContatos.Item(17, Index - 1).Value = txtObs.Text
                dgvContatos.Item(18, Index - 1).Value = cbCadastro.Text
                dgvContatos.Item(19, Index - 1).Value = dtpData.Text

                Ordenacao()

            End If

            'If vModo = "E" Then ' "E" do Botão Excluir.

            '    Dim Index As Integer = dgvContatos.CurrentRow.Index + 1

            '    For t = 1 To aNome.Length - 1

            '        If t > Index Then

            '            aNome(t - 1) = aNome(t)
            '            aCodigo(t - 1) = aCodigo(t)
            '            aEnd(t - 1) = aEnd(t)
            '            aComp(t - 1) = aComp(t)
            '            aCEP(t - 1) = aCEP(t)
            '            aCidade(t - 1) = aCidade(t)
            '            aUF(t - 1) = aUF(t)
            '            aCPF(t - 1) = aCPF(t)
            '            aCelular(t - 1) = aCelular(t)
            '            aComercial(t - 1) = aComercial(t)
            '            aContato(t - 1) = aContato(t)
            '            aNascimento(t - 1) = aNascimento(t)
            '            aEmail(t - 1) = aEmail(t)
            '            aSexo(t - 1) = aSexo(t)
            '            aEscolaridade(t - 1) = aEscolaridade(t)
            '            aInst(t - 1) = aInst(t)
            '            aObs(t - 1) = aObs(t)
            '            aCadastro(t - 1) = aCadastro(t)
            '            aData(t - 1) = aData(t)

            '        End If

            '    Next

            '    Dim Index2 As Integer = aNome.Length - 2

            '    ReDim Preserve aNome(Index2) 'Redimensiona todos os vetores.
            '    ReDim Preserve aCodigo(Index2)
            '    ReDim Preserve aEnd(Index2)
            '    ReDim Preserve aComp(Index2)
            '    ReDim Preserve aCEP(Index2)
            '    ReDim Preserve aCidade(Index2)
            '    ReDim Preserve aUF(Index2)
            '    ReDim Preserve aCPF(Index2)
            '    ReDim Preserve aCelular(Index2)
            '    ReDim Preserve aComercial(Index2)
            '    ReDim Preserve aContato(Index2)
            '    ReDim Preserve aNascimento(Index2)
            '    ReDim Preserve aEmail(Index2)
            '    ReDim Preserve aSexo(Index2)
            '    ReDim Preserve aEscolaridade(Index2)
            '    ReDim Preserve aInst(Index2)
            '    ReDim Preserve aObs(Index2)
            '    ReDim Preserve aCadastro(Index2)
            '    ReDim Preserve aData(Index2)

            '    CarregaGrid()

            'End If

        End If

        vModo = "X"
        DesabilitaCampos()
        GravaArquivo()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'If dgvContatos.CurrentRow.Index = "" Then

        '    DesabilitaCampos()

        '    'txtCodigo.Text = ""
        '    'txtNome.Text = ""
        '    'txtEnd.Text = ""
        '    'txtComp.Text = ""
        '    'mtbCEP.Text = ""
        '    'txtCidade.Text = ""
        '    'txtUF.Text = ""
        '    'mtbCPF.Text = ""
        '    'mtbCelular.Text = ""
        '    'mtbComercial.Text = ""
        '    'mtbContato.Text = ""
        '    'dtpNascimento.Text = Now
        '    'txtEmail.Text = ""
        '    'cbSexo.Text = ""
        '    'cbEscolaridade.Text = ""
        '    'txtInst.Text = ""
        '    'txtObs.Text = ""
        '    'cbCadastro.Text = ""
        '    'dtpData.Text = Now

        '    'txtCodigo.Focus()

        'Else
        DesabilitaCampos()
        CarregaCampos()

        'End If

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        vModo = "I"
        lblStatus.Text = "[Incluir registro]"
        HabilitaCampos()

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEnd.Text = ""
        txtComp.Text = ""
        txtBairro.Text = ""
        mtbCEP.Text = ""
        txtCidade.Text = ""
        cbUF.Text = ""
        mtbCPF.Text = ""
        mtbCelular.Text = ""
        mtbComercial.Text = ""
        mtbContato.Text = ""
        dtpNascimento.Text = Now
        txtEmail.Text = ""
        cbSexo.Text = ""
        cbEscolaridade.Text = ""
        txtInst.Text = ""
        txtObs.Text = ""
        cbCadastro.Text = ""
        dtpData.Text = Now

        txtCodigo.Focus()

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        vModo = "A"
        lblStatus.Text = "[Alterar registro]"
        HabilitaCampos()
        txtCodigo.Focus()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If vModo = "E" Then ' "E" do Botão Excluir.
            lblStatus.Text = "[Excluir registro]"
            HabilitaCampos()
            MessageBox.Show("Tem certeza que deseja excluir o registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If MsgBoxResult.Yes Then
                MessageBox.Show("Registro excluido com sucesso!", "Registro excluído", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'If vModo = "E" Then ' "E" do Botão Excluir.

                Dim Index As Integer = dgvContatos.CurrentRow.Index + 1

                For t = 1 To aNome.Length - 1

                    If t > Index Then

                        aNome(t - 1) = aNome(t)
                        aCodigo(t - 1) = aCodigo(t)
                        aEnd(t - 1) = aEnd(t)
                        aComp(t - 1) = aComp(t)
                        aBairro(t - 1) = aBairro(t)
                        aCEP(t - 1) = aCEP(t)
                        aCidade(t - 1) = aCidade(t)
                        aUF(t - 1) = aUF(t)
                        aCPF(t - 1) = aCPF(t)
                        aCelular(t - 1) = aCelular(t)
                        aComercial(t - 1) = aComercial(t)
                        aContato(t - 1) = aContato(t)
                        aNascimento(t - 1) = aNascimento(t)
                        aEmail(t - 1) = aEmail(t)
                        aSexo(t - 1) = aSexo(t)
                        aEscolaridade(t - 1) = aEscolaridade(t)
                        aInst(t - 1) = aInst(t)
                        aObs(t - 1) = aObs(t)
                        aCadastro(t - 1) = aCadastro(t)
                        aData(t - 1) = aData(t)

                    End If

                Next

                Dim Index2 As Integer = aNome.Length - 2

                ReDim Preserve aNome(Index2) 'Redimensiona todos os vetores.
                ReDim Preserve aCodigo(Index2)
                ReDim Preserve aEnd(Index2)
                ReDim Preserve aComp(Index2)
                ReDim Preserve aBairro(Index2)
                ReDim Preserve aCEP(Index2)
                ReDim Preserve aCidade(Index2)
                ReDim Preserve aUF(Index2)
                ReDim Preserve aCPF(Index2)
                ReDim Preserve aCelular(Index2)
                ReDim Preserve aComercial(Index2)
                ReDim Preserve aContato(Index2)
                ReDim Preserve aNascimento(Index2)
                ReDim Preserve aEmail(Index2)
                ReDim Preserve aSexo(Index2)
                ReDim Preserve aEscolaridade(Index2)
                ReDim Preserve aInst(Index2)
                ReDim Preserve aObs(Index2)
                ReDim Preserve aCadastro(Index2)
                ReDim Preserve aData(Index2)

                CarregaGrid()

            End If

            vModo = "X"
            DesabilitaCampos()
            GravaArquivo()

        End If

        If MsgBoxResult.No Then

            DesabilitaCampos()

        End If

        'vModo = "E"
        'HabilitaCampos()
        'MessageBox.Show("Tem certeza que deseja excluir o registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If MsgBoxResult.Yes Then
        '    MessageBox.Show("Registro excluido com sucesso!", "Registro excluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    CarregaGrid()
        '    DesabilitaCampos()

        'End If

        'If MsgBoxResult.No Then
        '    CarregaGrid()
        '    DesabilitaCampos()

        'End If

    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click

        frmMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        lblStatus.Text = "[Limpar campos]"
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEnd.Text = ""
        txtComp.Text = ""
        txtBairro.Text = ""
        mtbCEP.Text = ""
        txtCidade.Text = ""
        cbUF.Text = ""
        mtbCPF.Text = ""
        mtbCelular.Text = ""
        mtbComercial.Text = ""
        mtbContato.Text = ""
        dtpNascimento.Text = Now
        txtEmail.Text = ""
        cbSexo.Text = ""
        cbEscolaridade.Text = ""
        txtInst.Text = ""
        txtObs.Text = ""
        cbCadastro.Text = ""
        dtpData.Text = Now

        txtCodigo.Focus()

    End Sub

    Private Sub btnLimpar2_Click(sender As Object, e As EventArgs) Handles btnLimpar2.Click

        lblStatus.Text = "[Limpar pesquisa]"
        txtCodigoPesquisa.Text = ""
        txtNomePesquisa.Text = ""
        txtNomePesquisa.Focus()

    End Sub

    Private Sub HabilitaCampos() 'Ao clicar no botão alterar, os campos que estavam desabilitados, serão habilitados para alteração.

        lblCodigoPesquisa.Enabled = False
        txtCodigoPesquisa.Enabled = False

        lblNomePesquisa.Enabled = False
        txtNomePesquisa.Enabled = False

        lblCodigo.Enabled = True
        txtCodigo.Enabled = True

        lblNome.Enabled = True
        txtNome.Enabled = True

        lblEnd.Enabled = True
        txtEnd.Enabled = True

        lblComp.Enabled = True
        txtComp.Enabled = True

        lblBairro.Enabled = True
        txtBairro.Enabled = True

        lblCEP.Enabled = True
        mtbCEP.Enabled = True

        lblCidade.Enabled = True
        txtCidade.Enabled = True

        lblUF.Enabled = True
        cbUF.Enabled = True

        lblCPF.Enabled = True
        mtbCPF.Enabled = True

        lblCelular.Enabled = True
        mtbCelular.Enabled = True

        lblComercial.Enabled = True
        mtbComercial.Enabled = True

        lblContato.Enabled = True
        mtbContato.Enabled = True

        lblNascimento.Enabled = True
        dtpNascimento.Enabled = True

        lblEmail.Enabled = True
        txtEmail.Enabled = True

        lblSexo.Enabled = True
        cbSexo.Enabled = True

        lblEscolaridade.Enabled = True
        cbEscolaridade.Enabled = True

        lblInst.Enabled = True
        txtInst.Enabled = True

        lblObs.Enabled = True
        txtObs.Enabled = True

        lblCadastro.Enabled = True
        cbCadastro.Enabled = True

        lblData.Enabled = True
        dtpData.Enabled = True

        '---------------- Botões

        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
        btnLimpar.Enabled = True
        btnIncluir.Enabled = False
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnLimpar2.Enabled = False

    End Sub

    Private Sub DesabilitaCampos() 'Os campos e botões Salvar, Cancelar estarão desabilitados, enquanto os botões Incluir, Alterar e Excluir serão habilitados.

        lblCodigoPesquisa.Enabled = True
        txtCodigoPesquisa.Enabled = True

        lblNomePesquisa.Enabled = True
        txtNomePesquisa.Enabled = True

        lblCodigo.Enabled = False
        txtCodigo.Enabled = False

        lblNome.Enabled = False
        txtNome.Enabled = False

        lblEnd.Enabled = False
        txtEnd.Enabled = False

        lblComp.Enabled = False
        txtComp.Enabled = False

        lblBairro.Enabled = False
        txtBairro.Enabled = False

        lblCEP.Enabled = False
        mtbCEP.Enabled = False

        lblCidade.Enabled = False
        txtCidade.Enabled = False

        lblUF.Enabled = False
        cbUF.Enabled = False

        lblCPF.Enabled = False
        mtbCPF.Enabled = False

        lblCelular.Enabled = False
        mtbCelular.Enabled = False

        lblComercial.Enabled = False
        mtbComercial.Enabled = False

        lblContato.Enabled = False
        mtbContato.Enabled = False

        lblNascimento.Enabled = False
        dtpNascimento.Enabled = False

        lblEmail.Enabled = False
        txtEmail.Enabled = False

        lblSexo.Enabled = False
        cbSexo.Enabled = False

        lblEscolaridade.Enabled = False
        cbEscolaridade.Enabled = False

        lblInst.Enabled = False
        txtInst.Enabled = False

        lblObs.Enabled = False
        txtObs.Enabled = False

        lblCadastro.Enabled = False
        cbCadastro.Enabled = False

        lblData.Enabled = False
        dtpData.Enabled = False

        '----------------- Botões

        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnLimpar.Enabled = False
        btnIncluir.Enabled = True
        btnAlterar.Enabled = True
        btnExcluir.Enabled = True
        btnLimpar2.Enabled = True

    End Sub

    'Private Sub DesabilitaCamposPesquisa() 'Ao clicar no botão alterar, os campos que estavam desabilitados, serão habilitados para alteração.

    '    lblCodigoPesquisa.Enabled = True
    '    txtCodigoPesquisa.Enabled = True

    '    lblNomePesquisa.Enabled = True
    '    txtNomePesquisa.Enabled = True

    '    lblCodigo.Enabled = False
    '    txtCodigo.Enabled = False

    '    lblNome.Enabled = False
    '    txtNome.Enabled = False

    '    lblEnd.Enabled = False
    '    txtEnd.Enabled = False

    '    lblComp.Enabled = False
    '    txtComp.Enabled = False

    '    lblCEP.Enabled = False
    '    mtbCEP.Enabled = False

    '    lblCidade.Enabled = False
    '    txtCidade.Enabled = False

    '    lblUF.Enabled = False
    '    txtUF.Enabled = False

    '    lblCPF.Enabled = False
    '    mtbCPF.Enabled = False

    '    lblCelular.Enabled = False
    '    mtbCelular.Enabled = False

    '    lblComercial.Enabled = False
    '    mtbComercial.Enabled = False

    '    lblContato.Enabled = False
    '    mtbContato.Enabled = False

    '    lblNascimento.Enabled = False
    '    dtpNascimento.Enabled = False

    '    lblEmail.Enabled = False
    '    txtEmail.Enabled = False

    '    lblSexo.Enabled = False
    '    cbSexo.Enabled = False

    '    lblEscolaridade.Enabled = False
    '    cbEscolaridade.Enabled = False

    '    lblInst.Enabled = False
    '    txtInst.Enabled = False

    '    lblObs.Enabled = False
    '    txtObs.Enabled = False

    '    lblCadastro.Enabled = False
    '    cbCadastro.Enabled = False

    '    lblData.Enabled = False
    '    dtpData.Enabled = False

    '    '----------------- Botões

    '    btnSalvar.Enabled = False
    '    btnCancelar.Enabled = True
    '    btnIncluir.Enabled = False
    '    btnAlterar.Enabled = False
    '    btnExcluir.Enabled = False

    'End Sub

    Private Sub dgvContatos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContatos.SelectionChanged

        CarregaCampos()
        DesabilitaCampos()

    End Sub

    Private Sub CarregaCampos()

        Dim Index As Integer = dgvContatos.CurrentRow.Index 'Ao clicar nas linhas da Grid as informações dos campos preenchidos vão mudar de acordo com os dados de cada cadastro.

        txtNome.Text = aNome(Index + 1).Trim 'Trim serve para eliminar espaços vazios nos campos de texto.
        txtCodigo.Text = aCodigo(Index + 1)
        txtEnd.Text = aEnd(Index + 1).Trim
        txtComp.Text = aComp(Index + 1).Trim
        txtBairro.Text = aComp(Index + 1).Trim
        mtbCEP.Text = aCEP(Index + 1)
        txtCidade.Text = aCidade(Index + 1).Trim
        cbUF.Text = aUF(Index + 1)
        mtbCPF.Text = aCPF(Index + 1)
        mtbCelular.Text = aCelular(Index + 1)
        mtbComercial.Text = aComercial(Index + 1)
        mtbContato.Text = aContato(Index + 1)
        dtpNascimento.Text = aNascimento(Index + 1)
        txtEmail.Text = aEmail(Index + 1).Trim
        cbSexo.Text = aSexo(Index + 1)
        cbEscolaridade.Text = aEscolaridade(Index + 1).Trim
        txtInst.Text = aInst(Index + 1).Trim
        txtObs.Text = aObs(Index + 1).Trim
        cbCadastro.Text = aCadastro(Index + 1)
        dtpData.Text = aData(Index + 1)

    End Sub

    Private Sub Ordenacao() 'Ordena por ordem alfabética. Usado ao carregar o formulário e após incluir um registro.

        Dim vMudou As Boolean

        Dim vNome As String
        Dim vCodigo As String
        Dim vEnd As String
        Dim vComp As String
        Dim vBairro As String
        Dim vCEP As String
        Dim vCidade As String
        Dim vUF As String
        Dim vCPF As String
        Dim vCelular As String
        Dim vComercial As String
        Dim vContato As String
        Dim vNascimento As String
        Dim vEmail As String
        Dim vSexo As String
        Dim vEscolaridade As String
        Dim vInst As String
        Dim vObs As String
        Dim vCadastro As String
        Dim vData As String

        vMudou = True

        While vMudou

            vMudou = False

            For t = 1 To aNome.Length - 2

                If aNome(t + 1) < aNome(t) Then
                    vNome = aNome(t)
                    aNome(t) = aNome(t + 1)
                    aNome(t + 1) = vNome
                    vCodigo = aCodigo(t)
                    aCodigo(t) = aCodigo(t + 1)
                    aCodigo(t + 1) = vCodigo
                    vEnd = aEnd(t)
                    aEnd(t) = aEnd(t + 1)
                    aEnd(t + 1) = vEnd
                    vComp = aComp(t)
                    aComp(t) = aComp(t + 1)
                    aComp(t + 1) = vComp
                    vBairro = aBairro(t)
                    aBairro(t) = aBairro(t + 1)
                    aBairro(t + 1) = vBairro
                    vCEP = aCEP(t)
                    aCEP(t) = aCEP(t + 1)
                    aCEP(t + 1) = vCEP
                    vCidade = aCidade(t)
                    aCidade(t) = aCidade(t + 1)
                    aCidade(t + 1) = vCidade
                    vUF = aUF(t)
                    aUF(t) = aUF(t + 1)
                    aUF(t + 1) = vUF
                    vCPF = aCPF(t)
                    aCPF(t) = aCPF(t + 1)
                    aCPF(t + 1) = vCPF
                    vCelular = aCelular(t)
                    aCelular(t) = aCelular(t + 1)
                    aCelular(t + 1) = vCelular
                    vComercial = aComercial(t)
                    aComercial(t) = aComercial(t + 1)
                    aComercial(t + 1) = vComercial
                    vContato = aContato(t)
                    aContato(t) = aContato(t + 1)
                    aContato(t + 1) = vContato
                    vNascimento = aNascimento(t)
                    aNascimento(t) = aNascimento(t + 1)
                    aNascimento(t + 1) = vNascimento
                    vEmail = aEmail(t)
                    aEmail(t) = aEmail(t + 1)
                    aEmail(t + 1) = vEmail
                    vSexo = aSexo(t)
                    aSexo(t) = aSexo(t + 1)
                    aSexo(t + 1) = vSexo
                    vEscolaridade = aEscolaridade(t)
                    aEscolaridade(t) = aEscolaridade(t + 1)
                    aEscolaridade(t + 1) = vEscolaridade
                    vInst = aInst(t)
                    aInst(t) = aInst(t + 1)
                    aInst(t + 1) = vInst
                    vObs = aObs(t)
                    aObs(t) = aObs(t + 1)
                    aObs(t + 1) = vObs
                    vCadastro = aCadastro(t)
                    aCadastro(t) = aCadastro(t + 1)
                    aCadastro(t + 1) = vCadastro
                    vData = aData(t)
                    aData(t) = aData(t + 1)
                    aData(t + 1) = vData

                    vMudou = True

                End If

            Next

        End While

        CarregaGrid()

    End Sub

    Private Sub GravaArquivo()

        'If My.Computer.FileSystem.FileExists("D:\RENATO\Projetos\Sistemas\VisualBasic\Sistema_Cadastro\contatos.txt") Then
        '    'My.Computer.FileSystem.DeleteFile("D:\RENATO\Projetos\Sistemas\VisualBasic\Sistema_Cadastro\contatos.txt")

        'End If

        Dim Gravador As StreamWriter

        Gravador = My.Computer.FileSystem.OpenTextFileWriter("D:\RENATO\Projetos\Sistemas\VisualBasic\Sistema_Cadastro\contatos.txt", True)

        Dim vstrlinha As String = ""

        For t = 1 To aNome.Length - 1

            vstrlinha = (aNome(t).ToUpper & Space(30)).Substring(0, 30)
            vstrlinha = vstrlinha & (aCodigo(t) & Space(5)).Substring(0, 5)
            vstrlinha = vstrlinha & (aEnd(t) & Space(70)).Substring(0, 70)
            vstrlinha = vstrlinha & (aComp(t) & Space(50)).Substring(0, 50)
            vstrlinha = vstrlinha & (aBairro(t) & Space(50)).Substring(0, 50)
            vstrlinha = vstrlinha & (aCEP(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aCidade(t) & Space(30)).Substring(0, 30)
            vstrlinha = vstrlinha & (aUF(t) & Space(2)).Substring(0, 2)
            vstrlinha = vstrlinha & (aCPF(t) & Space(14)).Substring(0, 14)
            vstrlinha = vstrlinha & (aCelular(t) & Space(15)).Substring(0, 15)
            vstrlinha = vstrlinha & (aComercial(t) & Space(14)).Substring(0, 14)
            vstrlinha = vstrlinha & (aContato(t) & Space(15)).Substring(0, 15)
            vstrlinha = vstrlinha & (aNascimento(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aEmail(t).ToLower & Space(30)).Substring(0, 30)
            vstrlinha = vstrlinha & (aSexo(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aEscolaridade(t) & Space(20)).Substring(0, 20)
            vstrlinha = vstrlinha & (aInst(t) & Space(30)).Substring(0, 30)
            vstrlinha = vstrlinha & (aObs(t) & Space(1000)).Substring(0, 1000)
            vstrlinha = vstrlinha & (aCadastro(t) & Space(20)).Substring(0, 20)
            vstrlinha = vstrlinha & (aData(t) & Space(10)).Substring(0, 10)

            Gravador.WriteLine(vstrlinha)

        Next

        Gravador.Close()

    End Sub

    Private Sub txtNomePesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtNomePesquisa.TextChanged

        CarregaGrid()
        'DesabilitaCamposPesquisa()

    End Sub

    'Private Sub txtCodigoPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoPesquisa.TextChanged

    '    CarregaGridCodigo()
    '    DesabilitaCamposPesquisa()

    'End Sub

End Class



'CÓDIGOS DO CURSO (VÍDEOS 15 - 21)



'Imports System.IO

'Public Class Agenda
'    Dim anome(0) As String
'    Dim aTelRes(0) As String
'    Dim aTelCel(0) As String
'    Dim aDatNasc(0) As String
'    Dim aDatCadastro(0) As String
'    Dim aReferencia(0) As String
'    Dim aSexo(0) As String
'    Dim aemail(0) As String
'    Dim vModo As String = "X"

'    Private Sub Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        If Not My.Computer.FileSystem.FileExists("c:\temp\contatos.txt") Then
'            MessageBox.Show("Arquivo Vazio!", "Arquivo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'            ReDim anome(0)
'        Else
'            le_arquivo()
'            ordenacao()
'        End If
'    End Sub

'    Private Sub le_arquivo()
'        Dim Leitor As StreamReader
'        Leitor = My.Computer.FileSystem.OpenTextFileReader("c:\temp\contatos.txt")
'        Dim cont As Integer = 0
'        While Not Leitor.EndOfStream
'            Dim vstrlinha As String = Leitor.ReadLine()
'            Dim vnome As String = vstrlinha.Substring(0, 30)
'            Dim vTelRes As String = vstrlinha.Substring(30, 12)
'            Dim vTelCel As String = vstrlinha.Substring(42, 12)
'            Dim vDatNasc As String = vstrlinha.Substring(54, 10)
'            Dim vDatCadastro As String = vstrlinha.Substring(64, 10)
'            Dim vReferencia As String = vstrlinha.Substring(74, 10)
'            Dim vSexo As String = vstrlinha.Substring(84, 1)
'            Dim vemail As String = vstrlinha.Substring(85, 30)
'            '-----------------------Carrega vetores
'            cont = cont + 1
'            ReDim Preserve anome(cont)
'            ReDim Preserve aTelRes(cont)
'            ReDim Preserve aTelCel(cont)
'            ReDim Preserve aDatNasc(cont)
'            ReDim Preserve aDatCadastro(cont)
'            ReDim Preserve aReferencia(cont)
'            ReDim Preserve aSexo(cont)
'            ReDim Preserve aemail(cont)
'            anome(cont) = vnome
'            aTelRes(cont) = vTelRes
'            aTelCel(cont) = vTelCel
'            aDatNasc(cont) = vDatNasc
'            aDatCadastro(cont) = vDatCadastro
'            aReferencia(cont) = vReferencia
'            aSexo(cont) = vSexo
'            aemail(cont) = vemail
'            '------------------------carrega grid
'            dgvGridContatos.Rows.Add(vnome, vReferencia, vTelRes)
'            'dgvGridContatos.CurrentCell = dgvGridContatos(1, cont - 1)
'            'If vSexo = "F" Then
'            'dgvGridContatos.CurrentRow.DefaultCellStyle.BackColor = Color.Coral
'            'End If
'        End While
'        Leitor.Close()
'        carregacampos()
'    End Sub

'    Private Function criticampos()
'        If cmbSexo.Text <> "M" And cmbSexo.Text <> "F" Then
'            MessageBox.Show("Campo Sexo invalido!", "Erro de digitação", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            cmbSexo.Focus()
'            Return False
'        End If

'        If Not (txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".")) Then
'            MessageBox.Show("Campo e-mail invalido", "Erro de digitação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'            txtEmail.Focus()
'            Return False
'        End If
'        Return True
'    End Function

'    Private Sub carregagrid()
'        dgvGridContatos.Rows.Clear()
'        For t = 1 To anome.Length - 1
'            If anome(t).ToUpper.Contains(txtPesquisa.Text.ToUpper) Then
'                dgvGridContatos.Rows.Add(anome(t), aReferencia(t), aTelRes(t))
'            End If
'        Next
'        lblQtdRegistros.Text = "Qtd de Registros : " & anome.Length - 1
'    End Sub

'    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
'        Dim ret_critica As Boolean = criticampos()
'        If ret_critica Then
'            If vModo = "A" Then
'                Dim ind As Integer = dgvGridContatos.CurrentRow.Index + 1
'                anome(ind) = txtNome.Text
'                aTelCel(ind) = txtTelcel.Text
'                aTelRes(ind) = txtTelRes.Text
'                aDatCadastro(ind) = dtpDatCad.Text
'                aDatNasc(ind) = dtpDatNasc.Text
'                aReferencia(ind) = cmbRefer.Text
'                aSexo(ind) = cmbSexo.Text
'                aemail(ind) = txtEmail.Text
'                dgvGridContatos.Item(0, ind - 1).Value = txtNome.Text
'                dgvGridContatos.Item(1, ind - 1).Value = cmbRefer.Text
'                dgvGridContatos.Item(2, ind - 1).Value = txtTelRes.Text
'                ordenacao()
'            End If
'            If vModo = "I" Then
'                Dim ind As Integer = anome.Length
'                ReDim Preserve anome(ind)
'                ReDim Preserve aTelRes(ind)
'                ReDim Preserve aTelCel(ind)
'                ReDim Preserve aDatNasc(ind)
'                ReDim Preserve aDatCadastro(ind)
'                ReDim Preserve aReferencia(ind)
'                ReDim Preserve aSexo(ind)
'                ReDim Preserve aemail(ind)
'                anome(ind) = txtNome.Text
'                aTelCel(ind) = txtTelcel.Text
'                aTelRes(ind) = txtTelRes.Text
'                aDatCadastro(ind) = dtpDatCad.Text
'                aDatNasc(ind) = dtpDatNasc.Text
'                aReferencia(ind) = cmbRefer.Text
'                aSexo(ind) = cmbSexo.Text
'                aemail(ind) = txtEmail.Text
'                'dgvGridContatos.Rows.Add(txtNome.Text, cmbRefer.Text, txtTelRes.Text)
'                ordenacao()
'            End If
'            If vModo = "E" Then
'                Dim ind As Integer = dgvGridContatos.CurrentRow.Index + 1
'                For t = 1 To anome.Length - 1
'                    If t > ind Then
'                        anome(t - 1) = anome(t)
'                        aTelCel(t - 1) = aTelCel(t)
'                        aTelRes(t - 1) = aTelRes(t)
'                        aDatCadastro(t - 1) = aDatCadastro(t)
'                        aDatNasc(t - 1) = aDatNasc(t)
'                        aReferencia(t - 1) = aReferencia(t)
'                        aSexo(t - 1) = aSexo(t)
'                        aemail(t - 1) = aemail(t)
'                    End If
'                Next
'                Dim ind2 As Integer = anome.Length - 2
'                ReDim Preserve anome(ind2)
'                ReDim Preserve aTelRes(ind2)
'                ReDim Preserve aTelCel(ind2)
'                ReDim Preserve aDatNasc(ind2)
'                ReDim Preserve aDatCadastro(ind2)
'                ReDim Preserve aReferencia(ind2)
'                ReDim Preserve aSexo(ind2)
'                ReDim Preserve aemail(ind2)
'                carregagrid()
'            End If
'            vModo = "X"
'            Deshabcampos()
'            gravaarquivo()
'        End If
'    End Sub

'    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
'        vModo = "A"
'        habcampos()
'    End Sub

'    Private Sub habcampos()
'        txtNome.Enabled = True
'        txtEmail.Enabled = True
'        txtTelcel.Enabled = True
'        txtTelRes.Enabled = True
'        dtpDatCad.Enabled = True
'        dtpDatNasc.Enabled = True
'        cmbRefer.Enabled = True
'        cmbSexo.Enabled = True
'        '------------------------
'        btnIncluir.Enabled = False
'        btnAlterar.Enabled = False
'        btn_excluir.Enabled = False
'        btnConfirmar.Enabled = True
'        btnCancelar.Enabled = True
'    End Sub
'    Private Sub Deshabcampos()
'        txtNome.Enabled = False
'        txtEmail.Enabled = False
'        txtTelcel.Enabled = False
'        txtTelRes.Enabled = False
'        dtpDatCad.Enabled = False
'        dtpDatNasc.Enabled = False
'        cmbRefer.Enabled = False
'        cmbSexo.Enabled = False
'        '------------------------
'        btnIncluir.Enabled = True
'        btnAlterar.Enabled = True
'        btn_excluir.Enabled = True
'        btnConfirmar.Enabled = False
'        btnCancelar.Enabled = False
'    End Sub

'    Private Sub dgvGridContatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvGridContatos.SelectionChanged
'        carregacampos()
'        Deshabcampos()
'    End Sub
'    Private Sub carregacampos()
'        'If anome.Length > 1 Then
'        Dim ind As Integer = dgvGridContatos.CurrentRow.Index
'        txtNome.Text = anome(ind + 1).Trim
'        txtEmail.Text = aemail(ind + 1).Trim
'        txtTelcel.Text = aTelCel(ind + 1)
'        txtTelRes.Text = aTelRes(ind + 1)
'        cmbRefer.Text = aReferencia(ind + 1)
'        cmbSexo.Text = aSexo(ind + 1)
'        dtpDatCad.Value = aDatCadastro(ind + 1)
'        dtpDatNasc.Value = aDatNasc(ind + 1)
'        'End If

'    End Sub

'    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
'        vModo = "I"
'        habcampos()
'        txtNome.Text = ""
'        txtEmail.Text = ""
'        txtTelcel.Text = ""
'        txtTelRes.Text = ""
'        cmbRefer.Text = ""
'        cmbSexo.Text = ""
'        dtpDatCad.Value = Now
'        dtpDatNasc.Value = Now
'    End Sub

'    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
'        Deshabcampos()
'        carregacampos()
'    End Sub

'    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
'        vModo = "E"
'        habcampos()
'        MessageBox.Show("Para Excluir clique em Confirmar!", "Excluir Registro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
'    End Sub

'    Private Sub ordenacao()
'        Dim vmudou As Boolean
'        Dim vnome As String
'        Dim vTelRes As String
'        Dim vTelCel As String
'        Dim vDatNasc As String
'        Dim vDatCadastro As String
'        Dim vReferencia As String
'        Dim vSexo As String
'        Dim vemail As String

'        vmudou = True
'        While vmudou
'            vmudou = False
'            For t = 1 To anome.Length - 2
'                If anome(t + 1) < anome(t) Then
'                    vnome = anome(t)
'                    anome(t) = anome(t + 1)
'                    anome(t + 1) = vnome
'                    vTelRes = aTelRes(t)
'                    aTelRes(t) = aTelRes(t + 1)
'                    aTelRes(t + 1) = vTelRes
'                    vTelCel = aTelCel(t)
'                    aTelCel(t) = aTelCel(t + 1)
'                    aTelCel(t + 1) = vTelCel
'                    vDatNasc = aDatNasc(t)
'                    aDatNasc(t) = aDatNasc(t + 1)
'                    aDatNasc(t + 1) = vDatNasc
'                    vDatCadastro = aDatCadastro(t)
'                    aDatCadastro(t) = aDatCadastro(t + 1)
'                    aDatCadastro(t + 1) = vDatCadastro
'                    vReferencia = aReferencia(t)
'                    aReferencia(t) = aReferencia(t + 1)
'                    aReferencia(t + 1) = vReferencia
'                    vSexo = aSexo(t)
'                    aSexo(t) = aSexo(t + 1)
'                    aSexo(t + 1) = vSexo
'                    vemail = aemail(t)
'                    aemail(t) = aemail(t + 1)
'                    aemail(t + 1) = vemail
'                    vmudou = True
'                End If
'            Next
'        End While
'        carregagrid()
'    End Sub

'    Private Sub gravaarquivo()

'        If My.Computer.FileSystem.FileExists("c:\temp\contatos.txt") Then

'            My.Computer.FileSystem.DeleteFile("c:\temp\contatos.txt")

'        End If

'        Dim gravador As StreamWriter

'        gravador = My.Computer.FileSystem.OpenTextFileWriter("c:\temp\contatos.txt", True)

'        Dim vstrlinha As String = ""

'        For t = 1 To anome.Length - 1

'            vstrlinha = (anome(t).ToUpper & Space(30)).Substring(0, 30)
'            vstrlinha = vstrlinha & (aTelRes(t) & Space(12)).Substring(0, 12)
'            vstrlinha = vstrlinha & (aTelCel(t) & Space(12)).Substring(0, 12)
'            vstrlinha = vstrlinha & (aDatNasc(t) & Space(10)).Substring(0, 10)
'            vstrlinha = vstrlinha & (aDatCadastro(t) & Space(10)).Substring(0, 10)
'            vstrlinha = vstrlinha & (aReferencia(t) & Space(10)).Substring(0, 10)
'            vstrlinha = vstrlinha & (aSexo(t) & Space(1)).Substring(0, 1)
'            vstrlinha = vstrlinha & (aemail(t).ToLower & Space(40)).Substring(0, 40)

'            gravador.WriteLine(vstrlinha)

'        Next

'        gravador.Close()

'    End Sub

'    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
'        carregagrid()

'    End Sub
'End Class