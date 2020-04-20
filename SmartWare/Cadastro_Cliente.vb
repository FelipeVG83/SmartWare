Imports MySql.Data.MySqlClient
Public Class Cadastro_Cliente
    Dim outroBanco As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", TXT_CEP.Text)
            ds.ReadXml(xml)
            TXT_Endereco.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            TXT_Bairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            TXT_Cidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            TXT_UF.Text = ds.Tables(0).Rows(0)("uf").ToString()
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar o CEP! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If (TXT_Endereco.Text = "") Then
            MessageBox.Show("CEP não encontrado! Tente novamente!", "Busca de CEP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            TXT_N_Endereco.ReadOnly = False
            TXT_N_Endereco.Focus()
        End If
    End Sub

    Private Sub Cadastro_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim palavras As String() = Nome.Split(New Char() {" "c})
        'TST_NomeLogado.Text = palavras(0) & " " & palavras(palavras.Length - 1)


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TXT_Endereco.ReadOnly = False
        TXT_N_Endereco.ReadOnly = False
        TXT_Bairro.ReadOnly = False
        TXT_Cidade.ReadOnly = False
        TXT_UF.ReadOnly = False
    End Sub


    Private Sub CMB_Banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_Banco.SelectedIndexChanged
        If (CMB_Banco.SelectedItem = "Outro") Then
            outroBanco = InputBox("Digite o nome do Banco: ", "Outro Banco")
            CMB_Banco.Items.Add(outroBanco)
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comando As New MySqlCommand("Insert into Clientes (Nome_Cliente, CPF_Cliente, Email_Cliente, Data_Nasc_Cliente, Telefone_Cliente, Telefone_Com_Cliente, Celular_Cliente, CEP_Cliente, Endereco_Cliente, N_Endereco_Cliente, Bairro_Cliente, Cidade_Cliente, UF_Cliente, Banco_Cliente, Agencia_Cliente, Conta_Cliente, Infos_Adic_Cliente, Status_Cliente, Empresa_Cliente, CNPJ_Cliente) values (@Nome_Cliente, @CPF_Cliente, @Email_Cliente, @Data_Nasc_Cliente, @Telefone_Cliente, @Telefone_Com_Cliente, @Celular_Cliente, @CEP_Cliente, @Endereco_Cliente, @N_Endereco_Cliente, @Bairro_Cliente, @Cidade_Cliente, @UF_Cliente, @Banco_Cliente, @Agencia_Cliente, @Conta_Cliente, @Infos_Adic_Cliente, @Status_Cliente, @Empresa_Cliente, @CNPJ_Cliente)", Conexao)
        AbrirBD()

        comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Cliente").Value = TXT_Nome.Text

        comando.Parameters.Add("@CPF_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@CPF_Cliente").Value = TXT_CPF.Text

        comando.Parameters.Add("@Email_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Email_Cliente").Value = TXT_Email.Text

        comando.Parameters.Add("@Data_Nasc_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Data_Nasc_Cliente").Value = TXT_Nascimento.Text

        comando.Parameters.Add("@Telefone_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Cliente").Value = MST_Telefone.Text()

        comando.Parameters.Add("@Telefone_Com_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Com_Cliente").Value = MST_TelefoneCom.Text

        comando.Parameters.Add("@Celular_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Celular_Cliente").Value = MST_Celular.Text

        comando.Parameters.Add("@CEP_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@CEP_Cliente").Value = TXT_CEP.Text

        comando.Parameters.Add("@Endereco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Endereco_Cliente").Value = TXT_Endereco.Text

        comando.Parameters.Add("@N_Endereco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@N_Endereco_Cliente").Value = TXT_N_Endereco.Text

        comando.Parameters.Add("@Bairro_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Bairro_Cliente").Value = TXT_Bairro.Text

        comando.Parameters.Add("@Cidade_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Cidade_Cliente").Value = TXT_Cidade.Text

        comando.Parameters.Add("@UF_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@UF_Cliente").Value = TXT_UF.Text

        comando.Parameters.Add("@Banco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Banco_Cliente").Value = CMB_Banco.Text

        comando.Parameters.Add("@Agencia_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Agencia_Cliente").Value = TXT_Agencia.Text

        comando.Parameters.Add("@Conta_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Conta_Cliente").Value = TXT_Conta.Text

        comando.Parameters.Add("@Infos_Adic_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Infos_Adic_Cliente").Value = TXT_InfosAdic.Text

        comando.Parameters.Add("@Status_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Status_Cliente").Value = "Ativo"

        comando.Parameters.Add("@Empresa_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Empresa_Cliente").Value = TXT_Empresa.Text

        comando.Parameters.Add("@CNPJ_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@CNPJ_Cliente").Value = MST_CNPJ.Text
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Cliente Cadastrado com sucesso!", "Cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao cadastrar o Cliente." & ex.Message, "Cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub TXT_Nome_DoubleClick(sender As Object, e As EventArgs) Handles TXT_Nome.DoubleClick
        TXT_Nome.Text = ""
    End Sub

    'Menu

    Private Sub Menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub AdimitirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub
    Private Sub WebSitesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub SairToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class