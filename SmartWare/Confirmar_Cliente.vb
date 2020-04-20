Imports MySql.Data.MySqlClient
Public Class Confirmar_Cliente

    Private Sub Confirmar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
        Confirma = False
        'Dim comando As New MySqlCommand("select * from Clientes where Nome_Cliente = @Nome_Cliente", Conexao)
        'AbrirBD()
        'comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        'comando.Parameters("@Nome_Cliente").Value = NomeC
        'Dim dr As MySqlDataReader
        'dr = comando.ExecuteReader
        'While dr.Read
        '    TXT_Nome.Text = dr("Nome_Cliente")
        '    TXT_CPF.Text = dr("CPF_Cliente")
        '    TXT_Email.Text = dr("Email_Cliente")
        '    TXT_Nascimento.Text = dr("Data_Nasc_Cliente")
        '    TXT_Telefone.Text = dr("Telefone_Cliente")
        '    TXT_TelefoneComercial.Text = dr("Telefone_Com_Cliente")
        '    TXT_Celular.Text = dr("Celular_Cliente")
        '    TXT_CEP.Text = dr("CEP_Cliente")
        '    TXT_Endereco.Text = dr("Endereco_Cliente")
        '    TXT_N_Endereco.Text = dr("N_Endereco_Cliente")
        '    TXT_Bairro.Text = dr("Bairro_Cliente")
        '    TXT_Cidade.Text = dr("Cidade_Cliente")
        '    TXT_UF.Text = dr("UF_Cliente")
        '    CMB_Banco.SelectedItem = dr("Banco_Cliente")
        '    TXT_Agencia.Text = dr("Agencia_Cliente")
        '    TXT_Conta.Text = dr("Conta_Cliente")
        '    LBL_Status.Text = dr("Status_Cliente")
        '    TXT_InfoAdicionais.Text = dr("Infos_Adic_Cliente")
        'End While
        'FecharBD()
        'dr.Close()
    End Sub

    Private Sub BTN_AlterarCadastro_Click(sender As Object, e As EventArgs) Handles BTN_AlterarCadastro.Click
        Confirma = True
        Alterar = True

    End Sub

    Private Sub BTN_Confirmar_Click(sender As Object, e As EventArgs) Handles BTN_Confirmar.Click
        Confirmado = True
        Comprar.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
    End Sub

    Private Sub WebSitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
    End Sub
End Class