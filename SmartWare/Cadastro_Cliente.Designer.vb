<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Cliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Cliente))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_UF = New System.Windows.Forms.TextBox()
        Me.TXT_Cidade = New System.Windows.Forms.TextBox()
        Me.TXT_Bairro = New System.Windows.Forms.TextBox()
        Me.TXT_Endereco = New System.Windows.Forms.TextBox()
        Me.TXT_Nome = New System.Windows.Forms.TextBox()
        Me.LBL_4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_Nascimento = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_Email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TXT_N_Endereco = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MST_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_Empresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MST_Celular = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MST_TelefoneCom = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MST_Telefone = New System.Windows.Forms.MaskedTextBox()
        Me.LBL_5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_Agencia = New System.Windows.Forms.TextBox()
        Me.TXT_Conta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMB_Banco = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_InfosAdic = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdimitirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjetosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrçamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TST_NomeLogado = New System.Windows.Forms.ToolStripTextBox()
        Me.TXT_Data = New System.Windows.Forms.ToolStripTextBox()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(231, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(422, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TXT_UF
        '
        Me.TXT_UF.Location = New System.Drawing.Point(85, 113)
        Me.TXT_UF.Name = "TXT_UF"
        Me.TXT_UF.ReadOnly = True
        Me.TXT_UF.Size = New System.Drawing.Size(100, 24)
        Me.TXT_UF.TabIndex = 8
        '
        'TXT_Cidade
        '
        Me.TXT_Cidade.Location = New System.Drawing.Point(272, 82)
        Me.TXT_Cidade.Name = "TXT_Cidade"
        Me.TXT_Cidade.ReadOnly = True
        Me.TXT_Cidade.Size = New System.Drawing.Size(125, 24)
        Me.TXT_Cidade.TabIndex = 7
        '
        'TXT_Bairro
        '
        Me.TXT_Bairro.Location = New System.Drawing.Point(85, 84)
        Me.TXT_Bairro.Name = "TXT_Bairro"
        Me.TXT_Bairro.ReadOnly = True
        Me.TXT_Bairro.Size = New System.Drawing.Size(121, 24)
        Me.TXT_Bairro.TabIndex = 6
        '
        'TXT_Endereco
        '
        Me.TXT_Endereco.Location = New System.Drawing.Point(85, 54)
        Me.TXT_Endereco.Name = "TXT_Endereco"
        Me.TXT_Endereco.ReadOnly = True
        Me.TXT_Endereco.Size = New System.Drawing.Size(242, 24)
        Me.TXT_Endereco.TabIndex = 5
        '
        'TXT_Nome
        '
        Me.TXT_Nome.Location = New System.Drawing.Point(77, 19)
        Me.TXT_Nome.Name = "TXT_Nome"
        Me.TXT_Nome.Size = New System.Drawing.Size(366, 24)
        Me.TXT_Nome.TabIndex = 1
        '
        'LBL_4
        '
        Me.LBL_4.AutoSize = True
        Me.LBL_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_4.Location = New System.Drawing.Point(5, 23)
        Me.LBL_4.Name = "LBL_4"
        Me.LBL_4.Size = New System.Drawing.Size(53, 16)
        Me.LBL_4.TabIndex = 11
        Me.LBL_4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Endereço:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Bairro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(212, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cidade:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "UF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(365, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Data de Nascimento:"
        '
        'TXT_Nascimento
        '
        Me.TXT_Nascimento.Location = New System.Drawing.Point(524, 101)
        Me.TXT_Nascimento.Mask = "00/00/0000"
        Me.TXT_Nascimento.Name = "TXT_Nascimento"
        Me.TXT_Nascimento.Size = New System.Drawing.Size(86, 24)
        Me.TXT_Nascimento.TabIndex = 9
        Me.TXT_Nascimento.ValidatingType = GetType(Date)
        '
        'TXT_CPF
        '
        Me.TXT_CPF.Location = New System.Drawing.Point(524, 22)
        Me.TXT_CPF.Mask = "000000000/00"
        Me.TXT_CPF.Name = "TXT_CPF"
        Me.TXT_CPF.Size = New System.Drawing.Size(86, 24)
        Me.TXT_CPF.TabIndex = 3
        '
        'TXT_Email
        '
        Me.TXT_Email.Location = New System.Drawing.Point(77, 98)
        Me.TXT_Email.Name = "TXT_Email"
        Me.TXT_Email.Size = New System.Drawing.Size(282, 24)
        Me.TXT_Email.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "E-Mail:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Location = New System.Drawing.Point(202, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Validar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXT_CEP)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.TXT_N_Endereco)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_Endereco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_UF)
        Me.GroupBox1.Controls.Add(Me.TXT_Bairro)
        Me.GroupBox1.Controls.Add(Me.TXT_Cidade)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 148)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localização"
        '
        'TXT_CEP
        '
        Me.TXT_CEP.Location = New System.Drawing.Point(85, 22)
        Me.TXT_CEP.Mask = "00000-000"
        Me.TXT_CEP.Name = "TXT_CEP"
        Me.TXT_CEP.Size = New System.Drawing.Size(100, 24)
        Me.TXT_CEP.TabIndex = 29
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(283, 25)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 18)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Não sabe o CEP?"
        '
        'TXT_N_Endereco
        '
        Me.TXT_N_Endereco.Location = New System.Drawing.Point(333, 54)
        Me.TXT_N_Endereco.Name = "TXT_N_Endereco"
        Me.TXT_N_Endereco.ReadOnly = True
        Me.TXT_N_Endereco.Size = New System.Drawing.Size(53, 24)
        Me.TXT_N_Endereco.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.MST_CNPJ)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TXT_Empresa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.MST_Celular)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.MST_TelefoneCom)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.MST_Telefone)
        Me.GroupBox2.Controls.Add(Me.LBL_5)
        Me.GroupBox2.Controls.Add(Me.TXT_Nome)
        Me.GroupBox2.Controls.Add(Me.LBL_4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXT_Email)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_CPF)
        Me.GroupBox2.Controls.Add(Me.TXT_Nascimento)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 177)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações pessoais"
        '
        'MST_CNPJ
        '
        Me.MST_CNPJ.Location = New System.Drawing.Point(496, 63)
        Me.MST_CNPJ.Mask = " 00.000.000/0000-00"
        Me.MST_CNPJ.Name = "MST_CNPJ"
        Me.MST_CNPJ.Size = New System.Drawing.Size(114, 24)
        Me.MST_CNPJ.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(420, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "CNPJ:"
        '
        'TXT_Empresa
        '
        Me.TXT_Empresa.Location = New System.Drawing.Point(77, 57)
        Me.TXT_Empresa.Name = "TXT_Empresa"
        Me.TXT_Empresa.Size = New System.Drawing.Size(337, 24)
        Me.TXT_Empresa.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Empresa:"
        '
        'MST_Celular
        '
        Me.MST_Celular.Location = New System.Drawing.Point(532, 137)
        Me.MST_Celular.Mask = "(00)00000-0000"
        Me.MST_Celular.Name = "MST_Celular"
        Me.MST_Celular.Size = New System.Drawing.Size(78, 24)
        Me.MST_Celular.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(438, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Celular:"
        '
        'MST_TelefoneCom
        '
        Me.MST_TelefoneCom.Location = New System.Drawing.Point(333, 137)
        Me.MST_TelefoneCom.Mask = "(00)0000-0000"
        Me.MST_TelefoneCom.Name = "MST_TelefoneCom"
        Me.MST_TelefoneCom.Size = New System.Drawing.Size(78, 24)
        Me.MST_TelefoneCom.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(181, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Telefone Comercial:"
        '
        'MST_Telefone
        '
        Me.MST_Telefone.Location = New System.Drawing.Point(77, 137)
        Me.MST_Telefone.Mask = "(00)0000-0000"
        Me.MST_Telefone.Name = "MST_Telefone"
        Me.MST_Telefone.Size = New System.Drawing.Size(78, 24)
        Me.MST_Telefone.TabIndex = 23
        '
        'LBL_5
        '
        Me.LBL_5.AutoSize = True
        Me.LBL_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_5.Location = New System.Drawing.Point(5, 140)
        Me.LBL_5.Name = "LBL_5"
        Me.LBL_5.Size = New System.Drawing.Size(74, 16)
        Me.LBL_5.TabIndex = 22
        Me.LBL_5.Text = "Telefone:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TXT_Agencia)
        Me.GroupBox3.Controls.Add(Me.TXT_Conta)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.CMB_Banco)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(653, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 177)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados Bancários:"
        '
        'TXT_Agencia
        '
        Me.TXT_Agencia.Location = New System.Drawing.Point(83, 67)
        Me.TXT_Agencia.Name = "TXT_Agencia"
        Me.TXT_Agencia.Size = New System.Drawing.Size(100, 24)
        Me.TXT_Agencia.TabIndex = 31
        '
        'TXT_Conta
        '
        Me.TXT_Conta.Location = New System.Drawing.Point(83, 117)
        Me.TXT_Conta.Name = "TXT_Conta"
        Me.TXT_Conta.Size = New System.Drawing.Size(100, 24)
        Me.TXT_Conta.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Conta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Agência:"
        '
        'CMB_Banco
        '
        Me.CMB_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Banco.FormattingEnabled = True
        Me.CMB_Banco.Items.AddRange(New Object() {"Banco do Brasil", "Bradesco", "Caixa", "Citibank", "HSBC", "Itaú", "Santander", "Outro"})
        Me.CMB_Banco.Location = New System.Drawing.Point(83, 23)
        Me.CMB_Banco.Name = "CMB_Banco"
        Me.CMB_Banco.Size = New System.Drawing.Size(126, 26)
        Me.CMB_Banco.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Banco:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(470, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(166, 18)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Informações Adicionais:"
        '
        'TXT_InfosAdic
        '
        Me.TXT_InfosAdic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_InfosAdic.Location = New System.Drawing.Point(465, 270)
        Me.TXT_InfosAdic.Multiline = True
        Me.TXT_InfosAdic.Name = "TXT_InfosAdic"
        Me.TXT_InfosAdic.Size = New System.Drawing.Size(407, 123)
        Me.TXT_InfosAdic.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TST_NomeLogado, Me.TXT_Data, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 31)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.OrçamentoToolStripMenuItem, Me.ProdutosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 27)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdimitirToolStripMenuItem, Me.LocalizarToolStripMenuItem})
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'AdimitirToolStripMenuItem
        '
        Me.AdimitirToolStripMenuItem.Name = "AdimitirToolStripMenuItem"
        Me.AdimitirToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.AdimitirToolStripMenuItem.Text = "Admitir"
        Me.AdimitirToolStripMenuItem.ToolTipText = "Cadastrar novo funcionário ao Banco de Dados da Empresa"
        '
        'LocalizarToolStripMenuItem
        '
        Me.LocalizarToolStripMenuItem.Name = "LocalizarToolStripMenuItem"
        Me.LocalizarToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.LocalizarToolStripMenuItem.Text = "Localizar"
        Me.LocalizarToolStripMenuItem.ToolTipText = "Buscar funcionários já cadastrados no Banco de Dados da Empresa"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem1, Me.BuscarToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CadastroToolStripMenuItem1
        '
        Me.CadastroToolStripMenuItem1.Enabled = False
        Me.CadastroToolStripMenuItem1.Name = "CadastroToolStripMenuItem1"
        Me.CadastroToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.CadastroToolStripMenuItem1.Text = "Cadastro"
        Me.CadastroToolStripMenuItem1.ToolTipText = "Cadastrar novo cliente ao Banco de Dados da Empresa"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.BuscarToolStripMenuItem1.Text = "Localizar"
        Me.BuscarToolStripMenuItem1.ToolTipText = "Visualizar os clientes já cadastrados"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaToolStripMenuItem, Me.ProjetosToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'NovaToolStripMenuItem
        '
        Me.NovaToolStripMenuItem.Name = "NovaToolStripMenuItem"
        Me.NovaToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.NovaToolStripMenuItem.Text = "+ Nova"
        Me.NovaToolStripMenuItem.ToolTipText = "Cadastrar uma nova compra de um cliente"
        '
        'ProjetosToolStripMenuItem
        '
        Me.ProjetosToolStripMenuItem.Name = "ProjetosToolStripMenuItem"
        Me.ProjetosToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.ProjetosToolStripMenuItem.Text = "Projetos"
        Me.ProjetosToolStripMenuItem.ToolTipText = "Visualizar projetos em andamento, já comprados pelos clientes"
        '
        'OrçamentoToolStripMenuItem
        '
        Me.OrçamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebSitesToolStripMenuItem, Me.SoftwareDesktopToolStripMenuItem})
        Me.OrçamentoToolStripMenuItem.Name = "OrçamentoToolStripMenuItem"
        Me.OrçamentoToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.OrçamentoToolStripMenuItem.Text = "Orçamento"
        '
        'WebSitesToolStripMenuItem
        '
        Me.WebSitesToolStripMenuItem.Name = "WebSitesToolStripMenuItem"
        Me.WebSitesToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.WebSitesToolStripMenuItem.Text = "Web Sites"
        Me.WebSitesToolStripMenuItem.ToolTipText = "Construir o Wireframe de um WebSite"
        '
        'SoftwareDesktopToolStripMenuItem
        '
        Me.SoftwareDesktopToolStripMenuItem.Name = "SoftwareDesktopToolStripMenuItem"
        Me.SoftwareDesktopToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.SoftwareDesktopToolStripMenuItem.Text = "Software Desktop"
        Me.SoftwareDesktopToolStripMenuItem.ToolTipText = "Construir um wireframe de um Software Desktop"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.LocalizarToolStripMenuItem1})
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.NovoToolStripMenuItem.Text = "+ Novo"
        Me.NovoToolStripMenuItem.ToolTipText = "Adicionar novo produto"
        '
        'LocalizarToolStripMenuItem1
        '
        Me.LocalizarToolStripMenuItem1.Name = "LocalizarToolStripMenuItem1"
        Me.LocalizarToolStripMenuItem1.Size = New System.Drawing.Size(137, 24)
        Me.LocalizarToolStripMenuItem1.Text = "Localizar"
        Me.LocalizarToolStripMenuItem1.ToolTipText = "Visualizar produtos já cadastrados"
        '
        'TST_NomeLogado
        '
        Me.TST_NomeLogado.Enabled = False
        Me.TST_NomeLogado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TST_NomeLogado.Name = "TST_NomeLogado"
        Me.TST_NomeLogado.ReadOnly = True
        Me.TST_NomeLogado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TST_NomeLogado.Size = New System.Drawing.Size(200, 27)
        Me.TST_NomeLogado.ToolTipText = "Usuário Logado "
        '
        'TXT_Data
        '
        Me.TXT_Data.Enabled = False
        Me.TXT_Data.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Data.Name = "TXT_Data"
        Me.TXT_Data.ReadOnly = True
        Me.TXT_Data.Size = New System.Drawing.Size(150, 27)
        Me.TXT_Data.ToolTipText = "Data Atual"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(46, 27)
        Me.SairToolStripMenuItem.Text = "Sair"
        Me.SairToolStripMenuItem.ToolTipText = "Realizar Log Off"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Cadastro_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartWare.My.Resources.Resources._6_all_BG
        Me.ClientSize = New System.Drawing.Size(892, 473)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TXT_InfosAdic)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 500)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "Cadastro_Cliente"
        Me.Text = "Cadastro Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXT_UF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Cidade As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Bairro As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Endereco As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Nome As System.Windows.Forms.TextBox
    Friend WithEvents LBL_4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_Nascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_N_Endereco As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CMB_Banco As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_Agencia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Conta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXT_InfosAdic As System.Windows.Forms.TextBox
    Friend WithEvents MST_Celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MST_TelefoneCom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MST_Telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LBL_5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TXT_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MST_CNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdimitirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjetosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrçamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebSitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalizarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TST_NomeLogado As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TXT_Data As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
