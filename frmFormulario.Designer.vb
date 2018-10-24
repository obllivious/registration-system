<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulario))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblContato = New System.Windows.Forms.Label()
        Me.mtbContato = New System.Windows.Forms.MaskedTextBox()
        Me.lblNascimento = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.mtbCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.cbUF = New System.Windows.Forms.ComboBox()
        Me.mtbCPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.dtpNascimento = New System.Windows.Forms.DateTimePicker()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblComercial = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.mtbComercial = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCelular = New System.Windows.Forms.MaskedTextBox()
        Me.lblEscolaridade = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dgvContatos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENDERECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPLEMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMERCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTATO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NASCIMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESCOLARIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTITUICAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CADASTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtCodigoPesquisa = New System.Windows.Forms.TextBox()
        Me.lblCodigoPesquisa = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.cbCadastro = New System.Windows.Forms.ComboBox()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.lblNomePesquisa = New System.Windows.Forms.Label()
        Me.txtNomePesquisa = New System.Windows.Forms.TextBox()
        Me.gbPesquisa = New System.Windows.Forms.GroupBox()
        Me.btnLimpar2 = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.ststRegistros = New System.Windows.Forms.StatusStrip()
        Me.lblQtdRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.ststStatus = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.cbEscolaridade = New System.Windows.Forms.ComboBox()
        CType(Me.dgvContatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPesquisa.SuspendLayout()
        Me.ststRegistros.SuspendLayout()
        Me.ststStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(101, 399)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(432, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblContato
        '
        Me.lblContato.AutoSize = True
        Me.lblContato.Enabled = False
        Me.lblContato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblContato.Location = New System.Drawing.Point(200, 336)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(44, 13)
        Me.lblContato.TabIndex = 68
        Me.lblContato.Text = "Contato"
        '
        'mtbContato
        '
        Me.mtbContato.Enabled = False
        Me.mtbContato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mtbContato.Location = New System.Drawing.Point(203, 352)
        Me.mtbContato.Mask = "(000) 0 0000-0000"
        Me.mtbContato.Name = "mtbContato"
        Me.mtbContato.Size = New System.Drawing.Size(96, 20)
        Me.mtbContato.TabIndex = 9
        '
        'lblNascimento
        '
        Me.lblNascimento.AutoSize = True
        Me.lblNascimento.Enabled = False
        Me.lblNascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNascimento.Location = New System.Drawing.Point(536, 383)
        Me.lblNascimento.Name = "lblNascimento"
        Me.lblNascimento.Size = New System.Drawing.Size(63, 13)
        Me.lblNascimento.TabIndex = 55
        Me.lblNascimento.Text = "Nascimento"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(1164, 386)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 33)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Location = New System.Drawing.Point(1055, 386)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 33)
        Me.btnSalvar.TabIndex = 20
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Enabled = False
        Me.lblObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObs.Location = New System.Drawing.Point(727, 196)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(70, 13)
        Me.lblObs.TabIndex = 56
        Me.lblObs.Text = "Observações"
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Enabled = False
        Me.txtObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtObs.Location = New System.Drawing.Point(730, 212)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(534, 159)
        Me.txtObs.TabIndex = 17
        '
        'txtComp
        '
        Me.txtComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComp.Enabled = False
        Me.txtComp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtComp.Location = New System.Drawing.Point(101, 261)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(198, 20)
        Me.txtComp.TabIndex = 4
        '
        'txtEnd
        '
        Me.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnd.Enabled = False
        Me.txtEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEnd.Location = New System.Drawing.Point(101, 213)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(532, 20)
        Me.txtEnd.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Enabled = False
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(174, 167)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(459, 20)
        Me.txtNome.TabIndex = 2
        Me.txtNome.Tag = ""
        '
        'mtbCEP
        '
        Me.mtbCEP.Enabled = False
        Me.mtbCEP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mtbCEP.Location = New System.Drawing.Point(539, 261)
        Me.mtbCEP.Mask = "00.000-000"
        Me.mtbCEP.Name = "mtbCEP"
        Me.mtbCEP.Size = New System.Drawing.Size(94, 20)
        Me.mtbCEP.TabIndex = 5
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Enabled = False
        Me.lblComp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblComp.Location = New System.Drawing.Point(98, 245)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(71, 13)
        Me.lblComp.TabIndex = 53
        Me.lblComp.Text = "Complemento"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Enabled = False
        Me.lblEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnd.Location = New System.Drawing.Point(98, 197)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(53, 13)
        Me.lblEnd.TabIndex = 51
        Me.lblEnd.Text = "Endereço"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Enabled = False
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(171, 151)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 50
        Me.lblNome.Text = "Nome"
        '
        'cbUF
        '
        Me.cbUF.Enabled = False
        Me.cbUF.FormattingEnabled = True
        Me.cbUF.Items.AddRange(New Object() {"", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbUF.Location = New System.Drawing.Point(539, 306)
        Me.cbUF.Name = "cbUF"
        Me.cbUF.Size = New System.Drawing.Size(94, 21)
        Me.cbUF.TabIndex = 7
        '
        'mtbCPF
        '
        Me.mtbCPF.Enabled = False
        Me.mtbCPF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mtbCPF.Location = New System.Drawing.Point(539, 352)
        Me.mtbCPF.Mask = "000.000.000-00"
        Me.mtbCPF.Name = "mtbCPF"
        Me.mtbCPF.Size = New System.Drawing.Size(94, 20)
        Me.mtbCPF.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Enabled = False
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(98, 383)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 66
        Me.lblEmail.Text = "E-mail"
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Enabled = False
        Me.txtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCidade.Location = New System.Drawing.Point(101, 307)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(432, 20)
        Me.txtCidade.TabIndex = 6
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Enabled = False
        Me.lblCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCidade.Location = New System.Drawing.Point(98, 291)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 67
        Me.lblCidade.Text = "Cidade"
        '
        'dtpNascimento
        '
        Me.dtpNascimento.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpNascimento.Enabled = False
        Me.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNascimento.Location = New System.Drawing.Point(539, 399)
        Me.dtpNascimento.Name = "dtpNascimento"
        Me.dtpNascimento.Size = New System.Drawing.Size(94, 20)
        Me.dtpNascimento.TabIndex = 14
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Enabled = False
        Me.lblUF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUF.Location = New System.Drawing.Point(536, 290)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(21, 13)
        Me.lblUF.TabIndex = 65
        Me.lblUF.Text = "UF"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Enabled = False
        Me.lblCPF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCPF.Location = New System.Drawing.Point(536, 336)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(27, 13)
        Me.lblCPF.TabIndex = 64
        Me.lblCPF.Text = "CPF"
        '
        'lblComercial
        '
        Me.lblComercial.AutoSize = True
        Me.lblComercial.Enabled = False
        Me.lblComercial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblComercial.Location = New System.Drawing.Point(302, 336)
        Me.lblComercial.Name = "lblComercial"
        Me.lblComercial.Size = New System.Drawing.Size(53, 13)
        Me.lblComercial.TabIndex = 59
        Me.lblComercial.Text = "Comercial"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Enabled = False
        Me.lblCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCelular.Location = New System.Drawing.Point(98, 336)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 62
        Me.lblCelular.Text = "Celular"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Enabled = False
        Me.lblCEP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCEP.Location = New System.Drawing.Point(536, 245)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(28, 13)
        Me.lblCEP.TabIndex = 60
        Me.lblCEP.Text = "CEP"
        '
        'mtbComercial
        '
        Me.mtbComercial.Enabled = False
        Me.mtbComercial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mtbComercial.Location = New System.Drawing.Point(305, 352)
        Me.mtbComercial.Mask = "(000) 0000-0000"
        Me.mtbComercial.Name = "mtbComercial"
        Me.mtbComercial.Size = New System.Drawing.Size(96, 20)
        Me.mtbComercial.TabIndex = 10
        '
        'mtbCelular
        '
        Me.mtbCelular.BackColor = System.Drawing.SystemColors.Window
        Me.mtbCelular.Enabled = False
        Me.mtbCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mtbCelular.Location = New System.Drawing.Point(101, 352)
        Me.mtbCelular.Mask = "(000) 0 0000-0000"
        Me.mtbCelular.Name = "mtbCelular"
        Me.mtbCelular.Size = New System.Drawing.Size(96, 20)
        Me.mtbCelular.TabIndex = 8
        '
        'lblEscolaridade
        '
        Me.lblEscolaridade.AutoSize = True
        Me.lblEscolaridade.Enabled = False
        Me.lblEscolaridade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEscolaridade.Location = New System.Drawing.Point(727, 150)
        Me.lblEscolaridade.Name = "lblEscolaridade"
        Me.lblEscolaridade.Size = New System.Drawing.Size(68, 13)
        Me.lblEscolaridade.TabIndex = 66
        Me.lblEscolaridade.Text = "Escolaridade"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Enabled = False
        Me.lblSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSexo.Location = New System.Drawing.Point(404, 335)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 65
        Me.lblSexo.Text = "Sexo"
        '
        'cbSexo
        '
        Me.cbSexo.Enabled = False
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"", "Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(407, 351)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(126, 21)
        Me.cbSexo.TabIndex = 11
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Enabled = False
        Me.lblInst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInst.Location = New System.Drawing.Point(963, 149)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(55, 13)
        Me.lblInst.TabIndex = 76
        Me.lblInst.Text = "Instituição"
        '
        'txtInst
        '
        Me.txtInst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInst.Enabled = False
        Me.txtInst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtInst.Location = New System.Drawing.Point(966, 165)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(298, 20)
        Me.txtInst.TabIndex = 16
        '
        'dtpData
        '
        Me.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpData.Enabled = False
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(872, 398)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(88, 20)
        Me.dtpData.TabIndex = 19
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Enabled = False
        Me.lblData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblData.Location = New System.Drawing.Point(869, 382)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 55
        Me.lblData.Text = "Data"
        '
        'dgvContatos
        '
        Me.dgvContatos.AllowUserToAddRows = False
        Me.dgvContatos.AllowUserToDeleteRows = False
        Me.dgvContatos.AllowUserToResizeColumns = False
        Me.dgvContatos.AllowUserToResizeRows = False
        Me.dgvContatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOME, Me.ENDERECO, Me.COMPLEMENTO, Me.CEP, Me.CIDADE, Me.UF, Me.CPF, Me.CELULAR, Me.COMERCIAL, Me.CONTATO, Me.NASCIMENTO, Me.EMAIL, Me.SEXO, Me.ESCOLARIDADE, Me.INSTITUICAO, Me.OBSERVACAO, Me.CADASTRO, Me.DATA})
        Me.dgvContatos.Location = New System.Drawing.Point(101, 489)
        Me.dgvContatos.MultiSelect = False
        Me.dgvContatos.Name = "dgvContatos"
        Me.dgvContatos.RowHeadersVisible = False
        Me.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContatos.Size = New System.Drawing.Size(1163, 211)
        Me.dgvContatos.TabIndex = 25
        '
        'CODIGO
        '
        Me.CODIGO.FillWeight = 5.0!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CODIGO.ToolTipText = "Código Cadastrado"
        Me.CODIGO.Width = 60
        '
        'NOME
        '
        Me.NOME.HeaderText = "Nome"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        Me.NOME.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NOME.Width = 350
        '
        'ENDERECO
        '
        Me.ENDERECO.HeaderText = "Endereço"
        Me.ENDERECO.Name = "ENDERECO"
        Me.ENDERECO.ReadOnly = True
        Me.ENDERECO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ENDERECO.Width = 350
        '
        'COMPLEMENTO
        '
        Me.COMPLEMENTO.HeaderText = "Complemento"
        Me.COMPLEMENTO.Name = "COMPLEMENTO"
        Me.COMPLEMENTO.ReadOnly = True
        Me.COMPLEMENTO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COMPLEMENTO.Width = 300
        '
        'CEP
        '
        Me.CEP.HeaderText = "CEP"
        Me.CEP.Name = "CEP"
        Me.CEP.ReadOnly = True
        Me.CEP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CEP.Width = 80
        '
        'CIDADE
        '
        Me.CIDADE.HeaderText = "Cidade"
        Me.CIDADE.Name = "CIDADE"
        Me.CIDADE.ReadOnly = True
        Me.CIDADE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CIDADE.Width = 300
        '
        'UF
        '
        Me.UF.HeaderText = "UF"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        Me.UF.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UF.Width = 45
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        Me.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CPF.Width = 110
        '
        'CELULAR
        '
        Me.CELULAR.HeaderText = "Celular"
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        Me.CELULAR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CELULAR.Width = 110
        '
        'COMERCIAL
        '
        Me.COMERCIAL.HeaderText = "Comercial"
        Me.COMERCIAL.Name = "COMERCIAL"
        Me.COMERCIAL.ReadOnly = True
        Me.COMERCIAL.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COMERCIAL.Width = 110
        '
        'CONTATO
        '
        Me.CONTATO.HeaderText = "Contato"
        Me.CONTATO.Name = "CONTATO"
        Me.CONTATO.ReadOnly = True
        Me.CONTATO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CONTATO.Width = 110
        '
        'NASCIMENTO
        '
        Me.NASCIMENTO.HeaderText = "Nascimento"
        Me.NASCIMENTO.Name = "NASCIMENTO"
        Me.NASCIMENTO.ReadOnly = True
        Me.NASCIMENTO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "E-mail"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EMAIL.Width = 330
        '
        'SEXO
        '
        Me.SEXO.HeaderText = "Sexo"
        Me.SEXO.Name = "SEXO"
        Me.SEXO.ReadOnly = True
        Me.SEXO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SEXO.Width = 90
        '
        'ESCOLARIDADE
        '
        Me.ESCOLARIDADE.HeaderText = "Escolaridade"
        Me.ESCOLARIDADE.Name = "ESCOLARIDADE"
        Me.ESCOLARIDADE.ReadOnly = True
        Me.ESCOLARIDADE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ESCOLARIDADE.Width = 300
        '
        'INSTITUICAO
        '
        Me.INSTITUICAO.HeaderText = "Instituição"
        Me.INSTITUICAO.Name = "INSTITUICAO"
        Me.INSTITUICAO.ReadOnly = True
        Me.INSTITUICAO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.INSTITUICAO.Width = 300
        '
        'OBSERVACAO
        '
        Me.OBSERVACAO.HeaderText = "Observação"
        Me.OBSERVACAO.Name = "OBSERVACAO"
        Me.OBSERVACAO.ReadOnly = True
        Me.OBSERVACAO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OBSERVACAO.Width = 600
        '
        'CADASTRO
        '
        Me.CADASTRO.HeaderText = "Cadastro"
        Me.CADASTRO.Name = "CADASTRO"
        Me.CADASTRO.ReadOnly = True
        Me.CADASTRO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CADASTRO.Width = 120
        '
        'DATA
        '
        Me.DATA.HeaderText = "Data"
        Me.DATA.Name = "DATA"
        Me.DATA.ReadOnly = True
        Me.DATA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATA.Width = 80
        '
        'btnIncluir
        '
        Me.btnIncluir.BackColor = System.Drawing.Color.White
        Me.btnIncluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncluir.ForeColor = System.Drawing.Color.Black
        Me.btnIncluir.Location = New System.Drawing.Point(735, 37)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(103, 23)
        Me.btnIncluir.TabIndex = 22
        Me.btnIncluir.Text = "&Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.White
        Me.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(844, 37)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(103, 23)
        Me.btnAlterar.TabIndex = 23
        Me.btnAlterar.Text = "&Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Location = New System.Drawing.Point(953, 37)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(103, 23)
        Me.btnExcluir.TabIndex = 24
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'txtCodigoPesquisa
        '
        Me.txtCodigoPesquisa.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtCodigoPesquisa.Enabled = False
        Me.txtCodigoPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigoPesquisa.Location = New System.Drawing.Point(106, 42)
        Me.txtCodigoPesquisa.Name = "txtCodigoPesquisa"
        Me.txtCodigoPesquisa.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigoPesquisa.TabIndex = 27
        Me.txtCodigoPesquisa.Tag = ""
        '
        'lblCodigoPesquisa
        '
        Me.lblCodigoPesquisa.AutoSize = True
        Me.lblCodigoPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigoPesquisa.Location = New System.Drawing.Point(103, 26)
        Me.lblCodigoPesquisa.Name = "lblCodigoPesquisa"
        Me.lblCodigoPesquisa.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigoPesquisa.TabIndex = 50
        Me.lblCodigoPesquisa.Text = "Código"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Location = New System.Drawing.Point(1200, 37)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(69, 23)
        Me.btnSair.TabIndex = 26
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'cbCadastro
        '
        Me.cbCadastro.Enabled = False
        Me.cbCadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbCadastro.FormattingEnabled = True
        Me.cbCadastro.Items.AddRange(New Object() {"", "Médico", "Paciente", "Fornecedor", "Outros"})
        Me.cbCadastro.Location = New System.Drawing.Point(730, 397)
        Me.cbCadastro.Name = "cbCadastro"
        Me.cbCadastro.Size = New System.Drawing.Size(136, 21)
        Me.cbCadastro.TabIndex = 18
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Enabled = False
        Me.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCadastro.Location = New System.Drawing.Point(728, 381)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(67, 13)
        Me.lblCadastro.TabIndex = 78
        Me.lblCadastro.Text = "Cadastro de:"
        '
        'lblNomePesquisa
        '
        Me.lblNomePesquisa.AutoSize = True
        Me.lblNomePesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNomePesquisa.Location = New System.Drawing.Point(176, 26)
        Me.lblNomePesquisa.Name = "lblNomePesquisa"
        Me.lblNomePesquisa.Size = New System.Drawing.Size(35, 13)
        Me.lblNomePesquisa.TabIndex = 80
        Me.lblNomePesquisa.Text = "Nome"
        '
        'txtNomePesquisa
        '
        Me.txtNomePesquisa.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtNomePesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomePesquisa.Location = New System.Drawing.Point(179, 42)
        Me.txtNomePesquisa.Name = "txtNomePesquisa"
        Me.txtNomePesquisa.Size = New System.Drawing.Size(459, 20)
        Me.txtNomePesquisa.TabIndex = 28
        '
        'gbPesquisa
        '
        Me.gbPesquisa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPesquisa.Controls.Add(Me.btnExcluir)
        Me.gbPesquisa.Controls.Add(Me.txtNomePesquisa)
        Me.gbPesquisa.Controls.Add(Me.btnAlterar)
        Me.gbPesquisa.Controls.Add(Me.lblNomePesquisa)
        Me.gbPesquisa.Controls.Add(Me.btnIncluir)
        Me.gbPesquisa.Controls.Add(Me.txtCodigoPesquisa)
        Me.gbPesquisa.Controls.Add(Me.lblCodigoPesquisa)
        Me.gbPesquisa.Controls.Add(Me.btnLimpar2)
        Me.gbPesquisa.Controls.Add(Me.btnLimpar)
        Me.gbPesquisa.Controls.Add(Me.btnSair)
        Me.gbPesquisa.Location = New System.Drawing.Point(-8, 17)
        Me.gbPesquisa.Name = "gbPesquisa"
        Me.gbPesquisa.Size = New System.Drawing.Size(1383, 85)
        Me.gbPesquisa.TabIndex = 81
        Me.gbPesquisa.TabStop = False
        Me.gbPesquisa.Text = "       Pesquisa       "
        '
        'btnLimpar2
        '
        Me.btnLimpar2.BackColor = System.Drawing.Color.White
        Me.btnLimpar2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLimpar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnLimpar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnLimpar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar2.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar2.Location = New System.Drawing.Point(640, 42)
        Me.btnLimpar2.Name = "btnLimpar2"
        Me.btnLimpar2.Size = New System.Drawing.Size(37, 19)
        Me.btnLimpar2.TabIndex = 29
        Me.btnLimpar2.Text = "IR"
        Me.btnLimpar2.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(1125, 37)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(69, 23)
        Me.btnLimpar.TabIndex = 25
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'ststRegistros
        '
        Me.ststRegistros.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ststRegistros.Dock = System.Windows.Forms.DockStyle.None
        Me.ststRegistros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblQtdRegistros})
        Me.ststRegistros.Location = New System.Drawing.Point(98, 706)
        Me.ststRegistros.Name = "ststRegistros"
        Me.ststRegistros.Size = New System.Drawing.Size(158, 22)
        Me.ststRegistros.TabIndex = 82
        Me.ststRegistros.Text = "Registros"
        '
        'lblQtdRegistros
        '
        Me.lblQtdRegistros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQtdRegistros.LinkColor = System.Drawing.Color.Gray
        Me.lblQtdRegistros.Name = "lblQtdRegistros"
        Me.lblQtdRegistros.Size = New System.Drawing.Size(141, 17)
        Me.lblQtdRegistros.Text = "Registros Encontrados  [ ]"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(102, 167)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Tag = ""
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Enabled = False
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(98, 151)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 82
        Me.lblCodigo.Text = "Código"
        '
        'ststStatus
        '
        Me.ststStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ststStatus.Dock = System.Windows.Forms.DockStyle.None
        Me.ststStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.ststStatus.Location = New System.Drawing.Point(98, 461)
        Me.ststStatus.Name = "ststStatus"
        Me.ststStatus.Size = New System.Drawing.Size(70, 22)
        Me.ststStatus.TabIndex = 84
        Me.ststStatus.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.ActiveLinkColor = System.Drawing.Color.Black
        Me.lblStatus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStatus.LinkColor = System.Drawing.Color.Gray
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 17)
        Me.lblStatus.Text = "Status [ ]"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Enabled = False
        Me.lblBairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBairro.Location = New System.Drawing.Point(302, 245)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 53
        Me.lblBairro.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Enabled = False
        Me.txtBairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBairro.Location = New System.Drawing.Point(305, 261)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(228, 20)
        Me.txtBairro.TabIndex = 4
        '
        'cbEscolaridade
        '
        Me.cbEscolaridade.Enabled = False
        Me.cbEscolaridade.FormattingEnabled = True
        Me.cbEscolaridade.Items.AddRange(New Object() {"", "Analfabeto", "Fundamental Incompleto", "Fundamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Superior Incompleto", "Ensino Superior Completo", "Pós Graduação", "Mestrado", "Doutorado", "Não Especificado", "Outros"})
        Me.cbEscolaridade.Location = New System.Drawing.Point(731, 165)
        Me.cbEscolaridade.Name = "cbEscolaridade"
        Me.cbEscolaridade.Size = New System.Drawing.Size(229, 21)
        Me.cbEscolaridade.TabIndex = 7
        '
        'frmFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.ststStatus)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.ststRegistros)
        Me.Controls.Add(Me.dgvContatos)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.txtInst)
        Me.Controls.Add(Me.cbCadastro)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblContato)
        Me.Controls.Add(Me.mtbContato)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblNascimento)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.mtbCEP)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.cbEscolaridade)
        Me.Controls.Add(Me.cbUF)
        Me.Controls.Add(Me.mtbCPF)
        Me.Controls.Add(Me.lblEscolaridade)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.dtpNascimento)
        Me.Controls.Add(Me.lblUF)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblComercial)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.mtbComercial)
        Me.Controls.Add(Me.mtbCelular)
        Me.Controls.Add(Me.gbPesquisa)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormulario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário de Cadastro"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvContatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.ststRegistros.ResumeLayout(False)
        Me.ststRegistros.PerformLayout()
        Me.ststStatus.ResumeLayout(False)
        Me.ststStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblContato As Label
    Friend WithEvents mtbContato As MaskedTextBox
    Friend WithEvents lblNascimento As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents lblObs As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtComp As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents mtbCEP As MaskedTextBox
    Friend WithEvents lblComp As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents cbUF As ComboBox
    Friend WithEvents mtbCPF As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents dtpNascimento As DateTimePicker
    Friend WithEvents lblUF As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblComercial As Label
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblCEP As Label
    Friend WithEvents mtbComercial As MaskedTextBox
    Friend WithEvents mtbCelular As MaskedTextBox
    Friend WithEvents lblEscolaridade As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents lblInst As Label
    Friend WithEvents txtInst As TextBox
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents lblData As Label
    Friend WithEvents dgvContatos As DataGridView
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents txtCodigoPesquisa As TextBox
    Friend WithEvents lblCodigoPesquisa As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents cbCadastro As ComboBox
    Friend WithEvents lblCadastro As Label
    Friend WithEvents lblNomePesquisa As Label
    Friend WithEvents txtNomePesquisa As TextBox
    Friend WithEvents gbPesquisa As GroupBox
    Friend WithEvents ststRegistros As StatusStrip
    Friend WithEvents lblQtdRegistros As ToolStripStatusLabel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnLimpar2 As Button
    Friend WithEvents ststStatus As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents ENDERECO As DataGridViewTextBoxColumn
    Friend WithEvents COMPLEMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CEP As DataGridViewTextBoxColumn
    Friend WithEvents CIDADE As DataGridViewTextBoxColumn
    Friend WithEvents UF As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As DataGridViewTextBoxColumn
    Friend WithEvents COMERCIAL As DataGridViewTextBoxColumn
    Friend WithEvents CONTATO As DataGridViewTextBoxColumn
    Friend WithEvents NASCIMENTO As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents SEXO As DataGridViewTextBoxColumn
    Friend WithEvents ESCOLARIDADE As DataGridViewTextBoxColumn
    Friend WithEvents INSTITUICAO As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACAO As DataGridViewTextBoxColumn
    Friend WithEvents CADASTRO As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents cbEscolaridade As ComboBox
End Class
