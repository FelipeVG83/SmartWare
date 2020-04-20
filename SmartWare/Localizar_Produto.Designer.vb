<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localizar_Produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Localizar_Produto))
        Me.TXT_Preco = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LBL_Status = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_Desativar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_Alterar = New System.Windows.Forms.Button()
        Me.TXT_Linguagem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RDB_Web = New System.Windows.Forms.RadioButton()
        Me.RDB_Mobile = New System.Windows.Forms.RadioButton()
        Me.RDB_Desktop = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_Preco
        '
        Me.TXT_Preco.Location = New System.Drawing.Point(176, 182)
        Me.TXT_Preco.Name = "TXT_Preco"
        Me.TXT_Preco.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Preco.TabIndex = 79
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(371, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 35)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Alterar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LBL_Status
        '
        Me.LBL_Status.AutoSize = True
        Me.LBL_Status.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Status.Location = New System.Drawing.Point(425, 40)
        Me.LBL_Status.Name = "LBL_Status"
        Me.LBL_Status.Size = New System.Drawing.Size(0, 16)
        Me.LBL_Status.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Status"
        '
        'BTN_Desativar
        '
        Me.BTN_Desativar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BTN_Desativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Desativar.Location = New System.Drawing.Point(371, 69)
        Me.BTN_Desativar.Name = "BTN_Desativar"
        Me.BTN_Desativar.Size = New System.Drawing.Size(131, 35)
        Me.BTN_Desativar.TabIndex = 75
        Me.BTN_Desativar.Text = "Desativar"
        Me.BTN_Desativar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Preço (por Licença):"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Novo"})
        Me.ComboBox1.Location = New System.Drawing.Point(90, 276)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 24)
        Me.ComboBox1.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Pacote:"
        '
        'BTN_Alterar
        '
        Me.BTN_Alterar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BTN_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Alterar.Location = New System.Drawing.Point(111, 322)
        Me.BTN_Alterar.Name = "BTN_Alterar"
        Me.BTN_Alterar.Size = New System.Drawing.Size(317, 41)
        Me.BTN_Alterar.TabIndex = 70
        Me.BTN_Alterar.Text = "Alterar"
        Me.BTN_Alterar.UseVisualStyleBackColor = False
        Me.BTN_Alterar.Visible = False
        '
        'TXT_Linguagem
        '
        Me.TXT_Linguagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Linguagem.Location = New System.Drawing.Point(116, 234)
        Me.TXT_Linguagem.Name = "TXT_Linguagem"
        Me.TXT_Linguagem.Size = New System.Drawing.Size(217, 22)
        Me.TXT_Linguagem.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Linguagem:"
        '
        'RDB_Web
        '
        Me.RDB_Web.AutoSize = True
        Me.RDB_Web.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Web.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_Web.Location = New System.Drawing.Point(108, 139)
        Me.RDB_Web.Name = "RDB_Web"
        Me.RDB_Web.Size = New System.Drawing.Size(55, 20)
        Me.RDB_Web.TabIndex = 67
        Me.RDB_Web.TabStop = True
        Me.RDB_Web.Text = "Web"
        Me.RDB_Web.UseVisualStyleBackColor = False
        '
        'RDB_Mobile
        '
        Me.RDB_Mobile.AutoSize = True
        Me.RDB_Mobile.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Mobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_Mobile.Location = New System.Drawing.Point(108, 116)
        Me.RDB_Mobile.Name = "RDB_Mobile"
        Me.RDB_Mobile.Size = New System.Drawing.Size(67, 20)
        Me.RDB_Mobile.TabIndex = 66
        Me.RDB_Mobile.TabStop = True
        Me.RDB_Mobile.Text = "Mobile"
        Me.RDB_Mobile.UseVisualStyleBackColor = False
        '
        'RDB_Desktop
        '
        Me.RDB_Desktop.AutoSize = True
        Me.RDB_Desktop.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Desktop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_Desktop.Location = New System.Drawing.Point(108, 93)
        Me.RDB_Desktop.Name = "RDB_Desktop"
        Me.RDB_Desktop.Size = New System.Drawing.Size(77, 20)
        Me.RDB_Desktop.TabIndex = 65
        Me.RDB_Desktop.TabStop = True
        Me.RDB_Desktop.Text = "Desktop"
        Me.RDB_Desktop.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Categoria:"
        '
        'TXT_Nome
        '
        Me.TXT_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Nome.Location = New System.Drawing.Point(81, 41)
        Me.TXT_Nome.Name = "TXT_Nome"
        Me.TXT_Nome.Size = New System.Drawing.Size(252, 22)
        Me.TXT_Nome.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Nome:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TST_NomeLogado, Me.TXT_Data, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(538, 31)
        Me.MenuStrip1.TabIndex = 80
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
        Me.AdimitirToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AdimitirToolStripMenuItem.Text = "Admitir"
        Me.AdimitirToolStripMenuItem.ToolTipText = "Cadastrar novo funcionário ao Banco de Dados da Empresa"
        '
        'LocalizarToolStripMenuItem
        '
        Me.LocalizarToolStripMenuItem.Name = "LocalizarToolStripMenuItem"
        Me.LocalizarToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
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
        Me.CadastroToolStripMenuItem1.Name = "CadastroToolStripMenuItem1"
        Me.CadastroToolStripMenuItem1.Size = New System.Drawing.Size(137, 24)
        Me.CadastroToolStripMenuItem1.Text = "Cadastro"
        Me.CadastroToolStripMenuItem1.ToolTipText = "Cadastrar novo cliente ao Banco de Dados da Empresa"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(137, 24)
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
        Me.NovaToolStripMenuItem.Enabled = False
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
        'Localizar_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartWare.My.Resources.Resources._6_all_BG
        Me.ClientSize = New System.Drawing.Size(538, 382)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TXT_Preco)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBL_Status)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTN_Desativar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_Alterar)
        Me.Controls.Add(Me.TXT_Linguagem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RDB_Web)
        Me.Controls.Add(Me.RDB_Mobile)
        Me.Controls.Add(Me.RDB_Desktop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Nome)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 409)
        Me.MinimumSize = New System.Drawing.Size(546, 409)
        Me.Name = "Localizar_Produto"
        Me.Text = "Localizar_Produto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_Preco As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LBL_Status As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTN_Desativar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_Alterar As System.Windows.Forms.Button
    Friend WithEvents TXT_Linguagem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RDB_Web As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_Mobile As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_Desktop As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
