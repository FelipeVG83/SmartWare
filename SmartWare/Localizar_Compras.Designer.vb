﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localizar_Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Localizar_Compras))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TXT_Busca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBL_Ate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todos", "Nome do Cliente", "Previsão de Entrega"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'TXT_Busca
        '
        Me.TXT_Busca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Busca.Location = New System.Drawing.Point(206, 62)
        Me.TXT_Busca.Name = "TXT_Busca"
        Me.TXT_Busca.Size = New System.Drawing.Size(335, 22)
        Me.TXT_Busca.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Busca:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(635, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 117)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(815, 341)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Nome do Cliente"
        Me.ColumnHeader1.Width = 339
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 0
        Me.ColumnHeader3.Text = "Código"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Data de Entrega"
        Me.ColumnHeader7.Width = 162
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Preço Total"
        Me.ColumnHeader6.Width = 94
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = ""
        '
        'LBL_Ate
        '
        Me.LBL_Ate.AutoSize = True
        Me.LBL_Ate.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Ate.Location = New System.Drawing.Point(206, 65)
        Me.LBL_Ate.Name = "LBL_Ate"
        Me.LBL_Ate.Size = New System.Drawing.Size(28, 16)
        Me.LBL_Ate.TabIndex = 15
        Me.LBL_Ate.Text = "Até"
        Me.LBL_Ate.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(240, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 16
        Me.DateTimePicker1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TST_NomeLogado, Me.TXT_Data, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 31)
        Me.MenuStrip1.TabIndex = 43
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
        Me.NovaToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NovaToolStripMenuItem.Text = "+ Nova"
        Me.NovaToolStripMenuItem.ToolTipText = "Cadastrar uma nova compra de um cliente"
        '
        'ProjetosToolStripMenuItem
        '
        Me.ProjetosToolStripMenuItem.Enabled = False
        Me.ProjetosToolStripMenuItem.Name = "ProjetosToolStripMenuItem"
        Me.ProjetosToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
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
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NovoToolStripMenuItem.Text = "+ Novo"
        Me.NovoToolStripMenuItem.ToolTipText = "Adicionar novo produto"
        '
        'LocalizarToolStripMenuItem1
        '
        Me.LocalizarToolStripMenuItem1.Name = "LocalizarToolStripMenuItem1"
        Me.LocalizarToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
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
        'Localizar_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartWare.My.Resources.Resources._6_all_BG
        Me.ClientSize = New System.Drawing.Size(850, 470)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LBL_Ate)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TXT_Busca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(858, 497)
        Me.MinimumSize = New System.Drawing.Size(858, 497)
        Me.Name = "Localizar_Compras"
        Me.Text = "Localizar Compras"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Busca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LBL_Ate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
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
