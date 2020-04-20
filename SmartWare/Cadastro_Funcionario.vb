Imports MySql.Data.MySqlClient
Public Class Cadastro_Funcionario

    Private Sub BTN_Cadastrar_Click(sender As Object, e As EventArgs) Handles BTN_Cadastrar.Click
        Dim login As String() = TXTNome.Text.Split(New Char() {" "c})

        Dim comando As New MySqlCommand("Insert into Funcionarios (Login_Funcionario, Senha_Funcionario, Nome_Funcionario, CPF_Funcionario, Nascimento_Funcionario, Email_Funcionario, Telefone_Funcionario, Celular_Funcionario, CEP_Funcionario, Endereco_Funcionario, N_Endereco_Funcionario, Bairro_Funcionario, Cidade_Funcionario, UF_Funcionario, CT_Funcionario, Serie_CT_Funcionario, Data_Admissao_Funcionario, Cargo_Funcionario, Salario_Funcionario, Depto_Funcionario, Ramal_Funcionario, Banco_Funcionario, Agencia_Funcionario, Conta_Funcionario, Infos_Adic_Funcionario, Status_Funcionario, Login_Bloqueado_Funcionario) values (@Login_Funcionario, @Senha_Funcionario, @Nome_Funcionario, @CPF_Funcionario, @Nascimento_Funcionario, @Email_Funcionario, @Telefone_Funcionario, @Celular_Funcionario, @CEP_Funcionario, @Endereco_Funcionario, @N_Endereco_Funcionario, @Bairro_Funcionario, @Cidade_Funcionario, @UF_Funcionario, @CT_Funcionario, @Serie_CT_Funcionario, @Data_Admissao_Funcionario, @Cargo_Funcionario, @Salario_Funcionario, @Depto_Funcionario, @Ramal_Funcionario, @Banco_Funcionario, @Agencia_Funcionario, @Conta_Funcionario, @Infos_Adic_Funcionario, @Status_Funcionario, 'Desbloqueado')", Conexao)
        AbrirBD()

        comando.Parameters.Add("@Login_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Login_Funcionario").Value = login(0) & "." & login(login.Length - 1)

        comando.Parameters.Add("@Senha_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Senha_Funcionario").Value = login(0) & "!@"

        comando.Parameters.Add("@Nome_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Funcionario").Value = TXTNome.Text

        comando.Parameters.Add("@CPF_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@CPF_Funcionario").Value = TXT_CPF.Text

        comando.Parameters.Add("@Nascimento_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Nascimento_Funcionario").Value = TXT_Nascimento.Text

        comando.Parameters.Add("@Email_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Email_Funcionario").Value = TXT_Email.Text

        comando.Parameters.Add("@Telefone_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Funcionario").Value = MST_Telefone.Text()

        comando.Parameters.Add("@Celular_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Celular_Funcionario").Value = MST_Celular.Text

        comando.Parameters.Add("@CEP_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@CEP_Funcionario").Value = TXT_CEP.Text

        comando.Parameters.Add("@Endereco_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Endereco_Funcionario").Value = TXT_Endereco.Text

        comando.Parameters.Add("@N_Endereco_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@N_Endereco_Funcionario").Value = TXT_N_Endereco.Text

        comando.Parameters.Add("@Bairro_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Bairro_Funcionario").Value = TXT_Bairro.Text

        comando.Parameters.Add("@Cidade_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Cidade_Funcionario").Value = TXT_Cidade.Text

        comando.Parameters.Add("@UF_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@UF_Funcionario").Value = TXT_UF.Text

        comando.Parameters.Add("@CT_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@CT_Funcionario").Value = MST_CarteiraTrabalho.Text

        comando.Parameters.Add("@Serie_CT_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Serie_CT_Funcionario").Value = MST_SerieCateiraTrabalho.Text

        comando.Parameters.Add("@Data_Admissao_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Data_Admissao_Funcionario").Value = MST_DataAdmissaoFunc.Text

        comando.Parameters.Add("@Cargo_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Cargo_Funcionario").Value = TXT_CargoFunc.Text

        comando.Parameters.Add("@Salario_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Salario_Funcionario").Value = MST_SalarioFunc.Text

        comando.Parameters.Add("@Depto_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Depto_Funcionario").Value = CMB_Depto.Text

        comando.Parameters.Add("@Ramal_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Ramal_Funcionario").Value = TXT_RamalFunc.Text

        comando.Parameters.Add("@Banco_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Banco_Funcionario").Value = CMB_BancoFunc.Text

        comando.Parameters.Add("@Agencia_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Agencia_Funcionario").Value = TXT_AgenciaFunc.Text

        comando.Parameters.Add("@Conta_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Conta_Funcionario").Value = TXT_ContaFunc.Text

        comando.Parameters.Add("@Infos_Adic_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Infos_Adic_Funcionario").Value = TXT_InfoAdic_Func.Text

        comando.Parameters.Add("@Status_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Status_Funcionario").Value = "Ativo"

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Funcionário Cadastrado com sucesso!", "Cadastrar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao cadastrar o Funcionário." & ex.Message, "Cadastrar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

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
            TXT_CEP.Clear()
            TXT_CEP.Focus()
        End Try

        If (TXT_Endereco.Text = "") Then
            MessageBox.Show("CEP não encontrado! Tente novamente!", "Busca de CEP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            TXT_N_Endereco.ReadOnly = False
            TXT_N_Endereco.Focus()
        End If
    End Sub

   
    'Menu

    Private Sub Menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

     Private Sub BuscarToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
    End Sub
    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub
    Private Sub WebSitesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
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