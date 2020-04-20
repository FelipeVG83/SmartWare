Imports MySql.Data.MySqlClient
Public Class Localizar_Funcionario
    Dim Login, Senha, Nome, CPF, Nascimento, Email, Telefone, Celular, CEP, Endereco, N_Endereco, Bairro, Cidade, UF, CT, Serie_CT, Data_Admissao, Cargo, Salario, Depto, Ramal, Banco, Agencia, Conta, Infos_Adic, Status, UsuarioBloqueado As String
    Dim Alterar As Boolean
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_AlterarCadastro.Click
        Alterar = True
        TXTNome.ReadOnly = False
        TXT_Email.ReadOnly = False
        TXT_CPF.ReadOnly = False
        TXT_Nascimento.ReadOnly = False
        TXT_Telefone.ReadOnly = False
        TXT_Celular.ReadOnly = False
        TXT_CEP.ReadOnly = False
        TXT_Endereco.ReadOnly = False
        TXT_N_Endereco.ReadOnly = False
        TXT_Bairro.ReadOnly = False
        TXT_Cidade.ReadOnly = False
        TXT_UF.ReadOnly = False
        TXT_CT.ReadOnly = False
        TXT_SerieCT.ReadOnly = False
        TXT_DataAdmissao.ReadOnly = False
        TXT_CargoFunc.ReadOnly = False
        TXT_Salario.ReadOnly = False
        TXT_DeptoFunc.ReadOnly = False
        TXT_RamalFunc.ReadOnly = False
        TXT_AgenciaFunc.ReadOnly = False
        TXT_ContaFunc.ReadOnly = False
        TXT_InfoAdicionais.ReadOnly = False
        BTN_Alterar.Visible = True
        BTN_AlterarCadastro.Visible = False

    End Sub

    Private Sub Localizar_Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)

        Alterar = False
        Dim comando As New MySqlCommand("select * from Funcionarios where Cod_Funcionario = @Cod_Funcionario", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Cod_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Cod_Funcionario").Value = NomeF
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read

            TXTNome.Text = dr("Nome_Funcionario")
            TXT_CPF.Text = dr("CPF_Funcionario")
            TXT_Email.Text = dr("Email_Funcionario")
            TXT_Nascimento.Text = dr("Nascimento_Funcionario")
            TXT_Telefone.Text = dr("Telefone_Funcionario")
            TXT_Celular.Text = dr("Celular_Funcionario")
            TXT_CEP.Text = dr("CEP_Funcionario")
            TXT_Endereco.Text = dr("Endereco_Funcionario")
            TXT_N_Endereco.Text = dr("N_Endereco_Funcionario")
            TXT_Bairro.Text = dr("Bairro_Funcionario")
            TXT_Cidade.Text = dr("Cidade_Funcionario")
            TXT_UF.Text = dr("UF_Funcionario")
            TXT_CT.Text = dr("CT_Funcionario")
            TXT_SerieCT.Text = dr("Serie_CT_Funcionario")
            TXT_DataAdmissao.Text = dr("Data_Admissao_Funcionario")
            TXT_CargoFunc.Text = dr("Cargo_Funcionario")
            TXT_Salario.Text = dr("Salario_Funcionario")
            TXT_DeptoFunc.Text = dr("Depto_Funcionario")
            TXT_RamalFunc.Text = dr("Ramal_Funcionario")
            CMB_BancoFunc.SelectedItem = dr("Banco_Funcionario")
            TXT_AgenciaFunc.Text = dr("Agencia_Funcionario")
            TXT_ContaFunc.Text = dr("Conta_Funcionario")
            LBL_Status.Text = dr("Status_Funcionario")
            CMB_StatusFunc.SelectedItem = dr("Status_Funcionario")
            TXT_InfoAdicionais.Text = dr("Infos_Adic_Funcionario")
            TXT_Login.Text = dr("Login_Funcionario")


            Login = dr("Login_Funcionario")
            Nome = dr("Nome_Funcionario")
            CPF = dr("CPF_Funcionario")
            Email = dr("Email_Funcionario")
            Nascimento = dr("Nascimento_Funcionario")
            Telefone = dr("Telefone_Funcionario")
            Celular = dr("Celular_Funcionario")
            CEP = dr("CEP_Funcionario")
            Endereco = dr("Endereco_Funcionario")
            N_Endereco = dr("N_Endereco_Funcionario")
            Bairro = dr("Bairro_Funcionario")
            Cidade = dr("Cidade_Funcionario")
            UF = dr("UF_Funcionario")
            Banco = dr("Banco_Funcionario")
            Agencia = dr("Agencia_Funcionario")
            Conta = dr("Conta_Funcionario")
            Infos_Adic = dr("Infos_Adic_Funcionario")
            CT = dr("CT_Funcionario")
            Serie_CT = dr("Serie_CT_Funcionario")
            Data_Admissao = dr("Data_Admissao_Funcionario")
            Cargo = dr("Cargo_Funcionario")
            Salario = dr("Salario_Funcionario")
            Depto = dr("Depto_Funcionario")
            Ramal = dr("Ramal_Funcionario")
            UsuarioBloqueado = dr("Login_Bloqueado_Funcionario")
        End While
        FecharBD()
        dr.Close()
        If (LBL_Status.Text = "Inativo") Then
            BTN_Demitir.Text = "Funcionario Demitido"
            BTN_Demitir.Enabled = False
        Else
            BTN_Demitir.Text = "Excluir Funcionario"
            BTN_Demitir.Enabled = True
        End If
        If (UsuarioBloqueado = "Bloqueado") Then
            LBL_UsuarioBloqueado.Visible = True

        End If
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
        End Try
        If (TXT_Endereco.Text = "") Then
            MessageBox.Show("CEP não encontrado! Tente novamente!", "Busca de CEP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            TXT_N_Endereco.ReadOnly = False
            TXT_N_Endereco.Focus()
        End If
    End Sub

    'Ao clicar duas vezes no campo, este apagar a informação
    Private Sub TXT_Nome_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Nome.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Nome.Text = ""
        End If
    End Sub

    Private Sub TXT_Email_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Email.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Email.Text = ""
        End If
    End Sub

    Private Sub TXT_CPF_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_CPF.Clear()
        End If
    End Sub

    Private Sub TXT_N_Endereco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_N_Endereco.MouseDoubleClick
        If (Alterar = True) Then
            TXT_N_Endereco.Text = ""
        End If
    End Sub

    Private Sub TXT_Cidade_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Cidade.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Cidade.Text = ""
        End If
    End Sub

    Private Sub TXT_UF_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_UF.MouseDoubleClick
        If (Alterar = True) Then
            TXT_UF.Text = ""
        End If
    End Sub

    Private Sub TXT_Bairro_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Bairro.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Bairro.Text = ""
        End If

    End Sub

    Private Sub TXT_Endereco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Endereco.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Endereco.Text = ""
        End If
    End Sub

    Private Sub TXT_CEP_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_CEP.MouseDoubleClick
        If (Alterar = True) Then
            TXT_CEP.Clear()
        End If
    End Sub

    Private Sub TXT_ContaFunc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_ContaFunc.MouseDoubleClick
        If (Alterar = True) Then
            TXT_ContaFunc.Text = ""
        End If
    End Sub

    Private Sub TXT_Nascimento_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Nascimento.Clear()
        End If
    End Sub

    Private Sub MST_Celular_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Celular.Clear()
        End If
    End Sub

    Private Sub MST_Telefone_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Telefone.Clear()
        End If
    End Sub

    Private Sub TXT_AgenciaFunc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_AgenciaFunc.MouseDoubleClick
        If (Alterar = True) Then
            TXT_AgenciaFunc.Text = ""
        End If
    End Sub

    Private Sub TXT_InfoAdicionais_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_InfoAdicionais.MouseDoubleClick
        If (Alterar = True) Then
            TXT_InfoAdicionais.Text = ""
        End If
    End Sub

    'Voltar a informação inicial, caso a informação no campo não seja alterada

    Private Sub TXT_Nome_LostFocus(sender As Object, e As EventArgs) Handles TXT_Nome.LostFocus
        If (TXT_Nome.Text = "") Then
            TXT_Nome.Text = Nome
        End If
    End Sub

    Private Sub TXT_CPF_LostFocus(sender As Object, e As EventArgs)
        If (TXT_CPF.Text = "") Then
            TXT_CPF.Text = CPF
        End If
    End Sub

    Private Sub TXT_Nascimento_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Nascimento.Text = "") Then
            TXT_Nascimento.Text = Nascimento
        End If
    End Sub

    Private Sub TXT_Email_LostFocus(sender As Object, e As EventArgs) Handles TXT_Email.LostFocus
        If (TXT_Email.Text = "") Then
            TXT_Email.Text = Email
        End If
    End Sub

    Private Sub TXT_Telefone_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Telefone.Text = "") Then
            TXT_Telefone.Text = Telefone
        End If
    End Sub

    Private Sub TXT_Celular_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Celular.Text = "") Then
            TXT_Celular.Text = Celular
        End If
    End Sub

    Private Sub TXT_CEP_LostFocus(sender As Object, e As EventArgs) Handles TXT_CEP.LostFocus
        If (TXT_CEP.Text = "") Then
            TXT_CEP.Text = CEP
        End If
    End Sub

    Private Sub TXT_Endereco_LostFocus(sender As Object, e As EventArgs) Handles TXT_Endereco.LostFocus
        If (TXT_Endereco.Text = "") Then
            TXT_Endereco.Text = Endereco
        End If
    End Sub

    Private Sub TXT_N_Endereco_LostFocus(sender As Object, e As EventArgs) Handles TXT_N_Endereco.LostFocus
        If (TXT_Endereco.Text = "") Then
            TXT_N_Endereco.Text = N_Endereco
        End If
    End Sub

    Private Sub TXT_Bairro_LostFocus(sender As Object, e As EventArgs) Handles TXT_Bairro.LostFocus
        If (TXT_Bairro.Text = "") Then
            TXT_Bairro.Text = Bairro
        End If
    End Sub

    Private Sub TXT_Cidade_LostFocus(sender As Object, e As EventArgs) Handles TXT_Cidade.LostFocus
        If (TXT_Cidade.Text = "") Then
            TXT_Cidade.Text = Cidade
        End If
    End Sub

    Private Sub TXT_UF_LostFocus(sender As Object, e As EventArgs) Handles TXT_UF.LostFocus
        If (TXT_UF.Text = "") Then
            TXT_UF.Text = UF
        End If
    End Sub

    Private Sub TXT_CT_LostFocus(sender As Object, e As EventArgs) Handles TXT_CT.LostFocus
        If (TXT_CT.Text = "") Then
            TXT_CT.Text = CT
        End If
    End Sub

    Private Sub TXT_SerieCT_LostFocus(sender As Object, e As EventArgs) Handles TXT_SerieCT.LostFocus
        If (TXT_SerieCT.Text = "") Then
            TXT_SerieCT.Text = Serie_CT
        End If
    End Sub
   
    Private Sub TXT_DataAdmissao_LostFocus(sender As Object, e As EventArgs) Handles TXT_DataAdmissao.LostFocus
        If (TXT_DataAdmissao.Text = "") Then
            TXT_DataAdmissao.Text = Data_Admissao
        End If
    End Sub
   
    Private Sub TXT_CargoFunc_LostFocus(sender As Object, e As EventArgs) Handles TXT_CargoFunc.LostFocus
        If (TXT_CargoFunc.Text = "") Then
            TXT_CargoFunc.Text = Cargo
        End If
    End Sub

    Private Sub TXT_Salario_LostFocus(sender As Object, e As EventArgs) Handles TXT_Salario.LostFocus
        If (TXT_Salario.Text = "") Then
            TXT_Salario.Text = Salario
        End If
    End Sub

    Private Sub TXT_DeptoFunc_LostFocus(sender As Object, e As EventArgs) Handles TXT_DeptoFunc.LostFocus
        If (TXT_DeptoFunc.Text = "") Then
            TXT_DeptoFunc.Text = Depto
        End If
    End Sub

    Private Sub TXT_RamalFunc_LostFocus(sender As Object, e As EventArgs) Handles TXT_RamalFunc.LostFocus
        If (TXT_RamalFunc.Text = "") Then
            TXT_RamalFunc.Text = Ramal
        End If
    End Sub

    Private Sub TXT_AgenciaFunc_LostFocus(sender As Object, e As EventArgs) Handles TXT_AgenciaFunc.LostFocus
        If (TXT_AgenciaFunc.Text = "") Then
            TXT_AgenciaFunc.Text = Agencia
        End If
    End Sub

    Private Sub TXT_ContaFunc_LostFocus(sender As Object, e As EventArgs) Handles TXT_ContaFunc.LostFocus
        If (TXT_ContaFunc.Text = "") Then
            TXT_ContaFunc.Text = Conta
        End If
    End Sub

    Private Sub TXT_InfoAdicionais_LostFocus(sender As Object, e As EventArgs) Handles TXT_InfoAdicionais.LostFocus
        If (TXT_InfoAdicionais.Text = "") Then
            TXT_InfoAdicionais.Text = Infos_Adic
        End If
    End Sub

    Private Sub LBL_UsuarioBloqueado_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBL_UsuarioBloqueado.LinkClicked
        If (MessageBox.Show("Deseja desbloquear o usuário do funcionário", "Desbloquear Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Dim comando2 As New MySqlCommand("Update Funcionarios set Login_Bloqueado_Funcionario=@Login_Bloqueado_Funcionario where Login_Funcionario=@Login_Funcionario", Conexao)
            AbrirBD()
            comando2.Parameters.Add("@Login_Bloqueado_Funcionario", MySqlDbType.VarChar)
            comando2.Parameters("@Login_Bloqueado_Funcionario").Value = "Desbloqueado"

            comando2.Parameters.Add("@Login_Funcionario", MySqlDbType.VarChar)
            comando2.Parameters("@Login_Funcionario").Value = TXT_Login.Text

            Try
                comando2.ExecuteNonQuery()
                MessageBox.Show("Usuário desbloqueado com sucesso!", "Desbloqueio do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LBL_UsuarioBloqueado.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro ao desbloquear Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LBL_UsuarioBloqueado.Visible = True
            Finally
                FecharBD()
            End Try
        End If
    End Sub

    Private Sub BTN_Alterar_Click(sender As Object, e As EventArgs) Handles BTN_Alterar.Click
        Dim comando As New MySqlCommand("Update Funcionarios set Nome_Funcionario = @Nome_Funcionario, CPF_Funcionario = @CPF_Funcionario, Nascimento_Funcionario = @Nascimento_Funcionario, Email_Funcionario = @Email_Funcionario,  Telefone_Funcionario = @Telefone_Funcionario, Celular_Funcionario = @Celular_Funcionario, CEP_Funcionario = @CEP_Funcionario, Endereco_Funcionario = @Endereco_Funcionario,  N_Endereco_Funcionario = @N_Endereco_Funcionario, Bairro_Funcionario = @Bairro_Funcionario, Cidade_Funcionario = @Cidade_Funcionario, UF_Funcionario = UF_Funcionario, CT_Funcionario = @CT_Funcionario, Serie_CT_Funcionario = @Serie_CT_Funcionario, Data_Admissao_Funcionario = @Data_Admissao_Funcionario, Cargo_Funcionario = @Cargo_Funcionario, Salario_Funcionario = @Salario_Funcionario, Depto_Funcionario = @Depto_Funcionario, Ramal_Funcionario = @Ramal_Funcionario, Banco_Funcionario = @Banco_Funcionario, Agencia_Funcionario = @Agencia_Funcionario, Conta_Funcionario = @Conta_Funcionario, Infos_Adic_Funcionario = @Infos_Adic_Funcionario, Status_Funcionario = @Status_Funcionario where Nome_Funcionario=@Nome_Funcionario", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Funcionario").Value = TXTNome.Text

        comando.Parameters.Add("@CPF_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@CPF_Funcionario").Value = TXT_CPF.Text

        comando.Parameters.Add("@Nascimento_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Nascimento_Funcionario").Value = TXT_Nascimento.Text

        comando.Parameters.Add("@Email_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Email_Funcionario").Value = TXT_Email.Text

        comando.Parameters.Add("@Telefone_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Funcionario").Value = TXT_Telefone.Text

        comando.Parameters.Add("@Celular_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Celular_Funcionario").Value = TXT_Celular.Text

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
        comando.Parameters("@CT_Funcionario").Value = TXT_CT.Text

        comando.Parameters.Add("@Serie_CT_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Serie_CT_Funcionario").Value = TXT_SerieCT.Text

        comando.Parameters.Add("@Data_Admissao_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Data_Admissao_Funcionario").Value = TXT_DataAdmissao.Text

        comando.Parameters.Add("@Cargo_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Cargo_Funcionario").Value = TXT_CargoFunc.Text

        comando.Parameters.Add("@Salario_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Salario_Funcionario").Value = TXT_Salario.Text

        comando.Parameters.Add("@Depto_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Depto_Funcionario").Value = TXT_DeptoFunc.Text

        comando.Parameters.Add("@Ramal_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Ramal_Funcionario").Value = TXT_RamalFunc.Text

        comando.Parameters.Add("@Banco_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Banco_Funcionario").Value = CMB_BancoFunc.SelectedItem

        comando.Parameters.Add("@Agencia_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Agencia_Funcionario").Value = TXT_AgenciaFunc.Text

        comando.Parameters.Add("@Conta_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Conta_Funcionario").Value = TXT_ContaFunc.Text

        comando.Parameters.Add("@Infos_Adic_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Infos_Adic_Funcionario").Value = TXT_InfoAdicionais.Text

        comando.Parameters.Add("@Status_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Status_Funcionario").Value = CMB_StatusFunc.SelectedItem

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Deu certo! Alteramos o cadastro :)")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub BTN_Demitir_Click(sender As Object, e As EventArgs) Handles BTN_Demitir.Click
        If (LBL_Status.Text = "Ativo") Then
            If (MessageBox.Show("Deseja mesmo desligar o Funcionário da nossa empresa", "Demitir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim comando As New MySqlCommand("Update Funcionarios set Status_Funcionario=@Status_Funcionario where Nome_Funcionario=@Nome_Funcionario", Conexao)
                AbrirBD()

                comando.Parameters.Add("@Nome_Funcionario", MySqlDbType.VarChar)
                comando.Parameters("@nome_Funcionario").Value = TXTNome.Text

                comando.Parameters.Add("@Status_Funcionario", MySqlDbType.VarChar)
                comando.Parameters("@Status_Funcionario").Value = "Inativo"

                Try
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Desligamento do Funcionário elaborado com sucesso!", "Demitir Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LBL_Status.Text = "Inativo"
                    BTN_Demitir.Text = "Incluir Funcionario"
                Catch ex As Exception
                    MessageBox.Show("Erro ao desligar o Funcionario da empresa! Tente novamente!", "Demitir Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    FecharBD()
                End Try
            End If
        Else
            BTN_Demitir.Enabled = False
            BTN_Demitir.Text = "Demitido"
        End If
    End Sub

    'Menu

    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub

    Private Sub WebSitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class